namespace KhadijehRashid_C968
{
    partial class AddPartForm
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
            lblAddPart = new Label();
            rdoInHouse = new RadioButton();
            rdoOutsourced = new RadioButton();
            lblPartID = new Label();
            lblPartName = new Label();
            lblInventory = new Label();
            lblPrice = new Label();
            lblMax = new Label();
            lblMin = new Label();
            txtPartID = new TextBox();
            txtPartName = new TextBox();
            txtInventory = new TextBox();
            txtPrice = new TextBox();
            txtMax = new TextBox();
            txtMin = new TextBox();
            lblMachineID = new Label();
            txtMachineID = new TextBox();
            btnSavePart = new Button();
            btnCancelPart = new Button();
            SuspendLayout();
            // 
            // lblAddPart
            // 
            lblAddPart.AutoSize = true;
            lblAddPart.Location = new Point(20, 20);
            lblAddPart.Name = "lblAddPart";
            lblAddPart.Size = new Size(104, 32);
            lblAddPart.TabIndex = 0;
            lblAddPart.Text = "Add Part";
            lblAddPart.Click += label1_Click;
            // 
            // rdoInHouse
            // 
            rdoInHouse.AutoSize = true;
            rdoInHouse.Location = new Point(20, 65);
            rdoInHouse.Name = "rdoInHouse";
            rdoInHouse.Size = new Size(143, 36);
            rdoInHouse.TabIndex = 1;
            rdoInHouse.TabStop = true;
            rdoInHouse.Text = "In-House";
            rdoInHouse.UseVisualStyleBackColor = true;
            rdoInHouse.CheckedChanged += rdoInHouse_CheckedChanged;
            // 
            // rdoOutsourced
            // 
            rdoOutsourced.AutoSize = true;
            rdoOutsourced.Location = new Point(170, 65);
            rdoOutsourced.Name = "rdoOutsourced";
            rdoOutsourced.Size = new Size(169, 36);
            rdoOutsourced.TabIndex = 2;
            rdoOutsourced.TabStop = true;
            rdoOutsourced.Text = "Outsourced";
            rdoOutsourced.UseVisualStyleBackColor = true;
            rdoOutsourced.CheckedChanged += rdoOutsourced_CheckedChanged;
            // 
            // lblPartID
            // 
            lblPartID.AutoSize = true;
            lblPartID.Location = new Point(20, 110);
            lblPartID.Name = "lblPartID";
            lblPartID.Size = new Size(37, 32);
            lblPartID.TabIndex = 3;
            lblPartID.Text = "ID";
            // 
            // lblPartName
            // 
            lblPartName.AutoSize = true;
            lblPartName.Location = new Point(20, 155);
            lblPartName.Name = "lblPartName";
            lblPartName.Size = new Size(78, 32);
            lblPartName.TabIndex = 4;
            lblPartName.Text = "Name";
            // 
            // lblInventory
            // 
            lblInventory.AutoSize = true;
            lblInventory.Location = new Point(20, 200);
            lblInventory.Name = "lblInventory";
            lblInventory.Size = new Size(115, 32);
            lblInventory.TabIndex = 5;
            lblInventory.Text = "Inventory";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(20, 245);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(135, 32);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price / Cost";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(20, 290);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(59, 32);
            lblMax.TabIndex = 7;
            lblMax.Text = "Max";
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(20, 335);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(56, 32);
            lblMin.TabIndex = 8;
            lblMin.Text = "MIn";
            // 
            // txtPartID
            // 
            txtPartID.Location = new Point(220, 107);
            txtPartID.Name = "txtPartID";
            txtPartID.ReadOnly = true;
            txtPartID.Size = new Size(200, 39);
            txtPartID.TabIndex = 9;
            // 
            // txtPartName
            // 
            txtPartName.Location = new Point(220, 152);
            txtPartName.Name = "txtPartName";
            txtPartName.Size = new Size(200, 39);
            txtPartName.TabIndex = 10;
            // 
            // txtInventory
            // 
            txtInventory.Location = new Point(220, 197);
            txtInventory.Name = "txtInventory";
            txtInventory.Size = new Size(200, 39);
            txtInventory.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(220, 242);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 39);
            txtPrice.TabIndex = 12;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(220, 287);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(200, 39);
            txtMax.TabIndex = 13;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(220, 332);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(200, 39);
            txtMin.TabIndex = 14;
            // 
            // lblMachineID
            // 
            lblMachineID.AutoSize = true;
            lblMachineID.Location = new Point(20, 380);
            lblMachineID.Name = "lblMachineID";
            lblMachineID.Size = new Size(136, 32);
            lblMachineID.TabIndex = 15;
            lblMachineID.Text = "Machine ID";
            // 
            // txtMachineID
            // 
            txtMachineID.Location = new Point(220, 377);
            txtMachineID.Name = "txtMachineID";
            txtMachineID.Size = new Size(200, 39);
            txtMachineID.TabIndex = 16;
            // 
            // btnSavePart
            // 
            btnSavePart.Location = new Point(110, 430);
            btnSavePart.Name = "btnSavePart";
            btnSavePart.Size = new Size(150, 46);
            btnSavePart.TabIndex = 17;
            btnSavePart.Text = "Save";
            btnSavePart.UseVisualStyleBackColor = true;
            btnSavePart.Click += btnSavePart_Click;
            // 
            // btnCancelPart
            // 
            btnCancelPart.Location = new Point(270, 430);
            btnCancelPart.Name = "btnCancelPart";
            btnCancelPart.Size = new Size(150, 46);
            btnCancelPart.TabIndex = 18;
            btnCancelPart.Text = "Cancel";
            btnCancelPart.UseVisualStyleBackColor = true;
            btnCancelPart.Click += btnCancelPart_Click;
            // 
            // AddPartForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 529);
            Controls.Add(btnCancelPart);
            Controls.Add(btnSavePart);
            Controls.Add(txtMachineID);
            Controls.Add(lblMachineID);
            Controls.Add(txtMin);
            Controls.Add(txtMax);
            Controls.Add(txtPrice);
            Controls.Add(txtInventory);
            Controls.Add(txtPartName);
            Controls.Add(txtPartID);
            Controls.Add(lblMin);
            Controls.Add(lblMax);
            Controls.Add(lblPrice);
            Controls.Add(lblInventory);
            Controls.Add(lblPartName);
            Controls.Add(lblPartID);
            Controls.Add(rdoOutsourced);
            Controls.Add(rdoInHouse);
            Controls.Add(lblAddPart);
            Name = "AddPartForm";
            Text = "Part";
            Load += AddPartForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddPart;
        private RadioButton rdoInHouse;
        private RadioButton rdoOutsourced;
        private Label lblPartID;
        private Label lblPartName;
        private Label lblInventory;
        private Label lblPrice;
        private Label lblMax;
        private Label lblMin;
        private TextBox txtPartID;
        private TextBox txtPartName;
        private TextBox txtInventory;
        private TextBox txtPrice;
        private TextBox txtMax;
        private TextBox txtMin;
        private Label lblMachineID;
        private TextBox txtMachineID;
        private Button btnSavePart;
        private Button btnCancelPart;
    }
}