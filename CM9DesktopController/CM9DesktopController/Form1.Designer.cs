using System.Windows.Forms;

namespace CM9DesktopController
{
    partial class frmCM9DesktopController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ofdByteFile = new System.Windows.Forms.OpenFileDialog();
            this.lblReceivedBytes = new System.Windows.Forms.Label();
            this.lblReceivedString = new System.Windows.Forms.Label();
            this.txtReceivedBytes = new System.Windows.Forms.TextBox();
            this.txtReceivedString = new System.Windows.Forms.TextBox();
            this.tcMotionPages = new System.Windows.Forms.TabControl();
            this.tpPageFromFile = new System.Windows.Forms.TabPage();
            this.btnFilePlayPage = new System.Windows.Forms.Button();
            this.btnFileWritePageToFlash = new System.Windows.Forms.Button();
            this.btnMakeHeaderFromPage = new System.Windows.Forms.Button();
            this.btnFileWriteToPageDown = new System.Windows.Forms.Button();
            this.txtByteFileName = new System.Windows.Forms.TextBox();
            this.btnFileWriteToPageUp = new System.Windows.Forms.Button();
            this.txtFilePageNumberToWrite = new System.Windows.Forms.TextBox();
            this.btnGetFile = new System.Windows.Forms.Button();
            this.lblFileAtPosition = new System.Windows.Forms.Label();
            this.btnFilePageDown = new System.Windows.Forms.Button();
            this.btnFilePageUp = new System.Windows.Forms.Button();
            this.txtFilePageNumber = new System.Windows.Forms.TextBox();
            this.lblFilePageNumber = new System.Windows.Forms.Label();
            this.gbxFilePoses = new System.Windows.Forms.GroupBox();
            this.lblFileSpeed = new System.Windows.Forms.Label();
            this.lblFileDelay = new System.Windows.Forms.Label();
            this.gbxFileHeader = new System.Windows.Forms.GroupBox();
            this.cmbFileSlope = new System.Windows.Forms.ComboBox();
            this.cmbFileRes1 = new System.Windows.Forms.ComboBox();
            this.lblFileunidentifiedByte2 = new System.Windows.Forms.Label();
            this.txtFileunidentifiedByte2 = new System.Windows.Forms.TextBox();
            this.lblFileLinkedPage1 = new System.Windows.Forms.Label();
            this.txtFileLinkedPage1 = new System.Windows.Forms.TextBox();
            this.lblFileunidentifiedByte1 = new System.Windows.Forms.Label();
            this.txtFileUnidentifiedByte1 = new System.Windows.Forms.TextBox();
            this.lblFileSlope = new System.Windows.Forms.Label();
            this.lblFilecheckSum = new System.Windows.Forms.Label();
            this.lblFileLinkedPage2PlayCode = new System.Windows.Forms.Label();
            this.lblFileLinkedPage2 = new System.Windows.Forms.Label();
            this.lblFileLinkedPage1PlayCode = new System.Windows.Forms.Label();
            this.txtFilecheckSum = new System.Windows.Forms.TextBox();
            this.txtFileLinkedPage2PlayCode = new System.Windows.Forms.TextBox();
            this.txtFileLinkedPage2 = new System.Windows.Forms.TextBox();
            this.txtFileLinkedPage1PlayCode = new System.Windows.Forms.TextBox();
            this.lblFileExitPage = new System.Windows.Forms.Label();
            this.txtFileExitPage = new System.Windows.Forms.TextBox();
            this.lblFilenextPage = new System.Windows.Forms.Label();
            this.lblFileaccelTime = new System.Windows.Forms.Label();
            this.lblFiledxlSetup = new System.Windows.Forms.Label();
            this.lblFilePageSpeed = new System.Windows.Forms.Label();
            this.txtFileNextPage = new System.Windows.Forms.TextBox();
            this.txtFileAccelTime = new System.Windows.Forms.TextBox();
            this.txtFileDxlSetup = new System.Windows.Forms.TextBox();
            this.txtFilePageSpeed = new System.Windows.Forms.TextBox();
            this.lblFilePoseCount = new System.Windows.Forms.Label();
            this.txtFilePoseCount = new System.Windows.Forms.TextBox();
            this.lblFileRes1 = new System.Windows.Forms.Label();
            this.lblFileSchedule = new System.Windows.Forms.Label();
            this.lblFilePlayCount = new System.Windows.Forms.Label();
            this.lblFileUnidentifiedByte0 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFileSchedule = new System.Windows.Forms.TextBox();
            this.txtFilePlayCount = new System.Windows.Forms.TextBox();
            this.txtFileUnidentifiedByte0 = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.tpPageFromFlash = new System.Windows.Forms.TabPage();
            this.btnMotionBreak = new System.Windows.Forms.Button();
            this.btnFlashPlayPage = new System.Windows.Forms.Button();
            this.btnFlashPageDown = new System.Windows.Forms.Button();
            this.btnFlashPageUp = new System.Windows.Forms.Button();
            this.txtFlashPageNumber = new System.Windows.Forms.TextBox();
            this.lblFlashPageNumber = new System.Windows.Forms.Label();
            this.gbxFlashPoses = new System.Windows.Forms.GroupBox();
            this.lblPageS = new System.Windows.Forms.Label();
            this.lblPageD = new System.Windows.Forms.Label();
            this.gbxFlashHeader = new System.Windows.Forms.GroupBox();
            this.cmbFlashSlope = new System.Windows.Forms.ComboBox();
            this.cmbFlashRes1 = new System.Windows.Forms.ComboBox();
            this.lblFlashunidentifiedByte2 = new System.Windows.Forms.Label();
            this.txtFlashunidentifiedByte2 = new System.Windows.Forms.TextBox();
            this.lblFlashLinkedPage1 = new System.Windows.Forms.Label();
            this.txtFlashLinkedPage1 = new System.Windows.Forms.TextBox();
            this.lblFlashunidentifiedByte1 = new System.Windows.Forms.Label();
            this.txtFlashunidentifiedByte1 = new System.Windows.Forms.TextBox();
            this.lblFlashSlope = new System.Windows.Forms.Label();
            this.lblFlashChecksum = new System.Windows.Forms.Label();
            this.lblFlashLinkedPage2PlayCode = new System.Windows.Forms.Label();
            this.lblFlashLinkedPage2 = new System.Windows.Forms.Label();
            this.lblFlashLinkedPage1PlayCode = new System.Windows.Forms.Label();
            this.txtFlashChecksum = new System.Windows.Forms.TextBox();
            this.txtFlashLinkedPage2PlayCode = new System.Windows.Forms.TextBox();
            this.txtFlashLinkedPage2 = new System.Windows.Forms.TextBox();
            this.txtFlashLinkedPage1PlayCode = new System.Windows.Forms.TextBox();
            this.lblFlashExitPage = new System.Windows.Forms.Label();
            this.txtFlashExitPage = new System.Windows.Forms.TextBox();
            this.lblFlashNextPage = new System.Windows.Forms.Label();
            this.lblFlashaccelTime = new System.Windows.Forms.Label();
            this.lblFlashdxlSetup = new System.Windows.Forms.Label();
            this.lblFlashPageSpeed = new System.Windows.Forms.Label();
            this.txtFlashNextPage = new System.Windows.Forms.TextBox();
            this.txtFlashaccelTime = new System.Windows.Forms.TextBox();
            this.txtFlashdxlSetup = new System.Windows.Forms.TextBox();
            this.txtFlashPageSpeed = new System.Windows.Forms.TextBox();
            this.lblFlashPoseCount = new System.Windows.Forms.Label();
            this.txtFlashPoseCount = new System.Windows.Forms.TextBox();
            this.lblFlashRes1 = new System.Windows.Forms.Label();
            this.lblFlashSchedule = new System.Windows.Forms.Label();
            this.lblFlashPlayCount = new System.Windows.Forms.Label();
            this.lblFlashUnidentifiedByte0 = new System.Windows.Forms.Label();
            this.lblFlashName = new System.Windows.Forms.Label();
            this.txtFlashSchedule = new System.Windows.Forms.TextBox();
            this.txtFlashPlayCount = new System.Windows.Forms.TextBox();
            this.txtFlashUnidentifiedByte0 = new System.Windows.Forms.TextBox();
            this.txtFlashName = new System.Windows.Forms.TextBox();
            this.tpDynamixelReadWrite = new System.Windows.Forms.TabPage();
            this.grpbxAX12 = new System.Windows.Forms.GroupBox();
            this.lblAX12PresentSpeedHigh = new System.Windows.Forms.Label();
            this.lblAX12PresentSpeedLow = new System.Windows.Forms.Label();
            this.lblAX12PresentPositionHigh = new System.Windows.Forms.Label();
            this.lblAX12PresentPositionLow = new System.Windows.Forms.Label();
            this.lblAX12TorqueLimitHigh = new System.Windows.Forms.Label();
            this.lblAX12TorqueLimitLow = new System.Windows.Forms.Label();
            this.lblAX12MovingSpeedHigh = new System.Windows.Forms.Label();
            this.lblAX12MovingSpeedLow = new System.Windows.Forms.Label();
            this.lblAX12GoalPositionHigh = new System.Windows.Forms.Label();
            this.lblAX12GoalPositionLow = new System.Windows.Forms.Label();
            this.lblAX12CcwComplianceSlope = new System.Windows.Forms.Label();
            this.lblAX12CwComplianceSlope = new System.Windows.Forms.Label();
            this.lblAX12CcwComplianceMargin = new System.Windows.Forms.Label();
            this.lblAX12CwComplianceMargin = new System.Windows.Forms.Label();
            this.lblAX12LED = new System.Windows.Forms.Label();
            this.lblAX12TorqueEnable = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnReadAX12 = new System.Windows.Forms.Button();
            this.lblDynamixelID = new System.Windows.Forms.Label();
            this.cmbDynamixelID = new System.Windows.Forms.ComboBox();
            this.btnWritePosition = new System.Windows.Forms.Button();
            this.btnReadPosition = new System.Windows.Forms.Button();
            this.btnPing = new System.Windows.Forms.Button();
            this.gbControllerSerialConnection = new System.Windows.Forms.GroupBox();
            this.btnControllerSerialConnectionConnect = new System.Windows.Forms.Button();
            this.cmbControllerSerialConnectionDataBits = new System.Windows.Forms.ComboBox();
            this.lblControllerSerialConnectionDataBits = new System.Windows.Forms.Label();
            this.cmbControllerSerialConnectionStopBits = new System.Windows.Forms.ComboBox();
            this.lblControllerSerialConnectionStopBits = new System.Windows.Forms.Label();
            this.cmbControllerSerialConnectionFlow = new System.Windows.Forms.ComboBox();
            this.lblControllerSerialConnectionFlow = new System.Windows.Forms.Label();
            this.cmbControllerSerialConnectionParity = new System.Windows.Forms.ComboBox();
            this.lblControllerSerialConnectionParity = new System.Windows.Forms.Label();
            this.cmbControllerSerialConnectionBaud = new System.Windows.Forms.ComboBox();
            this.lblControllerSerialConnectionBaud = new System.Windows.Forms.Label();
            this.cmbControllerSerialConnectionCOM = new System.Windows.Forms.ComboBox();
            this.lblControllerSerialConnectionCOM = new System.Windows.Forms.Label();
            this.gbDebugSerialConnection = new System.Windows.Forms.GroupBox();
            this.btnDebugSerialConnectionConnect = new System.Windows.Forms.Button();
            this.cmbDebugSerialConnectionDataBits = new System.Windows.Forms.ComboBox();
            this.lblDebugSerialConnectionDataBits = new System.Windows.Forms.Label();
            this.cmbDebugSerialConnectionStopBits = new System.Windows.Forms.ComboBox();
            this.lblDebugSerialConnectionStopBits = new System.Windows.Forms.Label();
            this.cmbDebugSerialConnectionFlow = new System.Windows.Forms.ComboBox();
            this.lblDebugSerialConnectionFlow = new System.Windows.Forms.Label();
            this.cmbDebugSerialConnectionParity = new System.Windows.Forms.ComboBox();
            this.lblDebugSerialConnectionParity = new System.Windows.Forms.Label();
            this.cmbDebugSerialConnectionBaud = new System.Windows.Forms.ComboBox();
            this.lblDebugSerialConnectionBaud = new System.Windows.Forms.Label();
            this.cmbDebugSerialConnectionCOM = new System.Windows.Forms.ComboBox();
            this.lblDebugSerialConnectionCOM = new System.Windows.Forms.Label();
            this.txtDebugWindow = new System.Windows.Forms.TextBox();
            this.nudAX12 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
            this.lblAX12PresentLoadHigh = new System.Windows.Forms.Label();
            this.lblAX12PresentLoadLow = new System.Windows.Forms.Label();
            this.numericUpDown13 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown14 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown15 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown16 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown17 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown18 = new System.Windows.Forms.NumericUpDown();
            this.lblAX12ID = new System.Windows.Forms.Label();
            this.nudAX12ID = new System.Windows.Forms.NumericUpDown();
            this.tcMotionPages.SuspendLayout();
            this.tpPageFromFile.SuspendLayout();
            this.gbxFilePoses.SuspendLayout();
            this.gbxFileHeader.SuspendLayout();
            this.tpPageFromFlash.SuspendLayout();
            this.gbxFlashPoses.SuspendLayout();
            this.gbxFlashHeader.SuspendLayout();
            this.tpDynamixelReadWrite.SuspendLayout();
            this.grpbxAX12.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbControllerSerialConnection.SuspendLayout();
            this.gbDebugSerialConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAX12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAX12ID)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReceivedBytes
            // 
            this.lblReceivedBytes.AutoSize = true;
            this.lblReceivedBytes.Location = new System.Drawing.Point(11, 559);
            this.lblReceivedBytes.Name = "lblReceivedBytes";
            this.lblReceivedBytes.Size = new System.Drawing.Size(82, 13);
            this.lblReceivedBytes.TabIndex = 27;
            this.lblReceivedBytes.Text = "Received Bytes";
            // 
            // lblReceivedString
            // 
            this.lblReceivedString.AutoSize = true;
            this.lblReceivedString.Location = new System.Drawing.Point(11, 580);
            this.lblReceivedString.Name = "lblReceivedString";
            this.lblReceivedString.Size = new System.Drawing.Size(83, 13);
            this.lblReceivedString.TabIndex = 28;
            this.lblReceivedString.Text = "Received String";
            // 
            // txtReceivedBytes
            // 
            this.txtReceivedBytes.Location = new System.Drawing.Point(99, 556);
            this.txtReceivedBytes.Name = "txtReceivedBytes";
            this.txtReceivedBytes.Size = new System.Drawing.Size(864, 20);
            this.txtReceivedBytes.TabIndex = 29;
            // 
            // txtReceivedString
            // 
            this.txtReceivedString.Location = new System.Drawing.Point(99, 577);
            this.txtReceivedString.Name = "txtReceivedString";
            this.txtReceivedString.Size = new System.Drawing.Size(864, 20);
            this.txtReceivedString.TabIndex = 30;
            // 
            // tcMotionPages
            // 
            this.tcMotionPages.Controls.Add(this.tpPageFromFile);
            this.tcMotionPages.Controls.Add(this.tpPageFromFlash);
            this.tcMotionPages.Controls.Add(this.tpDynamixelReadWrite);
            this.tcMotionPages.Controls.Add(this.tabPage1);
            this.tcMotionPages.Location = new System.Drawing.Point(12, 137);
            this.tcMotionPages.Name = "tcMotionPages";
            this.tcMotionPages.SelectedIndex = 0;
            this.tcMotionPages.Size = new System.Drawing.Size(974, 419);
            this.tcMotionPages.TabIndex = 33;
            // 
            // tpPageFromFile
            // 
            this.tpPageFromFile.Controls.Add(this.btnFilePlayPage);
            this.tpPageFromFile.Controls.Add(this.btnFileWritePageToFlash);
            this.tpPageFromFile.Controls.Add(this.btnMakeHeaderFromPage);
            this.tpPageFromFile.Controls.Add(this.btnFileWriteToPageDown);
            this.tpPageFromFile.Controls.Add(this.txtByteFileName);
            this.tpPageFromFile.Controls.Add(this.btnFileWriteToPageUp);
            this.tpPageFromFile.Controls.Add(this.txtFilePageNumberToWrite);
            this.tpPageFromFile.Controls.Add(this.btnGetFile);
            this.tpPageFromFile.Controls.Add(this.lblFileAtPosition);
            this.tpPageFromFile.Controls.Add(this.btnFilePageDown);
            this.tpPageFromFile.Controls.Add(this.btnFilePageUp);
            this.tpPageFromFile.Controls.Add(this.txtFilePageNumber);
            this.tpPageFromFile.Controls.Add(this.lblFilePageNumber);
            this.tpPageFromFile.Controls.Add(this.gbxFilePoses);
            this.tpPageFromFile.Controls.Add(this.gbxFileHeader);
            this.tpPageFromFile.Location = new System.Drawing.Point(4, 22);
            this.tpPageFromFile.Name = "tpPageFromFile";
            this.tpPageFromFile.Padding = new System.Windows.Forms.Padding(3);
            this.tpPageFromFile.Size = new System.Drawing.Size(966, 393);
            this.tpPageFromFile.TabIndex = 0;
            this.tpPageFromFile.Text = "Page From File";
            this.tpPageFromFile.UseVisualStyleBackColor = true;
            // 
            // btnFilePlayPage
            // 
            this.btnFilePlayPage.Enabled = false;
            this.btnFilePlayPage.Location = new System.Drawing.Point(239, 365);
            this.btnFilePlayPage.Name = "btnFilePlayPage";
            this.btnFilePlayPage.Size = new System.Drawing.Size(73, 22);
            this.btnFilePlayPage.TabIndex = 38;
            this.btnFilePlayPage.Text = "Play Page";
            this.btnFilePlayPage.UseVisualStyleBackColor = true;
            this.btnFilePlayPage.Click += new System.EventHandler(this.btnFilePlayPage_Click);
            // 
            // btnFileWritePageToFlash
            // 
            this.btnFileWritePageToFlash.Enabled = false;
            this.btnFileWritePageToFlash.Location = new System.Drawing.Point(318, 365);
            this.btnFileWritePageToFlash.Name = "btnFileWritePageToFlash";
            this.btnFileWritePageToFlash.Size = new System.Drawing.Size(112, 22);
            this.btnFileWritePageToFlash.TabIndex = 37;
            this.btnFileWritePageToFlash.Text = "Write page to flash";
            this.btnFileWritePageToFlash.UseVisualStyleBackColor = true;
            this.btnFileWritePageToFlash.Click += new System.EventHandler(this.btnFileWritePageToFlash_Click);
            // 
            // btnMakeHeaderFromPage
            // 
            this.btnMakeHeaderFromPage.Enabled = false;
            this.btnMakeHeaderFromPage.Location = new System.Drawing.Point(96, 365);
            this.btnMakeHeaderFromPage.Name = "btnMakeHeaderFromPage";
            this.btnMakeHeaderFromPage.Size = new System.Drawing.Size(138, 22);
            this.btnMakeHeaderFromPage.TabIndex = 34;
            this.btnMakeHeaderFromPage.Text = "Make Header From Page";
            this.btnMakeHeaderFromPage.UseVisualStyleBackColor = true;
            this.btnMakeHeaderFromPage.Click += new System.EventHandler(this.btnMakeHeaderFromPage_Click);
            // 
            // btnFileWriteToPageDown
            // 
            this.btnFileWriteToPageDown.Location = new System.Drawing.Point(495, 366);
            this.btnFileWriteToPageDown.Name = "btnFileWriteToPageDown";
            this.btnFileWriteToPageDown.Size = new System.Drawing.Size(18, 18);
            this.btnFileWriteToPageDown.TabIndex = 36;
            this.btnFileWriteToPageDown.Text = "-";
            this.btnFileWriteToPageDown.UseVisualStyleBackColor = true;
            // 
            // txtByteFileName
            // 
            this.txtByteFileName.Location = new System.Drawing.Point(637, 364);
            this.txtByteFileName.Name = "txtByteFileName";
            this.txtByteFileName.Size = new System.Drawing.Size(233, 20);
            this.txtByteFileName.TabIndex = 33;
            // 
            // btnFileWriteToPageUp
            // 
            this.btnFileWriteToPageUp.Location = new System.Drawing.Point(554, 366);
            this.btnFileWriteToPageUp.Name = "btnFileWriteToPageUp";
            this.btnFileWriteToPageUp.Size = new System.Drawing.Size(18, 18);
            this.btnFileWriteToPageUp.TabIndex = 35;
            this.btnFileWriteToPageUp.Text = "+";
            this.btnFileWriteToPageUp.UseVisualStyleBackColor = true;
            this.btnFileWriteToPageUp.Click += new System.EventHandler(this.btnFileWriteToPageUp_Click);
            // 
            // txtFilePageNumberToWrite
            // 
            this.txtFilePageNumberToWrite.Location = new System.Drawing.Point(521, 366);
            this.txtFilePageNumberToWrite.Name = "txtFilePageNumberToWrite";
            this.txtFilePageNumberToWrite.Size = new System.Drawing.Size(27, 20);
            this.txtFilePageNumberToWrite.TabIndex = 34;
            this.txtFilePageNumberToWrite.Text = "1";
            // 
            // btnGetFile
            // 
            this.btnGetFile.Location = new System.Drawing.Point(578, 364);
            this.btnGetFile.Name = "btnGetFile";
            this.btnGetFile.Size = new System.Drawing.Size(53, 22);
            this.btnGetFile.TabIndex = 32;
            this.btnGetFile.Text = "Get File";
            this.btnGetFile.UseVisualStyleBackColor = true;
            this.btnGetFile.Click += new System.EventHandler(this.btnGetFile_Click);
            // 
            // lblFileAtPosition
            // 
            this.lblFileAtPosition.AutoSize = true;
            this.lblFileAtPosition.Location = new System.Drawing.Point(436, 370);
            this.lblFileAtPosition.Name = "lblFileAtPosition";
            this.lblFileAtPosition.Size = new System.Drawing.Size(58, 13);
            this.lblFileAtPosition.TabIndex = 33;
            this.lblFileAtPosition.Text = "at position:";
            // 
            // btnFilePageDown
            // 
            this.btnFilePageDown.Location = new System.Drawing.Point(500, 343);
            this.btnFilePageDown.Name = "btnFilePageDown";
            this.btnFilePageDown.Size = new System.Drawing.Size(18, 18);
            this.btnFilePageDown.TabIndex = 11;
            this.btnFilePageDown.Text = "-";
            this.btnFilePageDown.UseVisualStyleBackColor = true;
            this.btnFilePageDown.Click += new System.EventHandler(this.btnFilePageDown_Click);
            // 
            // btnFilePageUp
            // 
            this.btnFilePageUp.Location = new System.Drawing.Point(557, 342);
            this.btnFilePageUp.Name = "btnFilePageUp";
            this.btnFilePageUp.Size = new System.Drawing.Size(18, 18);
            this.btnFilePageUp.TabIndex = 10;
            this.btnFilePageUp.Text = "+";
            this.btnFilePageUp.UseVisualStyleBackColor = true;
            this.btnFilePageUp.Click += new System.EventHandler(this.btnFilePageUp_Click);
            // 
            // txtFilePageNumber
            // 
            this.txtFilePageNumber.Location = new System.Drawing.Point(524, 341);
            this.txtFilePageNumber.Name = "txtFilePageNumber";
            this.txtFilePageNumber.Size = new System.Drawing.Size(27, 20);
            this.txtFilePageNumber.TabIndex = 9;
            this.txtFilePageNumber.Text = "1";
            // 
            // lblFilePageNumber
            // 
            this.lblFilePageNumber.AutoSize = true;
            this.lblFilePageNumber.Location = new System.Drawing.Point(391, 345);
            this.lblFilePageNumber.Name = "lblFilePageNumber";
            this.lblFilePageNumber.Size = new System.Drawing.Size(112, 13);
            this.lblFilePageNumber.TabIndex = 8;
            this.lblFilePageNumber.Text = "Currently shown page:";
            // 
            // gbxFilePoses
            // 
            this.gbxFilePoses.Controls.Add(this.lblFileSpeed);
            this.gbxFilePoses.Controls.Add(this.lblFileDelay);
            this.gbxFilePoses.Location = new System.Drawing.Point(7, 134);
            this.gbxFilePoses.Name = "gbxFilePoses";
            this.gbxFilePoses.Size = new System.Drawing.Size(951, 201);
            this.gbxFilePoses.TabIndex = 7;
            this.gbxFilePoses.TabStop = false;
            this.gbxFilePoses.Text = "Poses";
            // 
            // lblFileSpeed
            // 
            this.lblFileSpeed.AutoSize = true;
            this.lblFileSpeed.Location = new System.Drawing.Point(910, 16);
            this.lblFileSpeed.Name = "lblFileSpeed";
            this.lblFileSpeed.Size = new System.Drawing.Size(14, 13);
            this.lblFileSpeed.TabIndex = 2;
            this.lblFileSpeed.Text = "S";
            // 
            // lblFileDelay
            // 
            this.lblFileDelay.AutoSize = true;
            this.lblFileDelay.Location = new System.Drawing.Point(885, 16);
            this.lblFileDelay.Name = "lblFileDelay";
            this.lblFileDelay.Size = new System.Drawing.Size(15, 13);
            this.lblFileDelay.TabIndex = 1;
            this.lblFileDelay.Text = "D";
            // 
            // gbxFileHeader
            // 
            this.gbxFileHeader.Controls.Add(this.cmbFileSlope);
            this.gbxFileHeader.Controls.Add(this.cmbFileRes1);
            this.gbxFileHeader.Controls.Add(this.lblFileunidentifiedByte2);
            this.gbxFileHeader.Controls.Add(this.txtFileunidentifiedByte2);
            this.gbxFileHeader.Controls.Add(this.lblFileLinkedPage1);
            this.gbxFileHeader.Controls.Add(this.txtFileLinkedPage1);
            this.gbxFileHeader.Controls.Add(this.lblFileunidentifiedByte1);
            this.gbxFileHeader.Controls.Add(this.txtFileUnidentifiedByte1);
            this.gbxFileHeader.Controls.Add(this.lblFileSlope);
            this.gbxFileHeader.Controls.Add(this.lblFilecheckSum);
            this.gbxFileHeader.Controls.Add(this.lblFileLinkedPage2PlayCode);
            this.gbxFileHeader.Controls.Add(this.lblFileLinkedPage2);
            this.gbxFileHeader.Controls.Add(this.lblFileLinkedPage1PlayCode);
            this.gbxFileHeader.Controls.Add(this.txtFilecheckSum);
            this.gbxFileHeader.Controls.Add(this.txtFileLinkedPage2PlayCode);
            this.gbxFileHeader.Controls.Add(this.txtFileLinkedPage2);
            this.gbxFileHeader.Controls.Add(this.txtFileLinkedPage1PlayCode);
            this.gbxFileHeader.Controls.Add(this.lblFileExitPage);
            this.gbxFileHeader.Controls.Add(this.txtFileExitPage);
            this.gbxFileHeader.Controls.Add(this.lblFilenextPage);
            this.gbxFileHeader.Controls.Add(this.lblFileaccelTime);
            this.gbxFileHeader.Controls.Add(this.lblFiledxlSetup);
            this.gbxFileHeader.Controls.Add(this.lblFilePageSpeed);
            this.gbxFileHeader.Controls.Add(this.txtFileNextPage);
            this.gbxFileHeader.Controls.Add(this.txtFileAccelTime);
            this.gbxFileHeader.Controls.Add(this.txtFileDxlSetup);
            this.gbxFileHeader.Controls.Add(this.txtFilePageSpeed);
            this.gbxFileHeader.Controls.Add(this.lblFilePoseCount);
            this.gbxFileHeader.Controls.Add(this.txtFilePoseCount);
            this.gbxFileHeader.Controls.Add(this.lblFileRes1);
            this.gbxFileHeader.Controls.Add(this.lblFileSchedule);
            this.gbxFileHeader.Controls.Add(this.lblFilePlayCount);
            this.gbxFileHeader.Controls.Add(this.lblFileUnidentifiedByte0);
            this.gbxFileHeader.Controls.Add(this.lblFileName);
            this.gbxFileHeader.Controls.Add(this.txtFileSchedule);
            this.gbxFileHeader.Controls.Add(this.txtFilePlayCount);
            this.gbxFileHeader.Controls.Add(this.txtFileUnidentifiedByte0);
            this.gbxFileHeader.Controls.Add(this.txtFileName);
            this.gbxFileHeader.Location = new System.Drawing.Point(6, 6);
            this.gbxFileHeader.Name = "gbxFileHeader";
            this.gbxFileHeader.Size = new System.Drawing.Size(952, 123);
            this.gbxFileHeader.TabIndex = 6;
            this.gbxFileHeader.TabStop = false;
            this.gbxFileHeader.Text = "Header";
            // 
            // cmbFileSlope
            // 
            this.cmbFileSlope.FormattingEnabled = true;
            this.cmbFileSlope.Location = new System.Drawing.Point(888, 68);
            this.cmbFileSlope.Name = "cmbFileSlope";
            this.cmbFileSlope.Size = new System.Drawing.Size(53, 21);
            this.cmbFileSlope.TabIndex = 39;
            // 
            // cmbFileRes1
            // 
            this.cmbFileRes1.FormattingEnabled = true;
            this.cmbFileRes1.Location = new System.Drawing.Point(262, 43);
            this.cmbFileRes1.Name = "cmbFileRes1";
            this.cmbFileRes1.Size = new System.Drawing.Size(53, 21);
            this.cmbFileRes1.TabIndex = 38;
            // 
            // lblFileunidentifiedByte2
            // 
            this.lblFileunidentifiedByte2.AutoSize = true;
            this.lblFileunidentifiedByte2.Location = new System.Drawing.Point(796, 96);
            this.lblFileunidentifiedByte2.Name = "lblFileunidentifiedByte2";
            this.lblFileunidentifiedByte2.Size = new System.Drawing.Size(88, 13);
            this.lblFileunidentifiedByte2.TabIndex = 37;
            this.lblFileunidentifiedByte2.Text = "unidentifiedByte2";
            this.lblFileunidentifiedByte2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFileunidentifiedByte2
            // 
            this.txtFileunidentifiedByte2.Location = new System.Drawing.Point(888, 93);
            this.txtFileunidentifiedByte2.Name = "txtFileunidentifiedByte2";
            this.txtFileunidentifiedByte2.Size = new System.Drawing.Size(53, 20);
            this.txtFileunidentifiedByte2.TabIndex = 36;
            // 
            // lblFileLinkedPage1
            // 
            this.lblFileLinkedPage1.AutoSize = true;
            this.lblFileLinkedPage1.Location = new System.Drawing.Point(471, 98);
            this.lblFileLinkedPage1.Name = "lblFileLinkedPage1";
            this.lblFileLinkedPage1.Size = new System.Drawing.Size(70, 13);
            this.lblFileLinkedPage1.TabIndex = 35;
            this.lblFileLinkedPage1.Text = "LinkedPage1";
            this.lblFileLinkedPage1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFileLinkedPage1
            // 
            this.txtFileLinkedPage1.Location = new System.Drawing.Point(547, 95);
            this.txtFileLinkedPage1.Name = "txtFileLinkedPage1";
            this.txtFileLinkedPage1.Size = new System.Drawing.Size(53, 20);
            this.txtFileLinkedPage1.TabIndex = 34;
            // 
            // lblFileunidentifiedByte1
            // 
            this.lblFileunidentifiedByte1.AutoSize = true;
            this.lblFileunidentifiedByte1.Location = new System.Drawing.Point(168, 95);
            this.lblFileunidentifiedByte1.Name = "lblFileunidentifiedByte1";
            this.lblFileunidentifiedByte1.Size = new System.Drawing.Size(88, 13);
            this.lblFileunidentifiedByte1.TabIndex = 33;
            this.lblFileunidentifiedByte1.Text = "unidentifiedByte1";
            this.lblFileunidentifiedByte1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFileUnidentifiedByte1
            // 
            this.txtFileUnidentifiedByte1.Location = new System.Drawing.Point(262, 91);
            this.txtFileUnidentifiedByte1.Name = "txtFileUnidentifiedByte1";
            this.txtFileUnidentifiedByte1.Size = new System.Drawing.Size(53, 20);
            this.txtFileUnidentifiedByte1.TabIndex = 32;
            // 
            // lblFileSlope
            // 
            this.lblFileSlope.AutoSize = true;
            this.lblFileSlope.Location = new System.Drawing.Point(848, 71);
            this.lblFileSlope.Name = "lblFileSlope";
            this.lblFileSlope.Size = new System.Drawing.Size(34, 13);
            this.lblFileSlope.TabIndex = 31;
            this.lblFileSlope.Text = "Slope";
            this.lblFileSlope.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFilecheckSum
            // 
            this.lblFilecheckSum.AutoSize = true;
            this.lblFilecheckSum.Location = new System.Drawing.Point(824, 46);
            this.lblFilecheckSum.Name = "lblFilecheckSum";
            this.lblFilecheckSum.Size = new System.Drawing.Size(58, 13);
            this.lblFilecheckSum.TabIndex = 29;
            this.lblFilecheckSum.Text = "checkSum";
            this.lblFilecheckSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFileLinkedPage2PlayCode
            // 
            this.lblFileLinkedPage2PlayCode.AutoSize = true;
            this.lblFileLinkedPage2PlayCode.Location = new System.Drawing.Point(619, 97);
            this.lblFileLinkedPage2PlayCode.Name = "lblFileLinkedPage2PlayCode";
            this.lblFileLinkedPage2PlayCode.Size = new System.Drawing.Size(115, 13);
            this.lblFileLinkedPage2PlayCode.TabIndex = 28;
            this.lblFileLinkedPage2PlayCode.Text = "LinkedPage2PlayCode";
            this.lblFileLinkedPage2PlayCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFileLinkedPage2
            // 
            this.lblFileLinkedPage2.AutoSize = true;
            this.lblFileLinkedPage2.Location = new System.Drawing.Point(662, 72);
            this.lblFileLinkedPage2.Name = "lblFileLinkedPage2";
            this.lblFileLinkedPage2.Size = new System.Drawing.Size(70, 13);
            this.lblFileLinkedPage2.TabIndex = 27;
            this.lblFileLinkedPage2.Text = "LinkedPage2";
            this.lblFileLinkedPage2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFileLinkedPage1PlayCode
            // 
            this.lblFileLinkedPage1PlayCode.AutoSize = true;
            this.lblFileLinkedPage1PlayCode.Location = new System.Drawing.Point(617, 46);
            this.lblFileLinkedPage1PlayCode.Name = "lblFileLinkedPage1PlayCode";
            this.lblFileLinkedPage1PlayCode.Size = new System.Drawing.Size(115, 13);
            this.lblFileLinkedPage1PlayCode.TabIndex = 26;
            this.lblFileLinkedPage1PlayCode.Text = "LinkedPage1PlayCode";
            this.lblFileLinkedPage1PlayCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFilecheckSum
            // 
            this.txtFilecheckSum.Location = new System.Drawing.Point(888, 43);
            this.txtFilecheckSum.Name = "txtFilecheckSum";
            this.txtFilecheckSum.Size = new System.Drawing.Size(53, 20);
            this.txtFilecheckSum.TabIndex = 25;
            // 
            // txtFileLinkedPage2PlayCode
            // 
            this.txtFileLinkedPage2PlayCode.Location = new System.Drawing.Point(738, 93);
            this.txtFileLinkedPage2PlayCode.Name = "txtFileLinkedPage2PlayCode";
            this.txtFileLinkedPage2PlayCode.Size = new System.Drawing.Size(53, 20);
            this.txtFileLinkedPage2PlayCode.TabIndex = 24;
            // 
            // txtFileLinkedPage2
            // 
            this.txtFileLinkedPage2.Location = new System.Drawing.Point(738, 68);
            this.txtFileLinkedPage2.Name = "txtFileLinkedPage2";
            this.txtFileLinkedPage2.Size = new System.Drawing.Size(53, 20);
            this.txtFileLinkedPage2.TabIndex = 23;
            // 
            // txtFileLinkedPage1PlayCode
            // 
            this.txtFileLinkedPage1PlayCode.Location = new System.Drawing.Point(738, 43);
            this.txtFileLinkedPage1PlayCode.Name = "txtFileLinkedPage1PlayCode";
            this.txtFileLinkedPage1PlayCode.Size = new System.Drawing.Size(53, 20);
            this.txtFileLinkedPage1PlayCode.TabIndex = 22;
            // 
            // lblFileExitPage
            // 
            this.lblFileExitPage.AutoSize = true;
            this.lblFileExitPage.Location = new System.Drawing.Point(492, 73);
            this.lblFileExitPage.Name = "lblFileExitPage";
            this.lblFileExitPage.Size = new System.Drawing.Size(49, 13);
            this.lblFileExitPage.TabIndex = 21;
            this.lblFileExitPage.Text = "ExitPage";
            this.lblFileExitPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFileExitPage
            // 
            this.txtFileExitPage.Location = new System.Drawing.Point(547, 69);
            this.txtFileExitPage.Name = "txtFileExitPage";
            this.txtFileExitPage.Size = new System.Drawing.Size(53, 20);
            this.txtFileExitPage.TabIndex = 20;
            // 
            // lblFilenextPage
            // 
            this.lblFilenextPage.AutoSize = true;
            this.lblFilenextPage.Location = new System.Drawing.Point(489, 46);
            this.lblFilenextPage.Name = "lblFilenextPage";
            this.lblFilenextPage.Size = new System.Drawing.Size(52, 13);
            this.lblFilenextPage.TabIndex = 19;
            this.lblFilenextPage.Text = "nextPage";
            this.lblFilenextPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFileaccelTime
            // 
            this.lblFileaccelTime.AutoSize = true;
            this.lblFileaccelTime.Location = new System.Drawing.Point(343, 96);
            this.lblFileaccelTime.Name = "lblFileaccelTime";
            this.lblFileaccelTime.Size = new System.Drawing.Size(56, 13);
            this.lblFileaccelTime.TabIndex = 18;
            this.lblFileaccelTime.Text = "accelTime";
            this.lblFileaccelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFiledxlSetup
            // 
            this.lblFiledxlSetup.AutoSize = true;
            this.lblFiledxlSetup.Location = new System.Drawing.Point(351, 71);
            this.lblFiledxlSetup.Name = "lblFiledxlSetup";
            this.lblFiledxlSetup.Size = new System.Drawing.Size(48, 13);
            this.lblFiledxlSetup.TabIndex = 17;
            this.lblFiledxlSetup.Text = "dxlSetup";
            this.lblFiledxlSetup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFilePageSpeed
            // 
            this.lblFilePageSpeed.AutoSize = true;
            this.lblFilePageSpeed.Location = new System.Drawing.Point(336, 45);
            this.lblFilePageSpeed.Name = "lblFilePageSpeed";
            this.lblFilePageSpeed.Size = new System.Drawing.Size(63, 13);
            this.lblFilePageSpeed.TabIndex = 16;
            this.lblFilePageSpeed.Text = "PageSpeed";
            this.lblFilePageSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFileNextPage
            // 
            this.txtFileNextPage.Location = new System.Drawing.Point(547, 42);
            this.txtFileNextPage.Name = "txtFileNextPage";
            this.txtFileNextPage.Size = new System.Drawing.Size(53, 20);
            this.txtFileNextPage.TabIndex = 15;
            // 
            // txtFileAccelTime
            // 
            this.txtFileAccelTime.Location = new System.Drawing.Point(405, 92);
            this.txtFileAccelTime.Name = "txtFileAccelTime";
            this.txtFileAccelTime.Size = new System.Drawing.Size(53, 20);
            this.txtFileAccelTime.TabIndex = 14;
            // 
            // txtFileDxlSetup
            // 
            this.txtFileDxlSetup.Location = new System.Drawing.Point(405, 67);
            this.txtFileDxlSetup.Name = "txtFileDxlSetup";
            this.txtFileDxlSetup.Size = new System.Drawing.Size(53, 20);
            this.txtFileDxlSetup.TabIndex = 13;
            // 
            // txtFilePageSpeed
            // 
            this.txtFilePageSpeed.Location = new System.Drawing.Point(405, 42);
            this.txtFilePageSpeed.Name = "txtFilePageSpeed";
            this.txtFilePageSpeed.Size = new System.Drawing.Size(53, 20);
            this.txtFilePageSpeed.TabIndex = 12;
            // 
            // lblFilePoseCount
            // 
            this.lblFilePoseCount.AutoSize = true;
            this.lblFilePoseCount.Location = new System.Drawing.Point(197, 71);
            this.lblFilePoseCount.Name = "lblFilePoseCount";
            this.lblFilePoseCount.Size = new System.Drawing.Size(59, 13);
            this.lblFilePoseCount.TabIndex = 11;
            this.lblFilePoseCount.Text = "PoseCount";
            this.lblFilePoseCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFilePoseCount
            // 
            this.txtFilePoseCount.Location = new System.Drawing.Point(262, 67);
            this.txtFilePoseCount.Name = "txtFilePoseCount";
            this.txtFilePoseCount.Size = new System.Drawing.Size(53, 20);
            this.txtFilePoseCount.TabIndex = 10;
            // 
            // lblFileRes1
            // 
            this.lblFileRes1.AutoSize = true;
            this.lblFileRes1.Location = new System.Drawing.Point(224, 46);
            this.lblFileRes1.Name = "lblFileRes1";
            this.lblFileRes1.Size = new System.Drawing.Size(32, 13);
            this.lblFileRes1.TabIndex = 9;
            this.lblFileRes1.Text = "Res1";
            this.lblFileRes1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFileSchedule
            // 
            this.lblFileSchedule.AutoSize = true;
            this.lblFileSchedule.Location = new System.Drawing.Point(51, 95);
            this.lblFileSchedule.Name = "lblFileSchedule";
            this.lblFileSchedule.Size = new System.Drawing.Size(52, 13);
            this.lblFileSchedule.TabIndex = 8;
            this.lblFileSchedule.Text = "Schedule";
            this.lblFileSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFilePlayCount
            // 
            this.lblFilePlayCount.AutoSize = true;
            this.lblFilePlayCount.Location = new System.Drawing.Point(45, 70);
            this.lblFilePlayCount.Name = "lblFilePlayCount";
            this.lblFilePlayCount.Size = new System.Drawing.Size(58, 13);
            this.lblFilePlayCount.TabIndex = 7;
            this.lblFilePlayCount.Text = "Play Count";
            this.lblFilePlayCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFileUnidentifiedByte0
            // 
            this.lblFileUnidentifiedByte0.AutoSize = true;
            this.lblFileUnidentifiedByte0.Location = new System.Drawing.Point(13, 44);
            this.lblFileUnidentifiedByte0.Name = "lblFileUnidentifiedByte0";
            this.lblFileUnidentifiedByte0.Size = new System.Drawing.Size(90, 13);
            this.lblFileUnidentifiedByte0.TabIndex = 6;
            this.lblFileUnidentifiedByte0.Text = "UnidentifiedByte0";
            this.lblFileUnidentifiedByte0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(68, 19);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(35, 13);
            this.lblFileName.TabIndex = 5;
            this.lblFileName.Text = "Name";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFileSchedule
            // 
            this.txtFileSchedule.Location = new System.Drawing.Point(109, 91);
            this.txtFileSchedule.Name = "txtFileSchedule";
            this.txtFileSchedule.Size = new System.Drawing.Size(53, 20);
            this.txtFileSchedule.TabIndex = 3;
            // 
            // txtFilePlayCount
            // 
            this.txtFilePlayCount.Location = new System.Drawing.Point(109, 66);
            this.txtFilePlayCount.Name = "txtFilePlayCount";
            this.txtFilePlayCount.Size = new System.Drawing.Size(53, 20);
            this.txtFilePlayCount.TabIndex = 2;
            // 
            // txtFileUnidentifiedByte0
            // 
            this.txtFileUnidentifiedByte0.Location = new System.Drawing.Point(109, 41);
            this.txtFileUnidentifiedByte0.Name = "txtFileUnidentifiedByte0";
            this.txtFileUnidentifiedByte0.Size = new System.Drawing.Size(53, 20);
            this.txtFileUnidentifiedByte0.TabIndex = 1;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(109, 16);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(832, 20);
            this.txtFileName.TabIndex = 0;
            // 
            // tpPageFromFlash
            // 
            this.tpPageFromFlash.Controls.Add(this.btnMotionBreak);
            this.tpPageFromFlash.Controls.Add(this.btnFlashPlayPage);
            this.tpPageFromFlash.Controls.Add(this.btnFlashPageDown);
            this.tpPageFromFlash.Controls.Add(this.btnFlashPageUp);
            this.tpPageFromFlash.Controls.Add(this.txtFlashPageNumber);
            this.tpPageFromFlash.Controls.Add(this.lblFlashPageNumber);
            this.tpPageFromFlash.Controls.Add(this.gbxFlashPoses);
            this.tpPageFromFlash.Controls.Add(this.gbxFlashHeader);
            this.tpPageFromFlash.Location = new System.Drawing.Point(4, 22);
            this.tpPageFromFlash.Name = "tpPageFromFlash";
            this.tpPageFromFlash.Padding = new System.Windows.Forms.Padding(3);
            this.tpPageFromFlash.Size = new System.Drawing.Size(966, 393);
            this.tpPageFromFlash.TabIndex = 1;
            this.tpPageFromFlash.Text = "Page From Flash";
            this.tpPageFromFlash.UseVisualStyleBackColor = true;
            // 
            // btnMotionBreak
            // 
            this.btnMotionBreak.Location = new System.Drawing.Point(431, 364);
            this.btnMotionBreak.Name = "btnMotionBreak";
            this.btnMotionBreak.Size = new System.Drawing.Size(73, 22);
            this.btnMotionBreak.TabIndex = 46;
            this.btnMotionBreak.Text = "Break Page";
            this.btnMotionBreak.UseVisualStyleBackColor = true;
            this.btnMotionBreak.Click += new System.EventHandler(this.btnMotionBreak_Click);
            // 
            // btnFlashPlayPage
            // 
            this.btnFlashPlayPage.Enabled = false;
            this.btnFlashPlayPage.Location = new System.Drawing.Point(352, 365);
            this.btnFlashPlayPage.Name = "btnFlashPlayPage";
            this.btnFlashPlayPage.Size = new System.Drawing.Size(73, 22);
            this.btnFlashPlayPage.TabIndex = 45;
            this.btnFlashPlayPage.Text = "Play Page";
            this.btnFlashPlayPage.UseVisualStyleBackColor = true;
            this.btnFlashPlayPage.Click += new System.EventHandler(this.btnFlashPlayPage_Click);
            // 
            // btnFlashPageDown
            // 
            this.btnFlashPageDown.Location = new System.Drawing.Point(500, 343);
            this.btnFlashPageDown.Name = "btnFlashPageDown";
            this.btnFlashPageDown.Size = new System.Drawing.Size(18, 18);
            this.btnFlashPageDown.TabIndex = 44;
            this.btnFlashPageDown.Text = "-";
            this.btnFlashPageDown.UseVisualStyleBackColor = true;
            this.btnFlashPageDown.Click += new System.EventHandler(this.btnFlashPageDown_Click);
            // 
            // btnFlashPageUp
            // 
            this.btnFlashPageUp.Location = new System.Drawing.Point(557, 342);
            this.btnFlashPageUp.Name = "btnFlashPageUp";
            this.btnFlashPageUp.Size = new System.Drawing.Size(18, 18);
            this.btnFlashPageUp.TabIndex = 43;
            this.btnFlashPageUp.Text = "+";
            this.btnFlashPageUp.UseVisualStyleBackColor = true;
            this.btnFlashPageUp.Click += new System.EventHandler(this.btnFlashPageUp_Click);
            // 
            // txtFlashPageNumber
            // 
            this.txtFlashPageNumber.Location = new System.Drawing.Point(524, 341);
            this.txtFlashPageNumber.Name = "txtFlashPageNumber";
            this.txtFlashPageNumber.Size = new System.Drawing.Size(27, 20);
            this.txtFlashPageNumber.TabIndex = 42;
            this.txtFlashPageNumber.Text = "1";
            // 
            // lblFlashPageNumber
            // 
            this.lblFlashPageNumber.AutoSize = true;
            this.lblFlashPageNumber.Location = new System.Drawing.Point(391, 345);
            this.lblFlashPageNumber.Name = "lblFlashPageNumber";
            this.lblFlashPageNumber.Size = new System.Drawing.Size(112, 13);
            this.lblFlashPageNumber.TabIndex = 41;
            this.lblFlashPageNumber.Text = "Currently shown page:";
            // 
            // gbxFlashPoses
            // 
            this.gbxFlashPoses.Controls.Add(this.lblPageS);
            this.gbxFlashPoses.Controls.Add(this.lblPageD);
            this.gbxFlashPoses.Location = new System.Drawing.Point(7, 134);
            this.gbxFlashPoses.Name = "gbxFlashPoses";
            this.gbxFlashPoses.Size = new System.Drawing.Size(951, 201);
            this.gbxFlashPoses.TabIndex = 40;
            this.gbxFlashPoses.TabStop = false;
            this.gbxFlashPoses.Text = "Poses";
            // 
            // lblPageS
            // 
            this.lblPageS.AutoSize = true;
            this.lblPageS.Location = new System.Drawing.Point(910, 16);
            this.lblPageS.Name = "lblPageS";
            this.lblPageS.Size = new System.Drawing.Size(14, 13);
            this.lblPageS.TabIndex = 2;
            this.lblPageS.Text = "S";
            // 
            // lblPageD
            // 
            this.lblPageD.AutoSize = true;
            this.lblPageD.Location = new System.Drawing.Point(885, 16);
            this.lblPageD.Name = "lblPageD";
            this.lblPageD.Size = new System.Drawing.Size(15, 13);
            this.lblPageD.TabIndex = 1;
            this.lblPageD.Text = "D";
            // 
            // gbxFlashHeader
            // 
            this.gbxFlashHeader.Controls.Add(this.cmbFlashSlope);
            this.gbxFlashHeader.Controls.Add(this.cmbFlashRes1);
            this.gbxFlashHeader.Controls.Add(this.lblFlashunidentifiedByte2);
            this.gbxFlashHeader.Controls.Add(this.txtFlashunidentifiedByte2);
            this.gbxFlashHeader.Controls.Add(this.lblFlashLinkedPage1);
            this.gbxFlashHeader.Controls.Add(this.txtFlashLinkedPage1);
            this.gbxFlashHeader.Controls.Add(this.lblFlashunidentifiedByte1);
            this.gbxFlashHeader.Controls.Add(this.txtFlashunidentifiedByte1);
            this.gbxFlashHeader.Controls.Add(this.lblFlashSlope);
            this.gbxFlashHeader.Controls.Add(this.lblFlashChecksum);
            this.gbxFlashHeader.Controls.Add(this.lblFlashLinkedPage2PlayCode);
            this.gbxFlashHeader.Controls.Add(this.lblFlashLinkedPage2);
            this.gbxFlashHeader.Controls.Add(this.lblFlashLinkedPage1PlayCode);
            this.gbxFlashHeader.Controls.Add(this.txtFlashChecksum);
            this.gbxFlashHeader.Controls.Add(this.txtFlashLinkedPage2PlayCode);
            this.gbxFlashHeader.Controls.Add(this.txtFlashLinkedPage2);
            this.gbxFlashHeader.Controls.Add(this.txtFlashLinkedPage1PlayCode);
            this.gbxFlashHeader.Controls.Add(this.lblFlashExitPage);
            this.gbxFlashHeader.Controls.Add(this.txtFlashExitPage);
            this.gbxFlashHeader.Controls.Add(this.lblFlashNextPage);
            this.gbxFlashHeader.Controls.Add(this.lblFlashaccelTime);
            this.gbxFlashHeader.Controls.Add(this.lblFlashdxlSetup);
            this.gbxFlashHeader.Controls.Add(this.lblFlashPageSpeed);
            this.gbxFlashHeader.Controls.Add(this.txtFlashNextPage);
            this.gbxFlashHeader.Controls.Add(this.txtFlashaccelTime);
            this.gbxFlashHeader.Controls.Add(this.txtFlashdxlSetup);
            this.gbxFlashHeader.Controls.Add(this.txtFlashPageSpeed);
            this.gbxFlashHeader.Controls.Add(this.lblFlashPoseCount);
            this.gbxFlashHeader.Controls.Add(this.txtFlashPoseCount);
            this.gbxFlashHeader.Controls.Add(this.lblFlashRes1);
            this.gbxFlashHeader.Controls.Add(this.lblFlashSchedule);
            this.gbxFlashHeader.Controls.Add(this.lblFlashPlayCount);
            this.gbxFlashHeader.Controls.Add(this.lblFlashUnidentifiedByte0);
            this.gbxFlashHeader.Controls.Add(this.lblFlashName);
            this.gbxFlashHeader.Controls.Add(this.txtFlashSchedule);
            this.gbxFlashHeader.Controls.Add(this.txtFlashPlayCount);
            this.gbxFlashHeader.Controls.Add(this.txtFlashUnidentifiedByte0);
            this.gbxFlashHeader.Controls.Add(this.txtFlashName);
            this.gbxFlashHeader.Location = new System.Drawing.Point(6, 6);
            this.gbxFlashHeader.Name = "gbxFlashHeader";
            this.gbxFlashHeader.Size = new System.Drawing.Size(952, 123);
            this.gbxFlashHeader.TabIndex = 39;
            this.gbxFlashHeader.TabStop = false;
            this.gbxFlashHeader.Text = "Header";
            // 
            // cmbFlashSlope
            // 
            this.cmbFlashSlope.FormattingEnabled = true;
            this.cmbFlashSlope.Location = new System.Drawing.Point(888, 68);
            this.cmbFlashSlope.Name = "cmbFlashSlope";
            this.cmbFlashSlope.Size = new System.Drawing.Size(53, 21);
            this.cmbFlashSlope.TabIndex = 39;
            // 
            // cmbFlashRes1
            // 
            this.cmbFlashRes1.FormattingEnabled = true;
            this.cmbFlashRes1.Location = new System.Drawing.Point(262, 43);
            this.cmbFlashRes1.Name = "cmbFlashRes1";
            this.cmbFlashRes1.Size = new System.Drawing.Size(53, 21);
            this.cmbFlashRes1.TabIndex = 38;
            // 
            // lblFlashunidentifiedByte2
            // 
            this.lblFlashunidentifiedByte2.AutoSize = true;
            this.lblFlashunidentifiedByte2.Location = new System.Drawing.Point(796, 96);
            this.lblFlashunidentifiedByte2.Name = "lblFlashunidentifiedByte2";
            this.lblFlashunidentifiedByte2.Size = new System.Drawing.Size(88, 13);
            this.lblFlashunidentifiedByte2.TabIndex = 37;
            this.lblFlashunidentifiedByte2.Text = "unidentifiedByte2";
            this.lblFlashunidentifiedByte2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFlashunidentifiedByte2
            // 
            this.txtFlashunidentifiedByte2.Location = new System.Drawing.Point(888, 93);
            this.txtFlashunidentifiedByte2.Name = "txtFlashunidentifiedByte2";
            this.txtFlashunidentifiedByte2.Size = new System.Drawing.Size(53, 20);
            this.txtFlashunidentifiedByte2.TabIndex = 36;
            // 
            // lblFlashLinkedPage1
            // 
            this.lblFlashLinkedPage1.AutoSize = true;
            this.lblFlashLinkedPage1.Location = new System.Drawing.Point(471, 98);
            this.lblFlashLinkedPage1.Name = "lblFlashLinkedPage1";
            this.lblFlashLinkedPage1.Size = new System.Drawing.Size(70, 13);
            this.lblFlashLinkedPage1.TabIndex = 35;
            this.lblFlashLinkedPage1.Text = "LinkedPage1";
            this.lblFlashLinkedPage1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFlashLinkedPage1
            // 
            this.txtFlashLinkedPage1.Location = new System.Drawing.Point(547, 95);
            this.txtFlashLinkedPage1.Name = "txtFlashLinkedPage1";
            this.txtFlashLinkedPage1.Size = new System.Drawing.Size(53, 20);
            this.txtFlashLinkedPage1.TabIndex = 34;
            // 
            // lblFlashunidentifiedByte1
            // 
            this.lblFlashunidentifiedByte1.AutoSize = true;
            this.lblFlashunidentifiedByte1.Location = new System.Drawing.Point(168, 95);
            this.lblFlashunidentifiedByte1.Name = "lblFlashunidentifiedByte1";
            this.lblFlashunidentifiedByte1.Size = new System.Drawing.Size(88, 13);
            this.lblFlashunidentifiedByte1.TabIndex = 33;
            this.lblFlashunidentifiedByte1.Text = "unidentifiedByte1";
            this.lblFlashunidentifiedByte1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFlashunidentifiedByte1
            // 
            this.txtFlashunidentifiedByte1.Location = new System.Drawing.Point(262, 91);
            this.txtFlashunidentifiedByte1.Name = "txtFlashunidentifiedByte1";
            this.txtFlashunidentifiedByte1.Size = new System.Drawing.Size(53, 20);
            this.txtFlashunidentifiedByte1.TabIndex = 32;
            // 
            // lblFlashSlope
            // 
            this.lblFlashSlope.AutoSize = true;
            this.lblFlashSlope.Location = new System.Drawing.Point(848, 71);
            this.lblFlashSlope.Name = "lblFlashSlope";
            this.lblFlashSlope.Size = new System.Drawing.Size(34, 13);
            this.lblFlashSlope.TabIndex = 31;
            this.lblFlashSlope.Text = "Slope";
            this.lblFlashSlope.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFlashChecksum
            // 
            this.lblFlashChecksum.AutoSize = true;
            this.lblFlashChecksum.Location = new System.Drawing.Point(824, 46);
            this.lblFlashChecksum.Name = "lblFlashChecksum";
            this.lblFlashChecksum.Size = new System.Drawing.Size(58, 13);
            this.lblFlashChecksum.TabIndex = 29;
            this.lblFlashChecksum.Text = "checkSum";
            this.lblFlashChecksum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFlashLinkedPage2PlayCode
            // 
            this.lblFlashLinkedPage2PlayCode.AutoSize = true;
            this.lblFlashLinkedPage2PlayCode.Location = new System.Drawing.Point(619, 97);
            this.lblFlashLinkedPage2PlayCode.Name = "lblFlashLinkedPage2PlayCode";
            this.lblFlashLinkedPage2PlayCode.Size = new System.Drawing.Size(115, 13);
            this.lblFlashLinkedPage2PlayCode.TabIndex = 28;
            this.lblFlashLinkedPage2PlayCode.Text = "LinkedPage2PlayCode";
            this.lblFlashLinkedPage2PlayCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFlashLinkedPage2
            // 
            this.lblFlashLinkedPage2.AutoSize = true;
            this.lblFlashLinkedPage2.Location = new System.Drawing.Point(662, 72);
            this.lblFlashLinkedPage2.Name = "lblFlashLinkedPage2";
            this.lblFlashLinkedPage2.Size = new System.Drawing.Size(70, 13);
            this.lblFlashLinkedPage2.TabIndex = 27;
            this.lblFlashLinkedPage2.Text = "LinkedPage2";
            this.lblFlashLinkedPage2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFlashLinkedPage1PlayCode
            // 
            this.lblFlashLinkedPage1PlayCode.AutoSize = true;
            this.lblFlashLinkedPage1PlayCode.Location = new System.Drawing.Point(617, 46);
            this.lblFlashLinkedPage1PlayCode.Name = "lblFlashLinkedPage1PlayCode";
            this.lblFlashLinkedPage1PlayCode.Size = new System.Drawing.Size(115, 13);
            this.lblFlashLinkedPage1PlayCode.TabIndex = 26;
            this.lblFlashLinkedPage1PlayCode.Text = "LinkedPage1PlayCode";
            this.lblFlashLinkedPage1PlayCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFlashChecksum
            // 
            this.txtFlashChecksum.Location = new System.Drawing.Point(888, 43);
            this.txtFlashChecksum.Name = "txtFlashChecksum";
            this.txtFlashChecksum.Size = new System.Drawing.Size(53, 20);
            this.txtFlashChecksum.TabIndex = 25;
            // 
            // txtFlashLinkedPage2PlayCode
            // 
            this.txtFlashLinkedPage2PlayCode.Location = new System.Drawing.Point(738, 93);
            this.txtFlashLinkedPage2PlayCode.Name = "txtFlashLinkedPage2PlayCode";
            this.txtFlashLinkedPage2PlayCode.Size = new System.Drawing.Size(53, 20);
            this.txtFlashLinkedPage2PlayCode.TabIndex = 24;
            // 
            // txtFlashLinkedPage2
            // 
            this.txtFlashLinkedPage2.Location = new System.Drawing.Point(738, 68);
            this.txtFlashLinkedPage2.Name = "txtFlashLinkedPage2";
            this.txtFlashLinkedPage2.Size = new System.Drawing.Size(53, 20);
            this.txtFlashLinkedPage2.TabIndex = 23;
            // 
            // txtFlashLinkedPage1PlayCode
            // 
            this.txtFlashLinkedPage1PlayCode.Location = new System.Drawing.Point(738, 43);
            this.txtFlashLinkedPage1PlayCode.Name = "txtFlashLinkedPage1PlayCode";
            this.txtFlashLinkedPage1PlayCode.Size = new System.Drawing.Size(53, 20);
            this.txtFlashLinkedPage1PlayCode.TabIndex = 22;
            // 
            // lblFlashExitPage
            // 
            this.lblFlashExitPage.AutoSize = true;
            this.lblFlashExitPage.Location = new System.Drawing.Point(492, 73);
            this.lblFlashExitPage.Name = "lblFlashExitPage";
            this.lblFlashExitPage.Size = new System.Drawing.Size(49, 13);
            this.lblFlashExitPage.TabIndex = 21;
            this.lblFlashExitPage.Text = "ExitPage";
            this.lblFlashExitPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFlashExitPage
            // 
            this.txtFlashExitPage.Location = new System.Drawing.Point(547, 69);
            this.txtFlashExitPage.Name = "txtFlashExitPage";
            this.txtFlashExitPage.Size = new System.Drawing.Size(53, 20);
            this.txtFlashExitPage.TabIndex = 20;
            // 
            // lblFlashNextPage
            // 
            this.lblFlashNextPage.AutoSize = true;
            this.lblFlashNextPage.Location = new System.Drawing.Point(489, 46);
            this.lblFlashNextPage.Name = "lblFlashNextPage";
            this.lblFlashNextPage.Size = new System.Drawing.Size(52, 13);
            this.lblFlashNextPage.TabIndex = 19;
            this.lblFlashNextPage.Text = "nextPage";
            this.lblFlashNextPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFlashaccelTime
            // 
            this.lblFlashaccelTime.AutoSize = true;
            this.lblFlashaccelTime.Location = new System.Drawing.Point(343, 96);
            this.lblFlashaccelTime.Name = "lblFlashaccelTime";
            this.lblFlashaccelTime.Size = new System.Drawing.Size(56, 13);
            this.lblFlashaccelTime.TabIndex = 18;
            this.lblFlashaccelTime.Text = "accelTime";
            this.lblFlashaccelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFlashdxlSetup
            // 
            this.lblFlashdxlSetup.AutoSize = true;
            this.lblFlashdxlSetup.Location = new System.Drawing.Point(351, 71);
            this.lblFlashdxlSetup.Name = "lblFlashdxlSetup";
            this.lblFlashdxlSetup.Size = new System.Drawing.Size(48, 13);
            this.lblFlashdxlSetup.TabIndex = 17;
            this.lblFlashdxlSetup.Text = "dxlSetup";
            this.lblFlashdxlSetup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFlashPageSpeed
            // 
            this.lblFlashPageSpeed.AutoSize = true;
            this.lblFlashPageSpeed.Location = new System.Drawing.Point(336, 45);
            this.lblFlashPageSpeed.Name = "lblFlashPageSpeed";
            this.lblFlashPageSpeed.Size = new System.Drawing.Size(63, 13);
            this.lblFlashPageSpeed.TabIndex = 16;
            this.lblFlashPageSpeed.Text = "PageSpeed";
            this.lblFlashPageSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFlashNextPage
            // 
            this.txtFlashNextPage.Location = new System.Drawing.Point(547, 42);
            this.txtFlashNextPage.Name = "txtFlashNextPage";
            this.txtFlashNextPage.Size = new System.Drawing.Size(53, 20);
            this.txtFlashNextPage.TabIndex = 15;
            // 
            // txtFlashaccelTime
            // 
            this.txtFlashaccelTime.Location = new System.Drawing.Point(405, 92);
            this.txtFlashaccelTime.Name = "txtFlashaccelTime";
            this.txtFlashaccelTime.Size = new System.Drawing.Size(53, 20);
            this.txtFlashaccelTime.TabIndex = 14;
            // 
            // txtFlashdxlSetup
            // 
            this.txtFlashdxlSetup.Location = new System.Drawing.Point(405, 67);
            this.txtFlashdxlSetup.Name = "txtFlashdxlSetup";
            this.txtFlashdxlSetup.Size = new System.Drawing.Size(53, 20);
            this.txtFlashdxlSetup.TabIndex = 13;
            // 
            // txtFlashPageSpeed
            // 
            this.txtFlashPageSpeed.Location = new System.Drawing.Point(405, 42);
            this.txtFlashPageSpeed.Name = "txtFlashPageSpeed";
            this.txtFlashPageSpeed.Size = new System.Drawing.Size(53, 20);
            this.txtFlashPageSpeed.TabIndex = 12;
            // 
            // lblFlashPoseCount
            // 
            this.lblFlashPoseCount.AutoSize = true;
            this.lblFlashPoseCount.Location = new System.Drawing.Point(197, 71);
            this.lblFlashPoseCount.Name = "lblFlashPoseCount";
            this.lblFlashPoseCount.Size = new System.Drawing.Size(59, 13);
            this.lblFlashPoseCount.TabIndex = 11;
            this.lblFlashPoseCount.Text = "PoseCount";
            this.lblFlashPoseCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFlashPoseCount
            // 
            this.txtFlashPoseCount.Location = new System.Drawing.Point(262, 67);
            this.txtFlashPoseCount.Name = "txtFlashPoseCount";
            this.txtFlashPoseCount.Size = new System.Drawing.Size(53, 20);
            this.txtFlashPoseCount.TabIndex = 10;
            // 
            // lblFlashRes1
            // 
            this.lblFlashRes1.AutoSize = true;
            this.lblFlashRes1.Location = new System.Drawing.Point(224, 46);
            this.lblFlashRes1.Name = "lblFlashRes1";
            this.lblFlashRes1.Size = new System.Drawing.Size(32, 13);
            this.lblFlashRes1.TabIndex = 9;
            this.lblFlashRes1.Text = "Res1";
            this.lblFlashRes1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFlashSchedule
            // 
            this.lblFlashSchedule.AutoSize = true;
            this.lblFlashSchedule.Location = new System.Drawing.Point(51, 95);
            this.lblFlashSchedule.Name = "lblFlashSchedule";
            this.lblFlashSchedule.Size = new System.Drawing.Size(52, 13);
            this.lblFlashSchedule.TabIndex = 8;
            this.lblFlashSchedule.Text = "Schedule";
            this.lblFlashSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFlashPlayCount
            // 
            this.lblFlashPlayCount.AutoSize = true;
            this.lblFlashPlayCount.Location = new System.Drawing.Point(45, 70);
            this.lblFlashPlayCount.Name = "lblFlashPlayCount";
            this.lblFlashPlayCount.Size = new System.Drawing.Size(58, 13);
            this.lblFlashPlayCount.TabIndex = 7;
            this.lblFlashPlayCount.Text = "Play Count";
            this.lblFlashPlayCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFlashUnidentifiedByte0
            // 
            this.lblFlashUnidentifiedByte0.AutoSize = true;
            this.lblFlashUnidentifiedByte0.Location = new System.Drawing.Point(13, 44);
            this.lblFlashUnidentifiedByte0.Name = "lblFlashUnidentifiedByte0";
            this.lblFlashUnidentifiedByte0.Size = new System.Drawing.Size(90, 13);
            this.lblFlashUnidentifiedByte0.TabIndex = 6;
            this.lblFlashUnidentifiedByte0.Text = "UnidentifiedByte0";
            this.lblFlashUnidentifiedByte0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFlashName
            // 
            this.lblFlashName.AutoSize = true;
            this.lblFlashName.Location = new System.Drawing.Point(68, 19);
            this.lblFlashName.Name = "lblFlashName";
            this.lblFlashName.Size = new System.Drawing.Size(35, 13);
            this.lblFlashName.TabIndex = 5;
            this.lblFlashName.Text = "Name";
            this.lblFlashName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFlashSchedule
            // 
            this.txtFlashSchedule.Location = new System.Drawing.Point(109, 91);
            this.txtFlashSchedule.Name = "txtFlashSchedule";
            this.txtFlashSchedule.Size = new System.Drawing.Size(53, 20);
            this.txtFlashSchedule.TabIndex = 3;
            // 
            // txtFlashPlayCount
            // 
            this.txtFlashPlayCount.Location = new System.Drawing.Point(109, 66);
            this.txtFlashPlayCount.Name = "txtFlashPlayCount";
            this.txtFlashPlayCount.Size = new System.Drawing.Size(53, 20);
            this.txtFlashPlayCount.TabIndex = 2;
            // 
            // txtFlashUnidentifiedByte0
            // 
            this.txtFlashUnidentifiedByte0.Location = new System.Drawing.Point(109, 41);
            this.txtFlashUnidentifiedByte0.Name = "txtFlashUnidentifiedByte0";
            this.txtFlashUnidentifiedByte0.Size = new System.Drawing.Size(53, 20);
            this.txtFlashUnidentifiedByte0.TabIndex = 1;
            // 
            // txtFlashName
            // 
            this.txtFlashName.Location = new System.Drawing.Point(109, 16);
            this.txtFlashName.Name = "txtFlashName";
            this.txtFlashName.Size = new System.Drawing.Size(832, 20);
            this.txtFlashName.TabIndex = 0;
            // 
            // tpDynamixelReadWrite
            // 
            this.tpDynamixelReadWrite.Controls.Add(this.grpbxAX12);
            this.tpDynamixelReadWrite.Location = new System.Drawing.Point(4, 22);
            this.tpDynamixelReadWrite.Name = "tpDynamixelReadWrite";
            this.tpDynamixelReadWrite.Size = new System.Drawing.Size(966, 393);
            this.tpDynamixelReadWrite.TabIndex = 2;
            this.tpDynamixelReadWrite.Text = "Dynamixel Info";
            this.tpDynamixelReadWrite.UseVisualStyleBackColor = true;
            // 
            // grpbxAX12
            // 
            this.grpbxAX12.Controls.Add(this.nudAX12ID);
            this.grpbxAX12.Controls.Add(this.lblAX12ID);
            this.grpbxAX12.Controls.Add(this.numericUpDown16);
            this.grpbxAX12.Controls.Add(this.numericUpDown17);
            this.grpbxAX12.Controls.Add(this.numericUpDown18);
            this.grpbxAX12.Controls.Add(this.numericUpDown13);
            this.grpbxAX12.Controls.Add(this.numericUpDown14);
            this.grpbxAX12.Controls.Add(this.numericUpDown15);
            this.grpbxAX12.Controls.Add(this.lblAX12PresentLoadHigh);
            this.grpbxAX12.Controls.Add(this.lblAX12PresentLoadLow);
            this.grpbxAX12.Controls.Add(this.numericUpDown10);
            this.grpbxAX12.Controls.Add(this.numericUpDown11);
            this.grpbxAX12.Controls.Add(this.numericUpDown12);
            this.grpbxAX12.Controls.Add(this.numericUpDown7);
            this.grpbxAX12.Controls.Add(this.numericUpDown8);
            this.grpbxAX12.Controls.Add(this.numericUpDown9);
            this.grpbxAX12.Controls.Add(this.numericUpDown4);
            this.grpbxAX12.Controls.Add(this.numericUpDown5);
            this.grpbxAX12.Controls.Add(this.numericUpDown6);
            this.grpbxAX12.Controls.Add(this.numericUpDown3);
            this.grpbxAX12.Controls.Add(this.numericUpDown2);
            this.grpbxAX12.Controls.Add(this.nudAX12);
            this.grpbxAX12.Controls.Add(this.lblAX12PresentSpeedHigh);
            this.grpbxAX12.Controls.Add(this.lblAX12PresentSpeedLow);
            this.grpbxAX12.Controls.Add(this.lblAX12PresentPositionHigh);
            this.grpbxAX12.Controls.Add(this.lblAX12PresentPositionLow);
            this.grpbxAX12.Controls.Add(this.lblAX12TorqueLimitHigh);
            this.grpbxAX12.Controls.Add(this.lblAX12TorqueLimitLow);
            this.grpbxAX12.Controls.Add(this.lblAX12MovingSpeedHigh);
            this.grpbxAX12.Controls.Add(this.lblAX12MovingSpeedLow);
            this.grpbxAX12.Controls.Add(this.lblAX12GoalPositionHigh);
            this.grpbxAX12.Controls.Add(this.lblAX12GoalPositionLow);
            this.grpbxAX12.Controls.Add(this.lblAX12CcwComplianceSlope);
            this.grpbxAX12.Controls.Add(this.lblAX12CwComplianceSlope);
            this.grpbxAX12.Controls.Add(this.lblAX12CcwComplianceMargin);
            this.grpbxAX12.Controls.Add(this.lblAX12CwComplianceMargin);
            this.grpbxAX12.Controls.Add(this.lblAX12LED);
            this.grpbxAX12.Controls.Add(this.lblAX12TorqueEnable);
            this.grpbxAX12.Location = new System.Drawing.Point(12, 10);
            this.grpbxAX12.Name = "grpbxAX12";
            this.grpbxAX12.Size = new System.Drawing.Size(357, 368);
            this.grpbxAX12.TabIndex = 0;
            this.grpbxAX12.TabStop = false;
            this.grpbxAX12.Text = "AX12";
            // 
            // lblAX12PresentSpeedHigh
            // 
            this.lblAX12PresentSpeedHigh.AutoSize = true;
            this.lblAX12PresentSpeedHigh.Location = new System.Drawing.Point(184, 203);
            this.lblAX12PresentSpeedHigh.Name = "lblAX12PresentSpeedHigh";
            this.lblAX12PresentSpeedHigh.Size = new System.Drawing.Size(105, 13);
            this.lblAX12PresentSpeedHigh.TabIndex = 15;
            this.lblAX12PresentSpeedHigh.Text = "Present Speed High:";
            // 
            // lblAX12PresentSpeedLow
            // 
            this.lblAX12PresentSpeedLow.AutoSize = true;
            this.lblAX12PresentSpeedLow.Location = new System.Drawing.Point(186, 179);
            this.lblAX12PresentSpeedLow.Name = "lblAX12PresentSpeedLow";
            this.lblAX12PresentSpeedLow.Size = new System.Drawing.Size(103, 13);
            this.lblAX12PresentSpeedLow.TabIndex = 14;
            this.lblAX12PresentSpeedLow.Text = "Present Speed Low:";
            // 
            // lblAX12PresentPositionHigh
            // 
            this.lblAX12PresentPositionHigh.AutoSize = true;
            this.lblAX12PresentPositionHigh.Location = new System.Drawing.Point(178, 153);
            this.lblAX12PresentPositionHigh.Name = "lblAX12PresentPositionHigh";
            this.lblAX12PresentPositionHigh.Size = new System.Drawing.Size(111, 13);
            this.lblAX12PresentPositionHigh.TabIndex = 13;
            this.lblAX12PresentPositionHigh.Text = "Present Position High:";
            // 
            // lblAX12PresentPositionLow
            // 
            this.lblAX12PresentPositionLow.AutoSize = true;
            this.lblAX12PresentPositionLow.Location = new System.Drawing.Point(180, 127);
            this.lblAX12PresentPositionLow.Name = "lblAX12PresentPositionLow";
            this.lblAX12PresentPositionLow.Size = new System.Drawing.Size(109, 13);
            this.lblAX12PresentPositionLow.TabIndex = 12;
            this.lblAX12PresentPositionLow.Text = "Present Position Low:";
            // 
            // lblAX12TorqueLimitHigh
            // 
            this.lblAX12TorqueLimitHigh.AutoSize = true;
            this.lblAX12TorqueLimitHigh.Location = new System.Drawing.Point(196, 101);
            this.lblAX12TorqueLimitHigh.Name = "lblAX12TorqueLimitHigh";
            this.lblAX12TorqueLimitHigh.Size = new System.Drawing.Size(93, 13);
            this.lblAX12TorqueLimitHigh.TabIndex = 11;
            this.lblAX12TorqueLimitHigh.Text = "Torque Limit High:";
            // 
            // lblAX12TorqueLimitLow
            // 
            this.lblAX12TorqueLimitLow.AutoSize = true;
            this.lblAX12TorqueLimitLow.Location = new System.Drawing.Point(198, 75);
            this.lblAX12TorqueLimitLow.Name = "lblAX12TorqueLimitLow";
            this.lblAX12TorqueLimitLow.Size = new System.Drawing.Size(91, 13);
            this.lblAX12TorqueLimitLow.TabIndex = 10;
            this.lblAX12TorqueLimitLow.Text = "Torque Limit Low:";
            // 
            // lblAX12MovingSpeedHigh
            // 
            this.lblAX12MovingSpeedHigh.AutoSize = true;
            this.lblAX12MovingSpeedHigh.Location = new System.Drawing.Point(185, 47);
            this.lblAX12MovingSpeedHigh.Name = "lblAX12MovingSpeedHigh";
            this.lblAX12MovingSpeedHigh.Size = new System.Drawing.Size(104, 13);
            this.lblAX12MovingSpeedHigh.TabIndex = 9;
            this.lblAX12MovingSpeedHigh.Text = "Moving Speed High:";
            // 
            // lblAX12MovingSpeedLow
            // 
            this.lblAX12MovingSpeedLow.AutoSize = true;
            this.lblAX12MovingSpeedLow.Location = new System.Drawing.Point(16, 255);
            this.lblAX12MovingSpeedLow.Name = "lblAX12MovingSpeedLow";
            this.lblAX12MovingSpeedLow.Size = new System.Drawing.Size(102, 13);
            this.lblAX12MovingSpeedLow.TabIndex = 8;
            this.lblAX12MovingSpeedLow.Text = "Moving Speed Low:";
            // 
            // lblAX12GoalPositionHigh
            // 
            this.lblAX12GoalPositionHigh.AutoSize = true;
            this.lblAX12GoalPositionHigh.Location = new System.Drawing.Point(21, 229);
            this.lblAX12GoalPositionHigh.Name = "lblAX12GoalPositionHigh";
            this.lblAX12GoalPositionHigh.Size = new System.Drawing.Size(97, 13);
            this.lblAX12GoalPositionHigh.TabIndex = 7;
            this.lblAX12GoalPositionHigh.Text = "Goal Position High:";
            // 
            // lblAX12GoalPositionLow
            // 
            this.lblAX12GoalPositionLow.AutoSize = true;
            this.lblAX12GoalPositionLow.Location = new System.Drawing.Point(23, 203);
            this.lblAX12GoalPositionLow.Name = "lblAX12GoalPositionLow";
            this.lblAX12GoalPositionLow.Size = new System.Drawing.Size(95, 13);
            this.lblAX12GoalPositionLow.TabIndex = 6;
            this.lblAX12GoalPositionLow.Text = "Goal Position Low:";
            // 
            // lblAX12CcwComplianceSlope
            // 
            this.lblAX12CcwComplianceSlope.AutoSize = true;
            this.lblAX12CcwComplianceSlope.Location = new System.Drawing.Point(6, 179);
            this.lblAX12CcwComplianceSlope.Name = "lblAX12CcwComplianceSlope";
            this.lblAX12CcwComplianceSlope.Size = new System.Drawing.Size(112, 13);
            this.lblAX12CcwComplianceSlope.TabIndex = 5;
            this.lblAX12CcwComplianceSlope.Text = "ccwComplianceSlope:";
            // 
            // lblAX12CwComplianceSlope
            // 
            this.lblAX12CwComplianceSlope.AutoSize = true;
            this.lblAX12CwComplianceSlope.Location = new System.Drawing.Point(12, 153);
            this.lblAX12CwComplianceSlope.Name = "lblAX12CwComplianceSlope";
            this.lblAX12CwComplianceSlope.Size = new System.Drawing.Size(106, 13);
            this.lblAX12CwComplianceSlope.TabIndex = 4;
            this.lblAX12CwComplianceSlope.Text = "cwComplianceSlope:";
            // 
            // lblAX12CcwComplianceMargin
            // 
            this.lblAX12CcwComplianceMargin.AutoSize = true;
            this.lblAX12CcwComplianceMargin.Location = new System.Drawing.Point(1, 127);
            this.lblAX12CcwComplianceMargin.Name = "lblAX12CcwComplianceMargin";
            this.lblAX12CcwComplianceMargin.Size = new System.Drawing.Size(117, 13);
            this.lblAX12CcwComplianceMargin.TabIndex = 3;
            this.lblAX12CcwComplianceMargin.Text = "ccwComplianceMargin:";
            // 
            // lblAX12CwComplianceMargin
            // 
            this.lblAX12CwComplianceMargin.AutoSize = true;
            this.lblAX12CwComplianceMargin.Location = new System.Drawing.Point(7, 101);
            this.lblAX12CwComplianceMargin.Name = "lblAX12CwComplianceMargin";
            this.lblAX12CwComplianceMargin.Size = new System.Drawing.Size(111, 13);
            this.lblAX12CwComplianceMargin.TabIndex = 2;
            this.lblAX12CwComplianceMargin.Text = "cwComplianceMargin:";
            // 
            // lblAX12LED
            // 
            this.lblAX12LED.AutoSize = true;
            this.lblAX12LED.Location = new System.Drawing.Point(87, 75);
            this.lblAX12LED.Name = "lblAX12LED";
            this.lblAX12LED.Size = new System.Drawing.Size(31, 13);
            this.lblAX12LED.TabIndex = 1;
            this.lblAX12LED.Text = "LED:";
            // 
            // lblAX12TorqueEnable
            // 
            this.lblAX12TorqueEnable.AutoSize = true;
            this.lblAX12TorqueEnable.Location = new System.Drawing.Point(38, 47);
            this.lblAX12TorqueEnable.Name = "lblAX12TorqueEnable";
            this.lblAX12TorqueEnable.Size = new System.Drawing.Size(80, 13);
            this.lblAX12TorqueEnable.TabIndex = 0;
            this.lblAX12TorqueEnable.Text = "Torque Enable:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnReadAX12);
            this.tabPage1.Controls.Add(this.lblDynamixelID);
            this.tabPage1.Controls.Add(this.cmbDynamixelID);
            this.tabPage1.Controls.Add(this.btnWritePosition);
            this.tabPage1.Controls.Add(this.btnReadPosition);
            this.tabPage1.Controls.Add(this.btnPing);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(966, 393);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Scratch";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnReadAX12
            // 
            this.btnReadAX12.Location = new System.Drawing.Point(15, 123);
            this.btnReadAX12.Name = "btnReadAX12";
            this.btnReadAX12.Size = new System.Drawing.Size(75, 23);
            this.btnReadAX12.TabIndex = 6;
            this.btnReadAX12.Text = "Read AX12";
            this.btnReadAX12.UseVisualStyleBackColor = true;
            this.btnReadAX12.Click += new System.EventHandler(this.btnReadAX12_Click);
            // 
            // lblDynamixelID
            // 
            this.lblDynamixelID.AutoSize = true;
            this.lblDynamixelID.Location = new System.Drawing.Point(12, 12);
            this.lblDynamixelID.Name = "lblDynamixelID";
            this.lblDynamixelID.Size = new System.Drawing.Size(72, 13);
            this.lblDynamixelID.TabIndex = 4;
            this.lblDynamixelID.Text = "Dynamixel ID:";
            // 
            // cmbDynamixelID
            // 
            this.cmbDynamixelID.FormattingEnabled = true;
            this.cmbDynamixelID.Location = new System.Drawing.Point(90, 9);
            this.cmbDynamixelID.Name = "cmbDynamixelID";
            this.cmbDynamixelID.Size = new System.Drawing.Size(55, 21);
            this.cmbDynamixelID.TabIndex = 3;
            // 
            // btnWritePosition
            // 
            this.btnWritePosition.Location = new System.Drawing.Point(15, 94);
            this.btnWritePosition.Name = "btnWritePosition";
            this.btnWritePosition.Size = new System.Drawing.Size(75, 23);
            this.btnWritePosition.TabIndex = 2;
            this.btnWritePosition.Text = "Write";
            this.btnWritePosition.UseVisualStyleBackColor = true;
            this.btnWritePosition.Click += new System.EventHandler(this.btnWritePosition_Click);
            // 
            // btnReadPosition
            // 
            this.btnReadPosition.Location = new System.Drawing.Point(15, 65);
            this.btnReadPosition.Name = "btnReadPosition";
            this.btnReadPosition.Size = new System.Drawing.Size(75, 23);
            this.btnReadPosition.TabIndex = 1;
            this.btnReadPosition.Text = "Read";
            this.btnReadPosition.UseVisualStyleBackColor = true;
            this.btnReadPosition.Click += new System.EventHandler(this.btnReadPosition_Click);
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(15, 36);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(75, 23);
            this.btnPing.TabIndex = 0;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // gbControllerSerialConnection
            // 
            this.gbControllerSerialConnection.Controls.Add(this.btnControllerSerialConnectionConnect);
            this.gbControllerSerialConnection.Controls.Add(this.cmbControllerSerialConnectionDataBits);
            this.gbControllerSerialConnection.Controls.Add(this.lblControllerSerialConnectionDataBits);
            this.gbControllerSerialConnection.Controls.Add(this.cmbControllerSerialConnectionStopBits);
            this.gbControllerSerialConnection.Controls.Add(this.lblControllerSerialConnectionStopBits);
            this.gbControllerSerialConnection.Controls.Add(this.cmbControllerSerialConnectionFlow);
            this.gbControllerSerialConnection.Controls.Add(this.lblControllerSerialConnectionFlow);
            this.gbControllerSerialConnection.Controls.Add(this.cmbControllerSerialConnectionParity);
            this.gbControllerSerialConnection.Controls.Add(this.lblControllerSerialConnectionParity);
            this.gbControllerSerialConnection.Controls.Add(this.cmbControllerSerialConnectionBaud);
            this.gbControllerSerialConnection.Controls.Add(this.lblControllerSerialConnectionBaud);
            this.gbControllerSerialConnection.Controls.Add(this.cmbControllerSerialConnectionCOM);
            this.gbControllerSerialConnection.Controls.Add(this.lblControllerSerialConnectionCOM);
            this.gbControllerSerialConnection.Location = new System.Drawing.Point(19, 8);
            this.gbControllerSerialConnection.Name = "gbControllerSerialConnection";
            this.gbControllerSerialConnection.Size = new System.Drawing.Size(240, 123);
            this.gbControllerSerialConnection.TabIndex = 34;
            this.gbControllerSerialConnection.TabStop = false;
            this.gbControllerSerialConnection.Text = "Controller Serial Connection";
            // 
            // btnControllerSerialConnectionConnect
            // 
            this.btnControllerSerialConnectionConnect.Location = new System.Drawing.Point(80, 94);
            this.btnControllerSerialConnectionConnect.Name = "btnControllerSerialConnectionConnect";
            this.btnControllerSerialConnectionConnect.Size = new System.Drawing.Size(65, 22);
            this.btnControllerSerialConnectionConnect.TabIndex = 32;
            this.btnControllerSerialConnectionConnect.Text = "Connect";
            this.btnControllerSerialConnectionConnect.UseVisualStyleBackColor = true;
            this.btnControllerSerialConnectionConnect.Click += new System.EventHandler(this.btnControllerSerialConnectionConnect_Click);
            // 
            // cmbControllerSerialConnectionDataBits
            // 
            this.cmbControllerSerialConnectionDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbControllerSerialConnectionDataBits.FormattingEnabled = true;
            this.cmbControllerSerialConnectionDataBits.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbControllerSerialConnectionDataBits.Location = new System.Drawing.Point(57, 44);
            this.cmbControllerSerialConnectionDataBits.Name = "cmbControllerSerialConnectionDataBits";
            this.cmbControllerSerialConnectionDataBits.Size = new System.Drawing.Size(45, 21);
            this.cmbControllerSerialConnectionDataBits.TabIndex = 31;
            // 
            // lblControllerSerialConnectionDataBits
            // 
            this.lblControllerSerialConnectionDataBits.AutoSize = true;
            this.lblControllerSerialConnectionDataBits.Location = new System.Drawing.Point(4, 48);
            this.lblControllerSerialConnectionDataBits.Name = "lblControllerSerialConnectionDataBits";
            this.lblControllerSerialConnectionDataBits.Size = new System.Drawing.Size(49, 13);
            this.lblControllerSerialConnectionDataBits.TabIndex = 30;
            this.lblControllerSerialConnectionDataBits.Text = "Data bits";
            // 
            // cmbControllerSerialConnectionStopBits
            // 
            this.cmbControllerSerialConnectionStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbControllerSerialConnectionStopBits.FormattingEnabled = true;
            this.cmbControllerSerialConnectionStopBits.Items.AddRange(new object[] {
            "None",
            "1",
            "1.5",
            "2"});
            this.cmbControllerSerialConnectionStopBits.Location = new System.Drawing.Point(57, 69);
            this.cmbControllerSerialConnectionStopBits.Name = "cmbControllerSerialConnectionStopBits";
            this.cmbControllerSerialConnectionStopBits.Size = new System.Drawing.Size(45, 21);
            this.cmbControllerSerialConnectionStopBits.TabIndex = 29;
            // 
            // lblControllerSerialConnectionStopBits
            // 
            this.lblControllerSerialConnectionStopBits.AutoSize = true;
            this.lblControllerSerialConnectionStopBits.Location = new System.Drawing.Point(6, 73);
            this.lblControllerSerialConnectionStopBits.Name = "lblControllerSerialConnectionStopBits";
            this.lblControllerSerialConnectionStopBits.Size = new System.Drawing.Size(49, 13);
            this.lblControllerSerialConnectionStopBits.TabIndex = 28;
            this.lblControllerSerialConnectionStopBits.Text = "Stop Bits";
            // 
            // cmbControllerSerialConnectionFlow
            // 
            this.cmbControllerSerialConnectionFlow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbControllerSerialConnectionFlow.FormattingEnabled = true;
            this.cmbControllerSerialConnectionFlow.Items.AddRange(new object[] {
            "Xon / Xoff",
            "Hardware",
            "None"});
            this.cmbControllerSerialConnectionFlow.Location = new System.Drawing.Point(163, 69);
            this.cmbControllerSerialConnectionFlow.Name = "cmbControllerSerialConnectionFlow";
            this.cmbControllerSerialConnectionFlow.Size = new System.Drawing.Size(68, 21);
            this.cmbControllerSerialConnectionFlow.TabIndex = 27;
            // 
            // lblControllerSerialConnectionFlow
            // 
            this.lblControllerSerialConnectionFlow.AutoSize = true;
            this.lblControllerSerialConnectionFlow.Location = new System.Drawing.Point(130, 73);
            this.lblControllerSerialConnectionFlow.Name = "lblControllerSerialConnectionFlow";
            this.lblControllerSerialConnectionFlow.Size = new System.Drawing.Size(29, 13);
            this.lblControllerSerialConnectionFlow.TabIndex = 26;
            this.lblControllerSerialConnectionFlow.Text = "Flow";
            // 
            // cmbControllerSerialConnectionParity
            // 
            this.cmbControllerSerialConnectionParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbControllerSerialConnectionParity.FormattingEnabled = true;
            this.cmbControllerSerialConnectionParity.Items.AddRange(new object[] {
            "Even",
            "Odd",
            "None",
            "Mark",
            "Space"});
            this.cmbControllerSerialConnectionParity.Location = new System.Drawing.Point(163, 44);
            this.cmbControllerSerialConnectionParity.Name = "cmbControllerSerialConnectionParity";
            this.cmbControllerSerialConnectionParity.Size = new System.Drawing.Size(68, 21);
            this.cmbControllerSerialConnectionParity.TabIndex = 21;
            // 
            // lblControllerSerialConnectionParity
            // 
            this.lblControllerSerialConnectionParity.AutoSize = true;
            this.lblControllerSerialConnectionParity.Location = new System.Drawing.Point(126, 48);
            this.lblControllerSerialConnectionParity.Name = "lblControllerSerialConnectionParity";
            this.lblControllerSerialConnectionParity.Size = new System.Drawing.Size(33, 13);
            this.lblControllerSerialConnectionParity.TabIndex = 20;
            this.lblControllerSerialConnectionParity.Text = "Parity";
            // 
            // cmbControllerSerialConnectionBaud
            // 
            this.cmbControllerSerialConnectionBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbControllerSerialConnectionBaud.FormattingEnabled = true;
            this.cmbControllerSerialConnectionBaud.Items.AddRange(new object[] {
            "1000000",
            "500000",
            "250000",
            "128000",
            "115200",
            "57600",
            "38400",
            "19200",
            "14400",
            "9600",
            "7200",
            "4800",
            "2400",
            "1800",
            "1200",
            "600",
            "300",
            "150",
            "134",
            "110",
            "75",
            "",
            ""});
            this.cmbControllerSerialConnectionBaud.Location = new System.Drawing.Point(163, 19);
            this.cmbControllerSerialConnectionBaud.Name = "cmbControllerSerialConnectionBaud";
            this.cmbControllerSerialConnectionBaud.Size = new System.Drawing.Size(68, 21);
            this.cmbControllerSerialConnectionBaud.TabIndex = 19;
            // 
            // lblControllerSerialConnectionBaud
            // 
            this.lblControllerSerialConnectionBaud.AutoSize = true;
            this.lblControllerSerialConnectionBaud.Location = new System.Drawing.Point(127, 23);
            this.lblControllerSerialConnectionBaud.Name = "lblControllerSerialConnectionBaud";
            this.lblControllerSerialConnectionBaud.Size = new System.Drawing.Size(32, 13);
            this.lblControllerSerialConnectionBaud.TabIndex = 18;
            this.lblControllerSerialConnectionBaud.Text = "Baud";
            // 
            // cmbControllerSerialConnectionCOM
            // 
            this.cmbControllerSerialConnectionCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbControllerSerialConnectionCOM.FormattingEnabled = true;
            this.cmbControllerSerialConnectionCOM.Location = new System.Drawing.Point(57, 19);
            this.cmbControllerSerialConnectionCOM.Name = "cmbControllerSerialConnectionCOM";
            this.cmbControllerSerialConnectionCOM.Size = new System.Drawing.Size(60, 21);
            this.cmbControllerSerialConnectionCOM.TabIndex = 17;
            // 
            // lblControllerSerialConnectionCOM
            // 
            this.lblControllerSerialConnectionCOM.AutoSize = true;
            this.lblControllerSerialConnectionCOM.Location = new System.Drawing.Point(22, 23);
            this.lblControllerSerialConnectionCOM.Name = "lblControllerSerialConnectionCOM";
            this.lblControllerSerialConnectionCOM.Size = new System.Drawing.Size(31, 13);
            this.lblControllerSerialConnectionCOM.TabIndex = 16;
            this.lblControllerSerialConnectionCOM.Text = "COM";
            // 
            // gbDebugSerialConnection
            // 
            this.gbDebugSerialConnection.Controls.Add(this.btnDebugSerialConnectionConnect);
            this.gbDebugSerialConnection.Controls.Add(this.cmbDebugSerialConnectionDataBits);
            this.gbDebugSerialConnection.Controls.Add(this.lblDebugSerialConnectionDataBits);
            this.gbDebugSerialConnection.Controls.Add(this.cmbDebugSerialConnectionStopBits);
            this.gbDebugSerialConnection.Controls.Add(this.lblDebugSerialConnectionStopBits);
            this.gbDebugSerialConnection.Controls.Add(this.cmbDebugSerialConnectionFlow);
            this.gbDebugSerialConnection.Controls.Add(this.lblDebugSerialConnectionFlow);
            this.gbDebugSerialConnection.Controls.Add(this.cmbDebugSerialConnectionParity);
            this.gbDebugSerialConnection.Controls.Add(this.lblDebugSerialConnectionParity);
            this.gbDebugSerialConnection.Controls.Add(this.cmbDebugSerialConnectionBaud);
            this.gbDebugSerialConnection.Controls.Add(this.lblDebugSerialConnectionBaud);
            this.gbDebugSerialConnection.Controls.Add(this.cmbDebugSerialConnectionCOM);
            this.gbDebugSerialConnection.Controls.Add(this.lblDebugSerialConnectionCOM);
            this.gbDebugSerialConnection.Location = new System.Drawing.Point(268, 8);
            this.gbDebugSerialConnection.Name = "gbDebugSerialConnection";
            this.gbDebugSerialConnection.Size = new System.Drawing.Size(240, 123);
            this.gbDebugSerialConnection.TabIndex = 35;
            this.gbDebugSerialConnection.TabStop = false;
            this.gbDebugSerialConnection.Text = "Debug Serial Connection";
            // 
            // btnDebugSerialConnectionConnect
            // 
            this.btnDebugSerialConnectionConnect.Location = new System.Drawing.Point(80, 94);
            this.btnDebugSerialConnectionConnect.Name = "btnDebugSerialConnectionConnect";
            this.btnDebugSerialConnectionConnect.Size = new System.Drawing.Size(65, 22);
            this.btnDebugSerialConnectionConnect.TabIndex = 32;
            this.btnDebugSerialConnectionConnect.Text = "Connect";
            this.btnDebugSerialConnectionConnect.UseVisualStyleBackColor = true;
            this.btnDebugSerialConnectionConnect.Click += new System.EventHandler(this.btnDebugSerialConnectionConnect_Click);
            // 
            // cmbDebugSerialConnectionDataBits
            // 
            this.cmbDebugSerialConnectionDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDebugSerialConnectionDataBits.FormattingEnabled = true;
            this.cmbDebugSerialConnectionDataBits.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbDebugSerialConnectionDataBits.Location = new System.Drawing.Point(57, 44);
            this.cmbDebugSerialConnectionDataBits.Name = "cmbDebugSerialConnectionDataBits";
            this.cmbDebugSerialConnectionDataBits.Size = new System.Drawing.Size(45, 21);
            this.cmbDebugSerialConnectionDataBits.TabIndex = 31;
            // 
            // lblDebugSerialConnectionDataBits
            // 
            this.lblDebugSerialConnectionDataBits.AutoSize = true;
            this.lblDebugSerialConnectionDataBits.Location = new System.Drawing.Point(4, 48);
            this.lblDebugSerialConnectionDataBits.Name = "lblDebugSerialConnectionDataBits";
            this.lblDebugSerialConnectionDataBits.Size = new System.Drawing.Size(49, 13);
            this.lblDebugSerialConnectionDataBits.TabIndex = 30;
            this.lblDebugSerialConnectionDataBits.Text = "Data bits";
            // 
            // cmbDebugSerialConnectionStopBits
            // 
            this.cmbDebugSerialConnectionStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDebugSerialConnectionStopBits.FormattingEnabled = true;
            this.cmbDebugSerialConnectionStopBits.Items.AddRange(new object[] {
            "None",
            "1",
            "1.5",
            "2"});
            this.cmbDebugSerialConnectionStopBits.Location = new System.Drawing.Point(57, 69);
            this.cmbDebugSerialConnectionStopBits.Name = "cmbDebugSerialConnectionStopBits";
            this.cmbDebugSerialConnectionStopBits.Size = new System.Drawing.Size(45, 21);
            this.cmbDebugSerialConnectionStopBits.TabIndex = 29;
            // 
            // lblDebugSerialConnectionStopBits
            // 
            this.lblDebugSerialConnectionStopBits.AutoSize = true;
            this.lblDebugSerialConnectionStopBits.Location = new System.Drawing.Point(6, 73);
            this.lblDebugSerialConnectionStopBits.Name = "lblDebugSerialConnectionStopBits";
            this.lblDebugSerialConnectionStopBits.Size = new System.Drawing.Size(49, 13);
            this.lblDebugSerialConnectionStopBits.TabIndex = 28;
            this.lblDebugSerialConnectionStopBits.Text = "Stop Bits";
            // 
            // cmbDebugSerialConnectionFlow
            // 
            this.cmbDebugSerialConnectionFlow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDebugSerialConnectionFlow.FormattingEnabled = true;
            this.cmbDebugSerialConnectionFlow.Items.AddRange(new object[] {
            "Xon / Xoff",
            "Hardware",
            "None"});
            this.cmbDebugSerialConnectionFlow.Location = new System.Drawing.Point(161, 69);
            this.cmbDebugSerialConnectionFlow.Name = "cmbDebugSerialConnectionFlow";
            this.cmbDebugSerialConnectionFlow.Size = new System.Drawing.Size(68, 21);
            this.cmbDebugSerialConnectionFlow.TabIndex = 27;
            // 
            // lblDebugSerialConnectionFlow
            // 
            this.lblDebugSerialConnectionFlow.AutoSize = true;
            this.lblDebugSerialConnectionFlow.Location = new System.Drawing.Point(128, 73);
            this.lblDebugSerialConnectionFlow.Name = "lblDebugSerialConnectionFlow";
            this.lblDebugSerialConnectionFlow.Size = new System.Drawing.Size(29, 13);
            this.lblDebugSerialConnectionFlow.TabIndex = 26;
            this.lblDebugSerialConnectionFlow.Text = "Flow";
            // 
            // cmbDebugSerialConnectionParity
            // 
            this.cmbDebugSerialConnectionParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDebugSerialConnectionParity.FormattingEnabled = true;
            this.cmbDebugSerialConnectionParity.Items.AddRange(new object[] {
            "Even",
            "Odd",
            "None",
            "Mark",
            "Space"});
            this.cmbDebugSerialConnectionParity.Location = new System.Drawing.Point(161, 44);
            this.cmbDebugSerialConnectionParity.Name = "cmbDebugSerialConnectionParity";
            this.cmbDebugSerialConnectionParity.Size = new System.Drawing.Size(68, 21);
            this.cmbDebugSerialConnectionParity.TabIndex = 21;
            // 
            // lblDebugSerialConnectionParity
            // 
            this.lblDebugSerialConnectionParity.AutoSize = true;
            this.lblDebugSerialConnectionParity.Location = new System.Drawing.Point(124, 48);
            this.lblDebugSerialConnectionParity.Name = "lblDebugSerialConnectionParity";
            this.lblDebugSerialConnectionParity.Size = new System.Drawing.Size(33, 13);
            this.lblDebugSerialConnectionParity.TabIndex = 20;
            this.lblDebugSerialConnectionParity.Text = "Parity";
            // 
            // cmbDebugSerialConnectionBaud
            // 
            this.cmbDebugSerialConnectionBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDebugSerialConnectionBaud.FormattingEnabled = true;
            this.cmbDebugSerialConnectionBaud.Items.AddRange(new object[] {
            "1000000",
            "500000",
            "250000",
            "128000",
            "115200",
            "57600",
            "38400",
            "19200",
            "14400",
            "9600",
            "7200",
            "4800",
            "2400",
            "1800",
            "1200",
            "600",
            "300",
            "150",
            "134",
            "110",
            "75",
            "",
            ""});
            this.cmbDebugSerialConnectionBaud.Location = new System.Drawing.Point(161, 19);
            this.cmbDebugSerialConnectionBaud.Name = "cmbDebugSerialConnectionBaud";
            this.cmbDebugSerialConnectionBaud.Size = new System.Drawing.Size(68, 21);
            this.cmbDebugSerialConnectionBaud.TabIndex = 19;
            // 
            // lblDebugSerialConnectionBaud
            // 
            this.lblDebugSerialConnectionBaud.AutoSize = true;
            this.lblDebugSerialConnectionBaud.Location = new System.Drawing.Point(125, 23);
            this.lblDebugSerialConnectionBaud.Name = "lblDebugSerialConnectionBaud";
            this.lblDebugSerialConnectionBaud.Size = new System.Drawing.Size(32, 13);
            this.lblDebugSerialConnectionBaud.TabIndex = 18;
            this.lblDebugSerialConnectionBaud.Text = "Baud";
            // 
            // cmbDebugSerialConnectionCOM
            // 
            this.cmbDebugSerialConnectionCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDebugSerialConnectionCOM.FormattingEnabled = true;
            this.cmbDebugSerialConnectionCOM.Location = new System.Drawing.Point(57, 19);
            this.cmbDebugSerialConnectionCOM.Name = "cmbDebugSerialConnectionCOM";
            this.cmbDebugSerialConnectionCOM.Size = new System.Drawing.Size(60, 21);
            this.cmbDebugSerialConnectionCOM.TabIndex = 17;
            // 
            // lblDebugSerialConnectionCOM
            // 
            this.lblDebugSerialConnectionCOM.AutoSize = true;
            this.lblDebugSerialConnectionCOM.Location = new System.Drawing.Point(22, 23);
            this.lblDebugSerialConnectionCOM.Name = "lblDebugSerialConnectionCOM";
            this.lblDebugSerialConnectionCOM.Size = new System.Drawing.Size(31, 13);
            this.lblDebugSerialConnectionCOM.TabIndex = 16;
            this.lblDebugSerialConnectionCOM.Text = "COM";
            // 
            // txtDebugWindow
            // 
            this.txtDebugWindow.BackColor = System.Drawing.Color.Black;
            this.txtDebugWindow.ForeColor = System.Drawing.Color.White;
            this.txtDebugWindow.Location = new System.Drawing.Point(514, 15);
            this.txtDebugWindow.Multiline = true;
            this.txtDebugWindow.Name = "txtDebugWindow";
            this.txtDebugWindow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDebugWindow.Size = new System.Drawing.Size(467, 115);
            this.txtDebugWindow.TabIndex = 36;
            // 
            // nudAX12
            // 
            this.nudAX12.Location = new System.Drawing.Point(121, 43);
            this.nudAX12.Name = "nudAX12";
            this.nudAX12.Size = new System.Drawing.Size(47, 20);
            this.nudAX12.TabIndex = 16;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(121, 71);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown2.TabIndex = 17;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(121, 97);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown3.TabIndex = 18;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(121, 175);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown4.TabIndex = 21;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(121, 149);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown5.TabIndex = 20;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(121, 123);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown6.TabIndex = 19;
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(121, 251);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown7.TabIndex = 24;
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(121, 225);
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown8.TabIndex = 23;
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.Location = new System.Drawing.Point(121, 199);
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown9.TabIndex = 22;
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.Location = new System.Drawing.Point(296, 97);
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown10.TabIndex = 27;
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.Location = new System.Drawing.Point(296, 71);
            this.numericUpDown11.Name = "numericUpDown11";
            this.numericUpDown11.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown11.TabIndex = 26;
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.Location = new System.Drawing.Point(296, 43);
            this.numericUpDown12.Name = "numericUpDown12";
            this.numericUpDown12.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown12.TabIndex = 25;
            // 
            // lblAX12PresentLoadHigh
            // 
            this.lblAX12PresentLoadHigh.AutoSize = true;
            this.lblAX12PresentLoadHigh.Location = new System.Drawing.Point(191, 255);
            this.lblAX12PresentLoadHigh.Name = "lblAX12PresentLoadHigh";
            this.lblAX12PresentLoadHigh.Size = new System.Drawing.Size(98, 13);
            this.lblAX12PresentLoadHigh.TabIndex = 29;
            this.lblAX12PresentLoadHigh.Text = "Present Load High:";
            // 
            // lblAX12PresentLoadLow
            // 
            this.lblAX12PresentLoadLow.AutoSize = true;
            this.lblAX12PresentLoadLow.Location = new System.Drawing.Point(193, 229);
            this.lblAX12PresentLoadLow.Name = "lblAX12PresentLoadLow";
            this.lblAX12PresentLoadLow.Size = new System.Drawing.Size(96, 13);
            this.lblAX12PresentLoadLow.TabIndex = 28;
            this.lblAX12PresentLoadLow.Text = "Present Load Low:";
            // 
            // numericUpDown13
            // 
            this.numericUpDown13.Location = new System.Drawing.Point(296, 175);
            this.numericUpDown13.Name = "numericUpDown13";
            this.numericUpDown13.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown13.TabIndex = 32;
            // 
            // numericUpDown14
            // 
            this.numericUpDown14.Location = new System.Drawing.Point(296, 149);
            this.numericUpDown14.Name = "numericUpDown14";
            this.numericUpDown14.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown14.TabIndex = 31;
            // 
            // numericUpDown15
            // 
            this.numericUpDown15.Location = new System.Drawing.Point(296, 123);
            this.numericUpDown15.Name = "numericUpDown15";
            this.numericUpDown15.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown15.TabIndex = 30;
            // 
            // numericUpDown16
            // 
            this.numericUpDown16.Location = new System.Drawing.Point(295, 251);
            this.numericUpDown16.Name = "numericUpDown16";
            this.numericUpDown16.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown16.TabIndex = 35;
            // 
            // numericUpDown17
            // 
            this.numericUpDown17.Location = new System.Drawing.Point(295, 225);
            this.numericUpDown17.Name = "numericUpDown17";
            this.numericUpDown17.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown17.TabIndex = 34;
            // 
            // numericUpDown18
            // 
            this.numericUpDown18.Location = new System.Drawing.Point(295, 199);
            this.numericUpDown18.Name = "numericUpDown18";
            this.numericUpDown18.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown18.TabIndex = 33;
            // 
            // lblAX12ID
            // 
            this.lblAX12ID.AutoSize = true;
            this.lblAX12ID.Location = new System.Drawing.Point(150, 20);
            this.lblAX12ID.Name = "lblAX12ID";
            this.lblAX12ID.Size = new System.Drawing.Size(21, 13);
            this.lblAX12ID.TabIndex = 36;
            this.lblAX12ID.Text = "ID:";
            // 
            // nudAX12ID
            // 
            this.nudAX12ID.Location = new System.Drawing.Point(175, 17);
            this.nudAX12ID.Name = "nudAX12ID";
            this.nudAX12ID.Size = new System.Drawing.Size(47, 20);
            this.nudAX12ID.TabIndex = 37;
            // 
            // frmCM9DesktopController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 609);
            this.Controls.Add(this.txtDebugWindow);
            this.Controls.Add(this.gbDebugSerialConnection);
            this.Controls.Add(this.gbControllerSerialConnection);
            this.Controls.Add(this.tcMotionPages);
            this.Controls.Add(this.txtReceivedString);
            this.Controls.Add(this.txtReceivedBytes);
            this.Controls.Add(this.lblReceivedString);
            this.Controls.Add(this.lblReceivedBytes);
            this.Name = "frmCM9DesktopController";
            this.Text = "CM9 Desktop Controller";
            this.Load += new System.EventHandler(this.frmMotion512ReaderTransmitter_Load);
            this.tcMotionPages.ResumeLayout(false);
            this.tpPageFromFile.ResumeLayout(false);
            this.tpPageFromFile.PerformLayout();
            this.gbxFilePoses.ResumeLayout(false);
            this.gbxFilePoses.PerformLayout();
            this.gbxFileHeader.ResumeLayout(false);
            this.gbxFileHeader.PerformLayout();
            this.tpPageFromFlash.ResumeLayout(false);
            this.tpPageFromFlash.PerformLayout();
            this.gbxFlashPoses.ResumeLayout(false);
            this.gbxFlashPoses.PerformLayout();
            this.gbxFlashHeader.ResumeLayout(false);
            this.gbxFlashHeader.PerformLayout();
            this.tpDynamixelReadWrite.ResumeLayout(false);
            this.grpbxAX12.ResumeLayout(false);
            this.grpbxAX12.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbControllerSerialConnection.ResumeLayout(false);
            this.gbControllerSerialConnection.PerformLayout();
            this.gbDebugSerialConnection.ResumeLayout(false);
            this.gbDebugSerialConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAX12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAX12ID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog ofdByteFile;
        private Label lblReceivedBytes;
        private Label lblReceivedString;
        private TextBox txtReceivedBytes;
        private TextBox txtReceivedString;
        private TabControl tcMotionPages;
        private TabPage tpPageFromFile;
        private Button btnFileWritePageToFlash;
        private Button btnMakeHeaderFromPage;
        private Button btnFileWriteToPageDown;
        private TextBox txtByteFileName;
        private Button btnFileWriteToPageUp;
        private TextBox txtFilePageNumberToWrite;
        private Button btnGetFile;
        private Label lblFileAtPosition;
        private Button btnFilePageDown;
        private Button btnFilePageUp;
        private TextBox txtFilePageNumber;
        private Label lblFilePageNumber;
        private GroupBox gbxFilePoses;
        private Label lblFileSpeed;
        private Label lblFileDelay;
        private GroupBox gbxFileHeader;
        private ComboBox cmbFileSlope;
        private ComboBox cmbFileRes1;
        private Label lblFileunidentifiedByte2;
        private TextBox txtFileunidentifiedByte2;
        private Label lblFileLinkedPage1;
        private TextBox txtFileLinkedPage1;
        private Label lblFileunidentifiedByte1;
        private TextBox txtFileUnidentifiedByte1;
        private Label lblFileSlope;
        private Label lblFilecheckSum;
        private Label lblFileLinkedPage2PlayCode;
        private Label lblFileLinkedPage2;
        private Label lblFileLinkedPage1PlayCode;
        private TextBox txtFilecheckSum;
        private TextBox txtFileLinkedPage2PlayCode;
        private TextBox txtFileLinkedPage2;
        private TextBox txtFileLinkedPage1PlayCode;
        private Label lblFileExitPage;
        private TextBox txtFileExitPage;
        private Label lblFilenextPage;
        private Label lblFileaccelTime;
        private Label lblFiledxlSetup;
        private Label lblFilePageSpeed;
        private TextBox txtFileNextPage;
        private TextBox txtFileAccelTime;
        private TextBox txtFileDxlSetup;
        private TextBox txtFilePageSpeed;
        private Label lblFilePoseCount;
        private TextBox txtFilePoseCount;
        private Label lblFileRes1;
        private Label lblFileSchedule;
        private Label lblFilePlayCount;
        private Label lblFileUnidentifiedByte0;
        private Label lblFileName;
        private TextBox txtFileSchedule;
        private TextBox txtFilePlayCount;
        private TextBox txtFileUnidentifiedByte0;
        private TextBox txtFileName;
        private TabPage tpPageFromFlash;
        private Button btnFilePlayPage;
        private GroupBox gbControllerSerialConnection;
        private Button btnControllerSerialConnectionConnect;
        private ComboBox cmbControllerSerialConnectionDataBits;
        private Label lblControllerSerialConnectionDataBits;
        private ComboBox cmbControllerSerialConnectionStopBits;
        private Label lblControllerSerialConnectionStopBits;
        private ComboBox cmbControllerSerialConnectionFlow;
        private Label lblControllerSerialConnectionFlow;
        private ComboBox cmbControllerSerialConnectionParity;
        private Label lblControllerSerialConnectionParity;
        private ComboBox cmbControllerSerialConnectionBaud;
        private Label lblControllerSerialConnectionBaud;
        private ComboBox cmbControllerSerialConnectionCOM;
        private Label lblControllerSerialConnectionCOM;
        private GroupBox gbDebugSerialConnection;
        private Button btnDebugSerialConnectionConnect;
        private ComboBox cmbDebugSerialConnectionDataBits;
        private Label lblDebugSerialConnectionDataBits;
        private ComboBox cmbDebugSerialConnectionStopBits;
        private Label lblDebugSerialConnectionStopBits;
        private ComboBox cmbDebugSerialConnectionFlow;
        private Label lblDebugSerialConnectionFlow;
        private ComboBox cmbDebugSerialConnectionParity;
        private Label lblDebugSerialConnectionParity;
        private ComboBox cmbDebugSerialConnectionBaud;
        private Label lblDebugSerialConnectionBaud;
        private ComboBox cmbDebugSerialConnectionCOM;
        private Label lblDebugSerialConnectionCOM;
        private TextBox txtDebugWindow;
        private TabPage tpDynamixelReadWrite;
        private Button btnFlashPlayPage;
        private Button btnFlashPageDown;
        private Button btnFlashPageUp;
        private TextBox txtFlashPageNumber;
        private Label lblFlashPageNumber;
        private GroupBox gbxFlashPoses;
        private Label lblPageS;
        private Label lblPageD;
        private GroupBox gbxFlashHeader;
        private ComboBox cmbFlashSlope;
        private ComboBox cmbFlashRes1;
        private Label lblFlashunidentifiedByte2;
        private TextBox txtFlashunidentifiedByte2;
        private Label lblFlashLinkedPage1;
        private TextBox txtFlashLinkedPage1;
        private Label lblFlashunidentifiedByte1;
        private TextBox txtFlashunidentifiedByte1;
        private Label lblFlashSlope;
        private Label lblFlashChecksum;
        private Label lblFlashLinkedPage2PlayCode;
        private Label lblFlashLinkedPage2;
        private Label lblFlashLinkedPage1PlayCode;
        private TextBox txtFlashChecksum;
        private TextBox txtFlashLinkedPage2PlayCode;
        private TextBox txtFlashLinkedPage2;
        private TextBox txtFlashLinkedPage1PlayCode;
        private Label lblFlashExitPage;
        private TextBox txtFlashExitPage;
        private Label lblFlashNextPage;
        private Label lblFlashaccelTime;
        private Label lblFlashdxlSetup;
        private Label lblFlashPageSpeed;
        private TextBox txtFlashNextPage;
        private TextBox txtFlashaccelTime;
        private TextBox txtFlashdxlSetup;
        private TextBox txtFlashPageSpeed;
        private Label lblFlashPoseCount;
        private TextBox txtFlashPoseCount;
        private Label lblFlashRes1;
        private Label lblFlashSchedule;
        private Label lblFlashPlayCount;
        private Label lblFlashUnidentifiedByte0;
        private Label lblFlashName;
        private TextBox txtFlashSchedule;
        private TextBox txtFlashPlayCount;
        private TextBox txtFlashUnidentifiedByte0;
        private TextBox txtFlashName;
        private Button btnMotionBreak;
        private TabPage tabPage1;
        private Button btnPing;
        private Button btnReadPosition;
        private Button btnWritePosition;
        private Label lblDynamixelID;
        private ComboBox cmbDynamixelID;
        private Button btnReadAX12;
        private GroupBox grpbxAX12;
        private Label lblAX12PresentSpeedHigh;
        private Label lblAX12PresentSpeedLow;
        private Label lblAX12PresentPositionHigh;
        private Label lblAX12PresentPositionLow;
        private Label lblAX12TorqueLimitHigh;
        private Label lblAX12TorqueLimitLow;
        private Label lblAX12MovingSpeedHigh;
        private Label lblAX12MovingSpeedLow;
        private Label lblAX12GoalPositionHigh;
        private Label lblAX12GoalPositionLow;
        private Label lblAX12CcwComplianceSlope;
        private Label lblAX12CwComplianceSlope;
        private Label lblAX12CcwComplianceMargin;
        private Label lblAX12CwComplianceMargin;
        private Label lblAX12LED;
        private Label lblAX12TorqueEnable;
        private NumericUpDown numericUpDown10;
        private NumericUpDown numericUpDown11;
        private NumericUpDown numericUpDown12;
        private NumericUpDown numericUpDown7;
        private NumericUpDown numericUpDown8;
        private NumericUpDown numericUpDown9;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown6;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown nudAX12;
        private Label lblAX12ID;
        private NumericUpDown numericUpDown16;
        private NumericUpDown numericUpDown17;
        private NumericUpDown numericUpDown18;
        private NumericUpDown numericUpDown13;
        private NumericUpDown numericUpDown14;
        private NumericUpDown numericUpDown15;
        private Label lblAX12PresentLoadHigh;
        private Label lblAX12PresentLoadLow;
        private NumericUpDown nudAX12ID;
    }
}

