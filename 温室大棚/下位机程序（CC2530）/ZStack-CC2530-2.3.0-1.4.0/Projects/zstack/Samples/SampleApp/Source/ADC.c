#include "ADC.h"
#include<ioCC2530.h>
static uint8 Delay_nus(uint16 i);
//P0.5
float get5(void)
  {   
        char temp7[2];
        float num7;
        unsigned int  adc7;
        ADCH &= 0X00;		//清EOC标志	
         ADCL &= 0X00;
        ADCCFG |= 0X20;         //配置为端口0输入
	ADCCON3=0xb5;		//单次转换,参考电压为电源电压，对P05进行采样,14位分辨率					
	ADCCON1 = 0X30;		//停止A/D
	ADCCON1 |= 0X40;	//启动A/D  
        
      //  Delay_nus(500); 
        while((!(ADCCON1 & 0x80))&&Delay_nus(200));
        //Delay_nus(50); 
        ADCCFG &=~0X20; 
        temp7[1] = ADCL;
        temp7[0] = ADCH;
        ADCCON1 = 0X30;	
        adc7 = (uint8)temp7[1];
        adc7 |= ( (uint8) temp7[0] )<<8;
        if(adc7&0x8000)adc7 = 0;
        adc7>>=2;
        num7 = adc7*3.3/8096;
        return num7;           
  }
//P0.6
float get6(void)
  {   
        char temp4[2];
        float num4;
        unsigned int  adc4;
        ADCH &= 0X00;		//清EOC标志	
        ADCL &= 0X00;
        ADCCFG |= 0X40;
	ADCCON3=0xb6;		//单次转换,参考电压为电源电压，对P06进行采样,14位分辨率					
	ADCCON1 = 0X30;		//停止A/D
	ADCCON1 |= 0X40;	//启动A/D  
        
      //  Delay_nus(500); 
        while((!(ADCCON1 & 0x80))&&Delay_nus(200));
        //Delay_nus(50); 
        ADCCFG &=~0X40;
        temp4[1] = ADCL;
        temp4[0] = ADCH;
        ADCCON1 = 0X30;	
        adc4 = (uint8)temp4[1];
        adc4 |= ( (uint8) temp4[0] )<<8;
        if(adc4&0x8000)adc4 = 0;
        adc4>>=2;
        num4 = adc4*3.3/8096;
        return num4;           
  }


uint8 Delay_nus(uint16 i)
{
   while(i--)
   {
      asm("NOP"); 
      asm("NOP");
      asm("NOP");
   }
   return 0;
}
      
          
     
