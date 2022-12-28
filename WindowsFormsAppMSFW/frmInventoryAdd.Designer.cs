
namespace WindowsFormsAppMSFW
{
    partial class frmInventoryAdd
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
            this.textBoxMRP = new System.Windows.Forms.TextBox();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCP = new System.Windows.Forms.Label();
            this.lableIC = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelICValue = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDOP = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTU = new System.Windows.Forms.TextBox();
            this.textBoxAU = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCGST = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSGST = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxIGST = new System.Windows.Forms.TextBox();
            this.labelIGST = new System.Windows.Forms.Label();
            this.textBoxHSN = new System.Windows.Forms.TextBox();
            this.labelHSN = new System.Windows.Forms.Label();
            this.textBoxsizes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxMRP
            // 
            this.textBoxMRP.Location = new System.Drawing.Point(522, 187);
            this.textBoxMRP.Name = "textBoxMRP";
            this.textBoxMRP.Size = new System.Drawing.Size(100, 20);
            this.textBoxMRP.TabIndex = 12;
            // 
            // textBoxRate
            // 
            this.textBoxRate.Location = new System.Drawing.Point(522, 47);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxRate.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "MRP";
            // 
            // labelCP
            // 
            this.labelCP.AutoSize = true;
            this.labelCP.Location = new System.Drawing.Point(420, 47);
            this.labelCP.Name = "labelCP";
            this.labelCP.Size = new System.Drawing.Size(30, 13);
            this.labelCP.TabIndex = 9;
            this.labelCP.Text = "Rate";
            // 
            // lableIC
            // 
            this.lableIC.AutoSize = true;
            this.lableIC.Location = new System.Drawing.Point(45, 44);
            this.lableIC.Name = "lableIC";
            this.lableIC.Size = new System.Drawing.Size(55, 13);
            this.lableIC.TabIndex = 7;
            this.lableIC.Text = "Item Code";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(423, 387);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(285, 387);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelICValue
            // 
            this.labelICValue.AutoSize = true;
            this.labelICValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelICValue.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelICValue.Location = new System.Drawing.Point(139, 42);
            this.labelICValue.Name = "labelICValue";
            this.labelICValue.Size = new System.Drawing.Size(83, 20);
            this.labelICValue.TabIndex = 15;
            this.labelICValue.Text = "Item Code";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(143, 85);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(217, 21);
            this.cmbSupplier.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Supplier";
            // 
            // textBoxMD
            // 
            this.textBoxMD.Location = new System.Drawing.Point(522, 229);
            this.textBoxMD.Name = "textBoxMD";
            this.textBoxMD.Size = new System.Drawing.Size(100, 20);
            this.textBoxMD.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Maximum Discount";
            // 
            // dateTimePickerDOP
            // 
            this.dateTimePickerDOP.Location = new System.Drawing.Point(143, 227);
            this.dateTimePickerDOP.Name = "dateTimePickerDOP";
            this.dateTimePickerDOP.Size = new System.Drawing.Size(217, 20);
            this.dateTimePickerDOP.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Date of Purchase";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Total Units";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Available Units";
            // 
            // textBoxTU
            // 
            this.textBoxTU.Location = new System.Drawing.Point(143, 268);
            this.textBoxTU.Name = "textBoxTU";
            this.textBoxTU.Size = new System.Drawing.Size(52, 20);
            this.textBoxTU.TabIndex = 5;
            // 
            // textBoxAU
            // 
            this.textBoxAU.Location = new System.Drawing.Point(143, 309);
            this.textBoxAU.Name = "textBoxAU";
            this.textBoxAU.Size = new System.Drawing.Size(52, 20);
            this.textBoxAU.TabIndex = 6;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(143, 157);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(217, 64);
            this.textBoxDesc.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Description";
            // 
            // textBoxCGST
            // 
            this.textBoxCGST.Location = new System.Drawing.Point(522, 86);
            this.textBoxCGST.Name = "textBoxCGST";
            this.textBoxCGST.Size = new System.Drawing.Size(100, 20);
            this.textBoxCGST.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(420, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "CGST";
            // 
            // textBoxSGST
            // 
            this.textBoxSGST.Location = new System.Drawing.Point(522, 120);
            this.textBoxSGST.Name = "textBoxSGST";
            this.textBoxSGST.Size = new System.Drawing.Size(100, 20);
            this.textBoxSGST.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(420, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "SGST";
            // 
            // textBoxIGST
            // 
            this.textBoxIGST.Location = new System.Drawing.Point(522, 154);
            this.textBoxIGST.Name = "textBoxIGST";
            this.textBoxIGST.Size = new System.Drawing.Size(100, 20);
            this.textBoxIGST.TabIndex = 11;
            // 
            // labelIGST
            // 
            this.labelIGST.AutoSize = true;
            this.labelIGST.Location = new System.Drawing.Point(420, 157);
            this.labelIGST.Name = "labelIGST";
            this.labelIGST.Size = new System.Drawing.Size(32, 13);
            this.labelIGST.TabIndex = 32;
            this.labelIGST.Text = "IGST";
            // 
            // textBoxHSN
            // 
            this.textBoxHSN.Location = new System.Drawing.Point(143, 123);
            this.textBoxHSN.Name = "textBoxHSN";
            this.textBoxHSN.Size = new System.Drawing.Size(97, 20);
            this.textBoxHSN.TabIndex = 2;
            // 
            // labelHSN
            // 
            this.labelHSN.AutoSize = true;
            this.labelHSN.Location = new System.Drawing.Point(47, 123);
            this.labelHSN.Name = "labelHSN";
            this.labelHSN.Size = new System.Drawing.Size(30, 13);
            this.labelHSN.TabIndex = 34;
            this.labelHSN.Text = "HSN";
            // 
            // textBoxsizes
            // 
            this.textBoxsizes.Location = new System.Drawing.Point(250, 268);
            this.textBoxsizes.Name = "textBoxsizes";
            this.textBoxsizes.Size = new System.Drawing.Size(110, 20);
            this.textBoxsizes.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Sizes";
            // 
            // frmInventoryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxsizes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxHSN);
            this.Controls.Add(this.labelHSN);
            this.Controls.Add(this.textBoxIGST);
            this.Controls.Add(this.labelIGST);
            this.Controls.Add(this.textBoxSGST);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxCGST);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxAU);
            this.Controls.Add(this.textBoxTU);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerDOP);
            this.Controls.Add(this.textBoxMD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.labelICValue);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.textBoxMRP);
            this.Controls.Add(this.textBoxRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCP);
            this.Controls.Add(this.lableIC);
            this.Name = "frmInventoryAdd";
            this.Text = "frmInventoryAdd";
            this.Load += new System.EventHandler(this.frmInventoryAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMRP;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCP;
        private System.Windows.Forms.Label lableIC;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelICValue;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTU;
        private System.Windows.Forms.TextBox textBoxAU;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCGST;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSGST;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxIGST;
        private System.Windows.Forms.Label labelIGST;
        private System.Windows.Forms.TextBox textBoxHSN;
        private System.Windows.Forms.Label labelHSN;
        private System.Windows.Forms.TextBox textBoxsizes;
        private System.Windows.Forms.Label label2;
    }
}