/*
 * bridge.h
 *
 *  Created on: Mar 26, 2017
 *      Author: Bill
 */

#ifndef BRIDGE_H_
#define BRIDGE_H_

void bridgeProcess(void);

void bridgePing(uint8_t bID);
void bridgeReadData(uint8_t bID, uint8_t *requestParameters, uint8_t requestParametersLength);
void bridgeWriteData(uint8_t bID, uint8_t *requestParameters, uint8_t requestParametersLength);
void bridgeReadAX12ImageInMemory(uint8_t bID);
void bridgeWriteAX12ImageInMemory(uint8_t bID, uint8_t *requestParameters);
void bridgeUpdateAX12ImageInMemoryFromDevice(uint8_t bID);
void bridgeUpdateAX12DeviceFromImageInMemory(uint8_t bID);
void bridgeUpdateAllAX12ImagesInMemoryFromDevices(void);
void bridgeUpdateAllAX12DevicesFromImagesInMemory(void);

#endif /* BRIDGE_H_ */
