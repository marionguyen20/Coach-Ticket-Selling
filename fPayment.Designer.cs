namespace TicketSelling
{
    partial class fPayment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pOK = new System.Windows.Forms.Panel();
            this.btnPay = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lbType = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbBank = new System.Windows.Forms.TextBox();
            this.lbBank = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbCardNum = new System.Windows.Forms.TextBox();
            this.lbCardNum = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPay = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pOK.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pOK);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 520);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbPrice);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(6, 363);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(469, 65);
            this.panel3.TabIndex = 4;
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(262, 18);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(176, 29);
            this.tbPrice.TabIndex = 4;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL PRICE";
            // 
            // pOK
            // 
            this.pOK.Controls.Add(this.btnPay);
            this.pOK.Location = new System.Drawing.Point(6, 434);
            this.pOK.Name = "pOK";
            this.pOK.Size = new System.Drawing.Size(497, 69);
            this.pOK.TabIndex = 3;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(179, 10);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(112, 52);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "PAYING";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(3, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(472, 298);
            this.panel5.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.cbType);
            this.panel10.Controls.Add(this.lbType);
            this.panel10.Location = new System.Drawing.Point(3, 237);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(441, 45);
            this.panel10.TabIndex = 4;
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Credit Card",
            "Debit Card",
            "Other"});
            this.cbType.Location = new System.Drawing.Point(147, 9);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 28);
            this.cbType.TabIndex = 1;
            this.cbType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbType_KeyDown);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(1, 13);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(98, 19);
            this.lbType.TabIndex = 0;
            this.lbType.Text = "CARD TYPE";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.tbBank);
            this.panel9.Controls.Add(this.lbBank);
            this.panel9.Location = new System.Drawing.Point(3, 159);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(441, 52);
            this.panel9.TabIndex = 3;
            // 
            // tbBank
            // 
            this.tbBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBank.Location = new System.Drawing.Point(147, 9);
            this.tbBank.Name = "tbBank";
            this.tbBank.Size = new System.Drawing.Size(294, 26);
            this.tbBank.TabIndex = 1;
            // 
            // lbBank
            // 
            this.lbBank.AutoSize = true;
            this.lbBank.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBank.Location = new System.Drawing.Point(3, 16);
            this.lbBank.Name = "lbBank";
            this.lbBank.Size = new System.Drawing.Size(55, 19);
            this.lbBank.TabIndex = 0;
            this.lbBank.Text = "BANK";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tbCardNum);
            this.panel8.Controls.Add(this.lbCardNum);
            this.panel8.Location = new System.Drawing.Point(3, 91);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(441, 45);
            this.panel8.TabIndex = 2;
            // 
            // tbCardNum
            // 
            this.tbCardNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCardNum.Location = new System.Drawing.Point(147, 6);
            this.tbCardNum.Name = "tbCardNum";
            this.tbCardNum.Size = new System.Drawing.Size(294, 26);
            this.tbCardNum.TabIndex = 1;
            this.tbCardNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCardNum_KeyPress);
            // 
            // lbCardNum
            // 
            this.lbCardNum.AutoSize = true;
            this.lbCardNum.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCardNum.Location = new System.Drawing.Point(3, 15);
            this.lbCardNum.Name = "lbCardNum";
            this.lbCardNum.Size = new System.Drawing.Size(125, 17);
            this.lbCardNum.TabIndex = 0;
            this.lbCardNum.Text = "CARD NUMBER";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tbName);
            this.panel7.Controls.Add(this.lbName);
            this.panel7.Location = new System.Drawing.Point(3, 14);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(441, 54);
            this.panel7.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(147, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(291, 26);
            this.tbName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(3, 12);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(101, 19);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "FULL NAME";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbPay);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 40);
            this.panel2.TabIndex = 1;
            // 
            // lbPay
            // 
            this.lbPay.AutoSize = true;
            this.lbPay.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPay.Location = new System.Drawing.Point(134, 6);
            this.lbPay.Name = "lbPay";
            this.lbPay.Size = new System.Drawing.Size(204, 26);
            this.lbPay.TabIndex = 0;
            this.lbPay.Text = "YOUR PAYMENT";
            this.lbPay.Click += new System.EventHandler(this.lbPay_Click);
            // 
            // fPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 544);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAYMENT";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pOK.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbPay;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox tbBank;
        private System.Windows.Forms.Label lbBank;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox tbCardNum;
        private System.Windows.Forms.Label lbCardNum;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel pOK;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.ComboBox cbType;
    }
}