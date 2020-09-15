namespace TicketSelling
{
    partial class fTrip
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
            System.Windows.Forms.Button btnFindTrip;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbDes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbSource = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.numericTicket = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChoose = new System.Windows.Forms.Button();
            this.flTripList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            btnFindTrip = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTicket)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFindTrip
            // 
            btnFindTrip.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnFindTrip.Location = new System.Drawing.Point(98, 408);
            btnFindTrip.Name = "btnFindTrip";
            btnFindTrip.Size = new System.Drawing.Size(152, 51);
            btnFindTrip.TabIndex = 1;
            btnFindTrip.Text = "FIND TRIP";
            btnFindTrip.UseVisualStyleBackColor = true;
            btnFindTrip.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 577);
            this.panel1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.datePick);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(18, 282);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(377, 56);
            this.panel8.TabIndex = 0;
            // 
            // datePick
            // 
            this.datePick.CustomFormat = "dd-MM-yyyy";
            this.datePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePick.Location = new System.Drawing.Point(136, 18);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(237, 27);
            this.datePick.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "DATE";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbDes);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(18, 197);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(377, 56);
            this.panel7.TabIndex = 0;
            // 
            // cbDes
            // 
            this.cbDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDes.FormattingEnabled = true;
            this.cbDes.Location = new System.Drawing.Point(136, 10);
            this.cbDes.Margin = new System.Windows.Forms.Padding(4);
            this.cbDes.Name = "cbDes";
            this.cbDes.Size = new System.Drawing.Size(237, 28);
            this.cbDes.TabIndex = 1;
            this.cbDes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbDes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbDes_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "DESTINATION";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbSource);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(18, 115);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(377, 56);
            this.panel6.TabIndex = 0;
            // 
            // cbSource
            // 
            this.cbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSource.FormattingEnabled = true;
            this.cbSource.Location = new System.Drawing.Point(136, 16);
            this.cbSource.Margin = new System.Windows.Forms.Padding(4);
            this.cbSource.Name = "cbSource";
            this.cbSource.Size = new System.Drawing.Size(237, 28);
            this.cbSource.TabIndex = 1;
            this.cbSource.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbSource.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbSource_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "SOURCE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(btnFindTrip);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Location = new System.Drawing.Point(18, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(380, 481);
            this.panel5.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.numericTicket);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Location = new System.Drawing.Point(0, 298);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(377, 56);
            this.panel9.TabIndex = 0;
            // 
            // numericTicket
            // 
            this.numericTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTicket.Location = new System.Drawing.Point(216, 10);
            this.numericTicket.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericTicket.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTicket.Name = "numericTicket";
            this.numericTicket.Size = new System.Drawing.Size(56, 29);
            this.numericTicket.TabIndex = 1;
            this.numericTicket.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "TICKET NUMBER";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(18, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 36);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "FINDING TRIP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnChoose);
            this.panel2.Controls.Add(this.flTripList);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(448, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 577);
            this.panel2.TabIndex = 0;
            // 
            // btnChoose
            // 
            this.btnChoose.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.Location = new System.Drawing.Point(156, 481);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(152, 51);
            this.btnChoose.TabIndex = 2;
            this.btnChoose.Text = "CHOOSING";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // flTripList
            // 
            this.flTripList.AutoScroll = true;
            this.flTripList.Location = new System.Drawing.Point(16, 72);
            this.flTripList.Name = "flTripList";
            this.flTripList.Size = new System.Drawing.Size(465, 383);
            this.flTripList.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(16, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(465, 36);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "TRIP LIST";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // fTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(956, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fTrip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRIP INFORMATION";
            this.Load += new System.EventHandler(this.fTrip_Load);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTicket)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSource;
        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.ComboBox cbDes;
        private System.Windows.Forms.NumericUpDown numericTicket;
        private System.Windows.Forms.FlowLayoutPanel flTripList;
        private System.Windows.Forms.Button btnChoose;
    }
}