﻿namespace TechavoSystem
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            TreeNode treeNode1 = new TreeNode("General Settings");
            TreeNode treeNode2 = new TreeNode("DO Settings", 1, 1);
            TreeNode treeNode3 = new TreeNode("DI Settings", 1, 1);
            TreeNode treeNode4 = new TreeNode("AI Settings", 1, 1);
            TreeNode treeNode5 = new TreeNode("IO Settings", new TreeNode[] { treeNode2, treeNode3, treeNode4 });
            TreeNode treeNode6 = new TreeNode("Pulse Settings", 0, 0);
            TreeNode treeNode7 = new TreeNode("User", 0, 0);
            TreeNode treeNode8 = new TreeNode("Modbus Master", 0, 0);
            TreeNode treeNode9 = new TreeNode("Modbus Slave", 0, 0);
            TreeNode treeNode10 = new TreeNode("GPRS Settings");
            TreeNode treeNode11 = new TreeNode("Status");
            TreeNode treeNode12 = new TreeNode("Console");
            pnlDashboard = new Panel();
            pnlDISettings = new Panel();
            btnDIWriteMemory = new Button();
            btnDIReadMemory = new Button();
            groupBox5 = new GroupBox();
            chkDIUser6 = new CheckBox();
            label46 = new Label();
            chkDIUser5 = new CheckBox();
            label47 = new Label();
            chkDIUser4 = new CheckBox();
            label48 = new Label();
            chkDIUser3 = new CheckBox();
            label49 = new Label();
            chkDIUser2 = new CheckBox();
            label50 = new Label();
            chkDIUser1 = new CheckBox();
            label51 = new Label();
            groupBox6 = new GroupBox();
            cmbDIDO8 = new ComboBox();
            label52 = new Label();
            cmbDIDO7 = new ComboBox();
            label53 = new Label();
            cmbDIDO6 = new ComboBox();
            label54 = new Label();
            cmbDIDO5 = new ComboBox();
            label55 = new Label();
            cmbDIDO4 = new ComboBox();
            label56 = new Label();
            cmbDIDO3 = new ComboBox();
            label57 = new Label();
            cmbDIDO2 = new ComboBox();
            label58 = new Label();
            cmbDIDO1 = new ComboBox();
            label59 = new Label();
            cmbDISelectChannel = new ComboBox();
            label68 = new Label();
            groupBox8 = new GroupBox();
            cmbDIReportDt = new ComboBox();
            label132 = new Label();
            txtDISMSRepeatSec = new TextBox();
            label69 = new Label();
            chkDIDataReport = new CheckBox();
            label102 = new Label();
            txtDISmsRepeatTime = new TextBox();
            label103 = new Label();
            txtDIAlarmVerifySec = new TextBox();
            label104 = new Label();
            cmbDIAlarm = new ComboBox();
            cmbDIType = new ComboBox();
            txtDIUnit = new TextBox();
            txtDIName = new TextBox();
            label105 = new Label();
            label106 = new Label();
            label107 = new Label();
            label108 = new Label();
            label41 = new Label();
            pnlGeneralSettings = new Panel();
            btnGeneralWriteMemory = new Button();
            btnGeneralReadMemory = new Button();
            groupBox13 = new GroupBox();
            txtIemiNo = new TextBox();
            chkGeneralRtcDebug = new CheckBox();
            label136 = new Label();
            chkGeneralModbusDebug = new CheckBox();
            label135 = new Label();
            label111 = new Label();
            txtGeneralSetTime = new TextBox();
            dtGeneralSetDate = new DateTimePicker();
            label61 = new Label();
            label60 = new Label();
            txtGeneralUserId = new TextBox();
            txtGeneralDataLogSec = new TextBox();
            label63 = new Label();
            txtGeneralSmsLogSec = new TextBox();
            label66 = new Label();
            label109 = new Label();
            label110 = new Label();
            label2 = new Label();
            pnlStatus = new Panel();
            groupBox27 = new GroupBox();
            lblStatusPulseCounter8 = new Label();
            lblStatusPulseCounter7 = new Label();
            lblStatusPulseCounter6 = new Label();
            lblStatusPulseCounter5 = new Label();
            lblStatusPulseCounter4 = new Label();
            lblStatusPulseCounter3 = new Label();
            lblStatusPulseCounter2 = new Label();
            pbDigiIn8 = new PictureBox();
            pbDigiIn7 = new PictureBox();
            pbDigiIn6 = new PictureBox();
            pbDigiIn5 = new PictureBox();
            pbDigiIn4 = new PictureBox();
            pbDigiIn3 = new PictureBox();
            pbDigiIn2 = new PictureBox();
            pbDigiIn1 = new PictureBox();
            pbDigiOut8 = new PictureBox();
            pbDigiOut7 = new PictureBox();
            pbDigiOut6 = new PictureBox();
            pbDigiOut5 = new PictureBox();
            pbDigiOut4 = new PictureBox();
            pbDigiOut3 = new PictureBox();
            pbDigiOut2 = new PictureBox();
            pbDigiOut1 = new PictureBox();
            lblAna8 = new Label();
            lblAna7 = new Label();
            lblAna6 = new Label();
            lblAna5 = new Label();
            lblAna4 = new Label();
            lblAna3 = new Label();
            lblAna2 = new Label();
            lblAna1 = new Label();
            lblTot8 = new Label();
            lblTot7 = new Label();
            lblTot6 = new Label();
            lblTot5 = new Label();
            lblTot4 = new Label();
            lblTot3 = new Label();
            lblTot2 = new Label();
            label171 = new Label();
            lblStatusDatalogSec = new Label();
            btnIOStatusRead = new Button();
            label165 = new Label();
            label166 = new Label();
            label167 = new Label();
            label168 = new Label();
            label169 = new Label();
            label170 = new Label();
            lblTot1 = new Label();
            lblStatusPulseCounter1 = new Label();
            lblStatusSystemVolt = new Label();
            groupBox26 = new GroupBox();
            btnStatusGSMRead = new Button();
            lblSignal2 = new Label();
            lblSignal3 = new Label();
            lblSignal4 = new Label();
            lblSignal5 = new Label();
            lblSignal1 = new Label();
            lblStatusProvider = new Label();
            lblStatusModule = new Label();
            lblStatusDecimal = new Label();
            label172 = new Label();
            label173 = new Label();
            label174 = new Label();
            label175 = new Label();
            label176 = new Label();
            lblStatusTime = new Label();
            lblStatusGprs = new Label();
            lblStatusDate = new Label();
            lblStatusIMEI = new Label();
            lblStatusProtocol = new Label();
            lblStatusSim = new Label();
            label177 = new Label();
            groupBox25 = new GroupBox();
            lblDataFlash = new Label();
            lblFirmwareVer = new Label();
            lblClientID = new Label();
            lblHardwareVer = new Label();
            lblStatusDeviceID = new Label();
            lblStatusDeviceModel = new Label();
            label182 = new Label();
            label183 = new Label();
            label184 = new Label();
            label185 = new Label();
            label186 = new Label();
            label187 = new Label();
            label164 = new Label();
            pnlDOSettings = new Panel();
            btnDOWriteMemory = new Button();
            btnDOReadMemory = new Button();
            cmbDOSelectChannel = new ComboBox();
            label115 = new Label();
            groupBox14 = new GroupBox();
            label121 = new Label();
            label120 = new Label();
            txtDoOnTime = new TextBox();
            label117 = new Label();
            txtDoOffTime = new TextBox();
            label116 = new Label();
            txtDoRelayDelayTime = new TextBox();
            label118 = new Label();
            txtDoRelayCloseOn = new TextBox();
            label119 = new Label();
            cmbDOType = new ComboBox();
            label114 = new Label();
            label40 = new Label();
            pnlModbusMaster = new Panel();
            groupBox19 = new GroupBox();
            label133 = new Label();
            btnMasterReadAll = new Button();
            btnMasterWriteAll = new Button();
            pnlMasterScroll = new Panel();
            groupBox44 = new GroupBox();
            cmbDecimalPoint32 = new ComboBox();
            label178 = new Label();
            cmbMasterFunctionCode32 = new ComboBox();
            cmbMasterByteOrder32 = new ComboBox();
            cmbMasterDataType32 = new ComboBox();
            cmbMasterActivation32 = new ComboBox();
            btnRegWriteMemory32 = new Button();
            btnRegReadMemory32 = new Button();
            txtMasterScaleFactor32 = new TextBox();
            txtMasterName32 = new TextBox();
            txtMasterRegStartAddress32 = new TextBox();
            txtMasterRegIndex32 = new TextBox();
            groupBox45 = new GroupBox();
            cmbDecimalPoint40 = new ComboBox();
            label179 = new Label();
            cmbMasterFunctionCode40 = new ComboBox();
            cmbMasterByteOrder40 = new ComboBox();
            cmbMasterDataType40 = new ComboBox();
            cmbMasterActivation40 = new ComboBox();
            btnRegWriteMemory40 = new Button();
            btnRegReadMemory40 = new Button();
            txtMasterScaleFactor40 = new TextBox();
            txtMasterName40 = new TextBox();
            txtMasterRegStartAddress40 = new TextBox();
            txtMasterRegIndex40 = new TextBox();
            groupBox46 = new GroupBox();
            cmbDecimalPoint39 = new ComboBox();
            label180 = new Label();
            cmbMasterFunctionCode39 = new ComboBox();
            cmbMasterByteOrder39 = new ComboBox();
            cmbMasterDataType39 = new ComboBox();
            cmbMasterActivation39 = new ComboBox();
            btnRegWriteMemory39 = new Button();
            btnRegReadMemory39 = new Button();
            txtMasterScaleFactor39 = new TextBox();
            txtMasterName39 = new TextBox();
            txtMasterRegStartAddress39 = new TextBox();
            txtMasterRegIndex39 = new TextBox();
            groupBox47 = new GroupBox();
            cmbDecimalPoint38 = new ComboBox();
            label181 = new Label();
            cmbMasterFunctionCode38 = new ComboBox();
            cmbMasterByteOrder38 = new ComboBox();
            cmbMasterDataType38 = new ComboBox();
            cmbMasterActivation38 = new ComboBox();
            btnRegWriteMemory38 = new Button();
            btnRegReadMemory38 = new Button();
            txtMasterScaleFactor38 = new TextBox();
            txtMasterName38 = new TextBox();
            txtMasterRegStartAddress38 = new TextBox();
            txtMasterRegIndex38 = new TextBox();
            groupBox48 = new GroupBox();
            cmbDecimalPoint36 = new ComboBox();
            label228 = new Label();
            cmbMasterFunctionCode36 = new ComboBox();
            cmbMasterByteOrder36 = new ComboBox();
            cmbMasterDataType36 = new ComboBox();
            cmbMasterActivation36 = new ComboBox();
            btnRegWriteMemory36 = new Button();
            btnRegReadMemory36 = new Button();
            txtMasterScaleFactor36 = new TextBox();
            txtMasterName36 = new TextBox();
            txtMasterRegStartAddress36 = new TextBox();
            txtMasterRegIndex36 = new TextBox();
            groupBox49 = new GroupBox();
            cmbDecimalPoint37 = new ComboBox();
            label229 = new Label();
            cmbMasterFunctionCode37 = new ComboBox();
            cmbMasterByteOrder37 = new ComboBox();
            cmbMasterDataType37 = new ComboBox();
            cmbMasterActivation37 = new ComboBox();
            btnRegWriteMemory37 = new Button();
            btnRegReadMemory37 = new Button();
            txtMasterScaleFactor37 = new TextBox();
            txtMasterName37 = new TextBox();
            txtMasterRegStartAddress37 = new TextBox();
            txtMasterRegIndex37 = new TextBox();
            groupBox50 = new GroupBox();
            cmbDecimalPoint35 = new ComboBox();
            label230 = new Label();
            cmbMasterFunctionCode35 = new ComboBox();
            cmbMasterByteOrder35 = new ComboBox();
            cmbMasterDataType35 = new ComboBox();
            cmbMasterActivation35 = new ComboBox();
            btnRegWriteMemory35 = new Button();
            btnRegReadMemory35 = new Button();
            txtMasterScaleFactor35 = new TextBox();
            txtMasterName35 = new TextBox();
            txtMasterRegStartAddress35 = new TextBox();
            txtMasterRegIndex35 = new TextBox();
            groupBox51 = new GroupBox();
            cmbDecimalPoint34 = new ComboBox();
            label231 = new Label();
            cmbMasterFunctionCode34 = new ComboBox();
            cmbMasterByteOrder34 = new ComboBox();
            cmbMasterDataType34 = new ComboBox();
            cmbMasterActivation34 = new ComboBox();
            btnRegWriteMemory34 = new Button();
            btnRegReadMemory34 = new Button();
            txtMasterScaleFactor34 = new TextBox();
            txtMasterName34 = new TextBox();
            txtMasterRegStartAddress34 = new TextBox();
            txtMasterRegIndex34 = new TextBox();
            groupBox52 = new GroupBox();
            cmbDecimalPoint33 = new ComboBox();
            label232 = new Label();
            cmbMasterFunctionCode33 = new ComboBox();
            cmbMasterByteOrder33 = new ComboBox();
            cmbMasterDataType33 = new ComboBox();
            cmbMasterActivation33 = new ComboBox();
            btnRegWriteMemory33 = new Button();
            btnRegReadMemory33 = new Button();
            txtMasterScaleFactor33 = new TextBox();
            txtMasterName33 = new TextBox();
            txtMasterRegStartAddress33 = new TextBox();
            txtMasterRegIndex33 = new TextBox();
            groupBox53 = new GroupBox();
            cmbDecimalPoint31 = new ComboBox();
            label233 = new Label();
            cmbMasterFunctionCode31 = new ComboBox();
            cmbMasterByteOrder31 = new ComboBox();
            cmbMasterDataType31 = new ComboBox();
            cmbMasterActivation31 = new ComboBox();
            btnRegWriteMemory31 = new Button();
            btnRegReadMemory31 = new Button();
            txtMasterScaleFactor31 = new TextBox();
            txtMasterName31 = new TextBox();
            txtMasterRegStartAddress31 = new TextBox();
            txtMasterRegIndex31 = new TextBox();
            groupBox54 = new GroupBox();
            cmbDecimalPoint22 = new ComboBox();
            label234 = new Label();
            cmbMasterFunctionCode22 = new ComboBox();
            cmbMasterByteOrder22 = new ComboBox();
            cmbMasterDataType22 = new ComboBox();
            cmbMasterActivation22 = new ComboBox();
            btnRegWriteMemory22 = new Button();
            btnRegReadMemory22 = new Button();
            txtMasterScaleFactor22 = new TextBox();
            txtMasterName22 = new TextBox();
            txtMasterRegStartAddress22 = new TextBox();
            txtMasterRegIndex22 = new TextBox();
            groupBox55 = new GroupBox();
            cmbDecimalPoint30 = new ComboBox();
            label235 = new Label();
            cmbMasterFunctionCode30 = new ComboBox();
            cmbMasterByteOrder30 = new ComboBox();
            cmbMasterDataType30 = new ComboBox();
            cmbMasterActivation30 = new ComboBox();
            btnRegWriteMemory30 = new Button();
            btnRegReadMemory30 = new Button();
            txtMasterScaleFactor30 = new TextBox();
            txtMasterName30 = new TextBox();
            txtMasterRegStartAddress30 = new TextBox();
            txtMasterRegIndex30 = new TextBox();
            groupBox56 = new GroupBox();
            cmbDecimalPoint29 = new ComboBox();
            label236 = new Label();
            cmbMasterFunctionCode29 = new ComboBox();
            cmbMasterByteOrder29 = new ComboBox();
            cmbMasterDataType29 = new ComboBox();
            cmbMasterActivation29 = new ComboBox();
            btnRegWriteMemory29 = new Button();
            btnRegReadMemory29 = new Button();
            txtMasterScaleFactor29 = new TextBox();
            txtMasterName29 = new TextBox();
            txtMasterRegStartAddress29 = new TextBox();
            txtMasterRegIndex29 = new TextBox();
            groupBox57 = new GroupBox();
            cmbDecimalPoint28 = new ComboBox();
            label237 = new Label();
            cmbMasterFunctionCode28 = new ComboBox();
            cmbMasterByteOrder28 = new ComboBox();
            cmbMasterDataType28 = new ComboBox();
            cmbMasterActivation28 = new ComboBox();
            btnRegWriteMemory28 = new Button();
            btnRegReadMemory28 = new Button();
            txtMasterScaleFactor28 = new TextBox();
            txtMasterName28 = new TextBox();
            txtMasterRegStartAddress28 = new TextBox();
            txtMasterRegIndex28 = new TextBox();
            groupBox58 = new GroupBox();
            cmbDecimalPoint26 = new ComboBox();
            label238 = new Label();
            cmbMasterFunctionCode26 = new ComboBox();
            cmbMasterByteOrder26 = new ComboBox();
            cmbMasterDataType26 = new ComboBox();
            cmbMasterActivation26 = new ComboBox();
            btnRegWriteMemory26 = new Button();
            btnRegReadMemory26 = new Button();
            txtMasterScaleFactor26 = new TextBox();
            txtMasterName26 = new TextBox();
            txtMasterRegStartAddress26 = new TextBox();
            txtMasterRegIndex26 = new TextBox();
            groupBox59 = new GroupBox();
            cmbDecimalPoint27 = new ComboBox();
            label239 = new Label();
            cmbMasterFunctionCode27 = new ComboBox();
            cmbMasterByteOrder27 = new ComboBox();
            cmbMasterDataType27 = new ComboBox();
            cmbMasterActivation27 = new ComboBox();
            btnRegWriteMemory27 = new Button();
            btnRegReadMemory27 = new Button();
            txtMasterScaleFactor27 = new TextBox();
            txtMasterName27 = new TextBox();
            txtMasterRegStartAddress27 = new TextBox();
            txtMasterRegIndex27 = new TextBox();
            groupBox60 = new GroupBox();
            cmbDecimalPoint25 = new ComboBox();
            label240 = new Label();
            cmbMasterFunctionCode25 = new ComboBox();
            cmbMasterByteOrder25 = new ComboBox();
            cmbMasterDataType25 = new ComboBox();
            cmbMasterActivation25 = new ComboBox();
            btnRegWriteMemory25 = new Button();
            btnRegReadMemory25 = new Button();
            txtMasterScaleFactor25 = new TextBox();
            txtMasterName25 = new TextBox();
            txtMasterRegStartAddress25 = new TextBox();
            txtMasterRegIndex25 = new TextBox();
            groupBox61 = new GroupBox();
            cmbDecimalPoint24 = new ComboBox();
            label241 = new Label();
            cmbMasterFunctionCode24 = new ComboBox();
            cmbMasterByteOrder24 = new ComboBox();
            cmbMasterDataType24 = new ComboBox();
            cmbMasterActivation24 = new ComboBox();
            btnRegWriteMemory24 = new Button();
            btnRegReadMemory24 = new Button();
            txtMasterScaleFactor24 = new TextBox();
            txtMasterName24 = new TextBox();
            txtMasterRegStartAddress24 = new TextBox();
            txtMasterRegIndex24 = new TextBox();
            groupBox62 = new GroupBox();
            cmbDecimalPoint23 = new ComboBox();
            label242 = new Label();
            cmbMasterFunctionCode23 = new ComboBox();
            cmbMasterByteOrder23 = new ComboBox();
            cmbMasterDataType23 = new ComboBox();
            cmbMasterActivation23 = new ComboBox();
            btnRegWriteMemory23 = new Button();
            btnRegReadMemory23 = new Button();
            txtMasterScaleFactor23 = new TextBox();
            txtMasterName23 = new TextBox();
            txtMasterRegStartAddress23 = new TextBox();
            txtMasterRegIndex23 = new TextBox();
            groupBox63 = new GroupBox();
            cmbDecimalPoint21 = new ComboBox();
            label243 = new Label();
            cmbMasterFunctionCode21 = new ComboBox();
            cmbMasterByteOrder21 = new ComboBox();
            cmbMasterDataType21 = new ComboBox();
            cmbMasterActivation21 = new ComboBox();
            btnRegWriteMemory21 = new Button();
            btnRegReadMemory21 = new Button();
            txtMasterScaleFactor21 = new TextBox();
            txtMasterName21 = new TextBox();
            txtMasterRegStartAddress21 = new TextBox();
            txtMasterRegIndex21 = new TextBox();
            groupBox34 = new GroupBox();
            cmbDecimalPoint12 = new ComboBox();
            label216 = new Label();
            cmbMasterFunctionCode12 = new ComboBox();
            cmbMasterByteOrder12 = new ComboBox();
            cmbMasterDataType12 = new ComboBox();
            cmbMasterActivation12 = new ComboBox();
            btnRegWriteMemory12 = new Button();
            btnRegReadMemory12 = new Button();
            txtMasterScaleFactor12 = new TextBox();
            txtMasterName12 = new TextBox();
            txtMasterRegStartAddress12 = new TextBox();
            txtMasterRegIndex12 = new TextBox();
            groupBox35 = new GroupBox();
            cmbDecimalPoint20 = new ComboBox();
            label208 = new Label();
            cmbMasterFunctionCode20 = new ComboBox();
            cmbMasterByteOrder20 = new ComboBox();
            cmbMasterDataType20 = new ComboBox();
            cmbMasterActivation20 = new ComboBox();
            btnRegWriteMemory20 = new Button();
            btnRegReadMemory20 = new Button();
            txtMasterScaleFactor20 = new TextBox();
            txtMasterName20 = new TextBox();
            txtMasterRegStartAddress20 = new TextBox();
            txtMasterRegIndex20 = new TextBox();
            groupBox36 = new GroupBox();
            cmbDecimalPoint19 = new ComboBox();
            label209 = new Label();
            cmbMasterFunctionCode19 = new ComboBox();
            cmbMasterByteOrder19 = new ComboBox();
            cmbMasterDataType19 = new ComboBox();
            cmbMasterActivation19 = new ComboBox();
            btnRegWriteMemory19 = new Button();
            btnRegReadMemory19 = new Button();
            txtMasterScaleFactor19 = new TextBox();
            txtMasterName19 = new TextBox();
            txtMasterRegStartAddress19 = new TextBox();
            txtMasterRegIndex19 = new TextBox();
            groupBox37 = new GroupBox();
            cmbDecimalPoint18 = new ComboBox();
            label210 = new Label();
            cmbMasterFunctionCode18 = new ComboBox();
            cmbMasterByteOrder18 = new ComboBox();
            cmbMasterDataType18 = new ComboBox();
            cmbMasterActivation18 = new ComboBox();
            btnRegWriteMemory18 = new Button();
            btnRegReadMemory18 = new Button();
            txtMasterScaleFactor18 = new TextBox();
            txtMasterName18 = new TextBox();
            txtMasterRegStartAddress18 = new TextBox();
            txtMasterRegIndex18 = new TextBox();
            groupBox38 = new GroupBox();
            cmbDecimalPoint16 = new ComboBox();
            label212 = new Label();
            cmbMasterFunctionCode16 = new ComboBox();
            cmbMasterByteOrder16 = new ComboBox();
            cmbMasterDataType16 = new ComboBox();
            cmbMasterActivation16 = new ComboBox();
            btnRegWriteMemory16 = new Button();
            btnRegReadMemory16 = new Button();
            txtMasterScaleFactor16 = new TextBox();
            txtMasterName16 = new TextBox();
            txtMasterRegStartAddress16 = new TextBox();
            txtMasterRegIndex16 = new TextBox();
            groupBox39 = new GroupBox();
            cmbDecimalPoint17 = new ComboBox();
            label211 = new Label();
            cmbMasterFunctionCode17 = new ComboBox();
            cmbMasterByteOrder17 = new ComboBox();
            cmbMasterDataType17 = new ComboBox();
            cmbMasterActivation17 = new ComboBox();
            btnRegWriteMemory17 = new Button();
            btnRegReadMemory17 = new Button();
            txtMasterScaleFactor17 = new TextBox();
            txtMasterName17 = new TextBox();
            txtMasterRegStartAddress17 = new TextBox();
            txtMasterRegIndex17 = new TextBox();
            groupBox40 = new GroupBox();
            cmbDecimalPoint15 = new ComboBox();
            label213 = new Label();
            cmbMasterFunctionCode15 = new ComboBox();
            cmbMasterByteOrder15 = new ComboBox();
            cmbMasterDataType15 = new ComboBox();
            cmbMasterActivation15 = new ComboBox();
            btnRegWriteMemory15 = new Button();
            btnRegReadMemory15 = new Button();
            txtMasterScaleFactor15 = new TextBox();
            txtMasterName15 = new TextBox();
            txtMasterRegStartAddress15 = new TextBox();
            txtMasterRegIndex15 = new TextBox();
            groupBox41 = new GroupBox();
            cmbDecimalPoint14 = new ComboBox();
            label214 = new Label();
            cmbMasterFunctionCode14 = new ComboBox();
            cmbMasterByteOrder14 = new ComboBox();
            cmbMasterDataType14 = new ComboBox();
            cmbMasterActivation14 = new ComboBox();
            btnRegWriteMemory14 = new Button();
            btnRegReadMemory14 = new Button();
            txtMasterScaleFactor14 = new TextBox();
            txtMasterName14 = new TextBox();
            txtMasterRegStartAddress14 = new TextBox();
            txtMasterRegIndex14 = new TextBox();
            groupBox42 = new GroupBox();
            cmbDecimalPoint13 = new ComboBox();
            label215 = new Label();
            cmbMasterFunctionCode13 = new ComboBox();
            cmbMasterByteOrder13 = new ComboBox();
            cmbMasterDataType13 = new ComboBox();
            cmbMasterActivation13 = new ComboBox();
            btnRegWriteMemory13 = new Button();
            btnRegReadMemory13 = new Button();
            txtMasterScaleFactor13 = new TextBox();
            txtMasterName13 = new TextBox();
            txtMasterRegStartAddress13 = new TextBox();
            txtMasterRegIndex13 = new TextBox();
            groupBox43 = new GroupBox();
            cmbDecimalPoint11 = new ComboBox();
            label217 = new Label();
            cmbMasterFunctionCode11 = new ComboBox();
            cmbMasterByteOrder11 = new ComboBox();
            cmbMasterDataType11 = new ComboBox();
            cmbMasterActivation11 = new ComboBox();
            btnRegWriteMemory11 = new Button();
            btnRegReadMemory11 = new Button();
            txtMasterScaleFactor11 = new TextBox();
            txtMasterName11 = new TextBox();
            txtMasterRegStartAddress11 = new TextBox();
            txtMasterRegIndex11 = new TextBox();
            groupBox21 = new GroupBox();
            cmbDecimalPoint2 = new ComboBox();
            label226 = new Label();
            cmbMasterFunctionCode2 = new ComboBox();
            cmbMasterByteOrder2 = new ComboBox();
            cmbMasterDataType2 = new ComboBox();
            cmbMasterActivation2 = new ComboBox();
            btnRegWriteMemory2 = new Button();
            btnRegReadMemory2 = new Button();
            txtMasterScaleFactor2 = new TextBox();
            txtMasterName2 = new TextBox();
            txtMasterRegStartAddress2 = new TextBox();
            txtMasterRegIndex2 = new TextBox();
            groupBox32 = new GroupBox();
            cmbDecimalPoint10 = new ComboBox();
            label218 = new Label();
            cmbMasterFunctionCode10 = new ComboBox();
            cmbMasterByteOrder10 = new ComboBox();
            cmbMasterDataType10 = new ComboBox();
            cmbMasterActivation10 = new ComboBox();
            btnRegWriteMemory10 = new Button();
            btnRegReadMemory10 = new Button();
            txtMasterScaleFactor10 = new TextBox();
            txtMasterName10 = new TextBox();
            txtMasterRegStartAddress10 = new TextBox();
            txtMasterRegIndex10 = new TextBox();
            groupBox33 = new GroupBox();
            cmbDecimalPoint9 = new ComboBox();
            label219 = new Label();
            cmbMasterFunctionCode9 = new ComboBox();
            cmbMasterByteOrder9 = new ComboBox();
            cmbMasterDataType9 = new ComboBox();
            cmbMasterActivation9 = new ComboBox();
            btnRegWriteMemory9 = new Button();
            btnRegReadMemory9 = new Button();
            txtMasterScaleFactor9 = new TextBox();
            txtMasterName9 = new TextBox();
            txtMasterRegStartAddress9 = new TextBox();
            txtMasterRegIndex9 = new TextBox();
            groupBox28 = new GroupBox();
            cmbDecimalPoint8 = new ComboBox();
            label220 = new Label();
            cmbMasterFunctionCode8 = new ComboBox();
            cmbMasterByteOrder8 = new ComboBox();
            cmbMasterDataType8 = new ComboBox();
            cmbMasterActivation8 = new ComboBox();
            btnRegWriteMemory8 = new Button();
            btnRegReadMemory8 = new Button();
            txtMasterScaleFactor8 = new TextBox();
            txtMasterName8 = new TextBox();
            txtMasterRegStartAddress8 = new TextBox();
            txtMasterRegIndex8 = new TextBox();
            groupBox29 = new GroupBox();
            cmbDecimalPoint6 = new ComboBox();
            label222 = new Label();
            cmbMasterFunctionCode6 = new ComboBox();
            cmbMasterByteOrder6 = new ComboBox();
            cmbMasterDataType6 = new ComboBox();
            cmbMasterActivation6 = new ComboBox();
            btnRegWriteMemory6 = new Button();
            btnRegReadMemory6 = new Button();
            txtMasterScaleFactor6 = new TextBox();
            txtMasterName6 = new TextBox();
            txtMasterRegStartAddress6 = new TextBox();
            txtMasterRegIndex6 = new TextBox();
            groupBox30 = new GroupBox();
            cmbDecimalPoint7 = new ComboBox();
            label221 = new Label();
            cmbMasterFunctionCode7 = new ComboBox();
            cmbMasterByteOrder7 = new ComboBox();
            cmbMasterDataType7 = new ComboBox();
            cmbMasterActivation7 = new ComboBox();
            btnRegWriteMemory7 = new Button();
            btnRegReadMemory7 = new Button();
            txtMasterScaleFactor7 = new TextBox();
            txtMasterName7 = new TextBox();
            txtMasterRegStartAddress7 = new TextBox();
            txtMasterRegIndex7 = new TextBox();
            groupBox31 = new GroupBox();
            cmbDecimalPoint5 = new ComboBox();
            label223 = new Label();
            cmbMasterFunctionCode5 = new ComboBox();
            cmbMasterByteOrder5 = new ComboBox();
            cmbMasterDataType5 = new ComboBox();
            cmbMasterActivation5 = new ComboBox();
            btnRegWriteMemory5 = new Button();
            btnRegReadMemory5 = new Button();
            txtMasterScaleFactor5 = new TextBox();
            txtMasterName5 = new TextBox();
            txtMasterRegStartAddress5 = new TextBox();
            txtMasterRegIndex5 = new TextBox();
            groupBox22 = new GroupBox();
            cmbDecimalPoint4 = new ComboBox();
            label224 = new Label();
            cmbMasterFunctionCode4 = new ComboBox();
            cmbMasterByteOrder4 = new ComboBox();
            cmbMasterDataType4 = new ComboBox();
            cmbMasterActivation4 = new ComboBox();
            btnRegWriteMemory4 = new Button();
            btnRegReadMemory4 = new Button();
            txtMasterScaleFactor4 = new TextBox();
            txtMasterName4 = new TextBox();
            txtMasterRegStartAddress4 = new TextBox();
            txtMasterRegIndex4 = new TextBox();
            groupBox24 = new GroupBox();
            cmbDecimalPoint3 = new ComboBox();
            label225 = new Label();
            cmbMasterFunctionCode3 = new ComboBox();
            cmbMasterByteOrder3 = new ComboBox();
            cmbMasterDataType3 = new ComboBox();
            cmbMasterActivation3 = new ComboBox();
            btnRegWriteMemory3 = new Button();
            btnRegReadMemory3 = new Button();
            txtMasterScaleFactor3 = new TextBox();
            txtMasterName3 = new TextBox();
            txtMasterRegStartAddress3 = new TextBox();
            txtMasterRegIndex3 = new TextBox();
            groupBox20 = new GroupBox();
            cmbDecimalPoint1 = new ComboBox();
            label227 = new Label();
            cmbMasterFunctionCode1 = new ComboBox();
            cmbMasterByteOrder1 = new ComboBox();
            cmbMasterDataType1 = new ComboBox();
            cmbMasterActivation1 = new ComboBox();
            btnRegWriteMemory1 = new Button();
            btnRegReadMemory1 = new Button();
            txtMasterScaleFactor1 = new TextBox();
            txtMasterName1 = new TextBox();
            txtMasterRegStartAddress1 = new TextBox();
            txtMasterRegIndex1 = new TextBox();
            label207 = new Label();
            label206 = new Label();
            label205 = new Label();
            label196 = new Label();
            label201 = new Label();
            label202 = new Label();
            label203 = new Label();
            label204 = new Label();
            groupBox18 = new GroupBox();
            cmbMasterUartType = new ComboBox();
            cmbMasterBaudRate = new ComboBox();
            label200 = new Label();
            label199 = new Label();
            txtMasterPollingInterval = new TextBox();
            label198 = new Label();
            txtMasterTimeout = new TextBox();
            label189 = new Label();
            txtMasterSlaveId = new TextBox();
            label197 = new Label();
            btnSlaveConnectionWriteMemory = new Button();
            btnSlaveConnectionReadMemory = new Button();
            cmbMasterSlaveIndex = new ComboBox();
            label195 = new Label();
            label45 = new Label();
            pnlModbusSlave = new Panel();
            btnModbusSlaveWriteMemory = new Button();
            btnModbusSlaveReadMemory = new Button();
            groupBox17 = new GroupBox();
            cmbModbusUartType = new ComboBox();
            cmbModbusPortType = new ComboBox();
            txtModbusSlaveId = new TextBox();
            txtModbusTimeout = new TextBox();
            label194 = new Label();
            txtModbusPollingInterval = new TextBox();
            label193 = new Label();
            label192 = new Label();
            cmbModbusBaudRate = new ComboBox();
            label191 = new Label();
            lblPortType = new Label();
            label190 = new Label();
            label44 = new Label();
            pnlPulseSettings = new Panel();
            btnPulseWriteMemory = new Button();
            btnPulseReadMemory = new Button();
            groupBox7 = new GroupBox();
            cmbPulseReportDT = new ComboBox();
            label131 = new Label();
            txtPulseDurationRef = new TextBox();
            label130 = new Label();
            chkPulseIsVolatile = new CheckBox();
            label62 = new Label();
            txtPulseKfactor = new TextBox();
            label64 = new Label();
            txtAdjustPulseCount = new TextBox();
            label65 = new Label();
            label42 = new Label();
            pnlConsole = new Panel();
            txtSystemLog = new TextBox();
            txtConsoleInput = new TextBox();
            btnConsoleSend = new Button();
            groupBox23 = new GroupBox();
            btnModbusRead = new Button();
            btnLogMonitorOff = new Button();
            btnClear = new Button();
            label188 = new Label();
            pnlGPRSSettings = new Panel();
            gbGprsIPSett2 = new GroupBox();
            cmbIp2EventTransmission = new ComboBox();
            cmbIp2SSLSecurityEnabled = new ComboBox();
            chkIp2SSLSecurityEnable = new CheckBox();
            txtIP2ServerPort = new TextBox();
            txtIP2ServerIP = new TextBox();
            label160 = new Label();
            label161 = new Label();
            label162 = new Label();
            label163 = new Label();
            btnGPRSWriteMemory = new Button();
            btnGPRSReadMemory = new Button();
            gbGprsTopics = new GroupBox();
            txtSubscribeCmd = new TextBox();
            txtPublishCMDReply = new TextBox();
            txtPublishEvent = new TextBox();
            label149 = new Label();
            label150 = new Label();
            label151 = new Label();
            gbGprsBrokerSett = new GroupBox();
            btnMQTTShowPass = new Button();
            cmbQosLevel = new ComboBox();
            label152 = new Label();
            chkAuthEnable = new CheckBox();
            txtMQTTPassword = new TextBox();
            txtMQTTUserName = new TextBox();
            txtClientId = new TextBox();
            txtBrokerPort = new TextBox();
            txtBrokerIPDomain = new TextBox();
            label153 = new Label();
            label154 = new Label();
            label155 = new Label();
            label156 = new Label();
            label157 = new Label();
            label158 = new Label();
            label159 = new Label();
            cmbConnectProtocol = new ComboBox();
            groupBox16 = new GroupBox();
            btnSSLModuleReupdate = new Button();
            btnClientKey = new Button();
            btnClientCertificate = new Button();
            btnCACertificate = new Button();
            txtClientKey = new TextBox();
            txtClientCertificate = new TextBox();
            txtCAServerCertificate = new TextBox();
            label137 = new Label();
            label138 = new Label();
            label139 = new Label();
            gbGprsModemSett = new GroupBox();
            btnIPSettPassView = new Button();
            txtSimPassword = new TextBox();
            txtSimUserName = new TextBox();
            txtAPN = new TextBox();
            label140 = new Label();
            label141 = new Label();
            label142 = new Label();
            label143 = new Label();
            gbGprsIPSett1 = new GroupBox();
            cmbEventTransmission = new ComboBox();
            cmbSSLSecurityEnabled = new ComboBox();
            chkSSLSecurityEnable = new CheckBox();
            txtServerPort = new TextBox();
            txtServerIPURL = new TextBox();
            label144 = new Label();
            label145 = new Label();
            label146 = new Label();
            label147 = new Label();
            label67 = new Label();
            label148 = new Label();
            pnlAISettings = new Panel();
            btnWriteMemoryAI = new Button();
            btnReadMemoryAI = new Button();
            groupBox4 = new GroupBox();
            chkUser6 = new CheckBox();
            label36 = new Label();
            chkUser5 = new CheckBox();
            label35 = new Label();
            chkUser4 = new CheckBox();
            label34 = new Label();
            chkUser3 = new CheckBox();
            label33 = new Label();
            chkUser2 = new CheckBox();
            label32 = new Label();
            chkUser1 = new CheckBox();
            label31 = new Label();
            groupBox3 = new GroupBox();
            cmbDO8 = new ComboBox();
            label30 = new Label();
            cmbDO7 = new ComboBox();
            label29 = new Label();
            cmbDO6 = new ComboBox();
            label28 = new Label();
            cmbDO5 = new ComboBox();
            label27 = new Label();
            cmbDO4 = new ComboBox();
            label26 = new Label();
            cmbDO3 = new ComboBox();
            label25 = new Label();
            cmbDO2 = new ComboBox();
            label24 = new Label();
            cmbDO1 = new ComboBox();
            label23 = new Label();
            groupBox2 = new GroupBox();
            txtKFactor = new TextBox();
            chkDataReport = new CheckBox();
            label1 = new Label();
            txtTotalizerUnit = new TextBox();
            label22 = new Label();
            cmbReportDataType = new ComboBox();
            label21 = new Label();
            txtDisplayDecimalPoint = new TextBox();
            label19 = new Label();
            chkVolatileFlag = new CheckBox();
            label18 = new Label();
            cmbTimebase = new ComboBox();
            label17 = new Label();
            label16 = new Label();
            label11 = new Label();
            chkTotalizer = new CheckBox();
            cmbSelectChannel = new ComboBox();
            label15 = new Label();
            groupBox1 = new GroupBox();
            cmbAIReportDataType = new ComboBox();
            label39 = new Label();
            chkAIDataReport = new CheckBox();
            label38 = new Label();
            txtAlarmSmsInterval = new TextBox();
            label37 = new Label();
            txtAlarmConfirmationSec = new TextBox();
            label20 = new Label();
            cmbAIAlarm = new ComboBox();
            cmbAIType = new ComboBox();
            txtThresoldLow = new TextBox();
            txtThresoldHigh = new TextBox();
            txtMaxValue = new TextBox();
            txtMinValue = new TextBox();
            txtUnit = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label13 = new Label();
            label6 = new Label();
            label12 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label4 = new Label();
            pnlUser = new Panel();
            cmbUserIndex = new ComboBox();
            label128 = new Label();
            btnUserWriteMemory = new Button();
            btnUserReadMemory = new Button();
            groupBox15 = new GroupBox();
            chkUserSmsTimerReport = new CheckBox();
            label134 = new Label();
            cmbUserSelectDo = new ComboBox();
            chkUserIsVolatile = new CheckBox();
            label129 = new Label();
            label112 = new Label();
            chkUserCanCall = new CheckBox();
            chkUserIsAlarm = new CheckBox();
            chkUserIsAdmin = new CheckBox();
            chkUserSmsOnGprsFail = new CheckBox();
            chkUserSmsOnLowTower = new CheckBox();
            label113 = new Label();
            label122 = new Label();
            chkUserSmsOnPowerOn = new CheckBox();
            txtUserMobileNo = new TextBox();
            label123 = new Label();
            label124 = new Label();
            label125 = new Label();
            label126 = new Label();
            label127 = new Label();
            label43 = new Label();
            pnlModbusSettings = new Panel();
            button5 = new Button();
            button6 = new Button();
            groupBox9 = new GroupBox();
            checkBox16 = new CheckBox();
            label70 = new Label();
            checkBox17 = new CheckBox();
            label71 = new Label();
            checkBox18 = new CheckBox();
            label72 = new Label();
            checkBox19 = new CheckBox();
            label73 = new Label();
            checkBox20 = new CheckBox();
            label74 = new Label();
            checkBox21 = new CheckBox();
            label75 = new Label();
            groupBox10 = new GroupBox();
            comboBox29 = new ComboBox();
            label76 = new Label();
            comboBox30 = new ComboBox();
            label77 = new Label();
            comboBox31 = new ComboBox();
            label78 = new Label();
            comboBox32 = new ComboBox();
            label79 = new Label();
            comboBox33 = new ComboBox();
            label80 = new Label();
            comboBox34 = new ComboBox();
            label81 = new Label();
            comboBox35 = new ComboBox();
            label82 = new Label();
            comboBox36 = new ComboBox();
            label83 = new Label();
            groupBox11 = new GroupBox();
            textBox19 = new TextBox();
            label84 = new Label();
            comboBox37 = new ComboBox();
            label85 = new Label();
            checkBox22 = new CheckBox();
            label86 = new Label();
            textBox20 = new TextBox();
            label87 = new Label();
            checkBox23 = new CheckBox();
            label88 = new Label();
            comboBox38 = new ComboBox();
            label89 = new Label();
            textBox21 = new TextBox();
            label90 = new Label();
            comboBox39 = new ComboBox();
            label91 = new Label();
            comboBox40 = new ComboBox();
            label92 = new Label();
            groupBox12 = new GroupBox();
            comboBox41 = new ComboBox();
            comboBox42 = new ComboBox();
            textBox22 = new TextBox();
            textBox23 = new TextBox();
            textBox24 = new TextBox();
            textBox25 = new TextBox();
            textBox26 = new TextBox();
            textBox27 = new TextBox();
            label93 = new Label();
            label94 = new Label();
            label95 = new Label();
            label96 = new Label();
            label97 = new Label();
            label98 = new Label();
            label99 = new Label();
            checkBox24 = new CheckBox();
            label100 = new Label();
            label101 = new Label();
            label3 = new Label();
            pnlMenu = new Panel();
            menu = new TreeView();
            menuImgList = new ImageList(components);
            lblError = new Label();
            LoginTimer = new System.Windows.Forms.Timer(components);
            btnConnect = new Button();
            cmbComPorts = new ComboBox();
            label14 = new Label();
            pnlConnect = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnOpenConfigFile = new Button();
            btnPortRefresh = new Button();
            lblProgressPercent = new Label();
            pbProcessing = new ProgressBar();
            errorReset = new System.Windows.Forms.Timer(components);
            lnkLogin = new LinkLabel();
            pictureBox1 = new PictureBox();
            lblErrorDetails = new Label();
            pnlDashboard.SuspendLayout();
            pnlDISettings.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox8.SuspendLayout();
            pnlGeneralSettings.SuspendLayout();
            groupBox13.SuspendLayout();
            pnlStatus.SuspendLayout();
            groupBox27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDigiIn8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiIn7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiIn6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiIn5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiIn4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiIn3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiIn2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiIn1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiOut8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiOut7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiOut6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiOut5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiOut4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiOut3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiOut2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiOut1).BeginInit();
            groupBox26.SuspendLayout();
            groupBox25.SuspendLayout();
            pnlDOSettings.SuspendLayout();
            groupBox14.SuspendLayout();
            pnlModbusMaster.SuspendLayout();
            groupBox19.SuspendLayout();
            pnlMasterScroll.SuspendLayout();
            groupBox44.SuspendLayout();
            groupBox45.SuspendLayout();
            groupBox46.SuspendLayout();
            groupBox47.SuspendLayout();
            groupBox48.SuspendLayout();
            groupBox49.SuspendLayout();
            groupBox50.SuspendLayout();
            groupBox51.SuspendLayout();
            groupBox52.SuspendLayout();
            groupBox53.SuspendLayout();
            groupBox54.SuspendLayout();
            groupBox55.SuspendLayout();
            groupBox56.SuspendLayout();
            groupBox57.SuspendLayout();
            groupBox58.SuspendLayout();
            groupBox59.SuspendLayout();
            groupBox60.SuspendLayout();
            groupBox61.SuspendLayout();
            groupBox62.SuspendLayout();
            groupBox63.SuspendLayout();
            groupBox34.SuspendLayout();
            groupBox35.SuspendLayout();
            groupBox36.SuspendLayout();
            groupBox37.SuspendLayout();
            groupBox38.SuspendLayout();
            groupBox39.SuspendLayout();
            groupBox40.SuspendLayout();
            groupBox41.SuspendLayout();
            groupBox42.SuspendLayout();
            groupBox43.SuspendLayout();
            groupBox21.SuspendLayout();
            groupBox32.SuspendLayout();
            groupBox33.SuspendLayout();
            groupBox28.SuspendLayout();
            groupBox29.SuspendLayout();
            groupBox30.SuspendLayout();
            groupBox31.SuspendLayout();
            groupBox22.SuspendLayout();
            groupBox24.SuspendLayout();
            groupBox20.SuspendLayout();
            groupBox18.SuspendLayout();
            pnlModbusSlave.SuspendLayout();
            groupBox17.SuspendLayout();
            pnlPulseSettings.SuspendLayout();
            groupBox7.SuspendLayout();
            pnlConsole.SuspendLayout();
            groupBox23.SuspendLayout();
            pnlGPRSSettings.SuspendLayout();
            gbGprsIPSett2.SuspendLayout();
            gbGprsTopics.SuspendLayout();
            gbGprsBrokerSett.SuspendLayout();
            groupBox16.SuspendLayout();
            gbGprsModemSett.SuspendLayout();
            gbGprsIPSett1.SuspendLayout();
            pnlAISettings.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            pnlUser.SuspendLayout();
            groupBox15.SuspendLayout();
            pnlModbusSettings.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox12.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlConnect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(pnlGPRSSettings);
            pnlDashboard.Controls.Add(pnlDISettings);
            pnlDashboard.Controls.Add(pnlGeneralSettings);
            pnlDashboard.Controls.Add(pnlStatus);
            pnlDashboard.Controls.Add(pnlDOSettings);
            pnlDashboard.Controls.Add(pnlModbusMaster);
            pnlDashboard.Controls.Add(pnlModbusSlave);
            pnlDashboard.Controls.Add(pnlPulseSettings);
            pnlDashboard.Controls.Add(pnlConsole);
            pnlDashboard.Controls.Add(pnlAISettings);
            pnlDashboard.Controls.Add(pnlUser);
            pnlDashboard.Controls.Add(pnlModbusSettings);
            pnlDashboard.Controls.Add(pnlMenu);
            pnlDashboard.Location = new Point(7, 87);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(1460, 837);
            pnlDashboard.TabIndex = 1;
            pnlDashboard.Visible = false;
            // 
            // pnlDISettings
            // 
            pnlDISettings.Controls.Add(btnDIWriteMemory);
            pnlDISettings.Controls.Add(btnDIReadMemory);
            pnlDISettings.Controls.Add(groupBox5);
            pnlDISettings.Controls.Add(groupBox6);
            pnlDISettings.Controls.Add(cmbDISelectChannel);
            pnlDISettings.Controls.Add(label68);
            pnlDISettings.Controls.Add(groupBox8);
            pnlDISettings.Controls.Add(label41);
            pnlDISettings.Location = new Point(321, 9);
            pnlDISettings.Name = "pnlDISettings";
            pnlDISettings.Size = new Size(1133, 822);
            pnlDISettings.TabIndex = 3;
            pnlDISettings.Visible = false;
            // 
            // btnDIWriteMemory
            // 
            btnDIWriteMemory.BackColor = Color.Red;
            btnDIWriteMemory.Cursor = Cursors.Hand;
            btnDIWriteMemory.ForeColor = Color.White;
            btnDIWriteMemory.Location = new Point(597, 757);
            btnDIWriteMemory.Name = "btnDIWriteMemory";
            btnDIWriteMemory.Size = new Size(172, 42);
            btnDIWriteMemory.TabIndex = 49;
            btnDIWriteMemory.Text = "Write Memory";
            btnDIWriteMemory.UseVisualStyleBackColor = false;
            btnDIWriteMemory.Click += (this.btnDIWriteMemory_Click);
            // 
            // btnDIReadMemory
            // 
            btnDIReadMemory.BackColor = Color.DarkKhaki;
            btnDIReadMemory.Cursor = Cursors.Hand;
            btnDIReadMemory.ForeColor = Color.White;
            btnDIReadMemory.Location = new Point(325, 757);
            btnDIReadMemory.Name = "btnDIReadMemory";
            btnDIReadMemory.Size = new Size(190, 42);
            btnDIReadMemory.TabIndex = 48;
            btnDIReadMemory.Text = "Read Memory";
            btnDIReadMemory.UseVisualStyleBackColor = false;
            btnDIReadMemory.Click += (this.btnDIReadMemory_Click);
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(chkDIUser6);
            groupBox5.Controls.Add(label46);
            groupBox5.Controls.Add(chkDIUser5);
            groupBox5.Controls.Add(label47);
            groupBox5.Controls.Add(chkDIUser4);
            groupBox5.Controls.Add(label48);
            groupBox5.Controls.Add(chkDIUser3);
            groupBox5.Controls.Add(label49);
            groupBox5.Controls.Add(chkDIUser2);
            groupBox5.Controls.Add(label50);
            groupBox5.Controls.Add(chkDIUser1);
            groupBox5.Controls.Add(label51);
            groupBox5.Location = new Point(763, 126);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(355, 404);
            groupBox5.TabIndex = 47;
            groupBox5.TabStop = false;
            groupBox5.Text = "Telephone to Alarm";
            // 
            // chkDIUser6
            // 
            chkDIUser6.AutoSize = true;
            chkDIUser6.Location = new Point(119, 199);
            chkDIUser6.Name = "chkDIUser6";
            chkDIUser6.Size = new Size(18, 17);
            chkDIUser6.TabIndex = 37;
            chkDIUser6.UseVisualStyleBackColor = true;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Location = new Point(15, 196);
            label46.Name = "label46";
            label46.Size = new Size(58, 20);
            label46.TabIndex = 36;
            label46.Text = "USER-6";
            // 
            // chkDIUser5
            // 
            chkDIUser5.AutoSize = true;
            chkDIUser5.Location = new Point(119, 167);
            chkDIUser5.Name = "chkDIUser5";
            chkDIUser5.Size = new Size(18, 17);
            chkDIUser5.TabIndex = 35;
            chkDIUser5.UseVisualStyleBackColor = true;
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Location = new Point(15, 164);
            label47.Name = "label47";
            label47.Size = new Size(58, 20);
            label47.TabIndex = 34;
            label47.Text = "USER-5";
            // 
            // chkDIUser4
            // 
            chkDIUser4.AutoSize = true;
            chkDIUser4.Location = new Point(119, 135);
            chkDIUser4.Name = "chkDIUser4";
            chkDIUser4.Size = new Size(18, 17);
            chkDIUser4.TabIndex = 33;
            chkDIUser4.UseVisualStyleBackColor = true;
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Location = new Point(15, 132);
            label48.Name = "label48";
            label48.Size = new Size(58, 20);
            label48.TabIndex = 32;
            label48.Text = "USER-4";
            // 
            // chkDIUser3
            // 
            chkDIUser3.AutoSize = true;
            chkDIUser3.Location = new Point(119, 103);
            chkDIUser3.Name = "chkDIUser3";
            chkDIUser3.Size = new Size(18, 17);
            chkDIUser3.TabIndex = 31;
            chkDIUser3.UseVisualStyleBackColor = true;
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Location = new Point(15, 100);
            label49.Name = "label49";
            label49.Size = new Size(58, 20);
            label49.TabIndex = 30;
            label49.Text = "USER-3";
            // 
            // chkDIUser2
            // 
            chkDIUser2.AutoSize = true;
            chkDIUser2.Location = new Point(119, 71);
            chkDIUser2.Name = "chkDIUser2";
            chkDIUser2.Size = new Size(18, 17);
            chkDIUser2.TabIndex = 29;
            chkDIUser2.UseVisualStyleBackColor = true;
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Location = new Point(15, 68);
            label50.Name = "label50";
            label50.Size = new Size(58, 20);
            label50.TabIndex = 28;
            label50.Text = "USER-2";
            // 
            // chkDIUser1
            // 
            chkDIUser1.AutoSize = true;
            chkDIUser1.Location = new Point(119, 39);
            chkDIUser1.Name = "chkDIUser1";
            chkDIUser1.Size = new Size(18, 17);
            chkDIUser1.TabIndex = 27;
            chkDIUser1.UseVisualStyleBackColor = true;
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Location = new Point(15, 36);
            label51.Name = "label51";
            label51.Size = new Size(58, 20);
            label51.TabIndex = 26;
            label51.Text = "USER-1";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(cmbDIDO8);
            groupBox6.Controls.Add(label52);
            groupBox6.Controls.Add(cmbDIDO7);
            groupBox6.Controls.Add(label53);
            groupBox6.Controls.Add(cmbDIDO6);
            groupBox6.Controls.Add(label54);
            groupBox6.Controls.Add(cmbDIDO5);
            groupBox6.Controls.Add(label55);
            groupBox6.Controls.Add(cmbDIDO4);
            groupBox6.Controls.Add(label56);
            groupBox6.Controls.Add(cmbDIDO3);
            groupBox6.Controls.Add(label57);
            groupBox6.Controls.Add(cmbDIDO2);
            groupBox6.Controls.Add(label58);
            groupBox6.Controls.Add(cmbDIDO1);
            groupBox6.Controls.Add(label59);
            groupBox6.Location = new Point(389, 126);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(361, 404);
            groupBox6.TabIndex = 46;
            groupBox6.TabStop = false;
            groupBox6.Text = "Digital Output";
            // 
            // cmbDIDO8
            // 
            cmbDIDO8.FormattingEnabled = true;
            cmbDIDO8.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "CYCLIC ", "FIXED ON", "STATE CHANGE" });
            cmbDIDO8.Location = new Point(166, 289);
            cmbDIDO8.Name = "cmbDIDO8";
            cmbDIDO8.Size = new Size(185, 28);
            cmbDIDO8.TabIndex = 43;
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Location = new Point(8, 288);
            label52.Name = "label52";
            label52.Size = new Size(53, 20);
            label52.TabIndex = 42;
            label52.Text = "DO - 8";
            // 
            // cmbDIDO7
            // 
            cmbDIDO7.FormattingEnabled = true;
            cmbDIDO7.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "CYCLIC ", "FIXED ON", "STATE CHANGE" });
            cmbDIDO7.Location = new Point(166, 252);
            cmbDIDO7.Name = "cmbDIDO7";
            cmbDIDO7.Size = new Size(185, 28);
            cmbDIDO7.TabIndex = 41;
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.Location = new Point(8, 253);
            label53.Name = "label53";
            label53.Size = new Size(53, 20);
            label53.TabIndex = 40;
            label53.Text = "DO - 7";
            // 
            // cmbDIDO6
            // 
            cmbDIDO6.FormattingEnabled = true;
            cmbDIDO6.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "CYCLIC ", "FIXED ON", "STATE CHANGE" });
            cmbDIDO6.Location = new Point(166, 215);
            cmbDIDO6.Name = "cmbDIDO6";
            cmbDIDO6.Size = new Size(185, 28);
            cmbDIDO6.TabIndex = 39;
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.Location = new Point(8, 218);
            label54.Name = "label54";
            label54.Size = new Size(53, 20);
            label54.TabIndex = 38;
            label54.Text = "DO - 6";
            // 
            // cmbDIDO5
            // 
            cmbDIDO5.FormattingEnabled = true;
            cmbDIDO5.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "CYCLIC ", "FIXED ON", "STATE CHANGE" });
            cmbDIDO5.Location = new Point(166, 178);
            cmbDIDO5.Name = "cmbDIDO5";
            cmbDIDO5.Size = new Size(185, 28);
            cmbDIDO5.TabIndex = 37;
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.Location = new Point(8, 179);
            label55.Name = "label55";
            label55.Size = new Size(53, 20);
            label55.TabIndex = 36;
            label55.Text = "DO - 5";
            // 
            // cmbDIDO4
            // 
            cmbDIDO4.FormattingEnabled = true;
            cmbDIDO4.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "CYCLIC ", "FIXED ON", "STATE CHANGE" });
            cmbDIDO4.Location = new Point(166, 141);
            cmbDIDO4.Name = "cmbDIDO4";
            cmbDIDO4.Size = new Size(185, 28);
            cmbDIDO4.TabIndex = 35;
            // 
            // label56
            // 
            label56.AutoSize = true;
            label56.Location = new Point(6, 142);
            label56.Name = "label56";
            label56.Size = new Size(53, 20);
            label56.TabIndex = 34;
            label56.Text = "DO - 4";
            // 
            // cmbDIDO3
            // 
            cmbDIDO3.FormattingEnabled = true;
            cmbDIDO3.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "CYCLIC ", "FIXED ON", "STATE CHANGE" });
            cmbDIDO3.Location = new Point(166, 104);
            cmbDIDO3.Name = "cmbDIDO3";
            cmbDIDO3.Size = new Size(185, 28);
            cmbDIDO3.TabIndex = 33;
            // 
            // label57
            // 
            label57.AutoSize = true;
            label57.Location = new Point(6, 107);
            label57.Name = "label57";
            label57.Size = new Size(53, 20);
            label57.TabIndex = 32;
            label57.Text = "DO - 3";
            // 
            // cmbDIDO2
            // 
            cmbDIDO2.FormattingEnabled = true;
            cmbDIDO2.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "CYCLIC ", "FIXED ON", "STATE CHANGE" });
            cmbDIDO2.Location = new Point(166, 67);
            cmbDIDO2.Name = "cmbDIDO2";
            cmbDIDO2.Size = new Size(185, 28);
            cmbDIDO2.TabIndex = 31;
            // 
            // label58
            // 
            label58.AutoSize = true;
            label58.Location = new Point(6, 72);
            label58.Name = "label58";
            label58.Size = new Size(53, 20);
            label58.TabIndex = 30;
            label58.Text = "DO - 2";
            // 
            // cmbDIDO1
            // 
            cmbDIDO1.FormattingEnabled = true;
            cmbDIDO1.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "CYCLIC ", "FIXED ON", "STATE CHANGE" });
            cmbDIDO1.Location = new Point(166, 30);
            cmbDIDO1.Name = "cmbDIDO1";
            cmbDIDO1.Size = new Size(185, 28);
            cmbDIDO1.TabIndex = 29;
            // 
            // label59
            // 
            label59.AutoSize = true;
            label59.Location = new Point(6, 37);
            label59.Name = "label59";
            label59.Size = new Size(53, 20);
            label59.TabIndex = 28;
            label59.Text = "DO - 1";
            // 
            // cmbDISelectChannel
            // 
            cmbDISelectChannel.BackColor = SystemColors.HighlightText;
            cmbDISelectChannel.Cursor = Cursors.Hand;
            cmbDISelectChannel.FlatStyle = FlatStyle.Popup;
            cmbDISelectChannel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbDISelectChannel.FormattingEnabled = true;
            cmbDISelectChannel.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDISelectChannel.Location = new Point(491, 79);
            cmbDISelectChannel.Name = "cmbDISelectChannel";
            cmbDISelectChannel.Size = new Size(224, 28);
            cmbDISelectChannel.TabIndex = 44;
            // 
            // label68
            // 
            label68.AutoSize = true;
            label68.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label68.Location = new Point(362, 82);
            label68.Name = "label68";
            label68.Size = new Size(110, 20);
            label68.TabIndex = 43;
            label68.Text = "Select Channel";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(cmbDIReportDt);
            groupBox8.Controls.Add(label132);
            groupBox8.Controls.Add(txtDISMSRepeatSec);
            groupBox8.Controls.Add(label69);
            groupBox8.Controls.Add(chkDIDataReport);
            groupBox8.Controls.Add(label102);
            groupBox8.Controls.Add(txtDISmsRepeatTime);
            groupBox8.Controls.Add(label103);
            groupBox8.Controls.Add(txtDIAlarmVerifySec);
            groupBox8.Controls.Add(label104);
            groupBox8.Controls.Add(cmbDIAlarm);
            groupBox8.Controls.Add(cmbDIType);
            groupBox8.Controls.Add(txtDIUnit);
            groupBox8.Controls.Add(txtDIName);
            groupBox8.Controls.Add(label105);
            groupBox8.Controls.Add(label106);
            groupBox8.Controls.Add(label107);
            groupBox8.Controls.Add(label108);
            groupBox8.Location = new Point(14, 126);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(361, 404);
            groupBox8.TabIndex = 42;
            groupBox8.TabStop = false;
            groupBox8.Text = "Channel Setup";
            // 
            // cmbDIReportDt
            // 
            cmbDIReportDt.FormattingEnabled = true;
            cmbDIReportDt.Items.AddRange(new object[] { "Decimal", "Hex", "Bin" });
            cmbDIReportDt.Location = new Point(164, 154);
            cmbDIReportDt.Name = "cmbDIReportDt";
            cmbDIReportDt.Size = new Size(185, 28);
            cmbDIReportDt.TabIndex = 31;
            // 
            // label132
            // 
            label132.AutoSize = true;
            label132.Location = new Point(14, 161);
            label132.Name = "label132";
            label132.Size = new Size(95, 20);
            label132.TabIndex = 30;
            label132.Text = "DI Report DT";
            // 
            // txtDISMSRepeatSec
            // 
            txtDISMSRepeatSec.BorderStyle = BorderStyle.FixedSingle;
            txtDISMSRepeatSec.Location = new Point(165, 279);
            txtDISMSRepeatSec.MaxLength = 10;
            txtDISMSRepeatSec.Name = "txtDISMSRepeatSec";
            txtDISMSRepeatSec.Size = new Size(185, 27);
            txtDISMSRepeatSec.TabIndex = 29;
            // 
            // label69
            // 
            label69.AutoSize = true;
            label69.Location = new Point(14, 283);
            label69.MaximumSize = new Size(164, 60);
            label69.Name = "label69";
            label69.Size = new Size(142, 20);
            label69.TabIndex = 28;
            label69.Text = "SMS Repeat Second";
            // 
            // chkDIDataReport
            // 
            chkDIDataReport.AutoSize = true;
            chkDIDataReport.Location = new Point(164, 118);
            chkDIDataReport.Name = "chkDIDataReport";
            chkDIDataReport.Size = new Size(18, 17);
            chkDIDataReport.TabIndex = 24;
            chkDIDataReport.UseVisualStyleBackColor = true;
            // 
            // label102
            // 
            label102.AutoSize = true;
            label102.Location = new Point(14, 118);
            label102.Name = "label102";
            label102.Size = new Size(109, 20);
            label102.TabIndex = 23;
            label102.Text = "DI Data Report";
            // 
            // txtDISmsRepeatTime
            // 
            txtDISmsRepeatTime.BorderStyle = BorderStyle.FixedSingle;
            txtDISmsRepeatTime.Location = new Point(165, 239);
            txtDISmsRepeatTime.MaxLength = 10;
            txtDISmsRepeatTime.Name = "txtDISmsRepeatTime";
            txtDISmsRepeatTime.Size = new Size(185, 27);
            txtDISmsRepeatTime.TabIndex = 22;
            // 
            // label103
            // 
            label103.AutoSize = true;
            label103.Location = new Point(15, 245);
            label103.Name = "label103";
            label103.Size = new Size(126, 20);
            label103.TabIndex = 21;
            label103.Text = "SMS Repeat Time";
            // 
            // txtDIAlarmVerifySec
            // 
            txtDIAlarmVerifySec.BorderStyle = BorderStyle.FixedSingle;
            txtDIAlarmVerifySec.Location = new Point(164, 199);
            txtDIAlarmVerifySec.MaxLength = 10;
            txtDIAlarmVerifySec.Name = "txtDIAlarmVerifySec";
            txtDIAlarmVerifySec.Size = new Size(185, 27);
            txtDIAlarmVerifySec.TabIndex = 20;
            // 
            // label104
            // 
            label104.AutoSize = true;
            label104.Location = new Point(14, 204);
            label104.MaximumSize = new Size(150, 0);
            label104.Name = "label104";
            label104.Size = new Size(117, 20);
            label104.TabIndex = 19;
            label104.Text = "Alarm Verify Sec";
            // 
            // cmbDIAlarm
            // 
            cmbDIAlarm.FormattingEnabled = true;
            cmbDIAlarm.Items.AddRange(new object[] { "AQUIRE", "AQUIRE & ALARM" });
            cmbDIAlarm.Location = new Point(164, 360);
            cmbDIAlarm.Name = "cmbDIAlarm";
            cmbDIAlarm.Size = new Size(185, 28);
            cmbDIAlarm.TabIndex = 18;
            // 
            // cmbDIType
            // 
            cmbDIType.FormattingEnabled = true;
            cmbDIType.Items.AddRange(new object[] { "Ignore - 0", "Activate - 1" });
            cmbDIType.Location = new Point(164, 319);
            cmbDIType.Name = "cmbDIType";
            cmbDIType.Size = new Size(185, 28);
            cmbDIType.TabIndex = 17;
            // 
            // txtDIUnit
            // 
            txtDIUnit.BorderStyle = BorderStyle.FixedSingle;
            txtDIUnit.Location = new Point(164, 78);
            txtDIUnit.MaxLength = 10;
            txtDIUnit.Name = "txtDIUnit";
            txtDIUnit.Size = new Size(185, 27);
            txtDIUnit.TabIndex = 12;
            // 
            // txtDIName
            // 
            txtDIName.BorderStyle = BorderStyle.FixedSingle;
            txtDIName.Location = new Point(164, 38);
            txtDIName.MaxLength = 10;
            txtDIName.Name = "txtDIName";
            txtDIName.Size = new Size(185, 27);
            txtDIName.TabIndex = 11;
            // 
            // label105
            // 
            label105.AutoSize = true;
            label105.Location = new Point(14, 40);
            label105.Name = "label105";
            label105.Size = new Size(49, 20);
            label105.TabIndex = 1;
            label105.Text = "Name";
            // 
            // label106
            // 
            label106.AutoSize = true;
            label106.Location = new Point(14, 363);
            label106.Name = "label106";
            label106.Size = new Size(68, 20);
            label106.TabIndex = 10;
            label106.Text = "DI Alarm";
            // 
            // label107
            // 
            label107.AutoSize = true;
            label107.Location = new Point(14, 79);
            label107.Name = "label107";
            label107.Size = new Size(36, 20);
            label107.TabIndex = 2;
            label107.Text = "Unit";
            // 
            // label108
            // 
            label108.AutoSize = true;
            label108.Location = new Point(14, 322);
            label108.Name = "label108";
            label108.Size = new Size(59, 20);
            label108.TabIndex = 9;
            label108.Text = "DI Type";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Segoe UI", 13.8F, (FontStyle)(FontStyle.Bold) | (FontStyle.Underline), GraphicsUnit.Point);
            label41.Location = new Point(498, 14);
            label41.Name = "label41";
            label41.Size = new Size(132, 31);
            label41.TabIndex = 1;
            label41.Text = "DI Settings";
            // 
            // pnlGeneralSettings
            // 
            pnlGeneralSettings.Controls.Add(btnGeneralWriteMemory);
            pnlGeneralSettings.Controls.Add(btnGeneralReadMemory);
            pnlGeneralSettings.Controls.Add(groupBox13);
            pnlGeneralSettings.Controls.Add(label2);
            pnlGeneralSettings.Location = new Point(321, 9);
            pnlGeneralSettings.Name = "pnlGeneralSettings";
            pnlGeneralSettings.Size = new Size(1133, 822);
            pnlGeneralSettings.TabIndex = 1;
            pnlGeneralSettings.Visible = false;
            // 
            // btnGeneralWriteMemory
            // 
            btnGeneralWriteMemory.BackColor = Color.Red;
            btnGeneralWriteMemory.Cursor = Cursors.Hand;
            btnGeneralWriteMemory.ForeColor = Color.White;
            btnGeneralWriteMemory.Location = new Point(604, 690);
            btnGeneralWriteMemory.Name = "btnGeneralWriteMemory";
            btnGeneralWriteMemory.Size = new Size(172, 42);
            btnGeneralWriteMemory.TabIndex = 59;
            btnGeneralWriteMemory.Text = "Write Memory";
            btnGeneralWriteMemory.UseVisualStyleBackColor = false;
            btnGeneralWriteMemory.Click += (this.btnGeneralWriteMemory_Click);
            // 
            // btnGeneralReadMemory
            // 
            btnGeneralReadMemory.BackColor = Color.DarkKhaki;
            btnGeneralReadMemory.Cursor = Cursors.Hand;
            btnGeneralReadMemory.ForeColor = Color.White;
            btnGeneralReadMemory.Location = new Point(332, 690);
            btnGeneralReadMemory.Name = "btnGeneralReadMemory";
            btnGeneralReadMemory.Size = new Size(190, 42);
            btnGeneralReadMemory.TabIndex = 58;
            btnGeneralReadMemory.Text = "Read Memory";
            btnGeneralReadMemory.UseVisualStyleBackColor = false;
            btnGeneralReadMemory.Click += (this.btnGeneralReadMemory_Click);
            // 
            // groupBox13
            // 
            groupBox13.Controls.Add(txtIemiNo);
            groupBox13.Controls.Add(chkGeneralRtcDebug);
            groupBox13.Controls.Add(label136);
            groupBox13.Controls.Add(chkGeneralModbusDebug);
            groupBox13.Controls.Add(label135);
            groupBox13.Controls.Add(label111);
            groupBox13.Controls.Add(txtGeneralSetTime);
            groupBox13.Controls.Add(dtGeneralSetDate);
            groupBox13.Controls.Add(label61);
            groupBox13.Controls.Add(label60);
            groupBox13.Controls.Add(txtGeneralUserId);
            groupBox13.Controls.Add(txtGeneralDataLogSec);
            groupBox13.Controls.Add(label63);
            groupBox13.Controls.Add(txtGeneralSmsLogSec);
            groupBox13.Controls.Add(label66);
            groupBox13.Controls.Add(label109);
            groupBox13.Controls.Add(label110);
            groupBox13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox13.Location = new Point(273, 93);
            groupBox13.Name = "groupBox13";
            groupBox13.Size = new Size(533, 427);
            groupBox13.TabIndex = 57;
            groupBox13.TabStop = false;
            groupBox13.Text = "Settings";
            // 
            // txtIemiNo
            // 
            txtIemiNo.BorderStyle = BorderStyle.FixedSingle;
            txtIemiNo.Location = new Point(324, 84);
            txtIemiNo.MaxLength = 15;
            txtIemiNo.Name = "txtIemiNo";
            txtIemiNo.ReadOnly = true;
            txtIemiNo.Size = new Size(188, 27);
            txtIemiNo.TabIndex = 45;
            // 
            // chkGeneralRtcDebug
            // 
            chkGeneralRtcDebug.AutoSize = true;
            chkGeneralRtcDebug.Location = new Point(325, 338);
            chkGeneralRtcDebug.Name = "chkGeneralRtcDebug";
            chkGeneralRtcDebug.Size = new Size(18, 17);
            chkGeneralRtcDebug.TabIndex = 44;
            chkGeneralRtcDebug.UseVisualStyleBackColor = true;
            // 
            // label136
            // 
            label136.AutoSize = true;
            label136.Location = new Point(15, 337);
            label136.MaximumSize = new Size(150, 0);
            label136.Name = "label136";
            label136.Size = new Size(82, 20);
            label136.TabIndex = 43;
            label136.Text = "Rtc Debug";
            // 
            // chkGeneralModbusDebug
            // 
            chkGeneralModbusDebug.AutoSize = true;
            chkGeneralModbusDebug.Location = new Point(325, 304);
            chkGeneralModbusDebug.Name = "chkGeneralModbusDebug";
            chkGeneralModbusDebug.Size = new Size(18, 17);
            chkGeneralModbusDebug.TabIndex = 42;
            chkGeneralModbusDebug.UseVisualStyleBackColor = true;
            // 
            // label135
            // 
            label135.AutoSize = true;
            label135.Location = new Point(15, 295);
            label135.MaximumSize = new Size(150, 0);
            label135.Name = "label135";
            label135.Size = new Size(116, 20);
            label135.TabIndex = 41;
            label135.Text = "Modbus Debug";
            // 
            // label111
            // 
            label111.AutoSize = true;
            label111.Location = new Point(450, 264);
            label111.MaximumSize = new Size(164, 60);
            label111.Name = "label111";
            label111.Size = new Size(63, 20);
            label111.TabIndex = 40;
            label111.Text = "HH:MM";
            // 
            // txtGeneralSetTime
            // 
            txtGeneralSetTime.BorderStyle = BorderStyle.FixedSingle;
            txtGeneralSetTime.Location = new Point(324, 260);
            txtGeneralSetTime.MaxLength = 5;
            txtGeneralSetTime.Name = "txtGeneralSetTime";
            txtGeneralSetTime.Size = new Size(114, 27);
            txtGeneralSetTime.TabIndex = 39;
            // 
            // dtGeneralSetDate
            // 
            dtGeneralSetDate.Location = new Point(325, 216);
            dtGeneralSetDate.Name = "dtGeneralSetDate";
            dtGeneralSetDate.Size = new Size(188, 27);
            dtGeneralSetDate.TabIndex = 38;
            // 
            // label61
            // 
            label61.AutoSize = true;
            label61.Location = new Point(15, 253);
            label61.MaximumSize = new Size(164, 60);
            label61.Name = "label61";
            label61.Size = new Size(70, 20);
            label61.TabIndex = 37;
            label61.Text = "Set Time";
            // 
            // label60
            // 
            label60.AutoSize = true;
            label60.Location = new Point(15, 211);
            label60.MaximumSize = new Size(164, 60);
            label60.Name = "label60";
            label60.Size = new Size(68, 20);
            label60.TabIndex = 36;
            label60.Text = "Set Date";
            // 
            // txtGeneralUserId
            // 
            txtGeneralUserId.BorderStyle = BorderStyle.FixedSingle;
            txtGeneralUserId.Location = new Point(324, 40);
            txtGeneralUserId.MaxLength = 10;
            txtGeneralUserId.Name = "txtGeneralUserId";
            txtGeneralUserId.Size = new Size(188, 27);
            txtGeneralUserId.TabIndex = 34;
            // 
            // txtGeneralDataLogSec
            // 
            txtGeneralDataLogSec.BorderStyle = BorderStyle.FixedSingle;
            txtGeneralDataLogSec.Location = new Point(324, 128);
            txtGeneralDataLogSec.MaxLength = 6;
            txtGeneralDataLogSec.Name = "txtGeneralDataLogSec";
            txtGeneralDataLogSec.Size = new Size(188, 27);
            txtGeneralDataLogSec.TabIndex = 31;
            // 
            // label63
            // 
            label63.AutoSize = true;
            label63.Location = new Point(14, 127);
            label63.MaximumSize = new Size(164, 60);
            label63.Name = "label63";
            label63.Size = new Size(99, 20);
            label63.TabIndex = 30;
            label63.Text = "Data Log Sec";
            // 
            // txtGeneralSmsLogSec
            // 
            txtGeneralSmsLogSec.BorderStyle = BorderStyle.FixedSingle;
            txtGeneralSmsLogSec.Location = new Point(324, 172);
            txtGeneralSmsLogSec.MaxLength = 6;
            txtGeneralSmsLogSec.Name = "txtGeneralSmsLogSec";
            txtGeneralSmsLogSec.Size = new Size(189, 27);
            txtGeneralSmsLogSec.TabIndex = 29;
            // 
            // label66
            // 
            label66.AutoSize = true;
            label66.Location = new Point(13, 169);
            label66.MaximumSize = new Size(164, 60);
            label66.Name = "label66";
            label66.Size = new Size(100, 20);
            label66.TabIndex = 28;
            label66.Text = "SMS Log Min";
            // 
            // label109
            // 
            label109.AutoSize = true;
            label109.Location = new Point(13, 85);
            label109.MaximumSize = new Size(150, 0);
            label109.Name = "label109";
            label109.Size = new Size(103, 20);
            label109.TabIndex = 19;
            label109.Text = "IEMI Number";
            // 
            // label110
            // 
            label110.AutoSize = true;
            label110.Location = new Point(15, 43);
            label110.Name = "label110";
            label110.Size = new Size(75, 20);
            label110.TabIndex = 28;
            label110.Text = "Device ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, (FontStyle)(FontStyle.Bold) | (FontStyle.Underline), GraphicsUnit.Point);
            label2.Location = new Point(463, 19);
            label2.Name = "label2";
            label2.Size = new Size(190, 31);
            label2.TabIndex = 35;
            label2.Text = "General Settings";
            // 
            // pnlStatus
            // 
            pnlStatus.Controls.Add(groupBox27);
            pnlStatus.Controls.Add(groupBox26);
            pnlStatus.Controls.Add(groupBox25);
            pnlStatus.Controls.Add(label164);
            pnlStatus.Location = new Point(321, 9);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(1133, 823);
            pnlStatus.TabIndex = 9;
            pnlStatus.Visible = false;
            // 
            // groupBox27
            // 
            groupBox27.Controls.Add(lblStatusPulseCounter8);
            groupBox27.Controls.Add(lblStatusPulseCounter7);
            groupBox27.Controls.Add(lblStatusPulseCounter6);
            groupBox27.Controls.Add(lblStatusPulseCounter5);
            groupBox27.Controls.Add(lblStatusPulseCounter4);
            groupBox27.Controls.Add(lblStatusPulseCounter3);
            groupBox27.Controls.Add(lblStatusPulseCounter2);
            groupBox27.Controls.Add(pbDigiIn8);
            groupBox27.Controls.Add(pbDigiIn7);
            groupBox27.Controls.Add(pbDigiIn6);
            groupBox27.Controls.Add(pbDigiIn5);
            groupBox27.Controls.Add(pbDigiIn4);
            groupBox27.Controls.Add(pbDigiIn3);
            groupBox27.Controls.Add(pbDigiIn2);
            groupBox27.Controls.Add(pbDigiIn1);
            groupBox27.Controls.Add(pbDigiOut8);
            groupBox27.Controls.Add(pbDigiOut7);
            groupBox27.Controls.Add(pbDigiOut6);
            groupBox27.Controls.Add(pbDigiOut5);
            groupBox27.Controls.Add(pbDigiOut4);
            groupBox27.Controls.Add(pbDigiOut3);
            groupBox27.Controls.Add(pbDigiOut2);
            groupBox27.Controls.Add(pbDigiOut1);
            groupBox27.Controls.Add(lblAna8);
            groupBox27.Controls.Add(lblAna7);
            groupBox27.Controls.Add(lblAna6);
            groupBox27.Controls.Add(lblAna5);
            groupBox27.Controls.Add(lblAna4);
            groupBox27.Controls.Add(lblAna3);
            groupBox27.Controls.Add(lblAna2);
            groupBox27.Controls.Add(lblAna1);
            groupBox27.Controls.Add(lblTot8);
            groupBox27.Controls.Add(lblTot7);
            groupBox27.Controls.Add(lblTot6);
            groupBox27.Controls.Add(lblTot5);
            groupBox27.Controls.Add(lblTot4);
            groupBox27.Controls.Add(lblTot3);
            groupBox27.Controls.Add(lblTot2);
            groupBox27.Controls.Add(label171);
            groupBox27.Controls.Add(lblStatusDatalogSec);
            groupBox27.Controls.Add(btnIOStatusRead);
            groupBox27.Controls.Add(label165);
            groupBox27.Controls.Add(label166);
            groupBox27.Controls.Add(label167);
            groupBox27.Controls.Add(label168);
            groupBox27.Controls.Add(label169);
            groupBox27.Controls.Add(label170);
            groupBox27.Controls.Add(lblTot1);
            groupBox27.Controls.Add(lblStatusPulseCounter1);
            groupBox27.Controls.Add(lblStatusSystemVolt);
            groupBox27.Location = new Point(652, 51);
            groupBox27.Name = "groupBox27";
            groupBox27.Size = new Size(471, 660);
            groupBox27.TabIndex = 5;
            groupBox27.TabStop = false;
            groupBox27.Text = "IO Status";
            // 
            // lblStatusPulseCounter8
            // 
            lblStatusPulseCounter8.AutoSize = true;
            lblStatusPulseCounter8.Location = new Point(429, 278);
            lblStatusPulseCounter8.Name = "lblStatusPulseCounter8";
            lblStatusPulseCounter8.Size = new Size(17, 20);
            lblStatusPulseCounter8.TabIndex = 66;
            lblStatusPulseCounter8.Text = "0";
            // 
            // lblStatusPulseCounter7
            // 
            lblStatusPulseCounter7.AutoSize = true;
            lblStatusPulseCounter7.Location = new Point(388, 278);
            lblStatusPulseCounter7.Name = "lblStatusPulseCounter7";
            lblStatusPulseCounter7.Size = new Size(17, 20);
            lblStatusPulseCounter7.TabIndex = 65;
            lblStatusPulseCounter7.Text = "0";
            // 
            // lblStatusPulseCounter6
            // 
            lblStatusPulseCounter6.AutoSize = true;
            lblStatusPulseCounter6.Location = new Point(346, 278);
            lblStatusPulseCounter6.Name = "lblStatusPulseCounter6";
            lblStatusPulseCounter6.Size = new Size(17, 20);
            lblStatusPulseCounter6.TabIndex = 64;
            lblStatusPulseCounter6.Text = "0";
            // 
            // lblStatusPulseCounter5
            // 
            lblStatusPulseCounter5.AutoSize = true;
            lblStatusPulseCounter5.Location = new Point(305, 278);
            lblStatusPulseCounter5.Name = "lblStatusPulseCounter5";
            lblStatusPulseCounter5.Size = new Size(17, 20);
            lblStatusPulseCounter5.TabIndex = 63;
            lblStatusPulseCounter5.Text = "0";
            // 
            // lblStatusPulseCounter4
            // 
            lblStatusPulseCounter4.AutoSize = true;
            lblStatusPulseCounter4.Location = new Point(264, 278);
            lblStatusPulseCounter4.Name = "lblStatusPulseCounter4";
            lblStatusPulseCounter4.Size = new Size(17, 20);
            lblStatusPulseCounter4.TabIndex = 62;
            lblStatusPulseCounter4.Text = "0";
            // 
            // lblStatusPulseCounter3
            // 
            lblStatusPulseCounter3.AutoSize = true;
            lblStatusPulseCounter3.Location = new Point(223, 278);
            lblStatusPulseCounter3.Name = "lblStatusPulseCounter3";
            lblStatusPulseCounter3.Size = new Size(17, 20);
            lblStatusPulseCounter3.TabIndex = 61;
            lblStatusPulseCounter3.Text = "0";
            // 
            // lblStatusPulseCounter2
            // 
            lblStatusPulseCounter2.AutoSize = true;
            lblStatusPulseCounter2.Location = new Point(181, 278);
            lblStatusPulseCounter2.Name = "lblStatusPulseCounter2";
            lblStatusPulseCounter2.Size = new Size(17, 20);
            lblStatusPulseCounter2.TabIndex = 60;
            lblStatusPulseCounter2.Text = "0";
            // 
            // pbDigiIn8
            // 
            pbDigiIn8.BackgroundImage = (Image)resources.GetObject("pbDigiIn8.BackgroundImage");
            pbDigiIn8.BackgroundImageLayout = ImageLayout.Stretch;
            pbDigiIn8.BorderStyle = BorderStyle.Fixed3D;
            pbDigiIn8.Location = new Point(337, 74);
            pbDigiIn8.Name = "pbDigiIn8";
            pbDigiIn8.Size = new Size(24, 25);
            pbDigiIn8.TabIndex = 59;
            pbDigiIn8.TabStop = false;
            // 
            // pbDigiIn7
            // 
            pbDigiIn7.BackgroundImage = (Image)resources.GetObject("pbDigiIn7.BackgroundImage");
            pbDigiIn7.BackgroundImageLayout = ImageLayout.Stretch;
            pbDigiIn7.BorderStyle = BorderStyle.Fixed3D;
            pbDigiIn7.Location = new Point(309, 74);
            pbDigiIn7.Name = "pbDigiIn7";
            pbDigiIn7.Size = new Size(24, 25);
            pbDigiIn7.TabIndex = 58;
            pbDigiIn7.TabStop = false;
            // 
            // pbDigiIn6
            // 
            pbDigiIn6.BackgroundImage = (Image)resources.GetObject("pbDigiIn6.BackgroundImage");
            pbDigiIn6.BackgroundImageLayout = ImageLayout.Stretch;
            pbDigiIn6.BorderStyle = BorderStyle.Fixed3D;
            pbDigiIn6.Location = new Point(282, 74);
            pbDigiIn6.Name = "pbDigiIn6";
            pbDigiIn6.Size = new Size(24, 25);
            pbDigiIn6.TabIndex = 57;
            pbDigiIn6.TabStop = false;
            // 
            // pbDigiIn5
            // 
            pbDigiIn5.BackgroundImage = (Image)resources.GetObject("pbDigiIn5.BackgroundImage");
            pbDigiIn5.BackgroundImageLayout = ImageLayout.Stretch;
            pbDigiIn5.BorderStyle = BorderStyle.Fixed3D;
            pbDigiIn5.Location = new Point(254, 74);
            pbDigiIn5.Name = "pbDigiIn5";
            pbDigiIn5.Size = new Size(24, 25);
            pbDigiIn5.TabIndex = 56;
            pbDigiIn5.TabStop = false;
            // 
            // pbDigiIn4
            // 
            pbDigiIn4.BackgroundImage = (Image)resources.GetObject("pbDigiIn4.BackgroundImage");
            pbDigiIn4.BackgroundImageLayout = ImageLayout.Stretch;
            pbDigiIn4.BorderStyle = BorderStyle.Fixed3D;
            pbDigiIn4.Location = new Point(228, 74);
            pbDigiIn4.Name = "pbDigiIn4";
            pbDigiIn4.Size = new Size(24, 25);
            pbDigiIn4.TabIndex = 55;
            pbDigiIn4.TabStop = false;
            // 
            // pbDigiIn3
            // 
            pbDigiIn3.BackgroundImage = (Image)resources.GetObject("pbDigiIn3.BackgroundImage");
            pbDigiIn3.BackgroundImageLayout = ImageLayout.Stretch;
            pbDigiIn3.BorderStyle = BorderStyle.Fixed3D;
            pbDigiIn3.Location = new Point(200, 74);
            pbDigiIn3.Name = "pbDigiIn3";
            pbDigiIn3.Size = new Size(24, 25);
            pbDigiIn3.TabIndex = 54;
            pbDigiIn3.TabStop = false;
            // 
            // pbDigiIn2
            // 
            pbDigiIn2.BackgroundImage = (Image)resources.GetObject("pbDigiIn2.BackgroundImage");
            pbDigiIn2.BackgroundImageLayout = ImageLayout.Stretch;
            pbDigiIn2.BorderStyle = BorderStyle.Fixed3D;
            pbDigiIn2.Location = new Point(173, 74);
            pbDigiIn2.Name = "pbDigiIn2";
            pbDigiIn2.Size = new Size(24, 25);
            pbDigiIn2.TabIndex = 53;
            pbDigiIn2.TabStop = false;
            // 
            // pbDigiIn1
            // 
            pbDigiIn1.BackgroundImage = (Image)resources.GetObject("pbDigiIn1.BackgroundImage");
            pbDigiIn1.BackgroundImageLayout = ImageLayout.Stretch;
            pbDigiIn1.BorderStyle = BorderStyle.Fixed3D;
            pbDigiIn1.Location = new Point(145, 74);
            pbDigiIn1.Name = "pbDigiIn1";
            pbDigiIn1.Size = new Size(24, 25);
            pbDigiIn1.TabIndex = 52;
            pbDigiIn1.TabStop = false;
            // 
            // pbDigiOut8
            // 
            pbDigiOut8.BackgroundImage = (Image)resources.GetObject("pbDigiOut8.BackgroundImage");
            pbDigiOut8.BackgroundImageLayout = ImageLayout.Stretch;
            pbDigiOut8.BorderStyle = BorderStyle.Fixed3D;
            pbDigiOut8.Location = new Point(337, 127);
            pbDigiOut8.Name = "pbDigiOut8";
            pbDigiOut8.Size = new Size(24, 25);
            pbDigiOut8.TabIndex = 51;
            pbDigiOut8.TabStop = false;
            // 
            // pbDigiOut7
            // 
            pbDigiOut7.BackgroundImage = (Image)resources.GetObject("pbDigiOut7.BackgroundImage");
            pbDigiOut7.BackgroundImageLayout = ImageLayout.Stretch;
            pbDigiOut7.BorderStyle = BorderStyle.Fixed3D;
            pbDigiOut7.Location = new Point(309, 127);
            pbDigiOut7.Name = "pbDigiOut7";
            pbDigiOut7.Size = new Size(24, 25);
            pbDigiOut7.TabIndex = 50;
            pbDigiOut7.TabStop = false;
            // 
            // pbDigiOut6
            // 
            pbDigiOut6.BackgroundImage = (Image)resources.GetObject("pbDigiOut6.BackgroundImage");
            pbDigiOut6.BackgroundImageLayout = ImageLayout.Stretch;
            pbDigiOut6.BorderStyle = BorderStyle.Fixed3D;
            pbDigiOut6.Location = new Point(282, 127);
            pbDigiOut6.Name = "pbDigiOut6";
            pbDigiOut6.Size = new Size(24, 25);
            pbDigiOut6.TabIndex = 49;
            pbDigiOut6.TabStop = false;
            // 
            // pbDigiOut5
            // 
            pbDigiOut5.BackgroundImage = (Image)resources.GetObject("pbDigiOut5.BackgroundImage");
            pbDigiOut5.BackgroundImageLayout = ImageLayout.Stretch;
            pbDigiOut5.BorderStyle = BorderStyle.Fixed3D;
            pbDigiOut5.Location = new Point(254, 127);
            pbDigiOut5.Name = "pbDigiOut5";
            pbDigiOut5.Size = new Size(24, 25);
            pbDigiOut5.TabIndex = 48;
            pbDigiOut5.TabStop = false;
            // 
            // pbDigiOut4
            // 
            pbDigiOut4.BackgroundImage = (Image)resources.GetObject("pbDigiOut4.BackgroundImage");
            pbDigiOut4.BackgroundImageLayout = ImageLayout.Stretch;
            pbDigiOut4.BorderStyle = BorderStyle.Fixed3D;
            pbDigiOut4.Location = new Point(228, 127);
            pbDigiOut4.Name = "pbDigiOut4";
            pbDigiOut4.Size = new Size(24, 25);
            pbDigiOut4.TabIndex = 47;
            pbDigiOut4.TabStop = false;
            // 
            // pbDigiOut3
            // 
            pbDigiOut3.BackgroundImage = (Image)resources.GetObject("pbDigiOut3.BackgroundImage");
            pbDigiOut3.BackgroundImageLayout = ImageLayout.Stretch;
            pbDigiOut3.BorderStyle = BorderStyle.Fixed3D;
            pbDigiOut3.Location = new Point(200, 127);
            pbDigiOut3.Name = "pbDigiOut3";
            pbDigiOut3.Size = new Size(24, 25);
            pbDigiOut3.TabIndex = 46;
            pbDigiOut3.TabStop = false;
            // 
            // pbDigiOut2
            // 
            pbDigiOut2.BackgroundImage = (Image)resources.GetObject("pbDigiOut2.BackgroundImage");
            pbDigiOut2.BackgroundImageLayout = ImageLayout.Stretch;
            pbDigiOut2.BorderStyle = BorderStyle.Fixed3D;
            pbDigiOut2.Location = new Point(173, 127);
            pbDigiOut2.Name = "pbDigiOut2";
            pbDigiOut2.Size = new Size(24, 25);
            pbDigiOut2.TabIndex = 45;
            pbDigiOut2.TabStop = false;
            // 
            // pbDigiOut1
            // 
            pbDigiOut1.BackgroundImage = (Image)resources.GetObject("pbDigiOut1.BackgroundImage");
            pbDigiOut1.BackgroundImageLayout = ImageLayout.Stretch;
            pbDigiOut1.BorderStyle = BorderStyle.Fixed3D;
            pbDigiOut1.Location = new Point(145, 127);
            pbDigiOut1.Name = "pbDigiOut1";
            pbDigiOut1.Size = new Size(24, 25);
            pbDigiOut1.TabIndex = 44;
            pbDigiOut1.TabStop = false;
            // 
            // lblAna8
            // 
            lblAna8.AutoSize = true;
            lblAna8.Location = new Point(431, 178);
            lblAna8.Name = "lblAna8";
            lblAna8.Size = new Size(17, 20);
            lblAna8.TabIndex = 43;
            lblAna8.Text = "0";
            // 
            // lblAna7
            // 
            lblAna7.AutoSize = true;
            lblAna7.Location = new Point(390, 178);
            lblAna7.Name = "lblAna7";
            lblAna7.Size = new Size(17, 20);
            lblAna7.TabIndex = 42;
            lblAna7.Text = "0";
            // 
            // lblAna6
            // 
            lblAna6.AutoSize = true;
            lblAna6.Location = new Point(348, 178);
            lblAna6.Name = "lblAna6";
            lblAna6.Size = new Size(17, 20);
            lblAna6.TabIndex = 41;
            lblAna6.Text = "0";
            // 
            // lblAna5
            // 
            lblAna5.AutoSize = true;
            lblAna5.Location = new Point(307, 178);
            lblAna5.Name = "lblAna5";
            lblAna5.Size = new Size(17, 20);
            lblAna5.TabIndex = 40;
            lblAna5.Text = "0";
            // 
            // lblAna4
            // 
            lblAna4.AutoSize = true;
            lblAna4.Location = new Point(266, 178);
            lblAna4.Name = "lblAna4";
            lblAna4.Size = new Size(17, 20);
            lblAna4.TabIndex = 39;
            lblAna4.Text = "0";
            // 
            // lblAna3
            // 
            lblAna3.AutoSize = true;
            lblAna3.Location = new Point(225, 178);
            lblAna3.Name = "lblAna3";
            lblAna3.Size = new Size(17, 20);
            lblAna3.TabIndex = 38;
            lblAna3.Text = "0";
            // 
            // lblAna2
            // 
            lblAna2.AutoSize = true;
            lblAna2.Location = new Point(183, 178);
            lblAna2.Name = "lblAna2";
            lblAna2.Size = new Size(17, 20);
            lblAna2.TabIndex = 37;
            lblAna2.Text = "0";
            // 
            // lblAna1
            // 
            lblAna1.AutoSize = true;
            lblAna1.Location = new Point(142, 178);
            lblAna1.Name = "lblAna1";
            lblAna1.Size = new Size(17, 20);
            lblAna1.TabIndex = 36;
            lblAna1.Text = "0";
            // 
            // lblTot8
            // 
            lblTot8.AutoSize = true;
            lblTot8.Location = new Point(430, 228);
            lblTot8.Name = "lblTot8";
            lblTot8.Size = new Size(17, 20);
            lblTot8.TabIndex = 35;
            lblTot8.Text = "0";
            // 
            // lblTot7
            // 
            lblTot7.AutoSize = true;
            lblTot7.Location = new Point(389, 228);
            lblTot7.Name = "lblTot7";
            lblTot7.Size = new Size(17, 20);
            lblTot7.TabIndex = 34;
            lblTot7.Text = "0";
            // 
            // lblTot6
            // 
            lblTot6.AutoSize = true;
            lblTot6.Location = new Point(347, 228);
            lblTot6.Name = "lblTot6";
            lblTot6.Size = new Size(17, 20);
            lblTot6.TabIndex = 33;
            lblTot6.Text = "0";
            // 
            // lblTot5
            // 
            lblTot5.AutoSize = true;
            lblTot5.Location = new Point(306, 228);
            lblTot5.Name = "lblTot5";
            lblTot5.Size = new Size(17, 20);
            lblTot5.TabIndex = 32;
            lblTot5.Text = "0";
            // 
            // lblTot4
            // 
            lblTot4.AutoSize = true;
            lblTot4.Location = new Point(265, 228);
            lblTot4.Name = "lblTot4";
            lblTot4.Size = new Size(17, 20);
            lblTot4.TabIndex = 31;
            lblTot4.Text = "0";
            // 
            // lblTot3
            // 
            lblTot3.AutoSize = true;
            lblTot3.Location = new Point(224, 228);
            lblTot3.Name = "lblTot3";
            lblTot3.Size = new Size(17, 20);
            lblTot3.TabIndex = 30;
            lblTot3.Text = "0";
            // 
            // lblTot2
            // 
            lblTot2.AutoSize = true;
            lblTot2.Location = new Point(182, 228);
            lblTot2.Name = "lblTot2";
            lblTot2.Size = new Size(17, 20);
            lblTot2.TabIndex = 29;
            lblTot2.Text = "0";
            // 
            // label171
            // 
            label171.AutoSize = true;
            label171.Location = new Point(19, 328);
            label171.Name = "label171";
            label171.Size = new Size(93, 20);
            label171.TabIndex = 28;
            label171.Text = "Datalog Sec:";
            // 
            // lblStatusDatalogSec
            // 
            lblStatusDatalogSec.AutoSize = true;
            lblStatusDatalogSec.Location = new Point(141, 328);
            lblStatusDatalogSec.Name = "lblStatusDatalogSec";
            lblStatusDatalogSec.Size = new Size(17, 20);
            lblStatusDatalogSec.TabIndex = 27;
            lblStatusDatalogSec.Text = "0";
            // 
            // btnIOStatusRead
            // 
            btnIOStatusRead.Location = new Point(188, 612);
            btnIOStatusRead.Name = "btnIOStatusRead";
            btnIOStatusRead.Size = new Size(94, 29);
            btnIOStatusRead.TabIndex = 26;
            btnIOStatusRead.Text = "Read";
            btnIOStatusRead.UseVisualStyleBackColor = true;
            btnIOStatusRead.Click += (this.btnIOStatusRead_Click);
            // 
            // label165
            // 
            label165.AutoSize = true;
            label165.Location = new Point(19, 78);
            label165.Name = "label165";
            label165.Size = new Size(95, 20);
            label165.TabIndex = 22;
            label165.Text = "Digital Input:";
            // 
            // label166
            // 
            label166.AutoSize = true;
            label166.Location = new Point(19, 128);
            label166.Name = "label166";
            label166.Size = new Size(107, 20);
            label166.TabIndex = 21;
            label166.Text = "Digital Output:";
            // 
            // label167
            // 
            label167.AutoSize = true;
            label167.Location = new Point(19, 178);
            label167.Name = "label167";
            label167.Size = new Size(98, 20);
            label167.TabIndex = 20;
            label167.Text = "Analog Input:";
            // 
            // label168
            // 
            label168.AutoSize = true;
            label168.Location = new Point(19, 228);
            label168.Name = "label168";
            label168.Size = new Size(69, 20);
            label168.TabIndex = 19;
            label168.Text = "Totalizer:";
            // 
            // label169
            // 
            label169.AutoSize = true;
            label169.Location = new Point(19, 278);
            label169.Name = "label169";
            label169.Size = new Size(102, 20);
            label169.TabIndex = 18;
            label169.Text = "Pulse Counter:";
            // 
            // label170
            // 
            label170.AutoSize = true;
            label170.Location = new Point(19, 32);
            label170.Name = "label170";
            label170.Size = new Size(89, 20);
            label170.TabIndex = 17;
            label170.Text = "System Volt:";
            // 
            // lblTot1
            // 
            lblTot1.AutoSize = true;
            lblTot1.Location = new Point(141, 228);
            lblTot1.Name = "lblTot1";
            lblTot1.Size = new Size(17, 20);
            lblTot1.TabIndex = 12;
            lblTot1.Text = "0";
            // 
            // lblStatusPulseCounter1
            // 
            lblStatusPulseCounter1.AutoSize = true;
            lblStatusPulseCounter1.Location = new Point(141, 278);
            lblStatusPulseCounter1.Name = "lblStatusPulseCounter1";
            lblStatusPulseCounter1.Size = new Size(17, 20);
            lblStatusPulseCounter1.TabIndex = 9;
            lblStatusPulseCounter1.Text = "0";
            // 
            // lblStatusSystemVolt
            // 
            lblStatusSystemVolt.AutoSize = true;
            lblStatusSystemVolt.Location = new Point(141, 32);
            lblStatusSystemVolt.Name = "lblStatusSystemVolt";
            lblStatusSystemVolt.Size = new Size(17, 20);
            lblStatusSystemVolt.TabIndex = 8;
            lblStatusSystemVolt.Text = "0";
            // 
            // groupBox26
            // 
            groupBox26.Controls.Add(btnStatusGSMRead);
            groupBox26.Controls.Add(lblSignal2);
            groupBox26.Controls.Add(lblSignal3);
            groupBox26.Controls.Add(lblSignal4);
            groupBox26.Controls.Add(lblSignal5);
            groupBox26.Controls.Add(lblSignal1);
            groupBox26.Controls.Add(lblStatusProvider);
            groupBox26.Controls.Add(lblStatusModule);
            groupBox26.Controls.Add(lblStatusDecimal);
            groupBox26.Controls.Add(label172);
            groupBox26.Controls.Add(label173);
            groupBox26.Controls.Add(label174);
            groupBox26.Controls.Add(label175);
            groupBox26.Controls.Add(label176);
            groupBox26.Controls.Add(lblStatusTime);
            groupBox26.Controls.Add(lblStatusGprs);
            groupBox26.Controls.Add(lblStatusDate);
            groupBox26.Controls.Add(lblStatusIMEI);
            groupBox26.Controls.Add(lblStatusProtocol);
            groupBox26.Controls.Add(lblStatusSim);
            groupBox26.Controls.Add(label177);
            groupBox26.Location = new Point(313, 52);
            groupBox26.Name = "groupBox26";
            groupBox26.Size = new Size(333, 660);
            groupBox26.TabIndex = 4;
            groupBox26.TabStop = false;
            groupBox26.Text = "GSM Status";
            // 
            // btnStatusGSMRead
            // 
            btnStatusGSMRead.Location = new Point(115, 614);
            btnStatusGSMRead.Name = "btnStatusGSMRead";
            btnStatusGSMRead.Size = new Size(94, 29);
            btnStatusGSMRead.TabIndex = 22;
            btnStatusGSMRead.Text = "Read";
            btnStatusGSMRead.UseVisualStyleBackColor = true;
            btnStatusGSMRead.Click += (this.btnStatusGSMRead_Click);
            // 
            // lblSignal2
            // 
            lblSignal2.BackColor = Color.White;
            lblSignal2.BorderStyle = BorderStyle.FixedSingle;
            lblSignal2.Location = new Point(41, 103);
            lblSignal2.Name = "lblSignal2";
            lblSignal2.Size = new Size(10, 20);
            lblSignal2.TabIndex = 21;
            // 
            // lblSignal3
            // 
            lblSignal3.BackColor = Color.White;
            lblSignal3.BorderStyle = BorderStyle.FixedSingle;
            lblSignal3.Location = new Point(57, 96);
            lblSignal3.Name = "lblSignal3";
            lblSignal3.Size = new Size(10, 27);
            lblSignal3.TabIndex = 20;
            // 
            // lblSignal4
            // 
            lblSignal4.BackColor = Color.White;
            lblSignal4.BorderStyle = BorderStyle.FixedSingle;
            lblSignal4.Location = new Point(73, 89);
            lblSignal4.Name = "lblSignal4";
            lblSignal4.Size = new Size(10, 34);
            lblSignal4.TabIndex = 19;
            // 
            // lblSignal5
            // 
            lblSignal5.BackColor = Color.White;
            lblSignal5.BorderStyle = BorderStyle.FixedSingle;
            lblSignal5.Location = new Point(89, 82);
            lblSignal5.Name = "lblSignal5";
            lblSignal5.Size = new Size(10, 41);
            lblSignal5.TabIndex = 18;
            // 
            // lblSignal1
            // 
            lblSignal1.BackColor = Color.White;
            lblSignal1.BorderStyle = BorderStyle.FixedSingle;
            lblSignal1.Location = new Point(25, 110);
            lblSignal1.Name = "lblSignal1";
            lblSignal1.Size = new Size(10, 13);
            lblSignal1.TabIndex = 17;
            // 
            // lblStatusProvider
            // 
            lblStatusProvider.AutoSize = true;
            lblStatusProvider.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatusProvider.ForeColor = Color.Blue;
            lblStatusProvider.Location = new Point(144, 56);
            lblStatusProvider.Name = "lblStatusProvider";
            lblStatusProvider.Size = new Size(40, 28);
            lblStatusProvider.TabIndex = 16;
            lblStatusProvider.Text = "NA";
            // 
            // lblStatusModule
            // 
            lblStatusModule.AutoSize = true;
            lblStatusModule.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatusModule.ForeColor = Color.Blue;
            lblStatusModule.Location = new Point(250, 97);
            lblStatusModule.Name = "lblStatusModule";
            lblStatusModule.Size = new Size(65, 28);
            lblStatusModule.TabIndex = 15;
            lblStatusModule.Text = "Home";
            // 
            // lblStatusDecimal
            // 
            lblStatusDecimal.AutoSize = true;
            lblStatusDecimal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatusDecimal.ForeColor = Color.Blue;
            lblStatusDecimal.Location = new Point(146, 99);
            lblStatusDecimal.Name = "lblStatusDecimal";
            lblStatusDecimal.Size = new Size(58, 28);
            lblStatusDecimal.TabIndex = 14;
            lblStatusDecimal.Text = "15db";
            // 
            // label172
            // 
            label172.AutoSize = true;
            label172.Location = new Point(16, 338);
            label172.Name = "label172";
            label172.Size = new Size(47, 20);
            label172.TabIndex = 12;
            label172.Text = "GPRS:";
            // 
            // label173
            // 
            label173.AutoSize = true;
            label173.Location = new Point(15, 152);
            label173.Name = "label173";
            label173.Size = new Size(44, 20);
            label173.TabIndex = 11;
            label173.Text = "Date:";
            // 
            // label174
            // 
            label174.AutoSize = true;
            label174.Location = new Point(16, 400);
            label174.Name = "label174";
            label174.Size = new Size(65, 20);
            label174.TabIndex = 10;
            label174.Text = "IMEI No:";
            // 
            // label175
            // 
            label175.AutoSize = true;
            label175.Location = new Point(16, 462);
            label175.Name = "label175";
            label175.Size = new Size(68, 20);
            label175.TabIndex = 9;
            label175.Text = "Protocol:";
            // 
            // label176
            // 
            label176.AutoSize = true;
            label176.Location = new Point(16, 276);
            label176.Name = "label176";
            label176.Size = new Size(37, 20);
            label176.TabIndex = 8;
            label176.Text = "SIM:";
            // 
            // lblStatusTime
            // 
            lblStatusTime.AutoSize = true;
            lblStatusTime.Location = new Point(126, 214);
            lblStatusTime.Name = "lblStatusTime";
            lblStatusTime.Size = new Size(17, 20);
            lblStatusTime.TabIndex = 7;
            lblStatusTime.Text = "0";
            // 
            // lblStatusGprs
            // 
            lblStatusGprs.AutoSize = true;
            lblStatusGprs.Location = new Point(126, 340);
            lblStatusGprs.Name = "lblStatusGprs";
            lblStatusGprs.Size = new Size(17, 20);
            lblStatusGprs.TabIndex = 5;
            lblStatusGprs.Text = "0";
            // 
            // lblStatusDate
            // 
            lblStatusDate.AutoSize = true;
            lblStatusDate.Location = new Point(127, 152);
            lblStatusDate.Name = "lblStatusDate";
            lblStatusDate.Size = new Size(17, 20);
            lblStatusDate.TabIndex = 4;
            lblStatusDate.Text = "0";
            // 
            // lblStatusIMEI
            // 
            lblStatusIMEI.AutoSize = true;
            lblStatusIMEI.Location = new Point(126, 402);
            lblStatusIMEI.Name = "lblStatusIMEI";
            lblStatusIMEI.Size = new Size(17, 20);
            lblStatusIMEI.TabIndex = 3;
            lblStatusIMEI.Text = "0";
            // 
            // lblStatusProtocol
            // 
            lblStatusProtocol.AutoSize = true;
            lblStatusProtocol.Location = new Point(128, 459);
            lblStatusProtocol.Name = "lblStatusProtocol";
            lblStatusProtocol.Size = new Size(17, 20);
            lblStatusProtocol.TabIndex = 2;
            lblStatusProtocol.Text = "0";
            // 
            // lblStatusSim
            // 
            lblStatusSim.AutoSize = true;
            lblStatusSim.Location = new Point(126, 278);
            lblStatusSim.Name = "lblStatusSim";
            lblStatusSim.Size = new Size(17, 20);
            lblStatusSim.TabIndex = 1;
            lblStatusSim.Text = "0";
            // 
            // label177
            // 
            label177.AutoSize = true;
            label177.Location = new Point(16, 214);
            label177.Name = "label177";
            label177.Size = new Size(45, 20);
            label177.TabIndex = 0;
            label177.Text = "TIME:";
            // 
            // groupBox25
            // 
            groupBox25.Controls.Add(lblDataFlash);
            groupBox25.Controls.Add(lblFirmwareVer);
            groupBox25.Controls.Add(lblClientID);
            groupBox25.Controls.Add(lblHardwareVer);
            groupBox25.Controls.Add(lblStatusDeviceID);
            groupBox25.Controls.Add(lblStatusDeviceModel);
            groupBox25.Controls.Add(label182);
            groupBox25.Controls.Add(label183);
            groupBox25.Controls.Add(label184);
            groupBox25.Controls.Add(label185);
            groupBox25.Controls.Add(label186);
            groupBox25.Controls.Add(label187);
            groupBox25.Location = new Point(8, 52);
            groupBox25.Name = "groupBox25";
            groupBox25.Size = new Size(299, 660);
            groupBox25.TabIndex = 3;
            groupBox25.TabStop = false;
            groupBox25.Text = "Device Info.";
            // 
            // lblDataFlash
            // 
            lblDataFlash.AutoSize = true;
            lblDataFlash.Location = new Point(164, 266);
            lblDataFlash.Name = "lblDataFlash";
            lblDataFlash.Size = new Size(78, 20);
            lblDataFlash.TabIndex = 16;
            lblDataFlash.Text = "Data Flash";
            // 
            // lblFirmwareVer
            // 
            lblFirmwareVer.AutoSize = true;
            lblFirmwareVer.Location = new Point(164, 175);
            lblFirmwareVer.Name = "lblFirmwareVer";
            lblFirmwareVer.Size = new Size(95, 20);
            lblFirmwareVer.TabIndex = 14;
            lblFirmwareVer.Text = "Firmware Ver";
            // 
            // lblClientID
            // 
            lblClientID.AutoSize = true;
            lblClientID.Location = new Point(164, 221);
            lblClientID.Name = "lblClientID";
            lblClientID.Size = new Size(66, 20);
            lblClientID.TabIndex = 13;
            lblClientID.Text = "Client ID";
            // 
            // lblHardwareVer
            // 
            lblHardwareVer.AutoSize = true;
            lblHardwareVer.Location = new Point(164, 131);
            lblHardwareVer.Name = "lblHardwareVer";
            lblHardwareVer.Size = new Size(99, 20);
            lblHardwareVer.TabIndex = 12;
            lblHardwareVer.Text = "Hardware Ver";
            // 
            // lblStatusDeviceID
            // 
            lblStatusDeviceID.AutoSize = true;
            lblStatusDeviceID.Location = new Point(164, 85);
            lblStatusDeviceID.Name = "lblStatusDeviceID";
            lblStatusDeviceID.Size = new Size(56, 20);
            lblStatusDeviceID.TabIndex = 11;
            lblStatusDeviceID.Text = "App ID";
            // 
            // lblStatusDeviceModel
            // 
            lblStatusDeviceModel.AutoSize = true;
            lblStatusDeviceModel.Location = new Point(164, 41);
            lblStatusDeviceModel.Name = "lblStatusDeviceModel";
            lblStatusDeviceModel.Size = new Size(101, 20);
            lblStatusDeviceModel.TabIndex = 10;
            lblStatusDeviceModel.Text = "Device Model";
            // 
            // label182
            // 
            label182.AutoSize = true;
            label182.Location = new Point(19, 266);
            label182.Name = "label182";
            label182.Size = new Size(81, 20);
            label182.TabIndex = 5;
            label182.Text = "Data Flash:";
            // 
            // label183
            // 
            label183.AutoSize = true;
            label183.Location = new Point(19, 175);
            label183.Name = "label183";
            label183.Size = new Size(98, 20);
            label183.TabIndex = 4;
            label183.Text = "Firmware Ver:";
            // 
            // label184
            // 
            label184.AutoSize = true;
            label184.Location = new Point(19, 221);
            label184.Name = "label184";
            label184.Size = new Size(69, 20);
            label184.TabIndex = 3;
            label184.Text = "Client ID:";
            // 
            // label185
            // 
            label185.AutoSize = true;
            label185.Location = new Point(19, 131);
            label185.Name = "label185";
            label185.Size = new Size(102, 20);
            label185.TabIndex = 2;
            label185.Text = "Hardware Ver:";
            // 
            // label186
            // 
            label186.AutoSize = true;
            label186.Location = new Point(19, 85);
            label186.Name = "label186";
            label186.Size = new Size(76, 20);
            label186.TabIndex = 1;
            label186.Text = "Device ID:";
            // 
            // label187
            // 
            label187.AutoSize = true;
            label187.Location = new Point(19, 41);
            label187.Name = "label187";
            label187.Size = new Size(104, 20);
            label187.TabIndex = 0;
            label187.Text = "Device Model:";
            // 
            // label164
            // 
            label164.AutoSize = true;
            label164.Font = new Font("Calibri", 16.2F, (FontStyle)(FontStyle.Bold) | (FontStyle.Underline), GraphicsUnit.Point);
            label164.Location = new Point(498, 4);
            label164.Name = "label164";
            label164.Size = new Size(88, 35);
            label164.TabIndex = 1;
            label164.Text = "Status";
            // 
            // pnlDOSettings
            // 
            pnlDOSettings.Controls.Add(btnDOWriteMemory);
            pnlDOSettings.Controls.Add(btnDOReadMemory);
            pnlDOSettings.Controls.Add(cmbDOSelectChannel);
            pnlDOSettings.Controls.Add(label115);
            pnlDOSettings.Controls.Add(groupBox14);
            pnlDOSettings.Controls.Add(label40);
            pnlDOSettings.Location = new Point(321, 9);
            pnlDOSettings.Name = "pnlDOSettings";
            pnlDOSettings.Size = new Size(1133, 822);
            pnlDOSettings.TabIndex = 2;
            pnlDOSettings.Visible = false;
            // 
            // btnDOWriteMemory
            // 
            btnDOWriteMemory.BackColor = Color.Red;
            btnDOWriteMemory.Cursor = Cursors.Hand;
            btnDOWriteMemory.ForeColor = Color.White;
            btnDOWriteMemory.Location = new Point(597, 729);
            btnDOWriteMemory.Name = "btnDOWriteMemory";
            btnDOWriteMemory.Size = new Size(172, 42);
            btnDOWriteMemory.TabIndex = 56;
            btnDOWriteMemory.Text = "Write Memory";
            btnDOWriteMemory.UseVisualStyleBackColor = false;
            btnDOWriteMemory.Click += (this.btnDOWriteMemory_Click);
            // 
            // btnDOReadMemory
            // 
            btnDOReadMemory.BackColor = Color.DarkKhaki;
            btnDOReadMemory.Cursor = Cursors.Hand;
            btnDOReadMemory.ForeColor = Color.White;
            btnDOReadMemory.Location = new Point(325, 729);
            btnDOReadMemory.Name = "btnDOReadMemory";
            btnDOReadMemory.Size = new Size(190, 42);
            btnDOReadMemory.TabIndex = 55;
            btnDOReadMemory.Text = "Read Memory";
            btnDOReadMemory.UseVisualStyleBackColor = false;
            btnDOReadMemory.Click += (this.btnDOReadMemory_Click);
            // 
            // cmbDOSelectChannel
            // 
            cmbDOSelectChannel.BackColor = SystemColors.HighlightText;
            cmbDOSelectChannel.Cursor = Cursors.Hand;
            cmbDOSelectChannel.FlatStyle = FlatStyle.Popup;
            cmbDOSelectChannel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbDOSelectChannel.FormattingEnabled = true;
            cmbDOSelectChannel.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7" });
            cmbDOSelectChannel.Location = new Point(491, 76);
            cmbDOSelectChannel.Name = "cmbDOSelectChannel";
            cmbDOSelectChannel.Size = new Size(224, 28);
            cmbDOSelectChannel.TabIndex = 52;
            // 
            // label115
            // 
            label115.AutoSize = true;
            label115.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label115.Location = new Point(362, 79);
            label115.Name = "label115";
            label115.Size = new Size(110, 20);
            label115.TabIndex = 51;
            label115.Text = "Select Channel";
            // 
            // groupBox14
            // 
            groupBox14.Controls.Add(label121);
            groupBox14.Controls.Add(label120);
            groupBox14.Controls.Add(txtDoOnTime);
            groupBox14.Controls.Add(label117);
            groupBox14.Controls.Add(txtDoOffTime);
            groupBox14.Controls.Add(label116);
            groupBox14.Controls.Add(txtDoRelayDelayTime);
            groupBox14.Controls.Add(label118);
            groupBox14.Controls.Add(txtDoRelayCloseOn);
            groupBox14.Controls.Add(label119);
            groupBox14.Controls.Add(cmbDOType);
            groupBox14.Controls.Add(label114);
            groupBox14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox14.Location = new Point(362, 129);
            groupBox14.Name = "groupBox14";
            groupBox14.Size = new Size(361, 300);
            groupBox14.TabIndex = 50;
            groupBox14.TabStop = false;
            groupBox14.Text = "DO Channel Setup";
            // 
            // label121
            // 
            label121.AutoSize = true;
            label121.Location = new Point(290, 212);
            label121.MaximumSize = new Size(164, 60);
            label121.Name = "label121";
            label121.Size = new Size(63, 20);
            label121.TabIndex = 33;
            label121.Text = "HH:MM";
            // 
            // label120
            // 
            label120.AutoSize = true;
            label120.Location = new Point(289, 166);
            label120.MaximumSize = new Size(164, 60);
            label120.Name = "label120";
            label120.Size = new Size(63, 20);
            label120.TabIndex = 32;
            label120.Text = "HH:MM";
            // 
            // txtDoOnTime
            // 
            txtDoOnTime.BorderStyle = BorderStyle.FixedSingle;
            txtDoOnTime.Location = new Point(162, 163);
            txtDoOnTime.MaxLength = 5;
            txtDoOnTime.Name = "txtDoOnTime";
            txtDoOnTime.Size = new Size(118, 27);
            txtDoOnTime.TabIndex = 31;
            // 
            // label117
            // 
            label117.AutoSize = true;
            label117.Location = new Point(14, 169);
            label117.MaximumSize = new Size(164, 60);
            label117.Name = "label117";
            label117.Size = new Size(68, 20);
            label117.TabIndex = 30;
            label117.Text = "On Time";
            // 
            // txtDoOffTime
            // 
            txtDoOffTime.BorderStyle = BorderStyle.FixedSingle;
            txtDoOffTime.Location = new Point(162, 210);
            txtDoOffTime.MaxLength = 5;
            txtDoOffTime.Name = "txtDoOffTime";
            txtDoOffTime.Size = new Size(117, 27);
            txtDoOffTime.TabIndex = 29;
            // 
            // label116
            // 
            label116.AutoSize = true;
            label116.Location = new Point(13, 211);
            label116.MaximumSize = new Size(164, 60);
            label116.Name = "label116";
            label116.Size = new Size(71, 20);
            label116.TabIndex = 28;
            label116.Text = "Off Time";
            // 
            // txtDoRelayDelayTime
            // 
            txtDoRelayDelayTime.BorderStyle = BorderStyle.FixedSingle;
            txtDoRelayDelayTime.Location = new Point(162, 120);
            txtDoRelayDelayTime.MaxLength = 10;
            txtDoRelayDelayTime.Name = "txtDoRelayDelayTime";
            txtDoRelayDelayTime.Size = new Size(189, 27);
            txtDoRelayDelayTime.TabIndex = 22;
            // 
            // label118
            // 
            label118.AutoSize = true;
            label118.Location = new Point(14, 127);
            label118.Name = "label118";
            label118.Size = new Size(129, 20);
            label118.TabIndex = 21;
            label118.Text = "Relay Delay Time";
            // 
            // txtDoRelayCloseOn
            // 
            txtDoRelayCloseOn.BorderStyle = BorderStyle.FixedSingle;
            txtDoRelayCloseOn.Location = new Point(162, 77);
            txtDoRelayCloseOn.MaxLength = 10;
            txtDoRelayCloseOn.Name = "txtDoRelayCloseOn";
            txtDoRelayCloseOn.Size = new Size(188, 27);
            txtDoRelayCloseOn.TabIndex = 20;
            // 
            // label119
            // 
            label119.AutoSize = true;
            label119.Location = new Point(13, 85);
            label119.MaximumSize = new Size(150, 0);
            label119.Name = "label119";
            label119.Size = new Size(127, 20);
            label119.TabIndex = 19;
            label119.Text = "Relay Close Time";
            // 
            // cmbDOType
            // 
            cmbDOType.FormattingEnabled = true;
            cmbDOType.Items.AddRange(new object[] { "Ignore-0", "Close Alarm-1", "Open Alarm-2", "OC-CO Alarm-3", "Timer 4", "Static Command 5", "Dynamic Command 6" });
            cmbDOType.Location = new Point(162, 33);
            cmbDOType.Name = "cmbDOType";
            cmbDOType.Size = new Size(187, 28);
            cmbDOType.TabIndex = 29;
            // 
            // label114
            // 
            label114.AutoSize = true;
            label114.Location = new Point(15, 43);
            label114.Name = "label114";
            label114.Size = new Size(66, 20);
            label114.TabIndex = 28;
            label114.Text = "D0 Type";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Segoe UI", 13.8F, (FontStyle)(FontStyle.Bold) | (FontStyle.Underline), GraphicsUnit.Point);
            label40.Location = new Point(486, 6);
            label40.Name = "label40";
            label40.Size = new Size(142, 31);
            label40.TabIndex = 0;
            label40.Text = "DO Settings";
            // 
            // pnlModbusMaster
            // 
            pnlModbusMaster.AutoScroll = true;
            pnlModbusMaster.Controls.Add(groupBox19);
            pnlModbusMaster.Controls.Add(groupBox18);
            pnlModbusMaster.Controls.Add(cmbMasterSlaveIndex);
            pnlModbusMaster.Controls.Add(label195);
            pnlModbusMaster.Controls.Add(label45);
            pnlModbusMaster.Location = new Point(321, 9);
            pnlModbusMaster.Name = "pnlModbusMaster";
            pnlModbusMaster.Size = new Size(1135, 822);
            pnlModbusMaster.TabIndex = 7;
            pnlModbusMaster.Visible = false;
            // 
            // groupBox19
            // 
            groupBox19.Controls.Add(label133);
            groupBox19.Controls.Add(btnMasterReadAll);
            groupBox19.Controls.Add(btnMasterWriteAll);
            groupBox19.Controls.Add(pnlMasterScroll);
            groupBox19.Controls.Add(label207);
            groupBox19.Controls.Add(label206);
            groupBox19.Controls.Add(label205);
            groupBox19.Controls.Add(label196);
            groupBox19.Controls.Add(label201);
            groupBox19.Controls.Add(label202);
            groupBox19.Controls.Add(label203);
            groupBox19.Controls.Add(label204);
            groupBox19.Location = new Point(2, 206);
            groupBox19.Name = "groupBox19";
            groupBox19.Size = new Size(1127, 607);
            groupBox19.TabIndex = 89;
            groupBox19.TabStop = false;
            groupBox19.Text = "Register Connection Parameter";
            // 
            // label133
            // 
            label133.AutoSize = true;
            label133.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            label133.Location = new Point(820, 34);
            label133.Name = "label133";
            label133.Size = new Size(87, 17);
            label133.TabIndex = 108;
            label133.Text = "Decimal Point";
            // 
            // btnMasterReadAll
            // 
            btnMasterReadAll.BackColor = Color.DarkKhaki;
            btnMasterReadAll.Cursor = Cursors.Hand;
            btnMasterReadAll.ForeColor = Color.White;
            btnMasterReadAll.Location = new Point(325, 558);
            btnMasterReadAll.Name = "btnMasterReadAll";
            btnMasterReadAll.Size = new Size(190, 42);
            btnMasterReadAll.TabIndex = 107;
            btnMasterReadAll.Text = "Read All";
            btnMasterReadAll.UseVisualStyleBackColor = false;
            btnMasterReadAll.Click += (this.btnMasterReadAll_Click);
            // 
            // btnMasterWriteAll
            // 
            btnMasterWriteAll.BackColor = Color.Red;
            btnMasterWriteAll.Cursor = Cursors.Hand;
            btnMasterWriteAll.ForeColor = Color.White;
            btnMasterWriteAll.Location = new Point(601, 558);
            btnMasterWriteAll.Name = "btnMasterWriteAll";
            btnMasterWriteAll.Size = new Size(172, 42);
            btnMasterWriteAll.TabIndex = 106;
            btnMasterWriteAll.Text = "Write All";
            btnMasterWriteAll.UseVisualStyleBackColor = false;
            btnMasterWriteAll.Click += (this.btnMasterWriteAll_Click);
            // 
            // pnlMasterScroll
            // 
            pnlMasterScroll.AutoScroll = true;
            pnlMasterScroll.AutoScrollMinSize = new Size(1072, 1087);
            pnlMasterScroll.Controls.Add(groupBox44);
            pnlMasterScroll.Controls.Add(groupBox45);
            pnlMasterScroll.Controls.Add(groupBox46);
            pnlMasterScroll.Controls.Add(groupBox47);
            pnlMasterScroll.Controls.Add(groupBox48);
            pnlMasterScroll.Controls.Add(groupBox49);
            pnlMasterScroll.Controls.Add(groupBox50);
            pnlMasterScroll.Controls.Add(groupBox51);
            pnlMasterScroll.Controls.Add(groupBox52);
            pnlMasterScroll.Controls.Add(groupBox53);
            pnlMasterScroll.Controls.Add(groupBox54);
            pnlMasterScroll.Controls.Add(groupBox55);
            pnlMasterScroll.Controls.Add(groupBox56);
            pnlMasterScroll.Controls.Add(groupBox57);
            pnlMasterScroll.Controls.Add(groupBox58);
            pnlMasterScroll.Controls.Add(groupBox59);
            pnlMasterScroll.Controls.Add(groupBox60);
            pnlMasterScroll.Controls.Add(groupBox61);
            pnlMasterScroll.Controls.Add(groupBox62);
            pnlMasterScroll.Controls.Add(groupBox63);
            pnlMasterScroll.Controls.Add(groupBox34);
            pnlMasterScroll.Controls.Add(groupBox35);
            pnlMasterScroll.Controls.Add(groupBox36);
            pnlMasterScroll.Controls.Add(groupBox37);
            pnlMasterScroll.Controls.Add(groupBox38);
            pnlMasterScroll.Controls.Add(groupBox39);
            pnlMasterScroll.Controls.Add(groupBox40);
            pnlMasterScroll.Controls.Add(groupBox41);
            pnlMasterScroll.Controls.Add(groupBox42);
            pnlMasterScroll.Controls.Add(groupBox43);
            pnlMasterScroll.Controls.Add(groupBox21);
            pnlMasterScroll.Controls.Add(groupBox32);
            pnlMasterScroll.Controls.Add(groupBox33);
            pnlMasterScroll.Controls.Add(groupBox28);
            pnlMasterScroll.Controls.Add(groupBox29);
            pnlMasterScroll.Controls.Add(groupBox30);
            pnlMasterScroll.Controls.Add(groupBox31);
            pnlMasterScroll.Controls.Add(groupBox22);
            pnlMasterScroll.Controls.Add(groupBox24);
            pnlMasterScroll.Controls.Add(groupBox20);
            pnlMasterScroll.Location = new Point(6, 62);
            pnlMasterScroll.Name = "pnlMasterScroll";
            pnlMasterScroll.Size = new Size(1120, 483);
            pnlMasterScroll.TabIndex = 104;
            // 
            // groupBox44
            // 
            groupBox44.Controls.Add(cmbDecimalPoint32);
            groupBox44.Controls.Add(label178);
            groupBox44.Controls.Add(cmbMasterFunctionCode32);
            groupBox44.Controls.Add(cmbMasterByteOrder32);
            groupBox44.Controls.Add(cmbMasterDataType32);
            groupBox44.Controls.Add(cmbMasterActivation32);
            groupBox44.Controls.Add(btnRegWriteMemory32);
            groupBox44.Controls.Add(btnRegReadMemory32);
            groupBox44.Controls.Add(txtMasterScaleFactor32);
            groupBox44.Controls.Add(txtMasterName32);
            groupBox44.Controls.Add(txtMasterRegStartAddress32);
            groupBox44.Controls.Add(txtMasterRegIndex32);
            groupBox44.Location = new Point(-5, 1639);
            groupBox44.Name = "groupBox44";
            groupBox44.Size = new Size(1097, 51);
            groupBox44.TabIndex = 140;
            groupBox44.TabStop = false;
            // 
            // cmbDecimalPoint32
            // 
            cmbDecimalPoint32.FormattingEnabled = true;
            cmbDecimalPoint32.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint32.Location = new Point(816, 16);
            cmbDecimalPoint32.Name = "cmbDecimalPoint32";
            cmbDecimalPoint32.Size = new Size(55, 28);
            cmbDecimalPoint32.TabIndex = 134;
            // 
            // label178
            // 
            label178.AutoSize = true;
            label178.Location = new Point(0, 19);
            label178.Name = "label178";
            label178.Size = new Size(25, 20);
            label178.TabIndex = 129;
            label178.Text = "32";
            // 
            // cmbMasterFunctionCode32
            // 
            cmbMasterFunctionCode32.FormattingEnabled = true;
            cmbMasterFunctionCode32.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode32.Location = new Point(583, 16);
            cmbMasterFunctionCode32.Name = "cmbMasterFunctionCode32";
            cmbMasterFunctionCode32.Size = new Size(155, 28);
            cmbMasterFunctionCode32.TabIndex = 100;
            // 
            // cmbMasterByteOrder32
            // 
            cmbMasterByteOrder32.FormattingEnabled = true;
            cmbMasterByteOrder32.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder32.Location = new Point(486, 16);
            cmbMasterByteOrder32.Name = "cmbMasterByteOrder32";
            cmbMasterByteOrder32.Size = new Size(92, 28);
            cmbMasterByteOrder32.TabIndex = 99;
            // 
            // cmbMasterDataType32
            // 
            cmbMasterDataType32.FormattingEnabled = true;
            cmbMasterDataType32.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType32.Location = new Point(351, 16);
            cmbMasterDataType32.Name = "cmbMasterDataType32";
            cmbMasterDataType32.Size = new Size(130, 28);
            cmbMasterDataType32.TabIndex = 98;
            // 
            // cmbMasterActivation32
            // 
            cmbMasterActivation32.FormattingEnabled = true;
            cmbMasterActivation32.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation32.Location = new Point(279, 16);
            cmbMasterActivation32.Name = "cmbMasterActivation32";
            cmbMasterActivation32.Size = new Size(68, 28);
            cmbMasterActivation32.TabIndex = 97;
            // 
            // btnRegWriteMemory32
            // 
            btnRegWriteMemory32.BackColor = Color.Red;
            btnRegWriteMemory32.Cursor = Cursors.Hand;
            btnRegWriteMemory32.ForeColor = Color.White;
            btnRegWriteMemory32.Location = new Point(984, 15);
            btnRegWriteMemory32.Name = "btnRegWriteMemory32";
            btnRegWriteMemory32.Size = new Size(112, 30);
            btnRegWriteMemory32.TabIndex = 95;
            btnRegWriteMemory32.Text = "Write Memory";
            btnRegWriteMemory32.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory32
            // 
            btnRegReadMemory32.BackColor = Color.DarkKhaki;
            btnRegReadMemory32.Cursor = Cursors.Hand;
            btnRegReadMemory32.ForeColor = Color.White;
            btnRegReadMemory32.Location = new Point(872, 15);
            btnRegReadMemory32.Name = "btnRegReadMemory32";
            btnRegReadMemory32.Size = new Size(112, 30);
            btnRegReadMemory32.TabIndex = 94;
            btnRegReadMemory32.Text = "Read Memory";
            btnRegReadMemory32.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor32
            // 
            txtMasterScaleFactor32.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor32.Location = new Point(742, 16);
            txtMasterScaleFactor32.MaxLength = 10;
            txtMasterScaleFactor32.Name = "txtMasterScaleFactor32";
            txtMasterScaleFactor32.Size = new Size(69, 27);
            txtMasterScaleFactor32.TabIndex = 93;
            // 
            // txtMasterName32
            // 
            txtMasterName32.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName32.Location = new Point(221, 16);
            txtMasterName32.MaxLength = 5;
            txtMasterName32.Name = "txtMasterName32";
            txtMasterName32.Size = new Size(53, 27);
            txtMasterName32.TabIndex = 92;
            // 
            // txtMasterRegStartAddress32
            // 
            txtMasterRegStartAddress32.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress32.Location = new Point(108, 16);
            txtMasterRegStartAddress32.MaxLength = 10;
            txtMasterRegStartAddress32.Name = "txtMasterRegStartAddress32";
            txtMasterRegStartAddress32.Size = new Size(110, 27);
            txtMasterRegStartAddress32.TabIndex = 91;
            // 
            // txtMasterRegIndex32
            // 
            txtMasterRegIndex32.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex32.Enabled = false;
            txtMasterRegIndex32.Location = new Point(27, 16);
            txtMasterRegIndex32.MaxLength = 2;
            txtMasterRegIndex32.Name = "txtMasterRegIndex32";
            txtMasterRegIndex32.Size = new Size(79, 27);
            txtMasterRegIndex32.TabIndex = 90;
            txtMasterRegIndex32.Text = "31";
            // 
            // groupBox45
            // 
            groupBox45.Controls.Add(cmbDecimalPoint40);
            groupBox45.Controls.Add(label179);
            groupBox45.Controls.Add(cmbMasterFunctionCode40);
            groupBox45.Controls.Add(cmbMasterByteOrder40);
            groupBox45.Controls.Add(cmbMasterDataType40);
            groupBox45.Controls.Add(cmbMasterActivation40);
            groupBox45.Controls.Add(btnRegWriteMemory40);
            groupBox45.Controls.Add(btnRegReadMemory40);
            groupBox45.Controls.Add(txtMasterScaleFactor40);
            groupBox45.Controls.Add(txtMasterName40);
            groupBox45.Controls.Add(txtMasterRegStartAddress40);
            groupBox45.Controls.Add(txtMasterRegIndex40);
            groupBox45.Location = new Point(-3, 2059);
            groupBox45.Name = "groupBox45";
            groupBox45.Size = new Size(1094, 51);
            groupBox45.TabIndex = 139;
            groupBox45.TabStop = false;
            // 
            // cmbDecimalPoint40
            // 
            cmbDecimalPoint40.FormattingEnabled = true;
            cmbDecimalPoint40.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint40.Location = new Point(810, 15);
            cmbDecimalPoint40.Name = "cmbDecimalPoint40";
            cmbDecimalPoint40.Size = new Size(55, 28);
            cmbDecimalPoint40.TabIndex = 136;
            // 
            // label179
            // 
            label179.AutoSize = true;
            label179.Location = new Point(-2, 18);
            label179.Name = "label179";
            label179.Size = new Size(25, 20);
            label179.TabIndex = 121;
            label179.Text = "40";
            // 
            // cmbMasterFunctionCode40
            // 
            cmbMasterFunctionCode40.FormattingEnabled = true;
            cmbMasterFunctionCode40.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode40.Location = new Point(577, 16);
            cmbMasterFunctionCode40.Name = "cmbMasterFunctionCode40";
            cmbMasterFunctionCode40.Size = new Size(155, 28);
            cmbMasterFunctionCode40.TabIndex = 100;
            // 
            // cmbMasterByteOrder40
            // 
            cmbMasterByteOrder40.FormattingEnabled = true;
            cmbMasterByteOrder40.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder40.Location = new Point(480, 16);
            cmbMasterByteOrder40.Name = "cmbMasterByteOrder40";
            cmbMasterByteOrder40.Size = new Size(92, 28);
            cmbMasterByteOrder40.TabIndex = 99;
            // 
            // cmbMasterDataType40
            // 
            cmbMasterDataType40.FormattingEnabled = true;
            cmbMasterDataType40.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType40.Location = new Point(345, 16);
            cmbMasterDataType40.Name = "cmbMasterDataType40";
            cmbMasterDataType40.Size = new Size(130, 28);
            cmbMasterDataType40.TabIndex = 98;
            // 
            // cmbMasterActivation40
            // 
            cmbMasterActivation40.FormattingEnabled = true;
            cmbMasterActivation40.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation40.Location = new Point(273, 16);
            cmbMasterActivation40.Name = "cmbMasterActivation40";
            cmbMasterActivation40.Size = new Size(68, 28);
            cmbMasterActivation40.TabIndex = 97;
            // 
            // btnRegWriteMemory40
            // 
            btnRegWriteMemory40.BackColor = Color.Red;
            btnRegWriteMemory40.Cursor = Cursors.Hand;
            btnRegWriteMemory40.ForeColor = Color.White;
            btnRegWriteMemory40.Location = new Point(980, 15);
            btnRegWriteMemory40.Name = "btnRegWriteMemory40";
            btnRegWriteMemory40.Size = new Size(112, 30);
            btnRegWriteMemory40.TabIndex = 95;
            btnRegWriteMemory40.Text = "Write Memory";
            btnRegWriteMemory40.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory40
            // 
            btnRegReadMemory40.BackColor = Color.DarkKhaki;
            btnRegReadMemory40.Cursor = Cursors.Hand;
            btnRegReadMemory40.ForeColor = Color.White;
            btnRegReadMemory40.Location = new Point(868, 15);
            btnRegReadMemory40.Name = "btnRegReadMemory40";
            btnRegReadMemory40.Size = new Size(112, 30);
            btnRegReadMemory40.TabIndex = 94;
            btnRegReadMemory40.Text = "Read Memory";
            btnRegReadMemory40.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor40
            // 
            txtMasterScaleFactor40.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor40.Location = new Point(736, 16);
            txtMasterScaleFactor40.MaxLength = 10;
            txtMasterScaleFactor40.Name = "txtMasterScaleFactor40";
            txtMasterScaleFactor40.Size = new Size(69, 27);
            txtMasterScaleFactor40.TabIndex = 93;
            // 
            // txtMasterName40
            // 
            txtMasterName40.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName40.Location = new Point(217, 16);
            txtMasterName40.MaxLength = 5;
            txtMasterName40.Name = "txtMasterName40";
            txtMasterName40.Size = new Size(50, 27);
            txtMasterName40.TabIndex = 92;
            // 
            // txtMasterRegStartAddress40
            // 
            txtMasterRegStartAddress40.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress40.Location = new Point(104, 16);
            txtMasterRegStartAddress40.MaxLength = 10;
            txtMasterRegStartAddress40.Name = "txtMasterRegStartAddress40";
            txtMasterRegStartAddress40.Size = new Size(110, 27);
            txtMasterRegStartAddress40.TabIndex = 91;
            // 
            // txtMasterRegIndex40
            // 
            txtMasterRegIndex40.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex40.Enabled = false;
            txtMasterRegIndex40.Location = new Point(23, 16);
            txtMasterRegIndex40.MaxLength = 2;
            txtMasterRegIndex40.Name = "txtMasterRegIndex40";
            txtMasterRegIndex40.Size = new Size(79, 27);
            txtMasterRegIndex40.TabIndex = 90;
            txtMasterRegIndex40.Text = "39";
            // 
            // groupBox46
            // 
            groupBox46.Controls.Add(cmbDecimalPoint39);
            groupBox46.Controls.Add(label180);
            groupBox46.Controls.Add(cmbMasterFunctionCode39);
            groupBox46.Controls.Add(cmbMasterByteOrder39);
            groupBox46.Controls.Add(cmbMasterDataType39);
            groupBox46.Controls.Add(cmbMasterActivation39);
            groupBox46.Controls.Add(btnRegWriteMemory39);
            groupBox46.Controls.Add(btnRegReadMemory39);
            groupBox46.Controls.Add(txtMasterScaleFactor39);
            groupBox46.Controls.Add(txtMasterName39);
            groupBox46.Controls.Add(txtMasterRegStartAddress39);
            groupBox46.Controls.Add(txtMasterRegIndex39);
            groupBox46.Location = new Point(-4, 2007);
            groupBox46.Name = "groupBox46";
            groupBox46.Size = new Size(1094, 51);
            groupBox46.TabIndex = 138;
            groupBox46.TabStop = false;
            // 
            // cmbDecimalPoint39
            // 
            cmbDecimalPoint39.FormattingEnabled = true;
            cmbDecimalPoint39.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint39.Location = new Point(811, 16);
            cmbDecimalPoint39.Name = "cmbDecimalPoint39";
            cmbDecimalPoint39.Size = new Size(55, 28);
            cmbDecimalPoint39.TabIndex = 136;
            // 
            // label180
            // 
            label180.AutoSize = true;
            label180.Location = new Point(-1, 19);
            label180.Name = "label180";
            label180.Size = new Size(25, 20);
            label180.TabIndex = 122;
            label180.Text = "39";
            // 
            // cmbMasterFunctionCode39
            // 
            cmbMasterFunctionCode39.FormattingEnabled = true;
            cmbMasterFunctionCode39.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode39.Location = new Point(577, 16);
            cmbMasterFunctionCode39.Name = "cmbMasterFunctionCode39";
            cmbMasterFunctionCode39.Size = new Size(155, 28);
            cmbMasterFunctionCode39.TabIndex = 100;
            // 
            // cmbMasterByteOrder39
            // 
            cmbMasterByteOrder39.FormattingEnabled = true;
            cmbMasterByteOrder39.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder39.Location = new Point(480, 16);
            cmbMasterByteOrder39.Name = "cmbMasterByteOrder39";
            cmbMasterByteOrder39.Size = new Size(92, 28);
            cmbMasterByteOrder39.TabIndex = 99;
            // 
            // cmbMasterDataType39
            // 
            cmbMasterDataType39.FormattingEnabled = true;
            cmbMasterDataType39.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType39.Location = new Point(345, 16);
            cmbMasterDataType39.Name = "cmbMasterDataType39";
            cmbMasterDataType39.Size = new Size(130, 28);
            cmbMasterDataType39.TabIndex = 98;
            // 
            // cmbMasterActivation39
            // 
            cmbMasterActivation39.FormattingEnabled = true;
            cmbMasterActivation39.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation39.Location = new Point(273, 16);
            cmbMasterActivation39.Name = "cmbMasterActivation39";
            cmbMasterActivation39.Size = new Size(68, 28);
            cmbMasterActivation39.TabIndex = 97;
            // 
            // btnRegWriteMemory39
            // 
            btnRegWriteMemory39.BackColor = Color.Red;
            btnRegWriteMemory39.Cursor = Cursors.Hand;
            btnRegWriteMemory39.ForeColor = Color.White;
            btnRegWriteMemory39.Location = new Point(981, 15);
            btnRegWriteMemory39.Name = "btnRegWriteMemory39";
            btnRegWriteMemory39.Size = new Size(112, 30);
            btnRegWriteMemory39.TabIndex = 95;
            btnRegWriteMemory39.Text = "Write Memory";
            btnRegWriteMemory39.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory39
            // 
            btnRegReadMemory39.BackColor = Color.DarkKhaki;
            btnRegReadMemory39.Cursor = Cursors.Hand;
            btnRegReadMemory39.ForeColor = Color.White;
            btnRegReadMemory39.Location = new Point(869, 15);
            btnRegReadMemory39.Name = "btnRegReadMemory39";
            btnRegReadMemory39.Size = new Size(112, 30);
            btnRegReadMemory39.TabIndex = 94;
            btnRegReadMemory39.Text = "Read Memory";
            btnRegReadMemory39.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor39
            // 
            txtMasterScaleFactor39.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor39.Location = new Point(736, 16);
            txtMasterScaleFactor39.MaxLength = 10;
            txtMasterScaleFactor39.Name = "txtMasterScaleFactor39";
            txtMasterScaleFactor39.Size = new Size(69, 27);
            txtMasterScaleFactor39.TabIndex = 93;
            // 
            // txtMasterName39
            // 
            txtMasterName39.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName39.Location = new Point(218, 16);
            txtMasterName39.MaxLength = 5;
            txtMasterName39.Name = "txtMasterName39";
            txtMasterName39.Size = new Size(50, 27);
            txtMasterName39.TabIndex = 92;
            // 
            // txtMasterRegStartAddress39
            // 
            txtMasterRegStartAddress39.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress39.Location = new Point(105, 16);
            txtMasterRegStartAddress39.MaxLength = 10;
            txtMasterRegStartAddress39.Name = "txtMasterRegStartAddress39";
            txtMasterRegStartAddress39.Size = new Size(110, 27);
            txtMasterRegStartAddress39.TabIndex = 91;
            // 
            // txtMasterRegIndex39
            // 
            txtMasterRegIndex39.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex39.Enabled = false;
            txtMasterRegIndex39.Location = new Point(24, 16);
            txtMasterRegIndex39.MaxLength = 2;
            txtMasterRegIndex39.Name = "txtMasterRegIndex39";
            txtMasterRegIndex39.Size = new Size(79, 27);
            txtMasterRegIndex39.TabIndex = 90;
            txtMasterRegIndex39.Text = "38";
            // 
            // groupBox47
            // 
            groupBox47.Controls.Add(cmbDecimalPoint38);
            groupBox47.Controls.Add(label181);
            groupBox47.Controls.Add(cmbMasterFunctionCode38);
            groupBox47.Controls.Add(cmbMasterByteOrder38);
            groupBox47.Controls.Add(cmbMasterDataType38);
            groupBox47.Controls.Add(cmbMasterActivation38);
            groupBox47.Controls.Add(btnRegWriteMemory38);
            groupBox47.Controls.Add(btnRegReadMemory38);
            groupBox47.Controls.Add(txtMasterScaleFactor38);
            groupBox47.Controls.Add(txtMasterName38);
            groupBox47.Controls.Add(txtMasterRegStartAddress38);
            groupBox47.Controls.Add(txtMasterRegIndex38);
            groupBox47.Location = new Point(-5, 1955);
            groupBox47.Name = "groupBox47";
            groupBox47.Size = new Size(1094, 51);
            groupBox47.TabIndex = 137;
            groupBox47.TabStop = false;
            // 
            // cmbDecimalPoint38
            // 
            cmbDecimalPoint38.FormattingEnabled = true;
            cmbDecimalPoint38.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint38.Location = new Point(814, 16);
            cmbDecimalPoint38.Name = "cmbDecimalPoint38";
            cmbDecimalPoint38.Size = new Size(55, 28);
            cmbDecimalPoint38.TabIndex = 135;
            // 
            // label181
            // 
            label181.AutoSize = true;
            label181.Location = new Point(0, 19);
            label181.Name = "label181";
            label181.Size = new Size(25, 20);
            label181.TabIndex = 123;
            label181.Text = "38";
            // 
            // cmbMasterFunctionCode38
            // 
            cmbMasterFunctionCode38.FormattingEnabled = true;
            cmbMasterFunctionCode38.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode38.Location = new Point(581, 16);
            cmbMasterFunctionCode38.Name = "cmbMasterFunctionCode38";
            cmbMasterFunctionCode38.Size = new Size(155, 28);
            cmbMasterFunctionCode38.TabIndex = 100;
            // 
            // cmbMasterByteOrder38
            // 
            cmbMasterByteOrder38.FormattingEnabled = true;
            cmbMasterByteOrder38.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder38.Location = new Point(484, 16);
            cmbMasterByteOrder38.Name = "cmbMasterByteOrder38";
            cmbMasterByteOrder38.Size = new Size(92, 28);
            cmbMasterByteOrder38.TabIndex = 99;
            // 
            // cmbMasterDataType38
            // 
            cmbMasterDataType38.FormattingEnabled = true;
            cmbMasterDataType38.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType38.Location = new Point(349, 16);
            cmbMasterDataType38.Name = "cmbMasterDataType38";
            cmbMasterDataType38.Size = new Size(130, 28);
            cmbMasterDataType38.TabIndex = 98;
            // 
            // cmbMasterActivation38
            // 
            cmbMasterActivation38.FormattingEnabled = true;
            cmbMasterActivation38.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation38.Location = new Point(277, 16);
            cmbMasterActivation38.Name = "cmbMasterActivation38";
            cmbMasterActivation38.Size = new Size(68, 28);
            cmbMasterActivation38.TabIndex = 97;
            // 
            // btnRegWriteMemory38
            // 
            btnRegWriteMemory38.BackColor = Color.Red;
            btnRegWriteMemory38.Cursor = Cursors.Hand;
            btnRegWriteMemory38.ForeColor = Color.White;
            btnRegWriteMemory38.Location = new Point(982, 15);
            btnRegWriteMemory38.Name = "btnRegWriteMemory38";
            btnRegWriteMemory38.Size = new Size(112, 30);
            btnRegWriteMemory38.TabIndex = 95;
            btnRegWriteMemory38.Text = "Write Memory";
            btnRegWriteMemory38.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory38
            // 
            btnRegReadMemory38.BackColor = Color.DarkKhaki;
            btnRegReadMemory38.Cursor = Cursors.Hand;
            btnRegReadMemory38.ForeColor = Color.White;
            btnRegReadMemory38.Location = new Point(870, 15);
            btnRegReadMemory38.Name = "btnRegReadMemory38";
            btnRegReadMemory38.Size = new Size(112, 30);
            btnRegReadMemory38.TabIndex = 94;
            btnRegReadMemory38.Text = "Read Memory";
            btnRegReadMemory38.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor38
            // 
            txtMasterScaleFactor38.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor38.Location = new Point(740, 16);
            txtMasterScaleFactor38.MaxLength = 10;
            txtMasterScaleFactor38.Name = "txtMasterScaleFactor38";
            txtMasterScaleFactor38.Size = new Size(69, 27);
            txtMasterScaleFactor38.TabIndex = 93;
            // 
            // txtMasterName38
            // 
            txtMasterName38.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName38.Location = new Point(219, 16);
            txtMasterName38.MaxLength = 5;
            txtMasterName38.Name = "txtMasterName38";
            txtMasterName38.Size = new Size(53, 27);
            txtMasterName38.TabIndex = 92;
            // 
            // txtMasterRegStartAddress38
            // 
            txtMasterRegStartAddress38.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress38.Location = new Point(106, 16);
            txtMasterRegStartAddress38.MaxLength = 10;
            txtMasterRegStartAddress38.Name = "txtMasterRegStartAddress38";
            txtMasterRegStartAddress38.Size = new Size(110, 27);
            txtMasterRegStartAddress38.TabIndex = 91;
            // 
            // txtMasterRegIndex38
            // 
            txtMasterRegIndex38.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex38.Enabled = false;
            txtMasterRegIndex38.Location = new Point(25, 16);
            txtMasterRegIndex38.MaxLength = 2;
            txtMasterRegIndex38.Name = "txtMasterRegIndex38";
            txtMasterRegIndex38.Size = new Size(79, 27);
            txtMasterRegIndex38.TabIndex = 90;
            txtMasterRegIndex38.Text = "37";
            // 
            // groupBox48
            // 
            groupBox48.Controls.Add(cmbDecimalPoint36);
            groupBox48.Controls.Add(label228);
            groupBox48.Controls.Add(cmbMasterFunctionCode36);
            groupBox48.Controls.Add(cmbMasterByteOrder36);
            groupBox48.Controls.Add(cmbMasterDataType36);
            groupBox48.Controls.Add(cmbMasterActivation36);
            groupBox48.Controls.Add(btnRegWriteMemory36);
            groupBox48.Controls.Add(btnRegReadMemory36);
            groupBox48.Controls.Add(txtMasterScaleFactor36);
            groupBox48.Controls.Add(txtMasterName36);
            groupBox48.Controls.Add(txtMasterRegStartAddress36);
            groupBox48.Controls.Add(txtMasterRegIndex36);
            groupBox48.Location = new Point(-6, 1850);
            groupBox48.Name = "groupBox48";
            groupBox48.Size = new Size(1099, 51);
            groupBox48.TabIndex = 136;
            groupBox48.TabStop = false;
            // 
            // cmbDecimalPoint36
            // 
            cmbDecimalPoint36.FormattingEnabled = true;
            cmbDecimalPoint36.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint36.Location = new Point(815, 16);
            cmbDecimalPoint36.Name = "cmbDecimalPoint36";
            cmbDecimalPoint36.Size = new Size(55, 28);
            cmbDecimalPoint36.TabIndex = 135;
            // 
            // label228
            // 
            label228.AutoSize = true;
            label228.Location = new Point(0, 19);
            label228.Name = "label228";
            label228.Size = new Size(25, 20);
            label228.TabIndex = 125;
            label228.Text = "36";
            // 
            // cmbMasterFunctionCode36
            // 
            cmbMasterFunctionCode36.FormattingEnabled = true;
            cmbMasterFunctionCode36.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode36.Location = new Point(585, 16);
            cmbMasterFunctionCode36.Name = "cmbMasterFunctionCode36";
            cmbMasterFunctionCode36.Size = new Size(155, 28);
            cmbMasterFunctionCode36.TabIndex = 100;
            // 
            // cmbMasterByteOrder36
            // 
            cmbMasterByteOrder36.FormattingEnabled = true;
            cmbMasterByteOrder36.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder36.Location = new Point(488, 16);
            cmbMasterByteOrder36.Name = "cmbMasterByteOrder36";
            cmbMasterByteOrder36.Size = new Size(92, 28);
            cmbMasterByteOrder36.TabIndex = 99;
            // 
            // cmbMasterDataType36
            // 
            cmbMasterDataType36.FormattingEnabled = true;
            cmbMasterDataType36.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType36.Location = new Point(353, 16);
            cmbMasterDataType36.Name = "cmbMasterDataType36";
            cmbMasterDataType36.Size = new Size(130, 28);
            cmbMasterDataType36.TabIndex = 98;
            // 
            // cmbMasterActivation36
            // 
            cmbMasterActivation36.FormattingEnabled = true;
            cmbMasterActivation36.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation36.Location = new Point(281, 16);
            cmbMasterActivation36.Name = "cmbMasterActivation36";
            cmbMasterActivation36.Size = new Size(68, 28);
            cmbMasterActivation36.TabIndex = 97;
            // 
            // btnRegWriteMemory36
            // 
            btnRegWriteMemory36.BackColor = Color.Red;
            btnRegWriteMemory36.Cursor = Cursors.Hand;
            btnRegWriteMemory36.ForeColor = Color.White;
            btnRegWriteMemory36.Location = new Point(985, 15);
            btnRegWriteMemory36.Name = "btnRegWriteMemory36";
            btnRegWriteMemory36.Size = new Size(112, 30);
            btnRegWriteMemory36.TabIndex = 95;
            btnRegWriteMemory36.Text = "Write Memory";
            btnRegWriteMemory36.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory36
            // 
            btnRegReadMemory36.BackColor = Color.DarkKhaki;
            btnRegReadMemory36.Cursor = Cursors.Hand;
            btnRegReadMemory36.ForeColor = Color.White;
            btnRegReadMemory36.Location = new Point(873, 15);
            btnRegReadMemory36.Name = "btnRegReadMemory36";
            btnRegReadMemory36.Size = new Size(112, 30);
            btnRegReadMemory36.TabIndex = 94;
            btnRegReadMemory36.Text = "Read Memory";
            btnRegReadMemory36.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor36
            // 
            txtMasterScaleFactor36.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor36.Location = new Point(744, 16);
            txtMasterScaleFactor36.MaxLength = 10;
            txtMasterScaleFactor36.Name = "txtMasterScaleFactor36";
            txtMasterScaleFactor36.Size = new Size(69, 27);
            txtMasterScaleFactor36.TabIndex = 93;
            // 
            // txtMasterName36
            // 
            txtMasterName36.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName36.Location = new Point(222, 16);
            txtMasterName36.MaxLength = 5;
            txtMasterName36.Name = "txtMasterName36";
            txtMasterName36.Size = new Size(53, 27);
            txtMasterName36.TabIndex = 92;
            // 
            // txtMasterRegStartAddress36
            // 
            txtMasterRegStartAddress36.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress36.Location = new Point(109, 16);
            txtMasterRegStartAddress36.MaxLength = 10;
            txtMasterRegStartAddress36.Name = "txtMasterRegStartAddress36";
            txtMasterRegStartAddress36.Size = new Size(110, 27);
            txtMasterRegStartAddress36.TabIndex = 91;
            // 
            // txtMasterRegIndex36
            // 
            txtMasterRegIndex36.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex36.Enabled = false;
            txtMasterRegIndex36.Location = new Point(28, 16);
            txtMasterRegIndex36.MaxLength = 2;
            txtMasterRegIndex36.Name = "txtMasterRegIndex36";
            txtMasterRegIndex36.Size = new Size(79, 27);
            txtMasterRegIndex36.TabIndex = 90;
            txtMasterRegIndex36.Text = "35";
            // 
            // groupBox49
            // 
            groupBox49.Controls.Add(cmbDecimalPoint37);
            groupBox49.Controls.Add(label229);
            groupBox49.Controls.Add(cmbMasterFunctionCode37);
            groupBox49.Controls.Add(cmbMasterByteOrder37);
            groupBox49.Controls.Add(cmbMasterDataType37);
            groupBox49.Controls.Add(cmbMasterActivation37);
            groupBox49.Controls.Add(btnRegWriteMemory37);
            groupBox49.Controls.Add(btnRegReadMemory37);
            groupBox49.Controls.Add(txtMasterScaleFactor37);
            groupBox49.Controls.Add(txtMasterName37);
            groupBox49.Controls.Add(txtMasterRegStartAddress37);
            groupBox49.Controls.Add(txtMasterRegIndex37);
            groupBox49.Location = new Point(-9, 1903);
            groupBox49.Name = "groupBox49";
            groupBox49.Size = new Size(1101, 51);
            groupBox49.TabIndex = 135;
            groupBox49.TabStop = false;
            // 
            // cmbDecimalPoint37
            // 
            cmbDecimalPoint37.FormattingEnabled = true;
            cmbDecimalPoint37.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint37.Location = new Point(818, 16);
            cmbDecimalPoint37.Name = "cmbDecimalPoint37";
            cmbDecimalPoint37.Size = new Size(55, 28);
            cmbDecimalPoint37.TabIndex = 135;
            // 
            // label229
            // 
            label229.AutoSize = true;
            label229.Location = new Point(3, 19);
            label229.Name = "label229";
            label229.Size = new Size(25, 20);
            label229.TabIndex = 124;
            label229.Text = "37";
            // 
            // cmbMasterFunctionCode37
            // 
            cmbMasterFunctionCode37.FormattingEnabled = true;
            cmbMasterFunctionCode37.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode37.Location = new Point(586, 16);
            cmbMasterFunctionCode37.Name = "cmbMasterFunctionCode37";
            cmbMasterFunctionCode37.Size = new Size(155, 28);
            cmbMasterFunctionCode37.TabIndex = 100;
            // 
            // cmbMasterByteOrder37
            // 
            cmbMasterByteOrder37.FormattingEnabled = true;
            cmbMasterByteOrder37.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder37.Location = new Point(489, 16);
            cmbMasterByteOrder37.Name = "cmbMasterByteOrder37";
            cmbMasterByteOrder37.Size = new Size(92, 28);
            cmbMasterByteOrder37.TabIndex = 99;
            // 
            // cmbMasterDataType37
            // 
            cmbMasterDataType37.FormattingEnabled = true;
            cmbMasterDataType37.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType37.Location = new Point(354, 16);
            cmbMasterDataType37.Name = "cmbMasterDataType37";
            cmbMasterDataType37.Size = new Size(130, 28);
            cmbMasterDataType37.TabIndex = 98;
            // 
            // cmbMasterActivation37
            // 
            cmbMasterActivation37.FormattingEnabled = true;
            cmbMasterActivation37.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation37.Location = new Point(282, 16);
            cmbMasterActivation37.Name = "cmbMasterActivation37";
            cmbMasterActivation37.Size = new Size(68, 28);
            cmbMasterActivation37.TabIndex = 97;
            // 
            // btnRegWriteMemory37
            // 
            btnRegWriteMemory37.BackColor = Color.Red;
            btnRegWriteMemory37.Cursor = Cursors.Hand;
            btnRegWriteMemory37.ForeColor = Color.White;
            btnRegWriteMemory37.Location = new Point(986, 15);
            btnRegWriteMemory37.Name = "btnRegWriteMemory37";
            btnRegWriteMemory37.Size = new Size(112, 30);
            btnRegWriteMemory37.TabIndex = 95;
            btnRegWriteMemory37.Text = "Write Memory";
            btnRegWriteMemory37.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory37
            // 
            btnRegReadMemory37.BackColor = Color.DarkKhaki;
            btnRegReadMemory37.Cursor = Cursors.Hand;
            btnRegReadMemory37.ForeColor = Color.White;
            btnRegReadMemory37.Location = new Point(874, 15);
            btnRegReadMemory37.Name = "btnRegReadMemory37";
            btnRegReadMemory37.Size = new Size(112, 30);
            btnRegReadMemory37.TabIndex = 94;
            btnRegReadMemory37.Text = "Read Memory";
            btnRegReadMemory37.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor37
            // 
            txtMasterScaleFactor37.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor37.Location = new Point(745, 16);
            txtMasterScaleFactor37.MaxLength = 10;
            txtMasterScaleFactor37.Name = "txtMasterScaleFactor37";
            txtMasterScaleFactor37.Size = new Size(69, 27);
            txtMasterScaleFactor37.TabIndex = 93;
            // 
            // txtMasterName37
            // 
            txtMasterName37.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName37.Location = new Point(223, 16);
            txtMasterName37.MaxLength = 5;
            txtMasterName37.Name = "txtMasterName37";
            txtMasterName37.Size = new Size(53, 27);
            txtMasterName37.TabIndex = 92;
            // 
            // txtMasterRegStartAddress37
            // 
            txtMasterRegStartAddress37.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress37.Location = new Point(110, 16);
            txtMasterRegStartAddress37.MaxLength = 10;
            txtMasterRegStartAddress37.Name = "txtMasterRegStartAddress37";
            txtMasterRegStartAddress37.Size = new Size(110, 27);
            txtMasterRegStartAddress37.TabIndex = 91;
            // 
            // txtMasterRegIndex37
            // 
            txtMasterRegIndex37.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex37.Enabled = false;
            txtMasterRegIndex37.Location = new Point(29, 16);
            txtMasterRegIndex37.MaxLength = 2;
            txtMasterRegIndex37.Name = "txtMasterRegIndex37";
            txtMasterRegIndex37.Size = new Size(79, 27);
            txtMasterRegIndex37.TabIndex = 90;
            txtMasterRegIndex37.Text = "36";
            // 
            // groupBox50
            // 
            groupBox50.Controls.Add(cmbDecimalPoint35);
            groupBox50.Controls.Add(label230);
            groupBox50.Controls.Add(cmbMasterFunctionCode35);
            groupBox50.Controls.Add(cmbMasterByteOrder35);
            groupBox50.Controls.Add(cmbMasterDataType35);
            groupBox50.Controls.Add(cmbMasterActivation35);
            groupBox50.Controls.Add(btnRegWriteMemory35);
            groupBox50.Controls.Add(btnRegReadMemory35);
            groupBox50.Controls.Add(txtMasterScaleFactor35);
            groupBox50.Controls.Add(txtMasterName35);
            groupBox50.Controls.Add(txtMasterRegStartAddress35);
            groupBox50.Controls.Add(txtMasterRegIndex35);
            groupBox50.Location = new Point(-5, 1797);
            groupBox50.Name = "groupBox50";
            groupBox50.Size = new Size(1098, 51);
            groupBox50.TabIndex = 134;
            groupBox50.TabStop = false;
            // 
            // cmbDecimalPoint35
            // 
            cmbDecimalPoint35.FormattingEnabled = true;
            cmbDecimalPoint35.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint35.Location = new Point(816, 16);
            cmbDecimalPoint35.Name = "cmbDecimalPoint35";
            cmbDecimalPoint35.Size = new Size(55, 28);
            cmbDecimalPoint35.TabIndex = 135;
            // 
            // label230
            // 
            label230.AutoSize = true;
            label230.Location = new Point(-1, 19);
            label230.Name = "label230";
            label230.Size = new Size(25, 20);
            label230.TabIndex = 126;
            label230.Text = "35";
            // 
            // cmbMasterFunctionCode35
            // 
            cmbMasterFunctionCode35.FormattingEnabled = true;
            cmbMasterFunctionCode35.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode35.Location = new Point(586, 16);
            cmbMasterFunctionCode35.Name = "cmbMasterFunctionCode35";
            cmbMasterFunctionCode35.Size = new Size(155, 28);
            cmbMasterFunctionCode35.TabIndex = 100;
            // 
            // cmbMasterByteOrder35
            // 
            cmbMasterByteOrder35.FormattingEnabled = true;
            cmbMasterByteOrder35.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder35.Location = new Point(489, 16);
            cmbMasterByteOrder35.Name = "cmbMasterByteOrder35";
            cmbMasterByteOrder35.Size = new Size(92, 28);
            cmbMasterByteOrder35.TabIndex = 99;
            // 
            // cmbMasterDataType35
            // 
            cmbMasterDataType35.FormattingEnabled = true;
            cmbMasterDataType35.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType35.Location = new Point(354, 16);
            cmbMasterDataType35.Name = "cmbMasterDataType35";
            cmbMasterDataType35.Size = new Size(130, 28);
            cmbMasterDataType35.TabIndex = 98;
            // 
            // cmbMasterActivation35
            // 
            cmbMasterActivation35.FormattingEnabled = true;
            cmbMasterActivation35.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation35.Location = new Point(282, 16);
            cmbMasterActivation35.Name = "cmbMasterActivation35";
            cmbMasterActivation35.Size = new Size(68, 28);
            cmbMasterActivation35.TabIndex = 97;
            // 
            // btnRegWriteMemory35
            // 
            btnRegWriteMemory35.BackColor = Color.Red;
            btnRegWriteMemory35.Cursor = Cursors.Hand;
            btnRegWriteMemory35.ForeColor = Color.White;
            btnRegWriteMemory35.Location = new Point(985, 15);
            btnRegWriteMemory35.Name = "btnRegWriteMemory35";
            btnRegWriteMemory35.Size = new Size(112, 30);
            btnRegWriteMemory35.TabIndex = 95;
            btnRegWriteMemory35.Text = "Write Memory";
            btnRegWriteMemory35.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory35
            // 
            btnRegReadMemory35.BackColor = Color.DarkKhaki;
            btnRegReadMemory35.Cursor = Cursors.Hand;
            btnRegReadMemory35.ForeColor = Color.White;
            btnRegReadMemory35.Location = new Point(873, 15);
            btnRegReadMemory35.Name = "btnRegReadMemory35";
            btnRegReadMemory35.Size = new Size(112, 30);
            btnRegReadMemory35.TabIndex = 94;
            btnRegReadMemory35.Text = "Read Memory";
            btnRegReadMemory35.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor35
            // 
            txtMasterScaleFactor35.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor35.Location = new Point(745, 16);
            txtMasterScaleFactor35.MaxLength = 10;
            txtMasterScaleFactor35.Name = "txtMasterScaleFactor35";
            txtMasterScaleFactor35.Size = new Size(69, 27);
            txtMasterScaleFactor35.TabIndex = 93;
            // 
            // txtMasterName35
            // 
            txtMasterName35.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName35.Location = new Point(222, 16);
            txtMasterName35.MaxLength = 5;
            txtMasterName35.Name = "txtMasterName35";
            txtMasterName35.Size = new Size(53, 27);
            txtMasterName35.TabIndex = 92;
            // 
            // txtMasterRegStartAddress35
            // 
            txtMasterRegStartAddress35.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress35.Location = new Point(109, 16);
            txtMasterRegStartAddress35.MaxLength = 10;
            txtMasterRegStartAddress35.Name = "txtMasterRegStartAddress35";
            txtMasterRegStartAddress35.Size = new Size(110, 27);
            txtMasterRegStartAddress35.TabIndex = 91;
            // 
            // txtMasterRegIndex35
            // 
            txtMasterRegIndex35.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex35.Enabled = false;
            txtMasterRegIndex35.Location = new Point(28, 16);
            txtMasterRegIndex35.MaxLength = 2;
            txtMasterRegIndex35.Name = "txtMasterRegIndex35";
            txtMasterRegIndex35.Size = new Size(79, 27);
            txtMasterRegIndex35.TabIndex = 90;
            txtMasterRegIndex35.Text = "34";
            // 
            // groupBox51
            // 
            groupBox51.Controls.Add(cmbDecimalPoint34);
            groupBox51.Controls.Add(label231);
            groupBox51.Controls.Add(cmbMasterFunctionCode34);
            groupBox51.Controls.Add(cmbMasterByteOrder34);
            groupBox51.Controls.Add(cmbMasterDataType34);
            groupBox51.Controls.Add(cmbMasterActivation34);
            groupBox51.Controls.Add(btnRegWriteMemory34);
            groupBox51.Controls.Add(btnRegReadMemory34);
            groupBox51.Controls.Add(txtMasterScaleFactor34);
            groupBox51.Controls.Add(txtMasterName34);
            groupBox51.Controls.Add(txtMasterRegStartAddress34);
            groupBox51.Controls.Add(txtMasterRegIndex34);
            groupBox51.Location = new Point(-5, 1745);
            groupBox51.Name = "groupBox51";
            groupBox51.Size = new Size(1097, 51);
            groupBox51.TabIndex = 133;
            groupBox51.TabStop = false;
            // 
            // cmbDecimalPoint34
            // 
            cmbDecimalPoint34.FormattingEnabled = true;
            cmbDecimalPoint34.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint34.Location = new Point(817, 15);
            cmbDecimalPoint34.Name = "cmbDecimalPoint34";
            cmbDecimalPoint34.Size = new Size(55, 28);
            cmbDecimalPoint34.TabIndex = 135;
            // 
            // label231
            // 
            label231.AutoSize = true;
            label231.Location = new Point(0, 20);
            label231.Name = "label231";
            label231.Size = new Size(25, 20);
            label231.TabIndex = 127;
            label231.Text = "34";
            // 
            // cmbMasterFunctionCode34
            // 
            cmbMasterFunctionCode34.FormattingEnabled = true;
            cmbMasterFunctionCode34.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode34.Location = new Point(586, 16);
            cmbMasterFunctionCode34.Name = "cmbMasterFunctionCode34";
            cmbMasterFunctionCode34.Size = new Size(155, 28);
            cmbMasterFunctionCode34.TabIndex = 100;
            // 
            // cmbMasterByteOrder34
            // 
            cmbMasterByteOrder34.FormattingEnabled = true;
            cmbMasterByteOrder34.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder34.Location = new Point(489, 16);
            cmbMasterByteOrder34.Name = "cmbMasterByteOrder34";
            cmbMasterByteOrder34.Size = new Size(92, 28);
            cmbMasterByteOrder34.TabIndex = 99;
            // 
            // cmbMasterDataType34
            // 
            cmbMasterDataType34.FormattingEnabled = true;
            cmbMasterDataType34.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType34.Location = new Point(354, 16);
            cmbMasterDataType34.Name = "cmbMasterDataType34";
            cmbMasterDataType34.Size = new Size(130, 28);
            cmbMasterDataType34.TabIndex = 98;
            // 
            // cmbMasterActivation34
            // 
            cmbMasterActivation34.FormattingEnabled = true;
            cmbMasterActivation34.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation34.Location = new Point(282, 16);
            cmbMasterActivation34.Name = "cmbMasterActivation34";
            cmbMasterActivation34.Size = new Size(68, 28);
            cmbMasterActivation34.TabIndex = 97;
            // 
            // btnRegWriteMemory34
            // 
            btnRegWriteMemory34.BackColor = Color.Red;
            btnRegWriteMemory34.Cursor = Cursors.Hand;
            btnRegWriteMemory34.ForeColor = Color.White;
            btnRegWriteMemory34.Location = new Point(986, 15);
            btnRegWriteMemory34.Name = "btnRegWriteMemory34";
            btnRegWriteMemory34.Size = new Size(112, 30);
            btnRegWriteMemory34.TabIndex = 95;
            btnRegWriteMemory34.Text = "Write Memory";
            btnRegWriteMemory34.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory34
            // 
            btnRegReadMemory34.BackColor = Color.DarkKhaki;
            btnRegReadMemory34.Cursor = Cursors.Hand;
            btnRegReadMemory34.ForeColor = Color.White;
            btnRegReadMemory34.Location = new Point(874, 15);
            btnRegReadMemory34.Name = "btnRegReadMemory34";
            btnRegReadMemory34.Size = new Size(112, 30);
            btnRegReadMemory34.TabIndex = 94;
            btnRegReadMemory34.Text = "Read Memory";
            btnRegReadMemory34.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor34
            // 
            txtMasterScaleFactor34.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor34.Location = new Point(745, 16);
            txtMasterScaleFactor34.MaxLength = 10;
            txtMasterScaleFactor34.Name = "txtMasterScaleFactor34";
            txtMasterScaleFactor34.Size = new Size(69, 27);
            txtMasterScaleFactor34.TabIndex = 93;
            // 
            // txtMasterName34
            // 
            txtMasterName34.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName34.Location = new Point(223, 16);
            txtMasterName34.MaxLength = 5;
            txtMasterName34.Name = "txtMasterName34";
            txtMasterName34.Size = new Size(53, 27);
            txtMasterName34.TabIndex = 92;
            // 
            // txtMasterRegStartAddress34
            // 
            txtMasterRegStartAddress34.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress34.Location = new Point(110, 16);
            txtMasterRegStartAddress34.MaxLength = 10;
            txtMasterRegStartAddress34.Name = "txtMasterRegStartAddress34";
            txtMasterRegStartAddress34.Size = new Size(110, 27);
            txtMasterRegStartAddress34.TabIndex = 91;
            // 
            // txtMasterRegIndex34
            // 
            txtMasterRegIndex34.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex34.Enabled = false;
            txtMasterRegIndex34.Location = new Point(29, 16);
            txtMasterRegIndex34.MaxLength = 2;
            txtMasterRegIndex34.Name = "txtMasterRegIndex34";
            txtMasterRegIndex34.Size = new Size(79, 27);
            txtMasterRegIndex34.TabIndex = 90;
            txtMasterRegIndex34.Text = "33";
            // 
            // groupBox52
            // 
            groupBox52.Controls.Add(cmbDecimalPoint33);
            groupBox52.Controls.Add(label232);
            groupBox52.Controls.Add(cmbMasterFunctionCode33);
            groupBox52.Controls.Add(cmbMasterByteOrder33);
            groupBox52.Controls.Add(cmbMasterDataType33);
            groupBox52.Controls.Add(cmbMasterActivation33);
            groupBox52.Controls.Add(btnRegWriteMemory33);
            groupBox52.Controls.Add(btnRegReadMemory33);
            groupBox52.Controls.Add(txtMasterScaleFactor33);
            groupBox52.Controls.Add(txtMasterName33);
            groupBox52.Controls.Add(txtMasterRegStartAddress33);
            groupBox52.Controls.Add(txtMasterRegIndex33);
            groupBox52.Location = new Point(-5, 1692);
            groupBox52.Name = "groupBox52";
            groupBox52.Size = new Size(1097, 51);
            groupBox52.TabIndex = 132;
            groupBox52.TabStop = false;
            // 
            // cmbDecimalPoint33
            // 
            cmbDecimalPoint33.FormattingEnabled = true;
            cmbDecimalPoint33.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint33.Location = new Point(816, 16);
            cmbDecimalPoint33.Name = "cmbDecimalPoint33";
            cmbDecimalPoint33.Size = new Size(55, 28);
            cmbDecimalPoint33.TabIndex = 135;
            // 
            // label232
            // 
            label232.AutoSize = true;
            label232.Location = new Point(0, 19);
            label232.Name = "label232";
            label232.Size = new Size(25, 20);
            label232.TabIndex = 128;
            label232.Text = "33";
            // 
            // cmbMasterFunctionCode33
            // 
            cmbMasterFunctionCode33.FormattingEnabled = true;
            cmbMasterFunctionCode33.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode33.Location = new Point(584, 16);
            cmbMasterFunctionCode33.Name = "cmbMasterFunctionCode33";
            cmbMasterFunctionCode33.Size = new Size(155, 28);
            cmbMasterFunctionCode33.TabIndex = 100;
            // 
            // cmbMasterByteOrder33
            // 
            cmbMasterByteOrder33.FormattingEnabled = true;
            cmbMasterByteOrder33.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder33.Location = new Point(487, 16);
            cmbMasterByteOrder33.Name = "cmbMasterByteOrder33";
            cmbMasterByteOrder33.Size = new Size(92, 28);
            cmbMasterByteOrder33.TabIndex = 99;
            // 
            // cmbMasterDataType33
            // 
            cmbMasterDataType33.FormattingEnabled = true;
            cmbMasterDataType33.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType33.Location = new Point(352, 16);
            cmbMasterDataType33.Name = "cmbMasterDataType33";
            cmbMasterDataType33.Size = new Size(130, 28);
            cmbMasterDataType33.TabIndex = 98;
            // 
            // cmbMasterActivation33
            // 
            cmbMasterActivation33.FormattingEnabled = true;
            cmbMasterActivation33.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation33.Location = new Point(280, 16);
            cmbMasterActivation33.Name = "cmbMasterActivation33";
            cmbMasterActivation33.Size = new Size(68, 28);
            cmbMasterActivation33.TabIndex = 97;
            // 
            // btnRegWriteMemory33
            // 
            btnRegWriteMemory33.BackColor = Color.Red;
            btnRegWriteMemory33.Cursor = Cursors.Hand;
            btnRegWriteMemory33.ForeColor = Color.White;
            btnRegWriteMemory33.Location = new Point(984, 15);
            btnRegWriteMemory33.Name = "btnRegWriteMemory33";
            btnRegWriteMemory33.Size = new Size(112, 30);
            btnRegWriteMemory33.TabIndex = 95;
            btnRegWriteMemory33.Text = "Write Memory";
            btnRegWriteMemory33.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory33
            // 
            btnRegReadMemory33.BackColor = Color.DarkKhaki;
            btnRegReadMemory33.Cursor = Cursors.Hand;
            btnRegReadMemory33.ForeColor = Color.White;
            btnRegReadMemory33.Location = new Point(872, 15);
            btnRegReadMemory33.Name = "btnRegReadMemory33";
            btnRegReadMemory33.Size = new Size(112, 30);
            btnRegReadMemory33.TabIndex = 94;
            btnRegReadMemory33.Text = "Read Memory";
            btnRegReadMemory33.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor33
            // 
            txtMasterScaleFactor33.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor33.Location = new Point(743, 16);
            txtMasterScaleFactor33.MaxLength = 10;
            txtMasterScaleFactor33.Name = "txtMasterScaleFactor33";
            txtMasterScaleFactor33.Size = new Size(69, 27);
            txtMasterScaleFactor33.TabIndex = 93;
            // 
            // txtMasterName33
            // 
            txtMasterName33.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName33.Location = new Point(221, 16);
            txtMasterName33.MaxLength = 5;
            txtMasterName33.Name = "txtMasterName33";
            txtMasterName33.Size = new Size(53, 27);
            txtMasterName33.TabIndex = 92;
            // 
            // txtMasterRegStartAddress33
            // 
            txtMasterRegStartAddress33.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress33.Location = new Point(108, 16);
            txtMasterRegStartAddress33.MaxLength = 10;
            txtMasterRegStartAddress33.Name = "txtMasterRegStartAddress33";
            txtMasterRegStartAddress33.Size = new Size(110, 27);
            txtMasterRegStartAddress33.TabIndex = 91;
            // 
            // txtMasterRegIndex33
            // 
            txtMasterRegIndex33.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex33.Enabled = false;
            txtMasterRegIndex33.Location = new Point(27, 16);
            txtMasterRegIndex33.MaxLength = 2;
            txtMasterRegIndex33.Name = "txtMasterRegIndex33";
            txtMasterRegIndex33.Size = new Size(79, 27);
            txtMasterRegIndex33.TabIndex = 90;
            txtMasterRegIndex33.Text = "32";
            // 
            // groupBox53
            // 
            groupBox53.Controls.Add(cmbDecimalPoint31);
            groupBox53.Controls.Add(label233);
            groupBox53.Controls.Add(cmbMasterFunctionCode31);
            groupBox53.Controls.Add(cmbMasterByteOrder31);
            groupBox53.Controls.Add(cmbMasterDataType31);
            groupBox53.Controls.Add(cmbMasterActivation31);
            groupBox53.Controls.Add(btnRegWriteMemory31);
            groupBox53.Controls.Add(btnRegReadMemory31);
            groupBox53.Controls.Add(txtMasterScaleFactor31);
            groupBox53.Controls.Add(txtMasterName31);
            groupBox53.Controls.Add(txtMasterRegStartAddress31);
            groupBox53.Controls.Add(txtMasterRegIndex31);
            groupBox53.Location = new Point(-7, 1586);
            groupBox53.Name = "groupBox53";
            groupBox53.Size = new Size(1100, 51);
            groupBox53.TabIndex = 131;
            groupBox53.TabStop = false;
            // 
            // cmbDecimalPoint31
            // 
            cmbDecimalPoint31.FormattingEnabled = true;
            cmbDecimalPoint31.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint31.Location = new Point(817, 17);
            cmbDecimalPoint31.Name = "cmbDecimalPoint31";
            cmbDecimalPoint31.Size = new Size(55, 28);
            cmbDecimalPoint31.TabIndex = 133;
            // 
            // label233
            // 
            label233.AutoSize = true;
            label233.Location = new Point(2, 20);
            label233.Name = "label233";
            label233.Size = new Size(25, 20);
            label233.TabIndex = 130;
            label233.Text = "31";
            // 
            // cmbMasterFunctionCode31
            // 
            cmbMasterFunctionCode31.FormattingEnabled = true;
            cmbMasterFunctionCode31.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode31.Location = new Point(584, 16);
            cmbMasterFunctionCode31.Name = "cmbMasterFunctionCode31";
            cmbMasterFunctionCode31.Size = new Size(155, 28);
            cmbMasterFunctionCode31.TabIndex = 100;
            // 
            // cmbMasterByteOrder31
            // 
            cmbMasterByteOrder31.FormattingEnabled = true;
            cmbMasterByteOrder31.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder31.Location = new Point(487, 16);
            cmbMasterByteOrder31.Name = "cmbMasterByteOrder31";
            cmbMasterByteOrder31.Size = new Size(92, 28);
            cmbMasterByteOrder31.TabIndex = 99;
            // 
            // cmbMasterDataType31
            // 
            cmbMasterDataType31.FormattingEnabled = true;
            cmbMasterDataType31.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType31.Location = new Point(352, 16);
            cmbMasterDataType31.Name = "cmbMasterDataType31";
            cmbMasterDataType31.Size = new Size(130, 28);
            cmbMasterDataType31.TabIndex = 98;
            // 
            // cmbMasterActivation31
            // 
            cmbMasterActivation31.FormattingEnabled = true;
            cmbMasterActivation31.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation31.Location = new Point(280, 16);
            cmbMasterActivation31.Name = "cmbMasterActivation31";
            cmbMasterActivation31.Size = new Size(68, 28);
            cmbMasterActivation31.TabIndex = 97;
            // 
            // btnRegWriteMemory31
            // 
            btnRegWriteMemory31.BackColor = Color.Red;
            btnRegWriteMemory31.Cursor = Cursors.Hand;
            btnRegWriteMemory31.ForeColor = Color.White;
            btnRegWriteMemory31.Location = new Point(986, 15);
            btnRegWriteMemory31.Name = "btnRegWriteMemory31";
            btnRegWriteMemory31.Size = new Size(112, 30);
            btnRegWriteMemory31.TabIndex = 95;
            btnRegWriteMemory31.Text = "Write Memory";
            btnRegWriteMemory31.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory31
            // 
            btnRegReadMemory31.BackColor = Color.DarkKhaki;
            btnRegReadMemory31.Cursor = Cursors.Hand;
            btnRegReadMemory31.ForeColor = Color.White;
            btnRegReadMemory31.Location = new Point(874, 15);
            btnRegReadMemory31.Name = "btnRegReadMemory31";
            btnRegReadMemory31.Size = new Size(112, 30);
            btnRegReadMemory31.TabIndex = 94;
            btnRegReadMemory31.Text = "Read Memory";
            btnRegReadMemory31.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor31
            // 
            txtMasterScaleFactor31.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor31.Location = new Point(743, 16);
            txtMasterScaleFactor31.MaxLength = 10;
            txtMasterScaleFactor31.Name = "txtMasterScaleFactor31";
            txtMasterScaleFactor31.Size = new Size(69, 27);
            txtMasterScaleFactor31.TabIndex = 93;
            // 
            // txtMasterName31
            // 
            txtMasterName31.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName31.Location = new Point(223, 16);
            txtMasterName31.MaxLength = 5;
            txtMasterName31.Name = "txtMasterName31";
            txtMasterName31.Size = new Size(53, 27);
            txtMasterName31.TabIndex = 92;
            // 
            // txtMasterRegStartAddress31
            // 
            txtMasterRegStartAddress31.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress31.Location = new Point(110, 16);
            txtMasterRegStartAddress31.MaxLength = 10;
            txtMasterRegStartAddress31.Name = "txtMasterRegStartAddress31";
            txtMasterRegStartAddress31.Size = new Size(110, 27);
            txtMasterRegStartAddress31.TabIndex = 91;
            // 
            // txtMasterRegIndex31
            // 
            txtMasterRegIndex31.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex31.Enabled = false;
            txtMasterRegIndex31.Location = new Point(29, 16);
            txtMasterRegIndex31.MaxLength = 2;
            txtMasterRegIndex31.Name = "txtMasterRegIndex31";
            txtMasterRegIndex31.Size = new Size(79, 27);
            txtMasterRegIndex31.TabIndex = 90;
            txtMasterRegIndex31.Text = "30";
            // 
            // groupBox54
            // 
            groupBox54.Controls.Add(cmbDecimalPoint22);
            groupBox54.Controls.Add(label234);
            groupBox54.Controls.Add(cmbMasterFunctionCode22);
            groupBox54.Controls.Add(cmbMasterByteOrder22);
            groupBox54.Controls.Add(cmbMasterDataType22);
            groupBox54.Controls.Add(cmbMasterActivation22);
            groupBox54.Controls.Add(btnRegWriteMemory22);
            groupBox54.Controls.Add(btnRegReadMemory22);
            groupBox54.Controls.Add(txtMasterScaleFactor22);
            groupBox54.Controls.Add(txtMasterName22);
            groupBox54.Controls.Add(txtMasterRegStartAddress22);
            groupBox54.Controls.Add(txtMasterRegIndex22);
            groupBox54.Location = new Point(-5, 1113);
            groupBox54.Name = "groupBox54";
            groupBox54.Size = new Size(1098, 51);
            groupBox54.TabIndex = 130;
            groupBox54.TabStop = false;
            // 
            // cmbDecimalPoint22
            // 
            cmbDecimalPoint22.FormattingEnabled = true;
            cmbDecimalPoint22.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint22.Location = new Point(816, 15);
            cmbDecimalPoint22.Name = "cmbDecimalPoint22";
            cmbDecimalPoint22.Size = new Size(55, 28);
            cmbDecimalPoint22.TabIndex = 140;
            // 
            // label234
            // 
            label234.AutoSize = true;
            label234.Location = new Point(3, 19);
            label234.Name = "label234";
            label234.Size = new Size(25, 20);
            label234.TabIndex = 139;
            label234.Text = "22";
            // 
            // cmbMasterFunctionCode22
            // 
            cmbMasterFunctionCode22.FormattingEnabled = true;
            cmbMasterFunctionCode22.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode22.Location = new Point(585, 16);
            cmbMasterFunctionCode22.Name = "cmbMasterFunctionCode22";
            cmbMasterFunctionCode22.Size = new Size(155, 28);
            cmbMasterFunctionCode22.TabIndex = 100;
            // 
            // cmbMasterByteOrder22
            // 
            cmbMasterByteOrder22.FormattingEnabled = true;
            cmbMasterByteOrder22.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder22.Location = new Point(488, 16);
            cmbMasterByteOrder22.Name = "cmbMasterByteOrder22";
            cmbMasterByteOrder22.Size = new Size(92, 28);
            cmbMasterByteOrder22.TabIndex = 99;
            // 
            // cmbMasterDataType22
            // 
            cmbMasterDataType22.FormattingEnabled = true;
            cmbMasterDataType22.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType22.Location = new Point(353, 16);
            cmbMasterDataType22.Name = "cmbMasterDataType22";
            cmbMasterDataType22.Size = new Size(130, 28);
            cmbMasterDataType22.TabIndex = 98;
            // 
            // cmbMasterActivation22
            // 
            cmbMasterActivation22.FormattingEnabled = true;
            cmbMasterActivation22.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation22.Location = new Point(281, 16);
            cmbMasterActivation22.Name = "cmbMasterActivation22";
            cmbMasterActivation22.Size = new Size(68, 28);
            cmbMasterActivation22.TabIndex = 97;
            // 
            // btnRegWriteMemory22
            // 
            btnRegWriteMemory22.BackColor = Color.Red;
            btnRegWriteMemory22.Cursor = Cursors.Hand;
            btnRegWriteMemory22.ForeColor = Color.White;
            btnRegWriteMemory22.Location = new Point(986, 15);
            btnRegWriteMemory22.Name = "btnRegWriteMemory22";
            btnRegWriteMemory22.Size = new Size(112, 30);
            btnRegWriteMemory22.TabIndex = 95;
            btnRegWriteMemory22.Text = "Write Memory";
            btnRegWriteMemory22.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory22
            // 
            btnRegReadMemory22.BackColor = Color.DarkKhaki;
            btnRegReadMemory22.Cursor = Cursors.Hand;
            btnRegReadMemory22.ForeColor = Color.White;
            btnRegReadMemory22.Location = new Point(874, 15);
            btnRegReadMemory22.Name = "btnRegReadMemory22";
            btnRegReadMemory22.Size = new Size(112, 30);
            btnRegReadMemory22.TabIndex = 94;
            btnRegReadMemory22.Text = "Read Memory";
            btnRegReadMemory22.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor22
            // 
            txtMasterScaleFactor22.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor22.Location = new Point(744, 16);
            txtMasterScaleFactor22.MaxLength = 10;
            txtMasterScaleFactor22.Name = "txtMasterScaleFactor22";
            txtMasterScaleFactor22.Size = new Size(69, 27);
            txtMasterScaleFactor22.TabIndex = 93;
            // 
            // txtMasterName22
            // 
            txtMasterName22.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName22.Location = new Point(223, 16);
            txtMasterName22.MaxLength = 5;
            txtMasterName22.Name = "txtMasterName22";
            txtMasterName22.Size = new Size(53, 27);
            txtMasterName22.TabIndex = 92;
            // 
            // txtMasterRegStartAddress22
            // 
            txtMasterRegStartAddress22.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress22.Location = new Point(110, 16);
            txtMasterRegStartAddress22.MaxLength = 10;
            txtMasterRegStartAddress22.Name = "txtMasterRegStartAddress22";
            txtMasterRegStartAddress22.Size = new Size(110, 27);
            txtMasterRegStartAddress22.TabIndex = 91;
            // 
            // txtMasterRegIndex22
            // 
            txtMasterRegIndex22.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex22.Enabled = false;
            txtMasterRegIndex22.Location = new Point(29, 16);
            txtMasterRegIndex22.MaxLength = 2;
            txtMasterRegIndex22.Name = "txtMasterRegIndex22";
            txtMasterRegIndex22.Size = new Size(79, 27);
            txtMasterRegIndex22.TabIndex = 90;
            txtMasterRegIndex22.Text = "21";
            // 
            // groupBox55
            // 
            groupBox55.Controls.Add(cmbDecimalPoint30);
            groupBox55.Controls.Add(label235);
            groupBox55.Controls.Add(cmbMasterFunctionCode30);
            groupBox55.Controls.Add(cmbMasterByteOrder30);
            groupBox55.Controls.Add(cmbMasterDataType30);
            groupBox55.Controls.Add(cmbMasterActivation30);
            groupBox55.Controls.Add(btnRegWriteMemory30);
            groupBox55.Controls.Add(btnRegReadMemory30);
            groupBox55.Controls.Add(txtMasterScaleFactor30);
            groupBox55.Controls.Add(txtMasterName30);
            groupBox55.Controls.Add(txtMasterRegStartAddress30);
            groupBox55.Controls.Add(txtMasterRegIndex30);
            groupBox55.Location = new Point(-6, 1533);
            groupBox55.Name = "groupBox55";
            groupBox55.Size = new Size(1097, 51);
            groupBox55.TabIndex = 129;
            groupBox55.TabStop = false;
            // 
            // cmbDecimalPoint30
            // 
            cmbDecimalPoint30.FormattingEnabled = true;
            cmbDecimalPoint30.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint30.Location = new Point(816, 15);
            cmbDecimalPoint30.Name = "cmbDecimalPoint30";
            cmbDecimalPoint30.Size = new Size(55, 28);
            cmbDecimalPoint30.TabIndex = 132;
            // 
            // label235
            // 
            label235.AutoSize = true;
            label235.Location = new Point(2, 19);
            label235.Name = "label235";
            label235.Size = new Size(25, 20);
            label235.TabIndex = 131;
            label235.Text = "30";
            // 
            // cmbMasterFunctionCode30
            // 
            cmbMasterFunctionCode30.FormattingEnabled = true;
            cmbMasterFunctionCode30.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode30.Location = new Point(584, 16);
            cmbMasterFunctionCode30.Name = "cmbMasterFunctionCode30";
            cmbMasterFunctionCode30.Size = new Size(155, 28);
            cmbMasterFunctionCode30.TabIndex = 100;
            // 
            // cmbMasterByteOrder30
            // 
            cmbMasterByteOrder30.FormattingEnabled = true;
            cmbMasterByteOrder30.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder30.Location = new Point(487, 16);
            cmbMasterByteOrder30.Name = "cmbMasterByteOrder30";
            cmbMasterByteOrder30.Size = new Size(92, 28);
            cmbMasterByteOrder30.TabIndex = 99;
            // 
            // cmbMasterDataType30
            // 
            cmbMasterDataType30.FormattingEnabled = true;
            cmbMasterDataType30.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType30.Location = new Point(352, 16);
            cmbMasterDataType30.Name = "cmbMasterDataType30";
            cmbMasterDataType30.Size = new Size(130, 28);
            cmbMasterDataType30.TabIndex = 98;
            // 
            // cmbMasterActivation30
            // 
            cmbMasterActivation30.FormattingEnabled = true;
            cmbMasterActivation30.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation30.Location = new Point(280, 16);
            cmbMasterActivation30.Name = "cmbMasterActivation30";
            cmbMasterActivation30.Size = new Size(68, 28);
            cmbMasterActivation30.TabIndex = 97;
            // 
            // btnRegWriteMemory30
            // 
            btnRegWriteMemory30.BackColor = Color.Red;
            btnRegWriteMemory30.Cursor = Cursors.Hand;
            btnRegWriteMemory30.ForeColor = Color.White;
            btnRegWriteMemory30.Location = new Point(985, 15);
            btnRegWriteMemory30.Name = "btnRegWriteMemory30";
            btnRegWriteMemory30.Size = new Size(112, 30);
            btnRegWriteMemory30.TabIndex = 95;
            btnRegWriteMemory30.Text = "Write Memory";
            btnRegWriteMemory30.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory30
            // 
            btnRegReadMemory30.BackColor = Color.DarkKhaki;
            btnRegReadMemory30.Cursor = Cursors.Hand;
            btnRegReadMemory30.ForeColor = Color.White;
            btnRegReadMemory30.Location = new Point(873, 15);
            btnRegReadMemory30.Name = "btnRegReadMemory30";
            btnRegReadMemory30.Size = new Size(112, 30);
            btnRegReadMemory30.TabIndex = 94;
            btnRegReadMemory30.Text = "Read Memory";
            btnRegReadMemory30.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor30
            // 
            txtMasterScaleFactor30.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor30.Location = new Point(743, 16);
            txtMasterScaleFactor30.MaxLength = 10;
            txtMasterScaleFactor30.Name = "txtMasterScaleFactor30";
            txtMasterScaleFactor30.Size = new Size(69, 27);
            txtMasterScaleFactor30.TabIndex = 93;
            // 
            // txtMasterName30
            // 
            txtMasterName30.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName30.Location = new Point(222, 16);
            txtMasterName30.MaxLength = 5;
            txtMasterName30.Name = "txtMasterName30";
            txtMasterName30.Size = new Size(53, 27);
            txtMasterName30.TabIndex = 92;
            // 
            // txtMasterRegStartAddress30
            // 
            txtMasterRegStartAddress30.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress30.Location = new Point(109, 16);
            txtMasterRegStartAddress30.MaxLength = 10;
            txtMasterRegStartAddress30.Name = "txtMasterRegStartAddress30";
            txtMasterRegStartAddress30.Size = new Size(110, 27);
            txtMasterRegStartAddress30.TabIndex = 91;
            // 
            // txtMasterRegIndex30
            // 
            txtMasterRegIndex30.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex30.Enabled = false;
            txtMasterRegIndex30.Location = new Point(28, 16);
            txtMasterRegIndex30.MaxLength = 2;
            txtMasterRegIndex30.Name = "txtMasterRegIndex30";
            txtMasterRegIndex30.Size = new Size(79, 27);
            txtMasterRegIndex30.TabIndex = 90;
            txtMasterRegIndex30.Text = "29";
            // 
            // groupBox56
            // 
            groupBox56.Controls.Add(cmbDecimalPoint29);
            groupBox56.Controls.Add(label236);
            groupBox56.Controls.Add(cmbMasterFunctionCode29);
            groupBox56.Controls.Add(cmbMasterByteOrder29);
            groupBox56.Controls.Add(cmbMasterDataType29);
            groupBox56.Controls.Add(cmbMasterActivation29);
            groupBox56.Controls.Add(btnRegWriteMemory29);
            groupBox56.Controls.Add(btnRegReadMemory29);
            groupBox56.Controls.Add(txtMasterScaleFactor29);
            groupBox56.Controls.Add(txtMasterName29);
            groupBox56.Controls.Add(txtMasterRegStartAddress29);
            groupBox56.Controls.Add(txtMasterRegIndex29);
            groupBox56.Location = new Point(-6, 1481);
            groupBox56.Name = "groupBox56";
            groupBox56.Size = new Size(1097, 51);
            groupBox56.TabIndex = 128;
            groupBox56.TabStop = false;
            // 
            // cmbDecimalPoint29
            // 
            cmbDecimalPoint29.FormattingEnabled = true;
            cmbDecimalPoint29.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint29.Location = new Point(816, 15);
            cmbDecimalPoint29.Name = "cmbDecimalPoint29";
            cmbDecimalPoint29.Size = new Size(55, 28);
            cmbDecimalPoint29.TabIndex = 141;
            // 
            // label236
            // 
            label236.AutoSize = true;
            label236.Location = new Point(2, 19);
            label236.Name = "label236";
            label236.Size = new Size(25, 20);
            label236.TabIndex = 132;
            label236.Text = "29";
            // 
            // cmbMasterFunctionCode29
            // 
            cmbMasterFunctionCode29.FormattingEnabled = true;
            cmbMasterFunctionCode29.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode29.Location = new Point(584, 16);
            cmbMasterFunctionCode29.Name = "cmbMasterFunctionCode29";
            cmbMasterFunctionCode29.Size = new Size(155, 28);
            cmbMasterFunctionCode29.TabIndex = 100;
            // 
            // cmbMasterByteOrder29
            // 
            cmbMasterByteOrder29.FormattingEnabled = true;
            cmbMasterByteOrder29.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder29.Location = new Point(487, 16);
            cmbMasterByteOrder29.Name = "cmbMasterByteOrder29";
            cmbMasterByteOrder29.Size = new Size(92, 28);
            cmbMasterByteOrder29.TabIndex = 99;
            // 
            // cmbMasterDataType29
            // 
            cmbMasterDataType29.FormattingEnabled = true;
            cmbMasterDataType29.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType29.Location = new Point(352, 16);
            cmbMasterDataType29.Name = "cmbMasterDataType29";
            cmbMasterDataType29.Size = new Size(130, 28);
            cmbMasterDataType29.TabIndex = 98;
            // 
            // cmbMasterActivation29
            // 
            cmbMasterActivation29.FormattingEnabled = true;
            cmbMasterActivation29.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation29.Location = new Point(280, 16);
            cmbMasterActivation29.Name = "cmbMasterActivation29";
            cmbMasterActivation29.Size = new Size(68, 28);
            cmbMasterActivation29.TabIndex = 97;
            // 
            // btnRegWriteMemory29
            // 
            btnRegWriteMemory29.BackColor = Color.Red;
            btnRegWriteMemory29.Cursor = Cursors.Hand;
            btnRegWriteMemory29.ForeColor = Color.White;
            btnRegWriteMemory29.Location = new Point(985, 15);
            btnRegWriteMemory29.Name = "btnRegWriteMemory29";
            btnRegWriteMemory29.Size = new Size(112, 30);
            btnRegWriteMemory29.TabIndex = 95;
            btnRegWriteMemory29.Text = "Write Memory";
            btnRegWriteMemory29.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory29
            // 
            btnRegReadMemory29.BackColor = Color.DarkKhaki;
            btnRegReadMemory29.Cursor = Cursors.Hand;
            btnRegReadMemory29.ForeColor = Color.White;
            btnRegReadMemory29.Location = new Point(873, 15);
            btnRegReadMemory29.Name = "btnRegReadMemory29";
            btnRegReadMemory29.Size = new Size(112, 30);
            btnRegReadMemory29.TabIndex = 94;
            btnRegReadMemory29.Text = "Read Memory";
            btnRegReadMemory29.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor29
            // 
            txtMasterScaleFactor29.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor29.Location = new Point(743, 16);
            txtMasterScaleFactor29.MaxLength = 10;
            txtMasterScaleFactor29.Name = "txtMasterScaleFactor29";
            txtMasterScaleFactor29.Size = new Size(69, 27);
            txtMasterScaleFactor29.TabIndex = 93;
            // 
            // txtMasterName29
            // 
            txtMasterName29.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName29.Location = new Point(222, 16);
            txtMasterName29.MaxLength = 5;
            txtMasterName29.Name = "txtMasterName29";
            txtMasterName29.Size = new Size(53, 27);
            txtMasterName29.TabIndex = 92;
            // 
            // txtMasterRegStartAddress29
            // 
            txtMasterRegStartAddress29.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress29.Location = new Point(109, 16);
            txtMasterRegStartAddress29.MaxLength = 10;
            txtMasterRegStartAddress29.Name = "txtMasterRegStartAddress29";
            txtMasterRegStartAddress29.Size = new Size(110, 27);
            txtMasterRegStartAddress29.TabIndex = 91;
            // 
            // txtMasterRegIndex29
            // 
            txtMasterRegIndex29.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex29.Enabled = false;
            txtMasterRegIndex29.Location = new Point(28, 16);
            txtMasterRegIndex29.MaxLength = 2;
            txtMasterRegIndex29.Name = "txtMasterRegIndex29";
            txtMasterRegIndex29.Size = new Size(79, 27);
            txtMasterRegIndex29.TabIndex = 90;
            txtMasterRegIndex29.Text = "28";
            // 
            // groupBox57
            // 
            groupBox57.Controls.Add(cmbDecimalPoint28);
            groupBox57.Controls.Add(label237);
            groupBox57.Controls.Add(cmbMasterFunctionCode28);
            groupBox57.Controls.Add(cmbMasterByteOrder28);
            groupBox57.Controls.Add(cmbMasterDataType28);
            groupBox57.Controls.Add(cmbMasterActivation28);
            groupBox57.Controls.Add(btnRegWriteMemory28);
            groupBox57.Controls.Add(btnRegReadMemory28);
            groupBox57.Controls.Add(txtMasterScaleFactor28);
            groupBox57.Controls.Add(txtMasterName28);
            groupBox57.Controls.Add(txtMasterRegStartAddress28);
            groupBox57.Controls.Add(txtMasterRegIndex28);
            groupBox57.Location = new Point(-6, 1429);
            groupBox57.Name = "groupBox57";
            groupBox57.Size = new Size(1097, 51);
            groupBox57.TabIndex = 127;
            groupBox57.TabStop = false;
            // 
            // cmbDecimalPoint28
            // 
            cmbDecimalPoint28.FormattingEnabled = true;
            cmbDecimalPoint28.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint28.Location = new Point(816, 16);
            cmbDecimalPoint28.Name = "cmbDecimalPoint28";
            cmbDecimalPoint28.Size = new Size(55, 28);
            cmbDecimalPoint28.TabIndex = 141;
            // 
            // label237
            // 
            label237.AutoSize = true;
            label237.Location = new Point(2, 19);
            label237.Name = "label237";
            label237.Size = new Size(25, 20);
            label237.TabIndex = 133;
            label237.Text = "28";
            // 
            // cmbMasterFunctionCode28
            // 
            cmbMasterFunctionCode28.FormattingEnabled = true;
            cmbMasterFunctionCode28.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode28.Location = new Point(585, 16);
            cmbMasterFunctionCode28.Name = "cmbMasterFunctionCode28";
            cmbMasterFunctionCode28.Size = new Size(155, 28);
            cmbMasterFunctionCode28.TabIndex = 100;
            // 
            // cmbMasterByteOrder28
            // 
            cmbMasterByteOrder28.FormattingEnabled = true;
            cmbMasterByteOrder28.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder28.Location = new Point(488, 16);
            cmbMasterByteOrder28.Name = "cmbMasterByteOrder28";
            cmbMasterByteOrder28.Size = new Size(92, 28);
            cmbMasterByteOrder28.TabIndex = 99;
            // 
            // cmbMasterDataType28
            // 
            cmbMasterDataType28.FormattingEnabled = true;
            cmbMasterDataType28.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType28.Location = new Point(353, 16);
            cmbMasterDataType28.Name = "cmbMasterDataType28";
            cmbMasterDataType28.Size = new Size(130, 28);
            cmbMasterDataType28.TabIndex = 98;
            // 
            // cmbMasterActivation28
            // 
            cmbMasterActivation28.FormattingEnabled = true;
            cmbMasterActivation28.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation28.Location = new Point(281, 16);
            cmbMasterActivation28.Name = "cmbMasterActivation28";
            cmbMasterActivation28.Size = new Size(68, 28);
            cmbMasterActivation28.TabIndex = 97;
            // 
            // btnRegWriteMemory28
            // 
            btnRegWriteMemory28.BackColor = Color.Red;
            btnRegWriteMemory28.Cursor = Cursors.Hand;
            btnRegWriteMemory28.ForeColor = Color.White;
            btnRegWriteMemory28.Location = new Point(986, 15);
            btnRegWriteMemory28.Name = "btnRegWriteMemory28";
            btnRegWriteMemory28.Size = new Size(112, 30);
            btnRegWriteMemory28.TabIndex = 95;
            btnRegWriteMemory28.Text = "Write Memory";
            btnRegWriteMemory28.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory28
            // 
            btnRegReadMemory28.BackColor = Color.DarkKhaki;
            btnRegReadMemory28.Cursor = Cursors.Hand;
            btnRegReadMemory28.ForeColor = Color.White;
            btnRegReadMemory28.Location = new Point(874, 15);
            btnRegReadMemory28.Name = "btnRegReadMemory28";
            btnRegReadMemory28.Size = new Size(112, 30);
            btnRegReadMemory28.TabIndex = 94;
            btnRegReadMemory28.Text = "Read Memory";
            btnRegReadMemory28.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor28
            // 
            txtMasterScaleFactor28.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor28.Location = new Point(744, 16);
            txtMasterScaleFactor28.MaxLength = 10;
            txtMasterScaleFactor28.Name = "txtMasterScaleFactor28";
            txtMasterScaleFactor28.Size = new Size(69, 27);
            txtMasterScaleFactor28.TabIndex = 93;
            // 
            // txtMasterName28
            // 
            txtMasterName28.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName28.Location = new Point(223, 16);
            txtMasterName28.MaxLength = 5;
            txtMasterName28.Name = "txtMasterName28";
            txtMasterName28.Size = new Size(53, 27);
            txtMasterName28.TabIndex = 92;
            // 
            // txtMasterRegStartAddress28
            // 
            txtMasterRegStartAddress28.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress28.Location = new Point(110, 16);
            txtMasterRegStartAddress28.MaxLength = 10;
            txtMasterRegStartAddress28.Name = "txtMasterRegStartAddress28";
            txtMasterRegStartAddress28.Size = new Size(110, 27);
            txtMasterRegStartAddress28.TabIndex = 91;
            // 
            // txtMasterRegIndex28
            // 
            txtMasterRegIndex28.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex28.Enabled = false;
            txtMasterRegIndex28.Location = new Point(29, 16);
            txtMasterRegIndex28.MaxLength = 2;
            txtMasterRegIndex28.Name = "txtMasterRegIndex28";
            txtMasterRegIndex28.Size = new Size(79, 27);
            txtMasterRegIndex28.TabIndex = 90;
            txtMasterRegIndex28.Text = "27";
            // 
            // groupBox58
            // 
            groupBox58.Controls.Add(cmbDecimalPoint26);
            groupBox58.Controls.Add(label238);
            groupBox58.Controls.Add(cmbMasterFunctionCode26);
            groupBox58.Controls.Add(cmbMasterByteOrder26);
            groupBox58.Controls.Add(cmbMasterDataType26);
            groupBox58.Controls.Add(cmbMasterActivation26);
            groupBox58.Controls.Add(btnRegWriteMemory26);
            groupBox58.Controls.Add(btnRegReadMemory26);
            groupBox58.Controls.Add(txtMasterScaleFactor26);
            groupBox58.Controls.Add(txtMasterName26);
            groupBox58.Controls.Add(txtMasterRegStartAddress26);
            groupBox58.Controls.Add(txtMasterRegIndex26);
            groupBox58.Location = new Point(-7, 1324);
            groupBox58.Name = "groupBox58";
            groupBox58.Size = new Size(1100, 51);
            groupBox58.TabIndex = 126;
            groupBox58.TabStop = false;
            // 
            // cmbDecimalPoint26
            // 
            cmbDecimalPoint26.FormattingEnabled = true;
            cmbDecimalPoint26.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint26.Location = new Point(819, 16);
            cmbDecimalPoint26.Name = "cmbDecimalPoint26";
            cmbDecimalPoint26.Size = new Size(55, 28);
            cmbDecimalPoint26.TabIndex = 139;
            // 
            // label238
            // 
            label238.AutoSize = true;
            label238.Location = new Point(3, 19);
            label238.Name = "label238";
            label238.Size = new Size(25, 20);
            label238.TabIndex = 135;
            label238.Text = "26";
            // 
            // cmbMasterFunctionCode26
            // 
            cmbMasterFunctionCode26.FormattingEnabled = true;
            cmbMasterFunctionCode26.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode26.Location = new Point(588, 16);
            cmbMasterFunctionCode26.Name = "cmbMasterFunctionCode26";
            cmbMasterFunctionCode26.Size = new Size(155, 28);
            cmbMasterFunctionCode26.TabIndex = 100;
            // 
            // cmbMasterByteOrder26
            // 
            cmbMasterByteOrder26.FormattingEnabled = true;
            cmbMasterByteOrder26.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder26.Location = new Point(491, 16);
            cmbMasterByteOrder26.Name = "cmbMasterByteOrder26";
            cmbMasterByteOrder26.Size = new Size(92, 28);
            cmbMasterByteOrder26.TabIndex = 99;
            // 
            // cmbMasterDataType26
            // 
            cmbMasterDataType26.FormattingEnabled = true;
            cmbMasterDataType26.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType26.Location = new Point(356, 16);
            cmbMasterDataType26.Name = "cmbMasterDataType26";
            cmbMasterDataType26.Size = new Size(130, 28);
            cmbMasterDataType26.TabIndex = 98;
            // 
            // cmbMasterActivation26
            // 
            cmbMasterActivation26.FormattingEnabled = true;
            cmbMasterActivation26.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation26.Location = new Point(284, 16);
            cmbMasterActivation26.Name = "cmbMasterActivation26";
            cmbMasterActivation26.Size = new Size(68, 28);
            cmbMasterActivation26.TabIndex = 97;
            // 
            // btnRegWriteMemory26
            // 
            btnRegWriteMemory26.BackColor = Color.Red;
            btnRegWriteMemory26.Cursor = Cursors.Hand;
            btnRegWriteMemory26.ForeColor = Color.White;
            btnRegWriteMemory26.Location = new Point(988, 15);
            btnRegWriteMemory26.Name = "btnRegWriteMemory26";
            btnRegWriteMemory26.Size = new Size(112, 30);
            btnRegWriteMemory26.TabIndex = 95;
            btnRegWriteMemory26.Text = "Write Memory";
            btnRegWriteMemory26.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory26
            // 
            btnRegReadMemory26.BackColor = Color.DarkKhaki;
            btnRegReadMemory26.Cursor = Cursors.Hand;
            btnRegReadMemory26.ForeColor = Color.White;
            btnRegReadMemory26.Location = new Point(876, 15);
            btnRegReadMemory26.Name = "btnRegReadMemory26";
            btnRegReadMemory26.Size = new Size(112, 30);
            btnRegReadMemory26.TabIndex = 94;
            btnRegReadMemory26.Text = "Read Memory";
            btnRegReadMemory26.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor26
            // 
            txtMasterScaleFactor26.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor26.Location = new Point(747, 16);
            txtMasterScaleFactor26.MaxLength = 10;
            txtMasterScaleFactor26.Name = "txtMasterScaleFactor26";
            txtMasterScaleFactor26.Size = new Size(69, 27);
            txtMasterScaleFactor26.TabIndex = 93;
            // 
            // txtMasterName26
            // 
            txtMasterName26.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName26.Location = new Point(225, 16);
            txtMasterName26.MaxLength = 5;
            txtMasterName26.Name = "txtMasterName26";
            txtMasterName26.Size = new Size(53, 27);
            txtMasterName26.TabIndex = 92;
            // 
            // txtMasterRegStartAddress26
            // 
            txtMasterRegStartAddress26.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress26.Location = new Point(112, 16);
            txtMasterRegStartAddress26.MaxLength = 10;
            txtMasterRegStartAddress26.Name = "txtMasterRegStartAddress26";
            txtMasterRegStartAddress26.Size = new Size(110, 27);
            txtMasterRegStartAddress26.TabIndex = 91;
            // 
            // txtMasterRegIndex26
            // 
            txtMasterRegIndex26.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex26.Enabled = false;
            txtMasterRegIndex26.Location = new Point(31, 16);
            txtMasterRegIndex26.MaxLength = 2;
            txtMasterRegIndex26.Name = "txtMasterRegIndex26";
            txtMasterRegIndex26.Size = new Size(79, 27);
            txtMasterRegIndex26.TabIndex = 90;
            txtMasterRegIndex26.Text = "25";
            // 
            // groupBox59
            // 
            groupBox59.Controls.Add(cmbDecimalPoint27);
            groupBox59.Controls.Add(label239);
            groupBox59.Controls.Add(cmbMasterFunctionCode27);
            groupBox59.Controls.Add(cmbMasterByteOrder27);
            groupBox59.Controls.Add(cmbMasterDataType27);
            groupBox59.Controls.Add(cmbMasterActivation27);
            groupBox59.Controls.Add(btnRegWriteMemory27);
            groupBox59.Controls.Add(btnRegReadMemory27);
            groupBox59.Controls.Add(txtMasterScaleFactor27);
            groupBox59.Controls.Add(txtMasterName27);
            groupBox59.Controls.Add(txtMasterRegStartAddress27);
            groupBox59.Controls.Add(txtMasterRegIndex27);
            groupBox59.Location = new Point(-6, 1377);
            groupBox59.Name = "groupBox59";
            groupBox59.Size = new Size(1099, 51);
            groupBox59.TabIndex = 125;
            groupBox59.TabStop = false;
            // 
            // cmbDecimalPoint27
            // 
            cmbDecimalPoint27.FormattingEnabled = true;
            cmbDecimalPoint27.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint27.Location = new Point(817, 16);
            cmbDecimalPoint27.Name = "cmbDecimalPoint27";
            cmbDecimalPoint27.Size = new Size(55, 28);
            cmbDecimalPoint27.TabIndex = 140;
            // 
            // label239
            // 
            label239.AutoSize = true;
            label239.Location = new Point(2, 19);
            label239.Name = "label239";
            label239.Size = new Size(25, 20);
            label239.TabIndex = 134;
            label239.Text = "27";
            // 
            // cmbMasterFunctionCode27
            // 
            cmbMasterFunctionCode27.FormattingEnabled = true;
            cmbMasterFunctionCode27.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode27.Location = new Point(585, 16);
            cmbMasterFunctionCode27.Name = "cmbMasterFunctionCode27";
            cmbMasterFunctionCode27.Size = new Size(155, 28);
            cmbMasterFunctionCode27.TabIndex = 100;
            // 
            // cmbMasterByteOrder27
            // 
            cmbMasterByteOrder27.FormattingEnabled = true;
            cmbMasterByteOrder27.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder27.Location = new Point(488, 16);
            cmbMasterByteOrder27.Name = "cmbMasterByteOrder27";
            cmbMasterByteOrder27.Size = new Size(92, 28);
            cmbMasterByteOrder27.TabIndex = 99;
            // 
            // cmbMasterDataType27
            // 
            cmbMasterDataType27.FormattingEnabled = true;
            cmbMasterDataType27.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType27.Location = new Point(353, 16);
            cmbMasterDataType27.Name = "cmbMasterDataType27";
            cmbMasterDataType27.Size = new Size(130, 28);
            cmbMasterDataType27.TabIndex = 98;
            // 
            // cmbMasterActivation27
            // 
            cmbMasterActivation27.FormattingEnabled = true;
            cmbMasterActivation27.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation27.Location = new Point(281, 16);
            cmbMasterActivation27.Name = "cmbMasterActivation27";
            cmbMasterActivation27.Size = new Size(68, 28);
            cmbMasterActivation27.TabIndex = 97;
            // 
            // btnRegWriteMemory27
            // 
            btnRegWriteMemory27.BackColor = Color.Red;
            btnRegWriteMemory27.Cursor = Cursors.Hand;
            btnRegWriteMemory27.ForeColor = Color.White;
            btnRegWriteMemory27.Location = new Point(986, 15);
            btnRegWriteMemory27.Name = "btnRegWriteMemory27";
            btnRegWriteMemory27.Size = new Size(112, 30);
            btnRegWriteMemory27.TabIndex = 95;
            btnRegWriteMemory27.Text = "Write Memory";
            btnRegWriteMemory27.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory27
            // 
            btnRegReadMemory27.BackColor = Color.DarkKhaki;
            btnRegReadMemory27.Cursor = Cursors.Hand;
            btnRegReadMemory27.ForeColor = Color.White;
            btnRegReadMemory27.Location = new Point(874, 15);
            btnRegReadMemory27.Name = "btnRegReadMemory27";
            btnRegReadMemory27.Size = new Size(112, 30);
            btnRegReadMemory27.TabIndex = 94;
            btnRegReadMemory27.Text = "Read Memory";
            btnRegReadMemory27.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor27
            // 
            txtMasterScaleFactor27.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor27.Location = new Point(744, 16);
            txtMasterScaleFactor27.MaxLength = 10;
            txtMasterScaleFactor27.Name = "txtMasterScaleFactor27";
            txtMasterScaleFactor27.Size = new Size(69, 27);
            txtMasterScaleFactor27.TabIndex = 93;
            // 
            // txtMasterName27
            // 
            txtMasterName27.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName27.Location = new Point(223, 16);
            txtMasterName27.MaxLength = 5;
            txtMasterName27.Name = "txtMasterName27";
            txtMasterName27.Size = new Size(53, 27);
            txtMasterName27.TabIndex = 92;
            // 
            // txtMasterRegStartAddress27
            // 
            txtMasterRegStartAddress27.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress27.Location = new Point(110, 16);
            txtMasterRegStartAddress27.MaxLength = 10;
            txtMasterRegStartAddress27.Name = "txtMasterRegStartAddress27";
            txtMasterRegStartAddress27.Size = new Size(110, 27);
            txtMasterRegStartAddress27.TabIndex = 91;
            // 
            // txtMasterRegIndex27
            // 
            txtMasterRegIndex27.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex27.Enabled = false;
            txtMasterRegIndex27.Location = new Point(29, 16);
            txtMasterRegIndex27.MaxLength = 2;
            txtMasterRegIndex27.Name = "txtMasterRegIndex27";
            txtMasterRegIndex27.Size = new Size(79, 27);
            txtMasterRegIndex27.TabIndex = 90;
            txtMasterRegIndex27.Text = "26";
            // 
            // groupBox60
            // 
            groupBox60.Controls.Add(cmbDecimalPoint25);
            groupBox60.Controls.Add(label240);
            groupBox60.Controls.Add(cmbMasterFunctionCode25);
            groupBox60.Controls.Add(cmbMasterByteOrder25);
            groupBox60.Controls.Add(cmbMasterDataType25);
            groupBox60.Controls.Add(cmbMasterActivation25);
            groupBox60.Controls.Add(btnRegWriteMemory25);
            groupBox60.Controls.Add(btnRegReadMemory25);
            groupBox60.Controls.Add(txtMasterScaleFactor25);
            groupBox60.Controls.Add(txtMasterName25);
            groupBox60.Controls.Add(txtMasterRegStartAddress25);
            groupBox60.Controls.Add(txtMasterRegIndex25);
            groupBox60.Location = new Point(-5, 1271);
            groupBox60.Name = "groupBox60";
            groupBox60.Size = new Size(1098, 51);
            groupBox60.TabIndex = 124;
            groupBox60.TabStop = false;
            // 
            // cmbDecimalPoint25
            // 
            cmbDecimalPoint25.FormattingEnabled = true;
            cmbDecimalPoint25.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint25.Location = new Point(817, 16);
            cmbDecimalPoint25.Name = "cmbDecimalPoint25";
            cmbDecimalPoint25.Size = new Size(55, 28);
            cmbDecimalPoint25.TabIndex = 139;
            // 
            // label240
            // 
            label240.AutoSize = true;
            label240.Location = new Point(0, 19);
            label240.Name = "label240";
            label240.Size = new Size(25, 20);
            label240.TabIndex = 136;
            label240.Text = "25";
            // 
            // cmbMasterFunctionCode25
            // 
            cmbMasterFunctionCode25.FormattingEnabled = true;
            cmbMasterFunctionCode25.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode25.Location = new Point(585, 16);
            cmbMasterFunctionCode25.Name = "cmbMasterFunctionCode25";
            cmbMasterFunctionCode25.Size = new Size(155, 28);
            cmbMasterFunctionCode25.TabIndex = 100;
            // 
            // cmbMasterByteOrder25
            // 
            cmbMasterByteOrder25.FormattingEnabled = true;
            cmbMasterByteOrder25.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder25.Location = new Point(488, 16);
            cmbMasterByteOrder25.Name = "cmbMasterByteOrder25";
            cmbMasterByteOrder25.Size = new Size(92, 28);
            cmbMasterByteOrder25.TabIndex = 99;
            // 
            // cmbMasterDataType25
            // 
            cmbMasterDataType25.FormattingEnabled = true;
            cmbMasterDataType25.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType25.Location = new Point(353, 16);
            cmbMasterDataType25.Name = "cmbMasterDataType25";
            cmbMasterDataType25.Size = new Size(130, 28);
            cmbMasterDataType25.TabIndex = 98;
            // 
            // cmbMasterActivation25
            // 
            cmbMasterActivation25.FormattingEnabled = true;
            cmbMasterActivation25.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation25.Location = new Point(281, 16);
            cmbMasterActivation25.Name = "cmbMasterActivation25";
            cmbMasterActivation25.Size = new Size(68, 28);
            cmbMasterActivation25.TabIndex = 97;
            // 
            // btnRegWriteMemory25
            // 
            btnRegWriteMemory25.BackColor = Color.Red;
            btnRegWriteMemory25.Cursor = Cursors.Hand;
            btnRegWriteMemory25.ForeColor = Color.White;
            btnRegWriteMemory25.Location = new Point(986, 15);
            btnRegWriteMemory25.Name = "btnRegWriteMemory25";
            btnRegWriteMemory25.Size = new Size(112, 30);
            btnRegWriteMemory25.TabIndex = 95;
            btnRegWriteMemory25.Text = "Write Memory";
            btnRegWriteMemory25.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory25
            // 
            btnRegReadMemory25.BackColor = Color.DarkKhaki;
            btnRegReadMemory25.Cursor = Cursors.Hand;
            btnRegReadMemory25.ForeColor = Color.White;
            btnRegReadMemory25.Location = new Point(874, 15);
            btnRegReadMemory25.Name = "btnRegReadMemory25";
            btnRegReadMemory25.Size = new Size(112, 30);
            btnRegReadMemory25.TabIndex = 94;
            btnRegReadMemory25.Text = "Read Memory";
            btnRegReadMemory25.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor25
            // 
            txtMasterScaleFactor25.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor25.Location = new Point(744, 16);
            txtMasterScaleFactor25.MaxLength = 10;
            txtMasterScaleFactor25.Name = "txtMasterScaleFactor25";
            txtMasterScaleFactor25.Size = new Size(69, 27);
            txtMasterScaleFactor25.TabIndex = 93;
            // 
            // txtMasterName25
            // 
            txtMasterName25.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName25.Location = new Point(223, 16);
            txtMasterName25.MaxLength = 5;
            txtMasterName25.Name = "txtMasterName25";
            txtMasterName25.Size = new Size(53, 27);
            txtMasterName25.TabIndex = 92;
            // 
            // txtMasterRegStartAddress25
            // 
            txtMasterRegStartAddress25.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress25.Location = new Point(110, 16);
            txtMasterRegStartAddress25.MaxLength = 10;
            txtMasterRegStartAddress25.Name = "txtMasterRegStartAddress25";
            txtMasterRegStartAddress25.Size = new Size(110, 27);
            txtMasterRegStartAddress25.TabIndex = 91;
            // 
            // txtMasterRegIndex25
            // 
            txtMasterRegIndex25.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex25.Enabled = false;
            txtMasterRegIndex25.Location = new Point(29, 16);
            txtMasterRegIndex25.MaxLength = 2;
            txtMasterRegIndex25.Name = "txtMasterRegIndex25";
            txtMasterRegIndex25.Size = new Size(79, 27);
            txtMasterRegIndex25.TabIndex = 90;
            txtMasterRegIndex25.Text = "24";
            // 
            // groupBox61
            // 
            groupBox61.Controls.Add(cmbDecimalPoint24);
            groupBox61.Controls.Add(label241);
            groupBox61.Controls.Add(cmbMasterFunctionCode24);
            groupBox61.Controls.Add(cmbMasterByteOrder24);
            groupBox61.Controls.Add(cmbMasterDataType24);
            groupBox61.Controls.Add(cmbMasterActivation24);
            groupBox61.Controls.Add(btnRegWriteMemory24);
            groupBox61.Controls.Add(btnRegReadMemory24);
            groupBox61.Controls.Add(txtMasterScaleFactor24);
            groupBox61.Controls.Add(txtMasterName24);
            groupBox61.Controls.Add(txtMasterRegStartAddress24);
            groupBox61.Controls.Add(txtMasterRegIndex24);
            groupBox61.Location = new Point(-6, 1219);
            groupBox61.Name = "groupBox61";
            groupBox61.Size = new Size(1098, 51);
            groupBox61.TabIndex = 123;
            groupBox61.TabStop = false;
            // 
            // cmbDecimalPoint24
            // 
            cmbDecimalPoint24.FormattingEnabled = true;
            cmbDecimalPoint24.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint24.Location = new Point(818, 15);
            cmbDecimalPoint24.Name = "cmbDecimalPoint24";
            cmbDecimalPoint24.Size = new Size(55, 28);
            cmbDecimalPoint24.TabIndex = 138;
            // 
            // label241
            // 
            label241.AutoSize = true;
            label241.Location = new Point(1, 19);
            label241.Name = "label241";
            label241.Size = new Size(25, 20);
            label241.TabIndex = 137;
            label241.Text = "24";
            // 
            // cmbMasterFunctionCode24
            // 
            cmbMasterFunctionCode24.FormattingEnabled = true;
            cmbMasterFunctionCode24.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode24.Location = new Point(586, 16);
            cmbMasterFunctionCode24.Name = "cmbMasterFunctionCode24";
            cmbMasterFunctionCode24.Size = new Size(155, 28);
            cmbMasterFunctionCode24.TabIndex = 100;
            // 
            // cmbMasterByteOrder24
            // 
            cmbMasterByteOrder24.FormattingEnabled = true;
            cmbMasterByteOrder24.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder24.Location = new Point(489, 16);
            cmbMasterByteOrder24.Name = "cmbMasterByteOrder24";
            cmbMasterByteOrder24.Size = new Size(92, 28);
            cmbMasterByteOrder24.TabIndex = 99;
            // 
            // cmbMasterDataType24
            // 
            cmbMasterDataType24.FormattingEnabled = true;
            cmbMasterDataType24.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType24.Location = new Point(354, 16);
            cmbMasterDataType24.Name = "cmbMasterDataType24";
            cmbMasterDataType24.Size = new Size(130, 28);
            cmbMasterDataType24.TabIndex = 98;
            // 
            // cmbMasterActivation24
            // 
            cmbMasterActivation24.FormattingEnabled = true;
            cmbMasterActivation24.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation24.Location = new Point(282, 16);
            cmbMasterActivation24.Name = "cmbMasterActivation24";
            cmbMasterActivation24.Size = new Size(68, 28);
            cmbMasterActivation24.TabIndex = 97;
            // 
            // btnRegWriteMemory24
            // 
            btnRegWriteMemory24.BackColor = Color.Red;
            btnRegWriteMemory24.Cursor = Cursors.Hand;
            btnRegWriteMemory24.ForeColor = Color.White;
            btnRegWriteMemory24.Location = new Point(987, 15);
            btnRegWriteMemory24.Name = "btnRegWriteMemory24";
            btnRegWriteMemory24.Size = new Size(112, 30);
            btnRegWriteMemory24.TabIndex = 95;
            btnRegWriteMemory24.Text = "Write Memory";
            btnRegWriteMemory24.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory24
            // 
            btnRegReadMemory24.BackColor = Color.DarkKhaki;
            btnRegReadMemory24.Cursor = Cursors.Hand;
            btnRegReadMemory24.ForeColor = Color.White;
            btnRegReadMemory24.Location = new Point(875, 15);
            btnRegReadMemory24.Name = "btnRegReadMemory24";
            btnRegReadMemory24.Size = new Size(112, 30);
            btnRegReadMemory24.TabIndex = 94;
            btnRegReadMemory24.Text = "Read Memory";
            btnRegReadMemory24.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor24
            // 
            txtMasterScaleFactor24.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor24.Location = new Point(745, 16);
            txtMasterScaleFactor24.MaxLength = 10;
            txtMasterScaleFactor24.Name = "txtMasterScaleFactor24";
            txtMasterScaleFactor24.Size = new Size(69, 27);
            txtMasterScaleFactor24.TabIndex = 93;
            // 
            // txtMasterName24
            // 
            txtMasterName24.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName24.Location = new Point(224, 16);
            txtMasterName24.MaxLength = 5;
            txtMasterName24.Name = "txtMasterName24";
            txtMasterName24.Size = new Size(53, 27);
            txtMasterName24.TabIndex = 92;
            // 
            // txtMasterRegStartAddress24
            // 
            txtMasterRegStartAddress24.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress24.Location = new Point(111, 16);
            txtMasterRegStartAddress24.MaxLength = 10;
            txtMasterRegStartAddress24.Name = "txtMasterRegStartAddress24";
            txtMasterRegStartAddress24.Size = new Size(110, 27);
            txtMasterRegStartAddress24.TabIndex = 91;
            // 
            // txtMasterRegIndex24
            // 
            txtMasterRegIndex24.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex24.Enabled = false;
            txtMasterRegIndex24.Location = new Point(30, 16);
            txtMasterRegIndex24.MaxLength = 2;
            txtMasterRegIndex24.Name = "txtMasterRegIndex24";
            txtMasterRegIndex24.Size = new Size(79, 27);
            txtMasterRegIndex24.TabIndex = 90;
            txtMasterRegIndex24.Text = "23";
            // 
            // groupBox62
            // 
            groupBox62.Controls.Add(cmbDecimalPoint23);
            groupBox62.Controls.Add(label242);
            groupBox62.Controls.Add(cmbMasterFunctionCode23);
            groupBox62.Controls.Add(cmbMasterByteOrder23);
            groupBox62.Controls.Add(cmbMasterDataType23);
            groupBox62.Controls.Add(cmbMasterActivation23);
            groupBox62.Controls.Add(btnRegWriteMemory23);
            groupBox62.Controls.Add(btnRegReadMemory23);
            groupBox62.Controls.Add(txtMasterScaleFactor23);
            groupBox62.Controls.Add(txtMasterName23);
            groupBox62.Controls.Add(txtMasterRegStartAddress23);
            groupBox62.Controls.Add(txtMasterRegIndex23);
            groupBox62.Location = new Point(-5, 1166);
            groupBox62.Name = "groupBox62";
            groupBox62.Size = new Size(1097, 51);
            groupBox62.TabIndex = 122;
            groupBox62.TabStop = false;
            // 
            // cmbDecimalPoint23
            // 
            cmbDecimalPoint23.FormattingEnabled = true;
            cmbDecimalPoint23.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint23.Location = new Point(817, 16);
            cmbDecimalPoint23.Name = "cmbDecimalPoint23";
            cmbDecimalPoint23.Size = new Size(55, 28);
            cmbDecimalPoint23.TabIndex = 139;
            // 
            // label242
            // 
            label242.AutoSize = true;
            label242.Location = new Point(0, 19);
            label242.Name = "label242";
            label242.Size = new Size(25, 20);
            label242.TabIndex = 138;
            label242.Text = "23";
            // 
            // cmbMasterFunctionCode23
            // 
            cmbMasterFunctionCode23.FormattingEnabled = true;
            cmbMasterFunctionCode23.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode23.Location = new Point(585, 16);
            cmbMasterFunctionCode23.Name = "cmbMasterFunctionCode23";
            cmbMasterFunctionCode23.Size = new Size(155, 28);
            cmbMasterFunctionCode23.TabIndex = 100;
            // 
            // cmbMasterByteOrder23
            // 
            cmbMasterByteOrder23.FormattingEnabled = true;
            cmbMasterByteOrder23.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder23.Location = new Point(488, 16);
            cmbMasterByteOrder23.Name = "cmbMasterByteOrder23";
            cmbMasterByteOrder23.Size = new Size(92, 28);
            cmbMasterByteOrder23.TabIndex = 99;
            // 
            // cmbMasterDataType23
            // 
            cmbMasterDataType23.FormattingEnabled = true;
            cmbMasterDataType23.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType23.Location = new Point(353, 16);
            cmbMasterDataType23.Name = "cmbMasterDataType23";
            cmbMasterDataType23.Size = new Size(130, 28);
            cmbMasterDataType23.TabIndex = 98;
            // 
            // cmbMasterActivation23
            // 
            cmbMasterActivation23.FormattingEnabled = true;
            cmbMasterActivation23.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation23.Location = new Point(281, 16);
            cmbMasterActivation23.Name = "cmbMasterActivation23";
            cmbMasterActivation23.Size = new Size(68, 28);
            cmbMasterActivation23.TabIndex = 97;
            // 
            // btnRegWriteMemory23
            // 
            btnRegWriteMemory23.BackColor = Color.Red;
            btnRegWriteMemory23.Cursor = Cursors.Hand;
            btnRegWriteMemory23.ForeColor = Color.White;
            btnRegWriteMemory23.Location = new Point(986, 15);
            btnRegWriteMemory23.Name = "btnRegWriteMemory23";
            btnRegWriteMemory23.Size = new Size(112, 30);
            btnRegWriteMemory23.TabIndex = 95;
            btnRegWriteMemory23.Text = "Write Memory";
            btnRegWriteMemory23.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory23
            // 
            btnRegReadMemory23.BackColor = Color.DarkKhaki;
            btnRegReadMemory23.Cursor = Cursors.Hand;
            btnRegReadMemory23.ForeColor = Color.White;
            btnRegReadMemory23.Location = new Point(874, 15);
            btnRegReadMemory23.Name = "btnRegReadMemory23";
            btnRegReadMemory23.Size = new Size(112, 30);
            btnRegReadMemory23.TabIndex = 94;
            btnRegReadMemory23.Text = "Read Memory";
            btnRegReadMemory23.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor23
            // 
            txtMasterScaleFactor23.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor23.Location = new Point(744, 16);
            txtMasterScaleFactor23.MaxLength = 10;
            txtMasterScaleFactor23.Name = "txtMasterScaleFactor23";
            txtMasterScaleFactor23.Size = new Size(69, 27);
            txtMasterScaleFactor23.TabIndex = 93;
            // 
            // txtMasterName23
            // 
            txtMasterName23.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName23.Location = new Point(223, 16);
            txtMasterName23.MaxLength = 5;
            txtMasterName23.Name = "txtMasterName23";
            txtMasterName23.Size = new Size(53, 27);
            txtMasterName23.TabIndex = 92;
            // 
            // txtMasterRegStartAddress23
            // 
            txtMasterRegStartAddress23.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress23.Location = new Point(110, 16);
            txtMasterRegStartAddress23.MaxLength = 10;
            txtMasterRegStartAddress23.Name = "txtMasterRegStartAddress23";
            txtMasterRegStartAddress23.Size = new Size(110, 27);
            txtMasterRegStartAddress23.TabIndex = 91;
            // 
            // txtMasterRegIndex23
            // 
            txtMasterRegIndex23.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex23.Enabled = false;
            txtMasterRegIndex23.Location = new Point(29, 16);
            txtMasterRegIndex23.MaxLength = 2;
            txtMasterRegIndex23.Name = "txtMasterRegIndex23";
            txtMasterRegIndex23.Size = new Size(79, 27);
            txtMasterRegIndex23.TabIndex = 90;
            txtMasterRegIndex23.Text = "22";
            // 
            // groupBox63
            // 
            groupBox63.Controls.Add(cmbDecimalPoint21);
            groupBox63.Controls.Add(label243);
            groupBox63.Controls.Add(cmbMasterFunctionCode21);
            groupBox63.Controls.Add(cmbMasterByteOrder21);
            groupBox63.Controls.Add(cmbMasterDataType21);
            groupBox63.Controls.Add(cmbMasterActivation21);
            groupBox63.Controls.Add(btnRegWriteMemory21);
            groupBox63.Controls.Add(btnRegReadMemory21);
            groupBox63.Controls.Add(txtMasterScaleFactor21);
            groupBox63.Controls.Add(txtMasterName21);
            groupBox63.Controls.Add(txtMasterRegStartAddress21);
            groupBox63.Controls.Add(txtMasterRegIndex21);
            groupBox63.Location = new Point(-5, 1060);
            groupBox63.Name = "groupBox63";
            groupBox63.Size = new Size(1098, 51);
            groupBox63.TabIndex = 121;
            groupBox63.TabStop = false;
            // 
            // cmbDecimalPoint21
            // 
            cmbDecimalPoint21.FormattingEnabled = true;
            cmbDecimalPoint21.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint21.Location = new Point(816, 15);
            cmbDecimalPoint21.Name = "cmbDecimalPoint21";
            cmbDecimalPoint21.Size = new Size(55, 28);
            cmbDecimalPoint21.TabIndex = 141;
            // 
            // label243
            // 
            label243.AutoSize = true;
            label243.Location = new Point(3, 19);
            label243.Name = "label243";
            label243.Size = new Size(25, 20);
            label243.TabIndex = 140;
            label243.Text = "21";
            // 
            // cmbMasterFunctionCode21
            // 
            cmbMasterFunctionCode21.FormattingEnabled = true;
            cmbMasterFunctionCode21.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode21.Location = new Point(585, 16);
            cmbMasterFunctionCode21.Name = "cmbMasterFunctionCode21";
            cmbMasterFunctionCode21.Size = new Size(155, 28);
            cmbMasterFunctionCode21.TabIndex = 100;
            // 
            // cmbMasterByteOrder21
            // 
            cmbMasterByteOrder21.FormattingEnabled = true;
            cmbMasterByteOrder21.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder21.Location = new Point(488, 16);
            cmbMasterByteOrder21.Name = "cmbMasterByteOrder21";
            cmbMasterByteOrder21.Size = new Size(92, 28);
            cmbMasterByteOrder21.TabIndex = 99;
            // 
            // cmbMasterDataType21
            // 
            cmbMasterDataType21.FormattingEnabled = true;
            cmbMasterDataType21.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType21.Location = new Point(353, 16);
            cmbMasterDataType21.Name = "cmbMasterDataType21";
            cmbMasterDataType21.Size = new Size(130, 28);
            cmbMasterDataType21.TabIndex = 98;
            // 
            // cmbMasterActivation21
            // 
            cmbMasterActivation21.FormattingEnabled = true;
            cmbMasterActivation21.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation21.Location = new Point(281, 16);
            cmbMasterActivation21.Name = "cmbMasterActivation21";
            cmbMasterActivation21.Size = new Size(68, 28);
            cmbMasterActivation21.TabIndex = 97;
            // 
            // btnRegWriteMemory21
            // 
            btnRegWriteMemory21.BackColor = Color.Red;
            btnRegWriteMemory21.Cursor = Cursors.Hand;
            btnRegWriteMemory21.ForeColor = Color.White;
            btnRegWriteMemory21.Location = new Point(986, 15);
            btnRegWriteMemory21.Name = "btnRegWriteMemory21";
            btnRegWriteMemory21.Size = new Size(112, 30);
            btnRegWriteMemory21.TabIndex = 95;
            btnRegWriteMemory21.Text = "Write Memory";
            btnRegWriteMemory21.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory21
            // 
            btnRegReadMemory21.BackColor = Color.DarkKhaki;
            btnRegReadMemory21.Cursor = Cursors.Hand;
            btnRegReadMemory21.ForeColor = Color.White;
            btnRegReadMemory21.Location = new Point(874, 15);
            btnRegReadMemory21.Name = "btnRegReadMemory21";
            btnRegReadMemory21.Size = new Size(112, 30);
            btnRegReadMemory21.TabIndex = 94;
            btnRegReadMemory21.Text = "Read Memory";
            btnRegReadMemory21.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor21
            // 
            txtMasterScaleFactor21.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor21.Location = new Point(744, 16);
            txtMasterScaleFactor21.MaxLength = 10;
            txtMasterScaleFactor21.Name = "txtMasterScaleFactor21";
            txtMasterScaleFactor21.Size = new Size(69, 27);
            txtMasterScaleFactor21.TabIndex = 93;
            // 
            // txtMasterName21
            // 
            txtMasterName21.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName21.Location = new Point(223, 16);
            txtMasterName21.MaxLength = 5;
            txtMasterName21.Name = "txtMasterName21";
            txtMasterName21.Size = new Size(53, 27);
            txtMasterName21.TabIndex = 92;
            // 
            // txtMasterRegStartAddress21
            // 
            txtMasterRegStartAddress21.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress21.Location = new Point(110, 16);
            txtMasterRegStartAddress21.MaxLength = 10;
            txtMasterRegStartAddress21.Name = "txtMasterRegStartAddress21";
            txtMasterRegStartAddress21.Size = new Size(110, 27);
            txtMasterRegStartAddress21.TabIndex = 91;
            // 
            // txtMasterRegIndex21
            // 
            txtMasterRegIndex21.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex21.Enabled = false;
            txtMasterRegIndex21.Location = new Point(29, 16);
            txtMasterRegIndex21.MaxLength = 2;
            txtMasterRegIndex21.Name = "txtMasterRegIndex21";
            txtMasterRegIndex21.Size = new Size(79, 27);
            txtMasterRegIndex21.TabIndex = 90;
            txtMasterRegIndex21.Text = "20";
            // 
            // groupBox34
            // 
            groupBox34.Controls.Add(cmbDecimalPoint12);
            groupBox34.Controls.Add(label216);
            groupBox34.Controls.Add(cmbMasterFunctionCode12);
            groupBox34.Controls.Add(cmbMasterByteOrder12);
            groupBox34.Controls.Add(cmbMasterDataType12);
            groupBox34.Controls.Add(cmbMasterActivation12);
            groupBox34.Controls.Add(btnRegWriteMemory12);
            groupBox34.Controls.Add(btnRegReadMemory12);
            groupBox34.Controls.Add(txtMasterScaleFactor12);
            groupBox34.Controls.Add(txtMasterName12);
            groupBox34.Controls.Add(txtMasterRegStartAddress12);
            groupBox34.Controls.Add(txtMasterRegIndex12);
            groupBox34.Location = new Point(-2, 585);
            groupBox34.Name = "groupBox34";
            groupBox34.Size = new Size(1097, 51);
            groupBox34.TabIndex = 120;
            groupBox34.TabStop = false;
            // 
            // cmbDecimalPoint12
            // 
            cmbDecimalPoint12.FormattingEnabled = true;
            cmbDecimalPoint12.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint12.Location = new Point(816, 16);
            cmbDecimalPoint12.Name = "cmbDecimalPoint12";
            cmbDecimalPoint12.Size = new Size(55, 28);
            cmbDecimalPoint12.TabIndex = 134;
            // 
            // label216
            // 
            label216.AutoSize = true;
            label216.Location = new Point(0, 19);
            label216.Name = "label216";
            label216.Size = new Size(25, 20);
            label216.TabIndex = 129;
            label216.Text = "12";
            // 
            // cmbMasterFunctionCode12
            // 
            cmbMasterFunctionCode12.FormattingEnabled = true;
            cmbMasterFunctionCode12.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode12.Location = new Point(583, 16);
            cmbMasterFunctionCode12.Name = "cmbMasterFunctionCode12";
            cmbMasterFunctionCode12.Size = new Size(155, 28);
            cmbMasterFunctionCode12.TabIndex = 100;
            // 
            // cmbMasterByteOrder12
            // 
            cmbMasterByteOrder12.FormattingEnabled = true;
            cmbMasterByteOrder12.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder12.Location = new Point(486, 16);
            cmbMasterByteOrder12.Name = "cmbMasterByteOrder12";
            cmbMasterByteOrder12.Size = new Size(92, 28);
            cmbMasterByteOrder12.TabIndex = 99;
            // 
            // cmbMasterDataType12
            // 
            cmbMasterDataType12.FormattingEnabled = true;
            cmbMasterDataType12.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType12.Location = new Point(351, 16);
            cmbMasterDataType12.Name = "cmbMasterDataType12";
            cmbMasterDataType12.Size = new Size(130, 28);
            cmbMasterDataType12.TabIndex = 98;
            // 
            // cmbMasterActivation12
            // 
            cmbMasterActivation12.FormattingEnabled = true;
            cmbMasterActivation12.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation12.Location = new Point(279, 16);
            cmbMasterActivation12.Name = "cmbMasterActivation12";
            cmbMasterActivation12.Size = new Size(68, 28);
            cmbMasterActivation12.TabIndex = 97;
            // 
            // btnRegWriteMemory12
            // 
            btnRegWriteMemory12.BackColor = Color.Red;
            btnRegWriteMemory12.Cursor = Cursors.Hand;
            btnRegWriteMemory12.ForeColor = Color.White;
            btnRegWriteMemory12.Location = new Point(984, 15);
            btnRegWriteMemory12.Name = "btnRegWriteMemory12";
            btnRegWriteMemory12.Size = new Size(112, 30);
            btnRegWriteMemory12.TabIndex = 95;
            btnRegWriteMemory12.Text = "Write Memory";
            btnRegWriteMemory12.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory12
            // 
            btnRegReadMemory12.BackColor = Color.DarkKhaki;
            btnRegReadMemory12.Cursor = Cursors.Hand;
            btnRegReadMemory12.ForeColor = Color.White;
            btnRegReadMemory12.Location = new Point(872, 15);
            btnRegReadMemory12.Name = "btnRegReadMemory12";
            btnRegReadMemory12.Size = new Size(112, 30);
            btnRegReadMemory12.TabIndex = 94;
            btnRegReadMemory12.Text = "Read Memory";
            btnRegReadMemory12.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor12
            // 
            txtMasterScaleFactor12.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor12.Location = new Point(742, 16);
            txtMasterScaleFactor12.MaxLength = 10;
            txtMasterScaleFactor12.Name = "txtMasterScaleFactor12";
            txtMasterScaleFactor12.Size = new Size(69, 27);
            txtMasterScaleFactor12.TabIndex = 93;
            // 
            // txtMasterName12
            // 
            txtMasterName12.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName12.Location = new Point(221, 16);
            txtMasterName12.MaxLength = 5;
            txtMasterName12.Name = "txtMasterName12";
            txtMasterName12.Size = new Size(53, 27);
            txtMasterName12.TabIndex = 92;
            // 
            // txtMasterRegStartAddress12
            // 
            txtMasterRegStartAddress12.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress12.Location = new Point(108, 16);
            txtMasterRegStartAddress12.MaxLength = 10;
            txtMasterRegStartAddress12.Name = "txtMasterRegStartAddress12";
            txtMasterRegStartAddress12.Size = new Size(110, 27);
            txtMasterRegStartAddress12.TabIndex = 91;
            // 
            // txtMasterRegIndex12
            // 
            txtMasterRegIndex12.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex12.Enabled = false;
            txtMasterRegIndex12.Location = new Point(27, 16);
            txtMasterRegIndex12.MaxLength = 2;
            txtMasterRegIndex12.Name = "txtMasterRegIndex12";
            txtMasterRegIndex12.Size = new Size(79, 27);
            txtMasterRegIndex12.TabIndex = 90;
            txtMasterRegIndex12.Text = "11";
            // 
            // groupBox35
            // 
            groupBox35.Controls.Add(cmbDecimalPoint20);
            groupBox35.Controls.Add(label208);
            groupBox35.Controls.Add(cmbMasterFunctionCode20);
            groupBox35.Controls.Add(cmbMasterByteOrder20);
            groupBox35.Controls.Add(cmbMasterDataType20);
            groupBox35.Controls.Add(cmbMasterActivation20);
            groupBox35.Controls.Add(btnRegWriteMemory20);
            groupBox35.Controls.Add(btnRegReadMemory20);
            groupBox35.Controls.Add(txtMasterScaleFactor20);
            groupBox35.Controls.Add(txtMasterName20);
            groupBox35.Controls.Add(txtMasterRegStartAddress20);
            groupBox35.Controls.Add(txtMasterRegIndex20);
            groupBox35.Location = new Point(0, 1005);
            groupBox35.Name = "groupBox35";
            groupBox35.Size = new Size(1094, 51);
            groupBox35.TabIndex = 119;
            groupBox35.TabStop = false;
            // 
            // cmbDecimalPoint20
            // 
            cmbDecimalPoint20.FormattingEnabled = true;
            cmbDecimalPoint20.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint20.Location = new Point(810, 15);
            cmbDecimalPoint20.Name = "cmbDecimalPoint20";
            cmbDecimalPoint20.Size = new Size(55, 28);
            cmbDecimalPoint20.TabIndex = 136;
            // 
            // label208
            // 
            label208.AutoSize = true;
            label208.Location = new Point(-2, 18);
            label208.Name = "label208";
            label208.Size = new Size(25, 20);
            label208.TabIndex = 121;
            label208.Text = "20";
            // 
            // cmbMasterFunctionCode20
            // 
            cmbMasterFunctionCode20.FormattingEnabled = true;
            cmbMasterFunctionCode20.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode20.Location = new Point(577, 16);
            cmbMasterFunctionCode20.Name = "cmbMasterFunctionCode20";
            cmbMasterFunctionCode20.Size = new Size(155, 28);
            cmbMasterFunctionCode20.TabIndex = 100;
            // 
            // cmbMasterByteOrder20
            // 
            cmbMasterByteOrder20.FormattingEnabled = true;
            cmbMasterByteOrder20.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder20.Location = new Point(480, 16);
            cmbMasterByteOrder20.Name = "cmbMasterByteOrder20";
            cmbMasterByteOrder20.Size = new Size(92, 28);
            cmbMasterByteOrder20.TabIndex = 99;
            // 
            // cmbMasterDataType20
            // 
            cmbMasterDataType20.FormattingEnabled = true;
            cmbMasterDataType20.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType20.Location = new Point(345, 16);
            cmbMasterDataType20.Name = "cmbMasterDataType20";
            cmbMasterDataType20.Size = new Size(130, 28);
            cmbMasterDataType20.TabIndex = 98;
            // 
            // cmbMasterActivation20
            // 
            cmbMasterActivation20.FormattingEnabled = true;
            cmbMasterActivation20.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation20.Location = new Point(273, 16);
            cmbMasterActivation20.Name = "cmbMasterActivation20";
            cmbMasterActivation20.Size = new Size(68, 28);
            cmbMasterActivation20.TabIndex = 97;
            // 
            // btnRegWriteMemory20
            // 
            btnRegWriteMemory20.BackColor = Color.Red;
            btnRegWriteMemory20.Cursor = Cursors.Hand;
            btnRegWriteMemory20.ForeColor = Color.White;
            btnRegWriteMemory20.Location = new Point(980, 15);
            btnRegWriteMemory20.Name = "btnRegWriteMemory20";
            btnRegWriteMemory20.Size = new Size(112, 30);
            btnRegWriteMemory20.TabIndex = 95;
            btnRegWriteMemory20.Text = "Write Memory";
            btnRegWriteMemory20.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory20
            // 
            btnRegReadMemory20.BackColor = Color.DarkKhaki;
            btnRegReadMemory20.Cursor = Cursors.Hand;
            btnRegReadMemory20.ForeColor = Color.White;
            btnRegReadMemory20.Location = new Point(868, 15);
            btnRegReadMemory20.Name = "btnRegReadMemory20";
            btnRegReadMemory20.Size = new Size(112, 30);
            btnRegReadMemory20.TabIndex = 94;
            btnRegReadMemory20.Text = "Read Memory";
            btnRegReadMemory20.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor20
            // 
            txtMasterScaleFactor20.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor20.Location = new Point(736, 16);
            txtMasterScaleFactor20.MaxLength = 10;
            txtMasterScaleFactor20.Name = "txtMasterScaleFactor20";
            txtMasterScaleFactor20.Size = new Size(69, 27);
            txtMasterScaleFactor20.TabIndex = 93;
            // 
            // txtMasterName20
            // 
            txtMasterName20.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName20.Location = new Point(217, 16);
            txtMasterName20.MaxLength = 5;
            txtMasterName20.Name = "txtMasterName20";
            txtMasterName20.Size = new Size(50, 27);
            txtMasterName20.TabIndex = 92;
            // 
            // txtMasterRegStartAddress20
            // 
            txtMasterRegStartAddress20.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress20.Location = new Point(104, 16);
            txtMasterRegStartAddress20.MaxLength = 10;
            txtMasterRegStartAddress20.Name = "txtMasterRegStartAddress20";
            txtMasterRegStartAddress20.Size = new Size(110, 27);
            txtMasterRegStartAddress20.TabIndex = 91;
            // 
            // txtMasterRegIndex20
            // 
            txtMasterRegIndex20.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex20.Enabled = false;
            txtMasterRegIndex20.Location = new Point(23, 16);
            txtMasterRegIndex20.MaxLength = 2;
            txtMasterRegIndex20.Name = "txtMasterRegIndex20";
            txtMasterRegIndex20.Size = new Size(79, 27);
            txtMasterRegIndex20.TabIndex = 90;
            txtMasterRegIndex20.Text = "19";
            // 
            // groupBox36
            // 
            groupBox36.Controls.Add(cmbDecimalPoint19);
            groupBox36.Controls.Add(label209);
            groupBox36.Controls.Add(cmbMasterFunctionCode19);
            groupBox36.Controls.Add(cmbMasterByteOrder19);
            groupBox36.Controls.Add(cmbMasterDataType19);
            groupBox36.Controls.Add(cmbMasterActivation19);
            groupBox36.Controls.Add(btnRegWriteMemory19);
            groupBox36.Controls.Add(btnRegReadMemory19);
            groupBox36.Controls.Add(txtMasterScaleFactor19);
            groupBox36.Controls.Add(txtMasterName19);
            groupBox36.Controls.Add(txtMasterRegStartAddress19);
            groupBox36.Controls.Add(txtMasterRegIndex19);
            groupBox36.Location = new Point(-1, 953);
            groupBox36.Name = "groupBox36";
            groupBox36.Size = new Size(1094, 51);
            groupBox36.TabIndex = 118;
            groupBox36.TabStop = false;
            // 
            // cmbDecimalPoint19
            // 
            cmbDecimalPoint19.FormattingEnabled = true;
            cmbDecimalPoint19.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint19.Location = new Point(811, 16);
            cmbDecimalPoint19.Name = "cmbDecimalPoint19";
            cmbDecimalPoint19.Size = new Size(55, 28);
            cmbDecimalPoint19.TabIndex = 136;
            // 
            // label209
            // 
            label209.AutoSize = true;
            label209.Location = new Point(-2, 19);
            label209.Name = "label209";
            label209.Size = new Size(25, 20);
            label209.TabIndex = 122;
            label209.Text = "19";
            // 
            // cmbMasterFunctionCode19
            // 
            cmbMasterFunctionCode19.FormattingEnabled = true;
            cmbMasterFunctionCode19.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode19.Location = new Point(577, 16);
            cmbMasterFunctionCode19.Name = "cmbMasterFunctionCode19";
            cmbMasterFunctionCode19.Size = new Size(155, 28);
            cmbMasterFunctionCode19.TabIndex = 100;
            // 
            // cmbMasterByteOrder19
            // 
            cmbMasterByteOrder19.FormattingEnabled = true;
            cmbMasterByteOrder19.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder19.Location = new Point(480, 16);
            cmbMasterByteOrder19.Name = "cmbMasterByteOrder19";
            cmbMasterByteOrder19.Size = new Size(92, 28);
            cmbMasterByteOrder19.TabIndex = 99;
            // 
            // cmbMasterDataType19
            // 
            cmbMasterDataType19.FormattingEnabled = true;
            cmbMasterDataType19.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType19.Location = new Point(345, 16);
            cmbMasterDataType19.Name = "cmbMasterDataType19";
            cmbMasterDataType19.Size = new Size(130, 28);
            cmbMasterDataType19.TabIndex = 98;
            // 
            // cmbMasterActivation19
            // 
            cmbMasterActivation19.FormattingEnabled = true;
            cmbMasterActivation19.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation19.Location = new Point(273, 16);
            cmbMasterActivation19.Name = "cmbMasterActivation19";
            cmbMasterActivation19.Size = new Size(68, 28);
            cmbMasterActivation19.TabIndex = 97;
            // 
            // btnRegWriteMemory19
            // 
            btnRegWriteMemory19.BackColor = Color.Red;
            btnRegWriteMemory19.Cursor = Cursors.Hand;
            btnRegWriteMemory19.ForeColor = Color.White;
            btnRegWriteMemory19.Location = new Point(981, 15);
            btnRegWriteMemory19.Name = "btnRegWriteMemory19";
            btnRegWriteMemory19.Size = new Size(112, 30);
            btnRegWriteMemory19.TabIndex = 95;
            btnRegWriteMemory19.Text = "Write Memory";
            btnRegWriteMemory19.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory19
            // 
            btnRegReadMemory19.BackColor = Color.DarkKhaki;
            btnRegReadMemory19.Cursor = Cursors.Hand;
            btnRegReadMemory19.ForeColor = Color.White;
            btnRegReadMemory19.Location = new Point(869, 15);
            btnRegReadMemory19.Name = "btnRegReadMemory19";
            btnRegReadMemory19.Size = new Size(112, 30);
            btnRegReadMemory19.TabIndex = 94;
            btnRegReadMemory19.Text = "Read Memory";
            btnRegReadMemory19.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor19
            // 
            txtMasterScaleFactor19.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor19.Location = new Point(736, 16);
            txtMasterScaleFactor19.MaxLength = 10;
            txtMasterScaleFactor19.Name = "txtMasterScaleFactor19";
            txtMasterScaleFactor19.Size = new Size(69, 27);
            txtMasterScaleFactor19.TabIndex = 93;
            // 
            // txtMasterName19
            // 
            txtMasterName19.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName19.Location = new Point(218, 16);
            txtMasterName19.MaxLength = 5;
            txtMasterName19.Name = "txtMasterName19";
            txtMasterName19.Size = new Size(50, 27);
            txtMasterName19.TabIndex = 92;
            // 
            // txtMasterRegStartAddress19
            // 
            txtMasterRegStartAddress19.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress19.Location = new Point(105, 16);
            txtMasterRegStartAddress19.MaxLength = 10;
            txtMasterRegStartAddress19.Name = "txtMasterRegStartAddress19";
            txtMasterRegStartAddress19.Size = new Size(110, 27);
            txtMasterRegStartAddress19.TabIndex = 91;
            // 
            // txtMasterRegIndex19
            // 
            txtMasterRegIndex19.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex19.Enabled = false;
            txtMasterRegIndex19.Location = new Point(24, 16);
            txtMasterRegIndex19.MaxLength = 2;
            txtMasterRegIndex19.Name = "txtMasterRegIndex19";
            txtMasterRegIndex19.Size = new Size(79, 27);
            txtMasterRegIndex19.TabIndex = 90;
            txtMasterRegIndex19.Text = "18";
            // 
            // groupBox37
            // 
            groupBox37.Controls.Add(cmbDecimalPoint18);
            groupBox37.Controls.Add(label210);
            groupBox37.Controls.Add(cmbMasterFunctionCode18);
            groupBox37.Controls.Add(cmbMasterByteOrder18);
            groupBox37.Controls.Add(cmbMasterDataType18);
            groupBox37.Controls.Add(cmbMasterActivation18);
            groupBox37.Controls.Add(btnRegWriteMemory18);
            groupBox37.Controls.Add(btnRegReadMemory18);
            groupBox37.Controls.Add(txtMasterScaleFactor18);
            groupBox37.Controls.Add(txtMasterName18);
            groupBox37.Controls.Add(txtMasterRegStartAddress18);
            groupBox37.Controls.Add(txtMasterRegIndex18);
            groupBox37.Location = new Point(-2, 901);
            groupBox37.Name = "groupBox37";
            groupBox37.Size = new Size(1094, 51);
            groupBox37.TabIndex = 117;
            groupBox37.TabStop = false;
            // 
            // cmbDecimalPoint18
            // 
            cmbDecimalPoint18.FormattingEnabled = true;
            cmbDecimalPoint18.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint18.Location = new Point(814, 16);
            cmbDecimalPoint18.Name = "cmbDecimalPoint18";
            cmbDecimalPoint18.Size = new Size(55, 28);
            cmbDecimalPoint18.TabIndex = 135;
            // 
            // label210
            // 
            label210.AutoSize = true;
            label210.Location = new Point(-1, 19);
            label210.Name = "label210";
            label210.Size = new Size(25, 20);
            label210.TabIndex = 123;
            label210.Text = "18";
            // 
            // cmbMasterFunctionCode18
            // 
            cmbMasterFunctionCode18.FormattingEnabled = true;
            cmbMasterFunctionCode18.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode18.Location = new Point(581, 16);
            cmbMasterFunctionCode18.Name = "cmbMasterFunctionCode18";
            cmbMasterFunctionCode18.Size = new Size(155, 28);
            cmbMasterFunctionCode18.TabIndex = 100;
            // 
            // cmbMasterByteOrder18
            // 
            cmbMasterByteOrder18.FormattingEnabled = true;
            cmbMasterByteOrder18.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder18.Location = new Point(484, 16);
            cmbMasterByteOrder18.Name = "cmbMasterByteOrder18";
            cmbMasterByteOrder18.Size = new Size(92, 28);
            cmbMasterByteOrder18.TabIndex = 99;
            // 
            // cmbMasterDataType18
            // 
            cmbMasterDataType18.FormattingEnabled = true;
            cmbMasterDataType18.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType18.Location = new Point(349, 16);
            cmbMasterDataType18.Name = "cmbMasterDataType18";
            cmbMasterDataType18.Size = new Size(130, 28);
            cmbMasterDataType18.TabIndex = 98;
            // 
            // cmbMasterActivation18
            // 
            cmbMasterActivation18.FormattingEnabled = true;
            cmbMasterActivation18.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation18.Location = new Point(277, 16);
            cmbMasterActivation18.Name = "cmbMasterActivation18";
            cmbMasterActivation18.Size = new Size(68, 28);
            cmbMasterActivation18.TabIndex = 97;
            // 
            // btnRegWriteMemory18
            // 
            btnRegWriteMemory18.BackColor = Color.Red;
            btnRegWriteMemory18.Cursor = Cursors.Hand;
            btnRegWriteMemory18.ForeColor = Color.White;
            btnRegWriteMemory18.Location = new Point(982, 15);
            btnRegWriteMemory18.Name = "btnRegWriteMemory18";
            btnRegWriteMemory18.Size = new Size(112, 30);
            btnRegWriteMemory18.TabIndex = 95;
            btnRegWriteMemory18.Text = "Write Memory";
            btnRegWriteMemory18.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory18
            // 
            btnRegReadMemory18.BackColor = Color.DarkKhaki;
            btnRegReadMemory18.Cursor = Cursors.Hand;
            btnRegReadMemory18.ForeColor = Color.White;
            btnRegReadMemory18.Location = new Point(870, 15);
            btnRegReadMemory18.Name = "btnRegReadMemory18";
            btnRegReadMemory18.Size = new Size(112, 30);
            btnRegReadMemory18.TabIndex = 94;
            btnRegReadMemory18.Text = "Read Memory";
            btnRegReadMemory18.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor18
            // 
            txtMasterScaleFactor18.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor18.Location = new Point(740, 16);
            txtMasterScaleFactor18.MaxLength = 10;
            txtMasterScaleFactor18.Name = "txtMasterScaleFactor18";
            txtMasterScaleFactor18.Size = new Size(69, 27);
            txtMasterScaleFactor18.TabIndex = 93;
            // 
            // txtMasterName18
            // 
            txtMasterName18.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName18.Location = new Point(219, 16);
            txtMasterName18.MaxLength = 5;
            txtMasterName18.Name = "txtMasterName18";
            txtMasterName18.Size = new Size(53, 27);
            txtMasterName18.TabIndex = 92;
            // 
            // txtMasterRegStartAddress18
            // 
            txtMasterRegStartAddress18.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress18.Location = new Point(106, 16);
            txtMasterRegStartAddress18.MaxLength = 10;
            txtMasterRegStartAddress18.Name = "txtMasterRegStartAddress18";
            txtMasterRegStartAddress18.Size = new Size(110, 27);
            txtMasterRegStartAddress18.TabIndex = 91;
            // 
            // txtMasterRegIndex18
            // 
            txtMasterRegIndex18.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex18.Enabled = false;
            txtMasterRegIndex18.Location = new Point(25, 16);
            txtMasterRegIndex18.MaxLength = 2;
            txtMasterRegIndex18.Name = "txtMasterRegIndex18";
            txtMasterRegIndex18.Size = new Size(79, 27);
            txtMasterRegIndex18.TabIndex = 90;
            txtMasterRegIndex18.Text = "17";
            // 
            // groupBox38
            // 
            groupBox38.Controls.Add(cmbDecimalPoint16);
            groupBox38.Controls.Add(label212);
            groupBox38.Controls.Add(cmbMasterFunctionCode16);
            groupBox38.Controls.Add(cmbMasterByteOrder16);
            groupBox38.Controls.Add(cmbMasterDataType16);
            groupBox38.Controls.Add(cmbMasterActivation16);
            groupBox38.Controls.Add(btnRegWriteMemory16);
            groupBox38.Controls.Add(btnRegReadMemory16);
            groupBox38.Controls.Add(txtMasterScaleFactor16);
            groupBox38.Controls.Add(txtMasterName16);
            groupBox38.Controls.Add(txtMasterRegStartAddress16);
            groupBox38.Controls.Add(txtMasterRegIndex16);
            groupBox38.Location = new Point(-3, 796);
            groupBox38.Name = "groupBox38";
            groupBox38.Size = new Size(1099, 51);
            groupBox38.TabIndex = 116;
            groupBox38.TabStop = false;
            // 
            // cmbDecimalPoint16
            // 
            cmbDecimalPoint16.FormattingEnabled = true;
            cmbDecimalPoint16.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint16.Location = new Point(815, 16);
            cmbDecimalPoint16.Name = "cmbDecimalPoint16";
            cmbDecimalPoint16.Size = new Size(55, 28);
            cmbDecimalPoint16.TabIndex = 135;
            // 
            // label212
            // 
            label212.AutoSize = true;
            label212.Location = new Point(0, 19);
            label212.Name = "label212";
            label212.Size = new Size(25, 20);
            label212.TabIndex = 125;
            label212.Text = "16";
            // 
            // cmbMasterFunctionCode16
            // 
            cmbMasterFunctionCode16.FormattingEnabled = true;
            cmbMasterFunctionCode16.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode16.Location = new Point(585, 16);
            cmbMasterFunctionCode16.Name = "cmbMasterFunctionCode16";
            cmbMasterFunctionCode16.Size = new Size(155, 28);
            cmbMasterFunctionCode16.TabIndex = 100;
            // 
            // cmbMasterByteOrder16
            // 
            cmbMasterByteOrder16.FormattingEnabled = true;
            cmbMasterByteOrder16.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder16.Location = new Point(488, 16);
            cmbMasterByteOrder16.Name = "cmbMasterByteOrder16";
            cmbMasterByteOrder16.Size = new Size(92, 28);
            cmbMasterByteOrder16.TabIndex = 99;
            // 
            // cmbMasterDataType16
            // 
            cmbMasterDataType16.FormattingEnabled = true;
            cmbMasterDataType16.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType16.Location = new Point(353, 16);
            cmbMasterDataType16.Name = "cmbMasterDataType16";
            cmbMasterDataType16.Size = new Size(130, 28);
            cmbMasterDataType16.TabIndex = 98;
            // 
            // cmbMasterActivation16
            // 
            cmbMasterActivation16.FormattingEnabled = true;
            cmbMasterActivation16.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation16.Location = new Point(281, 16);
            cmbMasterActivation16.Name = "cmbMasterActivation16";
            cmbMasterActivation16.Size = new Size(68, 28);
            cmbMasterActivation16.TabIndex = 97;
            // 
            // btnRegWriteMemory16
            // 
            btnRegWriteMemory16.BackColor = Color.Red;
            btnRegWriteMemory16.Cursor = Cursors.Hand;
            btnRegWriteMemory16.ForeColor = Color.White;
            btnRegWriteMemory16.Location = new Point(985, 15);
            btnRegWriteMemory16.Name = "btnRegWriteMemory16";
            btnRegWriteMemory16.Size = new Size(112, 30);
            btnRegWriteMemory16.TabIndex = 95;
            btnRegWriteMemory16.Text = "Write Memory";
            btnRegWriteMemory16.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory16
            // 
            btnRegReadMemory16.BackColor = Color.DarkKhaki;
            btnRegReadMemory16.Cursor = Cursors.Hand;
            btnRegReadMemory16.ForeColor = Color.White;
            btnRegReadMemory16.Location = new Point(873, 15);
            btnRegReadMemory16.Name = "btnRegReadMemory16";
            btnRegReadMemory16.Size = new Size(112, 30);
            btnRegReadMemory16.TabIndex = 94;
            btnRegReadMemory16.Text = "Read Memory";
            btnRegReadMemory16.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor16
            // 
            txtMasterScaleFactor16.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor16.Location = new Point(744, 16);
            txtMasterScaleFactor16.MaxLength = 10;
            txtMasterScaleFactor16.Name = "txtMasterScaleFactor16";
            txtMasterScaleFactor16.Size = new Size(69, 27);
            txtMasterScaleFactor16.TabIndex = 93;
            // 
            // txtMasterName16
            // 
            txtMasterName16.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName16.Location = new Point(222, 16);
            txtMasterName16.MaxLength = 5;
            txtMasterName16.Name = "txtMasterName16";
            txtMasterName16.Size = new Size(53, 27);
            txtMasterName16.TabIndex = 92;
            // 
            // txtMasterRegStartAddress16
            // 
            txtMasterRegStartAddress16.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress16.Location = new Point(109, 16);
            txtMasterRegStartAddress16.MaxLength = 10;
            txtMasterRegStartAddress16.Name = "txtMasterRegStartAddress16";
            txtMasterRegStartAddress16.Size = new Size(110, 27);
            txtMasterRegStartAddress16.TabIndex = 91;
            // 
            // txtMasterRegIndex16
            // 
            txtMasterRegIndex16.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex16.Enabled = false;
            txtMasterRegIndex16.Location = new Point(28, 16);
            txtMasterRegIndex16.MaxLength = 2;
            txtMasterRegIndex16.Name = "txtMasterRegIndex16";
            txtMasterRegIndex16.Size = new Size(79, 27);
            txtMasterRegIndex16.TabIndex = 90;
            txtMasterRegIndex16.Text = "15";
            // 
            // groupBox39
            // 
            groupBox39.Controls.Add(cmbDecimalPoint17);
            groupBox39.Controls.Add(label211);
            groupBox39.Controls.Add(cmbMasterFunctionCode17);
            groupBox39.Controls.Add(cmbMasterByteOrder17);
            groupBox39.Controls.Add(cmbMasterDataType17);
            groupBox39.Controls.Add(cmbMasterActivation17);
            groupBox39.Controls.Add(btnRegWriteMemory17);
            groupBox39.Controls.Add(btnRegReadMemory17);
            groupBox39.Controls.Add(txtMasterScaleFactor17);
            groupBox39.Controls.Add(txtMasterName17);
            groupBox39.Controls.Add(txtMasterRegStartAddress17);
            groupBox39.Controls.Add(txtMasterRegIndex17);
            groupBox39.Location = new Point(-6, 849);
            groupBox39.Name = "groupBox39";
            groupBox39.Size = new Size(1101, 51);
            groupBox39.TabIndex = 115;
            groupBox39.TabStop = false;
            // 
            // cmbDecimalPoint17
            // 
            cmbDecimalPoint17.FormattingEnabled = true;
            cmbDecimalPoint17.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint17.Location = new Point(818, 16);
            cmbDecimalPoint17.Name = "cmbDecimalPoint17";
            cmbDecimalPoint17.Size = new Size(55, 28);
            cmbDecimalPoint17.TabIndex = 135;
            // 
            // label211
            // 
            label211.AutoSize = true;
            label211.Location = new Point(2, 19);
            label211.Name = "label211";
            label211.Size = new Size(25, 20);
            label211.TabIndex = 124;
            label211.Text = "17";
            // 
            // cmbMasterFunctionCode17
            // 
            cmbMasterFunctionCode17.FormattingEnabled = true;
            cmbMasterFunctionCode17.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode17.Location = new Point(586, 16);
            cmbMasterFunctionCode17.Name = "cmbMasterFunctionCode17";
            cmbMasterFunctionCode17.Size = new Size(155, 28);
            cmbMasterFunctionCode17.TabIndex = 100;
            // 
            // cmbMasterByteOrder17
            // 
            cmbMasterByteOrder17.FormattingEnabled = true;
            cmbMasterByteOrder17.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder17.Location = new Point(489, 16);
            cmbMasterByteOrder17.Name = "cmbMasterByteOrder17";
            cmbMasterByteOrder17.Size = new Size(92, 28);
            cmbMasterByteOrder17.TabIndex = 99;
            // 
            // cmbMasterDataType17
            // 
            cmbMasterDataType17.FormattingEnabled = true;
            cmbMasterDataType17.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType17.Location = new Point(354, 16);
            cmbMasterDataType17.Name = "cmbMasterDataType17";
            cmbMasterDataType17.Size = new Size(130, 28);
            cmbMasterDataType17.TabIndex = 98;
            // 
            // cmbMasterActivation17
            // 
            cmbMasterActivation17.FormattingEnabled = true;
            cmbMasterActivation17.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation17.Location = new Point(282, 16);
            cmbMasterActivation17.Name = "cmbMasterActivation17";
            cmbMasterActivation17.Size = new Size(68, 28);
            cmbMasterActivation17.TabIndex = 97;
            // 
            // btnRegWriteMemory17
            // 
            btnRegWriteMemory17.BackColor = Color.Red;
            btnRegWriteMemory17.Cursor = Cursors.Hand;
            btnRegWriteMemory17.ForeColor = Color.White;
            btnRegWriteMemory17.Location = new Point(986, 15);
            btnRegWriteMemory17.Name = "btnRegWriteMemory17";
            btnRegWriteMemory17.Size = new Size(112, 30);
            btnRegWriteMemory17.TabIndex = 95;
            btnRegWriteMemory17.Text = "Write Memory";
            btnRegWriteMemory17.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory17
            // 
            btnRegReadMemory17.BackColor = Color.DarkKhaki;
            btnRegReadMemory17.Cursor = Cursors.Hand;
            btnRegReadMemory17.ForeColor = Color.White;
            btnRegReadMemory17.Location = new Point(874, 15);
            btnRegReadMemory17.Name = "btnRegReadMemory17";
            btnRegReadMemory17.Size = new Size(112, 30);
            btnRegReadMemory17.TabIndex = 94;
            btnRegReadMemory17.Text = "Read Memory";
            btnRegReadMemory17.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor17
            // 
            txtMasterScaleFactor17.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor17.Location = new Point(745, 16);
            txtMasterScaleFactor17.MaxLength = 10;
            txtMasterScaleFactor17.Name = "txtMasterScaleFactor17";
            txtMasterScaleFactor17.Size = new Size(69, 27);
            txtMasterScaleFactor17.TabIndex = 93;
            // 
            // txtMasterName17
            // 
            txtMasterName17.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName17.Location = new Point(223, 16);
            txtMasterName17.MaxLength = 5;
            txtMasterName17.Name = "txtMasterName17";
            txtMasterName17.Size = new Size(53, 27);
            txtMasterName17.TabIndex = 92;
            // 
            // txtMasterRegStartAddress17
            // 
            txtMasterRegStartAddress17.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress17.Location = new Point(110, 16);
            txtMasterRegStartAddress17.MaxLength = 10;
            txtMasterRegStartAddress17.Name = "txtMasterRegStartAddress17";
            txtMasterRegStartAddress17.Size = new Size(110, 27);
            txtMasterRegStartAddress17.TabIndex = 91;
            // 
            // txtMasterRegIndex17
            // 
            txtMasterRegIndex17.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex17.Enabled = false;
            txtMasterRegIndex17.Location = new Point(29, 16);
            txtMasterRegIndex17.MaxLength = 2;
            txtMasterRegIndex17.Name = "txtMasterRegIndex17";
            txtMasterRegIndex17.Size = new Size(79, 27);
            txtMasterRegIndex17.TabIndex = 90;
            txtMasterRegIndex17.Text = "16";
            // 
            // groupBox40
            // 
            groupBox40.Controls.Add(cmbDecimalPoint15);
            groupBox40.Controls.Add(label213);
            groupBox40.Controls.Add(cmbMasterFunctionCode15);
            groupBox40.Controls.Add(cmbMasterByteOrder15);
            groupBox40.Controls.Add(cmbMasterDataType15);
            groupBox40.Controls.Add(cmbMasterActivation15);
            groupBox40.Controls.Add(btnRegWriteMemory15);
            groupBox40.Controls.Add(btnRegReadMemory15);
            groupBox40.Controls.Add(txtMasterScaleFactor15);
            groupBox40.Controls.Add(txtMasterName15);
            groupBox40.Controls.Add(txtMasterRegStartAddress15);
            groupBox40.Controls.Add(txtMasterRegIndex15);
            groupBox40.Location = new Point(-2, 743);
            groupBox40.Name = "groupBox40";
            groupBox40.Size = new Size(1098, 51);
            groupBox40.TabIndex = 114;
            groupBox40.TabStop = false;
            // 
            // cmbDecimalPoint15
            // 
            cmbDecimalPoint15.FormattingEnabled = true;
            cmbDecimalPoint15.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint15.Location = new Point(816, 16);
            cmbDecimalPoint15.Name = "cmbDecimalPoint15";
            cmbDecimalPoint15.Size = new Size(55, 28);
            cmbDecimalPoint15.TabIndex = 135;
            // 
            // label213
            // 
            label213.AutoSize = true;
            label213.Location = new Point(-1, 19);
            label213.Name = "label213";
            label213.Size = new Size(25, 20);
            label213.TabIndex = 126;
            label213.Text = "15";
            // 
            // cmbMasterFunctionCode15
            // 
            cmbMasterFunctionCode15.FormattingEnabled = true;
            cmbMasterFunctionCode15.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode15.Location = new Point(586, 16);
            cmbMasterFunctionCode15.Name = "cmbMasterFunctionCode15";
            cmbMasterFunctionCode15.Size = new Size(155, 28);
            cmbMasterFunctionCode15.TabIndex = 100;
            // 
            // cmbMasterByteOrder15
            // 
            cmbMasterByteOrder15.FormattingEnabled = true;
            cmbMasterByteOrder15.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder15.Location = new Point(489, 16);
            cmbMasterByteOrder15.Name = "cmbMasterByteOrder15";
            cmbMasterByteOrder15.Size = new Size(92, 28);
            cmbMasterByteOrder15.TabIndex = 99;
            // 
            // cmbMasterDataType15
            // 
            cmbMasterDataType15.FormattingEnabled = true;
            cmbMasterDataType15.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType15.Location = new Point(354, 16);
            cmbMasterDataType15.Name = "cmbMasterDataType15";
            cmbMasterDataType15.Size = new Size(130, 28);
            cmbMasterDataType15.TabIndex = 98;
            // 
            // cmbMasterActivation15
            // 
            cmbMasterActivation15.FormattingEnabled = true;
            cmbMasterActivation15.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation15.Location = new Point(282, 16);
            cmbMasterActivation15.Name = "cmbMasterActivation15";
            cmbMasterActivation15.Size = new Size(68, 28);
            cmbMasterActivation15.TabIndex = 97;
            // 
            // btnRegWriteMemory15
            // 
            btnRegWriteMemory15.BackColor = Color.Red;
            btnRegWriteMemory15.Cursor = Cursors.Hand;
            btnRegWriteMemory15.ForeColor = Color.White;
            btnRegWriteMemory15.Location = new Point(985, 15);
            btnRegWriteMemory15.Name = "btnRegWriteMemory15";
            btnRegWriteMemory15.Size = new Size(112, 30);
            btnRegWriteMemory15.TabIndex = 95;
            btnRegWriteMemory15.Text = "Write Memory";
            btnRegWriteMemory15.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory15
            // 
            btnRegReadMemory15.BackColor = Color.DarkKhaki;
            btnRegReadMemory15.Cursor = Cursors.Hand;
            btnRegReadMemory15.ForeColor = Color.White;
            btnRegReadMemory15.Location = new Point(873, 15);
            btnRegReadMemory15.Name = "btnRegReadMemory15";
            btnRegReadMemory15.Size = new Size(112, 30);
            btnRegReadMemory15.TabIndex = 94;
            btnRegReadMemory15.Text = "Read Memory";
            btnRegReadMemory15.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor15
            // 
            txtMasterScaleFactor15.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor15.Location = new Point(745, 16);
            txtMasterScaleFactor15.MaxLength = 10;
            txtMasterScaleFactor15.Name = "txtMasterScaleFactor15";
            txtMasterScaleFactor15.Size = new Size(69, 27);
            txtMasterScaleFactor15.TabIndex = 93;
            // 
            // txtMasterName15
            // 
            txtMasterName15.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName15.Location = new Point(222, 16);
            txtMasterName15.MaxLength = 5;
            txtMasterName15.Name = "txtMasterName15";
            txtMasterName15.Size = new Size(53, 27);
            txtMasterName15.TabIndex = 92;
            // 
            // txtMasterRegStartAddress15
            // 
            txtMasterRegStartAddress15.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress15.Location = new Point(109, 16);
            txtMasterRegStartAddress15.MaxLength = 10;
            txtMasterRegStartAddress15.Name = "txtMasterRegStartAddress15";
            txtMasterRegStartAddress15.Size = new Size(110, 27);
            txtMasterRegStartAddress15.TabIndex = 91;
            // 
            // txtMasterRegIndex15
            // 
            txtMasterRegIndex15.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex15.Enabled = false;
            txtMasterRegIndex15.Location = new Point(28, 16);
            txtMasterRegIndex15.MaxLength = 2;
            txtMasterRegIndex15.Name = "txtMasterRegIndex15";
            txtMasterRegIndex15.Size = new Size(79, 27);
            txtMasterRegIndex15.TabIndex = 90;
            txtMasterRegIndex15.Text = "14";
            // 
            // groupBox41
            // 
            groupBox41.Controls.Add(cmbDecimalPoint14);
            groupBox41.Controls.Add(label214);
            groupBox41.Controls.Add(cmbMasterFunctionCode14);
            groupBox41.Controls.Add(cmbMasterByteOrder14);
            groupBox41.Controls.Add(cmbMasterDataType14);
            groupBox41.Controls.Add(cmbMasterActivation14);
            groupBox41.Controls.Add(btnRegWriteMemory14);
            groupBox41.Controls.Add(btnRegReadMemory14);
            groupBox41.Controls.Add(txtMasterScaleFactor14);
            groupBox41.Controls.Add(txtMasterName14);
            groupBox41.Controls.Add(txtMasterRegStartAddress14);
            groupBox41.Controls.Add(txtMasterRegIndex14);
            groupBox41.Location = new Point(-2, 691);
            groupBox41.Name = "groupBox41";
            groupBox41.Size = new Size(1097, 51);
            groupBox41.TabIndex = 113;
            groupBox41.TabStop = false;
            // 
            // cmbDecimalPoint14
            // 
            cmbDecimalPoint14.FormattingEnabled = true;
            cmbDecimalPoint14.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint14.Location = new Point(817, 15);
            cmbDecimalPoint14.Name = "cmbDecimalPoint14";
            cmbDecimalPoint14.Size = new Size(55, 28);
            cmbDecimalPoint14.TabIndex = 135;
            // 
            // label214
            // 
            label214.AutoSize = true;
            label214.Location = new Point(0, 20);
            label214.Name = "label214";
            label214.Size = new Size(25, 20);
            label214.TabIndex = 127;
            label214.Text = "14";
            // 
            // cmbMasterFunctionCode14
            // 
            cmbMasterFunctionCode14.FormattingEnabled = true;
            cmbMasterFunctionCode14.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode14.Location = new Point(586, 16);
            cmbMasterFunctionCode14.Name = "cmbMasterFunctionCode14";
            cmbMasterFunctionCode14.Size = new Size(155, 28);
            cmbMasterFunctionCode14.TabIndex = 100;
            // 
            // cmbMasterByteOrder14
            // 
            cmbMasterByteOrder14.FormattingEnabled = true;
            cmbMasterByteOrder14.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder14.Location = new Point(489, 16);
            cmbMasterByteOrder14.Name = "cmbMasterByteOrder14";
            cmbMasterByteOrder14.Size = new Size(92, 28);
            cmbMasterByteOrder14.TabIndex = 99;
            // 
            // cmbMasterDataType14
            // 
            cmbMasterDataType14.FormattingEnabled = true;
            cmbMasterDataType14.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType14.Location = new Point(354, 16);
            cmbMasterDataType14.Name = "cmbMasterDataType14";
            cmbMasterDataType14.Size = new Size(130, 28);
            cmbMasterDataType14.TabIndex = 98;
            // 
            // cmbMasterActivation14
            // 
            cmbMasterActivation14.FormattingEnabled = true;
            cmbMasterActivation14.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation14.Location = new Point(282, 16);
            cmbMasterActivation14.Name = "cmbMasterActivation14";
            cmbMasterActivation14.Size = new Size(68, 28);
            cmbMasterActivation14.TabIndex = 97;
            // 
            // btnRegWriteMemory14
            // 
            btnRegWriteMemory14.BackColor = Color.Red;
            btnRegWriteMemory14.Cursor = Cursors.Hand;
            btnRegWriteMemory14.ForeColor = Color.White;
            btnRegWriteMemory14.Location = new Point(986, 15);
            btnRegWriteMemory14.Name = "btnRegWriteMemory14";
            btnRegWriteMemory14.Size = new Size(112, 30);
            btnRegWriteMemory14.TabIndex = 95;
            btnRegWriteMemory14.Text = "Write Memory";
            btnRegWriteMemory14.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory14
            // 
            btnRegReadMemory14.BackColor = Color.DarkKhaki;
            btnRegReadMemory14.Cursor = Cursors.Hand;
            btnRegReadMemory14.ForeColor = Color.White;
            btnRegReadMemory14.Location = new Point(874, 15);
            btnRegReadMemory14.Name = "btnRegReadMemory14";
            btnRegReadMemory14.Size = new Size(112, 30);
            btnRegReadMemory14.TabIndex = 94;
            btnRegReadMemory14.Text = "Read Memory";
            btnRegReadMemory14.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor14
            // 
            txtMasterScaleFactor14.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor14.Location = new Point(745, 16);
            txtMasterScaleFactor14.MaxLength = 10;
            txtMasterScaleFactor14.Name = "txtMasterScaleFactor14";
            txtMasterScaleFactor14.Size = new Size(69, 27);
            txtMasterScaleFactor14.TabIndex = 93;
            // 
            // txtMasterName14
            // 
            txtMasterName14.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName14.Location = new Point(223, 16);
            txtMasterName14.MaxLength = 5;
            txtMasterName14.Name = "txtMasterName14";
            txtMasterName14.Size = new Size(53, 27);
            txtMasterName14.TabIndex = 92;
            // 
            // txtMasterRegStartAddress14
            // 
            txtMasterRegStartAddress14.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress14.Location = new Point(110, 16);
            txtMasterRegStartAddress14.MaxLength = 10;
            txtMasterRegStartAddress14.Name = "txtMasterRegStartAddress14";
            txtMasterRegStartAddress14.Size = new Size(110, 27);
            txtMasterRegStartAddress14.TabIndex = 91;
            // 
            // txtMasterRegIndex14
            // 
            txtMasterRegIndex14.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex14.Enabled = false;
            txtMasterRegIndex14.Location = new Point(29, 16);
            txtMasterRegIndex14.MaxLength = 2;
            txtMasterRegIndex14.Name = "txtMasterRegIndex14";
            txtMasterRegIndex14.Size = new Size(79, 27);
            txtMasterRegIndex14.TabIndex = 90;
            txtMasterRegIndex14.Text = "13";
            // 
            // groupBox42
            // 
            groupBox42.Controls.Add(cmbDecimalPoint13);
            groupBox42.Controls.Add(label215);
            groupBox42.Controls.Add(cmbMasterFunctionCode13);
            groupBox42.Controls.Add(cmbMasterByteOrder13);
            groupBox42.Controls.Add(cmbMasterDataType13);
            groupBox42.Controls.Add(cmbMasterActivation13);
            groupBox42.Controls.Add(btnRegWriteMemory13);
            groupBox42.Controls.Add(btnRegReadMemory13);
            groupBox42.Controls.Add(txtMasterScaleFactor13);
            groupBox42.Controls.Add(txtMasterName13);
            groupBox42.Controls.Add(txtMasterRegStartAddress13);
            groupBox42.Controls.Add(txtMasterRegIndex13);
            groupBox42.Location = new Point(-2, 638);
            groupBox42.Name = "groupBox42";
            groupBox42.Size = new Size(1097, 51);
            groupBox42.TabIndex = 112;
            groupBox42.TabStop = false;
            // 
            // cmbDecimalPoint13
            // 
            cmbDecimalPoint13.FormattingEnabled = true;
            cmbDecimalPoint13.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint13.Location = new Point(816, 16);
            cmbDecimalPoint13.Name = "cmbDecimalPoint13";
            cmbDecimalPoint13.Size = new Size(55, 28);
            cmbDecimalPoint13.TabIndex = 135;
            // 
            // label215
            // 
            label215.AutoSize = true;
            label215.Location = new Point(0, 19);
            label215.Name = "label215";
            label215.Size = new Size(25, 20);
            label215.TabIndex = 128;
            label215.Text = "13";
            // 
            // cmbMasterFunctionCode13
            // 
            cmbMasterFunctionCode13.FormattingEnabled = true;
            cmbMasterFunctionCode13.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode13.Location = new Point(584, 16);
            cmbMasterFunctionCode13.Name = "cmbMasterFunctionCode13";
            cmbMasterFunctionCode13.Size = new Size(155, 28);
            cmbMasterFunctionCode13.TabIndex = 100;
            // 
            // cmbMasterByteOrder13
            // 
            cmbMasterByteOrder13.FormattingEnabled = true;
            cmbMasterByteOrder13.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder13.Location = new Point(487, 16);
            cmbMasterByteOrder13.Name = "cmbMasterByteOrder13";
            cmbMasterByteOrder13.Size = new Size(92, 28);
            cmbMasterByteOrder13.TabIndex = 99;
            // 
            // cmbMasterDataType13
            // 
            cmbMasterDataType13.FormattingEnabled = true;
            cmbMasterDataType13.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType13.Location = new Point(352, 16);
            cmbMasterDataType13.Name = "cmbMasterDataType13";
            cmbMasterDataType13.Size = new Size(130, 28);
            cmbMasterDataType13.TabIndex = 98;
            // 
            // cmbMasterActivation13
            // 
            cmbMasterActivation13.FormattingEnabled = true;
            cmbMasterActivation13.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation13.Location = new Point(280, 16);
            cmbMasterActivation13.Name = "cmbMasterActivation13";
            cmbMasterActivation13.Size = new Size(68, 28);
            cmbMasterActivation13.TabIndex = 97;
            // 
            // btnRegWriteMemory13
            // 
            btnRegWriteMemory13.BackColor = Color.Red;
            btnRegWriteMemory13.Cursor = Cursors.Hand;
            btnRegWriteMemory13.ForeColor = Color.White;
            btnRegWriteMemory13.Location = new Point(984, 15);
            btnRegWriteMemory13.Name = "btnRegWriteMemory13";
            btnRegWriteMemory13.Size = new Size(112, 30);
            btnRegWriteMemory13.TabIndex = 95;
            btnRegWriteMemory13.Text = "Write Memory";
            btnRegWriteMemory13.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory13
            // 
            btnRegReadMemory13.BackColor = Color.DarkKhaki;
            btnRegReadMemory13.Cursor = Cursors.Hand;
            btnRegReadMemory13.ForeColor = Color.White;
            btnRegReadMemory13.Location = new Point(872, 15);
            btnRegReadMemory13.Name = "btnRegReadMemory13";
            btnRegReadMemory13.Size = new Size(112, 30);
            btnRegReadMemory13.TabIndex = 94;
            btnRegReadMemory13.Text = "Read Memory";
            btnRegReadMemory13.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor13
            // 
            txtMasterScaleFactor13.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor13.Location = new Point(743, 16);
            txtMasterScaleFactor13.MaxLength = 10;
            txtMasterScaleFactor13.Name = "txtMasterScaleFactor13";
            txtMasterScaleFactor13.Size = new Size(69, 27);
            txtMasterScaleFactor13.TabIndex = 93;
            // 
            // txtMasterName13
            // 
            txtMasterName13.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName13.Location = new Point(221, 16);
            txtMasterName13.MaxLength = 5;
            txtMasterName13.Name = "txtMasterName13";
            txtMasterName13.Size = new Size(53, 27);
            txtMasterName13.TabIndex = 92;
            // 
            // txtMasterRegStartAddress13
            // 
            txtMasterRegStartAddress13.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress13.Location = new Point(108, 16);
            txtMasterRegStartAddress13.MaxLength = 10;
            txtMasterRegStartAddress13.Name = "txtMasterRegStartAddress13";
            txtMasterRegStartAddress13.Size = new Size(110, 27);
            txtMasterRegStartAddress13.TabIndex = 91;
            // 
            // txtMasterRegIndex13
            // 
            txtMasterRegIndex13.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex13.Enabled = false;
            txtMasterRegIndex13.Location = new Point(27, 16);
            txtMasterRegIndex13.MaxLength = 2;
            txtMasterRegIndex13.Name = "txtMasterRegIndex13";
            txtMasterRegIndex13.Size = new Size(79, 27);
            txtMasterRegIndex13.TabIndex = 90;
            txtMasterRegIndex13.Text = "12";
            // 
            // groupBox43
            // 
            groupBox43.Controls.Add(cmbDecimalPoint11);
            groupBox43.Controls.Add(label217);
            groupBox43.Controls.Add(cmbMasterFunctionCode11);
            groupBox43.Controls.Add(cmbMasterByteOrder11);
            groupBox43.Controls.Add(cmbMasterDataType11);
            groupBox43.Controls.Add(cmbMasterActivation11);
            groupBox43.Controls.Add(btnRegWriteMemory11);
            groupBox43.Controls.Add(btnRegReadMemory11);
            groupBox43.Controls.Add(txtMasterScaleFactor11);
            groupBox43.Controls.Add(txtMasterName11);
            groupBox43.Controls.Add(txtMasterRegStartAddress11);
            groupBox43.Controls.Add(txtMasterRegIndex11);
            groupBox43.Location = new Point(-4, 532);
            groupBox43.Name = "groupBox43";
            groupBox43.Size = new Size(1100, 51);
            groupBox43.TabIndex = 111;
            groupBox43.TabStop = false;
            // 
            // cmbDecimalPoint11
            // 
            cmbDecimalPoint11.FormattingEnabled = true;
            cmbDecimalPoint11.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint11.Location = new Point(817, 17);
            cmbDecimalPoint11.Name = "cmbDecimalPoint11";
            cmbDecimalPoint11.Size = new Size(55, 28);
            cmbDecimalPoint11.TabIndex = 133;
            // 
            // label217
            // 
            label217.AutoSize = true;
            label217.Location = new Point(2, 20);
            label217.Name = "label217";
            label217.Size = new Size(25, 20);
            label217.TabIndex = 130;
            label217.Text = "11";
            // 
            // cmbMasterFunctionCode11
            // 
            cmbMasterFunctionCode11.FormattingEnabled = true;
            cmbMasterFunctionCode11.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode11.Location = new Point(584, 16);
            cmbMasterFunctionCode11.Name = "cmbMasterFunctionCode11";
            cmbMasterFunctionCode11.Size = new Size(155, 28);
            cmbMasterFunctionCode11.TabIndex = 100;
            // 
            // cmbMasterByteOrder11
            // 
            cmbMasterByteOrder11.FormattingEnabled = true;
            cmbMasterByteOrder11.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder11.Location = new Point(487, 16);
            cmbMasterByteOrder11.Name = "cmbMasterByteOrder11";
            cmbMasterByteOrder11.Size = new Size(92, 28);
            cmbMasterByteOrder11.TabIndex = 99;
            // 
            // cmbMasterDataType11
            // 
            cmbMasterDataType11.FormattingEnabled = true;
            cmbMasterDataType11.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType11.Location = new Point(352, 16);
            cmbMasterDataType11.Name = "cmbMasterDataType11";
            cmbMasterDataType11.Size = new Size(130, 28);
            cmbMasterDataType11.TabIndex = 98;
            // 
            // cmbMasterActivation11
            // 
            cmbMasterActivation11.FormattingEnabled = true;
            cmbMasterActivation11.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation11.Location = new Point(280, 16);
            cmbMasterActivation11.Name = "cmbMasterActivation11";
            cmbMasterActivation11.Size = new Size(68, 28);
            cmbMasterActivation11.TabIndex = 97;
            // 
            // btnRegWriteMemory11
            // 
            btnRegWriteMemory11.BackColor = Color.Red;
            btnRegWriteMemory11.Cursor = Cursors.Hand;
            btnRegWriteMemory11.ForeColor = Color.White;
            btnRegWriteMemory11.Location = new Point(986, 15);
            btnRegWriteMemory11.Name = "btnRegWriteMemory11";
            btnRegWriteMemory11.Size = new Size(112, 30);
            btnRegWriteMemory11.TabIndex = 95;
            btnRegWriteMemory11.Text = "Write Memory";
            btnRegWriteMemory11.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory11
            // 
            btnRegReadMemory11.BackColor = Color.DarkKhaki;
            btnRegReadMemory11.Cursor = Cursors.Hand;
            btnRegReadMemory11.ForeColor = Color.White;
            btnRegReadMemory11.Location = new Point(874, 15);
            btnRegReadMemory11.Name = "btnRegReadMemory11";
            btnRegReadMemory11.Size = new Size(112, 30);
            btnRegReadMemory11.TabIndex = 94;
            btnRegReadMemory11.Text = "Read Memory";
            btnRegReadMemory11.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor11
            // 
            txtMasterScaleFactor11.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor11.Location = new Point(743, 16);
            txtMasterScaleFactor11.MaxLength = 10;
            txtMasterScaleFactor11.Name = "txtMasterScaleFactor11";
            txtMasterScaleFactor11.Size = new Size(69, 27);
            txtMasterScaleFactor11.TabIndex = 93;
            // 
            // txtMasterName11
            // 
            txtMasterName11.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName11.Location = new Point(223, 16);
            txtMasterName11.MaxLength = 5;
            txtMasterName11.Name = "txtMasterName11";
            txtMasterName11.Size = new Size(53, 27);
            txtMasterName11.TabIndex = 92;
            // 
            // txtMasterRegStartAddress11
            // 
            txtMasterRegStartAddress11.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress11.Location = new Point(110, 16);
            txtMasterRegStartAddress11.MaxLength = 10;
            txtMasterRegStartAddress11.Name = "txtMasterRegStartAddress11";
            txtMasterRegStartAddress11.Size = new Size(110, 27);
            txtMasterRegStartAddress11.TabIndex = 91;
            // 
            // txtMasterRegIndex11
            // 
            txtMasterRegIndex11.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex11.Enabled = false;
            txtMasterRegIndex11.Location = new Point(29, 16);
            txtMasterRegIndex11.MaxLength = 2;
            txtMasterRegIndex11.Name = "txtMasterRegIndex11";
            txtMasterRegIndex11.Size = new Size(79, 27);
            txtMasterRegIndex11.TabIndex = 90;
            txtMasterRegIndex11.Text = "10";
            // 
            // groupBox21
            // 
            groupBox21.Controls.Add(cmbDecimalPoint2);
            groupBox21.Controls.Add(label226);
            groupBox21.Controls.Add(cmbMasterFunctionCode2);
            groupBox21.Controls.Add(cmbMasterByteOrder2);
            groupBox21.Controls.Add(cmbMasterDataType2);
            groupBox21.Controls.Add(cmbMasterActivation2);
            groupBox21.Controls.Add(btnRegWriteMemory2);
            groupBox21.Controls.Add(btnRegReadMemory2);
            groupBox21.Controls.Add(txtMasterScaleFactor2);
            groupBox21.Controls.Add(txtMasterName2);
            groupBox21.Controls.Add(txtMasterRegStartAddress2);
            groupBox21.Controls.Add(txtMasterRegIndex2);
            groupBox21.Location = new Point(-2, 59);
            groupBox21.Name = "groupBox21";
            groupBox21.Size = new Size(1098, 51);
            groupBox21.TabIndex = 110;
            groupBox21.TabStop = false;
            // 
            // cmbDecimalPoint2
            // 
            cmbDecimalPoint2.FormattingEnabled = true;
            cmbDecimalPoint2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint2.Location = new Point(816, 15);
            cmbDecimalPoint2.Name = "cmbDecimalPoint2";
            cmbDecimalPoint2.Size = new Size(55, 28);
            cmbDecimalPoint2.TabIndex = 140;
            // 
            // label226
            // 
            label226.AutoSize = true;
            label226.Location = new Point(10, 19);
            label226.Name = "label226";
            label226.Size = new Size(17, 20);
            label226.TabIndex = 139;
            label226.Text = "2";
            // 
            // cmbMasterFunctionCode2
            // 
            cmbMasterFunctionCode2.FormattingEnabled = true;
            cmbMasterFunctionCode2.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode2.Location = new Point(585, 16);
            cmbMasterFunctionCode2.Name = "cmbMasterFunctionCode2";
            cmbMasterFunctionCode2.Size = new Size(155, 28);
            cmbMasterFunctionCode2.TabIndex = 100;
            // 
            // cmbMasterByteOrder2
            // 
            cmbMasterByteOrder2.FormattingEnabled = true;
            cmbMasterByteOrder2.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder2.Location = new Point(488, 16);
            cmbMasterByteOrder2.Name = "cmbMasterByteOrder2";
            cmbMasterByteOrder2.Size = new Size(92, 28);
            cmbMasterByteOrder2.TabIndex = 99;
            // 
            // cmbMasterDataType2
            // 
            cmbMasterDataType2.FormattingEnabled = true;
            cmbMasterDataType2.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType2.Location = new Point(353, 16);
            cmbMasterDataType2.Name = "cmbMasterDataType2";
            cmbMasterDataType2.Size = new Size(130, 28);
            cmbMasterDataType2.TabIndex = 98;
            // 
            // cmbMasterActivation2
            // 
            cmbMasterActivation2.FormattingEnabled = true;
            cmbMasterActivation2.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation2.Location = new Point(281, 16);
            cmbMasterActivation2.Name = "cmbMasterActivation2";
            cmbMasterActivation2.Size = new Size(68, 28);
            cmbMasterActivation2.TabIndex = 97;
            // 
            // btnRegWriteMemory2
            // 
            btnRegWriteMemory2.BackColor = Color.Red;
            btnRegWriteMemory2.Cursor = Cursors.Hand;
            btnRegWriteMemory2.ForeColor = Color.White;
            btnRegWriteMemory2.Location = new Point(986, 15);
            btnRegWriteMemory2.Name = "btnRegWriteMemory2";
            btnRegWriteMemory2.Size = new Size(112, 30);
            btnRegWriteMemory2.TabIndex = 95;
            btnRegWriteMemory2.Text = "Write Memory";
            btnRegWriteMemory2.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory2
            // 
            btnRegReadMemory2.BackColor = Color.DarkKhaki;
            btnRegReadMemory2.Cursor = Cursors.Hand;
            btnRegReadMemory2.ForeColor = Color.White;
            btnRegReadMemory2.Location = new Point(874, 15);
            btnRegReadMemory2.Name = "btnRegReadMemory2";
            btnRegReadMemory2.Size = new Size(112, 30);
            btnRegReadMemory2.TabIndex = 94;
            btnRegReadMemory2.Text = "Read Memory";
            btnRegReadMemory2.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor2
            // 
            txtMasterScaleFactor2.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor2.Location = new Point(744, 16);
            txtMasterScaleFactor2.MaxLength = 10;
            txtMasterScaleFactor2.Name = "txtMasterScaleFactor2";
            txtMasterScaleFactor2.Size = new Size(69, 27);
            txtMasterScaleFactor2.TabIndex = 93;
            // 
            // txtMasterName2
            // 
            txtMasterName2.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName2.Location = new Point(223, 16);
            txtMasterName2.MaxLength = 5;
            txtMasterName2.Name = "txtMasterName2";
            txtMasterName2.Size = new Size(53, 27);
            txtMasterName2.TabIndex = 92;
            // 
            // txtMasterRegStartAddress2
            // 
            txtMasterRegStartAddress2.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress2.Location = new Point(110, 16);
            txtMasterRegStartAddress2.MaxLength = 10;
            txtMasterRegStartAddress2.Name = "txtMasterRegStartAddress2";
            txtMasterRegStartAddress2.Size = new Size(110, 27);
            txtMasterRegStartAddress2.TabIndex = 91;
            // 
            // txtMasterRegIndex2
            // 
            txtMasterRegIndex2.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex2.Enabled = false;
            txtMasterRegIndex2.Location = new Point(29, 16);
            txtMasterRegIndex2.MaxLength = 2;
            txtMasterRegIndex2.Name = "txtMasterRegIndex2";
            txtMasterRegIndex2.Size = new Size(79, 27);
            txtMasterRegIndex2.TabIndex = 90;
            txtMasterRegIndex2.Text = "1";
            // 
            // groupBox32
            // 
            groupBox32.Controls.Add(cmbDecimalPoint10);
            groupBox32.Controls.Add(label218);
            groupBox32.Controls.Add(cmbMasterFunctionCode10);
            groupBox32.Controls.Add(cmbMasterByteOrder10);
            groupBox32.Controls.Add(cmbMasterDataType10);
            groupBox32.Controls.Add(cmbMasterActivation10);
            groupBox32.Controls.Add(btnRegWriteMemory10);
            groupBox32.Controls.Add(btnRegReadMemory10);
            groupBox32.Controls.Add(txtMasterScaleFactor10);
            groupBox32.Controls.Add(txtMasterName10);
            groupBox32.Controls.Add(txtMasterRegStartAddress10);
            groupBox32.Controls.Add(txtMasterRegIndex10);
            groupBox32.Location = new Point(-3, 479);
            groupBox32.Name = "groupBox32";
            groupBox32.Size = new Size(1097, 51);
            groupBox32.TabIndex = 109;
            groupBox32.TabStop = false;
            // 
            // cmbDecimalPoint10
            // 
            cmbDecimalPoint10.FormattingEnabled = true;
            cmbDecimalPoint10.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint10.Location = new Point(816, 15);
            cmbDecimalPoint10.Name = "cmbDecimalPoint10";
            cmbDecimalPoint10.Size = new Size(55, 28);
            cmbDecimalPoint10.TabIndex = 132;
            // 
            // label218
            // 
            label218.AutoSize = true;
            label218.Location = new Point(2, 19);
            label218.Name = "label218";
            label218.Size = new Size(25, 20);
            label218.TabIndex = 131;
            label218.Text = "10";
            // 
            // cmbMasterFunctionCode10
            // 
            cmbMasterFunctionCode10.FormattingEnabled = true;
            cmbMasterFunctionCode10.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode10.Location = new Point(584, 16);
            cmbMasterFunctionCode10.Name = "cmbMasterFunctionCode10";
            cmbMasterFunctionCode10.Size = new Size(155, 28);
            cmbMasterFunctionCode10.TabIndex = 100;
            // 
            // cmbMasterByteOrder10
            // 
            cmbMasterByteOrder10.FormattingEnabled = true;
            cmbMasterByteOrder10.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder10.Location = new Point(487, 16);
            cmbMasterByteOrder10.Name = "cmbMasterByteOrder10";
            cmbMasterByteOrder10.Size = new Size(92, 28);
            cmbMasterByteOrder10.TabIndex = 99;
            // 
            // cmbMasterDataType10
            // 
            cmbMasterDataType10.FormattingEnabled = true;
            cmbMasterDataType10.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType10.Location = new Point(352, 16);
            cmbMasterDataType10.Name = "cmbMasterDataType10";
            cmbMasterDataType10.Size = new Size(130, 28);
            cmbMasterDataType10.TabIndex = 98;
            // 
            // cmbMasterActivation10
            // 
            cmbMasterActivation10.FormattingEnabled = true;
            cmbMasterActivation10.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation10.Location = new Point(280, 16);
            cmbMasterActivation10.Name = "cmbMasterActivation10";
            cmbMasterActivation10.Size = new Size(68, 28);
            cmbMasterActivation10.TabIndex = 97;
            // 
            // btnRegWriteMemory10
            // 
            btnRegWriteMemory10.BackColor = Color.Red;
            btnRegWriteMemory10.Cursor = Cursors.Hand;
            btnRegWriteMemory10.ForeColor = Color.White;
            btnRegWriteMemory10.Location = new Point(985, 15);
            btnRegWriteMemory10.Name = "btnRegWriteMemory10";
            btnRegWriteMemory10.Size = new Size(112, 30);
            btnRegWriteMemory10.TabIndex = 95;
            btnRegWriteMemory10.Text = "Write Memory";
            btnRegWriteMemory10.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory10
            // 
            btnRegReadMemory10.BackColor = Color.DarkKhaki;
            btnRegReadMemory10.Cursor = Cursors.Hand;
            btnRegReadMemory10.ForeColor = Color.White;
            btnRegReadMemory10.Location = new Point(873, 15);
            btnRegReadMemory10.Name = "btnRegReadMemory10";
            btnRegReadMemory10.Size = new Size(112, 30);
            btnRegReadMemory10.TabIndex = 94;
            btnRegReadMemory10.Text = "Read Memory";
            btnRegReadMemory10.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor10
            // 
            txtMasterScaleFactor10.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor10.Location = new Point(743, 16);
            txtMasterScaleFactor10.MaxLength = 10;
            txtMasterScaleFactor10.Name = "txtMasterScaleFactor10";
            txtMasterScaleFactor10.Size = new Size(69, 27);
            txtMasterScaleFactor10.TabIndex = 93;
            // 
            // txtMasterName10
            // 
            txtMasterName10.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName10.Location = new Point(222, 16);
            txtMasterName10.MaxLength = 5;
            txtMasterName10.Name = "txtMasterName10";
            txtMasterName10.Size = new Size(53, 27);
            txtMasterName10.TabIndex = 92;
            // 
            // txtMasterRegStartAddress10
            // 
            txtMasterRegStartAddress10.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress10.Location = new Point(109, 16);
            txtMasterRegStartAddress10.MaxLength = 10;
            txtMasterRegStartAddress10.Name = "txtMasterRegStartAddress10";
            txtMasterRegStartAddress10.Size = new Size(110, 27);
            txtMasterRegStartAddress10.TabIndex = 91;
            // 
            // txtMasterRegIndex10
            // 
            txtMasterRegIndex10.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex10.Enabled = false;
            txtMasterRegIndex10.Location = new Point(28, 16);
            txtMasterRegIndex10.MaxLength = 2;
            txtMasterRegIndex10.Name = "txtMasterRegIndex10";
            txtMasterRegIndex10.Size = new Size(79, 27);
            txtMasterRegIndex10.TabIndex = 90;
            txtMasterRegIndex10.Text = "9";
            // 
            // groupBox33
            // 
            groupBox33.Controls.Add(cmbDecimalPoint9);
            groupBox33.Controls.Add(label219);
            groupBox33.Controls.Add(cmbMasterFunctionCode9);
            groupBox33.Controls.Add(cmbMasterByteOrder9);
            groupBox33.Controls.Add(cmbMasterDataType9);
            groupBox33.Controls.Add(cmbMasterActivation9);
            groupBox33.Controls.Add(btnRegWriteMemory9);
            groupBox33.Controls.Add(btnRegReadMemory9);
            groupBox33.Controls.Add(txtMasterScaleFactor9);
            groupBox33.Controls.Add(txtMasterName9);
            groupBox33.Controls.Add(txtMasterRegStartAddress9);
            groupBox33.Controls.Add(txtMasterRegIndex9);
            groupBox33.Location = new Point(-3, 427);
            groupBox33.Name = "groupBox33";
            groupBox33.Size = new Size(1097, 51);
            groupBox33.TabIndex = 108;
            groupBox33.TabStop = false;
            // 
            // cmbDecimalPoint9
            // 
            cmbDecimalPoint9.FormattingEnabled = true;
            cmbDecimalPoint9.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint9.Location = new Point(816, 15);
            cmbDecimalPoint9.Name = "cmbDecimalPoint9";
            cmbDecimalPoint9.Size = new Size(55, 28);
            cmbDecimalPoint9.TabIndex = 141;
            // 
            // label219
            // 
            label219.AutoSize = true;
            label219.Location = new Point(9, 19);
            label219.Name = "label219";
            label219.Size = new Size(17, 20);
            label219.TabIndex = 132;
            label219.Text = "9";
            // 
            // cmbMasterFunctionCode9
            // 
            cmbMasterFunctionCode9.FormattingEnabled = true;
            cmbMasterFunctionCode9.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode9.Location = new Point(584, 16);
            cmbMasterFunctionCode9.Name = "cmbMasterFunctionCode9";
            cmbMasterFunctionCode9.Size = new Size(155, 28);
            cmbMasterFunctionCode9.TabIndex = 100;
            // 
            // cmbMasterByteOrder9
            // 
            cmbMasterByteOrder9.FormattingEnabled = true;
            cmbMasterByteOrder9.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder9.Location = new Point(487, 16);
            cmbMasterByteOrder9.Name = "cmbMasterByteOrder9";
            cmbMasterByteOrder9.Size = new Size(92, 28);
            cmbMasterByteOrder9.TabIndex = 99;
            // 
            // cmbMasterDataType9
            // 
            cmbMasterDataType9.FormattingEnabled = true;
            cmbMasterDataType9.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType9.Location = new Point(352, 16);
            cmbMasterDataType9.Name = "cmbMasterDataType9";
            cmbMasterDataType9.Size = new Size(130, 28);
            cmbMasterDataType9.TabIndex = 98;
            // 
            // cmbMasterActivation9
            // 
            cmbMasterActivation9.FormattingEnabled = true;
            cmbMasterActivation9.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation9.Location = new Point(280, 16);
            cmbMasterActivation9.Name = "cmbMasterActivation9";
            cmbMasterActivation9.Size = new Size(68, 28);
            cmbMasterActivation9.TabIndex = 97;
            // 
            // btnRegWriteMemory9
            // 
            btnRegWriteMemory9.BackColor = Color.Red;
            btnRegWriteMemory9.Cursor = Cursors.Hand;
            btnRegWriteMemory9.ForeColor = Color.White;
            btnRegWriteMemory9.Location = new Point(985, 15);
            btnRegWriteMemory9.Name = "btnRegWriteMemory9";
            btnRegWriteMemory9.Size = new Size(112, 30);
            btnRegWriteMemory9.TabIndex = 95;
            btnRegWriteMemory9.Text = "Write Memory";
            btnRegWriteMemory9.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory9
            // 
            btnRegReadMemory9.BackColor = Color.DarkKhaki;
            btnRegReadMemory9.Cursor = Cursors.Hand;
            btnRegReadMemory9.ForeColor = Color.White;
            btnRegReadMemory9.Location = new Point(873, 15);
            btnRegReadMemory9.Name = "btnRegReadMemory9";
            btnRegReadMemory9.Size = new Size(112, 30);
            btnRegReadMemory9.TabIndex = 94;
            btnRegReadMemory9.Text = "Read Memory";
            btnRegReadMemory9.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor9
            // 
            txtMasterScaleFactor9.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor9.Location = new Point(743, 16);
            txtMasterScaleFactor9.MaxLength = 10;
            txtMasterScaleFactor9.Name = "txtMasterScaleFactor9";
            txtMasterScaleFactor9.Size = new Size(69, 27);
            txtMasterScaleFactor9.TabIndex = 93;
            // 
            // txtMasterName9
            // 
            txtMasterName9.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName9.Location = new Point(222, 16);
            txtMasterName9.MaxLength = 5;
            txtMasterName9.Name = "txtMasterName9";
            txtMasterName9.Size = new Size(53, 27);
            txtMasterName9.TabIndex = 92;
            // 
            // txtMasterRegStartAddress9
            // 
            txtMasterRegStartAddress9.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress9.Location = new Point(109, 16);
            txtMasterRegStartAddress9.MaxLength = 10;
            txtMasterRegStartAddress9.Name = "txtMasterRegStartAddress9";
            txtMasterRegStartAddress9.Size = new Size(110, 27);
            txtMasterRegStartAddress9.TabIndex = 91;
            // 
            // txtMasterRegIndex9
            // 
            txtMasterRegIndex9.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex9.Enabled = false;
            txtMasterRegIndex9.Location = new Point(28, 16);
            txtMasterRegIndex9.MaxLength = 2;
            txtMasterRegIndex9.Name = "txtMasterRegIndex9";
            txtMasterRegIndex9.Size = new Size(79, 27);
            txtMasterRegIndex9.TabIndex = 90;
            txtMasterRegIndex9.Text = "8";
            // 
            // groupBox28
            // 
            groupBox28.Controls.Add(cmbDecimalPoint8);
            groupBox28.Controls.Add(label220);
            groupBox28.Controls.Add(cmbMasterFunctionCode8);
            groupBox28.Controls.Add(cmbMasterByteOrder8);
            groupBox28.Controls.Add(cmbMasterDataType8);
            groupBox28.Controls.Add(cmbMasterActivation8);
            groupBox28.Controls.Add(btnRegWriteMemory8);
            groupBox28.Controls.Add(btnRegReadMemory8);
            groupBox28.Controls.Add(txtMasterScaleFactor8);
            groupBox28.Controls.Add(txtMasterName8);
            groupBox28.Controls.Add(txtMasterRegStartAddress8);
            groupBox28.Controls.Add(txtMasterRegIndex8);
            groupBox28.Location = new Point(-3, 375);
            groupBox28.Name = "groupBox28";
            groupBox28.Size = new Size(1097, 51);
            groupBox28.TabIndex = 107;
            groupBox28.TabStop = false;
            // 
            // cmbDecimalPoint8
            // 
            cmbDecimalPoint8.FormattingEnabled = true;
            cmbDecimalPoint8.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint8.Location = new Point(816, 16);
            cmbDecimalPoint8.Name = "cmbDecimalPoint8";
            cmbDecimalPoint8.Size = new Size(55, 28);
            cmbDecimalPoint8.TabIndex = 141;
            // 
            // label220
            // 
            label220.AutoSize = true;
            label220.Location = new Point(10, 19);
            label220.Name = "label220";
            label220.Size = new Size(17, 20);
            label220.TabIndex = 133;
            label220.Text = "8";
            // 
            // cmbMasterFunctionCode8
            // 
            cmbMasterFunctionCode8.FormattingEnabled = true;
            cmbMasterFunctionCode8.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode8.Location = new Point(585, 16);
            cmbMasterFunctionCode8.Name = "cmbMasterFunctionCode8";
            cmbMasterFunctionCode8.Size = new Size(155, 28);
            cmbMasterFunctionCode8.TabIndex = 100;
            // 
            // cmbMasterByteOrder8
            // 
            cmbMasterByteOrder8.FormattingEnabled = true;
            cmbMasterByteOrder8.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder8.Location = new Point(488, 16);
            cmbMasterByteOrder8.Name = "cmbMasterByteOrder8";
            cmbMasterByteOrder8.Size = new Size(92, 28);
            cmbMasterByteOrder8.TabIndex = 99;
            // 
            // cmbMasterDataType8
            // 
            cmbMasterDataType8.FormattingEnabled = true;
            cmbMasterDataType8.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType8.Location = new Point(353, 16);
            cmbMasterDataType8.Name = "cmbMasterDataType8";
            cmbMasterDataType8.Size = new Size(130, 28);
            cmbMasterDataType8.TabIndex = 98;
            // 
            // cmbMasterActivation8
            // 
            cmbMasterActivation8.FormattingEnabled = true;
            cmbMasterActivation8.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation8.Location = new Point(281, 16);
            cmbMasterActivation8.Name = "cmbMasterActivation8";
            cmbMasterActivation8.Size = new Size(68, 28);
            cmbMasterActivation8.TabIndex = 97;
            // 
            // btnRegWriteMemory8
            // 
            btnRegWriteMemory8.BackColor = Color.Red;
            btnRegWriteMemory8.Cursor = Cursors.Hand;
            btnRegWriteMemory8.ForeColor = Color.White;
            btnRegWriteMemory8.Location = new Point(986, 15);
            btnRegWriteMemory8.Name = "btnRegWriteMemory8";
            btnRegWriteMemory8.Size = new Size(112, 30);
            btnRegWriteMemory8.TabIndex = 95;
            btnRegWriteMemory8.Text = "Write Memory";
            btnRegWriteMemory8.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory8
            // 
            btnRegReadMemory8.BackColor = Color.DarkKhaki;
            btnRegReadMemory8.Cursor = Cursors.Hand;
            btnRegReadMemory8.ForeColor = Color.White;
            btnRegReadMemory8.Location = new Point(874, 15);
            btnRegReadMemory8.Name = "btnRegReadMemory8";
            btnRegReadMemory8.Size = new Size(112, 30);
            btnRegReadMemory8.TabIndex = 94;
            btnRegReadMemory8.Text = "Read Memory";
            btnRegReadMemory8.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor8
            // 
            txtMasterScaleFactor8.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor8.Location = new Point(744, 16);
            txtMasterScaleFactor8.MaxLength = 10;
            txtMasterScaleFactor8.Name = "txtMasterScaleFactor8";
            txtMasterScaleFactor8.Size = new Size(69, 27);
            txtMasterScaleFactor8.TabIndex = 93;
            // 
            // txtMasterName8
            // 
            txtMasterName8.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName8.Location = new Point(223, 16);
            txtMasterName8.MaxLength = 5;
            txtMasterName8.Name = "txtMasterName8";
            txtMasterName8.Size = new Size(53, 27);
            txtMasterName8.TabIndex = 92;
            // 
            // txtMasterRegStartAddress8
            // 
            txtMasterRegStartAddress8.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress8.Location = new Point(110, 16);
            txtMasterRegStartAddress8.MaxLength = 10;
            txtMasterRegStartAddress8.Name = "txtMasterRegStartAddress8";
            txtMasterRegStartAddress8.Size = new Size(110, 27);
            txtMasterRegStartAddress8.TabIndex = 91;
            // 
            // txtMasterRegIndex8
            // 
            txtMasterRegIndex8.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex8.Enabled = false;
            txtMasterRegIndex8.Location = new Point(29, 16);
            txtMasterRegIndex8.MaxLength = 2;
            txtMasterRegIndex8.Name = "txtMasterRegIndex8";
            txtMasterRegIndex8.Size = new Size(79, 27);
            txtMasterRegIndex8.TabIndex = 90;
            txtMasterRegIndex8.Text = "7";
            // 
            // groupBox29
            // 
            groupBox29.Controls.Add(cmbDecimalPoint6);
            groupBox29.Controls.Add(label222);
            groupBox29.Controls.Add(cmbMasterFunctionCode6);
            groupBox29.Controls.Add(cmbMasterByteOrder6);
            groupBox29.Controls.Add(cmbMasterDataType6);
            groupBox29.Controls.Add(cmbMasterActivation6);
            groupBox29.Controls.Add(btnRegWriteMemory6);
            groupBox29.Controls.Add(btnRegReadMemory6);
            groupBox29.Controls.Add(txtMasterScaleFactor6);
            groupBox29.Controls.Add(txtMasterName6);
            groupBox29.Controls.Add(txtMasterRegStartAddress6);
            groupBox29.Controls.Add(txtMasterRegIndex6);
            groupBox29.Location = new Point(-4, 270);
            groupBox29.Name = "groupBox29";
            groupBox29.Size = new Size(1100, 51);
            groupBox29.TabIndex = 106;
            groupBox29.TabStop = false;
            // 
            // cmbDecimalPoint6
            // 
            cmbDecimalPoint6.FormattingEnabled = true;
            cmbDecimalPoint6.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint6.Location = new Point(819, 16);
            cmbDecimalPoint6.Name = "cmbDecimalPoint6";
            cmbDecimalPoint6.Size = new Size(55, 28);
            cmbDecimalPoint6.TabIndex = 139;
            // 
            // label222
            // 
            label222.AutoSize = true;
            label222.Location = new Point(12, 19);
            label222.Name = "label222";
            label222.Size = new Size(17, 20);
            label222.TabIndex = 135;
            label222.Text = "6";
            // 
            // cmbMasterFunctionCode6
            // 
            cmbMasterFunctionCode6.FormattingEnabled = true;
            cmbMasterFunctionCode6.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode6.Location = new Point(588, 16);
            cmbMasterFunctionCode6.Name = "cmbMasterFunctionCode6";
            cmbMasterFunctionCode6.Size = new Size(155, 28);
            cmbMasterFunctionCode6.TabIndex = 100;
            // 
            // cmbMasterByteOrder6
            // 
            cmbMasterByteOrder6.FormattingEnabled = true;
            cmbMasterByteOrder6.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder6.Location = new Point(491, 16);
            cmbMasterByteOrder6.Name = "cmbMasterByteOrder6";
            cmbMasterByteOrder6.Size = new Size(92, 28);
            cmbMasterByteOrder6.TabIndex = 99;
            // 
            // cmbMasterDataType6
            // 
            cmbMasterDataType6.FormattingEnabled = true;
            cmbMasterDataType6.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType6.Location = new Point(356, 16);
            cmbMasterDataType6.Name = "cmbMasterDataType6";
            cmbMasterDataType6.Size = new Size(130, 28);
            cmbMasterDataType6.TabIndex = 98;
            // 
            // cmbMasterActivation6
            // 
            cmbMasterActivation6.FormattingEnabled = true;
            cmbMasterActivation6.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation6.Location = new Point(284, 16);
            cmbMasterActivation6.Name = "cmbMasterActivation6";
            cmbMasterActivation6.Size = new Size(68, 28);
            cmbMasterActivation6.TabIndex = 97;
            // 
            // btnRegWriteMemory6
            // 
            btnRegWriteMemory6.BackColor = Color.Red;
            btnRegWriteMemory6.Cursor = Cursors.Hand;
            btnRegWriteMemory6.ForeColor = Color.White;
            btnRegWriteMemory6.Location = new Point(988, 15);
            btnRegWriteMemory6.Name = "btnRegWriteMemory6";
            btnRegWriteMemory6.Size = new Size(112, 30);
            btnRegWriteMemory6.TabIndex = 95;
            btnRegWriteMemory6.Text = "Write Memory";
            btnRegWriteMemory6.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory6
            // 
            btnRegReadMemory6.BackColor = Color.DarkKhaki;
            btnRegReadMemory6.Cursor = Cursors.Hand;
            btnRegReadMemory6.ForeColor = Color.White;
            btnRegReadMemory6.Location = new Point(876, 15);
            btnRegReadMemory6.Name = "btnRegReadMemory6";
            btnRegReadMemory6.Size = new Size(112, 30);
            btnRegReadMemory6.TabIndex = 94;
            btnRegReadMemory6.Text = "Read Memory";
            btnRegReadMemory6.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor6
            // 
            txtMasterScaleFactor6.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor6.Location = new Point(747, 16);
            txtMasterScaleFactor6.MaxLength = 10;
            txtMasterScaleFactor6.Name = "txtMasterScaleFactor6";
            txtMasterScaleFactor6.Size = new Size(69, 27);
            txtMasterScaleFactor6.TabIndex = 93;
            // 
            // txtMasterName6
            // 
            txtMasterName6.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName6.Location = new Point(225, 16);
            txtMasterName6.MaxLength = 5;
            txtMasterName6.Name = "txtMasterName6";
            txtMasterName6.Size = new Size(53, 27);
            txtMasterName6.TabIndex = 92;
            // 
            // txtMasterRegStartAddress6
            // 
            txtMasterRegStartAddress6.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress6.Location = new Point(112, 16);
            txtMasterRegStartAddress6.MaxLength = 10;
            txtMasterRegStartAddress6.Name = "txtMasterRegStartAddress6";
            txtMasterRegStartAddress6.Size = new Size(110, 27);
            txtMasterRegStartAddress6.TabIndex = 91;
            // 
            // txtMasterRegIndex6
            // 
            txtMasterRegIndex6.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex6.Enabled = false;
            txtMasterRegIndex6.Location = new Point(31, 16);
            txtMasterRegIndex6.MaxLength = 2;
            txtMasterRegIndex6.Name = "txtMasterRegIndex6";
            txtMasterRegIndex6.Size = new Size(79, 27);
            txtMasterRegIndex6.TabIndex = 90;
            txtMasterRegIndex6.Text = "5";
            // 
            // groupBox30
            // 
            groupBox30.Controls.Add(cmbDecimalPoint7);
            groupBox30.Controls.Add(label221);
            groupBox30.Controls.Add(cmbMasterFunctionCode7);
            groupBox30.Controls.Add(cmbMasterByteOrder7);
            groupBox30.Controls.Add(cmbMasterDataType7);
            groupBox30.Controls.Add(cmbMasterActivation7);
            groupBox30.Controls.Add(btnRegWriteMemory7);
            groupBox30.Controls.Add(btnRegReadMemory7);
            groupBox30.Controls.Add(txtMasterScaleFactor7);
            groupBox30.Controls.Add(txtMasterName7);
            groupBox30.Controls.Add(txtMasterRegStartAddress7);
            groupBox30.Controls.Add(txtMasterRegIndex7);
            groupBox30.Location = new Point(-3, 323);
            groupBox30.Name = "groupBox30";
            groupBox30.Size = new Size(1099, 51);
            groupBox30.TabIndex = 105;
            groupBox30.TabStop = false;
            // 
            // cmbDecimalPoint7
            // 
            cmbDecimalPoint7.FormattingEnabled = true;
            cmbDecimalPoint7.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint7.Location = new Point(817, 16);
            cmbDecimalPoint7.Name = "cmbDecimalPoint7";
            cmbDecimalPoint7.Size = new Size(55, 28);
            cmbDecimalPoint7.TabIndex = 140;
            // 
            // label221
            // 
            label221.AutoSize = true;
            label221.Location = new Point(10, 19);
            label221.Name = "label221";
            label221.Size = new Size(17, 20);
            label221.TabIndex = 134;
            label221.Text = "7";
            // 
            // cmbMasterFunctionCode7
            // 
            cmbMasterFunctionCode7.FormattingEnabled = true;
            cmbMasterFunctionCode7.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode7.Location = new Point(585, 16);
            cmbMasterFunctionCode7.Name = "cmbMasterFunctionCode7";
            cmbMasterFunctionCode7.Size = new Size(155, 28);
            cmbMasterFunctionCode7.TabIndex = 100;
            // 
            // cmbMasterByteOrder7
            // 
            cmbMasterByteOrder7.FormattingEnabled = true;
            cmbMasterByteOrder7.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder7.Location = new Point(488, 16);
            cmbMasterByteOrder7.Name = "cmbMasterByteOrder7";
            cmbMasterByteOrder7.Size = new Size(92, 28);
            cmbMasterByteOrder7.TabIndex = 99;
            // 
            // cmbMasterDataType7
            // 
            cmbMasterDataType7.FormattingEnabled = true;
            cmbMasterDataType7.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType7.Location = new Point(353, 16);
            cmbMasterDataType7.Name = "cmbMasterDataType7";
            cmbMasterDataType7.Size = new Size(130, 28);
            cmbMasterDataType7.TabIndex = 98;
            // 
            // cmbMasterActivation7
            // 
            cmbMasterActivation7.FormattingEnabled = true;
            cmbMasterActivation7.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation7.Location = new Point(281, 16);
            cmbMasterActivation7.Name = "cmbMasterActivation7";
            cmbMasterActivation7.Size = new Size(68, 28);
            cmbMasterActivation7.TabIndex = 97;
            // 
            // btnRegWriteMemory7
            // 
            btnRegWriteMemory7.BackColor = Color.Red;
            btnRegWriteMemory7.Cursor = Cursors.Hand;
            btnRegWriteMemory7.ForeColor = Color.White;
            btnRegWriteMemory7.Location = new Point(986, 15);
            btnRegWriteMemory7.Name = "btnRegWriteMemory7";
            btnRegWriteMemory7.Size = new Size(112, 30);
            btnRegWriteMemory7.TabIndex = 95;
            btnRegWriteMemory7.Text = "Write Memory";
            btnRegWriteMemory7.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory7
            // 
            btnRegReadMemory7.BackColor = Color.DarkKhaki;
            btnRegReadMemory7.Cursor = Cursors.Hand;
            btnRegReadMemory7.ForeColor = Color.White;
            btnRegReadMemory7.Location = new Point(874, 15);
            btnRegReadMemory7.Name = "btnRegReadMemory7";
            btnRegReadMemory7.Size = new Size(112, 30);
            btnRegReadMemory7.TabIndex = 94;
            btnRegReadMemory7.Text = "Read Memory";
            btnRegReadMemory7.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor7
            // 
            txtMasterScaleFactor7.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor7.Location = new Point(744, 16);
            txtMasterScaleFactor7.MaxLength = 10;
            txtMasterScaleFactor7.Name = "txtMasterScaleFactor7";
            txtMasterScaleFactor7.Size = new Size(69, 27);
            txtMasterScaleFactor7.TabIndex = 93;
            // 
            // txtMasterName7
            // 
            txtMasterName7.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName7.Location = new Point(223, 16);
            txtMasterName7.MaxLength = 5;
            txtMasterName7.Name = "txtMasterName7";
            txtMasterName7.Size = new Size(53, 27);
            txtMasterName7.TabIndex = 92;
            // 
            // txtMasterRegStartAddress7
            // 
            txtMasterRegStartAddress7.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress7.Location = new Point(110, 16);
            txtMasterRegStartAddress7.MaxLength = 10;
            txtMasterRegStartAddress7.Name = "txtMasterRegStartAddress7";
            txtMasterRegStartAddress7.Size = new Size(110, 27);
            txtMasterRegStartAddress7.TabIndex = 91;
            // 
            // txtMasterRegIndex7
            // 
            txtMasterRegIndex7.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex7.Enabled = false;
            txtMasterRegIndex7.Location = new Point(29, 16);
            txtMasterRegIndex7.MaxLength = 2;
            txtMasterRegIndex7.Name = "txtMasterRegIndex7";
            txtMasterRegIndex7.Size = new Size(79, 27);
            txtMasterRegIndex7.TabIndex = 90;
            txtMasterRegIndex7.Text = "6";
            // 
            // groupBox31
            // 
            groupBox31.Controls.Add(cmbDecimalPoint5);
            groupBox31.Controls.Add(label223);
            groupBox31.Controls.Add(cmbMasterFunctionCode5);
            groupBox31.Controls.Add(cmbMasterByteOrder5);
            groupBox31.Controls.Add(cmbMasterDataType5);
            groupBox31.Controls.Add(cmbMasterActivation5);
            groupBox31.Controls.Add(btnRegWriteMemory5);
            groupBox31.Controls.Add(btnRegReadMemory5);
            groupBox31.Controls.Add(txtMasterScaleFactor5);
            groupBox31.Controls.Add(txtMasterName5);
            groupBox31.Controls.Add(txtMasterRegStartAddress5);
            groupBox31.Controls.Add(txtMasterRegIndex5);
            groupBox31.Location = new Point(-2, 217);
            groupBox31.Name = "groupBox31";
            groupBox31.Size = new Size(1098, 51);
            groupBox31.TabIndex = 104;
            groupBox31.TabStop = false;
            // 
            // cmbDecimalPoint5
            // 
            cmbDecimalPoint5.FormattingEnabled = true;
            cmbDecimalPoint5.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint5.Location = new Point(817, 16);
            cmbDecimalPoint5.Name = "cmbDecimalPoint5";
            cmbDecimalPoint5.Size = new Size(55, 28);
            cmbDecimalPoint5.TabIndex = 139;
            // 
            // label223
            // 
            label223.AutoSize = true;
            label223.Location = new Point(10, 19);
            label223.Name = "label223";
            label223.Size = new Size(17, 20);
            label223.TabIndex = 136;
            label223.Text = "5";
            // 
            // cmbMasterFunctionCode5
            // 
            cmbMasterFunctionCode5.FormattingEnabled = true;
            cmbMasterFunctionCode5.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode5.Location = new Point(585, 16);
            cmbMasterFunctionCode5.Name = "cmbMasterFunctionCode5";
            cmbMasterFunctionCode5.Size = new Size(155, 28);
            cmbMasterFunctionCode5.TabIndex = 100;
            // 
            // cmbMasterByteOrder5
            // 
            cmbMasterByteOrder5.FormattingEnabled = true;
            cmbMasterByteOrder5.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder5.Location = new Point(488, 16);
            cmbMasterByteOrder5.Name = "cmbMasterByteOrder5";
            cmbMasterByteOrder5.Size = new Size(92, 28);
            cmbMasterByteOrder5.TabIndex = 99;
            // 
            // cmbMasterDataType5
            // 
            cmbMasterDataType5.FormattingEnabled = true;
            cmbMasterDataType5.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType5.Location = new Point(353, 16);
            cmbMasterDataType5.Name = "cmbMasterDataType5";
            cmbMasterDataType5.Size = new Size(130, 28);
            cmbMasterDataType5.TabIndex = 98;
            // 
            // cmbMasterActivation5
            // 
            cmbMasterActivation5.FormattingEnabled = true;
            cmbMasterActivation5.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation5.Location = new Point(281, 16);
            cmbMasterActivation5.Name = "cmbMasterActivation5";
            cmbMasterActivation5.Size = new Size(68, 28);
            cmbMasterActivation5.TabIndex = 97;
            // 
            // btnRegWriteMemory5
            // 
            btnRegWriteMemory5.BackColor = Color.Red;
            btnRegWriteMemory5.Cursor = Cursors.Hand;
            btnRegWriteMemory5.ForeColor = Color.White;
            btnRegWriteMemory5.Location = new Point(986, 15);
            btnRegWriteMemory5.Name = "btnRegWriteMemory5";
            btnRegWriteMemory5.Size = new Size(112, 30);
            btnRegWriteMemory5.TabIndex = 95;
            btnRegWriteMemory5.Text = "Write Memory";
            btnRegWriteMemory5.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory5
            // 
            btnRegReadMemory5.BackColor = Color.DarkKhaki;
            btnRegReadMemory5.Cursor = Cursors.Hand;
            btnRegReadMemory5.ForeColor = Color.White;
            btnRegReadMemory5.Location = new Point(874, 15);
            btnRegReadMemory5.Name = "btnRegReadMemory5";
            btnRegReadMemory5.Size = new Size(112, 30);
            btnRegReadMemory5.TabIndex = 94;
            btnRegReadMemory5.Text = "Read Memory";
            btnRegReadMemory5.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor5
            // 
            txtMasterScaleFactor5.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor5.Location = new Point(744, 16);
            txtMasterScaleFactor5.MaxLength = 10;
            txtMasterScaleFactor5.Name = "txtMasterScaleFactor5";
            txtMasterScaleFactor5.Size = new Size(69, 27);
            txtMasterScaleFactor5.TabIndex = 93;
            // 
            // txtMasterName5
            // 
            txtMasterName5.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName5.Location = new Point(223, 16);
            txtMasterName5.MaxLength = 5;
            txtMasterName5.Name = "txtMasterName5";
            txtMasterName5.Size = new Size(53, 27);
            txtMasterName5.TabIndex = 92;
            // 
            // txtMasterRegStartAddress5
            // 
            txtMasterRegStartAddress5.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress5.Location = new Point(110, 16);
            txtMasterRegStartAddress5.MaxLength = 10;
            txtMasterRegStartAddress5.Name = "txtMasterRegStartAddress5";
            txtMasterRegStartAddress5.Size = new Size(110, 27);
            txtMasterRegStartAddress5.TabIndex = 91;
            // 
            // txtMasterRegIndex5
            // 
            txtMasterRegIndex5.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex5.Enabled = false;
            txtMasterRegIndex5.Location = new Point(29, 16);
            txtMasterRegIndex5.MaxLength = 2;
            txtMasterRegIndex5.Name = "txtMasterRegIndex5";
            txtMasterRegIndex5.Size = new Size(79, 27);
            txtMasterRegIndex5.TabIndex = 90;
            txtMasterRegIndex5.Text = "4";
            // 
            // groupBox22
            // 
            groupBox22.Controls.Add(cmbDecimalPoint4);
            groupBox22.Controls.Add(label224);
            groupBox22.Controls.Add(cmbMasterFunctionCode4);
            groupBox22.Controls.Add(cmbMasterByteOrder4);
            groupBox22.Controls.Add(cmbMasterDataType4);
            groupBox22.Controls.Add(cmbMasterActivation4);
            groupBox22.Controls.Add(btnRegWriteMemory4);
            groupBox22.Controls.Add(btnRegReadMemory4);
            groupBox22.Controls.Add(txtMasterScaleFactor4);
            groupBox22.Controls.Add(txtMasterName4);
            groupBox22.Controls.Add(txtMasterRegStartAddress4);
            groupBox22.Controls.Add(txtMasterRegIndex4);
            groupBox22.Location = new Point(-3, 165);
            groupBox22.Name = "groupBox22";
            groupBox22.Size = new Size(1098, 51);
            groupBox22.TabIndex = 103;
            groupBox22.TabStop = false;
            // 
            // cmbDecimalPoint4
            // 
            cmbDecimalPoint4.FormattingEnabled = true;
            cmbDecimalPoint4.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint4.Location = new Point(818, 15);
            cmbDecimalPoint4.Name = "cmbDecimalPoint4";
            cmbDecimalPoint4.Size = new Size(55, 28);
            cmbDecimalPoint4.TabIndex = 138;
            // 
            // label224
            // 
            label224.AutoSize = true;
            label224.Location = new Point(11, 19);
            label224.Name = "label224";
            label224.Size = new Size(17, 20);
            label224.TabIndex = 137;
            label224.Text = "4";
            // 
            // cmbMasterFunctionCode4
            // 
            cmbMasterFunctionCode4.FormattingEnabled = true;
            cmbMasterFunctionCode4.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode4.Location = new Point(586, 16);
            cmbMasterFunctionCode4.Name = "cmbMasterFunctionCode4";
            cmbMasterFunctionCode4.Size = new Size(155, 28);
            cmbMasterFunctionCode4.TabIndex = 100;
            // 
            // cmbMasterByteOrder4
            // 
            cmbMasterByteOrder4.FormattingEnabled = true;
            cmbMasterByteOrder4.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder4.Location = new Point(489, 16);
            cmbMasterByteOrder4.Name = "cmbMasterByteOrder4";
            cmbMasterByteOrder4.Size = new Size(92, 28);
            cmbMasterByteOrder4.TabIndex = 99;
            // 
            // cmbMasterDataType4
            // 
            cmbMasterDataType4.FormattingEnabled = true;
            cmbMasterDataType4.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType4.Location = new Point(354, 16);
            cmbMasterDataType4.Name = "cmbMasterDataType4";
            cmbMasterDataType4.Size = new Size(130, 28);
            cmbMasterDataType4.TabIndex = 98;
            // 
            // cmbMasterActivation4
            // 
            cmbMasterActivation4.FormattingEnabled = true;
            cmbMasterActivation4.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation4.Location = new Point(282, 16);
            cmbMasterActivation4.Name = "cmbMasterActivation4";
            cmbMasterActivation4.Size = new Size(68, 28);
            cmbMasterActivation4.TabIndex = 97;
            // 
            // btnRegWriteMemory4
            // 
            btnRegWriteMemory4.BackColor = Color.Red;
            btnRegWriteMemory4.Cursor = Cursors.Hand;
            btnRegWriteMemory4.ForeColor = Color.White;
            btnRegWriteMemory4.Location = new Point(987, 15);
            btnRegWriteMemory4.Name = "btnRegWriteMemory4";
            btnRegWriteMemory4.Size = new Size(112, 30);
            btnRegWriteMemory4.TabIndex = 95;
            btnRegWriteMemory4.Text = "Write Memory";
            btnRegWriteMemory4.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory4
            // 
            btnRegReadMemory4.BackColor = Color.DarkKhaki;
            btnRegReadMemory4.Cursor = Cursors.Hand;
            btnRegReadMemory4.ForeColor = Color.White;
            btnRegReadMemory4.Location = new Point(875, 15);
            btnRegReadMemory4.Name = "btnRegReadMemory4";
            btnRegReadMemory4.Size = new Size(112, 30);
            btnRegReadMemory4.TabIndex = 94;
            btnRegReadMemory4.Text = "Read Memory";
            btnRegReadMemory4.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor4
            // 
            txtMasterScaleFactor4.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor4.Location = new Point(745, 16);
            txtMasterScaleFactor4.MaxLength = 10;
            txtMasterScaleFactor4.Name = "txtMasterScaleFactor4";
            txtMasterScaleFactor4.Size = new Size(69, 27);
            txtMasterScaleFactor4.TabIndex = 93;
            // 
            // txtMasterName4
            // 
            txtMasterName4.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName4.Location = new Point(224, 16);
            txtMasterName4.MaxLength = 5;
            txtMasterName4.Name = "txtMasterName4";
            txtMasterName4.Size = new Size(53, 27);
            txtMasterName4.TabIndex = 92;
            // 
            // txtMasterRegStartAddress4
            // 
            txtMasterRegStartAddress4.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress4.Location = new Point(111, 16);
            txtMasterRegStartAddress4.MaxLength = 10;
            txtMasterRegStartAddress4.Name = "txtMasterRegStartAddress4";
            txtMasterRegStartAddress4.Size = new Size(110, 27);
            txtMasterRegStartAddress4.TabIndex = 91;
            // 
            // txtMasterRegIndex4
            // 
            txtMasterRegIndex4.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex4.Enabled = false;
            txtMasterRegIndex4.Location = new Point(30, 16);
            txtMasterRegIndex4.MaxLength = 2;
            txtMasterRegIndex4.Name = "txtMasterRegIndex4";
            txtMasterRegIndex4.Size = new Size(79, 27);
            txtMasterRegIndex4.TabIndex = 90;
            txtMasterRegIndex4.Text = "3";
            // 
            // groupBox24
            // 
            groupBox24.Controls.Add(cmbDecimalPoint3);
            groupBox24.Controls.Add(label225);
            groupBox24.Controls.Add(cmbMasterFunctionCode3);
            groupBox24.Controls.Add(cmbMasterByteOrder3);
            groupBox24.Controls.Add(cmbMasterDataType3);
            groupBox24.Controls.Add(cmbMasterActivation3);
            groupBox24.Controls.Add(btnRegWriteMemory3);
            groupBox24.Controls.Add(btnRegReadMemory3);
            groupBox24.Controls.Add(txtMasterScaleFactor3);
            groupBox24.Controls.Add(txtMasterName3);
            groupBox24.Controls.Add(txtMasterRegStartAddress3);
            groupBox24.Controls.Add(txtMasterRegIndex3);
            groupBox24.Location = new Point(-2, 112);
            groupBox24.Name = "groupBox24";
            groupBox24.Size = new Size(1097, 51);
            groupBox24.TabIndex = 102;
            groupBox24.TabStop = false;
            // 
            // cmbDecimalPoint3
            // 
            cmbDecimalPoint3.FormattingEnabled = true;
            cmbDecimalPoint3.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint3.Location = new Point(817, 16);
            cmbDecimalPoint3.Name = "cmbDecimalPoint3";
            cmbDecimalPoint3.Size = new Size(55, 28);
            cmbDecimalPoint3.TabIndex = 139;
            // 
            // label225
            // 
            label225.AutoSize = true;
            label225.Location = new Point(10, 19);
            label225.Name = "label225";
            label225.Size = new Size(17, 20);
            label225.TabIndex = 138;
            label225.Text = "3";
            // 
            // cmbMasterFunctionCode3
            // 
            cmbMasterFunctionCode3.FormattingEnabled = true;
            cmbMasterFunctionCode3.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode3.Location = new Point(585, 16);
            cmbMasterFunctionCode3.Name = "cmbMasterFunctionCode3";
            cmbMasterFunctionCode3.Size = new Size(155, 28);
            cmbMasterFunctionCode3.TabIndex = 100;
            // 
            // cmbMasterByteOrder3
            // 
            cmbMasterByteOrder3.FormattingEnabled = true;
            cmbMasterByteOrder3.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder3.Location = new Point(488, 16);
            cmbMasterByteOrder3.Name = "cmbMasterByteOrder3";
            cmbMasterByteOrder3.Size = new Size(92, 28);
            cmbMasterByteOrder3.TabIndex = 99;
            // 
            // cmbMasterDataType3
            // 
            cmbMasterDataType3.FormattingEnabled = true;
            cmbMasterDataType3.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType3.Location = new Point(353, 16);
            cmbMasterDataType3.Name = "cmbMasterDataType3";
            cmbMasterDataType3.Size = new Size(130, 28);
            cmbMasterDataType3.TabIndex = 98;
            // 
            // cmbMasterActivation3
            // 
            cmbMasterActivation3.FormattingEnabled = true;
            cmbMasterActivation3.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation3.Location = new Point(281, 16);
            cmbMasterActivation3.Name = "cmbMasterActivation3";
            cmbMasterActivation3.Size = new Size(68, 28);
            cmbMasterActivation3.TabIndex = 97;
            // 
            // btnRegWriteMemory3
            // 
            btnRegWriteMemory3.BackColor = Color.Red;
            btnRegWriteMemory3.Cursor = Cursors.Hand;
            btnRegWriteMemory3.ForeColor = Color.White;
            btnRegWriteMemory3.Location = new Point(986, 15);
            btnRegWriteMemory3.Name = "btnRegWriteMemory3";
            btnRegWriteMemory3.Size = new Size(112, 30);
            btnRegWriteMemory3.TabIndex = 95;
            btnRegWriteMemory3.Text = "Write Memory";
            btnRegWriteMemory3.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory3
            // 
            btnRegReadMemory3.BackColor = Color.DarkKhaki;
            btnRegReadMemory3.Cursor = Cursors.Hand;
            btnRegReadMemory3.ForeColor = Color.White;
            btnRegReadMemory3.Location = new Point(874, 15);
            btnRegReadMemory3.Name = "btnRegReadMemory3";
            btnRegReadMemory3.Size = new Size(112, 30);
            btnRegReadMemory3.TabIndex = 94;
            btnRegReadMemory3.Text = "Read Memory";
            btnRegReadMemory3.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor3
            // 
            txtMasterScaleFactor3.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor3.Location = new Point(744, 16);
            txtMasterScaleFactor3.MaxLength = 10;
            txtMasterScaleFactor3.Name = "txtMasterScaleFactor3";
            txtMasterScaleFactor3.Size = new Size(69, 27);
            txtMasterScaleFactor3.TabIndex = 93;
            // 
            // txtMasterName3
            // 
            txtMasterName3.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName3.Location = new Point(223, 16);
            txtMasterName3.MaxLength = 5;
            txtMasterName3.Name = "txtMasterName3";
            txtMasterName3.Size = new Size(53, 27);
            txtMasterName3.TabIndex = 92;
            // 
            // txtMasterRegStartAddress3
            // 
            txtMasterRegStartAddress3.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress3.Location = new Point(110, 16);
            txtMasterRegStartAddress3.MaxLength = 10;
            txtMasterRegStartAddress3.Name = "txtMasterRegStartAddress3";
            txtMasterRegStartAddress3.Size = new Size(110, 27);
            txtMasterRegStartAddress3.TabIndex = 91;
            // 
            // txtMasterRegIndex3
            // 
            txtMasterRegIndex3.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex3.Enabled = false;
            txtMasterRegIndex3.Location = new Point(29, 16);
            txtMasterRegIndex3.MaxLength = 2;
            txtMasterRegIndex3.Name = "txtMasterRegIndex3";
            txtMasterRegIndex3.Size = new Size(79, 27);
            txtMasterRegIndex3.TabIndex = 90;
            txtMasterRegIndex3.Text = "2";
            // 
            // groupBox20
            // 
            groupBox20.Controls.Add(cmbDecimalPoint1);
            groupBox20.Controls.Add(label227);
            groupBox20.Controls.Add(cmbMasterFunctionCode1);
            groupBox20.Controls.Add(cmbMasterByteOrder1);
            groupBox20.Controls.Add(cmbMasterDataType1);
            groupBox20.Controls.Add(cmbMasterActivation1);
            groupBox20.Controls.Add(btnRegWriteMemory1);
            groupBox20.Controls.Add(btnRegReadMemory1);
            groupBox20.Controls.Add(txtMasterScaleFactor1);
            groupBox20.Controls.Add(txtMasterName1);
            groupBox20.Controls.Add(txtMasterRegStartAddress1);
            groupBox20.Controls.Add(txtMasterRegIndex1);
            groupBox20.Location = new Point(-2, 6);
            groupBox20.Name = "groupBox20";
            groupBox20.Size = new Size(1098, 51);
            groupBox20.TabIndex = 0;
            groupBox20.TabStop = false;
            // 
            // cmbDecimalPoint1
            // 
            cmbDecimalPoint1.FormattingEnabled = true;
            cmbDecimalPoint1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDecimalPoint1.Location = new Point(816, 15);
            cmbDecimalPoint1.Name = "cmbDecimalPoint1";
            cmbDecimalPoint1.Size = new Size(55, 28);
            cmbDecimalPoint1.TabIndex = 141;
            // 
            // label227
            // 
            label227.AutoSize = true;
            label227.Location = new Point(10, 19);
            label227.Name = "label227";
            label227.Size = new Size(17, 20);
            label227.TabIndex = 140;
            label227.Text = "1";
            // 
            // cmbMasterFunctionCode1
            // 
            cmbMasterFunctionCode1.FormattingEnabled = true;
            cmbMasterFunctionCode1.Items.AddRange(new object[] { "Read Coil", "Read Discrete Input", "Read Holding Register", "Read Input Register" });
            cmbMasterFunctionCode1.Location = new Point(585, 16);
            cmbMasterFunctionCode1.Name = "cmbMasterFunctionCode1";
            cmbMasterFunctionCode1.Size = new Size(155, 28);
            cmbMasterFunctionCode1.TabIndex = 100;
            // 
            // cmbMasterByteOrder1
            // 
            cmbMasterByteOrder1.FormattingEnabled = true;
            cmbMasterByteOrder1.Items.AddRange(new object[] { "Big Endian", "Little Endian" });
            cmbMasterByteOrder1.Location = new Point(488, 16);
            cmbMasterByteOrder1.Name = "cmbMasterByteOrder1";
            cmbMasterByteOrder1.Size = new Size(92, 28);
            cmbMasterByteOrder1.TabIndex = 99;
            // 
            // cmbMasterDataType1
            // 
            cmbMasterDataType1.FormattingEnabled = true;
            cmbMasterDataType1.Items.AddRange(new object[] { "BYTE", "UINT16", "INT16", "UINT32", "INT32", "FLOAT32" });
            cmbMasterDataType1.Location = new Point(353, 16);
            cmbMasterDataType1.Name = "cmbMasterDataType1";
            cmbMasterDataType1.Size = new Size(130, 28);
            cmbMasterDataType1.TabIndex = 98;
            // 
            // cmbMasterActivation1
            // 
            cmbMasterActivation1.FormattingEnabled = true;
            cmbMasterActivation1.Items.AddRange(new object[] { "Yes", "No" });
            cmbMasterActivation1.Location = new Point(281, 16);
            cmbMasterActivation1.Name = "cmbMasterActivation1";
            cmbMasterActivation1.Size = new Size(68, 28);
            cmbMasterActivation1.TabIndex = 97;
            // 
            // btnRegWriteMemory1
            // 
            btnRegWriteMemory1.BackColor = Color.Red;
            btnRegWriteMemory1.Cursor = Cursors.Hand;
            btnRegWriteMemory1.ForeColor = Color.White;
            btnRegWriteMemory1.Location = new Point(986, 15);
            btnRegWriteMemory1.Name = "btnRegWriteMemory1";
            btnRegWriteMemory1.Size = new Size(112, 30);
            btnRegWriteMemory1.TabIndex = 95;
            btnRegWriteMemory1.Text = "Write Memory";
            btnRegWriteMemory1.UseVisualStyleBackColor = false;
            // 
            // btnRegReadMemory1
            // 
            btnRegReadMemory1.BackColor = Color.DarkKhaki;
            btnRegReadMemory1.Cursor = Cursors.Hand;
            btnRegReadMemory1.ForeColor = Color.White;
            btnRegReadMemory1.Location = new Point(874, 15);
            btnRegReadMemory1.Name = "btnRegReadMemory1";
            btnRegReadMemory1.Size = new Size(112, 30);
            btnRegReadMemory1.TabIndex = 94;
            btnRegReadMemory1.Text = "Read Memory";
            btnRegReadMemory1.UseVisualStyleBackColor = false;
            // 
            // txtMasterScaleFactor1
            // 
            txtMasterScaleFactor1.BorderStyle = BorderStyle.FixedSingle;
            txtMasterScaleFactor1.Location = new Point(744, 16);
            txtMasterScaleFactor1.MaxLength = 10;
            txtMasterScaleFactor1.Name = "txtMasterScaleFactor1";
            txtMasterScaleFactor1.Size = new Size(69, 27);
            txtMasterScaleFactor1.TabIndex = 93;
            // 
            // txtMasterName1
            // 
            txtMasterName1.BorderStyle = BorderStyle.FixedSingle;
            txtMasterName1.Location = new Point(223, 16);
            txtMasterName1.MaxLength = 5;
            txtMasterName1.Name = "txtMasterName1";
            txtMasterName1.Size = new Size(53, 27);
            txtMasterName1.TabIndex = 92;
            // 
            // txtMasterRegStartAddress1
            // 
            txtMasterRegStartAddress1.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegStartAddress1.Location = new Point(110, 16);
            txtMasterRegStartAddress1.MaxLength = 10;
            txtMasterRegStartAddress1.Name = "txtMasterRegStartAddress1";
            txtMasterRegStartAddress1.Size = new Size(110, 27);
            txtMasterRegStartAddress1.TabIndex = 91;
            // 
            // txtMasterRegIndex1
            // 
            txtMasterRegIndex1.BorderStyle = BorderStyle.FixedSingle;
            txtMasterRegIndex1.Enabled = false;
            txtMasterRegIndex1.Location = new Point(29, 16);
            txtMasterRegIndex1.MaxLength = 2;
            txtMasterRegIndex1.Name = "txtMasterRegIndex1";
            txtMasterRegIndex1.Size = new Size(79, 27);
            txtMasterRegIndex1.TabIndex = 90;
            txtMasterRegIndex1.Text = "0";
            // 
            // label207
            // 
            label207.AutoSize = true;
            label207.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            label207.Location = new Point(615, 35);
            label207.Name = "label207";
            label207.Size = new Size(91, 17);
            label207.TabIndex = 103;
            label207.Text = "Function Code";
            // 
            // label206
            // 
            label206.AutoSize = true;
            label206.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            label206.Location = new Point(501, 35);
            label206.Name = "label206";
            label206.Size = new Size(71, 17);
            label206.TabIndex = 102;
            label206.Text = "Byte Order";
            // 
            // label205
            // 
            label205.AutoSize = true;
            label205.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            label205.Location = new Point(738, 35);
            label205.Name = "label205";
            label205.Size = new Size(78, 17);
            label205.TabIndex = 101;
            label205.Text = "Scale Factor";
            // 
            // label196
            // 
            label196.AutoSize = true;
            label196.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            label196.Location = new Point(288, 35);
            label196.Name = "label196";
            label196.Size = new Size(64, 17);
            label196.TabIndex = 100;
            label196.Text = "Activation";
            // 
            // label201
            // 
            label201.AutoSize = true;
            label201.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            label201.Location = new Point(104, 35);
            label201.Name = "label201";
            label201.Size = new Size(114, 17);
            label201.TabIndex = 99;
            label201.Text = "Reg Start Address";
            // 
            // label202
            // 
            label202.AutoSize = true;
            label202.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            label202.Location = new Point(217, 35);
            label202.Name = "label202";
            label202.Size = new Size(68, 17);
            label202.TabIndex = 98;
            label202.Text = "Tag Name";
            // 
            // label203
            // 
            label203.AutoSize = true;
            label203.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            label203.Location = new Point(387, 35);
            label203.Name = "label203";
            label203.Size = new Size(66, 17);
            label203.TabIndex = 97;
            label203.Text = "Data Type";
            // 
            // label204
            // 
            label204.AutoSize = true;
            label204.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            label204.Location = new Point(31, 35);
            label204.Name = "label204";
            label204.Size = new Size(66, 17);
            label204.TabIndex = 96;
            label204.Text = "Reg Index";
            // 
            // groupBox18
            // 
            groupBox18.Controls.Add(cmbMasterUartType);
            groupBox18.Controls.Add(cmbMasterBaudRate);
            groupBox18.Controls.Add(label200);
            groupBox18.Controls.Add(label199);
            groupBox18.Controls.Add(txtMasterPollingInterval);
            groupBox18.Controls.Add(label198);
            groupBox18.Controls.Add(txtMasterTimeout);
            groupBox18.Controls.Add(label189);
            groupBox18.Controls.Add(txtMasterSlaveId);
            groupBox18.Controls.Add(label197);
            groupBox18.Controls.Add(btnSlaveConnectionWriteMemory);
            groupBox18.Controls.Add(btnSlaveConnectionReadMemory);
            groupBox18.Location = new Point(8, 102);
            groupBox18.Name = "groupBox18";
            groupBox18.Size = new Size(1116, 93);
            groupBox18.TabIndex = 88;
            groupBox18.TabStop = false;
            groupBox18.Text = "Slave Connection Parameter";
            // 
            // cmbMasterUartType
            // 
            cmbMasterUartType.FormattingEnabled = true;
            cmbMasterUartType.Items.AddRange(new object[] { "8N1", "8E1", "8O1", "8N2" });
            cmbMasterUartType.Location = new Point(502, 53);
            cmbMasterUartType.Name = "cmbMasterUartType";
            cmbMasterUartType.Size = new Size(106, 28);
            cmbMasterUartType.TabIndex = 97;
            // 
            // cmbMasterBaudRate
            // 
            cmbMasterBaudRate.FormattingEnabled = true;
            cmbMasterBaudRate.Items.AddRange(new object[] { "300", "600", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" });
            cmbMasterBaudRate.Location = new Point(181, 54);
            cmbMasterBaudRate.Name = "cmbMasterBaudRate";
            cmbMasterBaudRate.Size = new Size(92, 28);
            cmbMasterBaudRate.TabIndex = 96;
            // 
            // label200
            // 
            label200.AutoSize = true;
            label200.Location = new Point(519, 21);
            label200.Name = "label200";
            label200.Size = new Size(72, 20);
            label200.TabIndex = 95;
            label200.Text = "Uart Type";
            // 
            // label199
            // 
            label199.AutoSize = true;
            label199.Location = new Point(187, 20);
            label199.Name = "label199";
            label199.Size = new Size(77, 20);
            label199.TabIndex = 94;
            label199.Text = "Baud Rate";
            // 
            // txtMasterPollingInterval
            // 
            txtMasterPollingInterval.BorderStyle = BorderStyle.FixedSingle;
            txtMasterPollingInterval.Location = new Point(338, 54);
            txtMasterPollingInterval.MaxLength = 10;
            txtMasterPollingInterval.Name = "txtMasterPollingInterval";
            txtMasterPollingInterval.Size = new Size(99, 27);
            txtMasterPollingInterval.TabIndex = 93;
            // 
            // label198
            // 
            label198.AutoSize = true;
            label198.Location = new Point(336, 21);
            label198.Name = "label198";
            label198.Size = new Size(107, 20);
            label198.TabIndex = 92;
            label198.Text = "Polling Interval";
            // 
            // txtMasterTimeout
            // 
            txtMasterTimeout.BorderStyle = BorderStyle.FixedSingle;
            txtMasterTimeout.Location = new Point(673, 54);
            txtMasterTimeout.MaxLength = 10;
            txtMasterTimeout.Name = "txtMasterTimeout";
            txtMasterTimeout.Size = new Size(99, 27);
            txtMasterTimeout.TabIndex = 91;
            // 
            // label189
            // 
            label189.AutoSize = true;
            label189.Location = new Point(684, 22);
            label189.Name = "label189";
            label189.Size = new Size(64, 20);
            label189.TabIndex = 90;
            label189.Text = "Timeout";
            // 
            // txtMasterSlaveId
            // 
            txtMasterSlaveId.BorderStyle = BorderStyle.FixedSingle;
            txtMasterSlaveId.Location = new Point(17, 54);
            txtMasterSlaveId.MaxLength = 10;
            txtMasterSlaveId.Name = "txtMasterSlaveId";
            txtMasterSlaveId.Size = new Size(99, 27);
            txtMasterSlaveId.TabIndex = 89;
            // 
            // label197
            // 
            label197.AutoSize = true;
            label197.Location = new Point(38, 21);
            label197.Name = "label197";
            label197.Size = new Size(61, 20);
            label197.TabIndex = 86;
            label197.Text = "Slave Id";
            // 
            // btnSlaveConnectionWriteMemory
            // 
            btnSlaveConnectionWriteMemory.BackColor = Color.Red;
            btnSlaveConnectionWriteMemory.Cursor = Cursors.Hand;
            btnSlaveConnectionWriteMemory.ForeColor = Color.White;
            btnSlaveConnectionWriteMemory.Location = new Point(968, 54);
            btnSlaveConnectionWriteMemory.Name = "btnSlaveConnectionWriteMemory";
            btnSlaveConnectionWriteMemory.Size = new Size(117, 30);
            btnSlaveConnectionWriteMemory.TabIndex = 85;
            btnSlaveConnectionWriteMemory.Text = "Write Memory";
            btnSlaveConnectionWriteMemory.UseVisualStyleBackColor = false;
            btnSlaveConnectionWriteMemory.Click += (this.btnSlaveConnectionWriteMemory_Click);
            // 
            // btnSlaveConnectionReadMemory
            // 
            btnSlaveConnectionReadMemory.BackColor = Color.DarkKhaki;
            btnSlaveConnectionReadMemory.Cursor = Cursors.Hand;
            btnSlaveConnectionReadMemory.ForeColor = Color.White;
            btnSlaveConnectionReadMemory.Location = new Point(834, 54);
            btnSlaveConnectionReadMemory.Name = "btnSlaveConnectionReadMemory";
            btnSlaveConnectionReadMemory.Size = new Size(117, 30);
            btnSlaveConnectionReadMemory.TabIndex = 84;
            btnSlaveConnectionReadMemory.Text = "Read Memory";
            btnSlaveConnectionReadMemory.UseVisualStyleBackColor = false;
            btnSlaveConnectionReadMemory.Click += (this.btnSlaveConnectionReadMemory_Click);
            // 
            // cmbMasterSlaveIndex
            // 
            cmbMasterSlaveIndex.FormattingEnabled = true;
            cmbMasterSlaveIndex.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19" });
            cmbMasterSlaveIndex.Location = new Point(587, 60);
            cmbMasterSlaveIndex.Name = "cmbMasterSlaveIndex";
            cmbMasterSlaveIndex.Size = new Size(112, 28);
            cmbMasterSlaveIndex.TabIndex = 87;
            // 
            // label195
            // 
            label195.AutoSize = true;
            label195.Location = new Point(433, 64);
            label195.MaximumSize = new Size(164, 60);
            label195.Name = "label195";
            label195.Size = new Size(128, 20);
            label195.TabIndex = 85;
            label195.Text = "Select Slave Index";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Font = new Font("Segoe UI", 13.8F, (FontStyle)(FontStyle.Bold) | (FontStyle.Underline), GraphicsUnit.Point);
            label45.Location = new Point(481, 6);
            label45.Name = "label45";
            label45.Size = new Size(182, 31);
            label45.TabIndex = 1;
            label45.Text = "Modbus Master";
            // 
            // pnlModbusSlave
            // 
            pnlModbusSlave.Controls.Add(btnModbusSlaveWriteMemory);
            pnlModbusSlave.Controls.Add(btnModbusSlaveReadMemory);
            pnlModbusSlave.Controls.Add(groupBox17);
            pnlModbusSlave.Controls.Add(label44);
            pnlModbusSlave.Location = new Point(321, 10);
            pnlModbusSlave.Name = "pnlModbusSlave";
            pnlModbusSlave.Size = new Size(1133, 821);
            pnlModbusSlave.TabIndex = 6;
            pnlModbusSlave.Visible = false;
            // 
            // btnModbusSlaveWriteMemory
            // 
            btnModbusSlaveWriteMemory.BackColor = Color.Red;
            btnModbusSlaveWriteMemory.Cursor = Cursors.Hand;
            btnModbusSlaveWriteMemory.ForeColor = Color.White;
            btnModbusSlaveWriteMemory.Location = new Point(631, 521);
            btnModbusSlaveWriteMemory.Name = "btnModbusSlaveWriteMemory";
            btnModbusSlaveWriteMemory.Size = new Size(172, 42);
            btnModbusSlaveWriteMemory.TabIndex = 64;
            btnModbusSlaveWriteMemory.Text = "Write Memory";
            btnModbusSlaveWriteMemory.UseVisualStyleBackColor = false;
            btnModbusSlaveWriteMemory.Click += (this.btnModbusSlaveWriteMemory_Click);
            // 
            // btnModbusSlaveReadMemory
            // 
            btnModbusSlaveReadMemory.BackColor = Color.DarkKhaki;
            btnModbusSlaveReadMemory.Cursor = Cursors.Hand;
            btnModbusSlaveReadMemory.ForeColor = Color.White;
            btnModbusSlaveReadMemory.Location = new Point(359, 521);
            btnModbusSlaveReadMemory.Name = "btnModbusSlaveReadMemory";
            btnModbusSlaveReadMemory.Size = new Size(190, 42);
            btnModbusSlaveReadMemory.TabIndex = 63;
            btnModbusSlaveReadMemory.Text = "Read Memory";
            btnModbusSlaveReadMemory.UseVisualStyleBackColor = false;
            btnModbusSlaveReadMemory.Click += (this.btnModbusSlaveReadMemory_Click);
            // 
            // groupBox17
            // 
            groupBox17.Controls.Add(cmbModbusUartType);
            groupBox17.Controls.Add(cmbModbusPortType);
            groupBox17.Controls.Add(txtModbusSlaveId);
            groupBox17.Controls.Add(txtModbusTimeout);
            groupBox17.Controls.Add(label194);
            groupBox17.Controls.Add(txtModbusPollingInterval);
            groupBox17.Controls.Add(label193);
            groupBox17.Controls.Add(label192);
            groupBox17.Controls.Add(cmbModbusBaudRate);
            groupBox17.Controls.Add(label191);
            groupBox17.Controls.Add(lblPortType);
            groupBox17.Controls.Add(label190);
            groupBox17.Location = new Point(100, 74);
            groupBox17.Name = "groupBox17";
            groupBox17.Size = new Size(926, 384);
            groupBox17.TabIndex = 2;
            groupBox17.TabStop = false;
            groupBox17.Text = "Settings";
            // 
            // cmbModbusUartType
            // 
            cmbModbusUartType.FormattingEnabled = true;
            cmbModbusUartType.Items.AddRange(new object[] { "8N1", "8E1", "8O1", "8N2" });
            cmbModbusUartType.Location = new Point(448, 209);
            cmbModbusUartType.Name = "cmbModbusUartType";
            cmbModbusUartType.Size = new Size(224, 28);
            cmbModbusUartType.TabIndex = 82;
            // 
            // cmbModbusPortType
            // 
            cmbModbusPortType.FormattingEnabled = true;
            cmbModbusPortType.Items.AddRange(new object[] { "RS232", "RS485" });
            cmbModbusPortType.Location = new Point(447, 46);
            cmbModbusPortType.Name = "cmbModbusPortType";
            cmbModbusPortType.Size = new Size(224, 28);
            cmbModbusPortType.TabIndex = 81;
            // 
            // txtModbusSlaveId
            // 
            txtModbusSlaveId.BorderStyle = BorderStyle.FixedSingle;
            txtModbusSlaveId.Location = new Point(448, 103);
            txtModbusSlaveId.MaxLength = 10;
            txtModbusSlaveId.Name = "txtModbusSlaveId";
            txtModbusSlaveId.Size = new Size(224, 27);
            txtModbusSlaveId.TabIndex = 80;
            // 
            // txtModbusTimeout
            // 
            txtModbusTimeout.BorderStyle = BorderStyle.FixedSingle;
            txtModbusTimeout.Location = new Point(448, 320);
            txtModbusTimeout.MaxLength = 10;
            txtModbusTimeout.Name = "txtModbusTimeout";
            txtModbusTimeout.Size = new Size(224, 27);
            txtModbusTimeout.TabIndex = 79;
            // 
            // label194
            // 
            label194.AutoSize = true;
            label194.Location = new Point(290, 326);
            label194.Name = "label194";
            label194.Size = new Size(64, 20);
            label194.TabIndex = 78;
            label194.Text = "Timeout";
            // 
            // txtModbusPollingInterval
            // 
            txtModbusPollingInterval.BorderStyle = BorderStyle.FixedSingle;
            txtModbusPollingInterval.Location = new Point(448, 266);
            txtModbusPollingInterval.MaxLength = 10;
            txtModbusPollingInterval.Name = "txtModbusPollingInterval";
            txtModbusPollingInterval.Size = new Size(224, 27);
            txtModbusPollingInterval.TabIndex = 77;
            // 
            // label193
            // 
            label193.AutoSize = true;
            label193.Location = new Point(290, 271);
            label193.Name = "label193";
            label193.Size = new Size(107, 20);
            label193.TabIndex = 76;
            label193.Text = "Polling Interval";
            // 
            // label192
            // 
            label192.AutoSize = true;
            label192.Location = new Point(290, 216);
            label192.MaximumSize = new Size(164, 60);
            label192.Name = "label192";
            label192.Size = new Size(72, 20);
            label192.TabIndex = 74;
            label192.Text = "Uart Type";
            // 
            // cmbModbusBaudRate
            // 
            cmbModbusBaudRate.FormattingEnabled = true;
            cmbModbusBaudRate.Items.AddRange(new object[] { "300", "600", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" });
            cmbModbusBaudRate.Location = new Point(448, 156);
            cmbModbusBaudRate.Name = "cmbModbusBaudRate";
            cmbModbusBaudRate.Size = new Size(224, 28);
            cmbModbusBaudRate.TabIndex = 73;
            // 
            // label191
            // 
            label191.AutoSize = true;
            label191.Location = new Point(290, 161);
            label191.MaximumSize = new Size(164, 60);
            label191.Name = "label191";
            label191.Size = new Size(77, 20);
            label191.TabIndex = 72;
            label191.Text = "Baud Rate";
            // 
            // lblPortType
            // 
            lblPortType.AutoSize = true;
            lblPortType.Location = new Point(289, 50);
            lblPortType.MaximumSize = new Size(164, 60);
            lblPortType.Name = "lblPortType";
            lblPortType.Size = new Size(70, 20);
            lblPortType.TabIndex = 70;
            lblPortType.Text = "Port Type";
            // 
            // label190
            // 
            label190.AutoSize = true;
            label190.Location = new Point(290, 107);
            label190.Name = "label190";
            label190.Size = new Size(61, 20);
            label190.TabIndex = 66;
            label190.Text = "Slave Id";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new Font("Segoe UI", 13.8F, (FontStyle)(FontStyle.Bold) | (FontStyle.Underline), GraphicsUnit.Point);
            label44.Location = new Point(464, 19);
            label44.Name = "label44";
            label44.Size = new Size(164, 31);
            label44.TabIndex = 1;
            label44.Text = "Modbus Slave";
            // 
            // pnlPulseSettings
            // 
            pnlPulseSettings.Controls.Add(btnPulseWriteMemory);
            pnlPulseSettings.Controls.Add(btnPulseReadMemory);
            pnlPulseSettings.Controls.Add(groupBox7);
            pnlPulseSettings.Controls.Add(label42);
            pnlPulseSettings.Location = new Point(321, 9);
            pnlPulseSettings.Name = "pnlPulseSettings";
            pnlPulseSettings.Size = new Size(1133, 822);
            pnlPulseSettings.TabIndex = 4;
            pnlPulseSettings.Visible = false;
            // 
            // btnPulseWriteMemory
            // 
            btnPulseWriteMemory.BackColor = Color.Red;
            btnPulseWriteMemory.Cursor = Cursors.Hand;
            btnPulseWriteMemory.ForeColor = Color.White;
            btnPulseWriteMemory.Location = new Point(620, 598);
            btnPulseWriteMemory.Name = "btnPulseWriteMemory";
            btnPulseWriteMemory.Size = new Size(172, 42);
            btnPulseWriteMemory.TabIndex = 58;
            btnPulseWriteMemory.Text = "Write Memory";
            btnPulseWriteMemory.UseVisualStyleBackColor = false;
            btnPulseWriteMemory.Click += (this.btnPulseWriteMemory_Click);
            // 
            // btnPulseReadMemory
            // 
            btnPulseReadMemory.BackColor = Color.DarkKhaki;
            btnPulseReadMemory.Cursor = Cursors.Hand;
            btnPulseReadMemory.ForeColor = Color.White;
            btnPulseReadMemory.Location = new Point(348, 598);
            btnPulseReadMemory.Name = "btnPulseReadMemory";
            btnPulseReadMemory.Size = new Size(190, 42);
            btnPulseReadMemory.TabIndex = 57;
            btnPulseReadMemory.Text = "Read Memory";
            btnPulseReadMemory.UseVisualStyleBackColor = false;
            btnPulseReadMemory.Click += (this.btnPulseReadMemory_Click);
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(cmbPulseReportDT);
            groupBox7.Controls.Add(label131);
            groupBox7.Controls.Add(txtPulseDurationRef);
            groupBox7.Controls.Add(label130);
            groupBox7.Controls.Add(chkPulseIsVolatile);
            groupBox7.Controls.Add(label62);
            groupBox7.Controls.Add(txtPulseKfactor);
            groupBox7.Controls.Add(label64);
            groupBox7.Controls.Add(txtAdjustPulseCount);
            groupBox7.Controls.Add(label65);
            groupBox7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox7.Location = new Point(375, 77);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(361, 300);
            groupBox7.TabIndex = 51;
            groupBox7.TabStop = false;
            groupBox7.Text = "Pulse Setup";
            // 
            // cmbPulseReportDT
            // 
            cmbPulseReportDT.FormattingEnabled = true;
            cmbPulseReportDT.Items.AddRange(new object[] { "Decimal", "Hex", "Bin" });
            cmbPulseReportDT.Location = new Point(162, 230);
            cmbPulseReportDT.Name = "cmbPulseReportDT";
            cmbPulseReportDT.Size = new Size(189, 28);
            cmbPulseReportDT.TabIndex = 35;
            // 
            // label131
            // 
            label131.AutoSize = true;
            label131.Location = new Point(16, 231);
            label131.MaximumSize = new Size(164, 60);
            label131.Name = "label131";
            label131.Size = new Size(121, 20);
            label131.TabIndex = 34;
            label131.Text = "Pulse Report DT";
            // 
            // txtPulseDurationRef
            // 
            txtPulseDurationRef.BorderStyle = BorderStyle.FixedSingle;
            txtPulseDurationRef.Location = new Point(162, 185);
            txtPulseDurationRef.MaxLength = 6;
            txtPulseDurationRef.Name = "txtPulseDurationRef";
            txtPulseDurationRef.Size = new Size(189, 27);
            txtPulseDurationRef.TabIndex = 33;
            // 
            // label130
            // 
            label130.AutoSize = true;
            label130.Location = new Point(14, 189);
            label130.MaximumSize = new Size(164, 60);
            label130.Name = "label130";
            label130.Size = new Size(140, 20);
            label130.TabIndex = 32;
            label130.Text = "Pulse Duration Ref";
            // 
            // chkPulseIsVolatile
            // 
            chkPulseIsVolatile.AutoSize = true;
            chkPulseIsVolatile.Location = new Point(163, 150);
            chkPulseIsVolatile.Name = "chkPulseIsVolatile";
            chkPulseIsVolatile.Size = new Size(18, 17);
            chkPulseIsVolatile.TabIndex = 31;
            chkPulseIsVolatile.UseVisualStyleBackColor = true;
            // 
            // label62
            // 
            label62.AutoSize = true;
            label62.Location = new Point(14, 147);
            label62.MaximumSize = new Size(164, 60);
            label62.Name = "label62";
            label62.Size = new Size(77, 20);
            label62.TabIndex = 30;
            label62.Text = "Is Volatile";
            // 
            // txtPulseKfactor
            // 
            txtPulseKfactor.BorderStyle = BorderStyle.FixedSingle;
            txtPulseKfactor.Location = new Point(162, 105);
            txtPulseKfactor.MaxLength = 10;
            txtPulseKfactor.Name = "txtPulseKfactor";
            txtPulseKfactor.Size = new Size(189, 27);
            txtPulseKfactor.TabIndex = 22;
            // 
            // label64
            // 
            label64.AutoSize = true;
            label64.Location = new Point(14, 105);
            label64.Name = "label64";
            label64.Size = new Size(67, 20);
            label64.TabIndex = 21;
            label64.Text = "K Factor";
            // 
            // txtAdjustPulseCount
            // 
            txtAdjustPulseCount.BorderStyle = BorderStyle.FixedSingle;
            txtAdjustPulseCount.Location = new Point(162, 60);
            txtAdjustPulseCount.MaxLength = 10;
            txtAdjustPulseCount.Name = "txtAdjustPulseCount";
            txtAdjustPulseCount.Size = new Size(188, 27);
            txtAdjustPulseCount.TabIndex = 20;
            // 
            // label65
            // 
            label65.AutoSize = true;
            label65.Location = new Point(13, 63);
            label65.MaximumSize = new Size(150, 0);
            label65.Name = "label65";
            label65.Size = new Size(142, 20);
            label65.TabIndex = 19;
            label65.Text = "Adjust Pulse Count";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Segoe UI", 13.8F, (FontStyle)(FontStyle.Bold) | (FontStyle.Underline), GraphicsUnit.Point);
            label42.Location = new Point(475, 4);
            label42.Name = "label42";
            label42.Size = new Size(165, 31);
            label42.TabIndex = 1;
            label42.Text = "Pulse Settings";
            // 
            // pnlConsole
            // 
            pnlConsole.Controls.Add(txtSystemLog);
            pnlConsole.Controls.Add(txtConsoleInput);
            pnlConsole.Controls.Add(btnConsoleSend);
            pnlConsole.Controls.Add(groupBox23);
            pnlConsole.Controls.Add(label188);
            pnlConsole.Location = new Point(321, 9);
            pnlConsole.Name = "pnlConsole";
            pnlConsole.Size = new Size(1133, 823);
            pnlConsole.TabIndex = 10;
            pnlConsole.Visible = false;
            // 
            // txtSystemLog
            // 
            txtSystemLog.BorderStyle = BorderStyle.FixedSingle;
            txtSystemLog.Location = new Point(12, 325);
            txtSystemLog.Multiline = true;
            txtSystemLog.Name = "txtSystemLog";
            txtSystemLog.ReadOnly = true;
            txtSystemLog.ScrollBars = ScrollBars.Vertical;
            txtSystemLog.Size = new Size(1119, 485);
            txtSystemLog.TabIndex = 7;
            // 
            // txtConsoleInput
            // 
            txtConsoleInput.Location = new Point(12, 135);
            txtConsoleInput.Multiline = true;
            txtConsoleInput.Name = "txtConsoleInput";
            txtConsoleInput.ScrollBars = ScrollBars.Vertical;
            txtConsoleInput.Size = new Size(1010, 183);
            txtConsoleInput.TabIndex = 5;
            // 
            // btnConsoleSend
            // 
            btnConsoleSend.Location = new Point(1032, 208);
            btnConsoleSend.Name = "btnConsoleSend";
            btnConsoleSend.Size = new Size(95, 39);
            btnConsoleSend.TabIndex = 6;
            btnConsoleSend.Text = "Send";
            btnConsoleSend.UseVisualStyleBackColor = true;
            btnConsoleSend.Click += (this.btnConsoleSend_Click);
            // 
            // groupBox23
            // 
            groupBox23.BackColor = Color.FromArgb((int)(byte)255, (int)(byte)224, (int)(byte)192);
            groupBox23.Controls.Add(btnModbusRead);
            groupBox23.Controls.Add(btnLogMonitorOff);
            groupBox23.Controls.Add(btnClear);
            groupBox23.Location = new Point(12, 51);
            groupBox23.Name = "groupBox23";
            groupBox23.Size = new Size(1118, 77);
            groupBox23.TabIndex = 4;
            groupBox23.TabStop = false;
            // 
            // btnModbusRead
            // 
            btnModbusRead.Location = new Point(1152, 26);
            btnModbusRead.Name = "btnModbusRead";
            btnModbusRead.Size = new Size(123, 29);
            btnModbusRead.TabIndex = 2;
            btnModbusRead.Text = "Modbus Read";
            btnModbusRead.UseVisualStyleBackColor = true;
            // 
            // btnLogMonitorOff
            // 
            btnLogMonitorOff.Location = new Point(961, 26);
            btnLogMonitorOff.Name = "btnLogMonitorOff";
            btnLogMonitorOff.Size = new Size(141, 29);
            btnLogMonitorOff.TabIndex = 1;
            btnLogMonitorOff.Text = "Log Monitor Off";
            btnLogMonitorOff.UseVisualStyleBackColor = true;
            btnLogMonitorOff.Click += (this.btnLogMonitorOff_Click);
            // 
            // btnClear
            // 
            btnClear.Location = new Point(805, 26);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += (this.btnClear_Click);
            // 
            // label188
            // 
            label188.AutoSize = true;
            label188.Font = new Font("Calibri", 16.2F, (FontStyle)(FontStyle.Bold) | (FontStyle.Underline), GraphicsUnit.Point);
            label188.Location = new Point(498, 4);
            label188.Name = "label188";
            label188.Size = new Size(107, 35);
            label188.TabIndex = 2;
            label188.Text = "Console";
            // 
            // pnlGPRSSettings
            // 
            pnlGPRSSettings.Controls.Add(gbGprsIPSett2);
            pnlGPRSSettings.Controls.Add(btnGPRSWriteMemory);
            pnlGPRSSettings.Controls.Add(btnGPRSReadMemory);
            pnlGPRSSettings.Controls.Add(gbGprsTopics);
            pnlGPRSSettings.Controls.Add(gbGprsBrokerSett);
            pnlGPRSSettings.Controls.Add(cmbConnectProtocol);
            pnlGPRSSettings.Controls.Add(groupBox16);
            pnlGPRSSettings.Controls.Add(gbGprsModemSett);
            pnlGPRSSettings.Controls.Add(gbGprsIPSett1);
            pnlGPRSSettings.Controls.Add(label67);
            pnlGPRSSettings.Controls.Add(label148);
            pnlGPRSSettings.Location = new Point(321, 9);
            pnlGPRSSettings.Name = "pnlGPRSSettings";
            pnlGPRSSettings.Size = new Size(1133, 823);
            pnlGPRSSettings.TabIndex = 8;
            pnlGPRSSettings.Visible = false;
            // 
            // gbGprsIPSett2
            // 
            gbGprsIPSett2.Controls.Add(cmbIp2EventTransmission);
            gbGprsIPSett2.Controls.Add(cmbIp2SSLSecurityEnabled);
            gbGprsIPSett2.Controls.Add(chkIp2SSLSecurityEnable);
            gbGprsIPSett2.Controls.Add(txtIP2ServerPort);
            gbGprsIPSett2.Controls.Add(txtIP2ServerIP);
            gbGprsIPSett2.Controls.Add(label160);
            gbGprsIPSett2.Controls.Add(label161);
            gbGprsIPSett2.Controls.Add(label162);
            gbGprsIPSett2.Controls.Add(label163);
            gbGprsIPSett2.Location = new Point(393, 139);
            gbGprsIPSett2.Name = "gbGprsIPSett2";
            gbGprsIPSett2.Size = new Size(353, 190);
            gbGprsIPSett2.TabIndex = 11;
            gbGprsIPSett2.TabStop = false;
            gbGprsIPSett2.Text = "IP Settings 2";
            // 
            // cmbIp2EventTransmission
            // 
            cmbIp2EventTransmission.FormattingEnabled = true;
            cmbIp2EventTransmission.Items.AddRange(new object[] { "GSM Only" });
            cmbIp2EventTransmission.Location = new Point(161, 146);
            cmbIp2EventTransmission.Name = "cmbIp2EventTransmission";
            cmbIp2EventTransmission.Size = new Size(183, 28);
            cmbIp2EventTransmission.TabIndex = 10;
            // 
            // cmbIp2SSLSecurityEnabled
            // 
            cmbIp2SSLSecurityEnabled.FormattingEnabled = true;
            cmbIp2SSLSecurityEnabled.Items.AddRange(new object[] { "No", "Yes" });
            cmbIp2SSLSecurityEnabled.Location = new Point(197, 111);
            cmbIp2SSLSecurityEnabled.Name = "cmbIp2SSLSecurityEnabled";
            cmbIp2SSLSecurityEnabled.Size = new Size(147, 28);
            cmbIp2SSLSecurityEnabled.TabIndex = 9;
            // 
            // chkIp2SSLSecurityEnable
            // 
            chkIp2SSLSecurityEnable.AutoSize = true;
            chkIp2SSLSecurityEnable.Location = new Point(161, 118);
            chkIp2SSLSecurityEnable.Name = "chkIp2SSLSecurityEnable";
            chkIp2SSLSecurityEnable.Size = new Size(18, 17);
            chkIp2SSLSecurityEnable.TabIndex = 8;
            chkIp2SSLSecurityEnable.UseVisualStyleBackColor = true;
            // 
            // txtIP2ServerPort
            // 
            txtIP2ServerPort.BorderStyle = BorderStyle.FixedSingle;
            txtIP2ServerPort.Location = new Point(161, 77);
            txtIP2ServerPort.MaxLength = 4;
            txtIP2ServerPort.Name = "txtIP2ServerPort";
            txtIP2ServerPort.Size = new Size(183, 27);
            txtIP2ServerPort.TabIndex = 7;
            // 
            // txtIP2ServerIP
            // 
            txtIP2ServerIP.BorderStyle = BorderStyle.FixedSingle;
            txtIP2ServerIP.Location = new Point(161, 43);
            txtIP2ServerIP.Name = "txtIP2ServerIP";
            txtIP2ServerIP.Size = new Size(181, 27);
            txtIP2ServerIP.TabIndex = 6;
            // 
            // label160
            // 
            label160.AutoSize = true;
            label160.Location = new Point(10, 148);
            label160.Name = "label160";
            label160.Size = new Size(133, 20);
            label160.TabIndex = 4;
            label160.Text = "Event Transmission";
            // 
            // label161
            // 
            label161.AutoSize = true;
            label161.Location = new Point(10, 115);
            label161.Name = "label161";
            label161.Size = new Size(137, 20);
            label161.TabIndex = 3;
            label161.Text = "SSL Security Enable";
            // 
            // label162
            // 
            label162.AutoSize = true;
            label162.Location = new Point(10, 79);
            label162.Name = "label162";
            label162.Size = new Size(80, 20);
            label162.TabIndex = 2;
            label162.Text = "Server Port";
            // 
            // label163
            // 
            label163.AutoSize = true;
            label163.Location = new Point(10, 45);
            label163.Name = "label163";
            label163.Size = new Size(98, 20);
            label163.TabIndex = 1;
            label163.Text = "Server IP/URL";
            // 
            // btnGPRSWriteMemory
            // 
            btnGPRSWriteMemory.BackColor = Color.Red;
            btnGPRSWriteMemory.Cursor = Cursors.Hand;
            btnGPRSWriteMemory.ForeColor = Color.White;
            btnGPRSWriteMemory.Location = new Point(628, 716);
            btnGPRSWriteMemory.Name = "btnGPRSWriteMemory";
            btnGPRSWriteMemory.Size = new Size(172, 42);
            btnGPRSWriteMemory.TabIndex = 60;
            btnGPRSWriteMemory.Text = "Write Memory";
            btnGPRSWriteMemory.UseVisualStyleBackColor = false;
            btnGPRSWriteMemory.Click += (this.btnGPRSWriteMemory_Click);
            // 
            // btnGPRSReadMemory
            // 
            btnGPRSReadMemory.BackColor = Color.DarkKhaki;
            btnGPRSReadMemory.Cursor = Cursors.Hand;
            btnGPRSReadMemory.ForeColor = Color.White;
            btnGPRSReadMemory.Location = new Point(356, 716);
            btnGPRSReadMemory.Name = "btnGPRSReadMemory";
            btnGPRSReadMemory.Size = new Size(190, 42);
            btnGPRSReadMemory.TabIndex = 59;
            btnGPRSReadMemory.Text = "Read Memory";
            btnGPRSReadMemory.UseVisualStyleBackColor = false;
            btnGPRSReadMemory.Click += (this.btnGPRSReadMemory_Click);
            // 
            // gbGprsTopics
            // 
            gbGprsTopics.Controls.Add(txtSubscribeCmd);
            gbGprsTopics.Controls.Add(txtPublishCMDReply);
            gbGprsTopics.Controls.Add(txtPublishEvent);
            gbGprsTopics.Controls.Add(label149);
            gbGprsTopics.Controls.Add(label150);
            gbGprsTopics.Controls.Add(label151);
            gbGprsTopics.Location = new Point(531, 340);
            gbGprsTopics.Name = "gbGprsTopics";
            gbGprsTopics.Size = new Size(581, 140);
            gbGprsTopics.TabIndex = 7;
            gbGprsTopics.TabStop = false;
            gbGprsTopics.Text = "Topics";
            // 
            // txtSubscribeCmd
            // 
            txtSubscribeCmd.BorderStyle = BorderStyle.FixedSingle;
            txtSubscribeCmd.Location = new Point(184, 105);
            txtSubscribeCmd.Name = "txtSubscribeCmd";
            txtSubscribeCmd.Size = new Size(219, 27);
            txtSubscribeCmd.TabIndex = 5;
            // 
            // txtPublishCMDReply
            // 
            txtPublishCMDReply.BorderStyle = BorderStyle.FixedSingle;
            txtPublishCMDReply.Location = new Point(184, 66);
            txtPublishCMDReply.Name = "txtPublishCMDReply";
            txtPublishCMDReply.Size = new Size(219, 27);
            txtPublishCMDReply.TabIndex = 4;
            // 
            // txtPublishEvent
            // 
            txtPublishEvent.BorderStyle = BorderStyle.FixedSingle;
            txtPublishEvent.Location = new Point(184, 28);
            txtPublishEvent.Name = "txtPublishEvent";
            txtPublishEvent.Size = new Size(219, 27);
            txtPublishEvent.TabIndex = 3;
            // 
            // label149
            // 
            label149.AutoSize = true;
            label149.Location = new Point(17, 110);
            label149.Name = "label149";
            label149.Size = new Size(108, 20);
            label149.TabIndex = 2;
            label149.Text = "Subscribe Cmd";
            // 
            // label150
            // 
            label150.AutoSize = true;
            label150.Location = new Point(17, 71);
            label150.Name = "label150";
            label150.Size = new Size(134, 20);
            label150.TabIndex = 1;
            label150.Text = "Publish CMD Reply";
            // 
            // label151
            // 
            label151.AutoSize = true;
            label151.Location = new Point(17, 33);
            label151.Name = "label151";
            label151.Size = new Size(96, 20);
            label151.TabIndex = 0;
            label151.Text = "Publish Event";
            // 
            // gbGprsBrokerSett
            // 
            gbGprsBrokerSett.Controls.Add(btnMQTTShowPass);
            gbGprsBrokerSett.Controls.Add(cmbQosLevel);
            gbGprsBrokerSett.Controls.Add(label152);
            gbGprsBrokerSett.Controls.Add(chkAuthEnable);
            gbGprsBrokerSett.Controls.Add(txtMQTTPassword);
            gbGprsBrokerSett.Controls.Add(txtMQTTUserName);
            gbGprsBrokerSett.Controls.Add(txtClientId);
            gbGprsBrokerSett.Controls.Add(txtBrokerPort);
            gbGprsBrokerSett.Controls.Add(txtBrokerIPDomain);
            gbGprsBrokerSett.Controls.Add(label153);
            gbGprsBrokerSett.Controls.Add(label154);
            gbGprsBrokerSett.Controls.Add(label155);
            gbGprsBrokerSett.Controls.Add(label156);
            gbGprsBrokerSett.Controls.Add(label157);
            gbGprsBrokerSett.Controls.Add(label158);
            gbGprsBrokerSett.Controls.Add(label159);
            gbGprsBrokerSett.Location = new Point(20, 341);
            gbGprsBrokerSett.Name = "gbGprsBrokerSett";
            gbGprsBrokerSett.Size = new Size(502, 350);
            gbGprsBrokerSett.TabIndex = 6;
            gbGprsBrokerSett.TabStop = false;
            gbGprsBrokerSett.Text = "Broker Sett.";
            // 
            // btnMQTTShowPass
            // 
            btnMQTTShowPass.BackgroundImage = (Image)resources.GetObject("btnMQTTShowPass.BackgroundImage");
            btnMQTTShowPass.BackgroundImageLayout = ImageLayout.Stretch;
            btnMQTTShowPass.Location = new Point(412, 222);
            btnMQTTShowPass.Name = "btnMQTTShowPass";
            btnMQTTShowPass.Size = new Size(28, 27);
            btnMQTTShowPass.TabIndex = 16;
            btnMQTTShowPass.UseVisualStyleBackColor = true;
            btnMQTTShowPass.Click += (this.btnMQTTShowPass_Click);
            // 
            // cmbQosLevel
            // 
            cmbQosLevel.FormattingEnabled = true;
            cmbQosLevel.Items.AddRange(new object[] { "0", "1" });
            cmbQosLevel.Location = new Point(182, 260);
            cmbQosLevel.Name = "cmbQosLevel";
            cmbQosLevel.Size = new Size(219, 28);
            cmbQosLevel.TabIndex = 15;
            // 
            // label152
            // 
            label152.AutoSize = true;
            label152.Location = new Point(10, 268);
            label152.Name = "label152";
            label152.Size = new Size(77, 20);
            label152.TabIndex = 14;
            label152.Text = "QOS Level";
            // 
            // chkAuthEnable
            // 
            chkAuthEnable.AutoSize = true;
            chkAuthEnable.Location = new Point(182, 153);
            chkAuthEnable.Name = "chkAuthEnable";
            chkAuthEnable.Size = new Size(18, 17);
            chkAuthEnable.TabIndex = 13;
            chkAuthEnable.UseVisualStyleBackColor = true;
            // 
            // txtMQTTPassword
            // 
            txtMQTTPassword.BorderStyle = BorderStyle.FixedSingle;
            txtMQTTPassword.Location = new Point(182, 220);
            txtMQTTPassword.Name = "txtMQTTPassword";
            txtMQTTPassword.Size = new Size(219, 27);
            txtMQTTPassword.TabIndex = 12;
            txtMQTTPassword.UseSystemPasswordChar = true;
            // 
            // txtMQTTUserName
            // 
            txtMQTTUserName.BorderStyle = BorderStyle.FixedSingle;
            txtMQTTUserName.Location = new Point(182, 181);
            txtMQTTUserName.Name = "txtMQTTUserName";
            txtMQTTUserName.Size = new Size(219, 27);
            txtMQTTUserName.TabIndex = 11;
            // 
            // txtClientId
            // 
            txtClientId.BorderStyle = BorderStyle.FixedSingle;
            txtClientId.Location = new Point(182, 108);
            txtClientId.Name = "txtClientId";
            txtClientId.Size = new Size(219, 27);
            txtClientId.TabIndex = 10;
            // 
            // txtBrokerPort
            // 
            txtBrokerPort.BorderStyle = BorderStyle.FixedSingle;
            txtBrokerPort.Location = new Point(182, 70);
            txtBrokerPort.MaxLength = 4;
            txtBrokerPort.Name = "txtBrokerPort";
            txtBrokerPort.Size = new Size(219, 27);
            txtBrokerPort.TabIndex = 9;
            // 
            // txtBrokerIPDomain
            // 
            txtBrokerIPDomain.BorderStyle = BorderStyle.FixedSingle;
            txtBrokerIPDomain.Location = new Point(182, 35);
            txtBrokerIPDomain.Name = "txtBrokerIPDomain";
            txtBrokerIPDomain.Size = new Size(219, 27);
            txtBrokerIPDomain.TabIndex = 8;
            // 
            // label153
            // 
            label153.Location = new Point(406, 62);
            label153.Name = "label153";
            label153.Size = new Size(80, 46);
            label153.TabIndex = 7;
            label153.Text = "do Sett. in IP Sett Tab";
            // 
            // label154
            // 
            label154.AutoSize = true;
            label154.Location = new Point(11, 224);
            label154.Name = "label154";
            label154.Size = new Size(70, 20);
            label154.TabIndex = 6;
            label154.Text = "Password";
            // 
            // label155
            // 
            label155.AutoSize = true;
            label155.Location = new Point(11, 187);
            label155.Name = "label155";
            label155.Size = new Size(82, 20);
            label155.TabIndex = 5;
            label155.Text = "User Name";
            // 
            // label156
            // 
            label156.AutoSize = true;
            label156.Location = new Point(11, 151);
            label156.Name = "label156";
            label156.Size = new Size(92, 20);
            label156.TabIndex = 4;
            label156.Text = "Auth. Enable";
            // 
            // label157
            // 
            label157.AutoSize = true;
            label157.Location = new Point(11, 112);
            label157.Name = "label157";
            label157.Size = new Size(66, 20);
            label157.TabIndex = 3;
            label157.Text = "Client ID";
            // 
            // label158
            // 
            label158.AutoSize = true;
            label158.Location = new Point(11, 75);
            label158.Name = "label158";
            label158.Size = new Size(82, 20);
            label158.TabIndex = 2;
            label158.Text = "Broker Port";
            // 
            // label159
            // 
            label159.AutoSize = true;
            label159.Location = new Point(11, 38);
            label159.Name = "label159";
            label159.Size = new Size(127, 20);
            label159.TabIndex = 0;
            label159.Text = "Broker IP/Domain";
            // 
            // cmbConnectProtocol
            // 
            cmbConnectProtocol.FormattingEnabled = true;
            cmbConnectProtocol.Items.AddRange(new object[] { "TCP-NONTRANSPARENT", "TCP-TRANSPARENT", "MQTT", "HTTP" });
            cmbConnectProtocol.Location = new Point(517, 99);
            cmbConnectProtocol.Name = "cmbConnectProtocol";
            cmbConnectProtocol.Size = new Size(181, 28);
            cmbConnectProtocol.TabIndex = 5;
            cmbConnectProtocol.SelectedIndexChanged += (this.cmbConnectProtocol_SelectedIndexChanged);
            // 
            // groupBox16
            // 
            groupBox16.Controls.Add(btnSSLModuleReupdate);
            groupBox16.Controls.Add(btnClientKey);
            groupBox16.Controls.Add(btnClientCertificate);
            groupBox16.Controls.Add(btnCACertificate);
            groupBox16.Controls.Add(txtClientKey);
            groupBox16.Controls.Add(txtClientCertificate);
            groupBox16.Controls.Add(txtCAServerCertificate);
            groupBox16.Controls.Add(label137);
            groupBox16.Controls.Add(label138);
            groupBox16.Controls.Add(label139);
            groupBox16.Location = new Point(531, 485);
            groupBox16.Name = "groupBox16";
            groupBox16.Size = new Size(581, 206);
            groupBox16.TabIndex = 5;
            groupBox16.TabStop = false;
            groupBox16.Text = "SSL Settings";
            // 
            // btnSSLModuleReupdate
            // 
            btnSSLModuleReupdate.BackColor = Color.DarkGray;
            btnSSLModuleReupdate.Enabled = false;
            btnSSLModuleReupdate.Location = new Point(155, 163);
            btnSSLModuleReupdate.Name = "btnSSLModuleReupdate";
            btnSSLModuleReupdate.Size = new Size(288, 29);
            btnSSLModuleReupdate.TabIndex = 9;
            btnSSLModuleReupdate.Text = "SSL Module Re-Update";
            btnSSLModuleReupdate.UseVisualStyleBackColor = false;
            // 
            // btnClientKey
            // 
            btnClientKey.BackColor = Color.DarkGray;
            btnClientKey.Enabled = false;
            btnClientKey.Location = new Point(433, 106);
            btnClientKey.Name = "btnClientKey";
            btnClientKey.Size = new Size(66, 29);
            btnClientKey.TabIndex = 8;
            btnClientKey.Text = "Browse";
            btnClientKey.UseVisualStyleBackColor = false;
            // 
            // btnClientCertificate
            // 
            btnClientCertificate.BackColor = Color.DarkGray;
            btnClientCertificate.Enabled = false;
            btnClientCertificate.Location = new Point(433, 68);
            btnClientCertificate.Name = "btnClientCertificate";
            btnClientCertificate.Size = new Size(66, 29);
            btnClientCertificate.TabIndex = 7;
            btnClientCertificate.Text = "Browse";
            btnClientCertificate.UseVisualStyleBackColor = false;
            // 
            // btnCACertificate
            // 
            btnCACertificate.BackColor = Color.DarkGray;
            btnCACertificate.Enabled = false;
            btnCACertificate.Location = new Point(433, 27);
            btnCACertificate.Name = "btnCACertificate";
            btnCACertificate.Size = new Size(66, 29);
            btnCACertificate.TabIndex = 6;
            btnCACertificate.Text = "Browse";
            btnCACertificate.UseVisualStyleBackColor = false;
            // 
            // txtClientKey
            // 
            txtClientKey.BorderStyle = BorderStyle.FixedSingle;
            txtClientKey.Enabled = false;
            txtClientKey.Location = new Point(184, 107);
            txtClientKey.Name = "txtClientKey";
            txtClientKey.Size = new Size(219, 27);
            txtClientKey.TabIndex = 5;
            // 
            // txtClientCertificate
            // 
            txtClientCertificate.BorderStyle = BorderStyle.FixedSingle;
            txtClientCertificate.Enabled = false;
            txtClientCertificate.Location = new Point(184, 70);
            txtClientCertificate.Name = "txtClientCertificate";
            txtClientCertificate.Size = new Size(219, 27);
            txtClientCertificate.TabIndex = 4;
            // 
            // txtCAServerCertificate
            // 
            txtCAServerCertificate.BorderStyle = BorderStyle.FixedSingle;
            txtCAServerCertificate.Enabled = false;
            txtCAServerCertificate.Location = new Point(184, 32);
            txtCAServerCertificate.Name = "txtCAServerCertificate";
            txtCAServerCertificate.Size = new Size(219, 27);
            txtCAServerCertificate.TabIndex = 3;
            // 
            // label137
            // 
            label137.AutoSize = true;
            label137.Location = new Point(21, 110);
            label137.Name = "label137";
            label137.Size = new Size(75, 20);
            label137.TabIndex = 2;
            label137.Text = "Client Key";
            // 
            // label138
            // 
            label138.AutoSize = true;
            label138.Location = new Point(21, 72);
            label138.Name = "label138";
            label138.Size = new Size(119, 20);
            label138.TabIndex = 1;
            label138.Text = "Client Certificate";
            // 
            // label139
            // 
            label139.AutoSize = true;
            label139.Location = new Point(21, 36);
            label139.Name = "label139";
            label139.Size = new Size(145, 20);
            label139.TabIndex = 0;
            label139.Text = "CA Server Certificate";
            // 
            // gbGprsModemSett
            // 
            gbGprsModemSett.Controls.Add(btnIPSettPassView);
            gbGprsModemSett.Controls.Add(txtSimPassword);
            gbGprsModemSett.Controls.Add(txtSimUserName);
            gbGprsModemSett.Controls.Add(txtAPN);
            gbGprsModemSett.Controls.Add(label140);
            gbGprsModemSett.Controls.Add(label141);
            gbGprsModemSett.Controls.Add(label142);
            gbGprsModemSett.Controls.Add(label143);
            gbGprsModemSett.Location = new Point(766, 137);
            gbGprsModemSett.Name = "gbGprsModemSett";
            gbGprsModemSett.Size = new Size(350, 190);
            gbGprsModemSett.TabIndex = 4;
            gbGprsModemSett.TabStop = false;
            gbGprsModemSett.Text = "Modem Settings";
            // 
            // btnIPSettPassView
            // 
            btnIPSettPassView.BackgroundImage = (Image)resources.GetObject("btnIPSettPassView.BackgroundImage");
            btnIPSettPassView.BackgroundImageLayout = ImageLayout.Stretch;
            btnIPSettPassView.Location = new Point(299, 125);
            btnIPSettPassView.Name = "btnIPSettPassView";
            btnIPSettPassView.Size = new Size(28, 27);
            btnIPSettPassView.TabIndex = 7;
            btnIPSettPassView.UseVisualStyleBackColor = true;
            btnIPSettPassView.Click += (this.btnIPSettPassView_Click);
            // 
            // txtSimPassword
            // 
            txtSimPassword.BorderStyle = BorderStyle.FixedSingle;
            txtSimPassword.Location = new Point(133, 125);
            txtSimPassword.Name = "txtSimPassword";
            txtSimPassword.Size = new Size(165, 27);
            txtSimPassword.TabIndex = 6;
            txtSimPassword.UseSystemPasswordChar = true;
            // 
            // txtSimUserName
            // 
            txtSimUserName.BorderStyle = BorderStyle.FixedSingle;
            txtSimUserName.Location = new Point(133, 90);
            txtSimUserName.Name = "txtSimUserName";
            txtSimUserName.Size = new Size(165, 27);
            txtSimUserName.TabIndex = 5;
            // 
            // txtAPN
            // 
            txtAPN.BorderStyle = BorderStyle.FixedSingle;
            txtAPN.Location = new Point(133, 56);
            txtAPN.Name = "txtAPN";
            txtAPN.Size = new Size(165, 27);
            txtAPN.TabIndex = 4;
            // 
            // label140
            // 
            label140.AutoSize = true;
            label140.Location = new Point(14, 125);
            label140.Name = "label140";
            label140.Size = new Size(99, 20);
            label140.TabIndex = 3;
            label140.Text = "SIM Password";
            // 
            // label141
            // 
            label141.AutoSize = true;
            label141.Location = new Point(15, 93);
            label141.Name = "label141";
            label141.Size = new Size(111, 20);
            label141.TabIndex = 2;
            label141.Text = "SIM User Name";
            // 
            // label142
            // 
            label142.AutoSize = true;
            label142.Location = new Point(15, 59);
            label142.Name = "label142";
            label142.Size = new Size(38, 20);
            label142.TabIndex = 1;
            label142.Text = "APN";
            // 
            // label143
            // 
            label143.AutoSize = true;
            label143.Location = new Point(49, 22);
            label143.Name = "label143";
            label143.Size = new Size(234, 20);
            label143.TabIndex = 0;
            label143.Text = "(Note - Applicable Only For India)";
            // 
            // gbGprsIPSett1
            // 
            gbGprsIPSett1.Controls.Add(cmbEventTransmission);
            gbGprsIPSett1.Controls.Add(cmbSSLSecurityEnabled);
            gbGprsIPSett1.Controls.Add(chkSSLSecurityEnable);
            gbGprsIPSett1.Controls.Add(txtServerPort);
            gbGprsIPSett1.Controls.Add(txtServerIPURL);
            gbGprsIPSett1.Controls.Add(label144);
            gbGprsIPSett1.Controls.Add(label145);
            gbGprsIPSett1.Controls.Add(label146);
            gbGprsIPSett1.Controls.Add(label147);
            gbGprsIPSett1.Location = new Point(20, 139);
            gbGprsIPSett1.Name = "gbGprsIPSett1";
            gbGprsIPSett1.Size = new Size(353, 190);
            gbGprsIPSett1.TabIndex = 3;
            gbGprsIPSett1.TabStop = false;
            gbGprsIPSett1.Text = "IP Settings 1";
            // 
            // cmbEventTransmission
            // 
            cmbEventTransmission.FormattingEnabled = true;
            cmbEventTransmission.Items.AddRange(new object[] { "GSM Only" });
            cmbEventTransmission.Location = new Point(161, 152);
            cmbEventTransmission.Name = "cmbEventTransmission";
            cmbEventTransmission.Size = new Size(183, 28);
            cmbEventTransmission.TabIndex = 10;
            // 
            // cmbSSLSecurityEnabled
            // 
            cmbSSLSecurityEnabled.FormattingEnabled = true;
            cmbSSLSecurityEnabled.Items.AddRange(new object[] { "No", "Yes" });
            cmbSSLSecurityEnabled.Location = new Point(197, 117);
            cmbSSLSecurityEnabled.Name = "cmbSSLSecurityEnabled";
            cmbSSLSecurityEnabled.Size = new Size(147, 28);
            cmbSSLSecurityEnabled.TabIndex = 9;
            // 
            // chkSSLSecurityEnable
            // 
            chkSSLSecurityEnable.AutoSize = true;
            chkSSLSecurityEnable.Location = new Point(161, 124);
            chkSSLSecurityEnable.Name = "chkSSLSecurityEnable";
            chkSSLSecurityEnable.Size = new Size(18, 17);
            chkSSLSecurityEnable.TabIndex = 8;
            chkSSLSecurityEnable.UseVisualStyleBackColor = true;
            // 
            // txtServerPort
            // 
            txtServerPort.BorderStyle = BorderStyle.FixedSingle;
            txtServerPort.Location = new Point(161, 83);
            txtServerPort.MaxLength = 4;
            txtServerPort.Name = "txtServerPort";
            txtServerPort.Size = new Size(183, 27);
            txtServerPort.TabIndex = 7;
            // 
            // txtServerIPURL
            // 
            txtServerIPURL.BorderStyle = BorderStyle.FixedSingle;
            txtServerIPURL.Location = new Point(161, 49);
            txtServerIPURL.Name = "txtServerIPURL";
            txtServerIPURL.Size = new Size(181, 27);
            txtServerIPURL.TabIndex = 6;
            // 
            // label144
            // 
            label144.AutoSize = true;
            label144.Location = new Point(10, 154);
            label144.Name = "label144";
            label144.Size = new Size(133, 20);
            label144.TabIndex = 4;
            label144.Text = "Event Transmission";
            // 
            // label145
            // 
            label145.AutoSize = true;
            label145.Location = new Point(10, 121);
            label145.Name = "label145";
            label145.Size = new Size(137, 20);
            label145.TabIndex = 3;
            label145.Text = "SSL Security Enable";
            // 
            // label146
            // 
            label146.AutoSize = true;
            label146.Location = new Point(10, 85);
            label146.Name = "label146";
            label146.Size = new Size(80, 20);
            label146.TabIndex = 2;
            label146.Text = "Server Port";
            // 
            // label147
            // 
            label147.AutoSize = true;
            label147.Location = new Point(10, 51);
            label147.Name = "label147";
            label147.Size = new Size(98, 20);
            label147.TabIndex = 1;
            label147.Text = "Server IP/URL";
            // 
            // label67
            // 
            label67.AutoSize = true;
            label67.Font = new Font("Calibri", 16.2F, (FontStyle)(FontStyle.Bold) | (FontStyle.Underline), GraphicsUnit.Point);
            label67.Location = new Point(469, 13);
            label67.Name = "label67";
            label67.Size = new Size(174, 35);
            label67.TabIndex = 0;
            label67.Text = "GPRS Settings";
            // 
            // label148
            // 
            label148.AutoSize = true;
            label148.Location = new Point(366, 102);
            label148.Name = "label148";
            label148.Size = new Size(123, 20);
            label148.TabIndex = 0;
            label148.Text = "Connect Protocol";
            // 
            // pnlAISettings
            // 
            pnlAISettings.Controls.Add(btnWriteMemoryAI);
            pnlAISettings.Controls.Add(btnReadMemoryAI);
            pnlAISettings.Controls.Add(groupBox4);
            pnlAISettings.Controls.Add(groupBox3);
            pnlAISettings.Controls.Add(groupBox2);
            pnlAISettings.Controls.Add(cmbSelectChannel);
            pnlAISettings.Controls.Add(label15);
            pnlAISettings.Controls.Add(groupBox1);
            pnlAISettings.Controls.Add(label4);
            pnlAISettings.Location = new Point(321, 9);
            pnlAISettings.Name = "pnlAISettings";
            pnlAISettings.Size = new Size(1133, 822);
            pnlAISettings.TabIndex = 2;
            pnlAISettings.Visible = false;
            // 
            // btnWriteMemoryAI
            // 
            btnWriteMemoryAI.BackColor = Color.Red;
            btnWriteMemoryAI.Cursor = Cursors.Hand;
            btnWriteMemoryAI.ForeColor = Color.White;
            btnWriteMemoryAI.Location = new Point(747, 767);
            btnWriteMemoryAI.Name = "btnWriteMemoryAI";
            btnWriteMemoryAI.Size = new Size(172, 42);
            btnWriteMemoryAI.TabIndex = 40;
            btnWriteMemoryAI.Text = "Write Memory";
            btnWriteMemoryAI.UseVisualStyleBackColor = false;
            btnWriteMemoryAI.Click += (this.btnWriteMemory_Click);
            // 
            // btnReadMemoryAI
            // 
            btnReadMemoryAI.BackColor = Color.DarkKhaki;
            btnReadMemoryAI.Cursor = Cursors.Hand;
            btnReadMemoryAI.ForeColor = Color.White;
            btnReadMemoryAI.Location = new Point(475, 767);
            btnReadMemoryAI.Name = "btnReadMemoryAI";
            btnReadMemoryAI.Size = new Size(190, 42);
            btnReadMemoryAI.TabIndex = 39;
            btnReadMemoryAI.Text = "Read Memory";
            btnReadMemoryAI.UseVisualStyleBackColor = false;
            btnReadMemoryAI.Click += (this.btnReadMemory_Click);
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(chkUser6);
            groupBox4.Controls.Add(label36);
            groupBox4.Controls.Add(chkUser5);
            groupBox4.Controls.Add(label35);
            groupBox4.Controls.Add(chkUser4);
            groupBox4.Controls.Add(label34);
            groupBox4.Controls.Add(chkUser3);
            groupBox4.Controls.Add(label33);
            groupBox4.Controls.Add(chkUser2);
            groupBox4.Controls.Add(label32);
            groupBox4.Controls.Add(chkUser1);
            groupBox4.Controls.Add(label31);
            groupBox4.Location = new Point(13, 666);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(361, 143);
            groupBox4.TabIndex = 38;
            groupBox4.TabStop = false;
            groupBox4.Text = "Telephone to Alarm";
            // 
            // chkUser6
            // 
            chkUser6.AutoSize = true;
            chkUser6.Location = new Point(317, 108);
            chkUser6.Name = "chkUser6";
            chkUser6.Size = new Size(18, 17);
            chkUser6.TabIndex = 37;
            chkUser6.UseVisualStyleBackColor = true;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(211, 105);
            label36.Name = "label36";
            label36.Size = new Size(58, 20);
            label36.TabIndex = 36;
            label36.Text = "USER-6";
            // 
            // chkUser5
            // 
            chkUser5.AutoSize = true;
            chkUser5.Location = new Point(317, 72);
            chkUser5.Name = "chkUser5";
            chkUser5.Size = new Size(18, 17);
            chkUser5.TabIndex = 35;
            chkUser5.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(211, 69);
            label35.Name = "label35";
            label35.Size = new Size(58, 20);
            label35.TabIndex = 34;
            label35.Text = "USER-5";
            // 
            // chkUser4
            // 
            chkUser4.AutoSize = true;
            chkUser4.Location = new Point(317, 36);
            chkUser4.Name = "chkUser4";
            chkUser4.Size = new Size(18, 17);
            chkUser4.TabIndex = 33;
            chkUser4.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(211, 33);
            label34.Name = "label34";
            label34.Size = new Size(58, 20);
            label34.TabIndex = 32;
            label34.Text = "USER-4";
            // 
            // chkUser3
            // 
            chkUser3.AutoSize = true;
            chkUser3.Location = new Point(119, 105);
            chkUser3.Name = "chkUser3";
            chkUser3.Size = new Size(18, 17);
            chkUser3.TabIndex = 31;
            chkUser3.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(15, 102);
            label33.Name = "label33";
            label33.Size = new Size(58, 20);
            label33.TabIndex = 30;
            label33.Text = "USER-3";
            // 
            // chkUser2
            // 
            chkUser2.AutoSize = true;
            chkUser2.Location = new Point(119, 72);
            chkUser2.Name = "chkUser2";
            chkUser2.Size = new Size(18, 17);
            chkUser2.TabIndex = 29;
            chkUser2.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(15, 69);
            label32.Name = "label32";
            label32.Size = new Size(58, 20);
            label32.TabIndex = 28;
            label32.Text = "USER-2";
            // 
            // chkUser1
            // 
            chkUser1.AutoSize = true;
            chkUser1.Location = new Point(119, 39);
            chkUser1.Name = "chkUser1";
            chkUser1.Size = new Size(18, 17);
            chkUser1.TabIndex = 27;
            chkUser1.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(15, 36);
            label31.Name = "label31";
            label31.Size = new Size(58, 20);
            label31.TabIndex = 26;
            label31.Text = "USER-1";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cmbDO8);
            groupBox3.Controls.Add(label30);
            groupBox3.Controls.Add(cmbDO7);
            groupBox3.Controls.Add(label29);
            groupBox3.Controls.Add(cmbDO6);
            groupBox3.Controls.Add(label28);
            groupBox3.Controls.Add(cmbDO5);
            groupBox3.Controls.Add(label27);
            groupBox3.Controls.Add(cmbDO4);
            groupBox3.Controls.Add(label26);
            groupBox3.Controls.Add(cmbDO3);
            groupBox3.Controls.Add(label25);
            groupBox3.Controls.Add(cmbDO2);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(cmbDO1);
            groupBox3.Controls.Add(label23);
            groupBox3.Location = new Point(797, 126);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(321, 364);
            groupBox3.TabIndex = 37;
            groupBox3.TabStop = false;
            groupBox3.Text = "Digital Output";
            // 
            // cmbDO8
            // 
            cmbDO8.FormattingEnabled = true;
            cmbDO8.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "CYCLIC ", "FIXED ON", "STATE CHANGE" });
            cmbDO8.Location = new Point(122, 294);
            cmbDO8.Name = "cmbDO8";
            cmbDO8.Size = new Size(185, 28);
            cmbDO8.TabIndex = 43;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(15, 303);
            label30.Name = "label30";
            label30.Size = new Size(53, 20);
            label30.TabIndex = 42;
            label30.Text = "DO - 8";
            // 
            // cmbDO7
            // 
            cmbDO7.FormattingEnabled = true;
            cmbDO7.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "CYCLIC ", "FIXED ON", "STATE CHANGE" });
            cmbDO7.Location = new Point(122, 257);
            cmbDO7.Name = "cmbDO7";
            cmbDO7.Size = new Size(185, 28);
            cmbDO7.TabIndex = 41;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(13, 265);
            label29.Name = "label29";
            label29.Size = new Size(53, 20);
            label29.TabIndex = 40;
            label29.Text = "DO - 7";
            // 
            // cmbDO6
            // 
            cmbDO6.FormattingEnabled = true;
            cmbDO6.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "CYCLIC ", "FIXED ON", "STATE CHANGE" });
            cmbDO6.Location = new Point(122, 220);
            cmbDO6.Name = "cmbDO6";
            cmbDO6.Size = new Size(185, 28);
            cmbDO6.TabIndex = 39;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(15, 227);
            label28.Name = "label28";
            label28.Size = new Size(53, 20);
            label28.TabIndex = 38;
            label28.Text = "DO - 6";
            // 
            // cmbDO5
            // 
            cmbDO5.FormattingEnabled = true;
            cmbDO5.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "CYCLIC ", "FIXED ON", "STATE CHANGE" });
            cmbDO5.Location = new Point(122, 182);
            cmbDO5.Name = "cmbDO5";
            cmbDO5.Size = new Size(185, 28);
            cmbDO5.TabIndex = 37;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(15, 189);
            label27.Name = "label27";
            label27.Size = new Size(53, 20);
            label27.TabIndex = 36;
            label27.Text = "DO - 5";
            // 
            // cmbDO4
            // 
            cmbDO4.FormattingEnabled = true;
            cmbDO4.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "CYCLIC ", "FIXED ON", "STATE CHANGE" });
            cmbDO4.Location = new Point(122, 144);
            cmbDO4.Name = "cmbDO4";
            cmbDO4.Size = new Size(185, 28);
            cmbDO4.TabIndex = 35;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(13, 151);
            label26.Name = "label26";
            label26.Size = new Size(53, 20);
            label26.TabIndex = 34;
            label26.Text = "DO - 4";
            // 
            // cmbDO3
            // 
            cmbDO3.FormattingEnabled = true;
            cmbDO3.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "CYCLIC ", "FIXED ON", "STATE CHANGE" });
            cmbDO3.Location = new Point(122, 108);
            cmbDO3.Name = "cmbDO3";
            cmbDO3.Size = new Size(185, 28);
            cmbDO3.TabIndex = 33;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(13, 113);
            label25.Name = "label25";
            label25.Size = new Size(53, 20);
            label25.TabIndex = 32;
            label25.Text = "DO - 3";
            // 
            // cmbDO2
            // 
            cmbDO2.FormattingEnabled = true;
            cmbDO2.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "CYCLIC ", "FIXED ON", "STATE CHANGE" });
            cmbDO2.Location = new Point(122, 71);
            cmbDO2.Name = "cmbDO2";
            cmbDO2.Size = new Size(185, 28);
            cmbDO2.TabIndex = 31;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(13, 75);
            label24.Name = "label24";
            label24.Size = new Size(53, 20);
            label24.TabIndex = 30;
            label24.Text = "DO - 2";
            // 
            // cmbDO1
            // 
            cmbDO1.FormattingEnabled = true;
            cmbDO1.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "CYCLIC ", "FIXED ON", "STATE CHANGE" });
            cmbDO1.Location = new Point(122, 34);
            cmbDO1.Name = "cmbDO1";
            cmbDO1.Size = new Size(185, 28);
            cmbDO1.TabIndex = 29;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(13, 37);
            label23.Name = "label23";
            label23.Size = new Size(53, 20);
            label23.TabIndex = 28;
            label23.Text = "DO - 1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtKFactor);
            groupBox2.Controls.Add(chkDataReport);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtTotalizerUnit);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(cmbReportDataType);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(txtDisplayDecimalPoint);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(chkVolatileFlag);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(cmbTimebase);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(chkTotalizer);
            groupBox2.Location = new Point(385, 126);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(405, 364);
            groupBox2.TabIndex = 36;
            groupBox2.TabStop = false;
            groupBox2.Text = "Totalizer Parameters";
            // 
            // txtKFactor
            // 
            txtKFactor.BorderStyle = BorderStyle.FixedSingle;
            txtKFactor.Enabled = false;
            txtKFactor.Location = new Point(210, 65);
            txtKFactor.Name = "txtKFactor";
            txtKFactor.Size = new Size(184, 27);
            txtKFactor.TabIndex = 32;
            // 
            // chkDataReport
            // 
            chkDataReport.AutoSize = true;
            chkDataReport.Enabled = false;
            chkDataReport.Location = new Point(211, 215);
            chkDataReport.Name = "chkDataReport";
            chkDataReport.Size = new Size(18, 17);
            chkDataReport.TabIndex = 31;
            chkDataReport.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 213);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 30;
            label1.Text = "Data Report";
            // 
            // txtTotalizerUnit
            // 
            txtTotalizerUnit.BorderStyle = BorderStyle.FixedSingle;
            txtTotalizerUnit.Enabled = false;
            txtTotalizerUnit.Location = new Point(209, 284);
            txtTotalizerUnit.MaxLength = 10;
            txtTotalizerUnit.Name = "txtTotalizerUnit";
            txtTotalizerUnit.Size = new Size(186, 27);
            txtTotalizerUnit.TabIndex = 29;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(6, 291);
            label22.Name = "label22";
            label22.Size = new Size(97, 20);
            label22.TabIndex = 28;
            label22.Text = "Totalizer Unit";
            // 
            // cmbReportDataType
            // 
            cmbReportDataType.Enabled = false;
            cmbReportDataType.FormattingEnabled = true;
            cmbReportDataType.Items.AddRange(new object[] { "Decimal", "Hex", "Binary" });
            cmbReportDataType.Location = new Point(209, 244);
            cmbReportDataType.Name = "cmbReportDataType";
            cmbReportDataType.Size = new Size(185, 28);
            cmbReportDataType.TabIndex = 27;
            // 
            // label21
            // 
            label21.Location = new Point(6, 248);
            label21.Name = "label21";
            label21.Size = new Size(201, 40);
            label21.TabIndex = 26;
            label21.Text = "Totalaizer Report Data Type";
            // 
            // txtDisplayDecimalPoint
            // 
            txtDisplayDecimalPoint.BorderStyle = BorderStyle.FixedSingle;
            txtDisplayDecimalPoint.Enabled = false;
            txtDisplayDecimalPoint.Location = new Point(210, 176);
            txtDisplayDecimalPoint.MaxLength = 5;
            txtDisplayDecimalPoint.Name = "txtDisplayDecimalPoint";
            txtDisplayDecimalPoint.Size = new Size(186, 27);
            txtDisplayDecimalPoint.TabIndex = 23;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(5, 177);
            label19.Name = "label19";
            label19.Size = new Size(154, 20);
            label19.TabIndex = 22;
            label19.Text = "Display Decimal Point";
            // 
            // chkVolatileFlag
            // 
            chkVolatileFlag.AutoSize = true;
            chkVolatileFlag.Enabled = false;
            chkVolatileFlag.Location = new Point(210, 147);
            chkVolatileFlag.Name = "chkVolatileFlag";
            chkVolatileFlag.Size = new Size(18, 17);
            chkVolatileFlag.TabIndex = 21;
            chkVolatileFlag.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(5, 141);
            label18.Name = "label18";
            label18.Size = new Size(91, 20);
            label18.TabIndex = 20;
            label18.Text = "Volatile Flag";
            // 
            // cmbTimebase
            // 
            cmbTimebase.Enabled = false;
            cmbTimebase.FormattingEnabled = true;
            cmbTimebase.Items.AddRange(new object[] { "sec", "min", "hourly" });
            cmbTimebase.Location = new Point(210, 107);
            cmbTimebase.Name = "cmbTimebase";
            cmbTimebase.Size = new Size(185, 28);
            cmbTimebase.TabIndex = 19;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(5, 105);
            label17.Name = "label17";
            label17.Size = new Size(77, 20);
            label17.TabIndex = 18;
            label17.Text = "Time Base";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(5, 69);
            label16.Name = "label16";
            label16.Size = new Size(62, 20);
            label16.TabIndex = 12;
            label16.Text = "K Factor";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(5, 33);
            label11.Name = "label11";
            label11.Size = new Size(77, 20);
            label11.TabIndex = 8;
            label11.Text = "Totalaizer";
            // 
            // chkTotalizer
            // 
            chkTotalizer.AutoSize = true;
            chkTotalizer.Location = new Point(211, 39);
            chkTotalizer.Name = "chkTotalizer";
            chkTotalizer.Size = new Size(18, 17);
            chkTotalizer.TabIndex = 7;
            chkTotalizer.UseVisualStyleBackColor = true;
            chkTotalizer.CheckedChanged += (this.chkTotalizer_CheckedChanged);
            // 
            // cmbSelectChannel
            // 
            cmbSelectChannel.BackColor = SystemColors.HighlightText;
            cmbSelectChannel.Cursor = Cursors.Hand;
            cmbSelectChannel.FlatStyle = FlatStyle.Popup;
            cmbSelectChannel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbSelectChannel.FormattingEnabled = true;
            cmbSelectChannel.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7" });
            cmbSelectChannel.Location = new Point(490, 79);
            cmbSelectChannel.Name = "cmbSelectChannel";
            cmbSelectChannel.Size = new Size(224, 28);
            cmbSelectChannel.TabIndex = 35;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(361, 82);
            label15.Name = "label15";
            label15.Size = new Size(110, 20);
            label15.TabIndex = 34;
            label15.Text = "Select Channel";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbAIReportDataType);
            groupBox1.Controls.Add(label39);
            groupBox1.Controls.Add(chkAIDataReport);
            groupBox1.Controls.Add(label38);
            groupBox1.Controls.Add(txtAlarmSmsInterval);
            groupBox1.Controls.Add(label37);
            groupBox1.Controls.Add(txtAlarmConfirmationSec);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(cmbAIAlarm);
            groupBox1.Controls.Add(cmbAIType);
            groupBox1.Controls.Add(txtThresoldLow);
            groupBox1.Controls.Add(txtThresoldHigh);
            groupBox1.Controls.Add(txtMaxValue);
            groupBox1.Controls.Add(txtMinValue);
            groupBox1.Controls.Add(txtUnit);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new Point(13, 126);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 534);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Channel Setup";
            // 
            // cmbAIReportDataType
            // 
            cmbAIReportDataType.FormattingEnabled = true;
            cmbAIReportDataType.Items.AddRange(new object[] { "Decimal", "Hex", "Binary" });
            cmbAIReportDataType.Location = new Point(164, 446);
            cmbAIReportDataType.Name = "cmbAIReportDataType";
            cmbAIReportDataType.Size = new Size(185, 28);
            cmbAIReportDataType.TabIndex = 29;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(14, 449);
            label39.MaximumSize = new Size(164, 60);
            label39.Name = "label39";
            label39.Size = new Size(143, 20);
            label39.TabIndex = 28;
            label39.Text = "AI Report Data Type";
            // 
            // chkAIDataReport
            // 
            chkAIDataReport.AutoSize = true;
            chkAIDataReport.Location = new Point(164, 419);
            chkAIDataReport.Name = "chkAIDataReport";
            chkAIDataReport.Size = new Size(18, 17);
            chkAIDataReport.TabIndex = 24;
            chkAIDataReport.UseVisualStyleBackColor = true;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(14, 416);
            label38.Name = "label38";
            label38.Size = new Size(108, 20);
            label38.TabIndex = 23;
            label38.Text = "AI Data Report";
            // 
            // txtAlarmSmsInterval
            // 
            txtAlarmSmsInterval.BorderStyle = BorderStyle.FixedSingle;
            txtAlarmSmsInterval.Location = new Point(164, 379);
            txtAlarmSmsInterval.MaxLength = 6;
            txtAlarmSmsInterval.Name = "txtAlarmSmsInterval";
            txtAlarmSmsInterval.Size = new Size(185, 27);
            txtAlarmSmsInterval.TabIndex = 22;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(14, 380);
            label37.Name = "label37";
            label37.Size = new Size(131, 20);
            label37.TabIndex = 21;
            label37.Text = "Alarm sms Interval";
            // 
            // txtAlarmConfirmationSec
            // 
            txtAlarmConfirmationSec.BorderStyle = BorderStyle.FixedSingle;
            txtAlarmConfirmationSec.Location = new Point(164, 338);
            txtAlarmConfirmationSec.MaxLength = 6;
            txtAlarmConfirmationSec.Name = "txtAlarmConfirmationSec";
            txtAlarmConfirmationSec.Size = new Size(185, 27);
            txtAlarmConfirmationSec.TabIndex = 20;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(14, 333);
            label20.MaximumSize = new Size(150, 0);
            label20.Name = "label20";
            label20.Size = new Size(144, 40);
            label20.TabIndex = 19;
            label20.Text = "Alarm Confirmation Sec";
            // 
            // cmbAIAlarm
            // 
            cmbAIAlarm.FormattingEnabled = true;
            cmbAIAlarm.Items.AddRange(new object[] { "NO ALARM", "AQUIRE & ALARM ABOVE HIGH THRESHOLD ", "AQUIRE & ALARM AT BELOW  LOW THRESHOLD 0~10 V", "AQUIRE & ALARM AT BOTH THRESHOLD" });
            cmbAIAlarm.Location = new Point(164, 298);
            cmbAIAlarm.Name = "cmbAIAlarm";
            cmbAIAlarm.Size = new Size(185, 28);
            cmbAIAlarm.TabIndex = 18;
            // 
            // cmbAIType
            // 
            cmbAIType.FormattingEnabled = true;
            cmbAIType.Items.AddRange(new object[] { "Ignore - 0", "4~20mA-1", "0~20mA-2", "0~5 V-3", "0~10 V-4" });
            cmbAIType.Location = new Point(164, 260);
            cmbAIType.Name = "cmbAIType";
            cmbAIType.Size = new Size(185, 28);
            cmbAIType.TabIndex = 17;
            // 
            // txtThresoldLow
            // 
            txtThresoldLow.BorderStyle = BorderStyle.FixedSingle;
            txtThresoldLow.Location = new Point(164, 223);
            txtThresoldLow.MaxLength = 6;
            txtThresoldLow.Name = "txtThresoldLow";
            txtThresoldLow.Size = new Size(185, 27);
            txtThresoldLow.TabIndex = 16;
            // 
            // txtThresoldHigh
            // 
            txtThresoldHigh.BorderStyle = BorderStyle.FixedSingle;
            txtThresoldHigh.Location = new Point(164, 186);
            txtThresoldHigh.MaxLength = 6;
            txtThresoldHigh.Name = "txtThresoldHigh";
            txtThresoldHigh.Size = new Size(185, 27);
            txtThresoldHigh.TabIndex = 15;
            // 
            // txtMaxValue
            // 
            txtMaxValue.BorderStyle = BorderStyle.FixedSingle;
            txtMaxValue.Location = new Point(164, 149);
            txtMaxValue.MaxLength = 6;
            txtMaxValue.Name = "txtMaxValue";
            txtMaxValue.Size = new Size(185, 27);
            txtMaxValue.TabIndex = 14;
            // 
            // txtMinValue
            // 
            txtMinValue.BorderStyle = BorderStyle.FixedSingle;
            txtMinValue.Location = new Point(164, 112);
            txtMinValue.MaxLength = 6;
            txtMinValue.Name = "txtMinValue";
            txtMinValue.Size = new Size(185, 27);
            txtMinValue.TabIndex = 13;
            // 
            // txtUnit
            // 
            txtUnit.BorderStyle = BorderStyle.FixedSingle;
            txtUnit.Location = new Point(164, 75);
            txtUnit.MaxLength = 10;
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(185, 27);
            txtUnit.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(164, 38);
            txtName.MaxLength = 10;
            txtName.Name = "txtName";
            txtName.Size = new Size(185, 27);
            txtName.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 40);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 1;
            label5.Text = "Name";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(14, 299);
            label13.Name = "label13";
            label13.Size = new Size(67, 20);
            label13.TabIndex = 10;
            label13.Text = "AI Alarm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 77);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 2;
            label6.Text = "Unit";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 262);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 9;
            label12.Text = "AI Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 151);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 3;
            label7.Text = "Max Value";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 114);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 4;
            label8.Text = "Min Value";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 225);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 5;
            label9.Text = "Thresold Low";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 188);
            label10.Name = "label10";
            label10.Size = new Size(102, 20);
            label10.TabIndex = 6;
            label10.Text = "Thresold High";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, (FontStyle)(FontStyle.Bold) | (FontStyle.Underline), GraphicsUnit.Point);
            label4.Location = new Point(438, 14);
            label4.Name = "label4";
            label4.Size = new Size(131, 31);
            label4.TabIndex = 32;
            label4.Text = "AI Settings";
            // 
            // pnlUser
            // 
            pnlUser.Controls.Add(cmbUserIndex);
            pnlUser.Controls.Add(label128);
            pnlUser.Controls.Add(btnUserWriteMemory);
            pnlUser.Controls.Add(btnUserReadMemory);
            pnlUser.Controls.Add(groupBox15);
            pnlUser.Controls.Add(label43);
            pnlUser.Location = new Point(321, 9);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(1133, 822);
            pnlUser.TabIndex = 5;
            pnlUser.Visible = false;
            // 
            // cmbUserIndex
            // 
            cmbUserIndex.FormattingEnabled = true;
            cmbUserIndex.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5" });
            cmbUserIndex.Location = new Point(556, 75);
            cmbUserIndex.Name = "cmbUserIndex";
            cmbUserIndex.Size = new Size(151, 28);
            cmbUserIndex.TabIndex = 64;
            // 
            // label128
            // 
            label128.AutoSize = true;
            label128.Location = new Point(424, 79);
            label128.Name = "label128";
            label128.Size = new Size(122, 20);
            label128.TabIndex = 63;
            label128.Text = "Select User Index";
            // 
            // btnUserWriteMemory
            // 
            btnUserWriteMemory.BackColor = Color.Red;
            btnUserWriteMemory.Cursor = Cursors.Hand;
            btnUserWriteMemory.ForeColor = Color.White;
            btnUserWriteMemory.Location = new Point(631, 689);
            btnUserWriteMemory.Name = "btnUserWriteMemory";
            btnUserWriteMemory.Size = new Size(172, 42);
            btnUserWriteMemory.TabIndex = 62;
            btnUserWriteMemory.Text = "Write Memory";
            btnUserWriteMemory.UseVisualStyleBackColor = false;
            btnUserWriteMemory.Click += (this.btnUserWriteMemory_Click);
            // 
            // btnUserReadMemory
            // 
            btnUserReadMemory.BackColor = Color.DarkKhaki;
            btnUserReadMemory.Cursor = Cursors.Hand;
            btnUserReadMemory.ForeColor = Color.White;
            btnUserReadMemory.Location = new Point(359, 689);
            btnUserReadMemory.Name = "btnUserReadMemory";
            btnUserReadMemory.Size = new Size(190, 42);
            btnUserReadMemory.TabIndex = 61;
            btnUserReadMemory.Text = "Read Memory";
            btnUserReadMemory.UseVisualStyleBackColor = false;
            btnUserReadMemory.Click += (this.btnUserReadMemory_Click);
            // 
            // groupBox15
            // 
            groupBox15.Controls.Add(chkUserSmsTimerReport);
            groupBox15.Controls.Add(label134);
            groupBox15.Controls.Add(cmbUserSelectDo);
            groupBox15.Controls.Add(chkUserIsVolatile);
            groupBox15.Controls.Add(label129);
            groupBox15.Controls.Add(label112);
            groupBox15.Controls.Add(chkUserCanCall);
            groupBox15.Controls.Add(chkUserIsAlarm);
            groupBox15.Controls.Add(chkUserIsAdmin);
            groupBox15.Controls.Add(chkUserSmsOnGprsFail);
            groupBox15.Controls.Add(chkUserSmsOnLowTower);
            groupBox15.Controls.Add(label113);
            groupBox15.Controls.Add(label122);
            groupBox15.Controls.Add(chkUserSmsOnPowerOn);
            groupBox15.Controls.Add(txtUserMobileNo);
            groupBox15.Controls.Add(label123);
            groupBox15.Controls.Add(label124);
            groupBox15.Controls.Add(label125);
            groupBox15.Controls.Add(label126);
            groupBox15.Controls.Add(label127);
            groupBox15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox15.Location = new Point(300, 120);
            groupBox15.Name = "groupBox15";
            groupBox15.Size = new Size(533, 509);
            groupBox15.TabIndex = 60;
            groupBox15.TabStop = false;
            groupBox15.Text = "User Setup";
            // 
            // chkUserSmsTimerReport
            // 
            chkUserSmsTimerReport.AutoSize = true;
            chkUserSmsTimerReport.Location = new Point(325, 92);
            chkUserSmsTimerReport.Name = "chkUserSmsTimerReport";
            chkUserSmsTimerReport.Size = new Size(18, 17);
            chkUserSmsTimerReport.TabIndex = 67;
            chkUserSmsTimerReport.UseVisualStyleBackColor = true;
            // 
            // label134
            // 
            label134.AutoSize = true;
            label134.Location = new Point(15, 84);
            label134.MaximumSize = new Size(150, 0);
            label134.Name = "label134";
            label134.Size = new Size(135, 20);
            label134.TabIndex = 66;
            label134.Text = "Sms Timer Report";
            // 
            // cmbUserSelectDo
            // 
            cmbUserSelectDo.FormattingEnabled = true;
            cmbUserSelectDo.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8" });
            cmbUserSelectDo.Location = new Point(324, 386);
            cmbUserSelectDo.Name = "cmbUserSelectDo";
            cmbUserSelectDo.Size = new Size(188, 28);
            cmbUserSelectDo.TabIndex = 65;
            // 
            // chkUserIsVolatile
            // 
            chkUserIsVolatile.AutoSize = true;
            chkUserIsVolatile.Location = new Point(325, 439);
            chkUserIsVolatile.Name = "chkUserIsVolatile";
            chkUserIsVolatile.Size = new Size(18, 17);
            chkUserIsVolatile.TabIndex = 45;
            chkUserIsVolatile.UseVisualStyleBackColor = true;
            // 
            // label129
            // 
            label129.AutoSize = true;
            label129.Location = new Point(15, 435);
            label129.MaximumSize = new Size(164, 60);
            label129.Name = "label129";
            label129.Size = new Size(77, 20);
            label129.TabIndex = 44;
            label129.Text = "Is Volatile";
            // 
            // label112
            // 
            label112.AutoSize = true;
            label112.Location = new Point(13, 390);
            label112.MaximumSize = new Size(164, 60);
            label112.Name = "label112";
            label112.Size = new Size(76, 20);
            label112.TabIndex = 43;
            label112.Text = "Select DO";
            // 
            // chkUserCanCall
            // 
            chkUserCanCall.AutoSize = true;
            chkUserCanCall.Location = new Point(325, 344);
            chkUserCanCall.Name = "chkUserCanCall";
            chkUserCanCall.Size = new Size(18, 17);
            chkUserCanCall.TabIndex = 42;
            chkUserCanCall.UseVisualStyleBackColor = true;
            // 
            // chkUserIsAlarm
            // 
            chkUserIsAlarm.AutoSize = true;
            chkUserIsAlarm.Location = new Point(324, 302);
            chkUserIsAlarm.Name = "chkUserIsAlarm";
            chkUserIsAlarm.Size = new Size(18, 17);
            chkUserIsAlarm.TabIndex = 41;
            chkUserIsAlarm.UseVisualStyleBackColor = true;
            // 
            // chkUserIsAdmin
            // 
            chkUserIsAdmin.AutoSize = true;
            chkUserIsAdmin.Location = new Point(325, 260);
            chkUserIsAdmin.Name = "chkUserIsAdmin";
            chkUserIsAdmin.Size = new Size(18, 17);
            chkUserIsAdmin.TabIndex = 40;
            chkUserIsAdmin.UseVisualStyleBackColor = true;
            // 
            // chkUserSmsOnGprsFail
            // 
            chkUserSmsOnGprsFail.AutoSize = true;
            chkUserSmsOnGprsFail.Location = new Point(325, 218);
            chkUserSmsOnGprsFail.Name = "chkUserSmsOnGprsFail";
            chkUserSmsOnGprsFail.Size = new Size(18, 17);
            chkUserSmsOnGprsFail.TabIndex = 39;
            chkUserSmsOnGprsFail.UseVisualStyleBackColor = true;
            // 
            // chkUserSmsOnLowTower
            // 
            chkUserSmsOnLowTower.AutoSize = true;
            chkUserSmsOnLowTower.Location = new Point(325, 176);
            chkUserSmsOnLowTower.Name = "chkUserSmsOnLowTower";
            chkUserSmsOnLowTower.Size = new Size(18, 17);
            chkUserSmsOnLowTower.TabIndex = 38;
            chkUserSmsOnLowTower.UseVisualStyleBackColor = true;
            // 
            // label113
            // 
            label113.AutoSize = true;
            label113.Location = new Point(15, 342);
            label113.MaximumSize = new Size(164, 60);
            label113.Name = "label113";
            label113.Size = new Size(64, 20);
            label113.TabIndex = 37;
            label113.Text = "Can Call";
            // 
            // label122
            // 
            label122.AutoSize = true;
            label122.Location = new Point(15, 299);
            label122.MaximumSize = new Size(164, 60);
            label122.Name = "label122";
            label122.Size = new Size(68, 20);
            label122.TabIndex = 36;
            label122.Text = "Is Alarm";
            // 
            // chkUserSmsOnPowerOn
            // 
            chkUserSmsOnPowerOn.AutoSize = true;
            chkUserSmsOnPowerOn.Location = new Point(325, 134);
            chkUserSmsOnPowerOn.Name = "chkUserSmsOnPowerOn";
            chkUserSmsOnPowerOn.Size = new Size(18, 17);
            chkUserSmsOnPowerOn.TabIndex = 35;
            chkUserSmsOnPowerOn.UseVisualStyleBackColor = true;
            // 
            // txtUserMobileNo
            // 
            txtUserMobileNo.BorderStyle = BorderStyle.FixedSingle;
            txtUserMobileNo.Location = new Point(324, 40);
            txtUserMobileNo.MaxLength = 10;
            txtUserMobileNo.Name = "txtUserMobileNo";
            txtUserMobileNo.Size = new Size(188, 27);
            txtUserMobileNo.TabIndex = 34;
            // 
            // label123
            // 
            label123.AutoSize = true;
            label123.Location = new Point(14, 213);
            label123.MaximumSize = new Size(164, 60);
            label123.Name = "label123";
            label123.Size = new Size(131, 20);
            label123.TabIndex = 30;
            label123.Text = "SMS on GPRS Fail";
            // 
            // label124
            // 
            label124.AutoSize = true;
            label124.Location = new Point(13, 256);
            label124.MaximumSize = new Size(164, 60);
            label124.Name = "label124";
            label124.Size = new Size(72, 20);
            label124.TabIndex = 28;
            label124.Text = "Is Admin";
            // 
            // label125
            // 
            label125.AutoSize = true;
            label125.Location = new Point(14, 170);
            label125.Name = "label125";
            label125.Size = new Size(141, 20);
            label125.TabIndex = 21;
            label125.Text = "SMS on Low Tower";
            // 
            // label126
            // 
            label126.AutoSize = true;
            label126.Location = new Point(13, 127);
            label126.MaximumSize = new Size(150, 0);
            label126.Name = "label126";
            label126.Size = new Size(131, 20);
            label126.TabIndex = 19;
            label126.Text = "SMS on Power on";
            // 
            // label127
            // 
            label127.AutoSize = true;
            label127.Location = new Point(15, 41);
            label127.Name = "label127";
            label127.Size = new Size(119, 20);
            label127.TabIndex = 28;
            label127.Text = "Mobile Number";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Segoe UI", 13.8F, (FontStyle)(FontStyle.Bold) | (FontStyle.Underline), GraphicsUnit.Point);
            label43.Location = new Point(538, 6);
            label43.Name = "label43";
            label43.Size = new Size(62, 31);
            label43.TabIndex = 1;
            label43.Text = "User";
            // 
            // pnlModbusSettings
            // 
            pnlModbusSettings.Controls.Add(button5);
            pnlModbusSettings.Controls.Add(button6);
            pnlModbusSettings.Controls.Add(groupBox9);
            pnlModbusSettings.Controls.Add(groupBox10);
            pnlModbusSettings.Controls.Add(groupBox11);
            pnlModbusSettings.Controls.Add(comboBox39);
            pnlModbusSettings.Controls.Add(label91);
            pnlModbusSettings.Controls.Add(comboBox40);
            pnlModbusSettings.Controls.Add(label92);
            pnlModbusSettings.Controls.Add(groupBox12);
            pnlModbusSettings.Controls.Add(label3);
            pnlModbusSettings.Location = new Point(321, 9);
            pnlModbusSettings.Name = "pnlModbusSettings";
            pnlModbusSettings.Size = new Size(1133, 822);
            pnlModbusSettings.TabIndex = 1;
            pnlModbusSettings.Visible = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Cursor = Cursors.Hand;
            button5.ForeColor = Color.White;
            button5.Location = new Point(762, 774);
            button5.Name = "button5";
            button5.Size = new Size(172, 42);
            button5.TabIndex = 30;
            button5.Text = "Write Memory";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkKhaki;
            button6.Cursor = Cursors.Hand;
            button6.ForeColor = Color.White;
            button6.Location = new Point(490, 774);
            button6.Name = "button6";
            button6.Size = new Size(190, 42);
            button6.TabIndex = 29;
            button6.Text = "Read Memory";
            button6.UseVisualStyleBackColor = false;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(checkBox16);
            groupBox9.Controls.Add(label70);
            groupBox9.Controls.Add(checkBox17);
            groupBox9.Controls.Add(label71);
            groupBox9.Controls.Add(checkBox18);
            groupBox9.Controls.Add(label72);
            groupBox9.Controls.Add(checkBox19);
            groupBox9.Controls.Add(label73);
            groupBox9.Controls.Add(checkBox20);
            groupBox9.Controls.Add(label74);
            groupBox9.Controls.Add(checkBox21);
            groupBox9.Controls.Add(label75);
            groupBox9.Location = new Point(12, 474);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(361, 342);
            groupBox9.TabIndex = 28;
            groupBox9.TabStop = false;
            groupBox9.Text = "Telephone to Alarm";
            // 
            // checkBox16
            // 
            checkBox16.AutoSize = true;
            checkBox16.Location = new Point(164, 204);
            checkBox16.Name = "checkBox16";
            checkBox16.Size = new Size(18, 17);
            checkBox16.TabIndex = 37;
            checkBox16.UseVisualStyleBackColor = true;
            // 
            // label70
            // 
            label70.AutoSize = true;
            label70.Location = new Point(15, 201);
            label70.Name = "label70";
            label70.Size = new Size(58, 20);
            label70.TabIndex = 36;
            label70.Text = "USER-6";
            // 
            // checkBox17
            // 
            checkBox17.AutoSize = true;
            checkBox17.Location = new Point(164, 171);
            checkBox17.Name = "checkBox17";
            checkBox17.Size = new Size(18, 17);
            checkBox17.TabIndex = 35;
            checkBox17.UseVisualStyleBackColor = true;
            // 
            // label71
            // 
            label71.AutoSize = true;
            label71.Location = new Point(15, 168);
            label71.Name = "label71";
            label71.Size = new Size(58, 20);
            label71.TabIndex = 34;
            label71.Text = "USER-5";
            // 
            // checkBox18
            // 
            checkBox18.AutoSize = true;
            checkBox18.Location = new Point(164, 138);
            checkBox18.Name = "checkBox18";
            checkBox18.Size = new Size(18, 17);
            checkBox18.TabIndex = 33;
            checkBox18.UseVisualStyleBackColor = true;
            // 
            // label72
            // 
            label72.AutoSize = true;
            label72.Location = new Point(15, 135);
            label72.Name = "label72";
            label72.Size = new Size(58, 20);
            label72.TabIndex = 32;
            label72.Text = "USER-4";
            // 
            // checkBox19
            // 
            checkBox19.AutoSize = true;
            checkBox19.Location = new Point(164, 105);
            checkBox19.Name = "checkBox19";
            checkBox19.Size = new Size(18, 17);
            checkBox19.TabIndex = 31;
            checkBox19.UseVisualStyleBackColor = true;
            // 
            // label73
            // 
            label73.AutoSize = true;
            label73.Location = new Point(15, 102);
            label73.Name = "label73";
            label73.Size = new Size(58, 20);
            label73.TabIndex = 30;
            label73.Text = "USER-3";
            // 
            // checkBox20
            // 
            checkBox20.AutoSize = true;
            checkBox20.Location = new Point(164, 72);
            checkBox20.Name = "checkBox20";
            checkBox20.Size = new Size(18, 17);
            checkBox20.TabIndex = 29;
            checkBox20.UseVisualStyleBackColor = true;
            // 
            // label74
            // 
            label74.AutoSize = true;
            label74.Location = new Point(15, 69);
            label74.Name = "label74";
            label74.Size = new Size(58, 20);
            label74.TabIndex = 28;
            label74.Text = "USER-2";
            // 
            // checkBox21
            // 
            checkBox21.AutoSize = true;
            checkBox21.Location = new Point(164, 39);
            checkBox21.Name = "checkBox21";
            checkBox21.Size = new Size(18, 17);
            checkBox21.TabIndex = 27;
            checkBox21.UseVisualStyleBackColor = true;
            // 
            // label75
            // 
            label75.AutoSize = true;
            label75.Location = new Point(15, 36);
            label75.Name = "label75";
            label75.Size = new Size(58, 20);
            label75.TabIndex = 26;
            label75.Text = "USER-1";
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(comboBox29);
            groupBox10.Controls.Add(label76);
            groupBox10.Controls.Add(comboBox30);
            groupBox10.Controls.Add(label77);
            groupBox10.Controls.Add(comboBox31);
            groupBox10.Controls.Add(label78);
            groupBox10.Controls.Add(comboBox32);
            groupBox10.Controls.Add(label79);
            groupBox10.Controls.Add(comboBox33);
            groupBox10.Controls.Add(label80);
            groupBox10.Controls.Add(comboBox34);
            groupBox10.Controls.Add(label81);
            groupBox10.Controls.Add(comboBox35);
            groupBox10.Controls.Add(label82);
            groupBox10.Controls.Add(comboBox36);
            groupBox10.Controls.Add(label83);
            groupBox10.Location = new Point(756, 104);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(361, 364);
            groupBox10.TabIndex = 27;
            groupBox10.TabStop = false;
            groupBox10.Text = "Digital Output";
            // 
            // comboBox29
            // 
            comboBox29.FormattingEnabled = true;
            comboBox29.Location = new Point(166, 289);
            comboBox29.Name = "comboBox29";
            comboBox29.Size = new Size(185, 28);
            comboBox29.TabIndex = 43;
            // 
            // label76
            // 
            label76.AutoSize = true;
            label76.Location = new Point(8, 303);
            label76.Name = "label76";
            label76.Size = new Size(53, 20);
            label76.TabIndex = 42;
            label76.Text = "DO - 8";
            // 
            // comboBox30
            // 
            comboBox30.FormattingEnabled = true;
            comboBox30.Location = new Point(166, 252);
            comboBox30.Name = "comboBox30";
            comboBox30.Size = new Size(185, 28);
            comboBox30.TabIndex = 41;
            // 
            // label77
            // 
            label77.AutoSize = true;
            label77.Location = new Point(6, 265);
            label77.Name = "label77";
            label77.Size = new Size(53, 20);
            label77.TabIndex = 40;
            label77.Text = "DO - 7";
            // 
            // comboBox31
            // 
            comboBox31.FormattingEnabled = true;
            comboBox31.Location = new Point(166, 215);
            comboBox31.Name = "comboBox31";
            comboBox31.Size = new Size(185, 28);
            comboBox31.TabIndex = 39;
            // 
            // label78
            // 
            label78.AutoSize = true;
            label78.Location = new Point(8, 227);
            label78.Name = "label78";
            label78.Size = new Size(53, 20);
            label78.TabIndex = 38;
            label78.Text = "DO - 6";
            // 
            // comboBox32
            // 
            comboBox32.FormattingEnabled = true;
            comboBox32.Location = new Point(166, 178);
            comboBox32.Name = "comboBox32";
            comboBox32.Size = new Size(185, 28);
            comboBox32.TabIndex = 37;
            // 
            // label79
            // 
            label79.AutoSize = true;
            label79.Location = new Point(8, 189);
            label79.Name = "label79";
            label79.Size = new Size(53, 20);
            label79.TabIndex = 36;
            label79.Text = "DO - 5";
            // 
            // comboBox33
            // 
            comboBox33.FormattingEnabled = true;
            comboBox33.Location = new Point(166, 141);
            comboBox33.Name = "comboBox33";
            comboBox33.Size = new Size(185, 28);
            comboBox33.TabIndex = 35;
            // 
            // label80
            // 
            label80.AutoSize = true;
            label80.Location = new Point(6, 151);
            label80.Name = "label80";
            label80.Size = new Size(53, 20);
            label80.TabIndex = 34;
            label80.Text = "DO - 4";
            // 
            // comboBox34
            // 
            comboBox34.FormattingEnabled = true;
            comboBox34.Location = new Point(166, 104);
            comboBox34.Name = "comboBox34";
            comboBox34.Size = new Size(185, 28);
            comboBox34.TabIndex = 33;
            // 
            // label81
            // 
            label81.AutoSize = true;
            label81.Location = new Point(6, 113);
            label81.Name = "label81";
            label81.Size = new Size(53, 20);
            label81.TabIndex = 32;
            label81.Text = "DO - 3";
            // 
            // comboBox35
            // 
            comboBox35.FormattingEnabled = true;
            comboBox35.Location = new Point(166, 67);
            comboBox35.Name = "comboBox35";
            comboBox35.Size = new Size(185, 28);
            comboBox35.TabIndex = 31;
            // 
            // label82
            // 
            label82.AutoSize = true;
            label82.Location = new Point(6, 75);
            label82.Name = "label82";
            label82.Size = new Size(53, 20);
            label82.TabIndex = 30;
            label82.Text = "DO - 2";
            // 
            // comboBox36
            // 
            comboBox36.FormattingEnabled = true;
            comboBox36.Location = new Point(166, 30);
            comboBox36.Name = "comboBox36";
            comboBox36.Size = new Size(185, 28);
            comboBox36.TabIndex = 29;
            // 
            // label83
            // 
            label83.AutoSize = true;
            label83.Location = new Point(6, 37);
            label83.Name = "label83";
            label83.Size = new Size(53, 20);
            label83.TabIndex = 28;
            label83.Text = "DO - 1";
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(textBox19);
            groupBox11.Controls.Add(label84);
            groupBox11.Controls.Add(comboBox37);
            groupBox11.Controls.Add(label85);
            groupBox11.Controls.Add(checkBox22);
            groupBox11.Controls.Add(label86);
            groupBox11.Controls.Add(textBox20);
            groupBox11.Controls.Add(label87);
            groupBox11.Controls.Add(checkBox23);
            groupBox11.Controls.Add(label88);
            groupBox11.Controls.Add(comboBox38);
            groupBox11.Controls.Add(label89);
            groupBox11.Controls.Add(textBox21);
            groupBox11.Controls.Add(label90);
            groupBox11.Location = new Point(384, 104);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(361, 364);
            groupBox11.TabIndex = 26;
            groupBox11.TabStop = false;
            groupBox11.Text = "Totalizer Parameters";
            // 
            // textBox19
            // 
            textBox19.BorderStyle = BorderStyle.FixedSingle;
            textBox19.Location = new Point(166, 236);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(186, 27);
            textBox19.TabIndex = 29;
            // 
            // label84
            // 
            label84.AutoSize = true;
            label84.Location = new Point(6, 239);
            label84.Name = "label84";
            label84.Size = new Size(97, 20);
            label84.TabIndex = 28;
            label84.Text = "Totalizer Unit";
            // 
            // comboBox37
            // 
            comboBox37.FormattingEnabled = true;
            comboBox37.Location = new Point(166, 198);
            comboBox37.Name = "comboBox37";
            comboBox37.Size = new Size(185, 28);
            comboBox37.TabIndex = 27;
            // 
            // label85
            // 
            label85.AutoSize = true;
            label85.Location = new Point(6, 205);
            label85.Name = "label85";
            label85.Size = new Size(125, 20);
            label85.TabIndex = 26;
            label85.Text = "Report Data Type";
            // 
            // checkBox22
            // 
            checkBox22.AutoSize = true;
            checkBox22.Location = new Point(166, 171);
            checkBox22.Name = "checkBox22";
            checkBox22.Size = new Size(18, 17);
            checkBox22.TabIndex = 25;
            checkBox22.UseVisualStyleBackColor = true;
            // 
            // label86
            // 
            label86.AutoSize = true;
            label86.Location = new Point(6, 171);
            label86.Name = "label86";
            label86.Size = new Size(91, 20);
            label86.TabIndex = 24;
            label86.Text = "Volatile Flag";
            // 
            // textBox20
            // 
            textBox20.BorderStyle = BorderStyle.FixedSingle;
            textBox20.Location = new Point(166, 134);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(186, 27);
            textBox20.TabIndex = 23;
            // 
            // label87
            // 
            label87.AutoSize = true;
            label87.Location = new Point(6, 137);
            label87.Name = "label87";
            label87.Size = new Size(154, 20);
            label87.TabIndex = 22;
            label87.Text = "Display Decimal Point";
            // 
            // checkBox23
            // 
            checkBox23.AutoSize = true;
            checkBox23.Location = new Point(166, 107);
            checkBox23.Name = "checkBox23";
            checkBox23.Size = new Size(18, 17);
            checkBox23.TabIndex = 21;
            checkBox23.UseVisualStyleBackColor = true;
            // 
            // label88
            // 
            label88.AutoSize = true;
            label88.Location = new Point(6, 103);
            label88.Name = "label88";
            label88.Size = new Size(91, 20);
            label88.TabIndex = 20;
            label88.Text = "Volatile Flag";
            // 
            // comboBox38
            // 
            comboBox38.FormattingEnabled = true;
            comboBox38.Location = new Point(166, 69);
            comboBox38.Name = "comboBox38";
            comboBox38.Size = new Size(185, 28);
            comboBox38.TabIndex = 19;
            // 
            // label89
            // 
            label89.AutoSize = true;
            label89.Location = new Point(6, 69);
            label89.Name = "label89";
            label89.Size = new Size(77, 20);
            label89.TabIndex = 18;
            label89.Text = "Time Base";
            // 
            // textBox21
            // 
            textBox21.BorderStyle = BorderStyle.FixedSingle;
            textBox21.Location = new Point(166, 32);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(185, 27);
            textBox21.TabIndex = 13;
            // 
            // label90
            // 
            label90.AutoSize = true;
            label90.Location = new Point(6, 35);
            label90.Name = "label90";
            label90.Size = new Size(62, 20);
            label90.TabIndex = 12;
            label90.Text = "K Factor";
            // 
            // comboBox39
            // 
            comboBox39.FormattingEnabled = true;
            comboBox39.Location = new Point(604, 52);
            comboBox39.Name = "comboBox39";
            comboBox39.Size = new Size(224, 28);
            comboBox39.TabIndex = 25;
            // 
            // label91
            // 
            label91.AutoSize = true;
            label91.Location = new Point(475, 52);
            label91.Name = "label91";
            label91.Size = new Size(106, 20);
            label91.TabIndex = 24;
            label91.Text = "Select Channel";
            // 
            // comboBox40
            // 
            comboBox40.FormattingEnabled = true;
            comboBox40.Location = new Point(154, 50);
            comboBox40.Name = "comboBox40";
            comboBox40.Size = new Size(224, 28);
            comboBox40.TabIndex = 23;
            // 
            // label92
            // 
            label92.AutoSize = true;
            label92.Location = new Point(25, 50);
            label92.Name = "label92";
            label92.Size = new Size(98, 20);
            label92.TabIndex = 22;
            label92.Text = "Select Device";
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(comboBox41);
            groupBox12.Controls.Add(comboBox42);
            groupBox12.Controls.Add(textBox22);
            groupBox12.Controls.Add(textBox23);
            groupBox12.Controls.Add(textBox24);
            groupBox12.Controls.Add(textBox25);
            groupBox12.Controls.Add(textBox26);
            groupBox12.Controls.Add(textBox27);
            groupBox12.Controls.Add(label93);
            groupBox12.Controls.Add(label94);
            groupBox12.Controls.Add(label95);
            groupBox12.Controls.Add(label96);
            groupBox12.Controls.Add(label97);
            groupBox12.Controls.Add(label98);
            groupBox12.Controls.Add(label99);
            groupBox12.Controls.Add(checkBox24);
            groupBox12.Controls.Add(label100);
            groupBox12.Controls.Add(label101);
            groupBox12.Location = new Point(12, 104);
            groupBox12.Name = "groupBox12";
            groupBox12.Size = new Size(361, 364);
            groupBox12.TabIndex = 21;
            groupBox12.TabStop = false;
            groupBox12.Text = "Channel Setup";
            // 
            // comboBox41
            // 
            comboBox41.FormattingEnabled = true;
            comboBox41.Location = new Point(164, 298);
            comboBox41.Name = "comboBox41";
            comboBox41.Size = new Size(185, 28);
            comboBox41.TabIndex = 18;
            // 
            // comboBox42
            // 
            comboBox42.FormattingEnabled = true;
            comboBox42.Location = new Point(164, 263);
            comboBox42.Name = "comboBox42";
            comboBox42.Size = new Size(185, 28);
            comboBox42.TabIndex = 17;
            // 
            // textBox22
            // 
            textBox22.BorderStyle = BorderStyle.FixedSingle;
            textBox22.Location = new Point(164, 205);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(185, 27);
            textBox22.TabIndex = 16;
            // 
            // textBox23
            // 
            textBox23.BorderStyle = BorderStyle.FixedSingle;
            textBox23.Location = new Point(164, 171);
            textBox23.Name = "textBox23";
            textBox23.Size = new Size(185, 27);
            textBox23.TabIndex = 15;
            // 
            // textBox24
            // 
            textBox24.BorderStyle = BorderStyle.FixedSingle;
            textBox24.Location = new Point(164, 137);
            textBox24.Name = "textBox24";
            textBox24.Size = new Size(185, 27);
            textBox24.TabIndex = 14;
            // 
            // textBox25
            // 
            textBox25.BorderStyle = BorderStyle.FixedSingle;
            textBox25.Location = new Point(164, 103);
            textBox25.Name = "textBox25";
            textBox25.Size = new Size(185, 27);
            textBox25.TabIndex = 13;
            // 
            // textBox26
            // 
            textBox26.BorderStyle = BorderStyle.FixedSingle;
            textBox26.Location = new Point(164, 69);
            textBox26.Name = "textBox26";
            textBox26.Size = new Size(185, 27);
            textBox26.TabIndex = 12;
            // 
            // textBox27
            // 
            textBox27.BorderStyle = BorderStyle.FixedSingle;
            textBox27.Location = new Point(164, 35);
            textBox27.Name = "textBox27";
            textBox27.Size = new Size(185, 27);
            textBox27.TabIndex = 11;
            // 
            // label93
            // 
            label93.AutoSize = true;
            label93.Location = new Point(15, 38);
            label93.Name = "label93";
            label93.Size = new Size(49, 20);
            label93.TabIndex = 1;
            label93.Text = "Name";
            // 
            // label94
            // 
            label94.AutoSize = true;
            label94.Location = new Point(15, 302);
            label94.Name = "label94";
            label94.Size = new Size(67, 20);
            label94.TabIndex = 10;
            label94.Text = "AI Alarm";
            // 
            // label95
            // 
            label95.AutoSize = true;
            label95.Location = new Point(15, 71);
            label95.Name = "label95";
            label95.Size = new Size(36, 20);
            label95.TabIndex = 2;
            label95.Text = "Unit";
            // 
            // label96
            // 
            label96.AutoSize = true;
            label96.Location = new Point(15, 269);
            label96.Name = "label96";
            label96.Size = new Size(58, 20);
            label96.TabIndex = 9;
            label96.Text = "AI Type";
            // 
            // label97
            // 
            label97.AutoSize = true;
            label97.Location = new Point(15, 137);
            label97.Name = "label97";
            label97.Size = new Size(77, 20);
            label97.TabIndex = 3;
            label97.Text = "Max Value";
            // 
            // label98
            // 
            label98.AutoSize = true;
            label98.Location = new Point(15, 236);
            label98.Name = "label98";
            label98.Size = new Size(74, 20);
            label98.TabIndex = 8;
            label98.Text = "Totalaizer";
            // 
            // label99
            // 
            label99.AutoSize = true;
            label99.Location = new Point(15, 104);
            label99.Name = "label99";
            label99.Size = new Size(74, 20);
            label99.TabIndex = 4;
            label99.Text = "Min Value";
            // 
            // checkBox24
            // 
            checkBox24.AutoSize = true;
            checkBox24.Location = new Point(166, 239);
            checkBox24.Name = "checkBox24";
            checkBox24.Size = new Size(18, 17);
            checkBox24.TabIndex = 7;
            checkBox24.UseVisualStyleBackColor = true;
            // 
            // label100
            // 
            label100.AutoSize = true;
            label100.Location = new Point(15, 203);
            label100.Name = "label100";
            label100.Size = new Size(97, 20);
            label100.TabIndex = 5;
            label100.Text = "Thresold Low";
            // 
            // label101
            // 
            label101.AutoSize = true;
            label101.Location = new Point(15, 170);
            label101.Name = "label101";
            label101.Size = new Size(102, 20);
            label101.TabIndex = 6;
            label101.Text = "Thresold High";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, (FontStyle)(FontStyle.Bold) | (FontStyle.Underline), GraphicsUnit.Point);
            label3.Location = new Point(473, 15);
            label3.Name = "label3";
            label3.Size = new Size(196, 31);
            label3.TabIndex = 0;
            label3.Text = "Modbus Settings";
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(menu);
            pnlMenu.Location = new Point(12, 10);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(306, 822);
            pnlMenu.TabIndex = 0;
            // 
            // menu
            // 
            menu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menu.ImageKey = "RootNode.png";
            menu.ImageList = menuImgList;
            menu.Location = new Point(3, 3);
            menu.Name = "menu";
            treeNode1.Name = "GeneralSettings";
            treeNode1.Text = "General Settings";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "DOSettings";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "DO Settings";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "DISettings";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "DI Settings";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "AISettings";
            treeNode4.SelectedImageIndex = 1;
            treeNode4.Text = "AI Settings";
            treeNode5.Name = "IOSettings";
            treeNode5.Text = "IO Settings";
            treeNode6.ImageIndex = 0;
            treeNode6.Name = "PulseSettings";
            treeNode6.SelectedImageIndex = 0;
            treeNode6.Text = "Pulse Settings";
            treeNode7.ImageIndex = 0;
            treeNode7.Name = "User";
            treeNode7.SelectedImageIndex = 0;
            treeNode7.Text = "User";
            treeNode8.ImageIndex = 0;
            treeNode8.Name = "ModbusMaster";
            treeNode8.SelectedImageIndex = 0;
            treeNode8.Text = "Modbus Master";
            treeNode9.ImageIndex = 0;
            treeNode9.Name = "ModbusSlave";
            treeNode9.SelectedImageIndex = 0;
            treeNode9.Text = "Modbus Slave";
            treeNode10.Name = "GPRSSettings";
            treeNode10.Text = "GPRS Settings";
            treeNode11.Name = "status";
            treeNode11.Text = "Status";
            treeNode12.Name = "console";
            treeNode12.Text = "Console";
            menu.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode5, treeNode6, treeNode7, treeNode8, treeNode9, treeNode10, treeNode11, treeNode12 });
            menu.SelectedImageIndex = 0;
            menu.Size = new Size(300, 813);
            menu.TabIndex = 0;
            // 
            // menuImgList
            // 
            menuImgList.ColorDepth = ColorDepth.Depth8Bit;
            menuImgList.ImageStream = (ImageListStreamer)resources.GetObject("menuImgList.ImageStream");
            menuImgList.TransparentColor = Color.Transparent;
            menuImgList.Images.SetKeyName(0, "RootNode.png");
            menuImgList.Images.SetKeyName(1, "ChildNode.png");
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(46, 927);
            lblError.Name = "lblError";
            lblError.Size = new Size(1421, 41);
            lblError.TabIndex = 6;
            lblError.Visible = false;
            // 
            // LoginTimer
            // 
            LoginTimer.Enabled = true;
            LoginTimer.Interval = 1000;
            LoginTimer.Tick += (this.LoginTimer_Tick);
            // 
            // btnConnect
            // 
            btnConnect.BackgroundImage = (Image)resources.GetObject("btnConnect.BackgroundImage");
            btnConnect.BackgroundImageLayout = ImageLayout.Stretch;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConnect.Location = new Point(590, 18);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(98, 31);
            btnConnect.TabIndex = 33;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += (this.btnConnect_Click);
            // 
            // cmbComPorts
            // 
            cmbComPorts.FormattingEnabled = true;
            cmbComPorts.Location = new Point(396, 21);
            cmbComPorts.Name = "cmbComPorts";
            cmbComPorts.Size = new Size(151, 28);
            cmbComPorts.TabIndex = 32;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(349, 24);
            label14.Name = "label14";
            label14.Size = new Size(41, 20);
            label14.TabIndex = 34;
            label14.Text = "Ports";
            // 
            // pnlConnect
            // 
            pnlConnect.Controls.Add(button2);
            pnlConnect.Controls.Add(button1);
            pnlConnect.Controls.Add(btnOpenConfigFile);
            pnlConnect.Controls.Add(btnPortRefresh);
            pnlConnect.Controls.Add(lblProgressPercent);
            pnlConnect.Controls.Add(pbProcessing);
            pnlConnect.Controls.Add(cmbComPorts);
            pnlConnect.Controls.Add(label14);
            pnlConnect.Controls.Add(btnConnect);
            pnlConnect.Location = new Point(12, 12);
            pnlConnect.Name = "pnlConnect";
            pnlConnect.Size = new Size(1455, 65);
            pnlConnect.TabIndex = 35;
            pnlConnect.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb((int)(byte)192, (int)(byte)255, (int)(byte)192);
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(938, 19);
            button2.Name = "button2";
            button2.Size = new Size(105, 31);
            button2.TabIndex = 43;
            button2.Text = "Write Config";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb((int)(byte)192, (int)(byte)255, (int)(byte)192);
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(828, 19);
            button1.Name = "button1";
            button1.Size = new Size(105, 31);
            button1.TabIndex = 42;
            button1.Text = "Read Config";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnOpenConfigFile
            // 
            btnOpenConfigFile.BackColor = Color.FromArgb((int)(byte)192, (int)(byte)255, (int)(byte)192);
            btnOpenConfigFile.Cursor = Cursors.Hand;
            btnOpenConfigFile.Location = new Point(694, 19);
            btnOpenConfigFile.Name = "btnOpenConfigFile";
            btnOpenConfigFile.Size = new Size(129, 31);
            btnOpenConfigFile.TabIndex = 41;
            btnOpenConfigFile.Text = "Open Config File";
            btnOpenConfigFile.UseVisualStyleBackColor = false;
            // 
            // btnPortRefresh
            // 
            btnPortRefresh.BackgroundImage = (Image)resources.GetObject("btnPortRefresh.BackgroundImage");
            btnPortRefresh.BackgroundImageLayout = ImageLayout.Stretch;
            btnPortRefresh.Location = new Point(552, 20);
            btnPortRefresh.Name = "btnPortRefresh";
            btnPortRefresh.Size = new Size(28, 28);
            btnPortRefresh.TabIndex = 40;
            btnPortRefresh.UseVisualStyleBackColor = true;
            btnPortRefresh.Click += (this.btnPortRefresh_Click);
            // 
            // lblProgressPercent
            // 
            lblProgressPercent.AutoSize = true;
            lblProgressPercent.Location = new Point(1210, 23);
            lblProgressPercent.Name = "lblProgressPercent";
            lblProgressPercent.Size = new Size(29, 20);
            lblProgressPercent.TabIndex = 38;
            lblProgressPercent.Text = "0%";
            // 
            // pbProcessing
            // 
            pbProcessing.BackColor = SystemColors.Info;
            pbProcessing.Location = new Point(1049, 23);
            pbProcessing.Name = "pbProcessing";
            pbProcessing.Size = new Size(151, 22);
            pbProcessing.Style = ProgressBarStyle.Continuous;
            pbProcessing.TabIndex = 37;
            // 
            // errorReset
            // 
            errorReset.Enabled = true;
            errorReset.Interval = 300000;
            errorReset.Tick += (this.errorReset_Tick);
            // 
            // lnkLogin
            // 
            lnkLogin.AutoSize = true;
            lnkLogin.Location = new Point(1416, 30);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(46, 20);
            lnkLogin.TabIndex = 47;
            lnkLogin.TabStop = true;
            lnkLogin.Text = "Login";
            lnkLogin.LinkClicked += (this.lnkLogin_LinkClicked);
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(7, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(306, 65);
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // lblErrorDetails
            // 
            lblErrorDetails.AutoSize = true;
            lblErrorDetails.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorDetails.ForeColor = Color.Red;
            lblErrorDetails.Location = new Point(1, 928);
            lblErrorDetails.Name = "lblErrorDetails";
            lblErrorDetails.Size = new Size(42, 19);
            lblErrorDetails.TabIndex = 48;
            lblErrorDetails.Text = "Error:";
            lblErrorDetails.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1471, 970);
            this.Controls.Add(lblErrorDetails);
            this.Controls.Add(lblError);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(lnkLogin);
            this.Controls.Add(pnlConnect);
            this.Controls.Add(pnlDashboard);
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.MaximumSize = new Size(1519, 1018);
            this.Name = "Dashboard";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += (this.Dashboard_Load);
            pnlDashboard.ResumeLayout(false);
            pnlDISettings.ResumeLayout(false);
            pnlDISettings.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            pnlGeneralSettings.ResumeLayout(false);
            pnlGeneralSettings.PerformLayout();
            groupBox13.ResumeLayout(false);
            groupBox13.PerformLayout();
            pnlStatus.ResumeLayout(false);
            pnlStatus.PerformLayout();
            groupBox27.ResumeLayout(false);
            groupBox27.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDigiIn8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiIn7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiIn6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiIn5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiIn4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiIn3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiIn2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiIn1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiOut8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiOut7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiOut6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiOut5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiOut4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiOut3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiOut2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDigiOut1).EndInit();
            groupBox26.ResumeLayout(false);
            groupBox26.PerformLayout();
            groupBox25.ResumeLayout(false);
            groupBox25.PerformLayout();
            pnlDOSettings.ResumeLayout(false);
            pnlDOSettings.PerformLayout();
            groupBox14.ResumeLayout(false);
            groupBox14.PerformLayout();
            pnlModbusMaster.ResumeLayout(false);
            pnlModbusMaster.PerformLayout();
            groupBox19.ResumeLayout(false);
            groupBox19.PerformLayout();
            pnlMasterScroll.ResumeLayout(false);
            groupBox44.ResumeLayout(false);
            groupBox44.PerformLayout();
            groupBox45.ResumeLayout(false);
            groupBox45.PerformLayout();
            groupBox46.ResumeLayout(false);
            groupBox46.PerformLayout();
            groupBox47.ResumeLayout(false);
            groupBox47.PerformLayout();
            groupBox48.ResumeLayout(false);
            groupBox48.PerformLayout();
            groupBox49.ResumeLayout(false);
            groupBox49.PerformLayout();
            groupBox50.ResumeLayout(false);
            groupBox50.PerformLayout();
            groupBox51.ResumeLayout(false);
            groupBox51.PerformLayout();
            groupBox52.ResumeLayout(false);
            groupBox52.PerformLayout();
            groupBox53.ResumeLayout(false);
            groupBox53.PerformLayout();
            groupBox54.ResumeLayout(false);
            groupBox54.PerformLayout();
            groupBox55.ResumeLayout(false);
            groupBox55.PerformLayout();
            groupBox56.ResumeLayout(false);
            groupBox56.PerformLayout();
            groupBox57.ResumeLayout(false);
            groupBox57.PerformLayout();
            groupBox58.ResumeLayout(false);
            groupBox58.PerformLayout();
            groupBox59.ResumeLayout(false);
            groupBox59.PerformLayout();
            groupBox60.ResumeLayout(false);
            groupBox60.PerformLayout();
            groupBox61.ResumeLayout(false);
            groupBox61.PerformLayout();
            groupBox62.ResumeLayout(false);
            groupBox62.PerformLayout();
            groupBox63.ResumeLayout(false);
            groupBox63.PerformLayout();
            groupBox34.ResumeLayout(false);
            groupBox34.PerformLayout();
            groupBox35.ResumeLayout(false);
            groupBox35.PerformLayout();
            groupBox36.ResumeLayout(false);
            groupBox36.PerformLayout();
            groupBox37.ResumeLayout(false);
            groupBox37.PerformLayout();
            groupBox38.ResumeLayout(false);
            groupBox38.PerformLayout();
            groupBox39.ResumeLayout(false);
            groupBox39.PerformLayout();
            groupBox40.ResumeLayout(false);
            groupBox40.PerformLayout();
            groupBox41.ResumeLayout(false);
            groupBox41.PerformLayout();
            groupBox42.ResumeLayout(false);
            groupBox42.PerformLayout();
            groupBox43.ResumeLayout(false);
            groupBox43.PerformLayout();
            groupBox21.ResumeLayout(false);
            groupBox21.PerformLayout();
            groupBox32.ResumeLayout(false);
            groupBox32.PerformLayout();
            groupBox33.ResumeLayout(false);
            groupBox33.PerformLayout();
            groupBox28.ResumeLayout(false);
            groupBox28.PerformLayout();
            groupBox29.ResumeLayout(false);
            groupBox29.PerformLayout();
            groupBox30.ResumeLayout(false);
            groupBox30.PerformLayout();
            groupBox31.ResumeLayout(false);
            groupBox31.PerformLayout();
            groupBox22.ResumeLayout(false);
            groupBox22.PerformLayout();
            groupBox24.ResumeLayout(false);
            groupBox24.PerformLayout();
            groupBox20.ResumeLayout(false);
            groupBox20.PerformLayout();
            groupBox18.ResumeLayout(false);
            groupBox18.PerformLayout();
            pnlModbusSlave.ResumeLayout(false);
            pnlModbusSlave.PerformLayout();
            groupBox17.ResumeLayout(false);
            groupBox17.PerformLayout();
            pnlPulseSettings.ResumeLayout(false);
            pnlPulseSettings.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            pnlConsole.ResumeLayout(false);
            pnlConsole.PerformLayout();
            groupBox23.ResumeLayout(false);
            pnlGPRSSettings.ResumeLayout(false);
            pnlGPRSSettings.PerformLayout();
            gbGprsIPSett2.ResumeLayout(false);
            gbGprsIPSett2.PerformLayout();
            gbGprsTopics.ResumeLayout(false);
            gbGprsTopics.PerformLayout();
            gbGprsBrokerSett.ResumeLayout(false);
            gbGprsBrokerSett.PerformLayout();
            groupBox16.ResumeLayout(false);
            groupBox16.PerformLayout();
            gbGprsModemSett.ResumeLayout(false);
            gbGprsModemSett.PerformLayout();
            gbGprsIPSett1.ResumeLayout(false);
            gbGprsIPSett1.PerformLayout();
            pnlAISettings.ResumeLayout(false);
            pnlAISettings.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            groupBox15.ResumeLayout(false);
            groupBox15.PerformLayout();
            pnlModbusSettings.ResumeLayout(false);
            pnlModbusSettings.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            groupBox12.ResumeLayout(false);
            groupBox12.PerformLayout();
            pnlMenu.ResumeLayout(false);
            pnlConnect.ResumeLayout(false);
            pnlConnect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private Panel pnlDashboard;
        private System.Windows.Forms.Timer LoginTimer;
        private Panel pnlMenu;
        private TreeView menu;
        private ImageList menuImgList;
        private Panel pnlGeneralSettings;
        private Panel pnlModbusSettings;
        private Label label3;
        private Button button5;
        private Button button6;
        private GroupBox groupBox9;
        private CheckBox checkBox16;
        private Label label70;
        private CheckBox checkBox17;
        private Label label71;
        private CheckBox checkBox18;
        private Label label72;
        private CheckBox checkBox19;
        private Label label73;
        private CheckBox checkBox20;
        private Label label74;
        private CheckBox checkBox21;
        private Label label75;
        private GroupBox groupBox10;
        private ComboBox comboBox29;
        private Label label76;
        private ComboBox comboBox30;
        private Label label77;
        private ComboBox comboBox31;
        private Label label78;
        private ComboBox comboBox32;
        private Label label79;
        private ComboBox comboBox33;
        private Label label80;
        private ComboBox comboBox34;
        private Label label81;
        private ComboBox comboBox35;
        private Label label82;
        private ComboBox comboBox36;
        private Label label83;
        private GroupBox groupBox11;
        private TextBox textBox19;
        private Label label84;
        private ComboBox comboBox37;
        private Label label85;
        private CheckBox checkBox22;
        private Label label86;
        private TextBox textBox20;
        private Label label87;
        private CheckBox checkBox23;
        private Label label88;
        private ComboBox comboBox38;
        private Label label89;
        private TextBox textBox21;
        private Label label90;
        private ComboBox comboBox39;
        private Label label91;
        private ComboBox comboBox40;
        private Label label92;
        private GroupBox groupBox12;
        private ComboBox comboBox41;
        private ComboBox comboBox42;
        private TextBox textBox22;
        private TextBox textBox23;
        private TextBox textBox24;
        private TextBox textBox25;
        private TextBox textBox26;
        private TextBox textBox27;
        private Label label93;
        private Label label94;
        private Label label95;
        private Label label96;
        private Label label97;
        private Label label98;
        private Label label99;
        private CheckBox checkBox24;
        private Label label100;
        private Label label101;
        private Button btnConnect;
        private ComboBox cmbComPorts;
        private Label label14;
        private Label label2;
        private Panel pnlAISettings;
        private Button btnWriteMemoryAI;
        private Button btnReadMemoryAI;
        private GroupBox groupBox4;
        private CheckBox chkUser6;
        private Label label36;
        private CheckBox chkUser5;
        private Label label35;
        private CheckBox chkUser4;
        private Label label34;
        private CheckBox chkUser3;
        private Label label33;
        private CheckBox chkUser2;
        private Label label32;
        private CheckBox chkUser1;
        private Label label31;
        private GroupBox groupBox3;
        private ComboBox cmbDO8;
        private Label label30;
        private ComboBox cmbDO7;
        private Label label29;
        private ComboBox cmbDO6;
        private Label label28;
        private ComboBox cmbDO5;
        private Label label27;
        private ComboBox cmbDO4;
        private Label label26;
        private ComboBox cmbDO3;
        private Label label25;
        private ComboBox cmbDO2;
        private Label label24;
        private ComboBox cmbDO1;
        private Label label23;
        private GroupBox groupBox2;
        private CheckBox chkDataReport;
        private Label label1;
        private TextBox txtTotalizerUnit;
        private Label label22;
        private ComboBox cmbReportDataType;
        private Label label21;
        private TextBox txtDisplayDecimalPoint;
        private Label label19;
        private CheckBox chkVolatileFlag;
        private Label label18;
        private ComboBox cmbTimebase;
        private Label label17;
        private Label label16;
        private Label label11;
        private CheckBox chkTotalizer;
        private ComboBox cmbSelectChannel;
        private Label label15;
        private GroupBox groupBox1;
        private ComboBox cmbAIAlarm;
        private ComboBox cmbAIType;
        private TextBox txtThresoldLow;
        private TextBox txtThresoldHigh;
        private TextBox txtMaxValue;
        private TextBox txtMinValue;
        private TextBox txtUnit;
        private TextBox txtName;
        private Label label5;
        private Label label13;
        private Label label6;
        private Label label12;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label4;
        private ComboBox cmbAIReportDataType;
        private Label label39;
        private CheckBox chkAIDataReport;
        private Label label38;
        private TextBox txtAlarmSmsInterval;
        private Label label37;
        private TextBox txtAlarmConfirmationSec;
        private Label label20;
        private TextBox txtKFactor;
        private Panel pnlConnect;
        private ProgressBar pbProcessing;
        private Panel pnlDISettings;
        private Label label41;
        private Panel pnlDOSettings;
        private Label label40;
        private Panel pnlPulseSettings;
        private Label label42;
        private Panel pnlUser;
        private Label label43;
        private Panel pnlModbusSlave;
        private Label label44;
        private Panel pnlModbusMaster;
        private Label label45;
        private Button btnDIWriteMemory;
        private Button btnDIReadMemory;
        private GroupBox groupBox5;
        private CheckBox chkDIUser6;
        private Label label46;
        private CheckBox chkDIUser5;
        private Label label47;
        private CheckBox chkDIUser4;
        private Label label48;
        private CheckBox chkDIUser3;
        private Label label49;
        private CheckBox chkDIUser2;
        private Label label50;
        private CheckBox chkDIUser1;
        private Label label51;
        private GroupBox groupBox6;
        private ComboBox cmbDIDO8;
        private Label label52;
        private ComboBox cmbDIDO7;
        private Label label53;
        private ComboBox cmbDIDO6;
        private Label label54;
        private ComboBox cmbDIDO5;
        private Label label55;
        private ComboBox cmbDIDO4;
        private Label label56;
        private ComboBox cmbDIDO3;
        private Label label57;
        private ComboBox cmbDIDO2;
        private Label label58;
        private ComboBox cmbDIDO1;
        private Label label59;
        private ComboBox cmbDISelectChannel;
        private Label label68;
        private GroupBox groupBox8;
        private Label label69;
        private CheckBox chkDIDataReport;
        private Label label102;
        private TextBox txtDISmsRepeatTime;
        private Label label103;
        private TextBox txtDIAlarmVerifySec;
        private Label label104;
        private ComboBox cmbDIAlarm;
        private ComboBox cmbDIType;
        private TextBox txtDIUnit;
        private TextBox txtDIName;
        private Label label105;
        private Label label106;
        private Label label107;
        private Label label108;
        private TextBox txtDISMSRepeatSec;
        private Button btnDOWriteMemory;
        private Button btnDOReadMemory;
        private ComboBox cmbDOSelectChannel;
        private Label label115;
        private GroupBox groupBox14;
        private Label label121;
        private Label label120;
        private TextBox txtDoOnTime;
        private Label label117;
        private TextBox txtDoOffTime;
        private Label label116;
        private TextBox txtDoRelayDelayTime;
        private Label label118;
        private TextBox txtDoRelayCloseOn;
        private Label label119;
        private ComboBox cmbDOType;
        private Label label114;
        private Button btnPulseWriteMemory;
        private Button btnPulseReadMemory;
        private GroupBox groupBox7;
        private Label label62;
        private TextBox txtPulseKfactor;
        private Label label64;
        private TextBox txtAdjustPulseCount;
        private Label label65;
        private CheckBox chkPulseIsVolatile;
        private Button btnGeneralWriteMemory;
        private Button btnGeneralReadMemory;
        private GroupBox groupBox13;
        private TextBox txtGeneralDataLogSec;
        private Label label63;
        private TextBox txtGeneralSmsLogSec;
        private Label label66;
        private Label label109;
        private Label label110;
        private TextBox txtGeneralUserId;
        private Label label61;
        private Label label60;
        private DateTimePicker dtGeneralSetDate;
        private Label label111;
        private TextBox txtGeneralSetTime;
        private ComboBox cmbUserIndex;
        private Label label128;
        private Button btnUserWriteMemory;
        private Button btnUserReadMemory;
        private GroupBox groupBox15;
        private Label label113;
        private Label label122;
        private CheckBox chkUserSmsOnPowerOn;
        private TextBox txtUserMobileNo;
        private Label label123;
        private Label label124;
        private Label label125;
        private Label label126;
        private Label label127;
        private CheckBox chkUserSmsOnGprsFail;
        private CheckBox chkUserSmsOnLowTower;
        private CheckBox chkUserCanCall;
        private CheckBox chkUserIsAlarm;
        private CheckBox chkUserIsAdmin;
        private Label label129;
        private Label label112;
        private ComboBox cmbUserSelectDo;
        private CheckBox chkUserIsVolatile;
        private Label label130;
        private TextBox txtPulseDurationRef;
        private ComboBox cmbPulseReportDT;
        private Label label131;
        private ComboBox cmbDIReportDt;
        private Label label132;
        private Label lblProgressPercent;
        private CheckBox chkUserSmsTimerReport;
        private Label label134;
        private CheckBox chkGeneralRtcDebug;
        private Label label136;
        private CheckBox chkGeneralModbusDebug;
        private Label label135;
        private TextBox txtIemiNo;
        private Panel pnlGPRSSettings;
        private Label label67;
        private GroupBox groupBox16;
        private Button btnSSLModuleReupdate;
        private Button btnClientKey;
        private Button btnClientCertificate;
        private Button btnCACertificate;
        private TextBox txtClientKey;
        private TextBox txtClientCertificate;
        private TextBox txtCAServerCertificate;
        private Label label137;
        private Label label138;
        private Label label139;
        private GroupBox gbGprsModemSett;
        private Button btnIPSettPassView;
        private TextBox txtSimPassword;
        private TextBox txtSimUserName;
        private TextBox txtAPN;
        private Label label140;
        private Label label141;
        private Label label142;
        private Label label143;
        private GroupBox gbGprsIPSett1;
        private ComboBox cmbEventTransmission;
        private ComboBox cmbSSLSecurityEnabled;
        private CheckBox chkSSLSecurityEnable;
        private TextBox txtServerPort;
        private TextBox txtServerIPURL;
        private ComboBox cmbConnectProtocol;
        private Label label144;
        private Label label145;
        private Label label146;
        private Label label147;
        private Label label148;
        private GroupBox gbGprsTopics;
        private TextBox txtSubscribeCmd;
        private TextBox txtPublishCMDReply;
        private TextBox txtPublishEvent;
        private Label label149;
        private Label label150;
        private Label label151;
        private GroupBox gbGprsBrokerSett;
        private Button btnMQTTShowPass;
        private ComboBox cmbQosLevel;
        private Label label152;
        private CheckBox chkAuthEnable;
        private TextBox txtMQTTPassword;
        private TextBox txtMQTTUserName;
        private TextBox txtClientId;
        private TextBox txtBrokerPort;
        private TextBox txtBrokerIPDomain;
        private Label label153;
        private Label label154;
        private Label label155;
        private Label label156;
        private Label label157;
        private Label label158;
        private Label label159;
        private Button btnGPRSWriteMemory;
        private Button btnGPRSReadMemory;
        private GroupBox gbGprsIPSett2;
        private ComboBox cmbIp2EventTransmission;
        private ComboBox cmbIp2SSLSecurityEnabled;
        private CheckBox chkIp2SSLSecurityEnable;
        private TextBox txtIP2ServerPort;
        private TextBox txtIP2ServerIP;
        private Label label160;
        private Label label161;
        private Label label162;
        private Label label163;
        private Panel pnlStatus;
        private Label label164;
        private GroupBox groupBox27;
        private Button btnIOStatusRead;
        private Label label165;
        private Label label166;
        private Label label167;
        private Label label168;
        private Label label169;
        private Label label170;
        private Label lblTot1;
        private Label lblStatusPulseCounter1;
        private Label lblStatusSystemVolt;
        private GroupBox groupBox26;
        private Button btnStatusGSMRead;
        private Label lblSignal2;
        private Label lblSignal3;
        private Label lblSignal4;
        private Label lblSignal5;
        private Label lblSignal1;
        private Label lblStatusProvider;
        private Label lblStatusModule;
        private Label lblStatusDecimal;
        private Label label172;
        private Label label173;
        private Label label174;
        private Label label175;
        private Label label176;
        private Label lblStatusTime;
        private Label lblStatusGprs;
        private Label lblStatusDate;
        private Label lblStatusIMEI;
        private Label lblStatusProtocol;
        private Label lblStatusSim;
        private Label label177;
        private GroupBox groupBox25;
        private Label lblDataFlash;
        private Label lblFirmwareVer;
        private Label lblClientID;
        private Label lblHardwareVer;
        private Label lblStatusDeviceID;
        private Label lblStatusDeviceModel;
        private Label label182;
        private Label label183;
        private Label label184;
        private Label label185;
        private Label label186;
        private Label label187;
        private Panel pnlConsole;
        private Label label188;
        private TextBox txtSystemLog;
        private TextBox txtConsoleInput;
        private Button btnConsoleSend;
        private GroupBox groupBox23;
        private Button btnModbusRead;
        private Button btnLogMonitorOff;
        private Button btnClear;
        private GroupBox groupBox17;
        private ComboBox cmbModbusUartType;
        private Label lblPortType;
        private ComboBox cmbSelectDevice;
        private Label label189;
        private TextBox txtMasterTimeout;
        private Label label190;
        private TextBox txtModbusTimeout;
        private Label label194;
        private TextBox txtModbusPollingInterval;
        private Label label193;
        private ComboBox cmbMasterFunctionCode1;
        private Label label192;
        private ComboBox cmbModbusBaudRate;
        private Label label191;
        private Button btnModbusSlaveWriteMemory;
        private Button btnModbusSlaveReadMemory;
        private TextBox txtModbusSlaveId;
        private ComboBox cmbModbusPortType;
        private GroupBox groupBox18;
        private ComboBox cmbMasterSlaveIndex;
        private Label label195;
        private Button btnSlaveConnectionWriteMemory;
        private Button btnSlaveConnectionReadMemory;
        private TextBox txtMasterSlaveId;
        private Label label197;
        private TextBox txtMasterPollingInterval;
        private Label label198;
        private ComboBox cmbMasterUartType;
        private ComboBox cmbMasterBaudRate;
        private Label label200;
        private Label label199;
        private GroupBox groupBox19;
        private Label label196;
        private Label label201;
        private Label label202;
        private Label label203;
        private Label label204;
        private Label label207;
        private Label label206;
        private Label label205;
        private Panel pnlMasterScroll;
        private GroupBox groupBox20;
        private Button btnRegWriteMemory1;
        private Button btnRegReadMemory1;
        private TextBox txtMasterScaleFactor1;
        private TextBox txtMasterName1;
        private TextBox txtMasterRegStartAddress1;
        private TextBox txtMasterRegIndex1;
        private ComboBox cmbMasterByteOrder1;
        private ComboBox cmbMasterDataType1;
        private ComboBox cmbMasterActivation1;
        private GroupBox groupBox28;
        private ComboBox cmbMasterFunctionCode8;
        private ComboBox cmbMasterByteOrder8;
        private ComboBox cmbMasterDataType8;
        private ComboBox cmbMasterActivation8;
        private Button btnRegWriteMemory8;
        private Button btnRegReadMemory8;
        private TextBox txtMasterScaleFactor8;
        private TextBox txtMasterName8;
        private TextBox txtMasterRegStartAddress8;
        private TextBox txtMasterRegIndex8;
        private GroupBox groupBox29;
        private ComboBox cmbMasterFunctionCode6;
        private ComboBox cmbMasterByteOrder6;
        private ComboBox cmbMasterDataType6;
        private ComboBox cmbMasterActivation6;
        private Button btnRegWriteMemory6;
        private Button btnRegReadMemory6;
        private TextBox txtMasterScaleFactor6;
        private TextBox txtMasterName6;
        private TextBox txtMasterRegStartAddress6;
        private TextBox txtMasterRegIndex6;
        private GroupBox groupBox30;
        private ComboBox cmbMasterFunctionCode7;
        private ComboBox cmbMasterByteOrder7;
        private ComboBox cmbMasterDataType7;
        private ComboBox cmbMasterActivation7;
        private Button btnRegWriteMemory7;
        private Button btnRegReadMemory7;
        private TextBox txtMasterScaleFactor7;
        private TextBox txtMasterName7;
        private TextBox txtMasterRegStartAddress7;
        private TextBox txtMasterRegIndex7;
        private GroupBox groupBox31;
        private ComboBox cmbMasterFunctionCode5;
        private ComboBox cmbMasterByteOrder5;
        private ComboBox cmbMasterDataType5;
        private ComboBox cmbMasterActivation5;
        private Button btnRegWriteMemory5;
        private Button btnRegReadMemory5;
        private TextBox txtMasterScaleFactor5;
        private TextBox txtMasterName5;
        private TextBox txtMasterRegStartAddress5;
        private TextBox txtMasterRegIndex5;
        private GroupBox groupBox22;
        private ComboBox cmbMasterFunctionCode4;
        private ComboBox cmbMasterByteOrder4;
        private ComboBox cmbMasterDataType4;
        private ComboBox cmbMasterActivation4;
        private Button btnRegWriteMemory4;
        private Button btnRegReadMemory4;
        private TextBox txtMasterScaleFactor4;
        private TextBox txtMasterName4;
        private TextBox txtMasterRegStartAddress4;
        private TextBox txtMasterRegIndex4;
        private GroupBox groupBox24;
        private ComboBox cmbMasterFunctionCode3;
        private ComboBox cmbMasterByteOrder3;
        private ComboBox cmbMasterDataType3;
        private ComboBox cmbMasterActivation3;
        private Button btnRegWriteMemory3;
        private Button btnRegReadMemory3;
        private TextBox txtMasterScaleFactor3;
        private TextBox txtMasterName3;
        private TextBox txtMasterRegStartAddress3;
        private TextBox txtMasterRegIndex3;
        private GroupBox groupBox21;
        private ComboBox cmbMasterFunctionCode2;
        private ComboBox cmbMasterByteOrder2;
        private ComboBox cmbMasterDataType2;
        private ComboBox cmbMasterActivation2;
        private Button btnRegWriteMemory2;
        private Button btnRegReadMemory2;
        private TextBox txtMasterScaleFactor2;
        private TextBox txtMasterName2;
        private TextBox txtMasterRegStartAddress2;
        private TextBox txtMasterRegIndex2;
        private GroupBox groupBox32;
        private ComboBox cmbMasterFunctionCode10;
        private ComboBox cmbMasterByteOrder10;
        private ComboBox cmbMasterDataType10;
        private ComboBox cmbMasterActivation10;
        private Button btnRegWriteMemory10;
        private Button btnRegReadMemory10;
        private TextBox txtMasterScaleFactor10;
        private TextBox txtMasterName10;
        private TextBox txtMasterRegStartAddress10;
        private TextBox txtMasterRegIndex10;
        private GroupBox groupBox33;
        private ComboBox cmbMasterFunctionCode9;
        private ComboBox cmbMasterByteOrder9;
        private ComboBox cmbMasterDataType9;
        private ComboBox cmbMasterActivation9;
        private Button btnRegWriteMemory9;
        private Button btnRegReadMemory9;
        private TextBox txtMasterScaleFactor9;
        private TextBox txtMasterName9;
        private TextBox txtMasterRegStartAddress9;
        private TextBox txtMasterRegIndex9;
        private GroupBox groupBox34;
        private ComboBox cmbMasterFunctionCode12;
        private ComboBox cmbMasterByteOrder12;
        private ComboBox cmbMasterDataType12;
        private ComboBox cmbMasterActivation12;
        private Button btnRegWriteMemory12;
        private Button btnRegReadMemory12;
        private TextBox txtMasterScaleFactor12;
        private TextBox txtMasterName12;
        private TextBox txtMasterRegStartAddress12;
        private TextBox txtMasterRegIndex12;
        private GroupBox groupBox35;
        private ComboBox cmbMasterFunctionCode20;
        private ComboBox cmbMasterByteOrder20;
        private ComboBox cmbMasterDataType20;
        private ComboBox cmbMasterActivation20;
        private Button btnRegWriteMemory20;
        private Button btnRegReadMemory20;
        private TextBox txtMasterScaleFactor20;
        private TextBox txtMasterName20;
        private TextBox txtMasterRegStartAddress20;
        private TextBox txtMasterRegIndex20;
        private GroupBox groupBox36;
        private ComboBox cmbMasterFunctionCode19;
        private ComboBox cmbMasterByteOrder19;
        private ComboBox cmbMasterDataType19;
        private ComboBox cmbMasterActivation19;
        private Button btnRegWriteMemory19;
        private Button btnRegReadMemory19;
        private TextBox txtMasterScaleFactor19;
        private TextBox txtMasterName19;
        private TextBox txtMasterRegStartAddress19;
        private TextBox txtMasterRegIndex19;
        private GroupBox groupBox37;
        private ComboBox cmbMasterFunctionCode18;
        private ComboBox cmbMasterByteOrder18;
        private ComboBox cmbMasterDataType18;
        private ComboBox cmbMasterActivation18;
        private Button btnRegWriteMemory18;
        private Button btnRegReadMemory18;
        private TextBox txtMasterScaleFactor18;
        private TextBox txtMasterName18;
        private TextBox txtMasterRegStartAddress18;
        private TextBox txtMasterRegIndex18;
        private GroupBox groupBox38;
        private ComboBox cmbMasterFunctionCode16;
        private ComboBox cmbMasterByteOrder16;
        private ComboBox cmbMasterDataType16;
        private ComboBox cmbMasterActivation16;
        private Button btnRegWriteMemory16;
        private Button btnRegReadMemory16;
        private TextBox txtMasterScaleFactor16;
        private TextBox txtMasterName16;
        private TextBox txtMasterRegStartAddress16;
        private TextBox txtMasterRegIndex16;
        private GroupBox groupBox39;
        private ComboBox cmbMasterFunctionCode17;
        private ComboBox cmbMasterByteOrder17;
        private ComboBox cmbMasterDataType17;
        private ComboBox cmbMasterActivation17;
        private Button btnRegWriteMemory17;
        private Button btnRegReadMemory17;
        private TextBox txtMasterScaleFactor17;
        private TextBox txtMasterName17;
        private TextBox txtMasterRegStartAddress17;
        private TextBox txtMasterRegIndex17;
        private GroupBox groupBox40;
        private ComboBox cmbMasterFunctionCode15;
        private ComboBox cmbMasterByteOrder15;
        private ComboBox cmbMasterDataType15;
        private ComboBox cmbMasterActivation15;
        private Button btnRegWriteMemory15;
        private Button btnRegReadMemory15;
        private TextBox txtMasterScaleFactor15;
        private TextBox txtMasterName15;
        private TextBox txtMasterRegStartAddress15;
        private TextBox txtMasterRegIndex15;
        private GroupBox groupBox41;
        private ComboBox cmbMasterFunctionCode14;
        private ComboBox cmbMasterByteOrder14;
        private ComboBox cmbMasterDataType14;
        private ComboBox cmbMasterActivation14;
        private Button btnRegWriteMemory14;
        private Button btnRegReadMemory14;
        private TextBox txtMasterScaleFactor14;
        private TextBox txtMasterName14;
        private TextBox txtMasterRegStartAddress14;
        private TextBox txtMasterRegIndex14;
        private GroupBox groupBox42;
        private ComboBox cmbMasterFunctionCode13;
        private ComboBox cmbMasterByteOrder13;
        private ComboBox cmbMasterDataType13;
        private ComboBox cmbMasterActivation13;
        private Button btnRegWriteMemory13;
        private Button btnRegReadMemory13;
        private TextBox txtMasterScaleFactor13;
        private TextBox txtMasterName13;
        private TextBox txtMasterRegStartAddress13;
        private TextBox txtMasterRegIndex13;
        private GroupBox groupBox43;
        private ComboBox cmbMasterFunctionCode11;
        private ComboBox cmbMasterByteOrder11;
        private ComboBox cmbMasterDataType11;
        private ComboBox cmbMasterActivation11;
        private Button btnRegWriteMemory11;
        private Button btnRegReadMemory11;
        private TextBox txtMasterScaleFactor11;
        private TextBox txtMasterName11;
        private TextBox txtMasterRegStartAddress11;
        private TextBox txtMasterRegIndex11;
        private Label label208;
        private Label label209;
        private Label label210;
        private Label label212;
        private Label label211;
        private Label label213;
        private Label label214;
        private Label label215;
        private Label label216;
        private Label label217;
        private Label label218;
        private Label label219;
        private Label label220;
        private Label label222;
        private Label label221;
        private Label label223;
        private Label label224;
        private Label label226;
        private Label label225;
        private Label label227;
        private Button btnMasterWriteAll;
        private Label label171;
        private Label lblStatusDatalogSec;
        private Label lblTot8;
        private Label lblTot7;
        private Label lblTot6;
        private Label lblTot5;
        private Label lblTot4;
        private Label lblTot3;
        private Label lblTot2;
        private Label lblAna8;
        private Label lblAna7;
        private Label lblAna6;
        private Label lblAna5;
        private Label lblAna4;
        private Label lblAna3;
        private Label lblAna2;
        private Label lblAna1;
        private PictureBox pbDigiOut1;
        private PictureBox pbDigiOut8;
        private PictureBox pbDigiOut7;
        private PictureBox pbDigiOut6;
        private PictureBox pbDigiOut5;
        private PictureBox pbDigiOut4;
        private PictureBox pbDigiOut3;
        private PictureBox pbDigiOut2;
        private PictureBox pbDigiIn8;
        private PictureBox pbDigiIn7;
        private PictureBox pbDigiIn6;
        private PictureBox pbDigiIn5;
        private PictureBox pbDigiIn4;
        private PictureBox pbDigiIn3;
        private PictureBox pbDigiIn2;
        private PictureBox pbDigiIn1;
        private Label lblStatusPulseCounter8;
        private Label lblStatusPulseCounter7;
        private Label lblStatusPulseCounter6;
        private Label lblStatusPulseCounter5;
        private Label lblStatusPulseCounter4;
        private Label lblStatusPulseCounter3;
        private Label lblStatusPulseCounter2;
        private Button btnPortRefresh;
        private System.Windows.Forms.Timer errorReset;
        private Button btnMasterReadAll;
        private Button button2;
        private Button button1;
        private Button btnOpenConfigFile;
        private LinkLabel lnkLogin;
        private PictureBox pictureBox1;
        private Label label133;
        private ComboBox cmbDecimalPoint11;
        private ComboBox cmbDecimalPoint10;
        private ComboBox cmbDecimalPoint12;
        private ComboBox cmbDecimalPoint18;
        private ComboBox cmbDecimalPoint16;
        private ComboBox cmbDecimalPoint17;
        private ComboBox cmbDecimalPoint15;
        private ComboBox cmbDecimalPoint14;
        private ComboBox cmbDecimalPoint13;
        private ComboBox cmbDecimalPoint20;
        private ComboBox cmbDecimalPoint19;
        private ComboBox cmbDecimalPoint2;
        private ComboBox cmbDecimalPoint4;
        private ComboBox cmbDecimalPoint3;
        private ComboBox cmbDecimalPoint1;
        private ComboBox cmbDecimalPoint9;
        private ComboBox cmbDecimalPoint8;
        private ComboBox cmbDecimalPoint6;
        private ComboBox cmbDecimalPoint7;
        private ComboBox cmbDecimalPoint5;
        private GroupBox groupBox44;
        private ComboBox cmbDecimalPoint32;
        private Label label178;
        private ComboBox cmbMasterFunctionCode32;
        private ComboBox cmbMasterByteOrder32;
        private ComboBox cmbMasterDataType32;
        private ComboBox cmbMasterActivation32;
        private Button btnRegWriteMemory32;
        private Button btnRegReadMemory32;
        private TextBox txtMasterScaleFactor32;
        private TextBox txtMasterName32;
        private TextBox txtMasterRegStartAddress32;
        private TextBox txtMasterRegIndex32;
        private GroupBox groupBox45;
        private ComboBox cmbDecimalPoint40;
        private Label label179;
        private ComboBox cmbMasterFunctionCode40;
        private ComboBox cmbMasterByteOrder40;
        private ComboBox cmbMasterDataType40;
        private ComboBox cmbMasterActivation40;
        private Button btnRegWriteMemory40;
        private Button btnRegReadMemory40;
        private TextBox txtMasterScaleFactor40;
        private TextBox txtMasterName40;
        private TextBox txtMasterRegStartAddress40;
        private TextBox txtMasterRegIndex40;
        private GroupBox groupBox46;
        private ComboBox cmbDecimalPoint39;
        private Label label180;
        private ComboBox cmbMasterFunctionCode39;
        private ComboBox cmbMasterByteOrder39;
        private ComboBox cmbMasterDataType39;
        private ComboBox cmbMasterActivation39;
        private Button btnRegWriteMemory39;
        private Button btnRegReadMemory39;
        private TextBox txtMasterScaleFactor39;
        private TextBox txtMasterName39;
        private TextBox txtMasterRegStartAddress39;
        private TextBox txtMasterRegIndex39;
        private GroupBox groupBox47;
        private ComboBox cmbDecimalPoint38;
        private Label label181;
        private ComboBox cmbMasterFunctionCode38;
        private ComboBox cmbMasterByteOrder38;
        private ComboBox cmbMasterDataType38;
        private ComboBox cmbMasterActivation38;
        private Button btnRegWriteMemory38;
        private Button btnRegReadMemory38;
        private TextBox txtMasterScaleFactor38;
        private TextBox txtMasterName38;
        private TextBox txtMasterRegStartAddress38;
        private TextBox txtMasterRegIndex38;
        private GroupBox groupBox48;
        private ComboBox cmbDecimalPoint36;
        private Label label228;
        private ComboBox cmbMasterFunctionCode36;
        private ComboBox cmbMasterByteOrder36;
        private ComboBox cmbMasterDataType36;
        private ComboBox cmbMasterActivation36;
        private Button btnRegWriteMemory36;
        private Button btnRegReadMemory36;
        private TextBox txtMasterScaleFactor36;
        private TextBox txtMasterName36;
        private TextBox txtMasterRegStartAddress36;
        private TextBox txtMasterRegIndex36;
        private GroupBox groupBox49;
        private ComboBox cmbDecimalPoint37;
        private Label label229;
        private ComboBox cmbMasterFunctionCode37;
        private ComboBox cmbMasterByteOrder37;
        private ComboBox cmbMasterDataType37;
        private ComboBox cmbMasterActivation37;
        private Button btnRegWriteMemory37;
        private Button btnRegReadMemory37;
        private TextBox txtMasterScaleFactor37;
        private TextBox txtMasterName37;
        private TextBox txtMasterRegStartAddress37;
        private TextBox txtMasterRegIndex37;
        private GroupBox groupBox50;
        private ComboBox cmbDecimalPoint35;
        private Label label230;
        private ComboBox cmbMasterFunctionCode35;
        private ComboBox cmbMasterByteOrder35;
        private ComboBox cmbMasterDataType35;
        private ComboBox cmbMasterActivation35;
        private Button btnRegWriteMemory35;
        private Button btnRegReadMemory35;
        private TextBox txtMasterScaleFactor35;
        private TextBox txtMasterName35;
        private TextBox txtMasterRegStartAddress35;
        private TextBox txtMasterRegIndex35;
        private GroupBox groupBox51;
        private ComboBox cmbDecimalPoint34;
        private Label label231;
        private ComboBox cmbMasterFunctionCode34;
        private ComboBox cmbMasterByteOrder34;
        private ComboBox cmbMasterDataType34;
        private ComboBox cmbMasterActivation34;
        private Button btnRegWriteMemory34;
        private Button btnRegReadMemory34;
        private TextBox txtMasterScaleFactor34;
        private TextBox txtMasterName34;
        private TextBox txtMasterRegStartAddress34;
        private TextBox txtMasterRegIndex34;
        private GroupBox groupBox52;
        private ComboBox cmbDecimalPoint33;
        private Label label232;
        private ComboBox cmbMasterFunctionCode33;
        private ComboBox cmbMasterByteOrder33;
        private ComboBox cmbMasterDataType33;
        private ComboBox cmbMasterActivation33;
        private Button btnRegWriteMemory33;
        private Button btnRegReadMemory33;
        private TextBox txtMasterScaleFactor33;
        private TextBox txtMasterName33;
        private TextBox txtMasterRegStartAddress33;
        private TextBox txtMasterRegIndex33;
        private GroupBox groupBox53;
        private ComboBox cmbDecimalPoint31;
        private Label label233;
        private ComboBox cmbMasterFunctionCode31;
        private ComboBox cmbMasterByteOrder31;
        private ComboBox cmbMasterDataType31;
        private ComboBox cmbMasterActivation31;
        private Button btnRegWriteMemory31;
        private Button btnRegReadMemory31;
        private TextBox txtMasterScaleFactor31;
        private TextBox txtMasterName31;
        private TextBox txtMasterRegStartAddress31;
        private TextBox txtMasterRegIndex31;
        private GroupBox groupBox54;
        private ComboBox cmbDecimalPoint22;
        private Label label234;
        private ComboBox cmbMasterFunctionCode22;
        private ComboBox cmbMasterByteOrder22;
        private ComboBox cmbMasterDataType22;
        private ComboBox cmbMasterActivation22;
        private Button btnRegWriteMemory22;
        private Button btnRegReadMemory22;
        private TextBox txtMasterScaleFactor22;
        private TextBox txtMasterName22;
        private TextBox txtMasterRegStartAddress22;
        private TextBox txtMasterRegIndex22;
        private GroupBox groupBox55;
        private ComboBox cmbDecimalPoint30;
        private Label label235;
        private ComboBox cmbMasterFunctionCode30;
        private ComboBox cmbMasterByteOrder30;
        private ComboBox cmbMasterDataType30;
        private ComboBox cmbMasterActivation30;
        private Button btnRegWriteMemory30;
        private Button btnRegReadMemory30;
        private TextBox txtMasterScaleFactor30;
        private TextBox txtMasterName30;
        private TextBox txtMasterRegStartAddress30;
        private TextBox txtMasterRegIndex30;
        private GroupBox groupBox56;
        private ComboBox cmbDecimalPoint29;
        private Label label236;
        private ComboBox cmbMasterFunctionCode29;
        private ComboBox cmbMasterByteOrder29;
        private ComboBox cmbMasterDataType29;
        private ComboBox cmbMasterActivation29;
        private Button btnRegWriteMemory29;
        private Button btnRegReadMemory29;
        private TextBox txtMasterScaleFactor29;
        private TextBox txtMasterName29;
        private TextBox txtMasterRegStartAddress29;
        private TextBox txtMasterRegIndex29;
        private GroupBox groupBox57;
        private ComboBox cmbDecimalPoint28;
        private Label label237;
        private ComboBox cmbMasterFunctionCode28;
        private ComboBox cmbMasterByteOrder28;
        private ComboBox cmbMasterDataType28;
        private ComboBox cmbMasterActivation28;
        private Button btnRegWriteMemory28;
        private Button btnRegReadMemory28;
        private TextBox txtMasterScaleFactor28;
        private TextBox txtMasterName28;
        private TextBox txtMasterRegStartAddress28;
        private TextBox txtMasterRegIndex28;
        private GroupBox groupBox58;
        private ComboBox cmbDecimalPoint26;
        private Label label238;
        private ComboBox cmbMasterFunctionCode26;
        private ComboBox cmbMasterByteOrder26;
        private ComboBox cmbMasterDataType26;
        private ComboBox cmbMasterActivation26;
        private Button btnRegWriteMemory26;
        private Button btnRegReadMemory26;
        private TextBox txtMasterScaleFactor26;
        private TextBox txtMasterName26;
        private TextBox txtMasterRegStartAddress26;
        private TextBox txtMasterRegIndex26;
        private GroupBox groupBox59;
        private ComboBox cmbDecimalPoint27;
        private Label label239;
        private ComboBox cmbMasterFunctionCode27;
        private ComboBox cmbMasterByteOrder27;
        private ComboBox cmbMasterDataType27;
        private ComboBox cmbMasterActivation27;
        private Button btnRegWriteMemory27;
        private Button btnRegReadMemory27;
        private TextBox txtMasterScaleFactor27;
        private TextBox txtMasterName27;
        private TextBox txtMasterRegStartAddress27;
        private TextBox txtMasterRegIndex27;
        private GroupBox groupBox60;
        private ComboBox cmbDecimalPoint25;
        private Label label240;
        private ComboBox cmbMasterFunctionCode25;
        private ComboBox cmbMasterByteOrder25;
        private ComboBox cmbMasterDataType25;
        private ComboBox cmbMasterActivation25;
        private Button btnRegWriteMemory25;
        private Button btnRegReadMemory25;
        private TextBox txtMasterScaleFactor25;
        private TextBox txtMasterName25;
        private TextBox txtMasterRegStartAddress25;
        private TextBox txtMasterRegIndex25;
        private GroupBox groupBox61;
        private ComboBox cmbDecimalPoint24;
        private Label label241;
        private ComboBox cmbMasterFunctionCode24;
        private ComboBox cmbMasterByteOrder24;
        private ComboBox cmbMasterDataType24;
        private ComboBox cmbMasterActivation24;
        private Button btnRegWriteMemory24;
        private Button btnRegReadMemory24;
        private TextBox txtMasterScaleFactor24;
        private TextBox txtMasterName24;
        private TextBox txtMasterRegStartAddress24;
        private TextBox txtMasterRegIndex24;
        private GroupBox groupBox62;
        private ComboBox cmbDecimalPoint23;
        private Label label242;
        private ComboBox cmbMasterFunctionCode23;
        private ComboBox cmbMasterByteOrder23;
        private ComboBox cmbMasterDataType23;
        private ComboBox cmbMasterActivation23;
        private Button btnRegWriteMemory23;
        private Button btnRegReadMemory23;
        private TextBox txtMasterScaleFactor23;
        private TextBox txtMasterName23;
        private TextBox txtMasterRegStartAddress23;
        private TextBox txtMasterRegIndex23;
        private GroupBox groupBox63;
        private ComboBox cmbDecimalPoint21;
        private Label label243;
        private ComboBox cmbMasterFunctionCode21;
        private ComboBox cmbMasterByteOrder21;
        private ComboBox cmbMasterDataType21;
        private ComboBox cmbMasterActivation21;
        private Button btnRegWriteMemory21;
        private Button btnRegReadMemory21;
        private TextBox txtMasterScaleFactor21;
        private TextBox txtMasterName21;
        private TextBox txtMasterRegStartAddress21;
        private TextBox txtMasterRegIndex21;
        private Label lblError;
        private Label lblErrorDetails;
    }
}