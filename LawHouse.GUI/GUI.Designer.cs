namespace LawHouse.GUI
{
    partial class GUI
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
            this.tabControl_Overview = new System.Windows.Forms.TabControl();
            this.tabPage_Overview = new System.Windows.Forms.TabPage();
            this.button_Help_Overview = new System.Windows.Forms.Button();
            this.button_AddNew = new System.Windows.Forms.Button();
            this.label_Overview = new System.Windows.Forms.Label();
            this.comboBox_Overview = new System.Windows.Forms.ComboBox();
            this.button_Overview_SaveChanges = new System.Windows.Forms.Button();
            this.objectListView_Overview = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn_Primary = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_CaseID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_CaseTitle = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_CaseStartDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_CaseEndDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_CaseKilometers = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_CaseEstimatedHours = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_CaseDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_CaseNotes = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_ClientID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_CaseEmployeeID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_ServiceTypeID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_ClientName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_ClientAdress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_ClientPhoneNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_EmployeeID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_EmployeeName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_ServiceID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_ServiceDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_ServicePrice = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_ServiceHours = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_ServiceStartDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_ServiceEmployeeID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPage_CreateCase = new System.Windows.Forms.TabPage();
            this.button_Cancel_CreateCase = new System.Windows.Forms.Button();
            this.button_Help_CreateCase = new System.Windows.Forms.Button();
            this.comboBox_Client = new System.Windows.Forms.ComboBox();
            this.richTextBox_CaseNotes = new System.Windows.Forms.RichTextBox();
            this.richTextBox_CaseDescription = new System.Windows.Forms.RichTextBox();
            this.button_CreateCase = new System.Windows.Forms.Button();
            this.label_CaseNotes = new System.Windows.Forms.Label();
            this.comboBox_Employee_CreateCase = new System.Windows.Forms.ComboBox();
            this.label_Employee = new System.Windows.Forms.Label();
            this.label_Client = new System.Windows.Forms.Label();
            this.comboBox_ServiceType_CreateCase = new System.Windows.Forms.ComboBox();
            this.label_Service = new System.Windows.Forms.Label();
            this.label_CaseTitle = new System.Windows.Forms.Label();
            this.label_CaseStartDate = new System.Windows.Forms.Label();
            this.label_CaseKilometers = new System.Windows.Forms.Label();
            this.label_CaseDescription = new System.Windows.Forms.Label();
            this.label_CaseEstimatedHours = new System.Windows.Forms.Label();
            this.textbox_CaseStartDate = new System.Windows.Forms.TextBox();
            this.textbox_CaseKilometers = new System.Windows.Forms.TextBox();
            this.textBox_CaseTitle = new System.Windows.Forms.TextBox();
            this.textBox_CaseEstimatedHours = new System.Windows.Forms.TextBox();
            this.tabPage_CreateEmployee = new System.Windows.Forms.TabPage();
            this.button_Cancel_CreateEmployee = new System.Windows.Forms.Button();
            this.button_Finished = new System.Windows.Forms.Button();
            this.listBox_EmployeeEducations_CreateEmployee = new System.Windows.Forms.ListBox();
            this.label_AddedEmployeeSpecialities = new System.Windows.Forms.Label();
            this.button_AddEducation_CreateEmployee = new System.Windows.Forms.Button();
            this.button_Help_CreateEmployee = new System.Windows.Forms.Button();
            this.label_EmployeeEducation = new System.Windows.Forms.Label();
            this.textBox_EmployeeName = new System.Windows.Forms.TextBox();
            this.comboBox_Education_CreateEmployee = new System.Windows.Forms.ComboBox();
            this.label_EmployeeName = new System.Windows.Forms.Label();
            this.button_CreateEmployee = new System.Windows.Forms.Button();
            this.tabPage_CreateClient = new System.Windows.Forms.TabPage();
            this.button_Cancel_CreateClient = new System.Windows.Forms.Button();
            this.button_Help_CreateClient = new System.Windows.Forms.Button();
            this.button_CreateClient = new System.Windows.Forms.Button();
            this.label_ClientPhoneNumber = new System.Windows.Forms.Label();
            this.label_ClientAdress = new System.Windows.Forms.Label();
            this.label_ClientName = new System.Windows.Forms.Label();
            this.textBox_ClientPhoneNumber = new System.Windows.Forms.TextBox();
            this.textbox_ClientAdress = new System.Windows.Forms.TextBox();
            this.textBox_ClientName = new System.Windows.Forms.TextBox();
            this.tabPage_CreateService = new System.Windows.Forms.TabPage();
            this.button_Cancel_CreateService = new System.Windows.Forms.Button();
            this.button_Help_CreateService = new System.Windows.Forms.Button();
            this.comboBox_Employee = new System.Windows.Forms.ComboBox();
            this.comboBox_Case = new System.Windows.Forms.ComboBox();
            this.button_AddService = new System.Windows.Forms.Button();
            this.label_EmployID = new System.Windows.Forms.Label();
            this.label_Case = new System.Windows.Forms.Label();
            this.label_ServiceHours = new System.Windows.Forms.Label();
            this.label_ServicePrice = new System.Windows.Forms.Label();
            this.label_ServiceDescription = new System.Windows.Forms.Label();
            this.label_ServiceStartDate = new System.Windows.Forms.Label();
            this.label_ServiceID = new System.Windows.Forms.Label();
            this.textBox_ServiceHours = new System.Windows.Forms.TextBox();
            this.textBox_ServicePrice = new System.Windows.Forms.TextBox();
            this.textBox_ServiceDescription = new System.Windows.Forms.TextBox();
            this.textbox_ServiceStartDate = new System.Windows.Forms.TextBox();
            this.textBox_ServiceID = new System.Windows.Forms.TextBox();
            this.tabControl_Overview.SuspendLayout();
            this.tabPage_Overview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_Overview)).BeginInit();
            this.tabPage_CreateCase.SuspendLayout();
            this.tabPage_CreateEmployee.SuspendLayout();
            this.tabPage_CreateClient.SuspendLayout();
            this.tabPage_CreateService.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Overview
            // 
            this.tabControl_Overview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_Overview.Controls.Add(this.tabPage_Overview);
            this.tabControl_Overview.Controls.Add(this.tabPage_CreateCase);
            this.tabControl_Overview.Controls.Add(this.tabPage_CreateEmployee);
            this.tabControl_Overview.Controls.Add(this.tabPage_CreateClient);
            this.tabControl_Overview.Controls.Add(this.tabPage_CreateService);
            this.tabControl_Overview.Location = new System.Drawing.Point(13, 13);
            this.tabControl_Overview.Multiline = true;
            this.tabControl_Overview.Name = "tabControl_Overview";
            this.tabControl_Overview.SelectedIndex = 0;
            this.tabControl_Overview.Size = new System.Drawing.Size(809, 425);
            this.tabControl_Overview.TabIndex = 0;
            // 
            // tabPage_Overview
            // 
            this.tabPage_Overview.Controls.Add(this.button_Help_Overview);
            this.tabPage_Overview.Controls.Add(this.button_AddNew);
            this.tabPage_Overview.Controls.Add(this.label_Overview);
            this.tabPage_Overview.Controls.Add(this.comboBox_Overview);
            this.tabPage_Overview.Controls.Add(this.button_Overview_SaveChanges);
            this.tabPage_Overview.Controls.Add(this.objectListView_Overview);
            this.tabPage_Overview.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Overview.Name = "tabPage_Overview";
            this.tabPage_Overview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Overview.Size = new System.Drawing.Size(801, 396);
            this.tabPage_Overview.TabIndex = 0;
            this.tabPage_Overview.Text = "Oversigt";
            this.tabPage_Overview.UseVisualStyleBackColor = true;
            // 
            // button_Help_Overview
            // 
            this.button_Help_Overview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Help_Overview.AutoSize = true;
            this.button_Help_Overview.Location = new System.Drawing.Point(768, 6);
            this.button_Help_Overview.Name = "button_Help_Overview";
            this.button_Help_Overview.Size = new System.Drawing.Size(27, 27);
            this.button_Help_Overview.TabIndex = 14;
            this.button_Help_Overview.Text = "?";
            this.button_Help_Overview.UseVisualStyleBackColor = true;
            // 
            // button_AddNew
            // 
            this.button_AddNew.AutoSize = true;
            this.button_AddNew.Location = new System.Drawing.Point(200, 6);
            this.button_AddNew.Name = "button_AddNew";
            this.button_AddNew.Size = new System.Drawing.Size(85, 27);
            this.button_AddNew.TabIndex = 13;
            this.button_AddNew.Text = "Opret ny...";
            this.button_AddNew.UseVisualStyleBackColor = true;
            this.button_AddNew.Click += new System.EventHandler(this.button_AddNew_Click);
            // 
            // label_Overview
            // 
            this.label_Overview.AutoSize = true;
            this.label_Overview.Location = new System.Drawing.Point(6, 9);
            this.label_Overview.Name = "label_Overview";
            this.label_Overview.Size = new System.Drawing.Size(61, 17);
            this.label_Overview.TabIndex = 12;
            this.label_Overview.Text = "Kategori";
            // 
            // comboBox_Overview
            // 
            this.comboBox_Overview.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Overview.FormattingEnabled = true;
            this.comboBox_Overview.Location = new System.Drawing.Point(73, 6);
            this.comboBox_Overview.Name = "comboBox_Overview";
            this.comboBox_Overview.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Overview.TabIndex = 11;
            this.comboBox_Overview.SelectedIndexChanged += new System.EventHandler(this.comboBox_Overview_SelectedIndexChanged);
            // 
            // button_Overview_SaveChanges
            // 
            this.button_Overview_SaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Overview_SaveChanges.AutoSize = true;
            this.button_Overview_SaveChanges.Location = new System.Drawing.Point(644, 6);
            this.button_Overview_SaveChanges.Name = "button_Overview_SaveChanges";
            this.button_Overview_SaveChanges.Size = new System.Drawing.Size(118, 27);
            this.button_Overview_SaveChanges.TabIndex = 1;
            this.button_Overview_SaveChanges.Text = "Gem ændringer";
            this.button_Overview_SaveChanges.UseVisualStyleBackColor = true;
            // 
            // objectListView_Overview
            // 
            this.objectListView_Overview.AllColumns.Add(this.olvColumn_Primary);
            this.objectListView_Overview.AllColumns.Add(this.olvColumn_CaseID);
            this.objectListView_Overview.AllColumns.Add(this.olvColumn_CaseTitle);
            this.objectListView_Overview.AllColumns.Add(this.olvColumn_CaseStartDate);
            this.objectListView_Overview.AllColumns.Add(this.olvColumn_CaseEndDate);
            this.objectListView_Overview.AllColumns.Add(this.olvColumn_CaseKilometers);
            this.objectListView_Overview.AllColumns.Add(this.olvColumn_CaseEstimatedHours);
            this.objectListView_Overview.AllColumns.Add(this.olvColumn_CaseDescription);
            this.objectListView_Overview.AllColumns.Add(this.olvColumn_CaseNotes);
            this.objectListView_Overview.AllColumns.Add(this.olvColumn_ClientID);
            this.objectListView_Overview.AllColumns.Add(this.olvColumn_CaseEmployeeID);
            this.objectListView_Overview.AllColumns.Add(this.olvColumn_ServiceTypeID);
            this.objectListView_Overview.AllColumns.Add(this.olvColumn_ClientName);
            this.objectListView_Overview.AllColumns.Add(this.olvColumn_ClientAdress);
            this.objectListView_Overview.AllColumns.Add(this.olvColumn_ClientPhoneNumber);
            this.objectListView_Overview.AllColumns.Add(this.olvColumn_EmployeeID);
            this.objectListView_Overview.AllColumns.Add(this.olvColumn_EmployeeName);
            this.objectListView_Overview.AllColumns.Add(this.olvColumn_ServiceID);
            this.objectListView_Overview.AllColumns.Add(this.olvColumn_ServiceDescription);
            this.objectListView_Overview.AllColumns.Add(this.olvColumn_ServicePrice);
            this.objectListView_Overview.AllColumns.Add(this.olvColumn_ServiceHours);
            this.objectListView_Overview.AllColumns.Add(this.olvColumn_ServiceStartDate);
            this.objectListView_Overview.AllColumns.Add(this.olvColumn_ServiceEmployeeID);
            this.objectListView_Overview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView_Overview.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.objectListView_Overview.CellEditUseWholeCell = false;
            this.objectListView_Overview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_Primary,
            this.olvColumn_CaseID,
            this.olvColumn_CaseTitle,
            this.olvColumn_CaseStartDate,
            this.olvColumn_CaseEndDate,
            this.olvColumn_CaseKilometers,
            this.olvColumn_CaseEstimatedHours,
            this.olvColumn_CaseDescription,
            this.olvColumn_CaseNotes,
            this.olvColumn_ClientID,
            this.olvColumn_CaseEmployeeID,
            this.olvColumn_ServiceTypeID,
            this.olvColumn_ClientName,
            this.olvColumn_ClientAdress,
            this.olvColumn_ClientPhoneNumber,
            this.olvColumn_EmployeeID,
            this.olvColumn_EmployeeName,
            this.olvColumn_ServiceID,
            this.olvColumn_ServiceDescription,
            this.olvColumn_ServicePrice,
            this.olvColumn_ServiceHours,
            this.olvColumn_ServiceStartDate,
            this.olvColumn_ServiceEmployeeID});
            this.objectListView_Overview.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_Overview.FullRowSelect = true;
            this.objectListView_Overview.GridLines = true;
            this.objectListView_Overview.HasCollapsibleGroups = false;
            this.objectListView_Overview.Location = new System.Drawing.Point(9, 42);
            this.objectListView_Overview.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.objectListView_Overview.Name = "objectListView_Overview";
            this.objectListView_Overview.ShowGroups = false;
            this.objectListView_Overview.ShowImagesOnSubItems = true;
            this.objectListView_Overview.Size = new System.Drawing.Size(782, 345);
            this.objectListView_Overview.TabIndex = 10;
            this.objectListView_Overview.UseCompatibleStateImageBehavior = false;
            this.objectListView_Overview.UseFiltering = true;
            this.objectListView_Overview.View = System.Windows.Forms.View.Details;
            this.objectListView_Overview.DoubleClick += new System.EventHandler(this.objectListView_Overview_DoubleClick);
            // 
            // olvColumn_Primary
            // 
            this.olvColumn_Primary.IsEditable = false;
            this.olvColumn_Primary.Width = 0;
            // 
            // olvColumn_CaseID
            // 
            this.olvColumn_CaseID.AspectName = "SagsNr";
            this.olvColumn_CaseID.IsEditable = false;
            this.olvColumn_CaseID.Text = "SagsNr";
            // 
            // olvColumn_CaseTitle
            // 
            this.olvColumn_CaseTitle.AspectName = "Arbejdstitel";
            this.olvColumn_CaseTitle.IsEditable = false;
            this.olvColumn_CaseTitle.Text = "Arbejdstitel";
            // 
            // olvColumn_CaseStartDate
            // 
            this.olvColumn_CaseStartDate.AspectName = "StartDato";
            this.olvColumn_CaseStartDate.IsEditable = false;
            this.olvColumn_CaseStartDate.Text = "StartDato";
            // 
            // olvColumn_CaseEndDate
            // 
            this.olvColumn_CaseEndDate.AspectName = "SlutDato";
            this.olvColumn_CaseEndDate.Text = "SlutDato";
            // 
            // olvColumn_CaseKilometers
            // 
            this.olvColumn_CaseKilometers.AspectName = "Kørselstimer";
            this.olvColumn_CaseKilometers.Text = "Kørselstimer";
            // 
            // olvColumn_CaseEstimatedHours
            // 
            this.olvColumn_CaseEstimatedHours.AspectName = "TimeEstimat";
            this.olvColumn_CaseEstimatedHours.Text = "TimeEstimat";
            // 
            // olvColumn_CaseDescription
            // 
            this.olvColumn_CaseDescription.AspectName = "SagsBeskrivelse";
            this.olvColumn_CaseDescription.Text = "SagsBeskrivelse";
            this.olvColumn_CaseDescription.Width = 90;
            // 
            // olvColumn_CaseNotes
            // 
            this.olvColumn_CaseNotes.AspectName = "InterneNoter";
            this.olvColumn_CaseNotes.Text = "InterneNoter";
            // 
            // olvColumn_ClientID
            // 
            this.olvColumn_ClientID.AspectName = "KlientNr";
            this.olvColumn_ClientID.IsEditable = false;
            this.olvColumn_ClientID.Text = "KlientNr";
            // 
            // olvColumn_CaseEmployeeID
            // 
            this.olvColumn_CaseEmployeeID.AspectName = "AdvokatId";
            this.olvColumn_CaseEmployeeID.Text = "AdvokatNr";
            // 
            // olvColumn_ServiceTypeID
            // 
            this.olvColumn_ServiceTypeID.AspectName = "YdelsesTypeNr";
            this.olvColumn_ServiceTypeID.Text = "YdelsesTypeNr";
            // 
            // olvColumn_ClientName
            // 
            this.olvColumn_ClientName.AspectName = "Navn";
            this.olvColumn_ClientName.Text = "Klient Navn";
            // 
            // olvColumn_ClientAdress
            // 
            this.olvColumn_ClientAdress.AspectName = "Adresse";
            this.olvColumn_ClientAdress.Text = "Adresse";
            // 
            // olvColumn_ClientPhoneNumber
            // 
            this.olvColumn_ClientPhoneNumber.AspectName = "TelefonNr";
            this.olvColumn_ClientPhoneNumber.Text = "TelefonNr";
            // 
            // olvColumn_EmployeeID
            // 
            this.olvColumn_EmployeeID.AspectName = "AdvokatId";
            this.olvColumn_EmployeeID.Text = "AdvokatId";
            this.olvColumn_EmployeeID.Width = 107;
            // 
            // olvColumn_EmployeeName
            // 
            this.olvColumn_EmployeeName.AspectName = "Navn";
            this.olvColumn_EmployeeName.Text = "Advokat Navn";
            // 
            // olvColumn_ServiceID
            // 
            this.olvColumn_ServiceID.AspectName = "YdelsesNr";
            this.olvColumn_ServiceID.Text = "Ydelses Nr";
            // 
            // olvColumn_ServiceDescription
            // 
            this.olvColumn_ServiceDescription.AspectName = "YdelsesBeskrivelse";
            this.olvColumn_ServiceDescription.Text = "Ydelse Beskrivelse";
            // 
            // olvColumn_ServicePrice
            // 
            this.olvColumn_ServicePrice.AspectName = "Pris";
            this.olvColumn_ServicePrice.Text = "Pris";
            // 
            // olvColumn_ServiceHours
            // 
            this.olvColumn_ServiceHours.AspectName = "Timer";
            this.olvColumn_ServiceHours.Text = "Timer";
            // 
            // olvColumn_ServiceStartDate
            // 
            this.olvColumn_ServiceStartDate.AspectName = "StartDato";
            this.olvColumn_ServiceStartDate.Text = "Start dato";
            // 
            // olvColumn_ServiceEmployeeID
            // 
            this.olvColumn_ServiceEmployeeID.AspectName = "AdvokatId";
            this.olvColumn_ServiceEmployeeID.Text = "AdvokatNr";
            // 
            // tabPage_CreateCase
            // 
            this.tabPage_CreateCase.Controls.Add(this.button_Cancel_CreateCase);
            this.tabPage_CreateCase.Controls.Add(this.button_Help_CreateCase);
            this.tabPage_CreateCase.Controls.Add(this.comboBox_Client);
            this.tabPage_CreateCase.Controls.Add(this.richTextBox_CaseNotes);
            this.tabPage_CreateCase.Controls.Add(this.richTextBox_CaseDescription);
            this.tabPage_CreateCase.Controls.Add(this.button_CreateCase);
            this.tabPage_CreateCase.Controls.Add(this.label_CaseNotes);
            this.tabPage_CreateCase.Controls.Add(this.comboBox_Employee_CreateCase);
            this.tabPage_CreateCase.Controls.Add(this.label_Employee);
            this.tabPage_CreateCase.Controls.Add(this.label_Client);
            this.tabPage_CreateCase.Controls.Add(this.comboBox_ServiceType_CreateCase);
            this.tabPage_CreateCase.Controls.Add(this.label_Service);
            this.tabPage_CreateCase.Controls.Add(this.label_CaseTitle);
            this.tabPage_CreateCase.Controls.Add(this.label_CaseStartDate);
            this.tabPage_CreateCase.Controls.Add(this.label_CaseKilometers);
            this.tabPage_CreateCase.Controls.Add(this.label_CaseDescription);
            this.tabPage_CreateCase.Controls.Add(this.label_CaseEstimatedHours);
            this.tabPage_CreateCase.Controls.Add(this.textbox_CaseStartDate);
            this.tabPage_CreateCase.Controls.Add(this.textbox_CaseKilometers);
            this.tabPage_CreateCase.Controls.Add(this.textBox_CaseTitle);
            this.tabPage_CreateCase.Controls.Add(this.textBox_CaseEstimatedHours);
            this.tabPage_CreateCase.Location = new System.Drawing.Point(4, 25);
            this.tabPage_CreateCase.Name = "tabPage_CreateCase";
            this.tabPage_CreateCase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CreateCase.Size = new System.Drawing.Size(801, 396);
            this.tabPage_CreateCase.TabIndex = 1;
            this.tabPage_CreateCase.Text = "Opret Sag";
            this.tabPage_CreateCase.UseVisualStyleBackColor = true;
            // 
            // button_Cancel_CreateCase
            // 
            this.button_Cancel_CreateCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancel_CreateCase.AutoSize = true;
            this.button_Cancel_CreateCase.Location = new System.Drawing.Point(631, 364);
            this.button_Cancel_CreateCase.Name = "button_Cancel_CreateCase";
            this.button_Cancel_CreateCase.Size = new System.Drawing.Size(75, 27);
            this.button_Cancel_CreateCase.TabIndex = 86;
            this.button_Cancel_CreateCase.Text = "Annuller";
            this.button_Cancel_CreateCase.UseVisualStyleBackColor = true;
            // 
            // button_Help_CreateCase
            // 
            this.button_Help_CreateCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Help_CreateCase.AutoSize = true;
            this.button_Help_CreateCase.Location = new System.Drawing.Point(768, 6);
            this.button_Help_CreateCase.Name = "button_Help_CreateCase";
            this.button_Help_CreateCase.Size = new System.Drawing.Size(27, 27);
            this.button_Help_CreateCase.TabIndex = 85;
            this.button_Help_CreateCase.Text = "?";
            this.button_Help_CreateCase.UseVisualStyleBackColor = true;
            // 
            // comboBox_Client
            // 
            this.comboBox_Client.FormattingEnabled = true;
            this.comboBox_Client.Location = new System.Drawing.Point(137, 272);
            this.comboBox_Client.Name = "comboBox_Client";
            this.comboBox_Client.Size = new System.Drawing.Size(169, 24);
            this.comboBox_Client.TabIndex = 84;
            // 
            // richTextBox_CaseNotes
            // 
            this.richTextBox_CaseNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_CaseNotes.Location = new System.Drawing.Point(526, 151);
            this.richTextBox_CaseNotes.Name = "richTextBox_CaseNotes";
            this.richTextBox_CaseNotes.Size = new System.Drawing.Size(226, 155);
            this.richTextBox_CaseNotes.TabIndex = 83;
            this.richTextBox_CaseNotes.Text = "";
            // 
            // richTextBox_CaseDescription
            // 
            this.richTextBox_CaseDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_CaseDescription.Location = new System.Drawing.Point(526, 16);
            this.richTextBox_CaseDescription.Name = "richTextBox_CaseDescription";
            this.richTextBox_CaseDescription.Size = new System.Drawing.Size(226, 155);
            this.richTextBox_CaseDescription.TabIndex = 82;
            this.richTextBox_CaseDescription.Text = "";
            // 
            // button_CreateCase
            // 
            this.button_CreateCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_CreateCase.AutoSize = true;
            this.button_CreateCase.Location = new System.Drawing.Point(712, 364);
            this.button_CreateCase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_CreateCase.Name = "button_CreateCase";
            this.button_CreateCase.Size = new System.Drawing.Size(83, 27);
            this.button_CreateCase.TabIndex = 81;
            this.button_CreateCase.Text = "Opret Sag";
            this.button_CreateCase.UseVisualStyleBackColor = true;
            this.button_CreateCase.Click += new System.EventHandler(this.button_CreateCase_Click);
            // 
            // label_CaseNotes
            // 
            this.label_CaseNotes.AutoSize = true;
            this.label_CaseNotes.Location = new System.Drawing.Point(351, 154);
            this.label_CaseNotes.Name = "label_CaseNotes";
            this.label_CaseNotes.Size = new System.Drawing.Size(89, 17);
            this.label_CaseNotes.TabIndex = 80;
            this.label_CaseNotes.Text = "Interne noter";
            // 
            // comboBox_Employee_CreateCase
            // 
            this.comboBox_Employee_CreateCase.Location = new System.Drawing.Point(137, 230);
            this.comboBox_Employee_CreateCase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Employee_CreateCase.Name = "comboBox_Employee_CreateCase";
            this.comboBox_Employee_CreateCase.Size = new System.Drawing.Size(169, 24);
            this.comboBox_Employee_CreateCase.TabIndex = 76;
            // 
            // label_Employee
            // 
            this.label_Employee.AutoSize = true;
            this.label_Employee.Location = new System.Drawing.Point(6, 230);
            this.label_Employee.Name = "label_Employee";
            this.label_Employee.Size = new System.Drawing.Size(93, 17);
            this.label_Employee.TabIndex = 79;
            this.label_Employee.Text = "Medarbejder*";
            // 
            // label_Client
            // 
            this.label_Client.AutoSize = true;
            this.label_Client.Location = new System.Drawing.Point(6, 272);
            this.label_Client.Name = "label_Client";
            this.label_Client.Size = new System.Drawing.Size(48, 17);
            this.label_Client.TabIndex = 78;
            this.label_Client.Text = "Klient*";
            // 
            // comboBox_ServiceType_CreateCase
            // 
            this.comboBox_ServiceType_CreateCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ServiceType_CreateCase.FormattingEnabled = true;
            this.comboBox_ServiceType_CreateCase.Location = new System.Drawing.Point(137, 16);
            this.comboBox_ServiceType_CreateCase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_ServiceType_CreateCase.Name = "comboBox_ServiceType_CreateCase";
            this.comboBox_ServiceType_CreateCase.Size = new System.Drawing.Size(169, 24);
            this.comboBox_ServiceType_CreateCase.TabIndex = 59;
            // 
            // label_Service
            // 
            this.label_Service.AutoSize = true;
            this.label_Service.Location = new System.Drawing.Point(6, 16);
            this.label_Service.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Service.Name = "label_Service";
            this.label_Service.Size = new System.Drawing.Size(76, 17);
            this.label_Service.TabIndex = 72;
            this.label_Service.Text = "Sags type*";
            // 
            // label_CaseTitle
            // 
            this.label_CaseTitle.AutoSize = true;
            this.label_CaseTitle.Location = new System.Drawing.Point(6, 65);
            this.label_CaseTitle.Name = "label_CaseTitle";
            this.label_CaseTitle.Size = new System.Drawing.Size(83, 17);
            this.label_CaseTitle.TabIndex = 61;
            this.label_CaseTitle.Text = "Arbejdstitel*";
            // 
            // label_CaseStartDate
            // 
            this.label_CaseStartDate.AutoSize = true;
            this.label_CaseStartDate.Location = new System.Drawing.Point(6, 109);
            this.label_CaseStartDate.Name = "label_CaseStartDate";
            this.label_CaseStartDate.Size = new System.Drawing.Size(70, 17);
            this.label_CaseStartDate.TabIndex = 62;
            this.label_CaseStartDate.Text = "Start dato";
            // 
            // label_CaseKilometers
            // 
            this.label_CaseKilometers.AutoSize = true;
            this.label_CaseKilometers.Location = new System.Drawing.Point(6, 151);
            this.label_CaseKilometers.Name = "label_CaseKilometers";
            this.label_CaseKilometers.Size = new System.Drawing.Size(86, 17);
            this.label_CaseKilometers.TabIndex = 65;
            this.label_CaseKilometers.Text = "Kørselstimer";
            // 
            // label_CaseDescription
            // 
            this.label_CaseDescription.AutoSize = true;
            this.label_CaseDescription.Location = new System.Drawing.Point(351, 19);
            this.label_CaseDescription.Name = "label_CaseDescription";
            this.label_CaseDescription.Size = new System.Drawing.Size(116, 17);
            this.label_CaseDescription.TabIndex = 71;
            this.label_CaseDescription.Text = "Sagsbeskrivelse*";
            // 
            // label_CaseEstimatedHours
            // 
            this.label_CaseEstimatedHours.AutoSize = true;
            this.label_CaseEstimatedHours.Location = new System.Drawing.Point(1, 191);
            this.label_CaseEstimatedHours.Name = "label_CaseEstimatedHours";
            this.label_CaseEstimatedHours.Size = new System.Drawing.Size(88, 17);
            this.label_CaseEstimatedHours.TabIndex = 67;
            this.label_CaseEstimatedHours.Text = "Time estimat";
            // 
            // textbox_CaseStartDate
            // 
            this.textbox_CaseStartDate.Enabled = false;
            this.textbox_CaseStartDate.Location = new System.Drawing.Point(137, 109);
            this.textbox_CaseStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textbox_CaseStartDate.Name = "textbox_CaseStartDate";
            this.textbox_CaseStartDate.Size = new System.Drawing.Size(169, 22);
            this.textbox_CaseStartDate.TabIndex = 64;
            // 
            // textbox_CaseKilometers
            // 
            this.textbox_CaseKilometers.Location = new System.Drawing.Point(137, 149);
            this.textbox_CaseKilometers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textbox_CaseKilometers.Name = "textbox_CaseKilometers";
            this.textbox_CaseKilometers.Size = new System.Drawing.Size(169, 22);
            this.textbox_CaseKilometers.TabIndex = 68;
            // 
            // textBox_CaseTitle
            // 
            this.textBox_CaseTitle.Location = new System.Drawing.Point(137, 65);
            this.textBox_CaseTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_CaseTitle.Name = "textBox_CaseTitle";
            this.textBox_CaseTitle.Size = new System.Drawing.Size(169, 22);
            this.textBox_CaseTitle.TabIndex = 63;
            // 
            // textBox_CaseEstimatedHours
            // 
            this.textBox_CaseEstimatedHours.Location = new System.Drawing.Point(137, 188);
            this.textBox_CaseEstimatedHours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_CaseEstimatedHours.Name = "textBox_CaseEstimatedHours";
            this.textBox_CaseEstimatedHours.Size = new System.Drawing.Size(169, 22);
            this.textBox_CaseEstimatedHours.TabIndex = 69;
            // 
            // tabPage_CreateEmployee
            // 
            this.tabPage_CreateEmployee.Controls.Add(this.button_Cancel_CreateEmployee);
            this.tabPage_CreateEmployee.Controls.Add(this.button_Finished);
            this.tabPage_CreateEmployee.Controls.Add(this.listBox_EmployeeEducations_CreateEmployee);
            this.tabPage_CreateEmployee.Controls.Add(this.label_AddedEmployeeSpecialities);
            this.tabPage_CreateEmployee.Controls.Add(this.button_AddEducation_CreateEmployee);
            this.tabPage_CreateEmployee.Controls.Add(this.button_Help_CreateEmployee);
            this.tabPage_CreateEmployee.Controls.Add(this.label_EmployeeEducation);
            this.tabPage_CreateEmployee.Controls.Add(this.textBox_EmployeeName);
            this.tabPage_CreateEmployee.Controls.Add(this.comboBox_Education_CreateEmployee);
            this.tabPage_CreateEmployee.Controls.Add(this.label_EmployeeName);
            this.tabPage_CreateEmployee.Controls.Add(this.button_CreateEmployee);
            this.tabPage_CreateEmployee.Location = new System.Drawing.Point(4, 25);
            this.tabPage_CreateEmployee.Name = "tabPage_CreateEmployee";
            this.tabPage_CreateEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CreateEmployee.Size = new System.Drawing.Size(801, 396);
            this.tabPage_CreateEmployee.TabIndex = 2;
            this.tabPage_CreateEmployee.Text = "Opret Advokat";
            this.tabPage_CreateEmployee.UseVisualStyleBackColor = true;
            // 
            // button_Cancel_CreateEmployee
            // 
            this.button_Cancel_CreateEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancel_CreateEmployee.AutoSize = true;
            this.button_Cancel_CreateEmployee.Location = new System.Drawing.Point(639, 363);
            this.button_Cancel_CreateEmployee.Name = "button_Cancel_CreateEmployee";
            this.button_Cancel_CreateEmployee.Size = new System.Drawing.Size(75, 27);
            this.button_Cancel_CreateEmployee.TabIndex = 87;
            this.button_Cancel_CreateEmployee.Text = "Annuller";
            this.button_Cancel_CreateEmployee.UseVisualStyleBackColor = true;
            // 
            // button_Finished
            // 
            this.button_Finished.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Finished.AutoSize = true;
            this.button_Finished.Location = new System.Drawing.Point(720, 363);
            this.button_Finished.Name = "button_Finished";
            this.button_Finished.Size = new System.Drawing.Size(75, 27);
            this.button_Finished.TabIndex = 81;
            this.button_Finished.Text = "Færdig";
            this.button_Finished.UseVisualStyleBackColor = true;
            this.button_Finished.Click += new System.EventHandler(this.button_Finished_Click);
            // 
            // listBox_EmployeeEducations_CreateEmployee
            // 
            this.listBox_EmployeeEducations_CreateEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_EmployeeEducations_CreateEmployee.Enabled = false;
            this.listBox_EmployeeEducations_CreateEmployee.FormattingEnabled = true;
            this.listBox_EmployeeEducations_CreateEmployee.ItemHeight = 16;
            this.listBox_EmployeeEducations_CreateEmployee.Location = new System.Drawing.Point(13, 107);
            this.listBox_EmployeeEducations_CreateEmployee.Name = "listBox_EmployeeEducations_CreateEmployee";
            this.listBox_EmployeeEducations_CreateEmployee.Size = new System.Drawing.Size(456, 276);
            this.listBox_EmployeeEducations_CreateEmployee.TabIndex = 80;
            // 
            // label_AddedEmployeeSpecialities
            // 
            this.label_AddedEmployeeSpecialities.AutoSize = true;
            this.label_AddedEmployeeSpecialities.Location = new System.Drawing.Point(10, 86);
            this.label_AddedEmployeeSpecialities.Name = "label_AddedEmployeeSpecialities";
            this.label_AddedEmployeeSpecialities.Size = new System.Drawing.Size(117, 17);
            this.label_AddedEmployeeSpecialities.TabIndex = 79;
            this.label_AddedEmployeeSpecialities.Text = "Efteruddannelser";
            // 
            // button_AddEducation_CreateEmployee
            // 
            this.button_AddEducation_CreateEmployee.AutoSize = true;
            this.button_AddEducation_CreateEmployee.Enabled = false;
            this.button_AddEducation_CreateEmployee.Location = new System.Drawing.Point(314, 49);
            this.button_AddEducation_CreateEmployee.Name = "button_AddEducation_CreateEmployee";
            this.button_AddEducation_CreateEmployee.Size = new System.Drawing.Size(155, 27);
            this.button_AddEducation_CreateEmployee.TabIndex = 78;
            this.button_AddEducation_CreateEmployee.Text = "Tilføj efteruddannelse";
            this.button_AddEducation_CreateEmployee.UseVisualStyleBackColor = true;
            this.button_AddEducation_CreateEmployee.Click += new System.EventHandler(this.button_AddSpeciality_CreateEmployee_Click);
            // 
            // button_Help_CreateEmployee
            // 
            this.button_Help_CreateEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Help_CreateEmployee.AutoSize = true;
            this.button_Help_CreateEmployee.Location = new System.Drawing.Point(768, 6);
            this.button_Help_CreateEmployee.Name = "button_Help_CreateEmployee";
            this.button_Help_CreateEmployee.Size = new System.Drawing.Size(27, 27);
            this.button_Help_CreateEmployee.TabIndex = 77;
            this.button_Help_CreateEmployee.Text = "?";
            this.button_Help_CreateEmployee.UseVisualStyleBackColor = true;
            // 
            // label_EmployeeEducation
            // 
            this.label_EmployeeEducation.AutoSize = true;
            this.label_EmployeeEducation.Location = new System.Drawing.Point(7, 48);
            this.label_EmployeeEducation.Name = "label_EmployeeEducation";
            this.label_EmployeeEducation.Size = new System.Drawing.Size(112, 17);
            this.label_EmployeeEducation.TabIndex = 76;
            this.label_EmployeeEducation.Text = "Efteruddannelse";
            // 
            // textBox_EmployeeName
            // 
            this.textBox_EmployeeName.Location = new System.Drawing.Point(139, 12);
            this.textBox_EmployeeName.Name = "textBox_EmployeeName";
            this.textBox_EmployeeName.Size = new System.Drawing.Size(169, 22);
            this.textBox_EmployeeName.TabIndex = 75;
            // 
            // comboBox_Education_CreateEmployee
            // 
            this.comboBox_Education_CreateEmployee.Enabled = false;
            this.comboBox_Education_CreateEmployee.FormattingEnabled = true;
            this.comboBox_Education_CreateEmployee.Location = new System.Drawing.Point(139, 49);
            this.comboBox_Education_CreateEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Education_CreateEmployee.Name = "comboBox_Education_CreateEmployee";
            this.comboBox_Education_CreateEmployee.Size = new System.Drawing.Size(169, 24);
            this.comboBox_Education_CreateEmployee.TabIndex = 74;
            // 
            // label_EmployeeName
            // 
            this.label_EmployeeName.AutoSize = true;
            this.label_EmployeeName.Location = new System.Drawing.Point(7, 12);
            this.label_EmployeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_EmployeeName.Name = "label_EmployeeName";
            this.label_EmployeeName.Size = new System.Drawing.Size(101, 17);
            this.label_EmployeeName.TabIndex = 73;
            this.label_EmployeeName.Text = "Advokat Navn*";
            // 
            // button_CreateEmployee
            // 
            this.button_CreateEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_CreateEmployee.AutoSize = true;
            this.button_CreateEmployee.Location = new System.Drawing.Point(314, 10);
            this.button_CreateEmployee.Name = "button_CreateEmployee";
            this.button_CreateEmployee.Size = new System.Drawing.Size(108, 27);
            this.button_CreateEmployee.TabIndex = 0;
            this.button_CreateEmployee.Text = "Opret advokat";
            this.button_CreateEmployee.UseVisualStyleBackColor = true;
            this.button_CreateEmployee.Click += new System.EventHandler(this.button_CreateEmployee_Click);
            // 
            // tabPage_CreateClient
            // 
            this.tabPage_CreateClient.Controls.Add(this.button_Cancel_CreateClient);
            this.tabPage_CreateClient.Controls.Add(this.button_Help_CreateClient);
            this.tabPage_CreateClient.Controls.Add(this.button_CreateClient);
            this.tabPage_CreateClient.Controls.Add(this.label_ClientPhoneNumber);
            this.tabPage_CreateClient.Controls.Add(this.label_ClientAdress);
            this.tabPage_CreateClient.Controls.Add(this.label_ClientName);
            this.tabPage_CreateClient.Controls.Add(this.textBox_ClientPhoneNumber);
            this.tabPage_CreateClient.Controls.Add(this.textbox_ClientAdress);
            this.tabPage_CreateClient.Controls.Add(this.textBox_ClientName);
            this.tabPage_CreateClient.Location = new System.Drawing.Point(4, 25);
            this.tabPage_CreateClient.Name = "tabPage_CreateClient";
            this.tabPage_CreateClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CreateClient.Size = new System.Drawing.Size(801, 396);
            this.tabPage_CreateClient.TabIndex = 3;
            this.tabPage_CreateClient.Text = "Opret Klient";
            this.tabPage_CreateClient.UseVisualStyleBackColor = true;
            // 
            // button_Cancel_CreateClient
            // 
            this.button_Cancel_CreateClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancel_CreateClient.AutoSize = true;
            this.button_Cancel_CreateClient.Location = new System.Drawing.Point(619, 362);
            this.button_Cancel_CreateClient.Name = "button_Cancel_CreateClient";
            this.button_Cancel_CreateClient.Size = new System.Drawing.Size(75, 27);
            this.button_Cancel_CreateClient.TabIndex = 88;
            this.button_Cancel_CreateClient.Text = "Annuller";
            this.button_Cancel_CreateClient.UseVisualStyleBackColor = true;
            // 
            // button_Help_CreateClient
            // 
            this.button_Help_CreateClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Help_CreateClient.AutoSize = true;
            this.button_Help_CreateClient.Location = new System.Drawing.Point(768, 6);
            this.button_Help_CreateClient.Name = "button_Help_CreateClient";
            this.button_Help_CreateClient.Size = new System.Drawing.Size(27, 27);
            this.button_Help_CreateClient.TabIndex = 86;
            this.button_Help_CreateClient.Text = "?";
            this.button_Help_CreateClient.UseVisualStyleBackColor = true;
            // 
            // button_CreateClient
            // 
            this.button_CreateClient.AutoSize = true;
            this.button_CreateClient.Location = new System.Drawing.Point(701, 362);
            this.button_CreateClient.Margin = new System.Windows.Forms.Padding(4);
            this.button_CreateClient.Name = "button_CreateClient";
            this.button_CreateClient.Size = new System.Drawing.Size(93, 27);
            this.button_CreateClient.TabIndex = 20;
            this.button_CreateClient.Text = "Opret Klient";
            this.button_CreateClient.UseVisualStyleBackColor = true;
            this.button_CreateClient.Click += new System.EventHandler(this.button_CreateClient_Click);
            // 
            // label_ClientPhoneNumber
            // 
            this.label_ClientPhoneNumber.AutoSize = true;
            this.label_ClientPhoneNumber.Location = new System.Drawing.Point(7, 87);
            this.label_ClientPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ClientPhoneNumber.Name = "label_ClientPhoneNumber";
            this.label_ClientPhoneNumber.Size = new System.Drawing.Size(71, 17);
            this.label_ClientPhoneNumber.TabIndex = 19;
            this.label_ClientPhoneNumber.Text = "TelefonNr";
            // 
            // label_ClientAdress
            // 
            this.label_ClientAdress.AutoSize = true;
            this.label_ClientAdress.Location = new System.Drawing.Point(7, 49);
            this.label_ClientAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ClientAdress.Name = "label_ClientAdress";
            this.label_ClientAdress.Size = new System.Drawing.Size(60, 17);
            this.label_ClientAdress.TabIndex = 18;
            this.label_ClientAdress.Text = "Adresse";
            // 
            // label_ClientName
            // 
            this.label_ClientName.AutoSize = true;
            this.label_ClientName.Location = new System.Drawing.Point(7, 13);
            this.label_ClientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ClientName.Name = "label_ClientName";
            this.label_ClientName.Size = new System.Drawing.Size(41, 17);
            this.label_ClientName.TabIndex = 17;
            this.label_ClientName.Text = "Navn";
            // 
            // textBox_ClientPhoneNumber
            // 
            this.textBox_ClientPhoneNumber.Location = new System.Drawing.Point(99, 87);
            this.textBox_ClientPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ClientPhoneNumber.Name = "textBox_ClientPhoneNumber";
            this.textBox_ClientPhoneNumber.Size = new System.Drawing.Size(169, 22);
            this.textBox_ClientPhoneNumber.TabIndex = 16;
            // 
            // textbox_ClientAdress
            // 
            this.textbox_ClientAdress.Location = new System.Drawing.Point(99, 49);
            this.textbox_ClientAdress.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_ClientAdress.Name = "textbox_ClientAdress";
            this.textbox_ClientAdress.Size = new System.Drawing.Size(169, 22);
            this.textbox_ClientAdress.TabIndex = 15;
            // 
            // textBox_ClientName
            // 
            this.textBox_ClientName.Location = new System.Drawing.Point(99, 13);
            this.textBox_ClientName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ClientName.Name = "textBox_ClientName";
            this.textBox_ClientName.Size = new System.Drawing.Size(169, 22);
            this.textBox_ClientName.TabIndex = 14;
            // 
            // tabPage_CreateService
            // 
            this.tabPage_CreateService.Controls.Add(this.button_Cancel_CreateService);
            this.tabPage_CreateService.Controls.Add(this.button_Help_CreateService);
            this.tabPage_CreateService.Controls.Add(this.comboBox_Employee);
            this.tabPage_CreateService.Controls.Add(this.comboBox_Case);
            this.tabPage_CreateService.Controls.Add(this.button_AddService);
            this.tabPage_CreateService.Controls.Add(this.label_EmployID);
            this.tabPage_CreateService.Controls.Add(this.label_Case);
            this.tabPage_CreateService.Controls.Add(this.label_ServiceHours);
            this.tabPage_CreateService.Controls.Add(this.label_ServicePrice);
            this.tabPage_CreateService.Controls.Add(this.label_ServiceDescription);
            this.tabPage_CreateService.Controls.Add(this.label_ServiceStartDate);
            this.tabPage_CreateService.Controls.Add(this.label_ServiceID);
            this.tabPage_CreateService.Controls.Add(this.textBox_ServiceHours);
            this.tabPage_CreateService.Controls.Add(this.textBox_ServicePrice);
            this.tabPage_CreateService.Controls.Add(this.textBox_ServiceDescription);
            this.tabPage_CreateService.Controls.Add(this.textbox_ServiceStartDate);
            this.tabPage_CreateService.Controls.Add(this.textBox_ServiceID);
            this.tabPage_CreateService.Location = new System.Drawing.Point(4, 25);
            this.tabPage_CreateService.Name = "tabPage_CreateService";
            this.tabPage_CreateService.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CreateService.Size = new System.Drawing.Size(801, 396);
            this.tabPage_CreateService.TabIndex = 4;
            this.tabPage_CreateService.Text = "Opret Ydelse";
            this.tabPage_CreateService.UseVisualStyleBackColor = true;
            // 
            // button_Cancel_CreateService
            // 
            this.button_Cancel_CreateService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancel_CreateService.AutoSize = true;
            this.button_Cancel_CreateService.Location = new System.Drawing.Point(621, 364);
            this.button_Cancel_CreateService.Name = "button_Cancel_CreateService";
            this.button_Cancel_CreateService.Size = new System.Drawing.Size(75, 27);
            this.button_Cancel_CreateService.TabIndex = 88;
            this.button_Cancel_CreateService.Text = "Annuller";
            this.button_Cancel_CreateService.UseVisualStyleBackColor = true;
            // 
            // button_Help_CreateService
            // 
            this.button_Help_CreateService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Help_CreateService.AutoSize = true;
            this.button_Help_CreateService.Location = new System.Drawing.Point(768, 6);
            this.button_Help_CreateService.Name = "button_Help_CreateService";
            this.button_Help_CreateService.Size = new System.Drawing.Size(27, 27);
            this.button_Help_CreateService.TabIndex = 87;
            this.button_Help_CreateService.Text = "?";
            this.button_Help_CreateService.UseVisualStyleBackColor = true;
            // 
            // comboBox_Employee
            // 
            this.comboBox_Employee.FormattingEnabled = true;
            this.comboBox_Employee.Location = new System.Drawing.Point(106, 281);
            this.comboBox_Employee.Name = "comboBox_Employee";
            this.comboBox_Employee.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Employee.TabIndex = 46;
            // 
            // comboBox_Case
            // 
            this.comboBox_Case.FormattingEnabled = true;
            this.comboBox_Case.Location = new System.Drawing.Point(106, 238);
            this.comboBox_Case.Name = "comboBox_Case";
            this.comboBox_Case.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Case.TabIndex = 45;
            // 
            // button_AddService
            // 
            this.button_AddService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddService.AutoSize = true;
            this.button_AddService.Location = new System.Drawing.Point(702, 364);
            this.button_AddService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_AddService.Name = "button_AddService";
            this.button_AddService.Size = new System.Drawing.Size(93, 27);
            this.button_AddService.TabIndex = 44;
            this.button_AddService.Text = "Tilføj ydelse";
            this.button_AddService.UseVisualStyleBackColor = true;
            // 
            // label_EmployID
            // 
            this.label_EmployID.AutoSize = true;
            this.label_EmployID.Location = new System.Drawing.Point(6, 281);
            this.label_EmployID.Name = "label_EmployID";
            this.label_EmployID.Size = new System.Drawing.Size(59, 17);
            this.label_EmployID.TabIndex = 43;
            this.label_EmployID.Text = "Advokat";
            // 
            // label_Case
            // 
            this.label_Case.AutoSize = true;
            this.label_Case.Location = new System.Drawing.Point(6, 238);
            this.label_Case.Name = "label_Case";
            this.label_Case.Size = new System.Drawing.Size(33, 17);
            this.label_Case.TabIndex = 42;
            this.label_Case.Text = "Sag";
            // 
            // label_ServiceHours
            // 
            this.label_ServiceHours.AutoSize = true;
            this.label_ServiceHours.Location = new System.Drawing.Point(6, 190);
            this.label_ServiceHours.Name = "label_ServiceHours";
            this.label_ServiceHours.Size = new System.Drawing.Size(44, 17);
            this.label_ServiceHours.TabIndex = 41;
            this.label_ServiceHours.Text = "Timer";
            // 
            // label_ServicePrice
            // 
            this.label_ServicePrice.AutoSize = true;
            this.label_ServicePrice.Location = new System.Drawing.Point(6, 142);
            this.label_ServicePrice.Name = "label_ServicePrice";
            this.label_ServicePrice.Size = new System.Drawing.Size(32, 17);
            this.label_ServicePrice.TabIndex = 40;
            this.label_ServicePrice.Text = "Pris";
            // 
            // label_ServiceDescription
            // 
            this.label_ServiceDescription.AutoSize = true;
            this.label_ServiceDescription.Location = new System.Drawing.Point(6, 102);
            this.label_ServiceDescription.Name = "label_ServiceDescription";
            this.label_ServiceDescription.Size = new System.Drawing.Size(80, 17);
            this.label_ServiceDescription.TabIndex = 39;
            this.label_ServiceDescription.Text = "Beskrivelse";
            // 
            // label_ServiceStartDate
            // 
            this.label_ServiceStartDate.AutoSize = true;
            this.label_ServiceStartDate.Location = new System.Drawing.Point(6, 58);
            this.label_ServiceStartDate.Name = "label_ServiceStartDate";
            this.label_ServiceStartDate.Size = new System.Drawing.Size(70, 17);
            this.label_ServiceStartDate.TabIndex = 38;
            this.label_ServiceStartDate.Text = "Start dato";
            // 
            // label_ServiceID
            // 
            this.label_ServiceID.AutoSize = true;
            this.label_ServiceID.Location = new System.Drawing.Point(6, 12);
            this.label_ServiceID.Name = "label_ServiceID";
            this.label_ServiceID.Size = new System.Drawing.Size(75, 17);
            this.label_ServiceID.TabIndex = 37;
            this.label_ServiceID.Text = "Ydelses nr";
            // 
            // textBox_ServiceHours
            // 
            this.textBox_ServiceHours.Location = new System.Drawing.Point(106, 185);
            this.textBox_ServiceHours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ServiceHours.Name = "textBox_ServiceHours";
            this.textBox_ServiceHours.Size = new System.Drawing.Size(121, 22);
            this.textBox_ServiceHours.TabIndex = 34;
            // 
            // textBox_ServicePrice
            // 
            this.textBox_ServicePrice.Location = new System.Drawing.Point(106, 137);
            this.textBox_ServicePrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ServicePrice.Name = "textBox_ServicePrice";
            this.textBox_ServicePrice.Size = new System.Drawing.Size(121, 22);
            this.textBox_ServicePrice.TabIndex = 33;
            // 
            // textBox_ServiceDescription
            // 
            this.textBox_ServiceDescription.Location = new System.Drawing.Point(106, 97);
            this.textBox_ServiceDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ServiceDescription.Name = "textBox_ServiceDescription";
            this.textBox_ServiceDescription.Size = new System.Drawing.Size(121, 22);
            this.textBox_ServiceDescription.TabIndex = 32;
            // 
            // textbox_ServiceStartDate
            // 
            this.textbox_ServiceStartDate.Location = new System.Drawing.Point(106, 53);
            this.textbox_ServiceStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textbox_ServiceStartDate.Name = "textbox_ServiceStartDate";
            this.textbox_ServiceStartDate.Size = new System.Drawing.Size(121, 22);
            this.textbox_ServiceStartDate.TabIndex = 31;
            // 
            // textBox_ServiceID
            // 
            this.textBox_ServiceID.Enabled = false;
            this.textBox_ServiceID.Location = new System.Drawing.Point(106, 7);
            this.textBox_ServiceID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ServiceID.Name = "textBox_ServiceID";
            this.textBox_ServiceID.Size = new System.Drawing.Size(121, 22);
            this.textBox_ServiceID.TabIndex = 30;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.tabControl_Overview);
            this.Name = "GUI";
            this.Text = "LawHouse";
            this.tabControl_Overview.ResumeLayout(false);
            this.tabPage_Overview.ResumeLayout(false);
            this.tabPage_Overview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_Overview)).EndInit();
            this.tabPage_CreateCase.ResumeLayout(false);
            this.tabPage_CreateCase.PerformLayout();
            this.tabPage_CreateEmployee.ResumeLayout(false);
            this.tabPage_CreateEmployee.PerformLayout();
            this.tabPage_CreateClient.ResumeLayout(false);
            this.tabPage_CreateClient.PerformLayout();
            this.tabPage_CreateService.ResumeLayout(false);
            this.tabPage_CreateService.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Overview;
        private System.Windows.Forms.TabPage tabPage_Overview;
        private System.Windows.Forms.Button button_Help_Overview;
        private System.Windows.Forms.Button button_AddNew;
        private System.Windows.Forms.Label label_Overview;
        private System.Windows.Forms.ComboBox comboBox_Overview;
        private System.Windows.Forms.Button button_Overview_SaveChanges;
        private BrightIdeasSoftware.ObjectListView objectListView_Overview;
        private BrightIdeasSoftware.OLVColumn olvColumn_Primary;
        private BrightIdeasSoftware.OLVColumn olvColumn_CaseID;
        private BrightIdeasSoftware.OLVColumn olvColumn_CaseTitle;
        private BrightIdeasSoftware.OLVColumn olvColumn_CaseStartDate;
        private BrightIdeasSoftware.OLVColumn olvColumn_CaseEndDate;
        private BrightIdeasSoftware.OLVColumn olvColumn_CaseKilometers;
        private BrightIdeasSoftware.OLVColumn olvColumn_CaseEstimatedHours;
        private BrightIdeasSoftware.OLVColumn olvColumn_CaseDescription;
        private BrightIdeasSoftware.OLVColumn olvColumn_CaseNotes;
        private BrightIdeasSoftware.OLVColumn olvColumn_ClientID;
        private BrightIdeasSoftware.OLVColumn olvColumn_EmployeeID;
        private BrightIdeasSoftware.OLVColumn olvColumn_ServiceTypeID;
        private BrightIdeasSoftware.OLVColumn olvColumn_ClientName;
        private BrightIdeasSoftware.OLVColumn olvColumn_ClientAdress;
        private BrightIdeasSoftware.OLVColumn olvColumn_ClientPhoneNumber;
        private BrightIdeasSoftware.OLVColumn olvColumn_EmployeeName;
        private BrightIdeasSoftware.OLVColumn olvColumn_ServiceID;
        private BrightIdeasSoftware.OLVColumn olvColumn_ServiceDescription;
        private BrightIdeasSoftware.OLVColumn olvColumn_ServicePrice;
        private BrightIdeasSoftware.OLVColumn olvColumn_ServiceHours;
        private System.Windows.Forms.TabPage tabPage_CreateCase;
        private BrightIdeasSoftware.OLVColumn olvColumn_CaseEmployeeID;
        private BrightIdeasSoftware.OLVColumn olvColumn_ServiceStartDate;
        private BrightIdeasSoftware.OLVColumn olvColumn_ServiceEmployeeID;
        private System.Windows.Forms.ComboBox comboBox_Client;
        private System.Windows.Forms.RichTextBox richTextBox_CaseNotes;
        private System.Windows.Forms.RichTextBox richTextBox_CaseDescription;
        private System.Windows.Forms.Button button_CreateCase;
        private System.Windows.Forms.Label label_CaseNotes;
        private System.Windows.Forms.ComboBox comboBox_Employee_CreateCase;
        private System.Windows.Forms.Label label_Employee;
        private System.Windows.Forms.Label label_Client;
        private System.Windows.Forms.ComboBox comboBox_ServiceType_CreateCase;
        private System.Windows.Forms.Label label_Service;
        private System.Windows.Forms.Label label_CaseTitle;
        private System.Windows.Forms.Label label_CaseStartDate;
        private System.Windows.Forms.Label label_CaseKilometers;
        private System.Windows.Forms.Label label_CaseDescription;
        private System.Windows.Forms.Label label_CaseEstimatedHours;
        private System.Windows.Forms.TextBox textbox_CaseStartDate;
        private System.Windows.Forms.TextBox textbox_CaseKilometers;
        private System.Windows.Forms.TextBox textBox_CaseTitle;
        private System.Windows.Forms.TextBox textBox_CaseEstimatedHours;
        private System.Windows.Forms.TabPage tabPage_CreateEmployee;
        private System.Windows.Forms.Button button_CreateEmployee;
        private System.Windows.Forms.Label label_EmployeeName;
        private System.Windows.Forms.Button button_Help_CreateCase;
        private System.Windows.Forms.Label label_EmployeeEducation;
        private System.Windows.Forms.TextBox textBox_EmployeeName;
        private System.Windows.Forms.ComboBox comboBox_Education_CreateEmployee;
        private System.Windows.Forms.ListBox listBox_EmployeeEducations_CreateEmployee;
        private System.Windows.Forms.Label label_AddedEmployeeSpecialities;
        private System.Windows.Forms.Button button_AddEducation_CreateEmployee;
        private System.Windows.Forms.Button button_Help_CreateEmployee;
        private System.Windows.Forms.TabPage tabPage_CreateClient;
        private System.Windows.Forms.Button button_CreateClient;
        private System.Windows.Forms.Label label_ClientPhoneNumber;
        private System.Windows.Forms.Label label_ClientAdress;
        private System.Windows.Forms.Label label_ClientName;
        private System.Windows.Forms.TextBox textBox_ClientPhoneNumber;
        private System.Windows.Forms.TextBox textbox_ClientAdress;
        private System.Windows.Forms.TextBox textBox_ClientName;
        private System.Windows.Forms.Button button_Help_CreateClient;
        private System.Windows.Forms.TabPage tabPage_CreateService;
        private System.Windows.Forms.Button button_Help_CreateService;
        private System.Windows.Forms.ComboBox comboBox_Employee;
        private System.Windows.Forms.ComboBox comboBox_Case;
        private System.Windows.Forms.Button button_AddService;
        private System.Windows.Forms.Label label_EmployID;
        private System.Windows.Forms.Label label_Case;
        private System.Windows.Forms.Label label_ServiceHours;
        private System.Windows.Forms.Label label_ServicePrice;
        private System.Windows.Forms.Label label_ServiceDescription;
        private System.Windows.Forms.Label label_ServiceStartDate;
        private System.Windows.Forms.Label label_ServiceID;
        private System.Windows.Forms.TextBox textBox_ServiceHours;
        private System.Windows.Forms.TextBox textBox_ServicePrice;
        private System.Windows.Forms.TextBox textBox_ServiceDescription;
        private System.Windows.Forms.TextBox textbox_ServiceStartDate;
        private System.Windows.Forms.TextBox textBox_ServiceID;
        private System.Windows.Forms.Button button_Finished;
        private System.Windows.Forms.Button button_Cancel_CreateCase;
        private System.Windows.Forms.Button button_Cancel_CreateEmployee;
        private System.Windows.Forms.Button button_Cancel_CreateClient;
        private System.Windows.Forms.Button button_Cancel_CreateService;
    }
}

