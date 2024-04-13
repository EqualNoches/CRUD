namespace CRUD
{
    partial class SearchForm
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
            dataGridView1 = new DataGridView();
            bindingSource1 = new BindingSource(components);
            lblUpdate = new Button();
            btnDelete = new Button();
            txbFilteredSearch = new TextBox();
            btnFilteredSearch = new Button();
            lblId = new Label();
            btnRefresh = new Button();
            txbID = new TextBox();
            mtxbPhoneNumber = new MaskedTextBox();
            cmbPais = new ComboBox();
            txbEmail = new TextBox();
            rdbFemale = new RadioButton();
            rdbMale = new RadioButton();
            dtpBirthday = new DateTimePicker();
            txbLastName = new TextBox();
            txbFirstName = new TextBox();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            lblNationality = new Label();
            lblBirthday = new Label();
            lblGender = new Label();
            lblLastName = new Label();
            lblName = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(806, 149);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 92;
            dataGridView1.Size = new Size(2033, 787);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // lblUpdate
            // 
            lblUpdate.Location = new Point(806, 983);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(313, 90);
            lblUpdate.TabIndex = 1;
            lblUpdate.Text = "Update";
            lblUpdate.UseVisualStyleBackColor = true;
            lblUpdate.Click += lblUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(2526, 973);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(313, 90);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txbFilteredSearch
            // 
            txbFilteredSearch.Location = new Point(2401, 42);
            txbFilteredSearch.Name = "txbFilteredSearch";
            txbFilteredSearch.Size = new Size(192, 43);
            txbFilteredSearch.TabIndex = 3;
            txbFilteredSearch.TextChanged += txbFilteredSearch_TextChanged;
            // 
            // btnFilteredSearch
            // 
            btnFilteredSearch.Location = new Point(2639, 21);
            btnFilteredSearch.Name = "btnFilteredSearch";
            btnFilteredSearch.Size = new Size(200, 84);
            btnFilteredSearch.TabIndex = 4;
            btnFilteredSearch.Text = "Search";
            btnFilteredSearch.UseVisualStyleBackColor = true;
            btnFilteredSearch.Click += btnFilteredSearch_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(2321, 45);
            lblId.Name = "lblId";
            lblId.Size = new Size(49, 37);
            lblId.TabIndex = 5;
            lblId.Text = "ID:";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(2009, 32);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(210, 63);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txbID
            // 
            txbID.Location = new Point(150, 983);
            txbID.Name = "txbID";
            txbID.ReadOnly = true;
            txbID.Size = new Size(105, 43);
            txbID.TabIndex = 42;
            // 
            // mtxbPhoneNumber
            // 
            mtxbPhoneNumber.Location = new Point(298, 685);
            mtxbPhoneNumber.Mask = "(999) 000-0000";
            mtxbPhoneNumber.Name = "mtxbPhoneNumber";
            mtxbPhoneNumber.Size = new Size(339, 43);
            mtxbPhoneNumber.TabIndex = 40;
            mtxbPhoneNumber.TextChanged += mtxbPhoneNumber_TextChanged;
            // 
            // cmbPais
            // 
            cmbPais.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPais.FormattingEnabled = true;
            cmbPais.Location = new Point(298, 554);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(339, 45);
            cmbPais.Sorted = true;
            cmbPais.TabIndex = 39;
            cmbPais.SelectedIndexChanged += cmbPais_SelectedIndexChanged;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(298, 826);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(313, 43);
            txbEmail.TabIndex = 36;
            txbEmail.TextChanged += txbEmail_TextChanged;
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Location = new Point(478, 299);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(133, 41);
            rdbFemale.TabIndex = 34;
            rdbFemale.Text = "Female";
            rdbFemale.UseVisualStyleBackColor = true;
            rdbFemale.CheckedChanged += rdbFemale_CheckedChanged;
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Checked = true;
            rdbMale.Location = new Point(298, 297);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(107, 41);
            rdbMale.TabIndex = 33;
            rdbMale.TabStop = true;
            rdbMale.Text = "Male";
            rdbMale.UseVisualStyleBackColor = true;
            rdbMale.CheckedChanged += rdbMale_CheckedChanged;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(298, 422);
            dtpBirthday.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dtpBirthday.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(430, 43);
            dtpBirthday.TabIndex = 35;
            dtpBirthday.ValueChanged += dtpBirthday_ValueChanged;
            // 
            // txbLastName
            // 
            txbLastName.Location = new Point(298, 194);
            txbLastName.Name = "txbLastName";
            txbLastName.Size = new Size(313, 43);
            txbLastName.TabIndex = 32;
            txbLastName.TextChanged += txbLastName_TextChanged;
            // 
            // txbFirstName
            // 
            txbFirstName.Location = new Point(298, 84);
            txbFirstName.Name = "txbFirstName";
            txbFirstName.Size = new Size(313, 43);
            txbFirstName.TabIndex = 31;
            txbFirstName.TextChanged += txbFirstName_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(41, 826);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(82, 37);
            lblEmail.TabIndex = 30;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(35, 691);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(196, 37);
            lblPhoneNumber.TabIndex = 29;
            lblPhoneNumber.Text = "Phone Number";
            lblPhoneNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.Location = new Point(35, 562);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(244, 37);
            lblNationality.TabIndex = 28;
            lblNationality.Text = "Pais de Nacimiento";
            lblNationality.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(41, 422);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(115, 37);
            lblBirthday.TabIndex = 27;
            lblBirthday.Text = "Birthday";
            lblBirthday.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(41, 299);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(104, 37);
            lblGender.TabIndex = 26;
            lblGender.Text = "Gender";
            lblGender.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(41, 194);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(142, 37);
            lblLastName.TabIndex = 25;
            lblLastName.Text = "Last Name";
            lblLastName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(41, 84);
            lblName.Name = "lblName";
            lblName.Size = new Size(144, 37);
            lblName.TabIndex = 24;
            lblName.Text = "First Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 983);
            label1.Name = "label1";
            label1.Size = new Size(49, 37);
            label1.TabIndex = 43;
            label1.Text = "ID:";
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2865, 1085);
            Controls.Add(label1);
            Controls.Add(txbID);
            Controls.Add(mtxbPhoneNumber);
            Controls.Add(cmbPais);
            Controls.Add(txbEmail);
            Controls.Add(rdbFemale);
            Controls.Add(rdbMale);
            Controls.Add(dtpBirthday);
            Controls.Add(txbLastName);
            Controls.Add(txbFirstName);
            Controls.Add(lblEmail);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblNationality);
            Controls.Add(lblBirthday);
            Controls.Add(lblGender);
            Controls.Add(lblLastName);
            Controls.Add(lblName);
            Controls.Add(btnRefresh);
            Controls.Add(lblId);
            Controls.Add(btnFilteredSearch);
            Controls.Add(txbFilteredSearch);
            Controls.Add(btnDelete);
            Controls.Add(lblUpdate);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "SearchForm";
            Text = "SearchForm";
            Load += SearchForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private Button lblUpdate;
        private Button btnDelete;
        private TextBox txbFilteredSearch;
        private Button btnFilteredSearch;
        private Label lblId;
        private Button btnRefresh;
        private TextBox txbID;
        private MaskedTextBox mtxbPhoneNumber;
        private ComboBox cmbPais;
        private TextBox txbEmail;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private DateTimePicker dtpBirthday;
        private TextBox txbLastName;
        private TextBox txbFirstName;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Label lblNationality;
        private Label lblBirthday;
        private Label lblGender;
        private Label lblLastName;
        private Label lblName;
        private Label label1;
    }
}