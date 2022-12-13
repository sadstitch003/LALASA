using System.Windows.Forms;

namespace LALASA
{
    partial class form_Menu
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tc_MainMenu = new System.Windows.Forms.TabControl();
            this.tb_Transaction = new System.Windows.Forms.TabPage();
            this.Pnl_TransMenu = new System.Windows.Forms.Panel();
            this.pnl_Line = new System.Windows.Forms.Panel();
            this.nud_QuantityService = new System.Windows.Forms.NumericUpDown();
            this.lbl_Text17 = new System.Windows.Forms.Label();
            this.dgv_DetailTransServices = new System.Windows.Forms.DataGridView();
            this.btn_DeleteService = new System.Windows.Forms.Button();
            this.btn_AddService = new System.Windows.Forms.Button();
            this.tb_ServiceFee = new System.Windows.Forms.TextBox();
            this.lbl_Text16 = new System.Windows.Forms.Label();
            this.tb_ServiceName = new System.Windows.Forms.TextBox();
            this.lbl_Text15 = new System.Windows.Forms.Label();
            this.cb_ServiceID = new System.Windows.Forms.ComboBox();
            this.lbl_Text14 = new System.Windows.Forms.Label();
            this.lbl_Test13 = new System.Windows.Forms.Label();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.lbl_Text12 = new System.Windows.Forms.Label();
            this.tb_AdditionalFee = new System.Windows.Forms.TextBox();
            this.lbl_Text11 = new System.Windows.Forms.Label();
            this.tb_TransSubtotal = new System.Windows.Forms.TextBox();
            this.lbl_Text10 = new System.Windows.Forms.Label();
            this.dtp_DueDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_Text9 = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Text8 = new System.Windows.Forms.Label();
            this.lbl_Text7 = new System.Windows.Forms.Label();
            this.cb_CustomerID = new System.Windows.Forms.ComboBox();
            this.lbl_Text2 = new System.Windows.Forms.Label();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_CompanyName = new System.Windows.Forms.TextBox();
            this.tb_CustomerName = new System.Windows.Forms.TextBox();
            this.lbl_Text6 = new System.Windows.Forms.Label();
            this.lbl_Text5 = new System.Windows.Forms.Label();
            this.lbl_Text4 = new System.Windows.Forms.Label();
            this.lbl_Text3 = new System.Windows.Forms.Label();
            this.lbl_Text1 = new System.Windows.Forms.Label();
            this.pnl_TransTitleBar = new System.Windows.Forms.Panel();
            this.btn_CreateTrans = new System.Windows.Forms.Button();
            this.btn_DeleteTrans = new System.Windows.Forms.Button();
            this.btn_ClearTrans = new System.Windows.Forms.Button();
            this.lbl_TransCode = new System.Windows.Forms.Label();
            this.pnl_TransSideMenu = new System.Windows.Forms.Panel();
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.tb_TransSearch = new System.Windows.Forms.TextBox();
            this.dgv_TransList = new System.Windows.Forms.DataGridView();
            this.tb_DetailTrans = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.nud_QtyTrans = new System.Windows.Forms.NumericUpDown();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_TSDelete = new System.Windows.Forms.Button();
            this.dgv_TSList = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_TSAdd = new System.Windows.Forms.Button();
            this.cb_TransServiceID = new System.Windows.Forms.ComboBox();
            this.tb_TransServiceFee = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_TransServiceName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.dgv_TransDTList = new System.Windows.Forms.DataGridView();
            this.tb_Schedule = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_SchDetailServiceList = new System.Windows.Forms.DataGridView();
            this.cb_StaffScheduleList = new System.Windows.Forms.ComboBox();
            this.tb_SchStaffPosition = new System.Windows.Forms.TextBox();
            this.tb_SchStaffName = new System.Windows.Forms.TextBox();
            this.dtp_SEnd = new System.Windows.Forms.DateTimePicker();
            this.dtp_SStart = new System.Windows.Forms.DateTimePicker();
            this.tb_ScheduleID = new System.Windows.Forms.TextBox();
            this.tb_TransScheduleID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ScheduleList = new System.Windows.Forms.DataGridView();
            this.btn_SDelete = new System.Windows.Forms.Button();
            this.btn_SAdd = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_SearchTransSchedule = new System.Windows.Forms.TextBox();
            this.dgv_TransScheduleList = new System.Windows.Forms.DataGridView();
            this.tb_Payment = new System.Windows.Forms.TabPage();
            this.cb_PPaymentType = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.tb_PPaymentID = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.tb_PPaymentAmount = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.dtp_PaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.btn_PDelete = new System.Windows.Forms.Button();
            this.dgv_Payment = new System.Windows.Forms.DataGridView();
            this.btn_PAdd = new System.Windows.Forms.Button();
            this.tb_PTransactionID = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label41 = new System.Windows.Forms.Label();
            this.tb_PDesc = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.tb_PAddFee = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.tb_PTransTotal = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.dtp_PDueDate = new System.Windows.Forms.DateTimePicker();
            this.label38 = new System.Windows.Forms.Label();
            this.dtp_PDate = new System.Windows.Forms.DateTimePicker();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.tb_PTransID = new System.Windows.Forms.TextBox();
            this.dgv_PTransID = new System.Windows.Forms.DataGridView();
            this.tb_Customer = new System.Windows.Forms.TabPage();
            this.panel13 = new System.Windows.Forms.Panel();
            this.tb_CCustID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgv_CCust = new System.Windows.Forms.DataGridView();
            this.label28 = new System.Windows.Forms.Label();
            this.tb_CPhone = new System.Windows.Forms.TextBox();
            this.tb_CAddress = new System.Windows.Forms.TextBox();
            this.tb_CCompany = new System.Windows.Forms.TextBox();
            this.tb_CCustName = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btn_CUpdate = new System.Windows.Forms.Button();
            this.btn_CCreate = new System.Windows.Forms.Button();
            this.btn_CDelete = new System.Windows.Forms.Button();
            this.btn_CClear = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tb_SearchCust = new System.Windows.Forms.TextBox();
            this.dgv_Cust = new System.Windows.Forms.DataGridView();
            this.tb_Staff = new System.Windows.Forms.TabPage();
            this.panel14 = new System.Windows.Forms.Panel();
            this.tb_SPassword = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tb_SAddress = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tb_SStaffID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgv_SStaff = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_SPhone = new System.Windows.Forms.TextBox();
            this.tb_SEmail = new System.Windows.Forms.TextBox();
            this.tb_SPosition = new System.Windows.Forms.TextBox();
            this.tb_SName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.btn_SUpdate = new System.Windows.Forms.Button();
            this.btn_SCreate = new System.Windows.Forms.Button();
            this.btn_SDel = new System.Windows.Forms.Button();
            this.btn_SClear = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.tb_StaffID = new System.Windows.Forms.TextBox();
            this.dgv_Staff = new System.Windows.Forms.DataGridView();
            this.tb_View = new System.Windows.Forms.TabPage();
            this.dgv_View = new System.Windows.Forms.DataGridView();
            this.ms_ViewMenu = new System.Windows.Forms.MenuStrip();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ongoingTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lateTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doneTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_TUpdate = new System.Windows.Forms.Button();
            this.tc_MainMenu.SuspendLayout();
            this.tb_Transaction.SuspendLayout();
            this.Pnl_TransMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_QuantityService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetailTransServices)).BeginInit();
            this.pnl_TransTitleBar.SuspendLayout();
            this.pnl_TransSideMenu.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TransList)).BeginInit();
            this.tb_DetailTrans.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_QtyTrans)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TSList)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TransDTList)).BeginInit();
            this.tb_Schedule.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SchDetailServiceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ScheduleList)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TransScheduleList)).BeginInit();
            this.tb_Payment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payment)).BeginInit();
            this.panel19.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PTransID)).BeginInit();
            this.tb_Customer.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CCust)).BeginInit();
            this.panel15.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cust)).BeginInit();
            this.tb_Staff.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SStaff)).BeginInit();
            this.panel16.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Staff)).BeginInit();
            this.tb_View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).BeginInit();
            this.ms_ViewMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_MainMenu
            // 
            this.tc_MainMenu.Controls.Add(this.tb_Transaction);
            this.tc_MainMenu.Controls.Add(this.tb_DetailTrans);
            this.tc_MainMenu.Controls.Add(this.tb_Schedule);
            this.tc_MainMenu.Controls.Add(this.tb_Payment);
            this.tc_MainMenu.Controls.Add(this.tb_Customer);
            this.tc_MainMenu.Controls.Add(this.tb_Staff);
            this.tc_MainMenu.Controls.Add(this.tb_View);
            this.tc_MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.tc_MainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tc_MainMenu.Name = "tc_MainMenu";
            this.tc_MainMenu.SelectedIndex = 0;
            this.tc_MainMenu.Size = new System.Drawing.Size(1215, 581);
            this.tc_MainMenu.TabIndex = 4;
            this.tc_MainMenu.SelectedIndexChanged += new System.EventHandler(this.tc_MainMenu_SelectedIndexChanged);
            // 
            // tb_Transaction
            // 
            this.tb_Transaction.Controls.Add(this.Pnl_TransMenu);
            this.tb_Transaction.Controls.Add(this.pnl_TransSideMenu);
            this.tb_Transaction.Location = new System.Drawing.Point(4, 25);
            this.tb_Transaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Transaction.Name = "tb_Transaction";
            this.tb_Transaction.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Transaction.Size = new System.Drawing.Size(1207, 552);
            this.tb_Transaction.TabIndex = 0;
            this.tb_Transaction.Text = "Transaction";
            this.tb_Transaction.UseVisualStyleBackColor = true;
            // 
            // Pnl_TransMenu
            // 
            this.Pnl_TransMenu.AutoScroll = true;
            this.Pnl_TransMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pnl_TransMenu.Controls.Add(this.pnl_Line);
            this.Pnl_TransMenu.Controls.Add(this.nud_QuantityService);
            this.Pnl_TransMenu.Controls.Add(this.lbl_Text17);
            this.Pnl_TransMenu.Controls.Add(this.dgv_DetailTransServices);
            this.Pnl_TransMenu.Controls.Add(this.btn_DeleteService);
            this.Pnl_TransMenu.Controls.Add(this.btn_AddService);
            this.Pnl_TransMenu.Controls.Add(this.tb_ServiceFee);
            this.Pnl_TransMenu.Controls.Add(this.lbl_Text16);
            this.Pnl_TransMenu.Controls.Add(this.tb_ServiceName);
            this.Pnl_TransMenu.Controls.Add(this.lbl_Text15);
            this.Pnl_TransMenu.Controls.Add(this.cb_ServiceID);
            this.Pnl_TransMenu.Controls.Add(this.lbl_Text14);
            this.Pnl_TransMenu.Controls.Add(this.lbl_Test13);
            this.Pnl_TransMenu.Controls.Add(this.tb_Description);
            this.Pnl_TransMenu.Controls.Add(this.lbl_Text12);
            this.Pnl_TransMenu.Controls.Add(this.tb_AdditionalFee);
            this.Pnl_TransMenu.Controls.Add(this.lbl_Text11);
            this.Pnl_TransMenu.Controls.Add(this.tb_TransSubtotal);
            this.Pnl_TransMenu.Controls.Add(this.lbl_Text10);
            this.Pnl_TransMenu.Controls.Add(this.dtp_DueDate);
            this.Pnl_TransMenu.Controls.Add(this.lbl_Text9);
            this.Pnl_TransMenu.Controls.Add(this.dtp_Date);
            this.Pnl_TransMenu.Controls.Add(this.lbl_Text8);
            this.Pnl_TransMenu.Controls.Add(this.lbl_Text7);
            this.Pnl_TransMenu.Controls.Add(this.cb_CustomerID);
            this.Pnl_TransMenu.Controls.Add(this.lbl_Text2);
            this.Pnl_TransMenu.Controls.Add(this.tb_Phone);
            this.Pnl_TransMenu.Controls.Add(this.tb_Address);
            this.Pnl_TransMenu.Controls.Add(this.tb_CompanyName);
            this.Pnl_TransMenu.Controls.Add(this.tb_CustomerName);
            this.Pnl_TransMenu.Controls.Add(this.lbl_Text6);
            this.Pnl_TransMenu.Controls.Add(this.lbl_Text5);
            this.Pnl_TransMenu.Controls.Add(this.lbl_Text4);
            this.Pnl_TransMenu.Controls.Add(this.lbl_Text3);
            this.Pnl_TransMenu.Controls.Add(this.lbl_Text1);
            this.Pnl_TransMenu.Controls.Add(this.pnl_TransTitleBar);
            this.Pnl_TransMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_TransMenu.Location = new System.Drawing.Point(253, 2);
            this.Pnl_TransMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_TransMenu.Name = "Pnl_TransMenu";
            this.Pnl_TransMenu.Size = new System.Drawing.Size(951, 548);
            this.Pnl_TransMenu.TabIndex = 2;
            // 
            // pnl_Line
            // 
            this.pnl_Line.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Line.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_Line.Location = new System.Drawing.Point(27, 218);
            this.pnl_Line.Name = "pnl_Line";
            this.pnl_Line.Size = new System.Drawing.Size(887, 2);
            this.pnl_Line.TabIndex = 40;
            // 
            // nud_QuantityService
            // 
            this.nud_QuantityService.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_QuantityService.Location = new System.Drawing.Point(166, 330);
            this.nud_QuantityService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_QuantityService.Name = "nud_QuantityService";
            this.nud_QuantityService.Size = new System.Drawing.Size(111, 25);
            this.nud_QuantityService.TabIndex = 39;
            this.nud_QuantityService.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_Text17
            // 
            this.lbl_Text17.AutoSize = true;
            this.lbl_Text17.Location = new System.Drawing.Point(23, 333);
            this.lbl_Text17.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbl_Text17.Name = "lbl_Text17";
            this.lbl_Text17.Size = new System.Drawing.Size(76, 16);
            this.lbl_Text17.TabIndex = 37;
            this.lbl_Text17.Text = "QUANTITY";
            // 
            // dgv_DetailTransServices
            // 
            this.dgv_DetailTransServices.AllowUserToAddRows = false;
            this.dgv_DetailTransServices.AllowUserToDeleteRows = false;
            this.dgv_DetailTransServices.AllowUserToResizeColumns = false;
            this.dgv_DetailTransServices.AllowUserToResizeRows = false;
            this.dgv_DetailTransServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DetailTransServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DetailTransServices.Location = new System.Drawing.Point(23, 393);
            this.dgv_DetailTransServices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_DetailTransServices.Name = "dgv_DetailTransServices";
            this.dgv_DetailTransServices.RowHeadersWidth = 51;
            this.dgv_DetailTransServices.RowTemplate.Height = 29;
            this.dgv_DetailTransServices.Size = new System.Drawing.Size(894, 138);
            this.dgv_DetailTransServices.TabIndex = 36;
            // 
            // btn_DeleteService
            // 
            this.btn_DeleteService.Location = new System.Drawing.Point(123, 366);
            this.btn_DeleteService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DeleteService.Name = "btn_DeleteService";
            this.btn_DeleteService.Size = new System.Drawing.Size(94, 23);
            this.btn_DeleteService.TabIndex = 34;
            this.btn_DeleteService.Text = "Delete";
            this.btn_DeleteService.UseVisualStyleBackColor = true;
            this.btn_DeleteService.Click += new System.EventHandler(this.btn_DeleteService_Click);
            // 
            // btn_AddService
            // 
            this.btn_AddService.Location = new System.Drawing.Point(23, 365);
            this.btn_AddService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddService.Name = "btn_AddService";
            this.btn_AddService.Size = new System.Drawing.Size(94, 23);
            this.btn_AddService.TabIndex = 33;
            this.btn_AddService.Text = "Add";
            this.btn_AddService.UseVisualStyleBackColor = true;
            this.btn_AddService.Click += new System.EventHandler(this.btn_AddService_Click);
            // 
            // tb_ServiceFee
            // 
            this.tb_ServiceFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ServiceFee.Location = new System.Drawing.Point(166, 304);
            this.tb_ServiceFee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ServiceFee.Name = "tb_ServiceFee";
            this.tb_ServiceFee.Size = new System.Drawing.Size(284, 22);
            this.tb_ServiceFee.TabIndex = 32;
            // 
            // lbl_Text16
            // 
            this.lbl_Text16.AutoSize = true;
            this.lbl_Text16.Location = new System.Drawing.Point(23, 307);
            this.lbl_Text16.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbl_Text16.Name = "lbl_Text16";
            this.lbl_Text16.Size = new System.Drawing.Size(94, 16);
            this.lbl_Text16.TabIndex = 31;
            this.lbl_Text16.Text = "SERVICE FEE";
            // 
            // tb_ServiceName
            // 
            this.tb_ServiceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ServiceName.Enabled = false;
            this.tb_ServiceName.Location = new System.Drawing.Point(166, 278);
            this.tb_ServiceName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ServiceName.Name = "tb_ServiceName";
            this.tb_ServiceName.Size = new System.Drawing.Size(284, 22);
            this.tb_ServiceName.TabIndex = 30;
            // 
            // lbl_Text15
            // 
            this.lbl_Text15.AutoSize = true;
            this.lbl_Text15.Location = new System.Drawing.Point(23, 281);
            this.lbl_Text15.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbl_Text15.Name = "lbl_Text15";
            this.lbl_Text15.Size = new System.Drawing.Size(107, 16);
            this.lbl_Text15.TabIndex = 29;
            this.lbl_Text15.Text = "SERVICE NAME";
            // 
            // cb_ServiceID
            // 
            this.cb_ServiceID.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ServiceID.FormattingEnabled = true;
            this.cb_ServiceID.Location = new System.Drawing.Point(166, 252);
            this.cb_ServiceID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_ServiceID.Name = "cb_ServiceID";
            this.cb_ServiceID.Size = new System.Drawing.Size(111, 25);
            this.cb_ServiceID.TabIndex = 28;
            this.cb_ServiceID.TextChanged += new System.EventHandler(this.cb_ServiceID_TextChanged);
            // 
            // lbl_Text14
            // 
            this.lbl_Text14.AutoSize = true;
            this.lbl_Text14.Location = new System.Drawing.Point(23, 255);
            this.lbl_Text14.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbl_Text14.Name = "lbl_Text14";
            this.lbl_Text14.Size = new System.Drawing.Size(81, 16);
            this.lbl_Text14.TabIndex = 27;
            this.lbl_Text14.Text = "SERVICE ID";
            // 
            // lbl_Test13
            // 
            this.lbl_Test13.AutoSize = true;
            this.lbl_Test13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Test13.Location = new System.Drawing.Point(23, 231);
            this.lbl_Test13.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbl_Test13.Name = "lbl_Test13";
            this.lbl_Test13.Size = new System.Drawing.Size(136, 20);
            this.lbl_Test13.TabIndex = 26;
            this.lbl_Test13.Text = "SERVICE REQUEST";
            // 
            // tb_Description
            // 
            this.tb_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Description.Location = new System.Drawing.Point(630, 176);
            this.tb_Description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(284, 22);
            this.tb_Description.TabIndex = 25;
            // 
            // lbl_Text12
            // 
            this.lbl_Text12.AutoSize = true;
            this.lbl_Text12.Location = new System.Drawing.Point(487, 180);
            this.lbl_Text12.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbl_Text12.Name = "lbl_Text12";
            this.lbl_Text12.Size = new System.Drawing.Size(98, 16);
            this.lbl_Text12.TabIndex = 24;
            this.lbl_Text12.Text = "DESCRIPTION";
            // 
            // tb_AdditionalFee
            // 
            this.tb_AdditionalFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_AdditionalFee.Location = new System.Drawing.Point(630, 150);
            this.tb_AdditionalFee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_AdditionalFee.Name = "tb_AdditionalFee";
            this.tb_AdditionalFee.Size = new System.Drawing.Size(284, 22);
            this.tb_AdditionalFee.TabIndex = 23;
            // 
            // lbl_Text11
            // 
            this.lbl_Text11.AutoSize = true;
            this.lbl_Text11.Location = new System.Drawing.Point(487, 153);
            this.lbl_Text11.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbl_Text11.Name = "lbl_Text11";
            this.lbl_Text11.Size = new System.Drawing.Size(116, 16);
            this.lbl_Text11.TabIndex = 22;
            this.lbl_Text11.Text = "ADDITIONAL FEE";
            // 
            // tb_TransSubtotal
            // 
            this.tb_TransSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_TransSubtotal.Enabled = false;
            this.tb_TransSubtotal.Location = new System.Drawing.Point(630, 124);
            this.tb_TransSubtotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TransSubtotal.Name = "tb_TransSubtotal";
            this.tb_TransSubtotal.Size = new System.Drawing.Size(284, 22);
            this.tb_TransSubtotal.TabIndex = 21;
            // 
            // lbl_Text10
            // 
            this.lbl_Text10.AutoSize = true;
            this.lbl_Text10.Location = new System.Drawing.Point(487, 126);
            this.lbl_Text10.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbl_Text10.Name = "lbl_Text10";
            this.lbl_Text10.Size = new System.Drawing.Size(79, 16);
            this.lbl_Text10.TabIndex = 20;
            this.lbl_Text10.Text = "SUBTOTAL";
            // 
            // dtp_DueDate
            // 
            this.dtp_DueDate.CalendarFont = new System.Drawing.Font("Segoe UI", 7.8F);
            this.dtp_DueDate.CustomFormat = "yyyy-MM-dd";
            this.dtp_DueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DueDate.Location = new System.Drawing.Point(630, 98);
            this.dtp_DueDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_DueDate.Name = "dtp_DueDate";
            this.dtp_DueDate.Size = new System.Drawing.Size(284, 22);
            this.dtp_DueDate.TabIndex = 19;
            // 
            // lbl_Text9
            // 
            this.lbl_Text9.AutoSize = true;
            this.lbl_Text9.Location = new System.Drawing.Point(487, 102);
            this.lbl_Text9.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbl_Text9.Name = "lbl_Text9";
            this.lbl_Text9.Size = new System.Drawing.Size(73, 16);
            this.lbl_Text9.TabIndex = 18;
            this.lbl_Text9.Text = "DUEDATE";
            // 
            // dtp_Date
            // 
            this.dtp_Date.CalendarFont = new System.Drawing.Font("Segoe UI", 7.8F);
            this.dtp_Date.CustomFormat = "yyyy-MM-dd";
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(630, 72);
            this.dtp_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(284, 22);
            this.dtp_Date.TabIndex = 17;
            // 
            // lbl_Text8
            // 
            this.lbl_Text8.AutoSize = true;
            this.lbl_Text8.Location = new System.Drawing.Point(487, 76);
            this.lbl_Text8.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbl_Text8.Name = "lbl_Text8";
            this.lbl_Text8.Size = new System.Drawing.Size(44, 16);
            this.lbl_Text8.TabIndex = 16;
            this.lbl_Text8.Text = "DATE";
            // 
            // lbl_Text7
            // 
            this.lbl_Text7.AutoSize = true;
            this.lbl_Text7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Text7.Location = new System.Drawing.Point(487, 51);
            this.lbl_Text7.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbl_Text7.Name = "lbl_Text7";
            this.lbl_Text7.Size = new System.Drawing.Size(171, 20);
            this.lbl_Text7.TabIndex = 15;
            this.lbl_Text7.Text = "DETAIL TRANSACTION";
            // 
            // cb_CustomerID
            // 
            this.cb_CustomerID.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_CustomerID.FormattingEnabled = true;
            this.cb_CustomerID.IntegralHeight = false;
            this.cb_CustomerID.Location = new System.Drawing.Point(166, 73);
            this.cb_CustomerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_CustomerID.Name = "cb_CustomerID";
            this.cb_CustomerID.Size = new System.Drawing.Size(111, 25);
            this.cb_CustomerID.TabIndex = 14;
            this.cb_CustomerID.TextChanged += new System.EventHandler(this.cb_CustomerID_TextChanged);
            // 
            // lbl_Text2
            // 
            this.lbl_Text2.AutoSize = true;
            this.lbl_Text2.Location = new System.Drawing.Point(23, 75);
            this.lbl_Text2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbl_Text2.Name = "lbl_Text2";
            this.lbl_Text2.Size = new System.Drawing.Size(100, 16);
            this.lbl_Text2.TabIndex = 12;
            this.lbl_Text2.Text = "CUSTOMER ID";
            // 
            // tb_Phone
            // 
            this.tb_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Phone.Location = new System.Drawing.Point(166, 176);
            this.tb_Phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(284, 22);
            this.tb_Phone.TabIndex = 11;
            // 
            // tb_Address
            // 
            this.tb_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Address.Location = new System.Drawing.Point(166, 150);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(284, 22);
            this.tb_Address.TabIndex = 10;
            // 
            // tb_CompanyName
            // 
            this.tb_CompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_CompanyName.Location = new System.Drawing.Point(166, 124);
            this.tb_CompanyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_CompanyName.Name = "tb_CompanyName";
            this.tb_CompanyName.Size = new System.Drawing.Size(284, 22);
            this.tb_CompanyName.TabIndex = 9;
            // 
            // tb_CustomerName
            // 
            this.tb_CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_CustomerName.Location = new System.Drawing.Point(166, 98);
            this.tb_CustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_CustomerName.Name = "tb_CustomerName";
            this.tb_CustomerName.Size = new System.Drawing.Size(284, 22);
            this.tb_CustomerName.TabIndex = 8;
            // 
            // lbl_Text6
            // 
            this.lbl_Text6.AutoSize = true;
            this.lbl_Text6.Location = new System.Drawing.Point(23, 178);
            this.lbl_Text6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbl_Text6.Name = "lbl_Text6";
            this.lbl_Text6.Size = new System.Drawing.Size(117, 16);
            this.lbl_Text6.TabIndex = 7;
            this.lbl_Text6.Text = "PHONE NUMBER";
            // 
            // lbl_Text5
            // 
            this.lbl_Text5.AutoSize = true;
            this.lbl_Text5.Location = new System.Drawing.Point(23, 152);
            this.lbl_Text5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbl_Text5.Name = "lbl_Text5";
            this.lbl_Text5.Size = new System.Drawing.Size(73, 16);
            this.lbl_Text5.TabIndex = 6;
            this.lbl_Text5.Text = "ADDRESS";
            // 
            // lbl_Text4
            // 
            this.lbl_Text4.AutoSize = true;
            this.lbl_Text4.Location = new System.Drawing.Point(23, 127);
            this.lbl_Text4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbl_Text4.Name = "lbl_Text4";
            this.lbl_Text4.Size = new System.Drawing.Size(116, 16);
            this.lbl_Text4.TabIndex = 5;
            this.lbl_Text4.Text = "COMPANY NAME";
            // 
            // lbl_Text3
            // 
            this.lbl_Text3.AutoSize = true;
            this.lbl_Text3.Location = new System.Drawing.Point(23, 100);
            this.lbl_Text3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbl_Text3.Name = "lbl_Text3";
            this.lbl_Text3.Size = new System.Drawing.Size(126, 16);
            this.lbl_Text3.TabIndex = 4;
            this.lbl_Text3.Text = "CUSTOMER NAME";
            // 
            // lbl_Text1
            // 
            this.lbl_Text1.AutoSize = true;
            this.lbl_Text1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Text1.Location = new System.Drawing.Point(23, 51);
            this.lbl_Text1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbl_Text1.Name = "lbl_Text1";
            this.lbl_Text1.Size = new System.Drawing.Size(128, 20);
            this.lbl_Text1.TabIndex = 3;
            this.lbl_Text1.Text = "CUSTOMER INFO";
            // 
            // pnl_TransTitleBar
            // 
            this.pnl_TransTitleBar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnl_TransTitleBar.Controls.Add(this.btn_TUpdate);
            this.pnl_TransTitleBar.Controls.Add(this.btn_CreateTrans);
            this.pnl_TransTitleBar.Controls.Add(this.btn_DeleteTrans);
            this.pnl_TransTitleBar.Controls.Add(this.btn_ClearTrans);
            this.pnl_TransTitleBar.Controls.Add(this.lbl_TransCode);
            this.pnl_TransTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TransTitleBar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pnl_TransTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_TransTitleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_TransTitleBar.Name = "pnl_TransTitleBar";
            this.pnl_TransTitleBar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_TransTitleBar.Size = new System.Drawing.Size(947, 30);
            this.pnl_TransTitleBar.TabIndex = 1;
            // 
            // btn_CreateTrans
            // 
            this.btn_CreateTrans.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_CreateTrans.Location = new System.Drawing.Point(662, 2);
            this.btn_CreateTrans.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btn_CreateTrans.Name = "btn_CreateTrans";
            this.btn_CreateTrans.Size = new System.Drawing.Size(94, 26);
            this.btn_CreateTrans.TabIndex = 17;
            this.btn_CreateTrans.Text = "Create";
            this.btn_CreateTrans.UseVisualStyleBackColor = true;
            this.btn_CreateTrans.Click += new System.EventHandler(this.btn_CreateTrans_Click);
            // 
            // btn_DeleteTrans
            // 
            this.btn_DeleteTrans.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_DeleteTrans.Location = new System.Drawing.Point(756, 2);
            this.btn_DeleteTrans.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btn_DeleteTrans.Name = "btn_DeleteTrans";
            this.btn_DeleteTrans.Size = new System.Drawing.Size(94, 26);
            this.btn_DeleteTrans.TabIndex = 16;
            this.btn_DeleteTrans.Text = "Delete";
            this.btn_DeleteTrans.UseVisualStyleBackColor = true;
            this.btn_DeleteTrans.Click += new System.EventHandler(this.btn_DeleteTrans_Click);
            // 
            // btn_ClearTrans
            // 
            this.btn_ClearTrans.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_ClearTrans.Location = new System.Drawing.Point(850, 2);
            this.btn_ClearTrans.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btn_ClearTrans.Name = "btn_ClearTrans";
            this.btn_ClearTrans.Size = new System.Drawing.Size(94, 26);
            this.btn_ClearTrans.TabIndex = 15;
            this.btn_ClearTrans.Text = "Clear";
            this.btn_ClearTrans.UseVisualStyleBackColor = true;
            this.btn_ClearTrans.Click += new System.EventHandler(this.btn_ClearTrans_Click);
            // 
            // lbl_TransCode
            // 
            this.lbl_TransCode.AutoSize = true;
            this.lbl_TransCode.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_TransCode.Location = new System.Drawing.Point(6, 2);
            this.lbl_TransCode.Name = "lbl_TransCode";
            this.lbl_TransCode.Size = new System.Drawing.Size(255, 25);
            this.lbl_TransCode.TabIndex = 2;
            this.lbl_TransCode.Text = "TRANSACTION CODE : TXXXX";
            // 
            // pnl_TransSideMenu
            // 
            this.pnl_TransSideMenu.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_TransSideMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_TransSideMenu.Controls.Add(this.pnl_Search);
            this.pnl_TransSideMenu.Controls.Add(this.dgv_TransList);
            this.pnl_TransSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_TransSideMenu.Location = new System.Drawing.Point(3, 2);
            this.pnl_TransSideMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_TransSideMenu.Name = "pnl_TransSideMenu";
            this.pnl_TransSideMenu.Size = new System.Drawing.Size(250, 548);
            this.pnl_TransSideMenu.TabIndex = 0;
            // 
            // pnl_Search
            // 
            this.pnl_Search.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnl_Search.Controls.Add(this.tb_TransSearch);
            this.pnl_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Search.Location = new System.Drawing.Point(0, 0);
            this.pnl_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(246, 30);
            this.pnl_Search.TabIndex = 1;
            // 
            // tb_TransSearch
            // 
            this.tb_TransSearch.Location = new System.Drawing.Point(5, 4);
            this.tb_TransSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TransSearch.Name = "tb_TransSearch";
            this.tb_TransSearch.Size = new System.Drawing.Size(235, 22);
            this.tb_TransSearch.TabIndex = 1;
            this.tb_TransSearch.TextChanged += new System.EventHandler(this.tb_TransSearch_TextChanged);
            // 
            // dgv_TransList
            // 
            this.dgv_TransList.AllowUserToAddRows = false;
            this.dgv_TransList.AllowUserToDeleteRows = false;
            this.dgv_TransList.AllowUserToResizeColumns = false;
            this.dgv_TransList.AllowUserToResizeRows = false;
            this.dgv_TransList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TransList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TransList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_TransList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TransList.Location = new System.Drawing.Point(0, 28);
            this.dgv_TransList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_TransList.Name = "dgv_TransList";
            this.dgv_TransList.ReadOnly = true;
            this.dgv_TransList.RowHeadersWidth = 51;
            this.dgv_TransList.RowTemplate.Height = 29;
            this.dgv_TransList.Size = new System.Drawing.Size(246, 516);
            this.dgv_TransList.TabIndex = 1;
            this.dgv_TransList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TransList_CellClick);
            // 
            // tb_DetailTrans
            // 
            this.tb_DetailTrans.Controls.Add(this.panel7);
            this.tb_DetailTrans.Controls.Add(this.panel4);
            this.tb_DetailTrans.Location = new System.Drawing.Point(4, 25);
            this.tb_DetailTrans.Name = "tb_DetailTrans";
            this.tb_DetailTrans.Padding = new System.Windows.Forms.Padding(3);
            this.tb_DetailTrans.Size = new System.Drawing.Size(1207, 552);
            this.tb_DetailTrans.TabIndex = 2;
            this.tb_DetailTrans.Text = "Detail Trans";
            this.tb_DetailTrans.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.nud_QtyTrans);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.btn_TSDelete);
            this.panel7.Controls.Add(this.dgv_TSList);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.btn_TSAdd);
            this.panel7.Controls.Add(this.cb_TransServiceID);
            this.panel7.Controls.Add(this.tb_TransServiceFee);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.tb_TransServiceName);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(253, 3);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(951, 546);
            this.panel7.TabIndex = 4;
            // 
            // nud_QtyTrans
            // 
            this.nud_QtyTrans.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_QtyTrans.Location = new System.Drawing.Point(174, 158);
            this.nud_QtyTrans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_QtyTrans.Name = "nud_QtyTrans";
            this.nud_QtyTrans.Size = new System.Drawing.Size(111, 25);
            this.nud_QtyTrans.TabIndex = 51;
            this.nud_QtyTrans.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel8.Controls.Add(this.label20);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Size = new System.Drawing.Size(947, 30);
            this.panel8.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(6, 2);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(141, 25);
            this.label20.TabIndex = 2;
            this.label20.Text = "TRANS SERVICE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 161);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 50;
            this.label9.Text = "QUANTITY";
            // 
            // btn_TSDelete
            // 
            this.btn_TSDelete.Location = new System.Drawing.Point(131, 201);
            this.btn_TSDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TSDelete.Name = "btn_TSDelete";
            this.btn_TSDelete.Size = new System.Drawing.Size(94, 23);
            this.btn_TSDelete.TabIndex = 48;
            this.btn_TSDelete.Text = "Delete";
            this.btn_TSDelete.UseVisualStyleBackColor = true;
            this.btn_TSDelete.Click += new System.EventHandler(this.btn_TSDelete_Click);
            // 
            // dgv_TSList
            // 
            this.dgv_TSList.AllowUserToAddRows = false;
            this.dgv_TSList.AllowUserToDeleteRows = false;
            this.dgv_TSList.AllowUserToResizeColumns = false;
            this.dgv_TSList.AllowUserToResizeRows = false;
            this.dgv_TSList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TSList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TSList.Location = new System.Drawing.Point(31, 228);
            this.dgv_TSList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_TSList.Name = "dgv_TSList";
            this.dgv_TSList.ReadOnly = true;
            this.dgv_TSList.RowHeadersWidth = 51;
            this.dgv_TSList.RowTemplate.Height = 29;
            this.dgv_TSList.Size = new System.Drawing.Size(894, 138);
            this.dgv_TSList.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(31, 54);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 20);
            this.label13.TabIndex = 40;
            this.label13.Text = "SERVICE DETAIL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 83);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 16);
            this.label12.TabIndex = 41;
            this.label12.Text = "SERVICE ID";
            // 
            // btn_TSAdd
            // 
            this.btn_TSAdd.Location = new System.Drawing.Point(31, 200);
            this.btn_TSAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TSAdd.Name = "btn_TSAdd";
            this.btn_TSAdd.Size = new System.Drawing.Size(94, 23);
            this.btn_TSAdd.TabIndex = 47;
            this.btn_TSAdd.Text = "Add";
            this.btn_TSAdd.UseVisualStyleBackColor = true;
            this.btn_TSAdd.Click += new System.EventHandler(this.btn_TSAdd_Click);
            // 
            // cb_TransServiceID
            // 
            this.cb_TransServiceID.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TransServiceID.FormattingEnabled = true;
            this.cb_TransServiceID.Location = new System.Drawing.Point(174, 80);
            this.cb_TransServiceID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_TransServiceID.Name = "cb_TransServiceID";
            this.cb_TransServiceID.Size = new System.Drawing.Size(111, 25);
            this.cb_TransServiceID.TabIndex = 42;
            this.cb_TransServiceID.TextChanged += new System.EventHandler(this.cb_TransServiceID_TextChanged);
            // 
            // tb_TransServiceFee
            // 
            this.tb_TransServiceFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_TransServiceFee.Location = new System.Drawing.Point(174, 132);
            this.tb_TransServiceFee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TransServiceFee.Name = "tb_TransServiceFee";
            this.tb_TransServiceFee.Size = new System.Drawing.Size(284, 22);
            this.tb_TransServiceFee.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 109);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 16);
            this.label11.TabIndex = 43;
            this.label11.Text = "SERVICE NAME";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 135);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 45;
            this.label10.Text = "SERVICE FEE";
            // 
            // tb_TransServiceName
            // 
            this.tb_TransServiceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_TransServiceName.Enabled = false;
            this.tb_TransServiceName.Location = new System.Drawing.Point(174, 106);
            this.tb_TransServiceName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TransServiceName.Name = "tb_TransServiceName";
            this.tb_TransServiceName.Size = new System.Drawing.Size(284, 22);
            this.tb_TransServiceName.TabIndex = 44;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.dgv_TransDTList);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 546);
            this.panel4.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel6.Controls.Add(this.tb_Search);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(246, 30);
            this.panel6.TabIndex = 1;
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(5, 4);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(235, 22);
            this.tb_Search.TabIndex = 1;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // dgv_TransDTList
            // 
            this.dgv_TransDTList.AllowUserToAddRows = false;
            this.dgv_TransDTList.AllowUserToDeleteRows = false;
            this.dgv_TransDTList.AllowUserToResizeColumns = false;
            this.dgv_TransDTList.AllowUserToResizeRows = false;
            this.dgv_TransDTList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TransDTList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TransDTList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_TransDTList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TransDTList.Location = new System.Drawing.Point(0, 28);
            this.dgv_TransDTList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_TransDTList.Name = "dgv_TransDTList";
            this.dgv_TransDTList.ReadOnly = true;
            this.dgv_TransDTList.RowHeadersWidth = 51;
            this.dgv_TransDTList.RowTemplate.Height = 29;
            this.dgv_TransDTList.Size = new System.Drawing.Size(246, 514);
            this.dgv_TransDTList.TabIndex = 1;
            this.dgv_TransDTList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TransDTList_CellClick);
            // 
            // tb_Schedule
            // 
            this.tb_Schedule.Controls.Add(this.panel3);
            this.tb_Schedule.Controls.Add(this.panel1);
            this.tb_Schedule.Location = new System.Drawing.Point(4, 25);
            this.tb_Schedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Schedule.Name = "tb_Schedule";
            this.tb_Schedule.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Schedule.Size = new System.Drawing.Size(1207, 552);
            this.tb_Schedule.TabIndex = 1;
            this.tb_Schedule.Text = "Schedule";
            this.tb_Schedule.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dgv_SchDetailServiceList);
            this.panel3.Controls.Add(this.cb_StaffScheduleList);
            this.panel3.Controls.Add(this.tb_SchStaffPosition);
            this.panel3.Controls.Add(this.tb_SchStaffName);
            this.panel3.Controls.Add(this.dtp_SEnd);
            this.panel3.Controls.Add(this.dtp_SStart);
            this.panel3.Controls.Add(this.tb_ScheduleID);
            this.panel3.Controls.Add(this.tb_TransScheduleID);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dgv_ScheduleList);
            this.panel3.Controls.Add(this.btn_SDelete);
            this.panel3.Controls.Add(this.btn_SAdd);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(253, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(951, 548);
            this.panel3.TabIndex = 3;
            // 
            // dgv_SchDetailServiceList
            // 
            this.dgv_SchDetailServiceList.AllowUserToAddRows = false;
            this.dgv_SchDetailServiceList.AllowUserToDeleteRows = false;
            this.dgv_SchDetailServiceList.AllowUserToResizeColumns = false;
            this.dgv_SchDetailServiceList.AllowUserToResizeRows = false;
            this.dgv_SchDetailServiceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SchDetailServiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SchDetailServiceList.Enabled = false;
            this.dgv_SchDetailServiceList.Location = new System.Drawing.Point(700, 226);
            this.dgv_SchDetailServiceList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_SchDetailServiceList.Name = "dgv_SchDetailServiceList";
            this.dgv_SchDetailServiceList.RowHeadersWidth = 51;
            this.dgv_SchDetailServiceList.RowTemplate.Height = 29;
            this.dgv_SchDetailServiceList.Size = new System.Drawing.Size(231, 127);
            this.dgv_SchDetailServiceList.TabIndex = 54;
            // 
            // cb_StaffScheduleList
            // 
            this.cb_StaffScheduleList.FormattingEnabled = true;
            this.cb_StaffScheduleList.Location = new System.Drawing.Point(614, 79);
            this.cb_StaffScheduleList.Name = "cb_StaffScheduleList";
            this.cb_StaffScheduleList.Size = new System.Drawing.Size(68, 24);
            this.cb_StaffScheduleList.TabIndex = 53;
            this.cb_StaffScheduleList.TextChanged += new System.EventHandler(this.cb_StaffScheduleList_TextChanged);
            // 
            // tb_SchStaffPosition
            // 
            this.tb_SchStaffPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_SchStaffPosition.Enabled = false;
            this.tb_SchStaffPosition.Location = new System.Drawing.Point(614, 131);
            this.tb_SchStaffPosition.Name = "tb_SchStaffPosition";
            this.tb_SchStaffPosition.Size = new System.Drawing.Size(166, 22);
            this.tb_SchStaffPosition.TabIndex = 52;
            // 
            // tb_SchStaffName
            // 
            this.tb_SchStaffName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_SchStaffName.Enabled = false;
            this.tb_SchStaffName.Location = new System.Drawing.Point(614, 105);
            this.tb_SchStaffName.Name = "tb_SchStaffName";
            this.tb_SchStaffName.Size = new System.Drawing.Size(166, 22);
            this.tb_SchStaffName.TabIndex = 49;
            // 
            // dtp_SEnd
            // 
            this.dtp_SEnd.CustomFormat = "yyyy-MM-dd HH:mm:00";
            this.dtp_SEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_SEnd.Location = new System.Drawing.Point(180, 161);
            this.dtp_SEnd.Name = "dtp_SEnd";
            this.dtp_SEnd.Size = new System.Drawing.Size(200, 22);
            this.dtp_SEnd.TabIndex = 48;
            // 
            // dtp_SStart
            // 
            this.dtp_SStart.CustomFormat = "yyyy-MM-dd HH:mm:00";
            this.dtp_SStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_SStart.Location = new System.Drawing.Point(180, 134);
            this.dtp_SStart.Name = "dtp_SStart";
            this.dtp_SStart.Size = new System.Drawing.Size(200, 22);
            this.dtp_SStart.TabIndex = 47;
            // 
            // tb_ScheduleID
            // 
            this.tb_ScheduleID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ScheduleID.Enabled = false;
            this.tb_ScheduleID.Location = new System.Drawing.Point(180, 108);
            this.tb_ScheduleID.Name = "tb_ScheduleID";
            this.tb_ScheduleID.Size = new System.Drawing.Size(100, 22);
            this.tb_ScheduleID.TabIndex = 46;
            // 
            // tb_TransScheduleID
            // 
            this.tb_TransScheduleID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_TransScheduleID.Enabled = false;
            this.tb_TransScheduleID.Location = new System.Drawing.Point(180, 81);
            this.tb_TransScheduleID.Name = "tb_TransScheduleID";
            this.tb_TransScheduleID.Size = new System.Drawing.Size(100, 22);
            this.tb_TransScheduleID.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "SCHEDULE END";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "SCHEDULE START";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(492, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "POSITION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "STAFF NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(491, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "STAFF DETAIL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "STAFF ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "SCHEDULE ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "TRANSACTION ID";
            // 
            // dgv_ScheduleList
            // 
            this.dgv_ScheduleList.AllowUserToAddRows = false;
            this.dgv_ScheduleList.AllowUserToDeleteRows = false;
            this.dgv_ScheduleList.AllowUserToResizeColumns = false;
            this.dgv_ScheduleList.AllowUserToResizeRows = false;
            this.dgv_ScheduleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ScheduleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ScheduleList.Location = new System.Drawing.Point(27, 226);
            this.dgv_ScheduleList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_ScheduleList.Name = "dgv_ScheduleList";
            this.dgv_ScheduleList.ReadOnly = true;
            this.dgv_ScheduleList.RowHeadersWidth = 51;
            this.dgv_ScheduleList.RowTemplate.Height = 29;
            this.dgv_ScheduleList.Size = new System.Drawing.Size(640, 127);
            this.dgv_ScheduleList.TabIndex = 36;
            // 
            // btn_SDelete
            // 
            this.btn_SDelete.Location = new System.Drawing.Point(127, 200);
            this.btn_SDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SDelete.Name = "btn_SDelete";
            this.btn_SDelete.Size = new System.Drawing.Size(94, 23);
            this.btn_SDelete.TabIndex = 34;
            this.btn_SDelete.Text = "Delete";
            this.btn_SDelete.UseVisualStyleBackColor = true;
            this.btn_SDelete.Click += new System.EventHandler(this.btn_SDelete_Click);
            // 
            // btn_SAdd
            // 
            this.btn_SAdd.Location = new System.Drawing.Point(27, 199);
            this.btn_SAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SAdd.Name = "btn_SAdd";
            this.btn_SAdd.Size = new System.Drawing.Size(94, 23);
            this.btn_SAdd.TabIndex = 33;
            this.btn_SAdd.Text = "Add";
            this.btn_SAdd.UseVisualStyleBackColor = true;
            this.btn_SAdd.Click += new System.EventHandler(this.btn_SAdd_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(23, 51);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 20);
            this.label17.TabIndex = 3;
            this.label17.Text = "SCHEDULE INFO";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel5.Controls.Add(this.label18);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Size = new System.Drawing.Size(947, 30);
            this.panel5.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(6, 2);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 25);
            this.label18.TabIndex = 2;
            this.label18.Text = "SCHEDULE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgv_TransScheduleList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 548);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.tb_SearchTransSchedule);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 30);
            this.panel2.TabIndex = 1;
            // 
            // tb_SearchTransSchedule
            // 
            this.tb_SearchTransSchedule.Location = new System.Drawing.Point(5, 4);
            this.tb_SearchTransSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_SearchTransSchedule.Name = "tb_SearchTransSchedule";
            this.tb_SearchTransSchedule.Size = new System.Drawing.Size(235, 22);
            this.tb_SearchTransSchedule.TabIndex = 1;
            this.tb_SearchTransSchedule.TextChanged += new System.EventHandler(this.tb_SearchTransSchedule_TextChanged);
            // 
            // dgv_TransScheduleList
            // 
            this.dgv_TransScheduleList.AllowUserToAddRows = false;
            this.dgv_TransScheduleList.AllowUserToDeleteRows = false;
            this.dgv_TransScheduleList.AllowUserToResizeColumns = false;
            this.dgv_TransScheduleList.AllowUserToResizeRows = false;
            this.dgv_TransScheduleList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TransScheduleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TransScheduleList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_TransScheduleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TransScheduleList.Location = new System.Drawing.Point(0, 28);
            this.dgv_TransScheduleList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_TransScheduleList.Name = "dgv_TransScheduleList";
            this.dgv_TransScheduleList.ReadOnly = true;
            this.dgv_TransScheduleList.RowHeadersWidth = 51;
            this.dgv_TransScheduleList.RowTemplate.Height = 29;
            this.dgv_TransScheduleList.Size = new System.Drawing.Size(246, 516);
            this.dgv_TransScheduleList.TabIndex = 1;
            this.dgv_TransScheduleList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TransScheduleList_CellClick);
            // 
            // tb_Payment
            // 
            this.tb_Payment.Controls.Add(this.cb_PPaymentType);
            this.tb_Payment.Controls.Add(this.label47);
            this.tb_Payment.Controls.Add(this.tb_PPaymentID);
            this.tb_Payment.Controls.Add(this.label46);
            this.tb_Payment.Controls.Add(this.tb_PPaymentAmount);
            this.tb_Payment.Controls.Add(this.label45);
            this.tb_Payment.Controls.Add(this.dtp_PaymentDate);
            this.tb_Payment.Controls.Add(this.label44);
            this.tb_Payment.Controls.Add(this.label43);
            this.tb_Payment.Controls.Add(this.btn_PDelete);
            this.tb_Payment.Controls.Add(this.dgv_Payment);
            this.tb_Payment.Controls.Add(this.btn_PAdd);
            this.tb_Payment.Controls.Add(this.tb_PTransactionID);
            this.tb_Payment.Controls.Add(this.label42);
            this.tb_Payment.Controls.Add(this.panel19);
            this.tb_Payment.Controls.Add(this.tb_PDesc);
            this.tb_Payment.Controls.Add(this.label35);
            this.tb_Payment.Controls.Add(this.tb_PAddFee);
            this.tb_Payment.Controls.Add(this.label36);
            this.tb_Payment.Controls.Add(this.tb_PTransTotal);
            this.tb_Payment.Controls.Add(this.label37);
            this.tb_Payment.Controls.Add(this.dtp_PDueDate);
            this.tb_Payment.Controls.Add(this.label38);
            this.tb_Payment.Controls.Add(this.dtp_PDate);
            this.tb_Payment.Controls.Add(this.label39);
            this.tb_Payment.Controls.Add(this.label40);
            this.tb_Payment.Controls.Add(this.panel17);
            this.tb_Payment.Location = new System.Drawing.Point(4, 25);
            this.tb_Payment.Name = "tb_Payment";
            this.tb_Payment.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Payment.Size = new System.Drawing.Size(1207, 552);
            this.tb_Payment.TabIndex = 6;
            this.tb_Payment.Text = "Payment";
            this.tb_Payment.UseVisualStyleBackColor = true;
            // 
            // cb_PPaymentType
            // 
            this.cb_PPaymentType.FormattingEnabled = true;
            this.cb_PPaymentType.Items.AddRange(new object[] {
            "DOWN PAYMENT",
            "FINAL PAYMENT"});
            this.cb_PPaymentType.Location = new System.Drawing.Point(432, 366);
            this.cb_PPaymentType.Name = "cb_PPaymentType";
            this.cb_PPaymentType.Size = new System.Drawing.Size(284, 24);
            this.cb_PPaymentType.TabIndex = 61;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(290, 369);
            this.label47.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(112, 16);
            this.label47.TabIndex = 60;
            this.label47.Text = "PAYMENT TYPE";
            // 
            // tb_PPaymentID
            // 
            this.tb_PPaymentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_PPaymentID.Enabled = false;
            this.tb_PPaymentID.Location = new System.Drawing.Point(432, 291);
            this.tb_PPaymentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_PPaymentID.Name = "tb_PPaymentID";
            this.tb_PPaymentID.Size = new System.Drawing.Size(284, 22);
            this.tb_PPaymentID.TabIndex = 59;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(289, 293);
            this.label46.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(89, 16);
            this.label46.TabIndex = 58;
            this.label46.Text = "PAYMENT ID";
            // 
            // tb_PPaymentAmount
            // 
            this.tb_PPaymentAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_PPaymentAmount.Location = new System.Drawing.Point(432, 341);
            this.tb_PPaymentAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_PPaymentAmount.Name = "tb_PPaymentAmount";
            this.tb_PPaymentAmount.Size = new System.Drawing.Size(284, 22);
            this.tb_PPaymentAmount.TabIndex = 57;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(290, 343);
            this.label45.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(66, 16);
            this.label45.TabIndex = 56;
            this.label45.Text = "AMOUNT";
            // 
            // dtp_PaymentDate
            // 
            this.dtp_PaymentDate.CalendarFont = new System.Drawing.Font("Segoe UI", 7.8F);
            this.dtp_PaymentDate.CustomFormat = "yyyy-MM-dd";
            this.dtp_PaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_PaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_PaymentDate.Location = new System.Drawing.Point(433, 315);
            this.dtp_PaymentDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_PaymentDate.Name = "dtp_PaymentDate";
            this.dtp_PaymentDate.Size = new System.Drawing.Size(284, 22);
            this.dtp_PaymentDate.TabIndex = 55;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(290, 319);
            this.label44.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(44, 16);
            this.label44.TabIndex = 54;
            this.label44.Text = "DATE";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label43.Location = new System.Drawing.Point(289, 260);
            this.label43.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(79, 20);
            this.label43.TabIndex = 53;
            this.label43.Text = "PAYMENT";
            // 
            // btn_PDelete
            // 
            this.btn_PDelete.Location = new System.Drawing.Point(393, 401);
            this.btn_PDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_PDelete.Name = "btn_PDelete";
            this.btn_PDelete.Size = new System.Drawing.Size(94, 23);
            this.btn_PDelete.TabIndex = 51;
            this.btn_PDelete.Text = "Delete";
            this.btn_PDelete.UseVisualStyleBackColor = true;
            this.btn_PDelete.Click += new System.EventHandler(this.btn_PDelete_Click);
            // 
            // dgv_Payment
            // 
            this.dgv_Payment.AllowUserToAddRows = false;
            this.dgv_Payment.AllowUserToDeleteRows = false;
            this.dgv_Payment.AllowUserToResizeColumns = false;
            this.dgv_Payment.AllowUserToResizeRows = false;
            this.dgv_Payment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Payment.Location = new System.Drawing.Point(293, 428);
            this.dgv_Payment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Payment.Name = "dgv_Payment";
            this.dgv_Payment.ReadOnly = true;
            this.dgv_Payment.RowHeadersWidth = 51;
            this.dgv_Payment.RowTemplate.Height = 29;
            this.dgv_Payment.Size = new System.Drawing.Size(894, 138);
            this.dgv_Payment.TabIndex = 52;
            // 
            // btn_PAdd
            // 
            this.btn_PAdd.Location = new System.Drawing.Point(293, 400);
            this.btn_PAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_PAdd.Name = "btn_PAdd";
            this.btn_PAdd.Size = new System.Drawing.Size(94, 23);
            this.btn_PAdd.TabIndex = 50;
            this.btn_PAdd.Text = "Add";
            this.btn_PAdd.UseVisualStyleBackColor = true;
            this.btn_PAdd.Click += new System.EventHandler(this.btn_PAdd_Click);
            // 
            // tb_PTransactionID
            // 
            this.tb_PTransactionID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_PTransactionID.Enabled = false;
            this.tb_PTransactionID.Location = new System.Drawing.Point(432, 86);
            this.tb_PTransactionID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_PTransactionID.Name = "tb_PTransactionID";
            this.tb_PTransactionID.Size = new System.Drawing.Size(284, 22);
            this.tb_PTransactionID.TabIndex = 39;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(290, 90);
            this.label42.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(120, 16);
            this.label42.TabIndex = 38;
            this.label42.Text = "TRANSACTION ID";
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel19.Controls.Add(this.label41);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel19.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel19.Location = new System.Drawing.Point(253, 3);
            this.panel19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel19.Name = "panel19";
            this.panel19.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel19.Size = new System.Drawing.Size(951, 30);
            this.panel19.TabIndex = 37;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label41.Location = new System.Drawing.Point(6, 2);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(93, 25);
            this.label41.TabIndex = 2;
            this.label41.Text = "PAYMENT";
            // 
            // tb_PDesc
            // 
            this.tb_PDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_PDesc.Enabled = false;
            this.tb_PDesc.Location = new System.Drawing.Point(433, 214);
            this.tb_PDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_PDesc.Name = "tb_PDesc";
            this.tb_PDesc.Size = new System.Drawing.Size(284, 22);
            this.tb_PDesc.TabIndex = 36;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(290, 218);
            this.label35.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(98, 16);
            this.label35.TabIndex = 35;
            this.label35.Text = "DESCRIPTION";
            // 
            // tb_PAddFee
            // 
            this.tb_PAddFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_PAddFee.Enabled = false;
            this.tb_PAddFee.Location = new System.Drawing.Point(433, 188);
            this.tb_PAddFee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_PAddFee.Name = "tb_PAddFee";
            this.tb_PAddFee.Size = new System.Drawing.Size(284, 22);
            this.tb_PAddFee.TabIndex = 34;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(290, 191);
            this.label36.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(116, 16);
            this.label36.TabIndex = 33;
            this.label36.Text = "ADDITIONAL FEE";
            // 
            // tb_PTransTotal
            // 
            this.tb_PTransTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_PTransTotal.Enabled = false;
            this.tb_PTransTotal.Location = new System.Drawing.Point(433, 162);
            this.tb_PTransTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_PTransTotal.Name = "tb_PTransTotal";
            this.tb_PTransTotal.Size = new System.Drawing.Size(284, 22);
            this.tb_PTransTotal.TabIndex = 32;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(290, 164);
            this.label37.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(79, 16);
            this.label37.TabIndex = 31;
            this.label37.Text = "SUBTOTAL";
            // 
            // dtp_PDueDate
            // 
            this.dtp_PDueDate.CalendarFont = new System.Drawing.Font("Segoe UI", 7.8F);
            this.dtp_PDueDate.CustomFormat = "yyyy-MM-dd";
            this.dtp_PDueDate.Enabled = false;
            this.dtp_PDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_PDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_PDueDate.Location = new System.Drawing.Point(433, 136);
            this.dtp_PDueDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_PDueDate.Name = "dtp_PDueDate";
            this.dtp_PDueDate.Size = new System.Drawing.Size(284, 22);
            this.dtp_PDueDate.TabIndex = 30;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(290, 140);
            this.label38.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(73, 16);
            this.label38.TabIndex = 29;
            this.label38.Text = "DUEDATE";
            // 
            // dtp_PDate
            // 
            this.dtp_PDate.CalendarFont = new System.Drawing.Font("Segoe UI", 7.8F);
            this.dtp_PDate.CustomFormat = "yyyy-MM-dd";
            this.dtp_PDate.Enabled = false;
            this.dtp_PDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_PDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_PDate.Location = new System.Drawing.Point(433, 110);
            this.dtp_PDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_PDate.Name = "dtp_PDate";
            this.dtp_PDate.Size = new System.Drawing.Size(284, 22);
            this.dtp_PDate.TabIndex = 28;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(290, 114);
            this.label39.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(44, 16);
            this.label39.TabIndex = 27;
            this.label39.Text = "DATE";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label40.Location = new System.Drawing.Point(289, 58);
            this.label40.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(171, 20);
            this.label40.TabIndex = 26;
            this.label40.Text = "DETAIL TRANSACTION";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.SystemColors.Control;
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel17.Controls.Add(this.panel18);
            this.panel17.Controls.Add(this.dgv_PTransID);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel17.Location = new System.Drawing.Point(3, 3);
            this.panel17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(250, 546);
            this.panel17.TabIndex = 2;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel18.Controls.Add(this.tb_PTransID);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(0, 0);
            this.panel18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(246, 30);
            this.panel18.TabIndex = 1;
            // 
            // tb_PTransID
            // 
            this.tb_PTransID.Location = new System.Drawing.Point(5, 4);
            this.tb_PTransID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_PTransID.Name = "tb_PTransID";
            this.tb_PTransID.Size = new System.Drawing.Size(235, 22);
            this.tb_PTransID.TabIndex = 1;
            this.tb_PTransID.TextChanged += new System.EventHandler(this.tb_PTransID_TextChanged);
            // 
            // dgv_PTransID
            // 
            this.dgv_PTransID.AllowUserToAddRows = false;
            this.dgv_PTransID.AllowUserToDeleteRows = false;
            this.dgv_PTransID.AllowUserToResizeColumns = false;
            this.dgv_PTransID.AllowUserToResizeRows = false;
            this.dgv_PTransID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_PTransID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PTransID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_PTransID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PTransID.Location = new System.Drawing.Point(0, 28);
            this.dgv_PTransID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_PTransID.Name = "dgv_PTransID";
            this.dgv_PTransID.ReadOnly = true;
            this.dgv_PTransID.RowHeadersWidth = 51;
            this.dgv_PTransID.RowTemplate.Height = 29;
            this.dgv_PTransID.Size = new System.Drawing.Size(246, 514);
            this.dgv_PTransID.TabIndex = 1;
            this.dgv_PTransID.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PTransID_CellClick);
            // 
            // tb_Customer
            // 
            this.tb_Customer.Controls.Add(this.panel13);
            this.tb_Customer.Controls.Add(this.panel9);
            this.tb_Customer.Location = new System.Drawing.Point(4, 25);
            this.tb_Customer.Name = "tb_Customer";
            this.tb_Customer.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Customer.Size = new System.Drawing.Size(1207, 552);
            this.tb_Customer.TabIndex = 3;
            this.tb_Customer.Text = "Customer";
            this.tb_Customer.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.AutoScroll = true;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel13.Controls.Add(this.tb_CCustID);
            this.panel13.Controls.Add(this.label14);
            this.panel13.Controls.Add(this.dgv_CCust);
            this.panel13.Controls.Add(this.label28);
            this.panel13.Controls.Add(this.tb_CPhone);
            this.panel13.Controls.Add(this.tb_CAddress);
            this.panel13.Controls.Add(this.tb_CCompany);
            this.panel13.Controls.Add(this.tb_CCustName);
            this.panel13.Controls.Add(this.label29);
            this.panel13.Controls.Add(this.label30);
            this.panel13.Controls.Add(this.label31);
            this.panel13.Controls.Add(this.label32);
            this.panel13.Controls.Add(this.label33);
            this.panel13.Controls.Add(this.panel15);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(253, 3);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(951, 546);
            this.panel13.TabIndex = 3;
            // 
            // tb_CCustID
            // 
            this.tb_CCustID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_CCustID.Enabled = false;
            this.tb_CCustID.Location = new System.Drawing.Point(166, 79);
            this.tb_CCustID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_CCustID.Name = "tb_CCustID";
            this.tb_CCustID.Size = new System.Drawing.Size(284, 22);
            this.tb_CCustID.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(23, 229);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "TRANSACTION";
            // 
            // dgv_CCust
            // 
            this.dgv_CCust.AllowUserToAddRows = false;
            this.dgv_CCust.AllowUserToDeleteRows = false;
            this.dgv_CCust.AllowUserToResizeColumns = false;
            this.dgv_CCust.AllowUserToResizeRows = false;
            this.dgv_CCust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CCust.Location = new System.Drawing.Point(26, 255);
            this.dgv_CCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_CCust.Name = "dgv_CCust";
            this.dgv_CCust.RowHeadersWidth = 51;
            this.dgv_CCust.RowTemplate.Height = 29;
            this.dgv_CCust.Size = new System.Drawing.Size(900, 158);
            this.dgv_CCust.TabIndex = 36;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(23, 81);
            this.label28.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(100, 16);
            this.label28.TabIndex = 12;
            this.label28.Text = "CUSTOMER ID";
            // 
            // tb_CPhone
            // 
            this.tb_CPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_CPhone.Location = new System.Drawing.Point(166, 183);
            this.tb_CPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_CPhone.Name = "tb_CPhone";
            this.tb_CPhone.Size = new System.Drawing.Size(284, 22);
            this.tb_CPhone.TabIndex = 11;
            // 
            // tb_CAddress
            // 
            this.tb_CAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_CAddress.Location = new System.Drawing.Point(166, 157);
            this.tb_CAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_CAddress.Name = "tb_CAddress";
            this.tb_CAddress.Size = new System.Drawing.Size(284, 22);
            this.tb_CAddress.TabIndex = 10;
            // 
            // tb_CCompany
            // 
            this.tb_CCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_CCompany.Location = new System.Drawing.Point(166, 131);
            this.tb_CCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_CCompany.Name = "tb_CCompany";
            this.tb_CCompany.Size = new System.Drawing.Size(284, 22);
            this.tb_CCompany.TabIndex = 9;
            // 
            // tb_CCustName
            // 
            this.tb_CCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_CCustName.Location = new System.Drawing.Point(166, 105);
            this.tb_CCustName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_CCustName.Name = "tb_CCustName";
            this.tb_CCustName.Size = new System.Drawing.Size(284, 22);
            this.tb_CCustName.TabIndex = 8;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(23, 185);
            this.label29.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(117, 16);
            this.label29.TabIndex = 7;
            this.label29.Text = "PHONE NUMBER";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(23, 159);
            this.label30.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(73, 16);
            this.label30.TabIndex = 6;
            this.label30.Text = "ADDRESS";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(23, 134);
            this.label31.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(116, 16);
            this.label31.TabIndex = 5;
            this.label31.Text = "COMPANY NAME";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(23, 107);
            this.label32.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(126, 16);
            this.label32.TabIndex = 4;
            this.label32.Text = "CUSTOMER NAME";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label33.Location = new System.Drawing.Point(23, 51);
            this.label33.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(128, 20);
            this.label33.TabIndex = 3;
            this.label33.Text = "CUSTOMER INFO";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel15.Controls.Add(this.btn_CUpdate);
            this.panel15.Controls.Add(this.btn_CCreate);
            this.panel15.Controls.Add(this.btn_CDelete);
            this.panel15.Controls.Add(this.btn_CClear);
            this.panel15.Controls.Add(this.label34);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel15.Size = new System.Drawing.Size(947, 30);
            this.panel15.TabIndex = 1;
            // 
            // btn_CUpdate
            // 
            this.btn_CUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_CUpdate.Enabled = false;
            this.btn_CUpdate.Location = new System.Drawing.Point(568, 2);
            this.btn_CUpdate.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btn_CUpdate.Name = "btn_CUpdate";
            this.btn_CUpdate.Size = new System.Drawing.Size(94, 26);
            this.btn_CUpdate.TabIndex = 18;
            this.btn_CUpdate.Text = "Update";
            this.btn_CUpdate.UseVisualStyleBackColor = true;
            this.btn_CUpdate.Click += new System.EventHandler(this.btn_CUpdate_Click);
            // 
            // btn_CCreate
            // 
            this.btn_CCreate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_CCreate.Location = new System.Drawing.Point(662, 2);
            this.btn_CCreate.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btn_CCreate.Name = "btn_CCreate";
            this.btn_CCreate.Size = new System.Drawing.Size(94, 26);
            this.btn_CCreate.TabIndex = 17;
            this.btn_CCreate.Text = "Create";
            this.btn_CCreate.UseVisualStyleBackColor = true;
            this.btn_CCreate.Click += new System.EventHandler(this.btn_CCreate_Click);
            // 
            // btn_CDelete
            // 
            this.btn_CDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_CDelete.Enabled = false;
            this.btn_CDelete.Location = new System.Drawing.Point(756, 2);
            this.btn_CDelete.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btn_CDelete.Name = "btn_CDelete";
            this.btn_CDelete.Size = new System.Drawing.Size(94, 26);
            this.btn_CDelete.TabIndex = 16;
            this.btn_CDelete.Text = "Delete";
            this.btn_CDelete.UseVisualStyleBackColor = true;
            this.btn_CDelete.Click += new System.EventHandler(this.btn_CDelete_Click);
            // 
            // btn_CClear
            // 
            this.btn_CClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_CClear.Location = new System.Drawing.Point(850, 2);
            this.btn_CClear.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btn_CClear.Name = "btn_CClear";
            this.btn_CClear.Size = new System.Drawing.Size(94, 26);
            this.btn_CClear.TabIndex = 15;
            this.btn_CClear.Text = "Clear";
            this.btn_CClear.UseVisualStyleBackColor = true;
            this.btn_CClear.Click += new System.EventHandler(this.btn_CClear_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label34.Location = new System.Drawing.Point(6, 2);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(153, 25);
            this.label34.TabIndex = 2;
            this.label34.Text = "CUSTOMER INFO";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Control;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.dgv_Cust);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(250, 546);
            this.panel9.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel10.Controls.Add(this.tb_SearchCust);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(246, 30);
            this.panel10.TabIndex = 1;
            // 
            // tb_SearchCust
            // 
            this.tb_SearchCust.Location = new System.Drawing.Point(5, 4);
            this.tb_SearchCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_SearchCust.Name = "tb_SearchCust";
            this.tb_SearchCust.Size = new System.Drawing.Size(235, 22);
            this.tb_SearchCust.TabIndex = 1;
            this.tb_SearchCust.TextChanged += new System.EventHandler(this.tb_SearchCust_TextChanged);
            // 
            // dgv_Cust
            // 
            this.dgv_Cust.AllowUserToAddRows = false;
            this.dgv_Cust.AllowUserToDeleteRows = false;
            this.dgv_Cust.AllowUserToResizeColumns = false;
            this.dgv_Cust.AllowUserToResizeRows = false;
            this.dgv_Cust.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Cust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Cust.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cust.Location = new System.Drawing.Point(0, 28);
            this.dgv_Cust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Cust.Name = "dgv_Cust";
            this.dgv_Cust.ReadOnly = true;
            this.dgv_Cust.RowHeadersWidth = 51;
            this.dgv_Cust.RowTemplate.Height = 29;
            this.dgv_Cust.Size = new System.Drawing.Size(246, 514);
            this.dgv_Cust.TabIndex = 1;
            this.dgv_Cust.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Cust_CellClick);
            // 
            // tb_Staff
            // 
            this.tb_Staff.Controls.Add(this.panel14);
            this.tb_Staff.Controls.Add(this.panel11);
            this.tb_Staff.Location = new System.Drawing.Point(4, 25);
            this.tb_Staff.Name = "tb_Staff";
            this.tb_Staff.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Staff.Size = new System.Drawing.Size(1207, 552);
            this.tb_Staff.TabIndex = 4;
            this.tb_Staff.Text = "Staff";
            this.tb_Staff.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            this.panel14.AutoScroll = true;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel14.Controls.Add(this.tb_SPassword);
            this.panel14.Controls.Add(this.label27);
            this.panel14.Controls.Add(this.tb_SAddress);
            this.panel14.Controls.Add(this.label26);
            this.panel14.Controls.Add(this.tb_SStaffID);
            this.panel14.Controls.Add(this.label15);
            this.panel14.Controls.Add(this.dgv_SStaff);
            this.panel14.Controls.Add(this.label16);
            this.panel14.Controls.Add(this.tb_SPhone);
            this.panel14.Controls.Add(this.tb_SEmail);
            this.panel14.Controls.Add(this.tb_SPosition);
            this.panel14.Controls.Add(this.tb_SName);
            this.panel14.Controls.Add(this.label19);
            this.panel14.Controls.Add(this.label21);
            this.panel14.Controls.Add(this.label22);
            this.panel14.Controls.Add(this.label23);
            this.panel14.Controls.Add(this.label24);
            this.panel14.Controls.Add(this.panel16);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(253, 3);
            this.panel14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(951, 546);
            this.panel14.TabIndex = 4;
            // 
            // tb_SPassword
            // 
            this.tb_SPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_SPassword.Location = new System.Drawing.Point(166, 235);
            this.tb_SPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_SPassword.Name = "tb_SPassword";
            this.tb_SPassword.Size = new System.Drawing.Size(284, 22);
            this.tb_SPassword.TabIndex = 13;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(23, 237);
            this.label27.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(132, 16);
            this.label27.TabIndex = 41;
            this.label27.Text = "STAFF PASSWORD";
            // 
            // tb_SAddress
            // 
            this.tb_SAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_SAddress.Location = new System.Drawing.Point(166, 209);
            this.tb_SAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_SAddress.Name = "tb_SAddress";
            this.tb_SAddress.Size = new System.Drawing.Size(284, 22);
            this.tb_SAddress.TabIndex = 12;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(23, 211);
            this.label26.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(119, 16);
            this.label26.TabIndex = 39;
            this.label26.Text = "STAFF ADDRESS";
            // 
            // tb_SStaffID
            // 
            this.tb_SStaffID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_SStaffID.Enabled = false;
            this.tb_SStaffID.Location = new System.Drawing.Point(166, 79);
            this.tb_SStaffID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_SStaffID.Name = "tb_SStaffID";
            this.tb_SStaffID.Size = new System.Drawing.Size(284, 22);
            this.tb_SStaffID.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(23, 281);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(232, 20);
            this.label15.TabIndex = 37;
            this.label15.Text = "TRANSACTION AND SCHEDULE";
            // 
            // dgv_SStaff
            // 
            this.dgv_SStaff.AllowUserToAddRows = false;
            this.dgv_SStaff.AllowUserToDeleteRows = false;
            this.dgv_SStaff.AllowUserToResizeColumns = false;
            this.dgv_SStaff.AllowUserToResizeRows = false;
            this.dgv_SStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SStaff.Location = new System.Drawing.Point(26, 307);
            this.dgv_SStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_SStaff.Name = "dgv_SStaff";
            this.dgv_SStaff.RowHeadersWidth = 51;
            this.dgv_SStaff.RowTemplate.Height = 29;
            this.dgv_SStaff.Size = new System.Drawing.Size(900, 158);
            this.dgv_SStaff.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 81);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 16);
            this.label16.TabIndex = 12;
            this.label16.Text = "STAFF ID";
            // 
            // tb_SPhone
            // 
            this.tb_SPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_SPhone.Location = new System.Drawing.Point(166, 183);
            this.tb_SPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_SPhone.Name = "tb_SPhone";
            this.tb_SPhone.Size = new System.Drawing.Size(284, 22);
            this.tb_SPhone.TabIndex = 11;
            // 
            // tb_SEmail
            // 
            this.tb_SEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_SEmail.Location = new System.Drawing.Point(166, 157);
            this.tb_SEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_SEmail.Name = "tb_SEmail";
            this.tb_SEmail.Size = new System.Drawing.Size(284, 22);
            this.tb_SEmail.TabIndex = 10;
            // 
            // tb_SPosition
            // 
            this.tb_SPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_SPosition.Location = new System.Drawing.Point(166, 131);
            this.tb_SPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_SPosition.Name = "tb_SPosition";
            this.tb_SPosition.Size = new System.Drawing.Size(284, 22);
            this.tb_SPosition.TabIndex = 9;
            // 
            // tb_SName
            // 
            this.tb_SName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_SName.Location = new System.Drawing.Point(166, 105);
            this.tb_SName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_SName.Name = "tb_SName";
            this.tb_SName.Size = new System.Drawing.Size(284, 22);
            this.tb_SName.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 185);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 16);
            this.label19.TabIndex = 7;
            this.label19.Text = "STAFF PHONE";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(23, 159);
            this.label21.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(92, 16);
            this.label21.TabIndex = 6;
            this.label21.Text = "STAFF EMAIL";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(23, 134);
            this.label22.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(116, 16);
            this.label22.TabIndex = 5;
            this.label22.Text = "STAFF POSITION";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(23, 107);
            this.label23.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(92, 16);
            this.label23.TabIndex = 4;
            this.label23.Text = "STAFF NAME";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label24.Location = new System.Drawing.Point(23, 51);
            this.label24.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(92, 20);
            this.label24.TabIndex = 3;
            this.label24.Text = "STAFF INFO";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel16.Controls.Add(this.btn_SUpdate);
            this.panel16.Controls.Add(this.btn_SCreate);
            this.panel16.Controls.Add(this.btn_SDel);
            this.panel16.Controls.Add(this.btn_SClear);
            this.panel16.Controls.Add(this.label25);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel16.Name = "panel16";
            this.panel16.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel16.Size = new System.Drawing.Size(947, 30);
            this.panel16.TabIndex = 1;
            // 
            // btn_SUpdate
            // 
            this.btn_SUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_SUpdate.Location = new System.Drawing.Point(568, 2);
            this.btn_SUpdate.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btn_SUpdate.Name = "btn_SUpdate";
            this.btn_SUpdate.Size = new System.Drawing.Size(94, 26);
            this.btn_SUpdate.TabIndex = 19;
            this.btn_SUpdate.Text = "Update";
            this.btn_SUpdate.UseVisualStyleBackColor = true;
            this.btn_SUpdate.Click += new System.EventHandler(this.btn_SUpdate_Click);
            // 
            // btn_SCreate
            // 
            this.btn_SCreate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_SCreate.Location = new System.Drawing.Point(662, 2);
            this.btn_SCreate.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btn_SCreate.Name = "btn_SCreate";
            this.btn_SCreate.Size = new System.Drawing.Size(94, 26);
            this.btn_SCreate.TabIndex = 17;
            this.btn_SCreate.Text = "Create";
            this.btn_SCreate.UseVisualStyleBackColor = true;
            this.btn_SCreate.Click += new System.EventHandler(this.btn_SCreate_Click);
            // 
            // btn_SDel
            // 
            this.btn_SDel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_SDel.Location = new System.Drawing.Point(756, 2);
            this.btn_SDel.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btn_SDel.Name = "btn_SDel";
            this.btn_SDel.Size = new System.Drawing.Size(94, 26);
            this.btn_SDel.TabIndex = 16;
            this.btn_SDel.Text = "Delete";
            this.btn_SDel.UseVisualStyleBackColor = true;
            this.btn_SDel.Click += new System.EventHandler(this.btn_SDel_Click);
            // 
            // btn_SClear
            // 
            this.btn_SClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_SClear.Location = new System.Drawing.Point(850, 2);
            this.btn_SClear.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btn_SClear.Name = "btn_SClear";
            this.btn_SClear.Size = new System.Drawing.Size(94, 26);
            this.btn_SClear.TabIndex = 15;
            this.btn_SClear.Text = "Clear";
            this.btn_SClear.UseVisualStyleBackColor = true;
            this.btn_SClear.Click += new System.EventHandler(this.btn_SClear_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(6, 2);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(108, 25);
            this.label25.TabIndex = 2;
            this.label25.Text = "STAFF INFO";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.Control;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.dgv_Staff);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(3, 3);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(250, 546);
            this.panel11.TabIndex = 2;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel12.Controls.Add(this.tb_StaffID);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(246, 30);
            this.panel12.TabIndex = 1;
            // 
            // tb_StaffID
            // 
            this.tb_StaffID.Location = new System.Drawing.Point(5, 4);
            this.tb_StaffID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_StaffID.Name = "tb_StaffID";
            this.tb_StaffID.Size = new System.Drawing.Size(235, 22);
            this.tb_StaffID.TabIndex = 1;
            this.tb_StaffID.TextChanged += new System.EventHandler(this.tb_StaffID_TextChanged);
            // 
            // dgv_Staff
            // 
            this.dgv_Staff.AllowUserToAddRows = false;
            this.dgv_Staff.AllowUserToDeleteRows = false;
            this.dgv_Staff.AllowUserToResizeColumns = false;
            this.dgv_Staff.AllowUserToResizeRows = false;
            this.dgv_Staff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Staff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Staff.Location = new System.Drawing.Point(0, 28);
            this.dgv_Staff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Staff.Name = "dgv_Staff";
            this.dgv_Staff.ReadOnly = true;
            this.dgv_Staff.RowHeadersWidth = 51;
            this.dgv_Staff.RowTemplate.Height = 29;
            this.dgv_Staff.Size = new System.Drawing.Size(246, 514);
            this.dgv_Staff.TabIndex = 1;
            this.dgv_Staff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Staff_CellClick);
            // 
            // tb_View
            // 
            this.tb_View.Controls.Add(this.dgv_View);
            this.tb_View.Controls.Add(this.ms_ViewMenu);
            this.tb_View.Location = new System.Drawing.Point(4, 25);
            this.tb_View.Name = "tb_View";
            this.tb_View.Padding = new System.Windows.Forms.Padding(3);
            this.tb_View.Size = new System.Drawing.Size(1207, 552);
            this.tb_View.TabIndex = 5;
            this.tb_View.Text = "View";
            this.tb_View.UseVisualStyleBackColor = true;
            // 
            // dgv_View
            // 
            this.dgv_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_View.Location = new System.Drawing.Point(169, 3);
            this.dgv_View.Name = "dgv_View";
            this.dgv_View.ReadOnly = true;
            this.dgv_View.RowHeadersWidth = 51;
            this.dgv_View.RowTemplate.Height = 24;
            this.dgv_View.Size = new System.Drawing.Size(1035, 546);
            this.dgv_View.TabIndex = 1;
            // 
            // ms_ViewMenu
            // 
            this.ms_ViewMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.ms_ViewMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_ViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleToolStripMenuItem,
            this.ongoingTransactionToolStripMenuItem,
            this.lateTransactionToolStripMenuItem,
            this.doneTransactionToolStripMenuItem,
            this.revenueToolStripMenuItem});
            this.ms_ViewMenu.Location = new System.Drawing.Point(3, 3);
            this.ms_ViewMenu.Name = "ms_ViewMenu";
            this.ms_ViewMenu.Size = new System.Drawing.Size(166, 546);
            this.ms_ViewMenu.TabIndex = 2;
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.scheduleToolStripMenuItem.Text = "Schedule";
            this.scheduleToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scheduleToolStripMenuItem.Click += new System.EventHandler(this.scheduleToolStripMenuItem_Click);
            // 
            // ongoingTransactionToolStripMenuItem
            // 
            this.ongoingTransactionToolStripMenuItem.Name = "ongoingTransactionToolStripMenuItem";
            this.ongoingTransactionToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.ongoingTransactionToolStripMenuItem.Text = "Ongoing Transaction";
            this.ongoingTransactionToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ongoingTransactionToolStripMenuItem.Click += new System.EventHandler(this.ongoingTransactionToolStripMenuItem_Click);
            // 
            // lateTransactionToolStripMenuItem
            // 
            this.lateTransactionToolStripMenuItem.Name = "lateTransactionToolStripMenuItem";
            this.lateTransactionToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.lateTransactionToolStripMenuItem.Text = "Late Transaction";
            this.lateTransactionToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lateTransactionToolStripMenuItem.Click += new System.EventHandler(this.lateTransactionToolStripMenuItem_Click);
            // 
            // doneTransactionToolStripMenuItem
            // 
            this.doneTransactionToolStripMenuItem.Name = "doneTransactionToolStripMenuItem";
            this.doneTransactionToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.doneTransactionToolStripMenuItem.Text = "Done Transaction";
            this.doneTransactionToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doneTransactionToolStripMenuItem.Click += new System.EventHandler(this.doneTransactionToolStripMenuItem_Click);
            // 
            // revenueToolStripMenuItem
            // 
            this.revenueToolStripMenuItem.Name = "revenueToolStripMenuItem";
            this.revenueToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.revenueToolStripMenuItem.Text = "Revenue";
            this.revenueToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.revenueToolStripMenuItem.Click += new System.EventHandler(this.revenueToolStripMenuItem_Click);
            // 
            // btn_TUpdate
            // 
            this.btn_TUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_TUpdate.Location = new System.Drawing.Point(568, 2);
            this.btn_TUpdate.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btn_TUpdate.Name = "btn_TUpdate";
            this.btn_TUpdate.Size = new System.Drawing.Size(94, 26);
            this.btn_TUpdate.TabIndex = 18;
            this.btn_TUpdate.Text = "Update";
            this.btn_TUpdate.UseVisualStyleBackColor = true;
            this.btn_TUpdate.Click += new System.EventHandler(this.btn_TUpdate_Click);
            // 
            // form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 581);
            this.Controls.Add(this.tc_MainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_ViewMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_Menu";
            this.ShowIcon = false;
            this.Text = "LALASA INFORMATION SYSTEM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_Menu_FormClosed);
            this.Load += new System.EventHandler(this.tc_MainMenu_SelectedIndexChanged);
            this.tc_MainMenu.ResumeLayout(false);
            this.tb_Transaction.ResumeLayout(false);
            this.Pnl_TransMenu.ResumeLayout(false);
            this.Pnl_TransMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_QuantityService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetailTransServices)).EndInit();
            this.pnl_TransTitleBar.ResumeLayout(false);
            this.pnl_TransTitleBar.PerformLayout();
            this.pnl_TransSideMenu.ResumeLayout(false);
            this.pnl_Search.ResumeLayout(false);
            this.pnl_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TransList)).EndInit();
            this.tb_DetailTrans.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_QtyTrans)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TSList)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TransDTList)).EndInit();
            this.tb_Schedule.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SchDetailServiceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ScheduleList)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TransScheduleList)).EndInit();
            this.tb_Payment.ResumeLayout(false);
            this.tb_Payment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payment)).EndInit();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PTransID)).EndInit();
            this.tb_Customer.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CCust)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cust)).EndInit();
            this.tb_Staff.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SStaff)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Staff)).EndInit();
            this.tb_View.ResumeLayout(false);
            this.tb_View.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).EndInit();
            this.ms_ViewMenu.ResumeLayout(false);
            this.ms_ViewMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl tc_MainMenu;
        private TabPage tb_Transaction;
        private TabPage tb_Schedule;
        private Panel pnl_TransSideMenu;
        private DataGridView dgv_TransList;
        private Panel pnl_Search;
        private TextBox tb_TransSearch;
        private Panel pnl_TransTitleBar;
        private Panel Pnl_TransMenu;
        private Label lbl_TransCode;
        private Label lbl_Text3;
        private Label lbl_Text1;
        private TextBox tb_Phone;
        private TextBox tb_Address;
        private TextBox tb_CompanyName;
        private Label lbl_Text6;
        private Label lbl_Text5;
        private Label lbl_Text4;
        private Label lbl_Text2;
        private Button btn_ClearTrans;
        private Label lbl_Text7;
        private Label lbl_Text8;
        private DateTimePicker dtp_DueDate;
        private Label lbl_Text9;
        private DateTimePicker dtp_Date;
        private TextBox tb_TransSubtotal;
        private Label lbl_Text10;
        private TextBox tb_Description;
        private Label lbl_Text12;
        private TextBox tb_AdditionalFee;
        private Label lbl_Text11;
        private Button btn_AddService;
        private TextBox tb_ServiceFee;
        private Label lbl_Text16;
        private TextBox tb_ServiceName;
        private Label lbl_Text15;
        private ComboBox cb_ServiceID;
        private Label lbl_Text14;
        private Label lbl_Test13;
        private Button btn_DeleteService;
        private DataGridView dgv_DetailTransServices;
        private NumericUpDown nud_QuantityService;
        private Label lbl_Text17;
        private Panel pnl_Line;
        private Button btn_DeleteTrans;
        private ComboBox cb_CustomerID;
        private TextBox tb_CustomerName;
        private Button btn_CreateTrans;
        private Panel panel1;
        private Panel panel2;
        private TextBox tb_SearchTransSchedule;
        private DataGridView dgv_TransScheduleList;
        private Panel panel3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgv_ScheduleList;
        private Button btn_SDelete;
        private Button btn_SAdd;
        private Label label17;
        private Panel panel5;
        private Label label18;
        private Label label8;
        private Label label7;
        private TabPage tb_DetailTrans;
        private TabPage tb_Customer;
        private TabPage tb_Staff;
        private TabPage tb_View;
        private DateTimePicker dtp_SEnd;
        private DateTimePicker dtp_SStart;
        private TextBox tb_ScheduleID;
        private TextBox tb_TransScheduleID;
        private ComboBox cb_StaffScheduleList;
        private TextBox tb_SchStaffPosition;
        private TextBox tb_SchStaffName;
        private DataGridView dgv_SchDetailServiceList;
        private Panel panel7;
        private NumericUpDown nud_QtyTrans;
        private Panel panel8;
        private Label label20;
        private Label label9;
        private Button btn_TSDelete;
        private DataGridView dgv_TSList;
        private Label label13;
        private Label label12;
        private Button btn_TSAdd;
        private ComboBox cb_TransServiceID;
        private TextBox tb_TransServiceFee;
        private Label label11;
        private Label label10;
        private TextBox tb_TransServiceName;
        private Panel panel4;
        private Panel panel6;
        private TextBox tb_Search;
        private DataGridView dgv_TransDTList;
        private Panel panel9;
        private Panel panel10;
        private TextBox tb_SearchCust;
        private DataGridView dgv_Cust;
        private Panel panel11;
        private Panel panel12;
        private TextBox tb_StaffID;
        private DataGridView dgv_Staff;
        private Panel panel13;
        private TextBox tb_CCustID;
        private Label label14;
        private DataGridView dgv_CCust;
        private Label label28;
        private TextBox tb_CPhone;
        private TextBox tb_CAddress;
        private TextBox tb_CCompany;
        private TextBox tb_CCustName;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Panel panel15;
        private Button btn_CUpdate;
        private Button btn_CCreate;
        private Button btn_CDelete;
        private Button btn_CClear;
        private Label label34;
        private Panel panel14;
        private TextBox tb_SAddress;
        private Label label26;
        private TextBox tb_SStaffID;
        private Label label15;
        private DataGridView dgv_SStaff;
        private Label label16;
        private TextBox tb_SPhone;
        private TextBox tb_SEmail;
        private TextBox tb_SPosition;
        private TextBox tb_SName;
        private Label label19;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Panel panel16;
        private Button btn_SUpdate;
        private Button btn_SCreate;
        private Button btn_SDel;
        private Button btn_SClear;
        private Label label25;
        private DataGridView dgv_View;
        private TextBox tb_SPassword;
        private Label label27;
        private TabPage tb_Payment;
        private TextBox tb_PPaymentAmount;
        private Label label45;
        private DateTimePicker dtp_PaymentDate;
        private Label label44;
        private Label label43;
        private Button btn_PDelete;
        private DataGridView dgv_Payment;
        private Button btn_PAdd;
        private TextBox tb_PTransactionID;
        private Label label42;
        private Panel panel19;
        private Label label41;
        private TextBox tb_PDesc;
        private Label label35;
        private TextBox tb_PAddFee;
        private Label label36;
        private TextBox tb_PTransTotal;
        private Label label37;
        private DateTimePicker dtp_PDueDate;
        private Label label38;
        private DateTimePicker dtp_PDate;
        private Label label39;
        private Label label40;
        private Panel panel17;
        private Panel panel18;
        private TextBox tb_PTransID;
        private DataGridView dgv_PTransID;
        private TextBox tb_PPaymentID;
        private Label label46;
        private ComboBox cb_PPaymentType;
        private Label label47;
        private MenuStrip ms_ViewMenu;
        private ToolStripMenuItem scheduleToolStripMenuItem;
        private ToolStripMenuItem ongoingTransactionToolStripMenuItem;
        private ToolStripMenuItem lateTransactionToolStripMenuItem;
        private ToolStripMenuItem doneTransactionToolStripMenuItem;
        private ToolStripMenuItem revenueToolStripMenuItem;
        private Button btn_TUpdate;
    }
}