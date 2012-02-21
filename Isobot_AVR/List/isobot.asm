
;CodeVisionAVR C Compiler V2.03.4 Standard
;(C) Copyright 1998-2008 Pavel Haiduc, HP InfoTech s.r.l.
;http://www.hpinfotech.com

;Chip type              : ATmega8L
;Program type           : Application
;Clock frequency        : 7,372000 MHz
;Memory model           : Small
;Optimize for           : Size
;(s)printf features     : int, width
;(s)scanf features      : int, width
;External RAM size      : 0
;Data Stack size        : 256 byte(s)
;Heap size              : 0 byte(s)
;Promote char to int    : Yes
;char is unsigned       : Yes
;global const stored in FLASH  : No
;8 bit enums            : Yes
;Enhanced core instructions    : On
;Smart register allocation : On
;Automatic register allocation : On

	#pragma AVRPART ADMIN PART_NAME ATmega8L
	#pragma AVRPART MEMORY PROG_FLASH 8192
	#pragma AVRPART MEMORY EEPROM 512
	#pragma AVRPART MEMORY INT_SRAM SIZE 1024
	#pragma AVRPART MEMORY INT_SRAM START_ADDR 0x60

	.LISTMAC
	.EQU UDRE=0x5
	.EQU RXC=0x7
	.EQU USR=0xB
	.EQU UDR=0xC
	.EQU SPSR=0xE
	.EQU SPDR=0xF
	.EQU EERE=0x0
	.EQU EEWE=0x1
	.EQU EEMWE=0x2
	.EQU EECR=0x1C
	.EQU EEDR=0x1D
	.EQU EEARL=0x1E
	.EQU EEARH=0x1F
	.EQU WDTCR=0x21
	.EQU MCUCR=0x35
	.EQU GICR=0x3B
	.EQU SPL=0x3D
	.EQU SPH=0x3E
	.EQU SREG=0x3F

	.DEF R0X0=R0
	.DEF R0X1=R1
	.DEF R0X2=R2
	.DEF R0X3=R3
	.DEF R0X4=R4
	.DEF R0X5=R5
	.DEF R0X6=R6
	.DEF R0X7=R7
	.DEF R0X8=R8
	.DEF R0X9=R9
	.DEF R0XA=R10
	.DEF R0XB=R11
	.DEF R0XC=R12
	.DEF R0XD=R13
	.DEF R0XE=R14
	.DEF R0XF=R15
	.DEF R0X10=R16
	.DEF R0X11=R17
	.DEF R0X12=R18
	.DEF R0X13=R19
	.DEF R0X14=R20
	.DEF R0X15=R21
	.DEF R0X16=R22
	.DEF R0X17=R23
	.DEF R0X18=R24
	.DEF R0X19=R25
	.DEF R0X1A=R26
	.DEF R0X1B=R27
	.DEF R0X1C=R28
	.DEF R0X1D=R29
	.DEF R0X1E=R30
	.DEF R0X1F=R31

	.MACRO __CPD1N
	CPI  R30,LOW(@0)
	LDI  R26,HIGH(@0)
	CPC  R31,R26
	LDI  R26,BYTE3(@0)
	CPC  R22,R26
	LDI  R26,BYTE4(@0)
	CPC  R23,R26
	.ENDM

	.MACRO __CPD2N
	CPI  R26,LOW(@0)
	LDI  R30,HIGH(@0)
	CPC  R27,R30
	LDI  R30,BYTE3(@0)
	CPC  R24,R30
	LDI  R30,BYTE4(@0)
	CPC  R25,R30
	.ENDM

	.MACRO __CPWRR
	CP   R@0,R@2
	CPC  R@1,R@3
	.ENDM

	.MACRO __CPWRN
	CPI  R@0,LOW(@2)
	LDI  R30,HIGH(@2)
	CPC  R@1,R30
	.ENDM

	.MACRO __ADDB1MN
	SUBI R30,LOW(-@0-(@1))
	.ENDM

	.MACRO __ADDB2MN
	SUBI R26,LOW(-@0-(@1))
	.ENDM

	.MACRO __ADDW1MN
	SUBI R30,LOW(-@0-(@1))
	SBCI R31,HIGH(-@0-(@1))
	.ENDM

	.MACRO __ADDW2MN
	SUBI R26,LOW(-@0-(@1))
	SBCI R27,HIGH(-@0-(@1))
	.ENDM

	.MACRO __ADDW1FN
	SUBI R30,LOW(-2*@0-(@1))
	SBCI R31,HIGH(-2*@0-(@1))
	.ENDM

	.MACRO __ADDD1FN
	SUBI R30,LOW(-2*@0-(@1))
	SBCI R31,HIGH(-2*@0-(@1))
	SBCI R22,BYTE3(-2*@0-(@1))
	.ENDM

	.MACRO __ADDD1N
	SUBI R30,LOW(-@0)
	SBCI R31,HIGH(-@0)
	SBCI R22,BYTE3(-@0)
	SBCI R23,BYTE4(-@0)
	.ENDM

	.MACRO __ADDD2N
	SUBI R26,LOW(-@0)
	SBCI R27,HIGH(-@0)
	SBCI R24,BYTE3(-@0)
	SBCI R25,BYTE4(-@0)
	.ENDM

	.MACRO __SUBD1N
	SUBI R30,LOW(@0)
	SBCI R31,HIGH(@0)
	SBCI R22,BYTE3(@0)
	SBCI R23,BYTE4(@0)
	.ENDM

	.MACRO __SUBD2N
	SUBI R26,LOW(@0)
	SBCI R27,HIGH(@0)
	SBCI R24,BYTE3(@0)
	SBCI R25,BYTE4(@0)
	.ENDM

	.MACRO __ANDBMNN
	LDS  R30,@0+@1
	ANDI R30,LOW(@2)
	STS  @0+@1,R30
	.ENDM

	.MACRO __ANDWMNN
	LDS  R30,@0+@1
	ANDI R30,LOW(@2)
	STS  @0+@1,R30
	LDS  R30,@0+@1+1
	ANDI R30,HIGH(@2)
	STS  @0+@1+1,R30
	.ENDM

	.MACRO __ANDD1N
	ANDI R30,LOW(@0)
	ANDI R31,HIGH(@0)
	ANDI R22,BYTE3(@0)
	ANDI R23,BYTE4(@0)
	.ENDM

	.MACRO __ANDD2N
	ANDI R26,LOW(@0)
	ANDI R27,HIGH(@0)
	ANDI R24,BYTE3(@0)
	ANDI R25,BYTE4(@0)
	.ENDM

	.MACRO __ORBMNN
	LDS  R30,@0+@1
	ORI  R30,LOW(@2)
	STS  @0+@1,R30
	.ENDM

	.MACRO __ORWMNN
	LDS  R30,@0+@1
	ORI  R30,LOW(@2)
	STS  @0+@1,R30
	LDS  R30,@0+@1+1
	ORI  R30,HIGH(@2)
	STS  @0+@1+1,R30
	.ENDM

	.MACRO __ORD1N
	ORI  R30,LOW(@0)
	ORI  R31,HIGH(@0)
	ORI  R22,BYTE3(@0)
	ORI  R23,BYTE4(@0)
	.ENDM

	.MACRO __ORD2N
	ORI  R26,LOW(@0)
	ORI  R27,HIGH(@0)
	ORI  R24,BYTE3(@0)
	ORI  R25,BYTE4(@0)
	.ENDM

	.MACRO __DELAY_USB
	LDI  R24,LOW(@0)
__DELAY_USB_LOOP:
	DEC  R24
	BRNE __DELAY_USB_LOOP
	.ENDM

	.MACRO __DELAY_USW
	LDI  R24,LOW(@0)
	LDI  R25,HIGH(@0)
__DELAY_USW_LOOP:
	SBIW R24,1
	BRNE __DELAY_USW_LOOP
	.ENDM

	.MACRO __CLRD1S
	LDI  R30,0
	STD  Y+@0,R30
	STD  Y+@0+1,R30
	STD  Y+@0+2,R30
	STD  Y+@0+3,R30
	.ENDM

	.MACRO __GETD1S
	LDD  R30,Y+@0
	LDD  R31,Y+@0+1
	LDD  R22,Y+@0+2
	LDD  R23,Y+@0+3
	.ENDM

	.MACRO __PUTD1S
	STD  Y+@0,R30
	STD  Y+@0+1,R31
	STD  Y+@0+2,R22
	STD  Y+@0+3,R23
	.ENDM

	.MACRO __PUTD2S
	STD  Y+@0,R26
	STD  Y+@0+1,R27
	STD  Y+@0+2,R24
	STD  Y+@0+3,R25
	.ENDM

	.MACRO __POINTB1MN
	LDI  R30,LOW(@0+@1)
	.ENDM

	.MACRO __POINTW1MN
	LDI  R30,LOW(@0+@1)
	LDI  R31,HIGH(@0+@1)
	.ENDM

	.MACRO __POINTD1M
	LDI  R30,LOW(@0)
	LDI  R31,HIGH(@0)
	LDI  R22,BYTE3(@0)
	LDI  R23,BYTE4(@0)
	.ENDM

	.MACRO __POINTW1FN
	LDI  R30,LOW(2*@0+@1)
	LDI  R31,HIGH(2*@0+@1)
	.ENDM

	.MACRO __POINTD1FN
	LDI  R30,LOW(2*@0+@1)
	LDI  R31,HIGH(2*@0+@1)
	LDI  R22,BYTE3(2*@0+@1)
	LDI  R23,BYTE4(2*@0+@1)
	.ENDM

	.MACRO __POINTB2MN
	LDI  R26,LOW(@0+@1)
	.ENDM

	.MACRO __POINTW2MN
	LDI  R26,LOW(@0+@1)
	LDI  R27,HIGH(@0+@1)
	.ENDM

	.MACRO __POINTBRM
	LDI  R@0,LOW(@1)
	.ENDM

	.MACRO __POINTWRM
	LDI  R@0,LOW(@2)
	LDI  R@1,HIGH(@2)
	.ENDM

	.MACRO __POINTBRMN
	LDI  R@0,LOW(@1+@2)
	.ENDM

	.MACRO __POINTWRMN
	LDI  R@0,LOW(@2+@3)
	LDI  R@1,HIGH(@2+@3)
	.ENDM

	.MACRO __POINTWRFN
	LDI  R@0,LOW(@2*2+@3)
	LDI  R@1,HIGH(@2*2+@3)
	.ENDM

	.MACRO __GETD1N
	LDI  R30,LOW(@0)
	LDI  R31,HIGH(@0)
	LDI  R22,BYTE3(@0)
	LDI  R23,BYTE4(@0)
	.ENDM

	.MACRO __GETD2N
	LDI  R26,LOW(@0)
	LDI  R27,HIGH(@0)
	LDI  R24,BYTE3(@0)
	LDI  R25,BYTE4(@0)
	.ENDM

	.MACRO __GETD2S
	LDD  R26,Y+@0
	LDD  R27,Y+@0+1
	LDD  R24,Y+@0+2
	LDD  R25,Y+@0+3
	.ENDM

	.MACRO __GETB1MN
	LDS  R30,@0+@1
	.ENDM

	.MACRO __GETB1HMN
	LDS  R31,@0+@1
	.ENDM

	.MACRO __GETW1MN
	LDS  R30,@0+@1
	LDS  R31,@0+@1+1
	.ENDM

	.MACRO __GETD1MN
	LDS  R30,@0+@1
	LDS  R31,@0+@1+1
	LDS  R22,@0+@1+2
	LDS  R23,@0+@1+3
	.ENDM

	.MACRO __GETBRMN
	LDS  R@0,@1+@2
	.ENDM

	.MACRO __GETWRMN
	LDS  R@0,@2+@3
	LDS  R@1,@2+@3+1
	.ENDM

	.MACRO __GETWRZ
	LDD  R@0,Z+@2
	LDD  R@1,Z+@2+1
	.ENDM

	.MACRO __GETD2Z
	LDD  R26,Z+@0
	LDD  R27,Z+@0+1
	LDD  R24,Z+@0+2
	LDD  R25,Z+@0+3
	.ENDM

	.MACRO __GETB2MN
	LDS  R26,@0+@1
	.ENDM

	.MACRO __GETW2MN
	LDS  R26,@0+@1
	LDS  R27,@0+@1+1
	.ENDM

	.MACRO __GETD2MN
	LDS  R26,@0+@1
	LDS  R27,@0+@1+1
	LDS  R24,@0+@1+2
	LDS  R25,@0+@1+3
	.ENDM

	.MACRO __PUTB1MN
	STS  @0+@1,R30
	.ENDM

	.MACRO __PUTW1MN
	STS  @0+@1,R30
	STS  @0+@1+1,R31
	.ENDM

	.MACRO __PUTD1MN
	STS  @0+@1,R30
	STS  @0+@1+1,R31
	STS  @0+@1+2,R22
	STS  @0+@1+3,R23
	.ENDM

	.MACRO __PUTB1EN
	LDI  R26,LOW(@0+@1)
	LDI  R27,HIGH(@0+@1)
	RCALL __EEPROMWRB
	.ENDM

	.MACRO __PUTW1EN
	LDI  R26,LOW(@0+@1)
	LDI  R27,HIGH(@0+@1)
	RCALL __EEPROMWRW
	.ENDM

	.MACRO __PUTD1EN
	LDI  R26,LOW(@0+@1)
	LDI  R27,HIGH(@0+@1)
	RCALL __EEPROMWRD
	.ENDM

	.MACRO __PUTBR0MN
	STS  @0+@1,R0
	.ENDM

	.MACRO __PUTDZ2
	STD  Z+@0,R26
	STD  Z+@0+1,R27
	STD  Z+@0+2,R24
	STD  Z+@0+3,R25
	.ENDM

	.MACRO __PUTBMRN
	STS  @0+@1,R@2
	.ENDM

	.MACRO __PUTWMRN
	STS  @0+@1,R@2
	STS  @0+@1+1,R@3
	.ENDM

	.MACRO __PUTBZR
	STD  Z+@1,R@0
	.ENDM

	.MACRO __PUTWZR
	STD  Z+@2,R@0
	STD  Z+@2+1,R@1
	.ENDM

	.MACRO __GETW1R
	MOV  R30,R@0
	MOV  R31,R@1
	.ENDM

	.MACRO __GETW2R
	MOV  R26,R@0
	MOV  R27,R@1
	.ENDM

	.MACRO __GETWRN
	LDI  R@0,LOW(@2)
	LDI  R@1,HIGH(@2)
	.ENDM

	.MACRO __PUTW1R
	MOV  R@0,R30
	MOV  R@1,R31
	.ENDM

	.MACRO __PUTW2R
	MOV  R@0,R26
	MOV  R@1,R27
	.ENDM

	.MACRO __ADDWRN
	SUBI R@0,LOW(-@2)
	SBCI R@1,HIGH(-@2)
	.ENDM

	.MACRO __ADDWRR
	ADD  R@0,R@2
	ADC  R@1,R@3
	.ENDM

	.MACRO __SUBWRN
	SUBI R@0,LOW(@2)
	SBCI R@1,HIGH(@2)
	.ENDM

	.MACRO __SUBWRR
	SUB  R@0,R@2
	SBC  R@1,R@3
	.ENDM

	.MACRO __ANDWRN
	ANDI R@0,LOW(@2)
	ANDI R@1,HIGH(@2)
	.ENDM

	.MACRO __ANDWRR
	AND  R@0,R@2
	AND  R@1,R@3
	.ENDM

	.MACRO __ORWRN
	ORI  R@0,LOW(@2)
	ORI  R@1,HIGH(@2)
	.ENDM

	.MACRO __ORWRR
	OR   R@0,R@2
	OR   R@1,R@3
	.ENDM

	.MACRO __EORWRR
	EOR  R@0,R@2
	EOR  R@1,R@3
	.ENDM

	.MACRO __GETWRS
	LDD  R@0,Y+@2
	LDD  R@1,Y+@2+1
	.ENDM

	.MACRO __PUTWSR
	STD  Y+@2,R@0
	STD  Y+@2+1,R@1
	.ENDM

	.MACRO __MOVEWRR
	MOV  R@0,R@2
	MOV  R@1,R@3
	.ENDM

	.MACRO __INWR
	IN   R@0,@2
	IN   R@1,@2+1
	.ENDM

	.MACRO __OUTWR
	OUT  @2+1,R@1
	OUT  @2,R@0
	.ENDM

	.MACRO __CALL1MN
	LDS  R30,@0+@1
	LDS  R31,@0+@1+1
	ICALL
	.ENDM

	.MACRO __CALL1FN
	LDI  R30,LOW(2*@0+@1)
	LDI  R31,HIGH(2*@0+@1)
	RCALL __GETW1PF
	ICALL
	.ENDM

	.MACRO __CALL2EN
	LDI  R26,LOW(@0+@1)
	LDI  R27,HIGH(@0+@1)
	RCALL __EEPROMRDW
	ICALL
	.ENDM

	.MACRO __GETW1STACK
	IN   R26,SPL
	IN   R27,SPH
	ADIW R26,@0+1
	LD   R30,X+
	LD   R31,X
	.ENDM

	.MACRO __NBST
	BST  R@0,@1
	IN   R30,SREG
	LDI  R31,0x40
	EOR  R30,R31
	OUT  SREG,R30
	.ENDM


	.MACRO __PUTB1SN
	LDD  R26,Y+@0
	LDD  R27,Y+@0+1
	SUBI R26,LOW(-@1)
	SBCI R27,HIGH(-@1)
	ST   X,R30
	.ENDM

	.MACRO __PUTW1SN
	LDD  R26,Y+@0
	LDD  R27,Y+@0+1
	SUBI R26,LOW(-@1)
	SBCI R27,HIGH(-@1)
	ST   X+,R30
	ST   X,R31
	.ENDM

	.MACRO __PUTD1SN
	LDD  R26,Y+@0
	LDD  R27,Y+@0+1
	SUBI R26,LOW(-@1)
	SBCI R27,HIGH(-@1)
	RCALL __PUTDP1
	.ENDM

	.MACRO __PUTB1SNS
	LDD  R26,Y+@0
	LDD  R27,Y+@0+1
	ADIW R26,@1
	ST   X,R30
	.ENDM

	.MACRO __PUTW1SNS
	LDD  R26,Y+@0
	LDD  R27,Y+@0+1
	ADIW R26,@1
	ST   X+,R30
	ST   X,R31
	.ENDM

	.MACRO __PUTD1SNS
	LDD  R26,Y+@0
	LDD  R27,Y+@0+1
	ADIW R26,@1
	RCALL __PUTDP1
	.ENDM

	.MACRO __PUTB1PMN
	LDS  R26,@0
	LDS  R27,@0+1
	SUBI R26,LOW(-@1)
	SBCI R27,HIGH(-@1)
	ST   X,R30
	.ENDM

	.MACRO __PUTW1PMN
	LDS  R26,@0
	LDS  R27,@0+1
	SUBI R26,LOW(-@1)
	SBCI R27,HIGH(-@1)
	ST   X+,R30
	ST   X,R31
	.ENDM

	.MACRO __PUTD1PMN
	LDS  R26,@0
	LDS  R27,@0+1
	SUBI R26,LOW(-@1)
	SBCI R27,HIGH(-@1)
	RCALL __PUTDP1
	.ENDM

	.MACRO __PUTB1PMNS
	LDS  R26,@0
	LDS  R27,@0+1
	ADIW R26,@1
	ST   X,R30
	.ENDM

	.MACRO __PUTW1PMNS
	LDS  R26,@0
	LDS  R27,@0+1
	ADIW R26,@1
	ST   X+,R30
	ST   X,R31
	.ENDM

	.MACRO __PUTD1PMNS
	LDS  R26,@0
	LDS  R27,@0+1
	ADIW R26,@1
	RCALL __PUTDP1
	.ENDM

	.MACRO __PUTB1RN
	MOVW R26,R@0
	SUBI R26,LOW(-@1)
	SBCI R27,HIGH(-@1)
	ST   X,R30
	.ENDM

	.MACRO __PUTW1RN
	MOVW R26,R@0
	SUBI R26,LOW(-@1)
	SBCI R27,HIGH(-@1)
	ST   X+,R30
	ST   X,R31
	.ENDM

	.MACRO __PUTD1RN
	MOVW R26,R@0
	SUBI R26,LOW(-@1)
	SBCI R27,HIGH(-@1)
	RCALL __PUTDP1
	.ENDM

	.MACRO __PUTB1RNS
	MOVW R26,R@0
	ADIW R26,@1
	ST   X,R30
	.ENDM

	.MACRO __PUTW1RNS
	MOVW R26,R@0
	ADIW R26,@1
	ST   X+,R30
	ST   X,R31
	.ENDM

	.MACRO __PUTD1RNS
	MOVW R26,R@0
	ADIW R26,@1
	RCALL __PUTDP1
	.ENDM

	.MACRO __PUTB1RON
	MOV  R26,R@0
	MOV  R27,R@1
	SUBI R26,LOW(-@2)
	SBCI R27,HIGH(-@2)
	ST   X,R30
	.ENDM

	.MACRO __PUTW1RON
	MOV  R26,R@0
	MOV  R27,R@1
	SUBI R26,LOW(-@2)
	SBCI R27,HIGH(-@2)
	ST   X+,R30
	ST   X,R31
	.ENDM

	.MACRO __PUTD1RON
	MOV  R26,R@0
	MOV  R27,R@1
	SUBI R26,LOW(-@2)
	SBCI R27,HIGH(-@2)
	RCALL __PUTDP1
	.ENDM

	.MACRO __PUTB1RONS
	MOV  R26,R@0
	MOV  R27,R@1
	ADIW R26,@2
	ST   X,R30
	.ENDM

	.MACRO __PUTW1RONS
	MOV  R26,R@0
	MOV  R27,R@1
	ADIW R26,@2
	ST   X+,R30
	ST   X,R31
	.ENDM

	.MACRO __PUTD1RONS
	MOV  R26,R@0
	MOV  R27,R@1
	ADIW R26,@2
	RCALL __PUTDP1
	.ENDM


	.MACRO __GETB1SX
	MOVW R30,R28
	SUBI R30,LOW(-@0)
	SBCI R31,HIGH(-@0)
	LD   R30,Z
	.ENDM

	.MACRO __GETB1HSX
	MOVW R30,R28
	SUBI R30,LOW(-@0)
	SBCI R31,HIGH(-@0)
	LD   R31,Z
	.ENDM

	.MACRO __GETW1SX
	MOVW R30,R28
	SUBI R30,LOW(-@0)
	SBCI R31,HIGH(-@0)
	LD   R0,Z+
	LD   R31,Z
	MOV  R30,R0
	.ENDM

	.MACRO __GETD1SX
	MOVW R30,R28
	SUBI R30,LOW(-@0)
	SBCI R31,HIGH(-@0)
	LD   R0,Z+
	LD   R1,Z+
	LD   R22,Z+
	LD   R23,Z
	MOVW R30,R0
	.ENDM

	.MACRO __GETB2SX
	MOVW R26,R28
	SUBI R26,LOW(-@0)
	SBCI R27,HIGH(-@0)
	LD   R26,X
	.ENDM

	.MACRO __GETW2SX
	MOVW R26,R28
	SUBI R26,LOW(-@0)
	SBCI R27,HIGH(-@0)
	LD   R0,X+
	LD   R27,X
	MOV  R26,R0
	.ENDM

	.MACRO __GETD2SX
	MOVW R26,R28
	SUBI R26,LOW(-@0)
	SBCI R27,HIGH(-@0)
	LD   R0,X+
	LD   R1,X+
	LD   R24,X+
	LD   R25,X
	MOVW R26,R0
	.ENDM

	.MACRO __GETBRSX
	MOVW R30,R28
	SUBI R30,LOW(-@1)
	SBCI R31,HIGH(-@1)
	LD   R@0,Z
	.ENDM

	.MACRO __GETWRSX
	MOVW R30,R28
	SUBI R30,LOW(-@2)
	SBCI R31,HIGH(-@2)
	LD   R@0,Z+
	LD   R@1,Z
	.ENDM

	.MACRO __LSLW8SX
	MOVW R30,R28
	SUBI R30,LOW(-@0)
	SBCI R31,HIGH(-@0)
	LD   R31,Z
	CLR  R30
	.ENDM

	.MACRO __PUTB1SX
	MOVW R26,R28
	SUBI R26,LOW(-@0)
	SBCI R27,HIGH(-@0)
	ST   X,R30
	.ENDM

	.MACRO __PUTW1SX
	MOVW R26,R28
	SUBI R26,LOW(-@0)
	SBCI R27,HIGH(-@0)
	ST   X+,R30
	ST   X,R31
	.ENDM

	.MACRO __PUTD1SX
	MOVW R26,R28
	SUBI R26,LOW(-@0)
	SBCI R27,HIGH(-@0)
	ST   X+,R30
	ST   X+,R31
	ST   X+,R22
	ST   X,R23
	.ENDM

	.MACRO __CLRW1SX
	MOVW R30,R28
	SUBI R30,LOW(-@0)
	SBCI R31,HIGH(-@0)
	CLR  R0
	ST   Z+,R0
	ST   Z,R0
	.ENDM

	.MACRO __CLRD1SX
	MOVW R30,R28
	SUBI R30,LOW(-@0)
	SBCI R31,HIGH(-@0)
	CLR  R0
	ST   Z+,R0
	ST   Z+,R0
	ST   Z+,R0
	ST   Z,R0
	.ENDM

	.MACRO __PUTB2SX
	MOVW R30,R28
	SUBI R30,LOW(-@0)
	SBCI R31,HIGH(-@0)
	ST   Z,R26
	.ENDM

	.MACRO __PUTW2SX
	MOVW R30,R28
	SUBI R30,LOW(-@0)
	SBCI R31,HIGH(-@0)
	ST   Z+,R26
	ST   Z,R27
	.ENDM

	.MACRO __PUTD2SX
	MOVW R30,R28
	SUBI R30,LOW(-@0)
	SBCI R31,HIGH(-@0)
	ST   Z+,R26
	ST   Z+,R27
	ST   Z+,R24
	ST   Z,R25
	.ENDM

	.MACRO __PUTBSRX
	MOVW R30,R28
	SUBI R30,LOW(-@0)
	SBCI R31,HIGH(-@0)
	ST   Z,R@1
	.ENDM

	.MACRO __PUTWSRX
	MOVW R30,R28
	SUBI R30,LOW(-@2)
	SBCI R31,HIGH(-@2)
	ST   Z+,R@0
	ST   Z,R@1
	.ENDM

	.MACRO __PUTB1SNX
	MOVW R26,R28
	SUBI R26,LOW(-@0)
	SBCI R27,HIGH(-@0)
	LD   R0,X+
	LD   R27,X
	MOV  R26,R0
	SUBI R26,LOW(-@1)
	SBCI R27,HIGH(-@1)
	ST   X,R30
	.ENDM

	.MACRO __PUTW1SNX
	MOVW R26,R28
	SUBI R26,LOW(-@0)
	SBCI R27,HIGH(-@0)
	LD   R0,X+
	LD   R27,X
	MOV  R26,R0
	SUBI R26,LOW(-@1)
	SBCI R27,HIGH(-@1)
	ST   X+,R30
	ST   X,R31
	.ENDM

	.MACRO __PUTD1SNX
	MOVW R26,R28
	SUBI R26,LOW(-@0)
	SBCI R27,HIGH(-@0)
	LD   R0,X+
	LD   R27,X
	MOV  R26,R0
	SUBI R26,LOW(-@1)
	SBCI R27,HIGH(-@1)
	ST   X+,R30
	ST   X+,R31
	ST   X+,R22
	ST   X,R23
	.ENDM

	.MACRO __MULBRR
	MULS R@0,R@1
	MOVW R30,R0
	.ENDM

	.MACRO __MULBRRU
	MUL  R@0,R@1
	MOVW R30,R0
	.ENDM

	.MACRO __MULBRR0
	MULS R@0,R@1
	.ENDM

	.MACRO __MULBRRU0
	MUL  R@0,R@1
	.ENDM

	.MACRO __MULBNWRU
	LDI  R26,@2
	MUL  R26,R@0
	MOVW R30,R0
	MUL  R26,R@1
	ADD  R31,R0
	.ENDM

	.CSEG
	.ORG 0x00

;INTERRUPT VECTORS
	RJMP __RESET
	RJMP 0x00
	RJMP 0x00
	RJMP 0x00
	RJMP 0x00
	RJMP 0x00
	RJMP 0x00
	RJMP 0x00
	RJMP 0x00
	RJMP 0x00
	RJMP 0x00
	RJMP 0x00
	RJMP 0x00
	RJMP 0x00
	RJMP 0x00
	RJMP 0x00
	RJMP 0x00
	RJMP 0x00
	RJMP 0x00

_tbl10_G100:
	.DB  0x10,0x27,0xE8,0x3,0x64,0x0,0xA,0x0
	.DB  0x1,0x0
_tbl16_G100:
	.DB  0x0,0x10,0x0,0x1,0x10,0x0,0x1,0x0

__RESET:
	CLI
	CLR  R30
	OUT  EECR,R30

;INTERRUPT VECTORS ARE PLACED
;AT THE START OF FLASH
	LDI  R31,1
	OUT  GICR,R31
	OUT  GICR,R30
	OUT  MCUCR,R30

;DISABLE WATCHDOG
	LDI  R31,0x18
	OUT  WDTCR,R31
	OUT  WDTCR,R30

;CLEAR R2-R14
	LDI  R24,(14-2)+1
	LDI  R26,2
	CLR  R27
__CLEAR_REG:
	ST   X+,R30
	DEC  R24
	BRNE __CLEAR_REG

;CLEAR SRAM
	LDI  R24,LOW(0x400)
	LDI  R25,HIGH(0x400)
	LDI  R26,0x60
__CLEAR_SRAM:
	ST   X+,R30
	SBIW R24,1
	BRNE __CLEAR_SRAM

;STACK POINTER INITIALIZATION
	LDI  R30,LOW(0x45F)
	OUT  SPL,R30
	LDI  R30,HIGH(0x45F)
	OUT  SPH,R30

;DATA STACK POINTER INITIALIZATION
	LDI  R28,LOW(0x160)
	LDI  R29,HIGH(0x160)

	RJMP _main

	.ESEG
	.ORG 0

	.DSEG
	.ORG 0x160

	.CSEG
;/*****************************************************
;Chip type           : ATmega8L
;Program type        : Application
;Clock frequency     : 7,372000 MHz
;*****************************************************/
;
;#include <mega8.h>
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
;#include <stdio.h>
;#include <delay.h>
;
;#define ADC_VREF_TYPE 0x60
;
;void init_atmega8(){
; 0000 000D void init_atmega8(){

	.CSEG
_init_atmega8:
; 0000 000E     // Input/Output Ports initialization
; 0000 000F     // Port B initialization
; 0000 0010     // Func7=In Func6=In Func5=In Func4=In Func3=In Func2=In Func1=In Func0=In
; 0000 0011     // State7=T State6=T State5=T State4=T State3=T State2=T State1=T State0=T
; 0000 0012     PORTB=0x00;
	LDI  R30,LOW(0)
	OUT  0x18,R30
; 0000 0013     DDRB=0x00;
	OUT  0x17,R30
; 0000 0014 
; 0000 0015     // Port C initialization
; 0000 0016     // Func6=In Func5=In Func4=In Func3=In Func2=In Func1=In Func0=In
; 0000 0017     // State6=T State5=T State4=T State3=T State2=T State1=T State0=T
; 0000 0018     PORTC=0x00;
	OUT  0x15,R30
; 0000 0019     DDRC=0x00;
	OUT  0x14,R30
; 0000 001A 
; 0000 001B     // Port D initialization
; 0000 001C     // Func7=In Func6=In Func5=In Func4=In Func3=Out Func2=Out Func1=In Func0=In
; 0000 001D     // State7=T State6=T State5=T State4=T State3=0 State2=0 State1=T State0=T
; 0000 001E     PORTD=0x00;
	OUT  0x12,R30
; 0000 001F     DDRD=0x0C;
	LDI  R30,LOW(12)
	OUT  0x11,R30
; 0000 0020 
; 0000 0021     // Timer/Counter 0 initialization
; 0000 0022     // Clock source: System Clock
; 0000 0023     // Clock value: Timer 0 Stopped
; 0000 0024     TCCR0=0x00;
	LDI  R30,LOW(0)
	OUT  0x33,R30
; 0000 0025     TCNT0=0x00;
	OUT  0x32,R30
; 0000 0026 
; 0000 0027     // Timer/Counter 1 initialization
; 0000 0028     // Clock source: System Clock
; 0000 0029     // Clock value: Timer 1 Stopped
; 0000 002A     // Mode: Normal top=FFFFh
; 0000 002B     // OC1A output: Discon.
; 0000 002C     // OC1B output: Discon.
; 0000 002D     // Noise Canceler: Off
; 0000 002E     // Input Capture on Falling Edge
; 0000 002F     // Timer 1 Overflow Interrupt: Off
; 0000 0030     // Input Capture Interrupt: Off
; 0000 0031     // Compare A Match Interrupt: Off
; 0000 0032     // Compare B Match Interrupt: Off
; 0000 0033     TCCR1A=0x00;
	OUT  0x2F,R30
; 0000 0034     TCCR1B=0x00;
	OUT  0x2E,R30
; 0000 0035     TCNT1H=0x00;
	OUT  0x2D,R30
; 0000 0036     TCNT1L=0x00;
	OUT  0x2C,R30
; 0000 0037     ICR1H=0x00;
	OUT  0x27,R30
; 0000 0038     ICR1L=0x00;
	OUT  0x26,R30
; 0000 0039     OCR1AH=0x00;
	OUT  0x2B,R30
; 0000 003A     OCR1AL=0x00;
	OUT  0x2A,R30
; 0000 003B     OCR1BH=0x00;
	OUT  0x29,R30
; 0000 003C     OCR1BL=0x00;
	OUT  0x28,R30
; 0000 003D 
; 0000 003E     // Timer/Counter 2 initialization
; 0000 003F     // Clock source: System Clock
; 0000 0040     // Clock value: Timer 2 Stopped
; 0000 0041     // Mode: Normal top=FFh
; 0000 0042     // OC2 output: Disconnected
; 0000 0043     ASSR=0x00;
	OUT  0x22,R30
; 0000 0044     TCCR2=0x00;
	OUT  0x25,R30
; 0000 0045     TCNT2=0x00;
	OUT  0x24,R30
; 0000 0046     OCR2=0x00;
	OUT  0x23,R30
; 0000 0047 
; 0000 0048     // External Interrupt(s) initialization
; 0000 0049     // INT0: Off
; 0000 004A     // INT1: Off
; 0000 004B     MCUCR=0x00;
	OUT  0x35,R30
; 0000 004C 
; 0000 004D     // Timer(s)/Counter(s) Interrupt(s) initialization
; 0000 004E     TIMSK=0x00;
	OUT  0x39,R30
; 0000 004F 
; 0000 0050     // USART initialization
; 0000 0051     // Communication Parameters: 8 Data, 1 Stop, No Parity
; 0000 0052     // USART Receiver: On
; 0000 0053     // USART Transmitter: On
; 0000 0054     // USART Mode: Asynchronous
; 0000 0055     // USART Baud Rate: 19200
; 0000 0056     UCSRA=0x00;
	OUT  0xB,R30
; 0000 0057     UCSRB=0x18;
	LDI  R30,LOW(24)
	OUT  0xA,R30
; 0000 0058     UCSRC=0x86;
	LDI  R30,LOW(134)
	OUT  0x20,R30
; 0000 0059     UBRRH=0x00;
	LDI  R30,LOW(0)
	OUT  0x20,R30
; 0000 005A     UBRRL=0x17;
	LDI  R30,LOW(23)
	OUT  0x9,R30
; 0000 005B 
; 0000 005C     // Analog Comparator initialization
; 0000 005D     // Analog Comparator: Off
; 0000 005E     // Analog Comparator Input Capture by Timer/Counter 1: Off
; 0000 005F     ACSR=0x80;
	LDI  R30,LOW(128)
	OUT  0x8,R30
; 0000 0060     SFIOR=0x00;
	LDI  R30,LOW(0)
	OUT  0x30,R30
; 0000 0061 
; 0000 0062     // ADC initialization
; 0000 0063     // ADC Clock frequency: 921,500 kHz
; 0000 0064     // ADC Voltage Reference: AVCC pin
; 0000 0065     // Only the 8 most significant bits of
; 0000 0066     // the AD conversion result are used
; 0000 0067     ADMUX=ADC_VREF_TYPE & 0xff;
	LDI  R30,LOW(96)
	OUT  0x7,R30
; 0000 0068     ADCSRA=0x83;
	LDI  R30,LOW(131)
	OUT  0x6,R30
; 0000 0069 }
	RET
;
;unsigned char read_adc(unsigned char adc_input)
; 0000 006C {
_read_adc:
; 0000 006D     ADMUX=adc_input | (ADC_VREF_TYPE & 0xff);
;	adc_input -> Y+0
	LD   R30,Y
	RCALL SUBOPT_0x0
	ORI  R30,LOW(0x60)
	OUT  0x7,R30
; 0000 006E     // Delay needed for the stabilization of the ADC input voltage
; 0000 006F     delay_us(10);
	__DELAY_USB 25
; 0000 0070     // Start the AD conversion
; 0000 0071     ADCSRA|=0x40;
	IN   R30,0x6
	RCALL SUBOPT_0x0
	ORI  R30,0x40
	OUT  0x6,R30
; 0000 0072     // Wait for the AD conversion to complete
; 0000 0073     while ((ADCSRA & 0x10)==0);
_0x3:
	IN   R30,0x6
	RCALL SUBOPT_0x0
	ANDI R30,LOW(0x10)
	BREQ _0x3
; 0000 0074     ADCSRA|=0x10;
	IN   R30,0x6
	RCALL SUBOPT_0x0
	ORI  R30,0x10
	OUT  0x6,R30
; 0000 0075     return ADCH;
	IN   R30,0x5
	RJMP _0x2060001
; 0000 0076 }
;
;//plati pre nastavenie Timeru 16bit na 2000khz
;//casy pre komunikaciu----
;#define start 5160      //pre start - 5160              cca 2,5 ms
;#define data0 900      //pre ukonceni data - 1160   -   0,5ms
;#define data01 900       //ak je bit 0 - 900        -   0,5ms
;#define data11 1800     //ak je bit 1 - 1820        -   1 ms
;#define rozptyl 300     //casove rozmedzie pre prijem
;//------------------------
;//nastavenie vstupu a vystupu pre isobot
;#define ISOBOT_IN PINC.0
;#define ISOBOT_OUT PORTD.3
;//------------------podporne funkcie---------------------
;//funkcia na kontrolovanie data v rozptyle
;char porovnaj(int datax,int datay, int rozptylx){
; 0000 0085 char porovnaj(int datax,int datay, int rozptylx){
; 0000 0086     if ((((datax-rozptylx) < datay) & ((datax+rozptylx) > datay)) == 1){   return 1; }
;	datax -> Y+4
;	datay -> Y+2
;	rozptylx -> Y+0
; 0000 0087     else                                                               {   return 0; }
; 0000 0088 }
;//-----------------------
;//*******************funkcie isobot**********************
;//funkcia pre prijem pomocou timer
;unsigned char data[4];
;void get_isobot(){
; 0000 008D void get_isobot(){
; 0000 008E     int pocdat;
; 0000 008F     int pocdata=22;
; 0000 0090 error:
;	pocdat -> R16,R17
;	pocdata -> R18,R19
; 0000 0091     data[0] = 0;
; 0000 0092     data[1] = 0;
; 0000 0093     data[2] = 0;
; 0000 0094     data[3] = 0;
; 0000 0095     while(ISOBOT_IN == 1);  //caka na trvalu 1 kvoli chybe nacitaniu v strede dat
; 0000 0096 //---------- start isobot ------------
; 0000 0097     TCNT1 = 0;              //nuluje timer
; 0000 0098     while (ISOBOT_IN == 0); //caka na start
; 0000 0099     if (porovnaj(start,TCNT1,rozptyl) == 0)    goto error;    //ak sa cas nezhoduje zo start vracia na error
; 0000 009A //------------------------------------
; 0000 009B     for(pocdat = 0;pocdat < pocdata;pocdat++){
; 0000 009C     //--------------start prijem data jednotlive---------------------
; 0000 009D         if ((data[0] & 0x08)== 0x08)    pocdata = 22;
; 0000 009E         else                            pocdata = 30;
; 0000 009F         TCNT1 = 0;                      //nuluje timer
; 0000 00A0         while (ISOBOT_IN == 1);         //caka na data
; 0000 00A1             if (TCNT1 > 1300){
; 0000 00A2                 if (pocdat < 6){
; 0000 00A3                    data[0] = data[0] | 0x01;
; 0000 00A4                 }
; 0000 00A5                 else if(pocdat < 14){
; 0000 00A6                    data[1] = data[1] | 0x01;
; 0000 00A7                 }
; 0000 00A8                 else if(pocdat < 22){
; 0000 00A9                    data[2] = data[2] | 0x01;
; 0000 00AA                 }
; 0000 00AB                 else{
; 0000 00AC                    data[3] = data[3] | 0x01;
; 0000 00AD                 }
; 0000 00AE             }
; 0000 00AF             if ((pocdat < 6)&(pocdat!=5)){
; 0000 00B0                 data[0]=data[0]<<1;
; 0000 00B1             }
; 0000 00B2             else if((pocdat < 14)&(pocdat!=13)){
; 0000 00B3                 data[1]=data[1]<<1;
; 0000 00B4             }
; 0000 00B5             else if((pocdat < 22)&(pocdat!=21)){
; 0000 00B6                 data[2]=data[2]<<1;
; 0000 00B7             }
; 0000 00B8             else if((pocdat < 30)&(pocdat!=29)){
; 0000 00B9                 data[3]=data[3]<<1;
; 0000 00BA             }
; 0000 00BB     //----------------------------------------------------------------
; 0000 00BC         TCNT1 = 0;                      //nuluje timer
; 0000 00BD         while (ISOBOT_IN == 0);        //caka na ukoncenie data
; 0000 00BE      if (porovnaj(data0,TCNT1,rozptyl) == 0) goto error; //ak sa cas zhoduje pokracuje
; 0000 00BF     //----------------------------------------------------------------
; 0000 00C0     }
; 0000 00C1 }
;//------------------------------------------------
;//funkcia odosielania do isobota pomocou delay
;void send_isobot(unsigned char data[]){
; 0000 00C4 void send_isobot(unsigned char data[]){
_send_isobot:
; 0000 00C5     int pocdat;
; 0000 00C6     int pocdata=22;
; 0000 00C7     if((data[0]&0x08)==0x08) pocdata = 22;
	RCALL __SAVELOCR4
;	data -> Y+4
;	pocdat -> R16,R17
;	pocdata -> R18,R19
	__GETWRN 18,19,22
	RCALL SUBOPT_0x1
	ANDI R30,LOW(0x8)
	ANDI R31,HIGH(0x8)
	SBIW R30,8
	BRNE _0x2A
	__GETWRN 18,19,22
; 0000 00C8     else                     pocdata = 30;
	RJMP _0x2B
_0x2A:
	__GETWRN 18,19,30
; 0000 00C9 //---------- start isobot ------------
; 0000 00CA     ISOBOT_OUT = 0;
_0x2B:
	CBI  0x12,3
; 0000 00CB     delay_ms(2);
	LDI  R30,LOW(2)
	LDI  R31,HIGH(2)
	RCALL SUBOPT_0x2
; 0000 00CC     delay_us(500);
	__DELAY_USW 921
; 0000 00CD //------------------------------------
; 0000 00CE     for(pocdat = 0;pocdat < pocdata;pocdat++){
	__GETWRN 16,17,0
_0x2F:
	__CPWRR 16,17,18,19
	BRLT PC+2
	RJMP _0x30
; 0000 00CF     //--------------start prijem data jednotlive---------------------
; 0000 00D0         ISOBOT_OUT = 1;
	SBI  0x12,3
; 0000 00D1             if (pocdat < 6){
	__CPWRN 16,17,6
	BRGE _0x33
; 0000 00D2                if((data[0]&0x20)==0x20){
	RCALL SUBOPT_0x1
	ANDI R30,LOW(0x20)
	ANDI R31,HIGH(0x20)
	SBIW R30,32
	BRNE _0x34
; 0000 00D3                     delay_ms(1);
	RCALL SUBOPT_0x3
; 0000 00D4                     delay_us(50);
	RCALL SUBOPT_0x4
; 0000 00D5                }
; 0000 00D6                else{
	RJMP _0x35
_0x34:
; 0000 00D7                     delay_us(550);
	RCALL SUBOPT_0x5
; 0000 00D8                }
_0x35:
; 0000 00D9             }
; 0000 00DA             else if(pocdat < 14){
	RJMP _0x36
_0x33:
	__CPWRN 16,17,14
	BRGE _0x37
; 0000 00DB                if((data[1]&0x80)==0x80){
	RCALL SUBOPT_0x6
	ADIW R26,1
	RCALL SUBOPT_0x7
	BRNE _0x38
; 0000 00DC                     delay_ms(1);
	RCALL SUBOPT_0x3
; 0000 00DD                     delay_us(50);
	RCALL SUBOPT_0x4
; 0000 00DE                }
; 0000 00DF                else{
	RJMP _0x39
_0x38:
; 0000 00E0                     delay_us(550);
	RCALL SUBOPT_0x5
; 0000 00E1                }
_0x39:
; 0000 00E2             }
; 0000 00E3             else if(pocdat < 22){
	RJMP _0x3A
_0x37:
	__CPWRN 16,17,22
	BRGE _0x3B
; 0000 00E4                if((data[2]&0x80)==0x80){
	RCALL SUBOPT_0x6
	ADIW R26,2
	RCALL SUBOPT_0x7
	BRNE _0x3C
; 0000 00E5                     delay_ms(1);
	RCALL SUBOPT_0x3
; 0000 00E6                     delay_us(50);
	RCALL SUBOPT_0x4
; 0000 00E7                }
; 0000 00E8                else{
	RJMP _0x3D
_0x3C:
; 0000 00E9                     delay_us(550);
	RCALL SUBOPT_0x5
; 0000 00EA                }
_0x3D:
; 0000 00EB             }
; 0000 00EC             else{
	RJMP _0x3E
_0x3B:
; 0000 00ED                if((data[3]&0x80)==0x80){
	RCALL SUBOPT_0x6
	ADIW R26,3
	RCALL SUBOPT_0x7
	BRNE _0x3F
; 0000 00EE                     delay_ms(1);
	RCALL SUBOPT_0x3
; 0000 00EF                     delay_us(50);
	RCALL SUBOPT_0x4
; 0000 00F0                }
; 0000 00F1                else{
	RJMP _0x40
_0x3F:
; 0000 00F2                     delay_us(550);
	RCALL SUBOPT_0x5
; 0000 00F3                }
_0x40:
; 0000 00F4             }
_0x3E:
_0x3A:
_0x36:
; 0000 00F5         //--------------------------------
; 0000 00F6             if ((pocdat < 6)){
	__CPWRN 16,17,6
	BRGE _0x41
; 0000 00F7                 data[0]=data[0]<<1;
	RCALL SUBOPT_0x1
	RCALL SUBOPT_0x8
	RCALL SUBOPT_0x6
	ST   X,R30
; 0000 00F8             }
; 0000 00F9             else if((pocdat < 14)){
	RJMP _0x42
_0x41:
	__CPWRN 16,17,14
	BRGE _0x43
; 0000 00FA                 data[1]=data[1]<<1;
	RCALL SUBOPT_0x6
	ADIW R26,1
	RCALL SUBOPT_0x9
	__PUTB1SNS 4,1
; 0000 00FB             }
; 0000 00FC             else if((pocdat < 22)){
	RJMP _0x44
_0x43:
	__CPWRN 16,17,22
	BRGE _0x45
; 0000 00FD                 data[2]=data[2]<<1;
	RCALL SUBOPT_0x6
	ADIW R26,2
	RCALL SUBOPT_0x9
	__PUTB1SNS 4,2
; 0000 00FE             }
; 0000 00FF             else if((pocdat < 30)){
	RJMP _0x46
_0x45:
	__CPWRN 16,17,30
	BRGE _0x47
; 0000 0100                 data[3]=data[3]<<1;
	RCALL SUBOPT_0x6
	ADIW R26,3
	RCALL SUBOPT_0x9
	__PUTB1SNS 4,3
; 0000 0101             }
; 0000 0102     //----------------------------------------------------------------
; 0000 0103         ISOBOT_OUT = 0;
_0x47:
_0x46:
_0x44:
_0x42:
	CBI  0x12,3
; 0000 0104         delay_us(550);
	RCALL SUBOPT_0x5
; 0000 0105     //----------------------------------------------------------------
; 0000 0106     }
	__ADDWRN 16,17,1
	RJMP _0x2F
_0x30:
; 0000 0107     ISOBOT_OUT = 1;
	SBI  0x12,3
; 0000 0108     delay_ms(100);
	LDI  R30,LOW(100)
	LDI  R31,HIGH(100)
	RCALL SUBOPT_0x2
; 0000 0109 }
	RCALL __LOADLOCR4
	ADIW R28,6
	RET
;unsigned char datax[4];
;void main(void)
; 0000 010C {
_main:
; 0000 010D     init_atmega8();
	RCALL _init_atmega8
; 0000 010E     PORTD.2 =1;
	SBI  0x12,2
; 0000 010F     delay_ms(500);
	LDI  R30,LOW(500)
	LDI  R31,HIGH(500)
	RCALL SUBOPT_0x2
; 0000 0110     PORTD.2 =0;
	CBI  0x12,2
; 0000 0111     while(getchar() != 'A');
_0x50:
	RCALL _getchar
	CPI  R30,LOW(0x41)
	BRNE _0x50
; 0000 0112     putchar(5);
	LDI  R30,LOW(5)
	ST   -Y,R30
	RCALL _putchar
; 0000 0113     while (1){
_0x53:
; 0000 0114         switch(getchar()){
	RCALL _getchar
; 0000 0115             case 0: datax[0]=getchar();
	CPI  R30,0
	BRNE _0x59
	RCALL _getchar
	STS  _datax,R30
; 0000 0116                     datax[1]=getchar();
	RCALL _getchar
	__PUTB1MN _datax,1
; 0000 0117                     datax[2]=getchar();
	RCALL _getchar
	__PUTB1MN _datax,2
; 0000 0118                     datax[3]=getchar();
	RCALL _getchar
	__PUTB1MN _datax,3
; 0000 0119                     send_isobot(datax);
	LDI  R30,LOW(_datax)
	LDI  R31,HIGH(_datax)
	ST   -Y,R31
	ST   -Y,R30
	RCALL _send_isobot
; 0000 011A                     break;
	RJMP _0x58
; 0000 011B             case 1: DDRC = getchar();       break;
_0x59:
	CPI  R30,LOW(0x1)
	BRNE _0x5A
	RCALL _getchar
	OUT  0x14,R30
	RJMP _0x58
; 0000 011C             case 2: DDRB = getchar();       break;
_0x5A:
	CPI  R30,LOW(0x2)
	BRNE _0x5B
	RCALL _getchar
	OUT  0x17,R30
	RJMP _0x58
; 0000 011D             case 3: PORTB = getchar();      break;
_0x5B:
	CPI  R30,LOW(0x3)
	BRNE _0x5C
	RCALL _getchar
	OUT  0x18,R30
	RJMP _0x58
; 0000 011E             case 4: putchar(PINB);          break;
_0x5C:
	CPI  R30,LOW(0x4)
	BRNE _0x5D
	IN   R30,0x16
	RJMP _0x68
; 0000 011F             case 5: putchar(read_adc(0));   break;
_0x5D:
	CPI  R30,LOW(0x5)
	BRNE _0x5E
	LDI  R30,LOW(0)
	RCALL SUBOPT_0xA
	RJMP _0x68
; 0000 0120             case 6: putchar(read_adc(1));   break;
_0x5E:
	CPI  R30,LOW(0x6)
	BRNE _0x5F
	LDI  R30,LOW(1)
	RCALL SUBOPT_0xA
	RJMP _0x68
; 0000 0121             case 7: putchar(read_adc(2));   break;
_0x5F:
	CPI  R30,LOW(0x7)
	BRNE _0x60
	LDI  R30,LOW(2)
	RCALL SUBOPT_0xA
	RJMP _0x68
; 0000 0122             case 8: putchar(read_adc(3));   break;
_0x60:
	CPI  R30,LOW(0x8)
	BRNE _0x61
	LDI  R30,LOW(3)
	RCALL SUBOPT_0xA
	RJMP _0x68
; 0000 0123             case 9: putchar(read_adc(4));   break;
_0x61:
	CPI  R30,LOW(0x9)
	BRNE _0x62
	LDI  R30,LOW(4)
	RCALL SUBOPT_0xA
	RJMP _0x68
; 0000 0124             case 10: putchar(read_adc(5));  break;
_0x62:
	CPI  R30,LOW(0xA)
	BRNE _0x63
	LDI  R30,LOW(5)
	RCALL SUBOPT_0xA
	RJMP _0x68
; 0000 0125             case 11: putchar(PINC);       break;
_0x63:
	CPI  R30,LOW(0xB)
	BRNE _0x64
	IN   R30,0x13
	RJMP _0x68
; 0000 0126             case 12: PORTC = getchar();     break;
_0x64:
	CPI  R30,LOW(0xC)
	BRNE _0x65
	RCALL _getchar
	OUT  0x15,R30
	RJMP _0x58
; 0000 0127             case 'A':   putchar(5);         break;
_0x65:
	CPI  R30,LOW(0x41)
	BRNE _0x58
	LDI  R30,LOW(5)
_0x68:
	ST   -Y,R30
	RCALL _putchar
; 0000 0128         }
_0x58:
; 0000 0129     };
	RJMP _0x53
; 0000 012A }
_0x67:
	RJMP _0x67
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

	.CSEG
_getchar:
     sbis usr,rxc
     rjmp _getchar
     in   r30,udr
	RET
_putchar:
     sbis usr,udre
     rjmp _putchar
     ld   r30,y
     out  udr,r30
_0x2060001:
	ADIW R28,1
	RET

	.CSEG

	.CSEG

	.DSEG
_data:
	.BYTE 0x4
_datax:
	.BYTE 0x4
_p_S1020024:
	.BYTE 0x2

	.CSEG
;OPTIMIZER ADDED SUBROUTINE, CALLED 13 TIMES, CODE SIZE REDUCTION:22 WORDS
SUBOPT_0x0:
	LDI  R31,0
	RET

;OPTIMIZER ADDED SUBROUTINE, CALLED 3 TIMES, CODE SIZE REDUCTION:4 WORDS
SUBOPT_0x1:
	LDD  R26,Y+4
	LDD  R27,Y+4+1
	LD   R30,X
	RJMP SUBOPT_0x0

;OPTIMIZER ADDED SUBROUTINE, CALLED 7 TIMES, CODE SIZE REDUCTION:10 WORDS
SUBOPT_0x2:
	ST   -Y,R31
	ST   -Y,R30
	RJMP _delay_ms

;OPTIMIZER ADDED SUBROUTINE, CALLED 4 TIMES, CODE SIZE REDUCTION:4 WORDS
SUBOPT_0x3:
	LDI  R30,LOW(1)
	LDI  R31,HIGH(1)
	RJMP SUBOPT_0x2

;OPTIMIZER ADDED SUBROUTINE, CALLED 4 TIMES, CODE SIZE REDUCTION:4 WORDS
SUBOPT_0x4:
	__DELAY_USB 123
	RET

;OPTIMIZER ADDED SUBROUTINE, CALLED 5 TIMES, CODE SIZE REDUCTION:10 WORDS
SUBOPT_0x5:
	__DELAY_USW 1014
	RET

;OPTIMIZER ADDED SUBROUTINE, CALLED 7 TIMES, CODE SIZE REDUCTION:4 WORDS
SUBOPT_0x6:
	LDD  R26,Y+4
	LDD  R27,Y+4+1
	RET

;OPTIMIZER ADDED SUBROUTINE, CALLED 3 TIMES, CODE SIZE REDUCTION:4 WORDS
SUBOPT_0x7:
	LD   R30,X
	RCALL SUBOPT_0x0
	ANDI R30,LOW(0x80)
	CPI  R30,LOW(0x80)
	RET

;OPTIMIZER ADDED SUBROUTINE, CALLED 4 TIMES, CODE SIZE REDUCTION:1 WORDS
SUBOPT_0x8:
	LSL  R30
	ROL  R31
	RET

;OPTIMIZER ADDED SUBROUTINE, CALLED 3 TIMES, CODE SIZE REDUCTION:2 WORDS
SUBOPT_0x9:
	LD   R30,X
	RCALL SUBOPT_0x0
	RJMP SUBOPT_0x8

;OPTIMIZER ADDED SUBROUTINE, CALLED 6 TIMES, CODE SIZE REDUCTION:3 WORDS
SUBOPT_0xA:
	ST   -Y,R30
	RJMP _read_adc


	.CSEG
_delay_ms:
	ld   r30,y+
	ld   r31,y+
	adiw r30,0
	breq __delay_ms1
__delay_ms0:
	__DELAY_USW 0x733
	wdr
	sbiw r30,1
	brne __delay_ms0
__delay_ms1:
	ret

__SAVELOCR4:
	ST   -Y,R19
__SAVELOCR3:
	ST   -Y,R18
__SAVELOCR2:
	ST   -Y,R17
	ST   -Y,R16
	RET

__LOADLOCR4:
	LDD  R19,Y+3
__LOADLOCR3:
	LDD  R18,Y+2
__LOADLOCR2:
	LDD  R17,Y+1
	LD   R16,Y
	RET

;END OF CODE MARKER
__END_OF_CODE:
