/*
 * communications.c
 *
 * Created: 11/18/2013 7:22:23 PM
 *  Author: Bill
 */ 

#include "communications.h"
#include "RS485.h"
#include "USB.h"
#include "bluetooth.h"

void communicationsInitialize(void)
{
	
	RS485Initialize();
	USBInitialize();
	bluetoothInitialize();
	
}
