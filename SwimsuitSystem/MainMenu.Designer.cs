namespace SwimsuitSystem
{
    partial class MainMenu
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
            btnNewUser = new Button();
            label1 = new Label();
            btnSearch = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // btnNewUser
            // 
            btnNewUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewUser.Location = new Point(159, 170);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(791, 91);
            btnNewUser.TabIndex = 0;
            btnNewUser.Text = "New User";
            btnNewUser.UseVisualStyleBackColor = true;
            btnNewUser.Click += btnNewUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(401, 53);
            label1.Name = "label1";
            label1.Size = new Size(285, 55);
            label1.TabIndex = 3;
            label1.Text = "SWIM SUIT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(159, 327);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(791, 91);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search User";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(159, 484);
            button3.Name = "button3";
            button3.Size = new Size(791, 91);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(25, 643);
            button4.Name = "button4";
            button4.Size = new Size(209, 58);
            button4.TabIndex = 6;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1086, 713);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(btnNewUser);
            ForeColor = SystemColors.ControlText;
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewUser;
        private Label label1;
        private Button btnSearch;
        private Button button3;
        private Button button4;
    }
}