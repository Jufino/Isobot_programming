/*****************************************************
Chip type           : ATmega8L
Program type        : Application
Clock frequency     : 7,372000 MHz
*****************************************************/

#include <mega8.h>
#include <stdio.h>
#include <delay.h>

#define ADC_VREF_TYPE 0x60

void init_atmega8(){
    // Input/Output Ports initialization
    // Port B initialization
    // Func7=In Func6=In Func5=In Func4=In Func3=In Func2=In Func1=In Func0=In 
    // State7=T State6=T State5=T State4=T State3=T State2=T State1=T State0=T 
    PORTB=0x00;
    DDRB=0x00;

    // Port C initialization
    // Func6=In Func5=In Func4=In Func3=In Func2=In Func1=In Func0=In 
    // State6=T State5=T State4=T State3=T State2=T State1=T State0=T 
    PORTC=0x00;
    DDRC=0x00;

    // Port D initialization
    // Func7=In Func6=In Func5=In Func4=In Func3=Out Func2=Out Func1=In Func0=In 
    // State7=T State6=T State5=T State4=T State3=0 State2=0 State1=T State0=T 
    PORTD=0x00;
    DDRD=0x0C;

    // Timer/Counter 0 initialization
    // Clock source: System Clock
    // Clock value: Timer 0 Stopped
    TCCR0=0x00;
    TCNT0=0x00;

    // Timer/Counter 1 initialization
    // Clock source: System Clock
    // Clock value: Timer 1 Stopped
    // Mode: Normal top=FFFFh
    // OC1A output: Discon.
    // OC1B output: Discon.
    // Noise Canceler: Off
    // Input Capture on Falling Edge
    // Timer 1 Overflow Interrupt: Off
    // Input Capture Interrupt: Off
    // Compare A Match Interrupt: Off
    // Compare B Match Interrupt: Off
    TCCR1A=0x00;
    TCCR1B=0x00;
    TCNT1H=0x00;
    TCNT1L=0x00;
    ICR1H=0x00;
    ICR1L=0x00;
    OCR1AH=0x00;
    OCR1AL=0x00;
    OCR1BH=0x00;
    OCR1BL=0x00;

    // Timer/Counter 2 initialization
    // Clock source: System Clock
    // Clock value: Timer 2 Stopped
    // Mode: Normal top=FFh
    // OC2 output: Disconnected
    ASSR=0x00;
    TCCR2=0x00;
    TCNT2=0x00;
    OCR2=0x00;

    // External Interrupt(s) initialization
    // INT0: Off
    // INT1: Off
    MCUCR=0x00;

    // Timer(s)/Counter(s) Interrupt(s) initialization
    TIMSK=0x00;

    // USART initialization
    // Communication Parameters: 8 Data, 1 Stop, No Parity
    // USART Receiver: On
    // USART Transmitter: On
    // USART Mode: Asynchronous
    // USART Baud Rate: 19200
    UCSRA=0x00;
    UCSRB=0x18;
    UCSRC=0x86;
    UBRRH=0x00;
    UBRRL=0x17;

    // Analog Comparator initialization
    // Analog Comparator: Off
    // Analog Comparator Input Capture by Timer/Counter 1: Off
    ACSR=0x80;
    SFIOR=0x00;

    // ADC initialization
    // ADC Clock frequency: 921,500 kHz
    // ADC Voltage Reference: AVCC pin
    // Only the 8 most significant bits of
    // the AD conversion result are used
    ADMUX=ADC_VREF_TYPE & 0xff;
    ADCSRA=0x83;
}

unsigned char read_adc(unsigned char adc_input)
{
    ADMUX=adc_input | (ADC_VREF_TYPE & 0xff);
    // Delay needed for the stabilization of the ADC input voltage
    delay_us(10);
    // Start the AD conversion
    ADCSRA|=0x40;
    // Wait for the AD conversion to complete
    while ((ADCSRA & 0x10)==0);
    ADCSRA|=0x10;
    return ADCH;
}

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
#define ISOBOT_OUT PORTD.3
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
void send_isobot(unsigned char data[]){
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
unsigned char datax[4];
void main(void)
{
    init_atmega8();
    PORTD.2 =1;
    delay_ms(500);
    PORTD.2 =0;  
    while(getchar() != 'A');
    putchar(5);
    while (1){
        switch(getchar()){
            case 0: datax[0]=getchar();
                    datax[1]=getchar();
                    datax[2]=getchar();
                    datax[3]=getchar();
                    send_isobot(datax);
                    break;
            case 1: DDRC = getchar();       break;
            case 2: DDRB = getchar();       break;
            case 3: PORTB = getchar();      break;
            case 4: putchar(PINB);          break;
            case 5: putchar(read_adc(0));   break;
            case 6: putchar(read_adc(1));   break;
            case 7: putchar(read_adc(2));   break;
            case 8: putchar(read_adc(3));   break;
            case 9: putchar(read_adc(4));   break;
            case 10: putchar(read_adc(5));  break;
            case 11: putchar(PINC);       break;
            case 12: PORTC = getchar();     break;
            case 'A':   putchar(5);         break;
        }
    };
}
