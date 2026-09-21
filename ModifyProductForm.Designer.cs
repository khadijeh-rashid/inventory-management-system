namespace KhadijehRashid_C968
{
    partial class ModifyProductForm
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
            btnSave = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            dataGridViewAssociatedParts = new DataGridView();
            lblAssociatedParts = new Label();
            btnAdd = new Button();
            txtSearchCandidateParts = new TextBox();
            btnSearchCandidateParts = new Button();
            dataGridViewCandidateParts = new DataGridView();
            lblCandidateParts = new Label();
            txtProductMin = new TextBox();
            txtProductMax = new TextBox();
            txtProductPrice = new TextBox();
            txtProductInventory = new TextBox();
            txtProductName = new TextBox();
            txtProductID = new TextBox();
            lblProductMin = new Label();
            lblProductMax = new Label();
            lblProductPrice = new Label();
            lblProductInventory = new Label();
            lblProductName = new Label();
            lblProductID = new Label();
            lblAddProduct = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssociatedParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCandidateParts).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(765, 939);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 45;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(920, 939);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 44;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(920, 884);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 43;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridViewAssociatedParts
            // 
            dataGridViewAssociatedParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAssociatedParts.Location = new Point(590, 574);
            dataGridViewAssociatedParts.Name = "dataGridViewAssociatedParts";
            dataGridViewAssociatedParts.RowHeadersWidth = 82;
            dataGridViewAssociatedParts.Size = new Size(480, 300);
            dataGridViewAssociatedParts.TabIndex = 42;
            // 
            // lblAssociatedParts
            // 
            lblAssociatedParts.AutoSize = true;
            lblAssociatedParts.Location = new Point(590, 539);
            lblAssociatedParts.Name = "lblAssociatedParts";
            lblAssociatedParts.Size = new Size(370, 32);
            lblAssociatedParts.TabIndex = 41;
            lblAssociatedParts.Text = "Parts Associated with this Product";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(920, 464);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 40;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearchCandidateParts
            // 
            txtSearchCandidateParts.Location = new Point(875, 48);
            txtSearchCandidateParts.Name = "txtSearchCandidateParts";
            txtSearchCandidateParts.Size = new Size(200, 39);
            txtSearchCandidateParts.TabIndex = 39;
            // 
            // btnSearchCandidateParts
            // 
            btnSearchCandidateParts.AccessibleRole = AccessibleRole.Document;
            btnSearchCandidateParts.Location = new Point(720, 44);
            btnSearchCandidateParts.Name = "btnSearchCandidateParts";
            btnSearchCandidateParts.Size = new Size(150, 46);
            btnSearchCandidateParts.TabIndex = 38;
            btnSearchCandidateParts.Text = "Search";
            btnSearchCandidateParts.UseVisualStyleBackColor = true;
            btnSearchCandidateParts.Click += btnSearchCandidateParts_Click;
            // 
            // dataGridViewCandidateParts
            // 
            dataGridViewCandidateParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCandidateParts.Location = new Point(590, 149);
            dataGridViewCandidateParts.Name = "dataGridViewCandidateParts";
            dataGridViewCandidateParts.RowHeadersWidth = 82;
            dataGridViewCandidateParts.Size = new Size(480, 300);
            dataGridViewCandidateParts.TabIndex = 37;
            // 
            // lblCandidateParts
            // 
            lblCandidateParts.AutoSize = true;
            lblCandidateParts.Location = new Point(590, 114);
            lblCandidateParts.Name = "lblCandidateParts";
            lblCandidateParts.Size = new Size(213, 32);
            lblCandidateParts.TabIndex = 36;
            lblCandidateParts.Text = "All Candidate Parts";
            // 
            // txtProductMin
            // 
            txtProductMin.Location = new Point(190, 456);
            txtProductMin.Name = "txtProductMin";
            txtProductMin.Size = new Size(200, 39);
            txtProductMin.TabIndex = 35;
            // 
            // txtProductMax
            // 
            txtProductMax.Location = new Point(190, 391);
            txtProductMax.Name = "txtProductMax";
            txtProductMax.Size = new Size(200, 39);
            txtProductMax.TabIndex = 34;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(190, 326);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(200, 39);
            txtProductPrice.TabIndex = 33;
            // 
            // txtProductInventory
            // 
            txtProductInventory.Location = new Point(190, 261);
            txtProductInventory.Name = "txtProductInventory";
            txtProductInventory.Size = new Size(200, 39);
            txtProductInventory.TabIndex = 32;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(190, 196);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(200, 39);
            txtProductName.TabIndex = 31;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(190, 131);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(200, 39);
            txtProductID.TabIndex = 30;
            // 
            // lblProductMin
            // 
            lblProductMin.AutoSize = true;
            lblProductMin.Location = new Point(50, 459);
            lblProductMin.Name = "lblProductMin";
            lblProductMin.Size = new Size(56, 32);
            lblProductMin.TabIndex = 29;
            lblProductMin.Text = "Min";
            // 
            // lblProductMax
            // 
            lblProductMax.AutoSize = true;
            lblProductMax.Location = new Point(50, 394);
            lblProductMax.Name = "lblProductMax";
            lblProductMax.Size = new Size(59, 32);
            lblProductMax.TabIndex = 28;
            lblProductMax.Text = "Max";
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Location = new Point(50, 329);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(121, 32);
            lblProductPrice.TabIndex = 27;
            lblProductPrice.Text = "Price/Cost";
            // 
            // lblProductInventory
            // 
            lblProductInventory.AutoSize = true;
            lblProductInventory.Location = new Point(50, 264);
            lblProductInventory.Name = "lblProductInventory";
            lblProductInventory.Size = new Size(115, 32);
            lblProductInventory.TabIndex = 26;
            lblProductInventory.Text = "Inventory";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(50, 199);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(78, 32);
            lblProductName.TabIndex = 25;
            lblProductName.Text = "Name";
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Location = new Point(50, 134);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(126, 32);
            lblProductID.TabIndex = 24;
            lblProductID.Text = "Product ID";
            // 
            // lblAddProduct
            // 
            lblAddProduct.AutoSize = true;
            lblAddProduct.Location = new Point(50, 44);
            lblAddProduct.Name = "lblAddProduct";
            lblAddProduct.Size = new Size(179, 32);
            lblAddProduct.TabIndex = 23;
            lblAddProduct.Text = "Modify Product";
            // 
            // ModifyProductForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 1029);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(dataGridViewAssociatedParts);
            Controls.Add(lblAssociatedParts);
            Controls.Add(btnAdd);
            Controls.Add(txtSearchCandidateParts);
            Controls.Add(btnSearchCandidateParts);
            Controls.Add(dataGridViewCandidateParts);
            Controls.Add(lblCandidateParts);
            Controls.Add(txtProductMin);
            Controls.Add(txtProductMax);
            Controls.Add(txtProductPrice);
            Controls.Add(txtProductInventory);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Controls.Add(lblProductMin);
            Controls.Add(lblProductMax);
            Controls.Add(lblProductPrice);
            Controls.Add(lblProductInventory);
            Controls.Add(lblProductName);
            Controls.Add(lblProductID);
            Controls.Add(lblAddProduct);
            Name = "ModifyProductForm";
            Text = "Product";
            Load += ModifyProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssociatedParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCandidateParts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private Button btnDelete;
        private DataGridView dataGridViewAssociatedParts;
        private Label lblAssociatedParts;
        private Button btnAdd;
        private TextBox txtSearchCandidateParts;
        private Button btnSearchCandidateParts;
        private DataGridView dataGridViewCandidateParts;
        private Label lblCandidateParts;
        private TextBox txtProductMin;
        private TextBox txtProductMax;
        private TextBox txtProductPrice;
        private TextBox txtProductInventory;
        private TextBox txtProductName;
        private TextBox txtProductID;
        private Label lblProductMin;
        private Label lblProductMax;
        private Label lblProductPrice;
        private Label lblProductInventory;
        private Label lblProductName;
        private Label lblProductID;
        private Label lblAddProduct;
    }
}