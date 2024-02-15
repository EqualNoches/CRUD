namespace SwimsuitSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            lblName = new Label();
            lblLastName = new Label();
            lblGender = new Label();
            lblBirthday = new Label();
            lblNationality = new Label();
            lblPhoneNumber = new Label();
            lblEmail = new Label();
            txbFirstName = new TextBox();
            txbLastName = new TextBox();
            dtpBirthday = new DateTimePicker();
            rdbMale = new RadioButton();
            rdbFemale = new RadioButton();
            txbPhoneNumber = new TextBox();
            txbEmail = new TextBox();
            btnSubmit = new Button();
            btnExit = new Button();
            cmbPais = new ComboBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(40, 74);
            lblName.Name = "lblName";
            lblName.Size = new Size(144, 37);
            lblName.TabIndex = 0;
            lblName.Text = "First Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(40, 184);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(142, 37);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name";
            lblLastName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(40, 289);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(104, 37);
            lblGender.TabIndex = 3;
            lblGender.Text = "Gender";
            lblGender.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(40, 412);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(115, 37);
            lblBirthday.TabIndex = 4;
            lblBirthday.Text = "Birthday";
            lblBirthday.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.Location = new Point(34, 552);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(258, 37);
            lblNationality.TabIndex = 5;
            lblNationality.Text = "Pais de Naciemiento";
            lblNationality.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(34, 681);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(196, 37);
            lblPhoneNumber.TabIndex = 8;
            lblPhoneNumber.Text = "Phone Number";
            lblPhoneNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(40, 816);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(82, 37);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbFirstName
            // 
            txbFirstName.Location = new Point(297, 74);
            txbFirstName.Name = "txbFirstName";
            txbFirstName.Size = new Size(313, 43);
            txbFirstName.TabIndex = 10;
            txbFirstName.TextChanged += txbFirstName_TextChanged;
            // 
            // txbLastName
            // 
            txbLastName.Location = new Point(297, 184);
            txbLastName.Name = "txbLastName";
            txbLastName.Size = new Size(313, 43);
            txbLastName.TabIndex = 11;
            txbLastName.TextChanged += txbLastName_TextChanged;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(297, 412);
            dtpBirthday.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dtpBirthday.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(430, 43);
            dtpBirthday.TabIndex = 14;
            dtpBirthday.ValueChanged += dtpBirthday_ValueChanged;
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Location = new Point(297, 287);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(107, 41);
            rdbMale.TabIndex = 12;
            rdbMale.TabStop = true;
            rdbMale.Text = "Male";
            rdbMale.UseVisualStyleBackColor = true;
            rdbMale.CheckedChanged += rdbMale_CheckedChanged;
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Location = new Point(477, 289);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(133, 41);
            rdbFemale.TabIndex = 13;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "Female";
            rdbFemale.UseVisualStyleBackColor = true;
            rdbFemale.CheckedChanged += rdbFemale_CheckedChanged;
            // 
            // txbPhoneNumber
            // 
            txbPhoneNumber.Location = new Point(297, 681);
            txbPhoneNumber.Name = "txbPhoneNumber";
            txbPhoneNumber.Size = new Size(313, 43);
            txbPhoneNumber.TabIndex = 16;
            txbPhoneNumber.TextChanged += txbPhoneNumber_TextChanged;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(297, 816);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(313, 43);
            txbEmail.TabIndex = 17;
            txbEmail.TextChanged += txbEmail_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(619, 1005);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(220, 76);
            btnSubmit.TabIndex = 18;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(34, 994);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(226, 76);
            btnExit.TabIndex = 19;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // cmbPais
            // 
            cmbPais.FormattingEnabled = true;
            cmbPais.Location = new Point(297, 544);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(339, 45);
            cmbPais.TabIndex = 20;            
            //
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 1111);
            Controls.Add(cmbPais);
            Controls.Add(btnExit);
            Controls.Add(btnSubmit);
            Controls.Add(txbEmail);
            Controls.Add(txbPhoneNumber);
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
            Name = "Form1";
            Text = "Swim Suit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblLastName;
        private Label lblGender;
        private Label lblBirthday;
        private Label lblNationality;
        private Label lblPhoneNumber;
        private Label lblEmail;
        private TextBox txbFirstName;
        private TextBox txbLastName;
        private DateTimePicker dtpBirthday;
        private RadioButton rdbMale;
        private RadioButton rdbFemale;
        private TextBox txbPhoneNumber;
        private TextBox txbEmail;
        private Button btnSubmit;
        private Button btnExit;
        private ComboBox cmbPais;
    }
}
