
#pragma used+
sfrb TWBR=0;
sfrb TWSR=1;
sfrb TWAR=2;
sfrb TWDR=3;
sfrb ADCL=4;
sfrb ADCH=5;
sfrw ADCW=4;      
sfrb ADCSRA=6;
sfrb ADMUX=7;
sfrb ACSR=8;
sfrb UBRRL=9;
sfrb UCSRB=0xa;
sfrb UCSRA=0xb;
sfrb UDR=0xc;
sfrb SPCR=0xd;
sfrb SPSR=0xe;
sfrb SPDR=0xf;
sfrb PIND=0x10;
sfrb DDRD=0x11;
sfrb PORTD=0x12;
sfrb PINC=0x13;
sfrb DDRC=0x14;
sfrb PORTC=0x15;
sfrb PINB=0x16;
sfrb DDRB=0x17;
sfrb PORTB=0x18;
sfrb EECR=0x1c;
sfrb EEDR=0x1d;
sfrb EEARL=0x1e;
sfrb EEARH=0x1f;
sfrw EEAR=0x1e;   
sfrb UBRRH=0x20;
sfrb UCSRC=0X20;
sfrb WDTCR=0x21;
sfrb ASSR=0x22;
sfrb OCR2=0x23;
sfrb TCNT2=0x24;
sfrb TCCR2=0x25;
sfrb ICR1L=0x26;
sfrb ICR1H=0x27;
sfrw ICR1=0x26;   
sfrb OCR1BL=0x28;
sfrb OCR1BH=0x29;
sfrw OCR1B=0x28;  
sfrb OCR1AL=0x2a;
sfrb OCR1AH=0x2b;
sfrw OCR1A=0x2a;  
sfrb TCNT1L=0x2c;
sfrb TCNT1H=0x2d;
sfrw TCNT1=0x2c;  
sfrb TCCR1B=0x2e;
sfrb TCCR1A=0x2f;
sfrb SFIOR=0x30;
sfrb OSCCAL=0x31;
sfrb TCNT0=0x32;
sfrb TCCR0=0x33;
sfrb MCUCSR=0x34;
sfrb MCUCR=0x35;
sfrb TWCR=0x36;
sfrb SPMCR=0x37;
sfrb TIFR=0x38;
sfrb TIMSK=0x39;
sfrb GIFR=0x3a;
sfrb GICR=0x3b;
sfrb SPL=0x3d;
sfrb SPH=0x3e;
sfrb SREG=0x3f;
#pragma used-

#asm
	#ifndef __SLEEP_DEFINED__
	#define __SLEEP_DEFINED__
	.EQU __se_bit=0x80
	.EQU __sm_mask=0x70
	.EQU __sm_powerdown=0x20
	.EQU __sm_powersave=0x30
	.EQU __sm_standby=0x60
	.EQU __sm_ext_standby=0x70
	.EQU __sm_adc_noise_red=0x10
	.SET power_ctrl_reg=mcucr
	#endif
#endasm

typedef char *va_list;

#pragma used+

char getchar(void);
void putchar(char c);
void puts(char *str);
void putsf(char flash *str);

char *gets(char *str,unsigned int len);

void printf(char flash *fmtstr,...);
void sprintf(char *str, char flash *fmtstr,...);
void snprintf(char *str, unsigned int size, char flash *fmtstr,...);
void vprintf (char flash * fmtstr, va_list argptr);
void vsprintf (char *str, char flash * fmtstr, va_list argptr);
void vsnprintf (char *str, unsigned int size, char flash * fmtstr, va_list argptr);
signed char scanf(char flash *fmtstr,...);
signed char sscanf(char *str, char flash *fmtstr,...);

#pragma used-

#pragma library stdio.lib

#pragma used+

void delay_us(unsigned int n);
void delay_ms(unsigned int n);

#pragma used-

void init_atmega8(){

PORTB=0x00;
DDRB=0x00;

PORTC=0x00;
DDRC=0x00;

PORTD=0x00;
DDRD=0x0C;

TCCR0=0x00;
TCNT0=0x00;

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

ASSR=0x00;
TCCR2=0x00;
TCNT2=0x00;
OCR2=0x00;

MCUCR=0x00;

TIMSK=0x00;

UCSRA=0x00;
UCSRB=0x18;
UCSRC=0x86;
UBRRH=0x00;
UBRRL=0x17;

ACSR=0x80;
SFIOR=0x00;

ADMUX=0x60 & 0xff;
ADCSRA=0x83;
}

unsigned char read_adc(unsigned char adc_input)
{
ADMUX=adc_input | (0x60 & 0xff);

delay_us(10);

ADCSRA|=0x40;

while ((ADCSRA & 0x10)==0);
ADCSRA|=0x10;
return ADCH;
}

char porovnaj(int datax,int datay, int rozptylx){
if ((((datax-rozptylx) < datay) & ((datax+rozptylx) > datay)) == 1){   return 1; }
else                                                               {   return 0; }
}  

unsigned char data[4];
void get_isobot(){
int pocdat;
int pocdata=22;
error:
data[0] = 0;
data[1] = 0;
data[2] = 0;
data[3] = 0;
while(PINC.0 == 1);  

TCNT1 = 0;              
while (PINC.0 == 0); 
if (porovnaj(5160      ,TCNT1,300     ) == 0)    goto error;    

for(pocdat = 0;pocdat < pocdata;pocdat++){

if ((data[0] & 0x08)== 0x08)    pocdata = 22;
else                            pocdata = 30;
TCNT1 = 0;                      
while (PINC.0 == 1);         
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

TCNT1 = 0;                      
while (PINC.0 == 0);        
if (porovnaj(900      ,TCNT1,300     ) == 0) goto error; 

}
}

void send_isobot(unsigned char data[]){
int pocdat;
int pocdata=22;
if((data[0]&0x08)==0x08) pocdata = 22;
else                     pocdata = 30;

PORTD.3 = 0;  
delay_ms(2);
delay_us(500);

for(pocdat = 0;pocdat < pocdata;pocdat++){

PORTD.3 = 1; 
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

PORTD.3 = 0;
delay_us(550);                                                  

}
PORTD.3 = 1;
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
