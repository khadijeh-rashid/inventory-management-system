namespace KhadijehRashid_C968
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblParts = new Label();
            btnSearchParts = new Button();
            txtSearchParts = new TextBox();
            dataGridViewParts = new DataGridView();
            btnAddPart = new Button();
            btnModifyPart = new Button();
            btnDeletePart = new Button();
            btnExit = new Button();
            lblProducts = new Label();
            btnSearchProducts = new Button();
            txtSearchProducts = new TextBox();
            dataGridViewProducts = new DataGridView();
            btnAddProduct = new Button();
            btnModifyProduct = new Button();
            btnDeleteProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(348, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Inventory Management System";
            // 
            // lblParts
            // 
            lblParts.AutoSize = true;
            lblParts.Location = new Point(20, 65);
            lblParts.Name = "lblParts";
            lblParts.Size = new Size(64, 32);
            lblParts.TabIndex = 1;
            lblParts.Text = "Parts";
            // 
            // btnSearchParts
            // 
            btnSearchParts.AutoSize = true;
            btnSearchParts.Location = new Point(235, 103);
            btnSearchParts.Name = "btnSearchParts";
            btnSearchParts.Size = new Size(109, 42);
            btnSearchParts.TabIndex = 2;
            btnSearchParts.Text = "Search";
            btnSearchParts.UseVisualStyleBackColor = true;
            btnSearchParts.Click += btnSearchParts_Click;
            // 
            // txtSearchParts
            // 
            txtSearchParts.Location = new Point(20, 105);
            txtSearchParts.Name = "txtSearchParts";
            txtSearchParts.Size = new Size(200, 39);
            txtSearchParts.TabIndex = 3;
            // 
            // dataGridViewParts
            // 
            dataGridViewParts.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewParts.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewParts.Location = new Point(20, 155);
            dataGridViewParts.MultiSelect = false;
            dataGridViewParts.Name = "dataGridViewParts";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewParts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewParts.RowHeadersWidth = 82;
            dataGridViewParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewParts.Size = new Size(480, 300);
            dataGridViewParts.TabIndex = 4;
            // 
            // btnAddPart
            // 
            btnAddPart.Location = new Point(20, 470);
            btnAddPart.Name = "btnAddPart";
            btnAddPart.Size = new Size(150, 46);
            btnAddPart.TabIndex = 5;
            btnAddPart.Text = "Add";
            btnAddPart.UseVisualStyleBackColor = true;
            btnAddPart.Click += btnAddPart_Click;
            // 
            // btnModifyPart
            // 
            btnModifyPart.Location = new Point(185, 470);
            btnModifyPart.Name = "btnModifyPart";
            btnModifyPart.Size = new Size(150, 46);
            btnModifyPart.TabIndex = 6;
            btnModifyPart.Text = "Modify";
            btnModifyPart.UseVisualStyleBackColor = true;
            btnModifyPart.Click += btnModifyPart_Click;
            // 
            // btnDeletePart
            // 
            btnDeletePart.Location = new Point(350, 470);
            btnDeletePart.Name = "btnDeletePart";
            btnDeletePart.Size = new Size(150, 46);
            btnDeletePart.TabIndex = 7;
            btnDeletePart.Text = "Delete";
            btnDeletePart.UseVisualStyleBackColor = true;
            btnDeletePart.Click += btnDeletePart_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(860, 525);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 46);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Location = new Point(530, 65);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(106, 32);
            lblProducts.TabIndex = 9;
            lblProducts.Text = "Products";
            // 
            // btnSearchProducts
            // 
            btnSearchProducts.Location = new Point(745, 103);
            btnSearchProducts.Name = "btnSearchProducts";
            btnSearchProducts.Size = new Size(150, 46);
            btnSearchProducts.TabIndex = 10;
            btnSearchProducts.Text = "Search";
            btnSearchProducts.UseVisualStyleBackColor = true;
            btnSearchProducts.Click += btnSearchProducts_Click;
            // 
            // txtSearchProducts
            // 
            txtSearchProducts.Location = new Point(530, 105);
            txtSearchProducts.Name = "txtSearchProducts";
            txtSearchProducts.Size = new Size(200, 39);
            txtSearchProducts.TabIndex = 11;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewProducts.Location = new Point(530, 155);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewProducts.RowHeadersWidth = 82;
            dataGridViewProducts.Size = new Size(480, 300);
            dataGridViewProducts.TabIndex = 12;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(530, 470);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(150, 46);
            btnAddProduct.TabIndex = 13;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnModifyProduct
            // 
            btnModifyProduct.Location = new Point(695, 470);
            btnModifyProduct.Name = "btnModifyProduct";
            btnModifyProduct.Size = new Size(150, 46);
            btnModifyProduct.TabIndex = 14;
            btnModifyProduct.Text = "Modify";
            btnModifyProduct.UseVisualStyleBackColor = true;
            btnModifyProduct.Click += btnModifyProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(860, 470);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(150, 46);
            btnDeleteProduct.TabIndex = 15;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 579);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnModifyProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(dataGridViewProducts);
            Controls.Add(txtSearchProducts);
            Controls.Add(btnSearchProducts);
            Controls.Add(lblProducts);
            Controls.Add(btnExit);
            Controls.Add(btnDeletePart);
            Controls.Add(btnModifyPart);
            Controls.Add(btnAddPart);
            Controls.Add(dataGridViewParts);
            Controls.Add(txtSearchParts);
            Controls.Add(btnSearchParts);
            Controls.Add(lblParts);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Screen";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblParts;
        private Button btnSearchParts;
        private TextBox txtSearchParts;
        private DataGridView dataGridViewParts;
        private Button btnAddPart;
        private Button btnModifyPart;
        private Button btnDeletePart;
        private Button btnExit;
        private Label lblProducts;
        private Button btnSearchProducts;
        private TextBox txtSearchProducts;
        private DataGridView dataGridViewProducts;
        private Button btnAddProduct;
        private Button btnModifyProduct;
        private Button btnDeleteProduct;
    }
}
