
namespace CMS
{
    partial class UserControl4
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label dateIssuedLabel;
            System.Windows.Forms.Label expiryDateLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label certificateLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.abbrvTextBox = new System.Windows.Forms.TextBox();
            this.certificatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cMSDataSet = new CMS.CMSDataSet();
            this.certificateComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.certificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cMSDataSet1 = new CMS.CMSDataSet1();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.dateIssuedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.expiryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reqView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certificateDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forCertificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.forCertificationTableAdapter = new CMS.CMSDataSet1TableAdapters.ForCertificationTableAdapter();
            this.tableAdapterManager = new CMS.CMSDataSet1TableAdapters.TableAdapterManager();
            this.certificationTableAdapter = new CMS.CMSDataSet1TableAdapters.CertificationTableAdapter();
            this.certificatesTableAdapter = new CMS.CMSDataSetTableAdapters.CertificatesTableAdapter();
            this.tableAdapterManager1 = new CMS.CMSDataSetTableAdapters.TableAdapterManager();
            idLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            dateIssuedLabel = new System.Windows.Forms.Label();
            expiryDateLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            certificateLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.certificatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forCertificationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(16, 23);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(16, 46);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 7;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(16, 72);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 9;
            lastNameLabel.Text = "Last Name:";
            // 
            // dateIssuedLabel
            // 
            dateIssuedLabel.AutoSize = true;
            dateIssuedLabel.Location = new System.Drawing.Point(16, 154);
            dateIssuedLabel.Name = "dateIssuedLabel";
            dateIssuedLabel.Size = new System.Drawing.Size(67, 13);
            dateIssuedLabel.TabIndex = 11;
            dateIssuedLabel.Text = "Date Issued:";
            // 
            // expiryDateLabel
            // 
            expiryDateLabel.AutoSize = true;
            expiryDateLabel.Location = new System.Drawing.Point(16, 180);
            expiryDateLabel.Name = "expiryDateLabel";
            expiryDateLabel.Size = new System.Drawing.Size(64, 13);
            expiryDateLabel.TabIndex = 13;
            expiryDateLabel.Text = "Expiry Date:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(16, 127);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 5;
            typeLabel.Text = "Type:";
            // 
            // certificateLabel
            // 
            certificateLabel.AutoSize = true;
            certificateLabel.Location = new System.Drawing.Point(20, 101);
            certificateLabel.Name = "certificateLabel";
            certificateLabel.Size = new System.Drawing.Size(57, 13);
            certificateLabel.TabIndex = 17;
            certificateLabel.Text = "Certificate:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 489);
            this.tabControl1.TabIndex = 0;
            // 
            // qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw
            // 
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.AutoScroll = true;
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.Controls.Add(this.button3);
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.Controls.Add(this.abbrvTextBox);
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.Controls.Add(certificateLabel);
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.Controls.Add(this.certificateComboBox);
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.Controls.Add(this.button2);
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.Controls.Add(this.button1);
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.Controls.Add(idLabel);
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.Controls.Add(this.idTextBox);
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.Controls.Add(typeLabel);
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.Controls.Add(firstNameLabel);
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.Controls.Add(this.firstNameTextBox);
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.Controls.Add(lastNameLabel);
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.Controls.Add(this.lastNameTextBox);
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.Controls.Add(dateIssuedLabel);
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.Controls.Add(this.dateIssuedDateTimePicker);
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.Controls.Add(expiryDateLabel);
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.Controls.Add(this.expiryDateDateTimePicker);
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.Controls.Add(this.reqView);
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.Location = new System.Drawing.Point(4, 22);
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.Name = "qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwq" +
    "wqwqwqwqwqwqwqwqwqwqwqw";
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.Padding = new System.Windows.Forms.Padding(3);
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.Size = new System.Drawing.Size(763, 463);
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.TabIndex = 0;
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.Text = "Requests Manager";
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(295, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // abbrvTextBox
            // 
            this.abbrvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.certificatesBindingSource, "Abbrv", true));
            this.abbrvTextBox.Location = new System.Drawing.Point(89, 125);
            this.abbrvTextBox.Name = "abbrvTextBox";
            this.abbrvTextBox.ReadOnly = true;
            this.abbrvTextBox.Size = new System.Drawing.Size(200, 20);
            this.abbrvTextBox.TabIndex = 19;
            // 
            // certificatesBindingSource
            // 
            this.certificatesBindingSource.DataMember = "Certificates";
            this.certificatesBindingSource.DataSource = this.cMSDataSet;
            // 
            // cMSDataSet
            // 
            this.cMSDataSet.DataSetName = "CMSDataSet";
            this.cMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // certificateComboBox
            // 
            this.certificateComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.certificateComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.certificateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.certificatesBindingSource, "Certificate", true));
            this.certificateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.certificatesBindingSource, "Certificate", true));
            this.certificateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.certificatesBindingSource, "Id", true));
            this.certificateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.certificateComboBox.FormattingEnabled = true;
            this.certificateComboBox.Location = new System.Drawing.Point(89, 98);
            this.certificateComboBox.Name = "certificateComboBox";
            this.certificateComboBox.Size = new System.Drawing.Size(200, 21);
            this.certificateComboBox.TabIndex = 18;
            this.certificateComboBox.SelectedIndexChanged += new System.EventHandler(this.certificateComboBox_SelectedIndexChanged);
            this.certificateComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.certificateComboBox_KeyUp);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Deny Request";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Issue Certificate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.certificationBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(89, 23);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // certificationBindingSource
            // 
            this.certificationBindingSource.DataMember = "Certification";
            this.certificationBindingSource.DataSource = this.cMSDataSet1;
            // 
            // cMSDataSet1
            // 
            this.cMSDataSet1.DataSetName = "CMSDataSet1";
            this.cMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.certificationBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(89, 46);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.firstNameTextBox.TabIndex = 8;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.certificationBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(89, 72);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastNameTextBox.TabIndex = 10;
            // 
            // dateIssuedDateTimePicker
            // 
            this.dateIssuedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.certificationBindingSource, "DateIssued", true));
            this.dateIssuedDateTimePicker.Location = new System.Drawing.Point(89, 150);
            this.dateIssuedDateTimePicker.Name = "dateIssuedDateTimePicker";
            this.dateIssuedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateIssuedDateTimePicker.TabIndex = 12;
            // 
            // expiryDateDateTimePicker
            // 
            this.expiryDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.certificationBindingSource, "ExpiryDate", true));
            this.expiryDateDateTimePicker.Location = new System.Drawing.Point(89, 176);
            this.expiryDateDateTimePicker.Name = "expiryDateDateTimePicker";
            this.expiryDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.expiryDateDateTimePicker.TabIndex = 14;
            // 
            // reqView
            // 
            this.reqView.AllowUserToAddRows = false;
            this.reqView.AllowUserToDeleteRows = false;
            this.reqView.AutoGenerateColumns = false;
            this.reqView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reqView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.certificateDueDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.reqView.DataSource = this.forCertificationBindingSource;
            this.reqView.Location = new System.Drawing.Point(5, 243);
            this.reqView.Name = "reqView";
            this.reqView.ReadOnly = true;
            this.reqView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reqView.Size = new System.Drawing.Size(751, 217);
            this.reqView.TabIndex = 0;
            this.reqView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // certificateDueDataGridViewTextBoxColumn
            // 
            this.certificateDueDataGridViewTextBoxColumn.DataPropertyName = "CertificateDue";
            this.certificateDueDataGridViewTextBoxColumn.HeaderText = "CertificateDue";
            this.certificateDueDataGridViewTextBoxColumn.Name = "certificateDueDataGridViewTextBoxColumn";
            this.certificateDueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // forCertificationBindingSource
            // 
            this.forCertificationBindingSource.DataMember = "ForCertification";
            this.forCertificationBindingSource.DataSource = this.cMSDataSet1;
            // 
            // forCertificationTableAdapter
            // 
            this.forCertificationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CertificationTableAdapter = this.certificationTableAdapter;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.ForCertificationTableAdapter = this.forCertificationTableAdapter;
            this.tableAdapterManager.UpdateOrder = CMS.CMSDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // certificationTableAdapter
            // 
            this.certificationTableAdapter.ClearBeforeFill = true;
            // 
            // certificatesTableAdapter
            // 
            this.certificatesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CertificatesTableAdapter = this.certificatesTableAdapter;
            this.tableAdapterManager1.EmployeeTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = CMS.CMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(774, 492);
            this.Load += new System.EventHandler(this.UserControl4_Load);
            this.tabControl1.ResumeLayout(false);
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.ResumeLayout(false);
            this.qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.certificatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forCertificationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage qwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqwqw;
        private System.Windows.Forms.DataGridView reqView;
        private System.Windows.Forms.BindingSource forCertificationBindingSource;
        private CMSDataSet1 cMSDataSet1;
        private CMSDataSet1TableAdapters.ForCertificationTableAdapter forCertificationTableAdapter;
        private CMSDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource certificationBindingSource;
        private CMSDataSet1TableAdapters.CertificationTableAdapter certificationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certificateDueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.DateTimePicker dateIssuedDateTimePicker;
        private System.Windows.Forms.DateTimePicker expiryDateDateTimePicker;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource certificatesBindingSource;
        private CMSDataSet cMSDataSet;
        private CMSDataSetTableAdapters.CertificatesTableAdapter certificatesTableAdapter;
        private CMSDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox abbrvTextBox;
        private System.Windows.Forms.ComboBox certificateComboBox;
        private System.Windows.Forms.Button button3;
    }
}
