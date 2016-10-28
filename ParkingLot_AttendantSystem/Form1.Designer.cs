namespace ITS3100_ParkingApp3
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            this.main_Panel = new System.Windows.Forms.Panel();
            this.showRemove_Button = new System.Windows.Forms.Button();
            this.showSearch_Button = new System.Windows.Forms.Button();
            this.showNew_Button = new System.Windows.Forms.Button();
            this.mainTitle_Label = new System.Windows.Forms.Label();
            this.newCustomer_Panel = new System.Windows.Forms.Panel();
            this.newTitle_Label = new System.Windows.Forms.Label();
            this.newFullname_Label = new System.Windows.Forms.Label();
            this.newLicensePlate_Label = new System.Windows.Forms.Label();
            this.newFullname_TBox = new System.Windows.Forms.TextBox();
            this.newLicensePlate_TBox = new System.Windows.Forms.TextBox();
            this.newFindParking_Button = new System.Windows.Forms.Button();
            this.searchCustomer_Panel = new System.Windows.Forms.Panel();
            this.searchTitle_Label = new System.Windows.Forms.Label();
            this.searchFullname_RButton = new System.Windows.Forms.RadioButton();
            this.searchLicensePlate_RButton = new System.Windows.Forms.RadioButton();
            this.searchParkingSpace_RButton = new System.Windows.Forms.RadioButton();
            this.search_TBox = new System.Windows.Forms.TextBox();
            this.search_Button = new System.Windows.Forms.Button();
            this.removeCustomer_Panel = new System.Windows.Forms.Panel();
            this.removeTitle = new System.Windows.Forms.Label();
            this.removeFullname_RButton = new System.Windows.Forms.RadioButton();
            this.removeLicensePlate_RButton = new System.Windows.Forms.RadioButton();
            this.removeParkingSpace_RButton = new System.Windows.Forms.RadioButton();
            this.remove_TBox = new System.Windows.Forms.TextBox();
            this.remove_Button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAttendant = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTester = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClock = new System.Windows.Forms.ToolStripTextBox();
            this.mnuTestCases = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTestParkingLot = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuParkingLotFull = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTestParkingLotEmpty = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTestParkingLotAssign = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTestParkingLotRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTestCustomerName = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTestNameNull = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTestNameShort = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTestNameLong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTestCustomerPlate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTestPlateNull = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTestPlateShort = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTestPlateLong = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mnuLogoff = new System.Windows.Forms.ToolStripMenuItem();
            this.main_Panel.SuspendLayout();
            this.newCustomer_Panel.SuspendLayout();
            this.searchCustomer_Panel.SuspendLayout();
            this.removeCustomer_Panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_Panel
            // 
            this.main_Panel.BackColor = System.Drawing.SystemColors.GrayText;
            this.main_Panel.Controls.Add(this.showRemove_Button);
            this.main_Panel.Controls.Add(this.showSearch_Button);
            this.main_Panel.Controls.Add(this.showNew_Button);
            this.main_Panel.Location = new System.Drawing.Point(12, 138);
            this.main_Panel.Name = "main_Panel";
            this.main_Panel.Size = new System.Drawing.Size(760, 83);
            this.main_Panel.TabIndex = 0;
            this.main_Panel.Visible = false;
            // 
            // showRemove_Button
            // 
            this.showRemove_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRemove_Button.Location = new System.Drawing.Point(542, 23);
            this.showRemove_Button.Name = "showRemove_Button";
            this.showRemove_Button.Size = new System.Drawing.Size(202, 41);
            this.showRemove_Button.TabIndex = 2;
            this.showRemove_Button.Text = "Remove";
            this.showRemove_Button.UseVisualStyleBackColor = true;
            this.showRemove_Button.Click += new System.EventHandler(this.remove_Button_Click);
            // 
            // showSearch_Button
            // 
            this.showSearch_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSearch_Button.Location = new System.Drawing.Point(277, 23);
            this.showSearch_Button.Name = "showSearch_Button";
            this.showSearch_Button.Size = new System.Drawing.Size(202, 41);
            this.showSearch_Button.TabIndex = 1;
            this.showSearch_Button.Text = "Search";
            this.showSearch_Button.UseVisualStyleBackColor = true;
            this.showSearch_Button.Click += new System.EventHandler(this.search_Button_Click);
            // 
            // showNew_Button
            // 
            this.showNew_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showNew_Button.Location = new System.Drawing.Point(19, 23);
            this.showNew_Button.Name = "showNew_Button";
            this.showNew_Button.Size = new System.Drawing.Size(202, 41);
            this.showNew_Button.TabIndex = 0;
            this.showNew_Button.Text = "New";
            this.showNew_Button.UseVisualStyleBackColor = true;
            this.showNew_Button.Click += new System.EventHandler(this.new_Button_Click);
            // 
            // mainTitle_Label
            // 
            this.mainTitle_Label.AutoSize = true;
            this.mainTitle_Label.Font = new System.Drawing.Font("Old English Text MT", 44F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainTitle_Label.Location = new System.Drawing.Point(-8, 45);
            this.mainTitle_Label.Margin = new System.Windows.Forms.Padding(10);
            this.mainTitle_Label.Name = "mainTitle_Label";
            this.mainTitle_Label.Size = new System.Drawing.Size(780, 71);
            this.mainTitle_Label.TabIndex = 1;
            this.mainTitle_Label.Text = "Parking Management System";
            // 
            // newCustomer_Panel
            // 
            this.newCustomer_Panel.BackColor = System.Drawing.SystemColors.GrayText;
            this.newCustomer_Panel.Controls.Add(this.newTitle_Label);
            this.newCustomer_Panel.Controls.Add(this.newFullname_Label);
            this.newCustomer_Panel.Controls.Add(this.newLicensePlate_Label);
            this.newCustomer_Panel.Controls.Add(this.newFullname_TBox);
            this.newCustomer_Panel.Controls.Add(this.newLicensePlate_TBox);
            this.newCustomer_Panel.Controls.Add(this.newFindParking_Button);
            this.newCustomer_Panel.Location = new System.Drawing.Point(12, 227);
            this.newCustomer_Panel.Name = "newCustomer_Panel";
            this.newCustomer_Panel.Size = new System.Drawing.Size(760, 325);
            this.newCustomer_Panel.TabIndex = 2;
            this.newCustomer_Panel.Visible = false;
            // 
            // newTitle_Label
            // 
            this.newTitle_Label.AutoSize = true;
            this.newTitle_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTitle_Label.Location = new System.Drawing.Point(15, 13);
            this.newTitle_Label.Name = "newTitle_Label";
            this.newTitle_Label.Size = new System.Drawing.Size(183, 24);
            this.newTitle_Label.TabIndex = 0;
            this.newTitle_Label.Text = "New Customer Entry";
            // 
            // newFullname_Label
            // 
            this.newFullname_Label.AutoSize = true;
            this.newFullname_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newFullname_Label.Location = new System.Drawing.Point(95, 82);
            this.newFullname_Label.Name = "newFullname_Label";
            this.newFullname_Label.Size = new System.Drawing.Size(84, 20);
            this.newFullname_Label.TabIndex = 1;
            this.newFullname_Label.Text = "Full Name:";
            // 
            // newLicensePlate_Label
            // 
            this.newLicensePlate_Label.AutoSize = true;
            this.newLicensePlate_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLicensePlate_Label.Location = new System.Drawing.Point(95, 120);
            this.newLicensePlate_Label.Name = "newLicensePlate_Label";
            this.newLicensePlate_Label.Size = new System.Drawing.Size(108, 20);
            this.newLicensePlate_Label.TabIndex = 2;
            this.newLicensePlate_Label.Text = "License Plate:";
            // 
            // newFullname_TBox
            // 
            this.newFullname_TBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newFullname_TBox.Location = new System.Drawing.Point(230, 80);
            this.newFullname_TBox.MaxLength = 25;
            this.newFullname_TBox.Name = "newFullname_TBox";
            this.newFullname_TBox.Size = new System.Drawing.Size(250, 26);
            this.newFullname_TBox.TabIndex = 4;
            // 
            // newLicensePlate_TBox
            // 
            this.newLicensePlate_TBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLicensePlate_TBox.Location = new System.Drawing.Point(230, 115);
            this.newLicensePlate_TBox.MaxLength = 8;
            this.newLicensePlate_TBox.Name = "newLicensePlate_TBox";
            this.newLicensePlate_TBox.Size = new System.Drawing.Size(250, 26);
            this.newLicensePlate_TBox.TabIndex = 5;
            // 
            // newFindParking_Button
            // 
            this.newFindParking_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newFindParking_Button.Location = new System.Drawing.Point(230, 150);
            this.newFindParking_Button.Name = "newFindParking_Button";
            this.newFindParking_Button.Size = new System.Drawing.Size(250, 35);
            this.newFindParking_Button.TabIndex = 6;
            this.newFindParking_Button.Text = "Find Parking";
            this.newFindParking_Button.UseVisualStyleBackColor = true;
            this.newFindParking_Button.Click += new System.EventHandler(this.findParking_Button_Click);
            // 
            // searchCustomer_Panel
            // 
            this.searchCustomer_Panel.BackColor = System.Drawing.SystemColors.GrayText;
            this.searchCustomer_Panel.Controls.Add(this.searchTitle_Label);
            this.searchCustomer_Panel.Controls.Add(this.searchFullname_RButton);
            this.searchCustomer_Panel.Controls.Add(this.searchLicensePlate_RButton);
            this.searchCustomer_Panel.Controls.Add(this.searchParkingSpace_RButton);
            this.searchCustomer_Panel.Controls.Add(this.search_TBox);
            this.searchCustomer_Panel.Controls.Add(this.search_Button);
            this.searchCustomer_Panel.Location = new System.Drawing.Point(12, 227);
            this.searchCustomer_Panel.Name = "searchCustomer_Panel";
            this.searchCustomer_Panel.Size = new System.Drawing.Size(760, 325);
            this.searchCustomer_Panel.TabIndex = 3;
            this.searchCustomer_Panel.Visible = false;
            // 
            // searchTitle_Label
            // 
            this.searchTitle_Label.AutoSize = true;
            this.searchTitle_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTitle_Label.Location = new System.Drawing.Point(15, 13);
            this.searchTitle_Label.Name = "searchTitle_Label";
            this.searchTitle_Label.Size = new System.Drawing.Size(232, 24);
            this.searchTitle_Label.TabIndex = 0;
            this.searchTitle_Label.Text = "Search Customer Records";
            // 
            // searchFullname_RButton
            // 
            this.searchFullname_RButton.AutoSize = true;
            this.searchFullname_RButton.Checked = true;
            this.searchFullname_RButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchFullname_RButton.Location = new System.Drawing.Point(80, 80);
            this.searchFullname_RButton.Name = "searchFullname_RButton";
            this.searchFullname_RButton.Size = new System.Drawing.Size(98, 24);
            this.searchFullname_RButton.TabIndex = 4;
            this.searchFullname_RButton.TabStop = true;
            this.searchFullname_RButton.Text = "Full Name";
            this.searchFullname_RButton.UseVisualStyleBackColor = true;
            this.searchFullname_RButton.CheckedChanged += new System.EventHandler(this.searchTBLength);
            // 
            // searchLicensePlate_RButton
            // 
            this.searchLicensePlate_RButton.AutoSize = true;
            this.searchLicensePlate_RButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLicensePlate_RButton.Location = new System.Drawing.Point(80, 110);
            this.searchLicensePlate_RButton.Name = "searchLicensePlate_RButton";
            this.searchLicensePlate_RButton.Size = new System.Drawing.Size(122, 24);
            this.searchLicensePlate_RButton.TabIndex = 5;
            this.searchLicensePlate_RButton.Text = "License Plate";
            this.searchLicensePlate_RButton.UseVisualStyleBackColor = true;
            this.searchLicensePlate_RButton.CheckedChanged += new System.EventHandler(this.searchTBLength);
            // 
            // searchParkingSpace_RButton
            // 
            this.searchParkingSpace_RButton.AutoSize = true;
            this.searchParkingSpace_RButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchParkingSpace_RButton.Location = new System.Drawing.Point(80, 140);
            this.searchParkingSpace_RButton.Name = "searchParkingSpace_RButton";
            this.searchParkingSpace_RButton.Size = new System.Drawing.Size(130, 24);
            this.searchParkingSpace_RButton.TabIndex = 6;
            this.searchParkingSpace_RButton.Text = "Parking Space";
            this.searchParkingSpace_RButton.UseVisualStyleBackColor = true;
            this.searchParkingSpace_RButton.CheckedChanged += new System.EventHandler(this.searchTBLength);
            // 
            // search_TBox
            // 
            this.search_TBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_TBox.Location = new System.Drawing.Point(230, 80);
            this.search_TBox.MaxLength = 25;
            this.search_TBox.Name = "search_TBox";
            this.search_TBox.Size = new System.Drawing.Size(250, 26);
            this.search_TBox.TabIndex = 7;
            // 
            // search_Button
            // 
            this.search_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_Button.Location = new System.Drawing.Point(230, 115);
            this.search_Button.Name = "search_Button";
            this.search_Button.Size = new System.Drawing.Size(250, 50);
            this.search_Button.TabIndex = 8;
            this.search_Button.Text = "Search";
            this.search_Button.UseVisualStyleBackColor = true;
            this.search_Button.Click += new System.EventHandler(this.searchPanel_Button_Click);
            // 
            // removeCustomer_Panel
            // 
            this.removeCustomer_Panel.BackColor = System.Drawing.SystemColors.GrayText;
            this.removeCustomer_Panel.Controls.Add(this.removeTitle);
            this.removeCustomer_Panel.Controls.Add(this.removeFullname_RButton);
            this.removeCustomer_Panel.Controls.Add(this.removeLicensePlate_RButton);
            this.removeCustomer_Panel.Controls.Add(this.removeParkingSpace_RButton);
            this.removeCustomer_Panel.Controls.Add(this.remove_TBox);
            this.removeCustomer_Panel.Controls.Add(this.remove_Button);
            this.removeCustomer_Panel.Location = new System.Drawing.Point(12, 227);
            this.removeCustomer_Panel.Name = "removeCustomer_Panel";
            this.removeCustomer_Panel.Size = new System.Drawing.Size(760, 325);
            this.removeCustomer_Panel.TabIndex = 4;
            this.removeCustomer_Panel.Visible = false;
            // 
            // removeTitle
            // 
            this.removeTitle.AutoSize = true;
            this.removeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTitle.Location = new System.Drawing.Point(15, 13);
            this.removeTitle.Name = "removeTitle";
            this.removeTitle.Size = new System.Drawing.Size(243, 24);
            this.removeTitle.TabIndex = 0;
            this.removeTitle.Text = "Remove Customer Records";
            // 
            // removeFullname_RButton
            // 
            this.removeFullname_RButton.AutoSize = true;
            this.removeFullname_RButton.Checked = true;
            this.removeFullname_RButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeFullname_RButton.Location = new System.Drawing.Point(80, 80);
            this.removeFullname_RButton.Name = "removeFullname_RButton";
            this.removeFullname_RButton.Size = new System.Drawing.Size(98, 24);
            this.removeFullname_RButton.TabIndex = 4;
            this.removeFullname_RButton.TabStop = true;
            this.removeFullname_RButton.Text = "Full Name";
            this.removeFullname_RButton.UseVisualStyleBackColor = true;
            this.removeFullname_RButton.CheckedChanged += new System.EventHandler(this.removeTBLength);
            // 
            // removeLicensePlate_RButton
            // 
            this.removeLicensePlate_RButton.AutoSize = true;
            this.removeLicensePlate_RButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeLicensePlate_RButton.Location = new System.Drawing.Point(80, 110);
            this.removeLicensePlate_RButton.Name = "removeLicensePlate_RButton";
            this.removeLicensePlate_RButton.Size = new System.Drawing.Size(122, 24);
            this.removeLicensePlate_RButton.TabIndex = 5;
            this.removeLicensePlate_RButton.Text = "License Plate";
            this.removeLicensePlate_RButton.UseVisualStyleBackColor = true;
            this.removeLicensePlate_RButton.CheckedChanged += new System.EventHandler(this.removeTBLength);
            // 
            // removeParkingSpace_RButton
            // 
            this.removeParkingSpace_RButton.AutoSize = true;
            this.removeParkingSpace_RButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeParkingSpace_RButton.Location = new System.Drawing.Point(80, 140);
            this.removeParkingSpace_RButton.Name = "removeParkingSpace_RButton";
            this.removeParkingSpace_RButton.Size = new System.Drawing.Size(130, 24);
            this.removeParkingSpace_RButton.TabIndex = 6;
            this.removeParkingSpace_RButton.Text = "Parking Space";
            this.removeParkingSpace_RButton.UseVisualStyleBackColor = true;
            this.removeParkingSpace_RButton.CheckedChanged += new System.EventHandler(this.removeTBLength);
            // 
            // remove_TBox
            // 
            this.remove_TBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_TBox.Location = new System.Drawing.Point(230, 80);
            this.remove_TBox.MaxLength = 25;
            this.remove_TBox.Name = "remove_TBox";
            this.remove_TBox.Size = new System.Drawing.Size(250, 26);
            this.remove_TBox.TabIndex = 7;
            // 
            // remove_Button
            // 
            this.remove_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_Button.Location = new System.Drawing.Point(230, 115);
            this.remove_Button.Name = "remove_Button";
            this.remove_Button.Size = new System.Drawing.Size(250, 50);
            this.remove_Button.TabIndex = 8;
            this.remove_Button.Text = "Remove";
            this.remove_Button.UseVisualStyleBackColor = true;
            this.remove_Button.Click += new System.EventHandler(this.removePanel_Button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.mnuClock,
            this.mnuTestCases});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogin,
            this.mnuStatus,
            this.mnuExit});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // mnuLogin
            // 
            this.mnuLogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogoff,
            this.mnuAttendant,
            this.mnuTester});
            this.mnuLogin.Name = "mnuLogin";
            this.mnuLogin.Size = new System.Drawing.Size(152, 22);
            this.mnuLogin.Text = "&Login";
            // 
            // mnuAttendant
            // 
            this.mnuAttendant.Name = "mnuAttendant";
            this.mnuAttendant.Size = new System.Drawing.Size(152, 22);
            this.mnuAttendant.Text = "Attendant";
            this.mnuAttendant.Click += new System.EventHandler(this.mnuAttendant_Click);
            // 
            // mnuTester
            // 
            this.mnuTester.Name = "mnuTester";
            this.mnuTester.Size = new System.Drawing.Size(152, 22);
            this.mnuTester.Text = "Tester";
            this.mnuTester.Click += new System.EventHandler(this.mnuTester_Click);
            // 
            // mnuStatus
            // 
            this.mnuStatus.Name = "mnuStatus";
            this.mnuStatus.Size = new System.Drawing.Size(152, 22);
            this.mnuStatus.Text = "&Status";
            this.mnuStatus.Visible = false;
            this.mnuStatus.Click += new System.EventHandler(this.mnuStatus_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(152, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.ToolTipText = "Exit Program";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuClock
            // 
            this.mnuClock.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuClock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mnuClock.Enabled = false;
            this.mnuClock.MaxLength = 15;
            this.mnuClock.Name = "mnuClock";
            this.mnuClock.ReadOnly = true;
            this.mnuClock.ShortcutsEnabled = false;
            this.mnuClock.Size = new System.Drawing.Size(100, 20);
            this.mnuClock.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mnuClock.ToolTipText = "Clock";
            // 
            // mnuTestCases
            // 
            this.mnuTestCases.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTestParkingLot,
            this.mnuTestCustomerName,
            this.mnuTestCustomerPlate});
            this.mnuTestCases.Name = "mnuTestCases";
            this.mnuTestCases.Size = new System.Drawing.Size(73, 20);
            this.mnuTestCases.Text = "Test Cases";
            this.mnuTestCases.ToolTipText = "Testing Menu";
            this.mnuTestCases.Visible = false;
            // 
            // mnuTestParkingLot
            // 
            this.mnuTestParkingLot.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuParkingLotFull,
            this.mnuTestParkingLotEmpty,
            this.mnuTestParkingLotAssign,
            this.mnuTestParkingLotRemove});
            this.mnuTestParkingLot.Name = "mnuTestParkingLot";
            this.mnuTestParkingLot.Size = new System.Drawing.Size(161, 22);
            this.mnuTestParkingLot.Text = "Parking Lot";
            // 
            // mnuParkingLotFull
            // 
            this.mnuParkingLotFull.Name = "mnuParkingLotFull";
            this.mnuParkingLotFull.Size = new System.Drawing.Size(172, 22);
            this.mnuParkingLotFull.Text = "Fill Parking Lot";
            this.mnuParkingLotFull.Click += new System.EventHandler(this.mnuParkingLotFull_Click);
            // 
            // mnuTestParkingLotEmpty
            // 
            this.mnuTestParkingLotEmpty.Name = "mnuTestParkingLotEmpty";
            this.mnuTestParkingLotEmpty.Size = new System.Drawing.Size(172, 22);
            this.mnuTestParkingLotEmpty.Text = "Empty Parking Lot";
            this.mnuTestParkingLotEmpty.Click += new System.EventHandler(this.mnuTestParkingLotEmpty_Click);
            // 
            // mnuTestParkingLotAssign
            // 
            this.mnuTestParkingLotAssign.Name = "mnuTestParkingLotAssign";
            this.mnuTestParkingLotAssign.Size = new System.Drawing.Size(172, 22);
            this.mnuTestParkingLotAssign.Text = "Add Customer";
            this.mnuTestParkingLotAssign.Click += new System.EventHandler(this.mnuTestParkingLotAssign_Click);
            // 
            // mnuTestParkingLotRemove
            // 
            this.mnuTestParkingLotRemove.Name = "mnuTestParkingLotRemove";
            this.mnuTestParkingLotRemove.Size = new System.Drawing.Size(172, 22);
            this.mnuTestParkingLotRemove.Text = "Remove Customer";
            this.mnuTestParkingLotRemove.Click += new System.EventHandler(this.mnuTestParkingLotRemove_Click);
            // 
            // mnuTestCustomerName
            // 
            this.mnuTestCustomerName.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTestNameNull,
            this.mnuTestNameShort,
            this.mnuTestNameLong});
            this.mnuTestCustomerName.Name = "mnuTestCustomerName";
            this.mnuTestCustomerName.Size = new System.Drawing.Size(161, 22);
            this.mnuTestCustomerName.Text = "Customer Name";
            // 
            // mnuTestNameNull
            // 
            this.mnuTestNameNull.Name = "mnuTestNameNull";
            this.mnuTestNameNull.Size = new System.Drawing.Size(152, 22);
            this.mnuTestNameNull.Text = "Null Name";
            this.mnuTestNameNull.Click += new System.EventHandler(this.mnuTestNameNull_Click);
            // 
            // mnuTestNameShort
            // 
            this.mnuTestNameShort.Name = "mnuTestNameShort";
            this.mnuTestNameShort.Size = new System.Drawing.Size(152, 22);
            this.mnuTestNameShort.Text = "Short Name";
            this.mnuTestNameShort.Click += new System.EventHandler(this.mnuTestNameShort_Click);
            // 
            // mnuTestNameLong
            // 
            this.mnuTestNameLong.Name = "mnuTestNameLong";
            this.mnuTestNameLong.Size = new System.Drawing.Size(152, 22);
            this.mnuTestNameLong.Text = "Long Name";
            this.mnuTestNameLong.Click += new System.EventHandler(this.mnuTestNameLong_Click);
            // 
            // mnuTestCustomerPlate
            // 
            this.mnuTestCustomerPlate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTestPlateNull,
            this.mnuTestPlateShort,
            this.mnuTestPlateLong});
            this.mnuTestCustomerPlate.Name = "mnuTestCustomerPlate";
            this.mnuTestCustomerPlate.Size = new System.Drawing.Size(161, 22);
            this.mnuTestCustomerPlate.Text = "Customer Plate";
            // 
            // mnuTestPlateNull
            // 
            this.mnuTestPlateNull.Name = "mnuTestPlateNull";
            this.mnuTestPlateNull.Size = new System.Drawing.Size(152, 22);
            this.mnuTestPlateNull.Text = "Null Plate";
            this.mnuTestPlateNull.Click += new System.EventHandler(this.mnuTestPlateNull_Click);
            // 
            // mnuTestPlateShort
            // 
            this.mnuTestPlateShort.Name = "mnuTestPlateShort";
            this.mnuTestPlateShort.Size = new System.Drawing.Size(152, 22);
            this.mnuTestPlateShort.Text = "Blank Plate";
            this.mnuTestPlateShort.Click += new System.EventHandler(this.mnuTestPlateShort_Click);
            // 
            // mnuTestPlateLong
            // 
            this.mnuTestPlateLong.Name = "mnuTestPlateLong";
            this.mnuTestPlateLong.Size = new System.Drawing.Size(152, 22);
            this.mnuTestPlateLong.Text = "Long Plate";
            this.mnuTestPlateLong.Click += new System.EventHandler(this.mnuTestPlateLong_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 750;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mnuLogoff
            // 
            this.mnuLogoff.Name = "mnuLogoff";
            this.mnuLogoff.Size = new System.Drawing.Size(152, 22);
            this.mnuLogoff.Text = "Log Off";
            this.mnuLogoff.Click += new System.EventHandler(this.mnuLogoff_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainTitle_Label);
            this.Controls.Add(this.main_Panel);
            this.Controls.Add(this.newCustomer_Panel);
            this.Controls.Add(this.searchCustomer_Panel);
            this.Controls.Add(this.removeCustomer_Panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "mainForm";
            this.Text = "Dream Builders Parking Management";
            this.main_Panel.ResumeLayout(false);
            this.newCustomer_Panel.ResumeLayout(false);
            this.newCustomer_Panel.PerformLayout();
            this.searchCustomer_Panel.ResumeLayout(false);
            this.searchCustomer_Panel.PerformLayout();
            this.removeCustomer_Panel.ResumeLayout(false);
            this.removeCustomer_Panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel main_Panel;
        private System.Windows.Forms.Button showRemove_Button;
        private System.Windows.Forms.Button showSearch_Button;
        private System.Windows.Forms.Button showNew_Button;
        private System.Windows.Forms.Label mainTitle_Label;
        private System.Windows.Forms.Panel newCustomer_Panel;
        private System.Windows.Forms.Button newFindParking_Button;
        private System.Windows.Forms.TextBox newLicensePlate_TBox;
        private System.Windows.Forms.TextBox newFullname_TBox;
        private System.Windows.Forms.Label newLicensePlate_Label;
        private System.Windows.Forms.Label newFullname_Label;
        private System.Windows.Forms.Label newTitle_Label;
        private System.Windows.Forms.Panel searchCustomer_Panel;
        private System.Windows.Forms.TextBox search_TBox;
        private System.Windows.Forms.Label searchTitle_Label;
        private System.Windows.Forms.Button search_Button;
        private System.Windows.Forms.RadioButton searchParkingSpace_RButton;
        private System.Windows.Forms.RadioButton searchLicensePlate_RButton;
        private System.Windows.Forms.RadioButton searchFullname_RButton;
        private System.Windows.Forms.Panel removeCustomer_Panel;
        private System.Windows.Forms.Button remove_Button;
        private System.Windows.Forms.RadioButton removeParkingSpace_RButton;
        private System.Windows.Forms.RadioButton removeLicensePlate_RButton;
        private System.Windows.Forms.RadioButton removeFullname_RButton;
        private System.Windows.Forms.TextBox remove_TBox;
        private System.Windows.Forms.Label removeTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuStatus;
        private System.Windows.Forms.ToolStripTextBox mnuClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem mnuTestCases;
        private System.Windows.Forms.ToolStripMenuItem mnuTestCustomerPlate;
        private System.Windows.Forms.ToolStripMenuItem mnuTestPlateShort;
        private System.Windows.Forms.ToolStripMenuItem mnuTestPlateLong;
        private System.Windows.Forms.ToolStripMenuItem mnuTestCustomerName;
        private System.Windows.Forms.ToolStripMenuItem mnuTestNameNull;
        private System.Windows.Forms.ToolStripMenuItem mnuTestNameShort;
        private System.Windows.Forms.ToolStripMenuItem mnuTestNameLong;
        private System.Windows.Forms.ToolStripMenuItem mnuTestParkingLot;
        private System.Windows.Forms.ToolStripMenuItem mnuTestParkingLotEmpty;
        private System.Windows.Forms.ToolStripMenuItem mnuParkingLotFull;
        private System.Windows.Forms.ToolStripMenuItem mnuTestParkingLotAssign;
        private System.Windows.Forms.ToolStripMenuItem mnuTestParkingLotRemove;
        private System.Windows.Forms.ToolStripMenuItem mnuTestPlateNull;
        private System.Windows.Forms.ToolStripMenuItem mnuLogin;
        private System.Windows.Forms.ToolStripMenuItem mnuAttendant;
        private System.Windows.Forms.ToolStripMenuItem mnuTester;
        private System.Windows.Forms.ToolStripMenuItem mnuLogoff;

    }
}

