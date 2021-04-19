
namespace CMS
{
    partial class UserControl3
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
            System.Windows.Forms.Label remarksLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label certificateDueLabel;
            this.forCertificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cMSDataSet1 = new CMS.CMSDataSet1();
            this.forCertificationTableAdapter = new CMS.CMSDataSet1TableAdapters.ForCertificationTableAdapter();
            this.tableAdapterManager = new CMS.CMSDataSet1TableAdapters.TableAdapterManager();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CertificateDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fcertView = new System.Windows.Forms.DataGridView();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.firstNameComboBox = new System.Windows.Forms.ComboBox();
            this.lastNameComboBox = new System.Windows.Forms.ComboBox();
            this.abbrvComboBox = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.certificateDueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.certificatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cMSDataSet = new CMS.CMSDataSet();
            this.certificatesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new CMS.CMSDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager1 = new CMS.CMSDataSetTableAdapters.TableAdapterManager();
            this.certificatesTableAdapter = new CMS.CMSDataSetTableAdapters.CertificatesTableAdapter();
            remarksLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            certificateDueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.forCertificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fcertView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificatesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // forCertificationTableAdapter
            // 
            this.forCertificationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CertificationTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.ForCertificationTableAdapter = this.forCertificationTableAdapter;
            this.tableAdapterManager.UpdateOrder = CMS.CMSDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CertificateDue
            // 
            this.CertificateDue.DataPropertyName = "CertificateDue";
            this.CertificateDue.HeaderText = "CertificateDue";
            this.CertificateDue.Name = "CertificateDue";
            this.CertificateDue.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // fcertView
            // 
            this.fcertView.AllowUserToAddRows = false;
            this.fcertView.AllowUserToDeleteRows = false;
            this.fcertView.AutoGenerateColumns = false;
            this.fcertView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fcertView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.FirstName,
            this.LastName,
            this.CertificateDue,
            this.typeDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.fcertView.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.forCertificationBindingSource, "Id", true));
            this.fcertView.DataSource = this.forCertificationBindingSource;
            this.fcertView.Location = new System.Drawing.Point(15, 190);
            this.fcertView.Name = "fcertView";
            this.fcertView.ReadOnly = true;
            this.fcertView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fcertView.Size = new System.Drawing.Size(768, 284);
            this.fcertView.TabIndex = 0;
            this.fcertView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fcertView_CellClick);
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forCertificationBindingSource, "Remarks", true));
            this.remarksTextBox.Location = new System.Drawing.Point(99, 135);
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(200, 20);
            this.remarksTextBox.TabIndex = 12;
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Location = new System.Drawing.Point(41, 138);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(52, 13);
            remarksLabel.TabIndex = 11;
            remarksLabel.Text = "Remarks:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(58, 113);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 9;
            typeLabel.Text = "Type:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // firstNameComboBox
            // 
            this.firstNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.firstNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.firstNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "FirstName", true));
            this.firstNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.forCertificationBindingSource, "FirstName", true));
            this.firstNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.forCertificationBindingSource, "Id", true));
            this.firstNameComboBox.FormattingEnabled = true;
            this.firstNameComboBox.Location = new System.Drawing.Point(99, 24);
            this.firstNameComboBox.Name = "firstNameComboBox";
            this.firstNameComboBox.Size = new System.Drawing.Size(200, 21);
            this.firstNameComboBox.TabIndex = 16;
            this.firstNameComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.firstNameComboBox_KeyUp);
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(32, 27);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 15;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameComboBox
            // 
            this.lastNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lastNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lastNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "LastName", true));
            this.lastNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.forCertificationBindingSource, "LastName", true));
            this.lastNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.forCertificationBindingSource, "Id", true));
            this.lastNameComboBox.FormattingEnabled = true;
            this.lastNameComboBox.Location = new System.Drawing.Point(99, 57);
            this.lastNameComboBox.MaxDropDownItems = 10;
            this.lastNameComboBox.Name = "lastNameComboBox";
            this.lastNameComboBox.Size = new System.Drawing.Size(200, 21);
            this.lastNameComboBox.TabIndex = 17;
            this.lastNameComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lastNameComboBox_KeyUp);
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(31, 60);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 16;
            lastNameLabel.Text = "Last Name:";
            // 
            // abbrvComboBox
            // 
            this.abbrvComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.abbrvComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.abbrvComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.certificatesBindingSource, "Abbrv", true));
            this.abbrvComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.certificatesBindingSource1, "Abbrv", true));
            this.abbrvComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.certificatesBindingSource, "Code", true));
            this.abbrvComboBox.FormattingEnabled = true;
            this.abbrvComboBox.Location = new System.Drawing.Point(99, 109);
            this.abbrvComboBox.Name = "abbrvComboBox";
            this.abbrvComboBox.Size = new System.Drawing.Size(200, 21);
            this.abbrvComboBox.TabIndex = 18;
            this.abbrvComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.abbrvComboBox_KeyUp);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(305, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forCertificationBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(330, 24);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 20;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(305, 27);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 19;
            idLabel.Text = "Id:";
            // 
            // certificateDueDateTimePicker
            // 
            this.certificateDueDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.forCertificationBindingSource, "CertificateDue", true));
            this.certificateDueDateTimePicker.Location = new System.Drawing.Point(99, 84);
            this.certificateDueDateTimePicker.Name = "certificateDueDateTimePicker";
            this.certificateDueDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.certificateDueDateTimePicker.TabIndex = 21;
            // 
            // certificateDueLabel
            // 
            certificateDueLabel.AutoSize = true;
            certificateDueLabel.Location = new System.Drawing.Point(12, 88);
            certificateDueLabel.Name = "certificateDueLabel";
            certificateDueLabel.Size = new System.Drawing.Size(80, 13);
            certificateDueLabel.TabIndex = 20;
            certificateDueLabel.Text = "Certificate Due:";
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
            // certificatesBindingSource1
            // 
            this.certificatesBindingSource1.DataMember = "Certificates";
            this.certificatesBindingSource1.DataSource = this.cMSDataSet;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.cMSDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CertificatesTableAdapter = null;
            this.tableAdapterManager1.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager1.UpdateOrder = CMS.CMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // certificatesTableAdapter
            // 
            this.certificatesTableAdapter.ClearBeforeFill = true;
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(certificateDueLabel);
            this.Controls.Add(this.certificateDueDateTimePicker);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.abbrvComboBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameComboBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameComboBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(typeLabel);
            this.Controls.Add(remarksLabel);
            this.Controls.Add(this.remarksTextBox);
            this.Controls.Add(this.fcertView);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(803, 509);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.forCertificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fcertView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificatesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certificateDueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource forCertificationBindingSource;
        private CMSDataSet1 cMSDataSet1;
        private CMSDataSet1TableAdapters.ForCertificationTableAdapter forCertificationTableAdapter;
        private CMSDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private CMSDataSet cMSDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private CMSDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private CMSDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource certificatesBindingSource;
        private CMSDataSetTableAdapters.CertificatesTableAdapter certificatesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CertificateDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView fcertView;
        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox firstNameComboBox;
        private System.Windows.Forms.ComboBox lastNameComboBox;
        private System.Windows.Forms.ComboBox abbrvComboBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker certificateDueDateTimePicker;
        private System.Windows.Forms.BindingSource certificatesBindingSource1;
    }
}
