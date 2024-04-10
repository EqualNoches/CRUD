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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 92;
            dataGridView1.Size = new Size(2374, 793);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblUpdate
            // 
            lblUpdate.Location = new Point(31, 952);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(313, 90);
            lblUpdate.TabIndex = 1;
            lblUpdate.Text = "Update";
            lblUpdate.UseVisualStyleBackColor = true;
            lblUpdate.Click += lblUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(2092, 952);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(313, 90);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txbFilteredSearch
            // 
            txbFilteredSearch.Location = new Point(1990, 52);
            txbFilteredSearch.Name = "txbFilteredSearch";
            txbFilteredSearch.Size = new Size(192, 43);
            txbFilteredSearch.TabIndex = 3;
            txbFilteredSearch.TextChanged += txbFilteredSearch_TextChanged;
            // 
            // btnFilteredSearch
            // 
            btnFilteredSearch.Location = new Point(2205, 31);
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
            lblId.Location = new Point(1908, 58);
            lblId.Name = "lblId";
            lblId.Size = new Size(49, 37);
            lblId.TabIndex = 5;
            lblId.Text = "ID:";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(31, 31);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(449, 84);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2449, 1063);
            Controls.Add(btnRefresh);
            Controls.Add(lblId);
            Controls.Add(btnFilteredSearch);
            Controls.Add(txbFilteredSearch);
            Controls.Add(btnDelete);
            Controls.Add(lblUpdate);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
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
    }
}