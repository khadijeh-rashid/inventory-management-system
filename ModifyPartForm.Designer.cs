namespace KhadijehRashid_C968
{
    partial class ModifyPartForm
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
            btnCancelPart = new Button();
            btnSavePart = new Button();
            txtMachineID = new TextBox();
            lblMachineID = new Label();
            txtMin = new TextBox();
            txtMax = new TextBox();
            txtPrice = new TextBox();
            txtInventory = new TextBox();
            txtPartName = new TextBox();
            txtPartID = new TextBox();
            lblMin = new Label();
            lblMax = new Label();
            lblPrice = new Label();
            lblInventory = new Label();
            lblPartName = new Label();
            lblPartID = new Label();
            rdoOutsourced = new RadioButton();
            rdoInHouse = new RadioButton();
            lblModifyPart = new Label();
            SuspendLayout();
            // 
            // btnCancelPart
            // 
            btnCancelPart.Location = new Point(287, 446);
            btnCancelPart.Name = "btnCancelPart";
            btnCancelPart.Size = new Size(150, 46);
            btnCancelPart.TabIndex = 37;
            btnCancelPart.Text = "Cancel";
            btnCancelPart.UseVisualStyleBackColor = true;
            btnCancelPart.Click += btnCancelPart_Click;
            // 
            // btnSavePart
            // 
            btnSavePart.Location = new Point(127, 446);
            btnSavePart.Name = "btnSavePart";
            btnSavePart.Size = new Size(150, 46);
            btnSavePart.TabIndex = 36;
            btnSavePart.Text = "Save";
            btnSavePart.UseVisualStyleBackColor = true;
            btnSavePart.Click += btnSavePart_Click;
            // 
            // txtMachineID
            // 
            txtMachineID.Location = new Point(237, 393);
            txtMachineID.Name = "txtMachineID";
            txtMachineID.Size = new Size(200, 39);
            txtMachineID.TabIndex = 35;
            // 
            // lblMachineID
            // 
            lblMachineID.AutoSize = true;
            lblMachineID.Location = new Point(37, 396);
            lblMachineID.Name = "lblMachineID";
            lblMachineID.Size = new Size(136, 32);
            lblMachineID.TabIndex = 34;
            lblMachineID.Text = "Machine ID";
            // 
            // txtMin
            // 
            txtMin.Location = new Point(237, 348);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(200, 39);
            txtMin.TabIndex = 33;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(237, 303);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(200, 39);
            txtMax.TabIndex = 32;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(237, 258);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 39);
            txtPrice.TabIndex = 31;
            // 
            // txtInventory
            // 
            txtInventory.Location = new Point(237, 213);
            txtInventory.Name = "txtInventory";
            txtInventory.Size = new Size(200, 39);
            txtInventory.TabIndex = 30;
            // 
            // txtPartName
            // 
            txtPartName.Location = new Point(237, 168);
            txtPartName.Name = "txtPartName";
            txtPartName.Size = new Size(200, 39);
            txtPartName.TabIndex = 29;
            // 
            // txtPartID
            // 
            txtPartID.Location = new Point(237, 123);
            txtPartID.Name = "txtPartID";
            txtPartID.ReadOnly = true;
            txtPartID.Size = new Size(200, 39);
            txtPartID.TabIndex = 28;
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(37, 351);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(56, 32);
            lblMin.TabIndex = 27;
            lblMin.Text = "MIn";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(37, 306);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(59, 32);
            lblMax.TabIndex = 26;
            lblMax.Text = "Max";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(37, 261);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(135, 32);
            lblPrice.TabIndex = 25;
            lblPrice.Text = "Price / Cost";
            // 
            // lblInventory
            // 
            lblInventory.AutoSize = true;
            lblInventory.Location = new Point(37, 216);
            lblInventory.Name = "lblInventory";
            lblInventory.Size = new Size(115, 32);
            lblInventory.TabIndex = 24;
            lblInventory.Text = "Inventory";
            // 
            // lblPartName
            // 
            lblPartName.AutoSize = true;
            lblPartName.Location = new Point(37, 171);
            lblPartName.Name = "lblPartName";
            lblPartName.Size = new Size(78, 32);
            lblPartName.TabIndex = 23;
            lblPartName.Text = "Name";
            // 
            // lblPartID
            // 
            lblPartID.AutoSize = true;
            lblPartID.Location = new Point(37, 126);
            lblPartID.Name = "lblPartID";
            lblPartID.Size = new Size(37, 32);
            lblPartID.TabIndex = 22;
            lblPartID.Text = "ID";
            // 
            // rdoOutsourced
            // 
            rdoOutsourced.AutoSize = true;
            rdoOutsourced.Location = new Point(187, 81);
            rdoOutsourced.Name = "rdoOutsourced";
            rdoOutsourced.Size = new Size(169, 36);
            rdoOutsourced.TabIndex = 21;
            rdoOutsourced.TabStop = true;
            rdoOutsourced.Text = "Outsourced";
            rdoOutsourced.UseVisualStyleBackColor = true;
            rdoOutsourced.CheckedChanged += rdoOutsourced_CheckedChanged;
            // 
            // rdoInHouse
            // 
            rdoInHouse.AutoSize = true;
            rdoInHouse.Location = new Point(37, 81);
            rdoInHouse.Name = "rdoInHouse";
            rdoInHouse.Size = new Size(143, 36);
            rdoInHouse.TabIndex = 20;
            rdoInHouse.TabStop = true;
            rdoInHouse.Text = "In-House";
            rdoInHouse.UseVisualStyleBackColor = true;
            rdoInHouse.CheckedChanged += rdoInHouse_CheckedChanged;
            // 
            // lblModifyPart
            // 
            lblModifyPart.AutoSize = true;
            lblModifyPart.Location = new Point(37, 36);
            lblModifyPart.Name = "lblModifyPart";
            lblModifyPart.Size = new Size(137, 32);
            lblModifyPart.TabIndex = 19;
            lblModifyPart.Text = "Modify Part";
            // 
            // ModifyPartForm
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
            Controls.Add(lblModifyPart);
            Name = "ModifyPartForm";
            Text = "Part";
            Load += ModifyPartForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelPart;
        private Button btnSavePart;
        private TextBox txtMachineID;
        private Label lblMachineID;
        private TextBox txtMin;
        private TextBox txtMax;
        private TextBox txtPrice;
        private TextBox txtInventory;
        private TextBox txtPartName;
        private TextBox txtPartID;
        private Label lblMin;
        private Label lblMax;
        private Label lblPrice;
        private Label lblInventory;
        private Label lblPartName;
        private Label lblPartID;
        private RadioButton rdoOutsourced;
        private RadioButton rdoInHouse;
        private Label lblModifyPart;
    }
}