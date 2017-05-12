/*
 * buttons.h
 *
 *  Created on: Jan 13, 2014
 *      Author: Bill
 */

#ifndef BUTTONS_H_
#define BUTTONS_H_

#include "common.h"

#define BUTTONS_START	1<<0
#define BUTTONS_UP		1<<4
#define BUTTONS_DOWN	1<<5
#define BUTTONS_LEFT	1<<6
#define BUTTONS_RIGHT	1<<7

void buttonsInitialize(void);
uint8_t buttonsGetState(void);

#endif /* BUTTONS_H_ */
