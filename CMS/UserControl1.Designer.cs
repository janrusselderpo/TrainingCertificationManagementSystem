
namespace CMS
{
    partial class UserControl1
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
            System.Windows.Forms.Label validityLabel;
            System.Windows.Forms.Label abbrvLabel;
            System.Windows.Forms.Label certificateLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label codeLabel1;
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.certificatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cMSDataSet = new CMS.CMSDataSet();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.certificateTextBox = new System.Windows.Forms.TextBox();
            this.abbrvTextBox = new System.Windows.Forms.TextBox();
            this.validityTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.certView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certificateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abbrv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.empCV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CertificateDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forCertificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cMSDataSet1 = new CMS.CMSDataSet1();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.certEmpView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certificateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.certificationTableAdapter = new CMS.CMSDataSet1TableAdapters.CertificationTableAdapter();
            this.tableAdapterManager1 = new CMS.CMSDataSet1TableAdapters.TableAdapterManager();
            this.forCertificationTableAdapter = new CMS.CMSDataSet1TableAdapters.ForCertificationTableAdapter();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new CMS.CMSDataSet1TableAdapters.EmployeesTableAdapter();
            this.abbrvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certificatesTableAdapter = new CMS.CMSDataSetTableAdapters.CertificatesTableAdapter();
            this.tableAdapterManager = new CMS.CMSDataSetTableAdapters.TableAdapterManager();
            validityLabel = new System.Windows.Forms.Label();
            abbrvLabel = new System.Windows.Forms.Label();
            certificateLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            codeLabel1 = new System.Windows.Forms.Label();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.certificatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forCertificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSet1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.certEmpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // validityLabel
            // 
            validityLabel.AutoSize = true;
            validityLabel.Location = new System.Drawing.Point(2, 109);
            validityLabel.Name = "validityLabel";
            validityLabel.Size = new System.Drawing.Size(84, 13);
            validityLabel.TabIndex = 17;
            validityLabel.Text = "Validity(Months):";
            // 
            // abbrvLabel
            // 
            abbrvLabel.AutoSize = true;
            abbrvLabel.Location = new System.Drawing.Point(48, 83);
            abbrvLabel.Name = "abbrvLabel";
            abbrvLabel.Size = new System.Drawing.Size(38, 13);
            abbrvLabel.TabIndex = 15;
            abbrvLabel.Text = "Abbrv:";
            // 
            // certificateLabel
            // 
            certificateLabel.AutoSize = true;
            certificateLabel.Location = new System.Drawing.Point(29, 57);
            certificateLabel.Name = "certificateLabel";
            certificateLabel.Size = new System.Drawing.Size(57, 13);
            certificateLabel.TabIndex = 13;
            certificateLabel.Text = "Certificate:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(67, 140);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 17;
            idLabel.Text = "Id:";
            // 
            // codeLabel1
            // 
            codeLabel1.AutoSize = true;
            codeLabel1.Location = new System.Drawing.Point(51, 31);
            codeLabel1.Name = "codeLabel1";
            codeLabel1.Size = new System.Drawing.Size(35, 13);
            codeLabel1.TabIndex = 18;
            codeLabel1.Text = "Code:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Controls.Add(this.certView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(732, 416);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Certificate Management";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(codeLabel1);
            this.panel1.Controls.Add(this.codeTextBox);
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(certificateLabel);
            this.panel1.Controls.Add(this.certificateTextBox);
            this.panel1.Controls.Add(abbrvLabel);
            this.panel1.Controls.Add(this.abbrvTextBox);
            this.panel1.Controls.Add(validityLabel);
            this.panel1.Controls.Add(this.validityTextBox);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 211);
            this.panel1.TabIndex = 1;
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.certificatesBindingSource, "Code", true));
            this.codeTextBox.Location = new System.Drawing.Point(93, 28);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.codeTextBox.TabIndex = 19;
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
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.certificatesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(93, 137);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 18;
            // 
            // certificateTextBox
            // 
            this.certificateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.certificatesBindingSource, "Certificate", true));
            this.certificateTextBox.Location = new System.Drawing.Point(93, 54);
            this.certificateTextBox.Name = "certificateTextBox";
            this.certificateTextBox.Size = new System.Drawing.Size(100, 20);
            this.certificateTextBox.TabIndex = 1;
            // 
            // abbrvTextBox
            // 
            this.abbrvTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.abbrvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.certificatesBindingSource, "Abbrv", true));
            this.abbrvTextBox.Location = new System.Drawing.Point(93, 80);
            this.abbrvTextBox.Name = "abbrvTextBox";
            this.abbrvTextBox.Size = new System.Drawing.Size(100, 20);
            this.abbrvTextBox.TabIndex = 2;
            // 
            // validityTextBox
            // 
            this.validityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.certificatesBindingSource, "Validity", true));
            this.validityTextBox.Location = new System.Drawing.Point(92, 106);
            this.validityTextBox.Name = "validityTextBox";
            this.validityTextBox.Size = new System.Drawing.Size(100, 20);
            this.validityTextBox.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(209, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 22);
            this.button4.TabIndex = 7;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // certView
            // 
            this.certView.AllowUserToAddRows = false;
            this.certView.AllowUserToDeleteRows = false;
            this.certView.AllowUserToResizeColumns = false;
            this.certView.AllowUserToResizeRows = false;
            this.certView.AutoGenerateColumns = false;
            this.certView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.certView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.codeDataGridViewTextBoxColumn,
            this.certificateDataGridViewTextBoxColumn,
            this.Abbrv,
            this.validityDataGridViewTextBoxColumn});
            this.certView.DataSource = this.certificatesBindingSource;
            this.certView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.certView.Location = new System.Drawing.Point(6, 216);
            this.certView.Name = "certView";
            this.certView.ReadOnly = true;
            this.certView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.certView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.certView.Size = new System.Drawing.Size(720, 194);
            this.certView.TabIndex = 0;
            this.certView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.certView_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 60;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // certificateDataGridViewTextBoxColumn
            // 
            this.certificateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.certificateDataGridViewTextBoxColumn.DataPropertyName = "Certificate";
            this.certificateDataGridViewTextBoxColumn.HeaderText = "Certificate";
            this.certificateDataGridViewTextBoxColumn.Name = "certificateDataGridViewTextBoxColumn";
            this.certificateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Abbrv
            // 
            this.Abbrv.DataPropertyName = "Abbrv";
            this.Abbrv.HeaderText = "Abbrv";
            this.Abbrv.Name = "Abbrv";
            this.Abbrv.ReadOnly = true;
            // 
            // validityDataGridViewTextBoxColumn
            // 
            this.validityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.validityDataGridViewTextBoxColumn.DataPropertyName = "Validity";
            this.validityDataGridViewTextBoxColumn.HeaderText = "Validity";
            this.validityDataGridViewTextBoxColumn.Name = "validityDataGridViewTextBoxColumn";
            this.validityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.empCV);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(732, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employees for Certication";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // empCV
            // 
            this.empCV.AllowUserToAddRows = false;
            this.empCV.AllowUserToDeleteRows = false;
            this.empCV.AutoGenerateColumns = false;
            this.empCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empCV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.FirstName,
            this.LastName,
            this.CertificateDue,
            this.typeDataGridViewTextBoxColumn1,
            this.remarksDataGridViewTextBoxColumn});
            this.empCV.DataSource = this.forCertificationBindingSource;
            this.empCV.Location = new System.Drawing.Point(6, 66);
            this.empCV.Name = "empCV";
            this.empCV.ReadOnly = true;
            this.empCV.Size = new System.Drawing.Size(720, 344);
            this.empCV.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 50;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // CertificateDue
            // 
            this.CertificateDue.DataPropertyName = "CertificateDue";
            this.CertificateDue.HeaderText = "CertificateDue";
            this.CertificateDue.Name = "CertificateDue";
            this.CertificateDue.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn1
            // 
            this.typeDataGridViewTextBoxColumn1.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn1.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
            this.typeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
            this.remarksDataGridViewTextBoxColumn.Width = 111;
            // 
            // forCertificationBindingSource
            // 
            this.forCertificationBindingSource.DataMember = "ForCertification";
            this.forCertificationBindingSource.DataSource = this.cMSDataSet1;
            // 
            // cMSDataSet1
            // 
            this.cMSDataSet1.DataSetName = "CMSDataSet1";
            this.cMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.certEmpView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(732, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Certified Employees";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // certEmpView
            // 
            this.certEmpView.AllowUserToAddRows = false;
            this.certEmpView.AllowUserToDeleteRows = false;
            this.certEmpView.AutoGenerateColumns = false;
            this.certEmpView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.certEmpView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.certificateDataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.certEmpView.DataSource = this.certificationBindingSource;
            this.certEmpView.Location = new System.Drawing.Point(6, 66);
            this.certEmpView.Name = "certEmpView";
            this.certEmpView.ReadOnly = true;
            this.certEmpView.Size = new System.Drawing.Size(720, 344);
            this.certEmpView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // certificateDataGridViewTextBoxColumn1
            // 
            this.certificateDataGridViewTextBoxColumn1.DataPropertyName = "Certificate";
            this.certificateDataGridViewTextBoxColumn1.HeaderText = "Certificate";
            this.certificateDataGridViewTextBoxColumn1.Name = "certificateDataGridViewTextBoxColumn1";
            this.certificateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn1.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn2.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DateIssued";
            this.dataGridViewTextBoxColumn3.HeaderText = "DateIssued";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ExpiryDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "ExpiryDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // certificationBindingSource
            // 
            this.certificationBindingSource.DataMember = "Certification";
            this.certificationBindingSource.DataSource = this.cMSDataSet1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(740, 442);
            this.tabControl1.TabIndex = 0;
            // 
            // certificationTableAdapter
            // 
            this.certificationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CertificationTableAdapter = this.certificationTableAdapter;
            this.tableAdapterManager1.EmployeesTableAdapter = null;
            this.tableAdapterManager1.ForCertificationTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = CMS.CMSDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // forCertificationTableAdapter
            // 
            this.forCertificationTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.cMSDataSet1;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // abbrvDataGridViewTextBoxColumn
            // 
            this.abbrvDataGridViewTextBoxColumn.DataPropertyName = "Abbrv";
            this.abbrvDataGridViewTextBoxColumn.HeaderText = "Abbrv";
            this.abbrvDataGridViewTextBoxColumn.Name = "abbrvDataGridViewTextBoxColumn";
            this.abbrvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // certificatesTableAdapter
            // 
            this.certificatesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CertificatesTableAdapter = this.certificatesTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CMS.CMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(749, 458);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.tabPage4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.certificatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forCertificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSet1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.certEmpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CMSDataSet cMSDataSet;
        private System.Windows.Forms.BindingSource certificatesBindingSource;
        private CMSDataSetTableAdapters.CertificatesTableAdapter certificatesTableAdapter;
        private CMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox certificateTextBox;
        private System.Windows.Forms.TextBox abbrvTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn abbrvDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView empCV;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView certEmpView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.BindingSource certificationBindingSource;
        private CMSDataSet1 cMSDataSet1;
        private CMSDataSet1TableAdapters.CertificationTableAdapter certificationTableAdapter;
        private CMSDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn certificateDueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource forCertificationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIssuedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateDataGridViewTextBoxColumn;
        private CMSDataSet1TableAdapters.ForCertificationTableAdapter forCertificationTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private CMSDataSet1TableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox validityTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certificateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abbrv;
        private System.Windows.Forms.DataGridViewTextBoxColumn validityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CertificateDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certificateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        public System.Windows.Forms.DataGridView certView;
    }
}
