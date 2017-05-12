/*
 * buttons.c
 *
 *  Created on: Jan 13, 2014
 *      Author: Bill
 */

#include "led.h"
#include "buttons.h"

volatile uint8_t BUTTON_STATUS;

void EXTI3_IRQHandler(void)
{

	if(EXTI_GetITStatus(EXTI_Line3) != RESET)
	{
		EXTI_ClearITPendingBit(EXTI_Line3);
		BUTTON_STATUS |= (BUTTONS_START);
	}

}

void EXTI15_10_IRQHandler(void)
{

	if(EXTI_GetITStatus(EXTI_Line10) != RESET)
	{
		EXTI_ClearITPendingBit(EXTI_Line10);
		BUTTON_STATUS |= (BUTTONS_DOWN);
	}

	if(EXTI_GetITStatus(EXTI_Line11) != RESET)
	{
		EXTI_ClearITPendingBit(EXTI_Line11);
		BUTTON_STATUS |= (BUTTONS_UP);
	}

	if(EXTI_GetITStatus(EXTI_Line14) != RESET)
	{
		EXTI_ClearITPendingBit(EXTI_Line14);
		BUTTON_STATUS |= (BUTTONS_RIGHT);
	}

	if(EXTI_GetITStatus(EXTI_Line15) != RESET)
	{
		EXTI_ClearITPendingBit(EXTI_Line15);
		BUTTON_STATUS |= (BUTTONS_LEFT);
	}

}

void buttonsInitialize()
{

	GPIO_InitTypeDef GPIO_InitStruct;
	EXTI_InitTypeDef EXTI_InitStruct;
	NVIC_InitTypeDef NVIC_InitStruct;

	GPIO_StructInit(&GPIO_InitStruct);
	EXTI_StructInit(&EXTI_InitStruct);
	NVIC_StructInit(&NVIC_InitStruct);

	EXTI_DeInit();

	// PORTA CONFIG
	GPIO_InitStruct.GPIO_Pin = GPIO_Pin_14 | GPIO_Pin_15;
	GPIO_InitStruct.GPIO_Mode = GPIO_Mode_IPU;
	GPIO_Init(GPIOA, &GPIO_InitStruct);

	// PORTB CONFIG
	GPIO_InitStruct.GPIO_Pin = GPIO_Pin_3;
	GPIO_InitStruct.GPIO_Mode = GPIO_Mode_IPU;
	GPIO_Init(GPIOB, &GPIO_InitStruct);

	// PORTC CONFIG
	GPIO_InitStruct.GPIO_Pin = GPIO_Pin_11 | GPIO_Pin_10;
	GPIO_InitStruct.GPIO_Mode = GPIO_Mode_IPU;
	GPIO_Init(GPIOC, &GPIO_InitStruct);

	GPIO_EXTILineConfig(GPIO_PortSourceGPIOA, GPIO_PinSource14);
	GPIO_EXTILineConfig(GPIO_PortSourceGPIOA, GPIO_PinSource15);
	GPIO_EXTILineConfig(GPIO_PortSourceGPIOB, GPIO_PinSource3);
	GPIO_EXTILineConfig(GPIO_PortSourceGPIOC, GPIO_PinSource10);
	GPIO_EXTILineConfig(GPIO_PortSourceGPIOC, GPIO_PinSource11);

	EXTI_InitStruct.EXTI_Line = EXTI_Line3 | EXTI_Line10 | EXTI_Line11 | EXTI_Line14 | EXTI_Line15;
	EXTI_InitStruct.EXTI_Mode = EXTI_Mode_Interrupt;
	EXTI_InitStruct.EXTI_Trigger = EXTI_Trigger_Falling;
	EXTI_InitStruct.EXTI_LineCmd = ENABLE;
	EXTI_Init(&EXTI_InitStruct);

	NVIC_InitStruct.NVIC_IRQChannelPreemptionPriority = 4;
	NVIC_InitStruct.NVIC_IRQChannelSubPriority = 0;
	NVIC_InitStruct.NVIC_IRQChannelCmd = ENABLE;

	NVIC_InitStruct.NVIC_IRQChannel = EXTI15_10_IRQChannel;
	NVIC_Init(&NVIC_InitStruct);

	NVIC_InitStruct.NVIC_IRQChannel = EXTI3_IRQChannel;
	NVIC_Init(&NVIC_InitStruct);

}

uint8_t buttonsGetState(void)
{

	uint8_t buttonStatus = BUTTON_STATUS;
	BUTTON_STATUS = 0;
	return buttonStatus;

}
