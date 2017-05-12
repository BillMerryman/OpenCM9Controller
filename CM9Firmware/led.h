/*
 * led.h
 *
 *  Created on: Dec 2, 2013
 *      Author: Bill
 */

#ifndef LED_H_
#define LED_H_

#include "common.h"

#define LED_GREEN		0x01

#define LED_POWER		0x01
#define LED_TXD			0x02
#define LED_RXD			0x04
#define LED_AUX			0x08
#define LED_MANAGE		0x10
#define LED_PROGRAM		0x20
#define LED_PLAY		0x40

#define LED_OFF			0
#define LED_ON			1
#define LED_TOGGLE		2

void LEDInitialize(void);
void LEDSet(unsigned char LEDno, unsigned char state);

#endif /* LED_H_ */
