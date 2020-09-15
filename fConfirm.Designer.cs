namespace TicketSelling
{
    partial class fConfirm
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
            this.pOK = new System.Windows.Forms.Panel();
            this.btnCf = new System.Windows.Forms.Button();
            this.pAmount = new System.Windows.Forms.Panel();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutTicket = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pOK.SuspendLayout();
            this.pAmount.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pOK);
            this.panel1.Controls.Add(this.pAmount);
            this.panel1.Controls.Add(this.flowLayoutTicket);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 725);
            this.panel1.TabIndex = 0;
            // 
            // pOK
            // 
            this.pOK.Controls.Add(this.btnCf);
            this.pOK.Location = new System.Drawing.Point(13, 655);
            this.pOK.Name = "pOK";
            this.pOK.Size = new System.Drawing.Size(376, 67);
            this.pOK.TabIndex = 2;
            // 
            // btnCf
            // 
            this.btnCf.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCf.Location = new System.Drawing.Point(122, 12);
            this.btnCf.Name = "btnCf";
            this.btnCf.Size = new System.Drawing.Size(112, 52);
            this.btnCf.TabIndex = 0;
            this.btnCf.Text = "BUYING";
            this.btnCf.UseVisualStyleBackColor = true;
            this.btnCf.Click += new System.EventHandler(this.btnCf_Click);
            // 
            // pAmount
            // 
            this.pAmount.Controls.Add(this.tbPrice);
            this.pAmount.Controls.Add(this.label2);
            this.pAmount.Location = new System.Drawing.Point(13, 602);
            this.pAmount.Name = "pAmount";
            this.pAmount.Size = new System.Drawing.Size(376, 47);
            this.pAmount.TabIndex = 2;
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(180, 11);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(192, 29);
            this.tbPrice.TabIndex = 1;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "TOTAL PRICE";
            // 
            // flowLayoutTicket
            // 
            this.flowLayoutTicket.AutoScroll = true;
            this.flowLayoutTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutTicket.Location = new System.Drawing.Point(13, 57);
            this.flowLayoutTicket.Name = "flowLayoutTicket";
            this.flowLayoutTicket.Size = new System.Drawing.Size(376, 529);
            this.flowLayoutTicket.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 35);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "YOUR TICKET";
            // 
            // fConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 749);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONFIRM TICKET";
            this.panel1.ResumeLayout(false);
            this.pOK.ResumeLayout(false);
            this.pAmount.ResumeLayout(false);
            this.pAmount.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pOK;
        private System.Windows.Forms.Panel pAmount;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTicket;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCf;
    }
}