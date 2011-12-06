//plati pre nastavenie Timeru 16bit na 2000khz
//casy pre komunikaciu----
#define start 5160      //pre start - 5160              cca 2,5 ms
#define data0 900      //pre ukonceni data - 1160   -   0,5ms
#define data01 900       //ak je bit 0 - 900        -   0,5ms
#define data11 1800     //ak je bit 1 - 1820        -   1 ms
#define rozptyl 300     //casove rozmedzie pre prijem
//------------------------
//nastavenie vstupu a vystupu pre isobot
#define ISOBOT_IN PINC.0
#define ISOBOT_OUT PORTC.1
//------------------podporne funkcie---------------------
//funkcia na kontrolovanie data v rozptyle
char porovnaj(int datax,int datay, int rozptylx){
    if ((((datax-rozptylx) < datay) & ((datax+rozptylx) > datay)) == 1){   return 1; }
    else                                                               {   return 0; }
}  
//-----------------------
//*******************funkcie isobot**********************
//funkcia pre prijem pomocou timer
unsigned char data[4];
void get_isobot(){
    int pocdat;
    int pocdata=22;
error:
    data[0] = 0;
    data[1] = 0;
    data[2] = 0;
    data[3] = 0;
    while(ISOBOT_IN == 1);  //caka na trvalu 1 kvoli chybe nacitaniu v strede dat
//---------- start isobot ------------
    TCNT1 = 0;              //nuluje timer
    while (ISOBOT_IN == 0); //caka na start  
    if (porovnaj(start,TCNT1,rozptyl) == 0)    goto error;    //ak sa cas nezhoduje zo start vracia na error
//------------------------------------
    for(pocdat = 0;pocdat < pocdata;pocdat++){
    //--------------start prijem data jednotlive---------------------
        if ((data[0] & 0x08)== 0x08)    pocdata = 22;
        else                            pocdata = 30;
        TCNT1 = 0;                      //nuluje timer
        while (ISOBOT_IN == 1);         //caka na data
            if (TCNT1 > 1300){
                if (pocdat < 6){
                   data[0] = data[0] | 0x01;  
                }
                else if(pocdat < 14){
                   data[1] = data[1] | 0x01; 
                }
                else if(pocdat < 22){
                   data[2] = data[2] | 0x01; 
                }
                else{
                   data[3] = data[3] | 0x01;   
                }
            } 
            if ((pocdat < 6)&(pocdat!=5)){
                data[0]=data[0]<<1;  
            }
            else if((pocdat < 14)&(pocdat!=13)){
                data[1]=data[1]<<1; 
            }
            else if((pocdat < 22)&(pocdat!=21)){
                data[2]=data[2]<<1;   
            }    
            else if((pocdat < 30)&(pocdat!=29)){
                data[3]=data[3]<<1;   
            }    
    //----------------------------------------------------------------
        TCNT1 = 0;                      //nuluje timer
        while (ISOBOT_IN == 0);        //caka na ukoncenie data
     if (porovnaj(data0,TCNT1,rozptyl) == 0) goto error; //ak sa cas zhoduje pokracuje                                                         
    //----------------------------------------------------------------
    }
}
//------------------------------------------------
//funkcia odosielania do isobota pomocou delay
void send_isobot_delay(unsigned char data[]){
    int pocdat;
    int pocdata=22;
    if((data[0]&0x08)==0x08) pocdata = 22;
    else                     pocdata = 30;
//---------- start isobot ------------
    ISOBOT_OUT = 0;  
    delay_ms(2);
    delay_us(500);
//------------------------------------
    for(pocdat = 0;pocdat < pocdata;pocdat++){
    //--------------start prijem data jednotlive---------------------
        ISOBOT_OUT = 1; 
            if (pocdat < 6){
               if((data[0]&0x20)==0x20){
                    delay_ms(1);
                    delay_us(50);       
               }  
               else{
                    delay_us(550); 
               }
            }
            else if(pocdat < 14){
               if((data[1]&0x80)==0x80){
                    delay_ms(1);
                    delay_us(50);       
               }  
               else{
                    delay_us(550); 
               }
            }
            else if(pocdat < 22){
               if((data[2]&0x80)==0x80){
                    delay_ms(1);
                    delay_us(50);       
               }  
               else{
                    delay_us(550); 
               } 
            } 
            else{
               if((data[3]&0x80)==0x80){
                    delay_ms(1);
                    delay_us(50);       
               }  
               else{
                    delay_us(550); 
               }                   
            }                 
        //--------------------------------
            if ((pocdat < 6)){
                data[0]=data[0]<<1;  
            }
            else if((pocdat < 14)){
                data[1]=data[1]<<1; 
            }
            else if((pocdat < 22)){         
                data[2]=data[2]<<1;   
            }      
            else if((pocdat < 30)){         
                data[3]=data[3]<<1;   
            }                    
    //----------------------------------------------------------------
        ISOBOT_OUT = 0;
        delay_us(550);                                                  
    //----------------------------------------------------------------
    }
    ISOBOT_OUT = 1;
    delay_ms(100);
} 