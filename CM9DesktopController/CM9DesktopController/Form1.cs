using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace CM9DesktopController
{
    public partial class frmCM9DesktopController : Form
    {
        private const int CM5_ID = 200;

        private const int MOTION_PAGE_SIZE = 512;
        private const int MOTION_PAGE_SECTION_LENGTH = 64;
        private const int MOTION_PAGE_SECTION_COUNT = 8;

        private const int USB_PACKET_FLAG_WIDTH = 2;
        private const int USB_ID_WIDTH = 1;
        private const int USB_PARAMETER_LENGTH_WIDTH = 1;
        private const int USB_INSTRUCTION_WIDTH = 1;
        private const int USB_CHECKSUM_WIDTH = 1;
        private const int HEADER_WIDTH = USB_PACKET_FLAG_WIDTH + USB_ID_WIDTH + USB_PARAMETER_LENGTH_WIDTH + USB_INSTRUCTION_WIDTH;
        private const int NON_PARAMETER_WIDTH = HEADER_WIDTH + USB_CHECKSUM_WIDTH;

        private Label[] lblFilePosePositions = new Label[31];
        private TextBox[,] txtFilePosePositions = new TextBox[7, 31];
        private TextBox[] txtFileDelay = new TextBox[7];
        private TextBox[] txtFileSpeed = new TextBox[7];
        private Label[] lblFlashPosePositions = new Label[31];
        private TextBox[,] txtFlashPosePositions = new TextBox[7, 31];
        private TextBox[] txtFlashDelay = new TextBox[7];
        private TextBox[] txtFlashSpeed = new TextBox[7];
        Byte[] ByteFileArray;
        Byte[] ByteFlashArray = new Byte[MOTION_PAGE_SIZE];
        SerialPort ControllerSerialConnection = new SerialPort();
        SerialPort DebugSerialConnection = new SerialPort();

        delegate void SerialTextCallback(String value);

        public frmCM9DesktopController()
        {
            InitializeComponent();
            foreach (String portName in SerialPort.GetPortNames())
            {
                cmbControllerSerialConnectionCOM.Items.Add(Char.IsDigit(portName, portName.Length - 1)? portName : portName.Substring(0, portName.Length - 1));
                cmbDebugSerialConnectionCOM.Items.Add(Char.IsDigit(portName, portName.Length - 1) ? portName : portName.Substring(0, portName.Length - 1));
            }

            renderFilePageFields();
            renderFlashPageFields();

            DebugSerialConnection.DataReceived += DebugSerialConnectionReceiveHandler;

        }

        private void frmMotion512ReaderTransmitter_Load(object sender, EventArgs e)
        {

            cmbControllerSerialConnectionBaud.SelectedIndex = 4;
            cmbControllerSerialConnectionParity.SelectedIndex = 2;
            cmbControllerSerialConnectionDataBits.SelectedIndex = 4;
            cmbControllerSerialConnectionStopBits.SelectedIndex = 1;
            cmbControllerSerialConnectionFlow.SelectedIndex = 2;

            cmbDebugSerialConnectionBaud.SelectedIndex = 5;
            cmbDebugSerialConnectionParity.SelectedIndex = 2;
            cmbDebugSerialConnectionDataBits.SelectedIndex = 4;
            cmbDebugSerialConnectionStopBits.SelectedIndex = 1;
            cmbDebugSerialConnectionFlow.SelectedIndex = 2;

        }

        private void btnControllerSerialConnectionConnect_Click(object sender, EventArgs e)
        {
            ControllerSerialConnection.BaudRate = Int32.Parse((String)cmbControllerSerialConnectionBaud.SelectedItem);
            ControllerSerialConnection.DataBits = Int32.Parse((String)cmbControllerSerialConnectionDataBits.SelectedItem);
            switch ((String)cmbControllerSerialConnectionParity.SelectedItem)
            {
                case "Odd":
                    ControllerSerialConnection.Parity = Parity.Odd;
                    break;
                case "Even":
                    ControllerSerialConnection.Parity = Parity.Even;
                    break;
                case "Mark":
                    ControllerSerialConnection.Parity = Parity.Mark;
                    break;
                case "Space":
                    ControllerSerialConnection.Parity = Parity.Space;
                    break;
                case "None":
                    ControllerSerialConnection.Parity = Parity.None;
                    break;
            }
            ControllerSerialConnection.PortName = (String)cmbControllerSerialConnectionCOM.SelectedItem;
            switch ((String)cmbControllerSerialConnectionStopBits.SelectedItem)
            {
                case "None":
                    ControllerSerialConnection.StopBits = StopBits.None;
                    break;
                case "1":
                    ControllerSerialConnection.StopBits = StopBits.One;
                    break;
                case "1.5":
                    ControllerSerialConnection.StopBits = StopBits.OnePointFive;
                    break;
                case "2":
                    ControllerSerialConnection.StopBits = StopBits.Two;
                    break;
            }
            try
            {
                ControllerSerialConnection.ReadTimeout = 500;
                ControllerSerialConnection.WriteTimeout = 500;
                ControllerSerialConnection.Open();
                if (ByteFileArray != null)
                {
                    btnFileWritePageToFlash.Enabled = true;
                    btnFilePlayPage.Enabled = true;
                }

                btnFlashPlayPage.Enabled = true;
                readPageFromFlash(ControllerSerialConnection, ByteFlashArray, Byte.Parse(txtFlashPageNumber.Text), txtReceivedBytes, txtReceivedString);
                setFlashFields();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnDebugSerialConnectionConnect_Click(object sender, EventArgs e)
        {

            DebugSerialConnection.BaudRate = Int32.Parse((String)cmbDebugSerialConnectionBaud.SelectedItem);
            DebugSerialConnection.DataBits = Int32.Parse((String)cmbDebugSerialConnectionDataBits.SelectedItem);
            switch ((String)cmbDebugSerialConnectionParity.SelectedItem)
            {
                case "Odd":
                    DebugSerialConnection.Parity = Parity.Odd;
                    break;
                case "Even":
                    DebugSerialConnection.Parity = Parity.Even;
                    break;
                case "Mark":
                    DebugSerialConnection.Parity = Parity.Mark;
                    break;
                case "Space":
                    DebugSerialConnection.Parity = Parity.Space;
                    break;
                case "None":
                    DebugSerialConnection.Parity = Parity.None;
                    break;
            }
            DebugSerialConnection.PortName = (String)cmbDebugSerialConnectionCOM.SelectedItem;
            switch ((String)cmbDebugSerialConnectionStopBits.SelectedItem)
            {
                case "None":
                    DebugSerialConnection.StopBits = StopBits.None;
                    break;
                case "1":
                    DebugSerialConnection.StopBits = StopBits.One;
                    break;
                case "1.5":
                    DebugSerialConnection.StopBits = StopBits.OnePointFive;
                    break;
                case "2":
                    DebugSerialConnection.StopBits = StopBits.Two;
                    break;
            }
            try
            {
                DebugSerialConnection.Open();
            }
            catch (Exception ex)
            {

            }

        }

        private void btnFilePageDown_Click(object sender, EventArgs e)
        {

            Int32 pageNumber = Int32.Parse(txtFilePageNumber.Text);
            if (pageNumber == 0) return;
            pageNumber--;
            txtFilePageNumber.Text = pageNumber.ToString();
            setFileFields(pageNumber);

        }

        private void btnFilePageUp_Click(object sender, EventArgs e)
        {

            Int32 pageNumber = Int32.Parse(txtFilePageNumber.Text);
            if (pageNumber == 127) return;
            pageNumber++;
            txtFilePageNumber.Text = pageNumber.ToString();
            setFileFields(pageNumber);

        }

        private void btnFileWriteToPageDown_Click(object sender, EventArgs e)
        {

            Int32 pageNumber = Int32.Parse(txtFilePageNumberToWrite.Text);
            if (pageNumber == 0) return;
            pageNumber--;
            txtFilePageNumberToWrite.Text = pageNumber.ToString();

        }

        private void btnFileWriteToPageUp_Click(object sender, EventArgs e)
        {

            Int32 pageNumber = Int32.Parse(txtFilePageNumberToWrite.Text);
            if (pageNumber == 127) return;
            pageNumber++;
            txtFilePageNumberToWrite.Text = pageNumber.ToString();

        }

        private void btnFileWritePageToFlash_Click(object sender, EventArgs e)
        {

            writePageToBuffer(ControllerSerialConnection, ByteFileArray, Byte.Parse(txtFilePageNumber.Text), txtReceivedBytes, txtReceivedString);
            transferBufferToFlash(ControllerSerialConnection, Byte.Parse(txtFilePageNumberToWrite.Text), txtReceivedBytes, txtReceivedString);

        }

        private void btnFilePlayPage_Click(object sender, EventArgs e)
        {

            writePageToBuffer(ControllerSerialConnection, ByteFileArray, Byte.Parse(txtFilePageNumber.Text), txtReceivedBytes, txtReceivedString);
            transferBufferToMotionPage(ControllerSerialConnection, txtReceivedBytes, txtReceivedString);
            executeMotionPage(ControllerSerialConnection, Byte.Parse(txtFilePageNumber.Text), txtReceivedBytes, txtReceivedString);

        }

        private void btnGetFile_Click(object sender, EventArgs e)
        {
            if (ofdByteFile.ShowDialog() == DialogResult.OK)
            {
                txtByteFileName.Text = ofdByteFile.FileName;
                System.IO.Stream ByteFileStream = ofdByteFile.OpenFile();
                ByteFileArray = new Byte[ByteFileStream.Length - 1];
                ByteFileStream.Read(ByteFileArray, 0, (Int32)ByteFileStream.Length - 1);
                ByteFileStream.Close();
                setFileFields(1);
                btnMakeHeaderFromPage.Enabled = true;
                if (ControllerSerialConnection.IsOpen)
                {
                    btnFileWritePageToFlash.Enabled = true;
                    btnFilePlayPage.Enabled = true;
                }
            }
        }

        private void btnMakeHeaderFromPage_Click(object sender, EventArgs e)
        {

            Byte pageNumber = Byte.Parse(txtFilePageNumber.Text);
            Int32 pageBase = pageNumber * 512;
            String[] rows = new String[64];
            String[] columns = new String[16];

            StringBuilder pageText = new StringBuilder();
            StringBuilder titleText = new StringBuilder();

            for (Int16 counter = 0; counter < 14; counter++)
            {
                titleText.Append((char)ByteFileArray[pageBase + counter]);
            }

            pageText.AppendLine("byte page_" + txtFilePageNumber.Text + "[] = { //" + titleText.ToString());

            for (Int16 rowCounter = 0; rowCounter < 64; rowCounter++)
            {
                for (Int16 columnCounter = 0; columnCounter < 16; columnCounter++)
                {
                    StringBuilder hex = new StringBuilder();
                    hex.AppendFormat("0x{0:x2}", ByteFileArray[pageBase + (rowCounter * 16) + columnCounter]);
                    columns[columnCounter] = hex.ToString();
                }
                rows[rowCounter] = "\t" + String.Join(", ", columns);
            }
            pageText.AppendLine(String.Join(", \r\n", rows));
            pageText.AppendLine("};");
            File.WriteAllText("page_" + txtFilePageNumber.Text + ".txt", pageText.ToString());

        }

        private void btnFlashPageDown_Click(object sender, EventArgs e)
        {

            Byte pageNumber = Byte.Parse(txtFlashPageNumber.Text);
            if (pageNumber == 0) return;
            pageNumber--;
            txtFlashPageNumber.Text = pageNumber.ToString();
            readPageFromFlash(ControllerSerialConnection, ByteFlashArray, pageNumber, txtReceivedBytes, txtReceivedString);
            setFlashFields();

        }

        private void btnFlashPageUp_Click(object sender, EventArgs e)
        {

            Byte pageNumber = Byte.Parse(txtFlashPageNumber.Text);
            if (pageNumber == 127) return;
            pageNumber++;
            txtFlashPageNumber.Text = pageNumber.ToString();
            readPageFromFlash(ControllerSerialConnection, ByteFlashArray, pageNumber, txtReceivedBytes, txtReceivedString);
            setFlashFields();

        }

        private void btnFlashPlayPage_Click(object sender, EventArgs e)
        {
            transferFlashToMotionPage(ControllerSerialConnection, Byte.Parse(txtFlashPageNumber.Text), txtReceivedBytes, txtReceivedString);
            executeMotionPage(ControllerSerialConnection, Byte.Parse(txtFlashPageNumber.Text), txtReceivedBytes, txtReceivedString);
        }

        private void btnMotionBreak_Click(object sender, EventArgs e)
        {

            breakMotionPage(ControllerSerialConnection, txtReceivedBytes, txtReceivedString);

        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            //give input field for ID to ping (1-254)
            ping(ControllerSerialConnection, 1, txtReceivedBytes, txtReceivedString);
        }

        private void btnReadPosition_Click(object sender, EventArgs e)
        {
            //give AX12 and AXS1 fields on GUI to read into
            read(ControllerSerialConnection, 1, txtReceivedBytes, txtReceivedString);
        }

        private void btnWritePosition_Click(object sender, EventArgs e)
        {
            //give AX12 and AXS1 fields on GUI to write from
            write(ControllerSerialConnection, 1, txtReceivedBytes, txtReceivedString);
        }

        private void btnReadAX12_Click(object sender, EventArgs e)
        {
            readAX12(ControllerSerialConnection, 1, txtReceivedBytes, txtReceivedString);
        }

        private void DebugSerialConnectionReceiveHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SetDebugText(((SerialPort)sender).ReadExisting());
        }

        private void ping(SerialPort spTargetPort, Byte dynamixelID, TextBox byteOutput, TextBox stringOutput)
        {
            Byte[] responseBuffer = null;
            byte error = 0;
            transmitPacket(spTargetPort, dynamixelID, PROTOCOL.INST_PING, ref error, null, ref responseBuffer);
            DisplayPayload(byteOutput, stringOutput, responseBuffer);
        }

        private void read(SerialPort spTargetPort, Byte dynamixelID, TextBox byteOutput, TextBox stringOutput)
        {
            //mod this to do a full dynamixel read from memory
            Byte[] parameterBuffer = {0x24, 0x02};
            Byte[] responseBuffer = null;
            byte error = 0;
            transmitPacket(spTargetPort, dynamixelID, PROTOCOL.INST_READ_DATA, ref error, parameterBuffer, ref responseBuffer);
            DisplayPayload(byteOutput, stringOutput, responseBuffer);
        }

        private void write(SerialPort spTargetPort, Byte dynamixelID, TextBox byteOutput, TextBox stringOutput)
        {
            //mod this to do a full dynamixel write from the GUI
            Byte[] parameterBuffer = { 0x18, 0x01, 0x00, 0x00, 0x00, 0x20, 0x20, 0xFF, 0x00};
            Byte[] responseBuffer = null;
            byte error = 0;
            transmitPacket(spTargetPort, dynamixelID, PROTOCOL.INST_WRITE_DATA, ref error, parameterBuffer, ref responseBuffer);
            DisplayPayload(byteOutput, stringOutput, responseBuffer);
        }
        
        private void readAX12(SerialPort spTargetPort, Byte dynamixelID, TextBox byteOutput, TextBox stringOutput)
        {
            Byte[] responseBuffer = null;
            byte error = 0;
            transmitPacket(spTargetPort, dynamixelID, PROTOCOL.INST_UPDATE_AX12_IMAGE_IN_MEMORY_FROM_DEVICE, ref error, null, ref responseBuffer);
            transmitPacket(spTargetPort, dynamixelID, PROTOCOL.INST_READ_AX12_IMAGE_IN_MEMORY, ref error, null, ref responseBuffer);
            DisplayPayload(byteOutput, stringOutput, responseBuffer);
        }

        private void readPageFromFlash(SerialPort spTargetPort, Byte[] target, Byte pageNumber, TextBox byteOutput, TextBox stringOutput)
        {
            Byte[] parameterBuffer = new Byte[1];
            Byte[] responseBuffer = null;
            Byte error = 0;

            transferFlashToBuffer(spTargetPort, pageNumber, byteOutput, stringOutput);

            for (Byte section = 0; section < MOTION_PAGE_SECTION_COUNT; section++)
            {
                parameterBuffer[0] = section;
                transmitPacket(spTargetPort, CM5_ID, PROTOCOL.INST_READ_PAGE_SECTION_FROM_BUFFER, ref error, parameterBuffer, ref responseBuffer);
                for (Byte counter = 0; counter < MOTION_PAGE_SECTION_LENGTH; counter++)
                {
                    target[(section * MOTION_PAGE_SECTION_LENGTH) + counter] = responseBuffer[counter];
                }
            }
        }

        private void writePageToBuffer(SerialPort spTargetPort, Byte[] sourceFile, Byte pageNumber, TextBox byteOutput, TextBox stringOutput)
        {
            Int32 pageBase = pageNumber * MOTION_PAGE_SIZE;

            Byte[] parameterBuffer = new Byte[MOTION_PAGE_SECTION_LENGTH + 1];
            Byte[] responseBuffer = null;
            Byte error = 0;

            for (Byte section = 0; section < MOTION_PAGE_SECTION_COUNT; section++)
            {
                parameterBuffer[0] = section;
                for (Byte counter = 1; counter < MOTION_PAGE_SECTION_LENGTH + 1; counter++)
                {
                    parameterBuffer[counter] = sourceFile[pageBase + (MOTION_PAGE_SECTION_LENGTH * section) + (counter - 1)];
                }
                transmitPacket(spTargetPort, CM5_ID, PROTOCOL.INST_WRITE_PAGE_SECTION_TO_BUFFER, ref error, parameterBuffer, ref responseBuffer);
            }
        }

        private void transferBufferToFlash(SerialPort spTargetPort, Byte pageNumber, TextBox byteOutput, TextBox stringOutput)
        {
            Byte[] parameterBuffer = new Byte[] { pageNumber };
            Byte[] responseBuffer = null;
            Byte error = 0;
            transmitPacket(spTargetPort, CM5_ID, PROTOCOL.INST_TRANSFER_PAGE_BUFFER_TO_FLASH, ref error, parameterBuffer, ref responseBuffer);
            DisplayPayload(byteOutput, stringOutput, responseBuffer);
        }

        private void transferBufferToMotionPage(SerialPort spTargetPort, TextBox byteOutput, TextBox stringOutput)
        {
            Byte[] responseBuffer = null;
            Byte error = 0;
            transmitPacket(spTargetPort, CM5_ID, PROTOCOL.INST_TRANSFER_PAGE_BUFFER_TO_MOTION_PAGE, ref error, null, ref responseBuffer);
            DisplayPayload(byteOutput, stringOutput, responseBuffer);
        }

        private void transferFlashToBuffer(SerialPort spTargetPort, Byte pageNumber, TextBox byteOutput, TextBox stringOutput)
        {
            Byte[] parameterBuffer = new Byte[] { pageNumber };
            Byte[] responseBuffer = null;
            Byte error = 0;
            transmitPacket(spTargetPort, CM5_ID, PROTOCOL.INST_TRANSFER_FLASH_TO_PAGE_BUFFER, ref error, parameterBuffer, ref responseBuffer);
            DisplayPayload(byteOutput, stringOutput, responseBuffer);
        }

        private void transferFlashToMotionPage(SerialPort spTargetPort, Byte pageNumber, TextBox byteOutput, TextBox stringOutput)
        {
            Byte[] parameterBuffer = new Byte[] { pageNumber };
            Byte[] responseBuffer = null;
            Byte error = 0;
            transmitPacket(spTargetPort, CM5_ID, PROTOCOL.INST_TRANSFER_FLASH_TO_MOTION_PAGE, ref error, parameterBuffer, ref responseBuffer);
            DisplayPayload(byteOutput, stringOutput, responseBuffer);
        }

        private void executeMotionPage(SerialPort spTargetPort, Byte pageNumber, TextBox byteOutput, TextBox stringOutput)
        {
            Byte[] requestBuffer = { pageNumber };
            Byte[] responseBuffer = null;
            Byte error = 0;
            transmitPacket(spTargetPort, CM5_ID, PROTOCOL.INST_EXECUTE_MOTION_PAGE, ref error, requestBuffer, ref responseBuffer);
            DisplayPayload(byteOutput, stringOutput, responseBuffer);
        }

        private void breakMotionPage(SerialPort spTargetPort, TextBox byteOutput, TextBox stringOutput)
        {
            Byte[] responseBuffer = null;
            Byte error = 0;
            transmitPacket(spTargetPort, CM5_ID, PROTOCOL.INST_BREAK_MOTION_PAGE, ref error, null, ref responseBuffer);
            DisplayPayload(byteOutput, stringOutput, responseBuffer);
        }

        private bool transmitPacket(SerialPort spTargetPort, byte id, PROTOCOL instruction, ref byte error, Byte[] requestBuffer, ref Byte[] responseBuffer)
        {
            sendPacket(spTargetPort, id, instruction, requestBuffer);
            receivePacket(spTargetPort, ref error, ref responseBuffer);
            return true;
        }

        private bool sendPacket(SerialPort spTargetPort, byte id, PROTOCOL instruction, Byte[] parameters)
        {
            //go through and have functions check the return value
            //also either have the error output write to the output window, or
            //expand the response fields. Or maybe just put what we did get back in the response fields
            //and pop up an 'error' modal dialog alert. Maybe zero out the arrays before we
            //populate and send them
            Byte[] transmitBuffer;

            transmitBuffer = assemblePacket(id, (byte)instruction, parameters);
            try
            {
                spTargetPort.Write(transmitBuffer, 0, transmitBuffer.Length);
                return true;
            }
            catch (TimeoutException stoe)
            {
                return false;
            }
        }

        private bool receivePacket(SerialPort spTargetPort, ref byte error, ref Byte[] parameters)
        {
            Byte[] charBuffer = new Byte[1];
            Byte[] RS485RxBuffer = new Byte[BUFFER_SIZE];
            byte RS485RxReadPosition = 0;
            byte RS485RxWritePosition = 0;

            try
            {
                while (true)
                {
                    if (spTargetPort.Read(charBuffer, 0, charBuffer.Length) < charBuffer.Length) continue;
                    RS485RxBuffer[RS485RxWritePosition++] = charBuffer[0];

                    Byte occupiedBufferSize = (Byte)((RS485RxReadPosition <= RS485RxWritePosition) ? (RS485RxWritePosition - RS485RxReadPosition) : (BUFFER_SIZE - (RS485RxReadPosition - RS485RxWritePosition)));

                    //if we don't even have a sentinels worth yet, continue
                    if (occupiedBufferSize < RS485_PACKET_FLAG_WIDTH) continue;

                    //if we have what should at least be a sentinel, but it isn't,
                    //consume a byte and try again...
                    if (RS485RxBuffer[RS485RxReadPosition] != 0xFF || RS485RxBuffer[(Byte)(RS485RxReadPosition + 1)] != 0xFF)
                    {
                        RS485RxReadPosition++;
                        continue;
                    }

                    //if we don't have a headers worth yet, continue
                    if (occupiedBufferSize < RS485_PACKET_FLAG_WIDTH + RS485_ID_WIDTH + RS485_PARAMETER_LENGTH_WIDTH) continue;

                    Byte parameterSizePosition = (Byte)(RS485RxReadPosition + RS485_PACKET_FLAG_WIDTH + RS485_ID_WIDTH);
                    Byte packetSize = (Byte)((RS485_PACKET_FLAG_WIDTH + RS485_ID_WIDTH + RS485_PARAMETER_LENGTH_WIDTH) + RS485RxBuffer[parameterSizePosition]);

                    //if we don't have what the header says is a packets worth yet, continue
                    if (occupiedBufferSize < packetSize) continue;

                    //we have a packets worth, evaluate checksum to make sure it is a valid packet
                    Byte checkSumPosition = (Byte)(RS485RxReadPosition + RS485_PACKET_FLAG_WIDTH + RS485_ID_WIDTH + RS485RxBuffer[parameterSizePosition]);
                    Byte checkSum = 0;
                    Byte rxReadPosition = (Byte)(RS485RxReadPosition + RS485_PACKET_FLAG_WIDTH);
                    while (rxReadPosition != checkSumPosition) checkSum += RS485RxBuffer[rxReadPosition++];
                    checkSum = (Byte)~checkSum;
                    if (checkSum != RS485RxBuffer[rxReadPosition])
                    {
                        RS485RxReadPosition++;
                        continue;
                    }
                    //we got a good packet back, so lets deal with it..
                    //move past header
                    RS485RxReadPosition += RS485_PACKET_FLAG_WIDTH;
                    //get returned ID
                    Byte returnedID = RS485RxBuffer[RS485RxReadPosition];
                    RS485RxReadPosition++;
                    //get returned length
                    Byte returnedLength = RS485RxBuffer[RS485RxReadPosition];
                    RS485RxReadPosition++;
                    //get returned error, if there is an error, eat rest of packet and return false
                    error = RS485RxBuffer[RS485RxReadPosition];
                    if ((error & (RS485_RX_CHECKSUM_ERROR | RS485_RX_INSTRUCTION_ERROR)) != 0)
                    {
                        RS485RxReadPosition += returnedLength;
                        return false;
                    }
                    RS485RxReadPosition++;
                    //get payload length
                    Byte payloadLength = (Byte)(returnedLength - (RS485_INSTRUCTION_WIDTH + RS485_CHECKSUM_WIDTH));
                    //allocate buffer
                    parameters = new Byte[payloadLength];
                    //read payload
                    for (Byte counter = 0; counter < payloadLength; counter++)
                    {
                        parameters[counter] = RS485RxBuffer[RS485RxReadPosition];
                        RS485RxReadPosition++;
                    }
                    //eat checksum
                    RS485RxReadPosition++;
                    return true;
                }
            }
            catch (TimeoutException stoe)
            {
                return false;
            }
        }

        private Byte[] assemblePacket(Byte ID, Byte instruction, Byte[] parameters)
        {
            Byte parameterLength = parameters == null ? (Byte)0 : (Byte)(parameters.Length);
            Byte[] returnPacket = new Byte[HEADER_WIDTH + parameterLength + USB_CHECKSUM_WIDTH];
            Byte packetPosition = 0;
            Byte checkSum = 0;
            Byte payloadLength = (Byte)(USB_INSTRUCTION_WIDTH + parameterLength + USB_CHECKSUM_WIDTH);
            returnPacket[packetPosition++] = 0xff;
            returnPacket[packetPosition++] = 0xff;
            returnPacket[packetPosition++] = ID;
            returnPacket[packetPosition++] = payloadLength;
            returnPacket[packetPosition++] = instruction;
            checkSum = (Byte)(ID + payloadLength + instruction);

            for (Int32 counter = 0; counter < parameterLength; counter++)
            {
                returnPacket[packetPosition++] = parameters[counter];
                checkSum += parameters[counter];
            }

            returnPacket[packetPosition++] = (Byte)~checkSum;

            return returnPacket;
        }

        #region GUI population functions

        //Place the labels and text boxes for motion page position, speed, etc. from motion pages in a motion file on the GUI
        private void renderFilePageFields()
        {

            //Add the fields for the position data
            for (int column = 0; column < 31; column++)
            {
                lblFilePosePositions[column] = new Label();
                this.gbxFilePoses.Controls.Add(this.lblFilePosePositions[column]);
                this.lblFilePosePositions[column].AutoSize = true;
                this.lblFilePosePositions[column].Location = new System.Drawing.Point((5 + (column * 28)), 16);
                this.lblFilePosePositions[column].Name = "lblPosePosition" + column;
                this.lblFilePosePositions[column].Size = new System.Drawing.Size(16, 18);
                this.lblFilePosePositions[column].TabIndex = 0;
                this.lblFilePosePositions[column].Text = column.ToString();
            }
            for (int row = 0; row < 7; row++)
            {
                for (int column = 0; column < 31; column++)
                {
                    txtFilePosePositions[row, column] = new TextBox();
                    this.gbxFilePoses.Controls.Add(txtFilePosePositions[row, column]);
                    this.txtFilePosePositions[row, column].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.txtFilePosePositions[row, column].Location = new System.Drawing.Point((5 + (column * 28)), (35 + (row * 22)));
                    this.txtFilePosePositions[row, column].Name = "Pose" + row + "X" + column;
                    this.txtFilePosePositions[row, column].RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                    this.txtFilePosePositions[row, column].Size = new System.Drawing.Size(26, 18);
                }
            }
            for (int row = 0; row < 7; row++)
            {
                txtFileDelay[row] = new TextBox();
                txtFileSpeed[row] = new TextBox();
                this.gbxFilePoses.Controls.Add(txtFileDelay[row]);
                this.gbxFilePoses.Controls.Add(txtFileSpeed[row]);
                this.txtFileDelay[row].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.txtFileSpeed[row].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.txtFileDelay[row].Location = new System.Drawing.Point(885, (35 + (row * 22)));
                this.txtFileSpeed[row].Location = new System.Drawing.Point(915, (35 + (row * 22)));
                this.txtFileDelay[row].Name = "Delay" + row;
                this.txtFileSpeed[row].Name = "Speed" + row;
                this.txtFileDelay[row].RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.txtFileSpeed[row].RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.txtFileDelay[row].Size = new System.Drawing.Size(26, 18);
                this.txtFileSpeed[row].Size = new System.Drawing.Size(26, 18);
            }

        }

        //Place the labels and text boxes for motion page position, speed, etc. from motion pages in flash on the GUI
        private void renderFlashPageFields()
        {
            //Add the fields for the position data
            for (int column = 0; column < 31; column++)
            {
                lblFlashPosePositions[column] = new Label();
                this.gbxFlashPoses.Controls.Add(this.lblFlashPosePositions[column]);
                this.lblFlashPosePositions[column].AutoSize = true;
                this.lblFlashPosePositions[column].Location = new System.Drawing.Point((5 + (column * 28)), 16);
                this.lblFlashPosePositions[column].Name = "lblFlashPosePosition" + column;
                this.lblFlashPosePositions[column].Size = new System.Drawing.Size(16, 18);
                this.lblFlashPosePositions[column].TabIndex = 0;
                this.lblFlashPosePositions[column].Text = column.ToString();
            }
            for (int row = 0; row < 7; row++)
            {
                for (int column = 0; column < 31; column++)
                {
                    txtFlashPosePositions[row, column] = new TextBox();
                    this.gbxFlashPoses.Controls.Add(txtFlashPosePositions[row, column]);
                    this.txtFlashPosePositions[row, column].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.txtFlashPosePositions[row, column].Location = new System.Drawing.Point((5 + (column * 28)), (35 + (row * 22)));
                    this.txtFlashPosePositions[row, column].Name = "FlashPose" + row + "X" + column;
                    this.txtFlashPosePositions[row, column].RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                    this.txtFlashPosePositions[row, column].Size = new System.Drawing.Size(26, 18);
                }
            }
            for (int row = 0; row < 7; row++)
            {
                txtFlashDelay[row] = new TextBox();
                txtFlashSpeed[row] = new TextBox();
                this.gbxFlashPoses.Controls.Add(txtFlashDelay[row]);
                this.gbxFlashPoses.Controls.Add(txtFlashSpeed[row]);
                this.txtFlashDelay[row].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.txtFlashSpeed[row].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.txtFlashDelay[row].Location = new System.Drawing.Point(885, (35 + (row * 22)));
                this.txtFlashSpeed[row].Location = new System.Drawing.Point(915, (35 + (row * 22)));
                this.txtFlashDelay[row].Name = "FlashDelay" + row;
                this.txtFlashSpeed[row].Name = "FlashSpeed" + row;
                this.txtFlashDelay[row].RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.txtFlashSpeed[row].RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.txtFlashDelay[row].Size = new System.Drawing.Size(26, 18);
                this.txtFlashSpeed[row].Size = new System.Drawing.Size(26, 18);
            }
        }

        //Display all the data about a motion page from a motion file on the GUI
        private void setFileFields(Int32 pageNumber)
        {

            if (pageNumber < 0 || pageNumber > 128) return;

            Int32 pageBase = pageNumber * MOTION_PAGE_SIZE;
            StringBuilder title = new StringBuilder();

            for (Int32 counter = 0; counter < 14; counter++, pageBase++)
            {
                title.Append((Char)(ByteFileArray[pageBase]));
            }

            txtFileName.Text = title.ToString();
            txtFileUnidentifiedByte0.Text = ByteFileArray[pageBase++].ToString();
            txtFilePlayCount.Text = ByteFileArray[pageBase++].ToString();
            txtFileSchedule.Text = ByteFileArray[pageBase++].ToString();
            cmbFileRes1.Items.Clear();
            for (Int32 counter = 0; counter < 3; counter++, pageBase++)
            {
                cmbFileRes1.Items.Add(ByteFileArray[pageBase]);
            }
            txtFilePoseCount.Text = ByteFileArray[pageBase++].ToString();
            txtFileUnidentifiedByte1.Text = ByteFileArray[pageBase++].ToString();
            txtFilePageSpeed.Text = ByteFileArray[pageBase++].ToString();
            txtFileDxlSetup.Text = ByteFileArray[pageBase++].ToString();
            txtFileAccelTime.Text = ByteFileArray[pageBase++].ToString();
            txtFileNextPage.Text = ByteFileArray[pageBase++].ToString();
            txtFileExitPage.Text = ByteFileArray[pageBase++].ToString();
            txtFileLinkedPage1.Text = ByteFileArray[pageBase++].ToString();
            txtFileLinkedPage1PlayCode.Text = ByteFileArray[pageBase++].ToString();
            txtFileLinkedPage2.Text = ByteFileArray[pageBase++].ToString();
            txtFileLinkedPage2PlayCode.Text = ByteFileArray[pageBase++].ToString();
            txtFilecheckSum.Text = ByteFileArray[pageBase++].ToString();
            cmbFileSlope.Items.Clear();
            for (Int32 counter = 0; counter < 31; counter++, pageBase++)
            {
                cmbFileSlope.Items.Add(ByteFileArray[pageBase]);
            }

            txtFileunidentifiedByte2.Text = ByteFileArray[pageBase++].ToString();

            for (Int32 row = 0; row < 7; row++)
            {
                for (Int32 column = 0; column < 31; column++)
                {
                    UInt32 positionLow = ByteFileArray[pageBase++];
                    UInt32 positionHigh = ByteFileArray[pageBase++] & (UInt32)3;
                    positionHigh <<= 8;
                    UInt32 position = positionHigh + positionLow;
                    txtFilePosePositions[row, column].Text = position.ToString();
                }
                txtFileDelay[row].Text = ByteFileArray[pageBase++].ToString();
                txtFileSpeed[row].Text = ByteFileArray[pageBase++].ToString();
            }

        }

        //Display all the data about a motion page from flash on the GUI
        private void setFlashFields()
        {

            Int32 pageBase = 0;
            StringBuilder title = new StringBuilder();

            for (Int32 counter = 0; counter < 14; counter++, pageBase++)
            {
                title.Append((Char)(ByteFlashArray[pageBase]));
            }

            txtFlashName.Text = title.ToString();
            txtFlashUnidentifiedByte0.Text = ByteFlashArray[pageBase++].ToString();
            txtFlashPlayCount.Text = ByteFlashArray[pageBase++].ToString();
            txtFlashSchedule.Text = ByteFlashArray[pageBase++].ToString();
            cmbFlashRes1.Items.Clear();
            for (Int32 counter = 0; counter < 3; counter++, pageBase++)
            {
                cmbFlashRes1.Items.Add(ByteFlashArray[pageBase]);
            }
            txtFlashPoseCount.Text = ByteFlashArray[pageBase++].ToString();
            txtFlashunidentifiedByte1.Text = ByteFlashArray[pageBase++].ToString();
            txtFlashPageSpeed.Text = ByteFlashArray[pageBase++].ToString();
            txtFlashdxlSetup.Text = ByteFlashArray[pageBase++].ToString();
            txtFlashaccelTime.Text = ByteFlashArray[pageBase++].ToString();
            txtFlashNextPage.Text = ByteFlashArray[pageBase++].ToString();
            txtFlashExitPage.Text = ByteFlashArray[pageBase++].ToString();
            txtFlashLinkedPage1.Text = ByteFlashArray[pageBase++].ToString();
            txtFlashLinkedPage1PlayCode.Text = ByteFlashArray[pageBase++].ToString();
            txtFlashLinkedPage2.Text = ByteFlashArray[pageBase++].ToString();
            txtFlashLinkedPage2PlayCode.Text = ByteFlashArray[pageBase++].ToString();
            txtFlashChecksum.Text = ByteFlashArray[pageBase++].ToString();
            cmbFlashSlope.Items.Clear();
            for (Int32 counter = 0; counter < 31; counter++, pageBase++)
            {
                cmbFlashSlope.Items.Add(ByteFlashArray[pageBase]);
            }

            txtFlashunidentifiedByte2.Text = ByteFlashArray[pageBase++].ToString();

            for (Int32 row = 0; row < 7; row++)
            {
                for (Int32 column = 0; column < 31; column++)
                {
                    UInt32 positionLow = ByteFlashArray[pageBase++];
                    UInt32 positionHigh = ByteFlashArray[pageBase++] & (UInt32)3;
                    positionHigh <<= 8;
                    UInt32 position = positionHigh + positionLow;
                    txtFlashPosePositions[row, column].Text = position.ToString();
                }
                txtFlashDelay[row].Text = ByteFlashArray[pageBase++].ToString();
                txtFlashSpeed[row].Text = ByteFlashArray[pageBase++].ToString();
            }

        }

        //Set debug window text (possibly from another thread)
        private void SetDebugText(String Value)
        {
            if (txtDebugWindow.InvokeRequired)
            {
                SerialTextCallback d = new SerialTextCallback(SetDebugText);
                this.Invoke(d, new object[] { Value });
            }
            else
            {
                String newValue = txtDebugWindow.Text + Value;
                if (newValue.Length > 65536) newValue = newValue.Substring(newValue.Length - 65536);
                txtDebugWindow.Text = newValue;
                txtDebugWindow.SelectionStart = txtDebugWindow.TextLength;
                txtDebugWindow.ScrollToCaret();
            }
        }

        //Display response buffers as string on the GUI
        private static void DisplayPayload(TextBox byteOutput, TextBox stringOutput, Byte[] inputBuffer)
        {
            StringBuilder bytesRead = new StringBuilder();
            StringBuilder stringRead = new StringBuilder();
            for (int messageByte = 0; messageByte < inputBuffer.Length; messageByte++)
            {
                bytesRead.Append((char)inputBuffer[messageByte]);
                bytesRead.Append(" ");
                stringRead.Append(inputBuffer[messageByte].ToString());
                stringRead.Append(" ");
            }
            byteOutput.Text = bytesRead.ToString();
            stringOutput.Text = stringRead.ToString();
        }

        #endregion

    }

}