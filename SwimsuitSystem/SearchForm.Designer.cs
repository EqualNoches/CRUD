namespace SwimsuitSystem
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
            btnSearch = new Button();
            rtxbSearchBar = new RichTextBox();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1662, 96);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(314, 80);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // rtxbSearchBar
            // 
            rtxbSearchBar.Location = new Point(156, 96);
            rtxbSearchBar.MaxLength = 20;
            rtxbSearchBar.Multiline = false;
            rtxbSearchBar.Name = "rtxbSearchBar";
            rtxbSearchBar.Size = new Size(1486, 80);
            rtxbSearchBar.TabIndex = 2;
            rtxbSearchBar.Text = "";
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1988, 911);
            Controls.Add(rtxbSearchBar);
            Controls.Add(btnSearch);
            Name = "SearchForm";
            Text = "SearchForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSearch;
        private RichTextBox rtxbSearchBar;
    }
}