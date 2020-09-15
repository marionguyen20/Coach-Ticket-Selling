namespace TicketSelling
{
    partial class fDriver
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
            this.label1 = new System.Windows.Forms.Label();
            this.DriverGridView = new System.Windows.Forms.DataGridView();
            this.startDay = new System.Windows.Forms.DateTimePicker();
            this.endDay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DriverGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Driver";
            // 
            // DriverGridView
            // 
            this.DriverGridView.AllowUserToAddRows = false;
            this.DriverGridView.AllowUserToDeleteRows = false;
            this.DriverGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DriverGridView.Location = new System.Drawing.Point(11, 58);
            this.DriverGridView.Margin = new System.Windows.Forms.Padding(2);
            this.DriverGridView.MultiSelect = false;
            this.DriverGridView.Name = "DriverGridView";
            this.DriverGridView.ReadOnly = true;
            this.DriverGridView.RowHeadersWidth = 51;
            this.DriverGridView.RowTemplate.Height = 24;
            this.DriverGridView.Size = new System.Drawing.Size(798, 331);
            this.DriverGridView.TabIndex = 1;
            // 
            // startDay
            // 
            this.startDay.Location = new System.Drawing.Point(177, 32);
            this.startDay.Margin = new System.Windows.Forms.Padding(2);
            this.startDay.Name = "startDay";
            this.startDay.Size = new System.Drawing.Size(202, 20);
            this.startDay.TabIndex = 2;
            // 
            // endDay
            // 
            this.endDay.Location = new System.Drawing.Point(480, 32);
            this.endDay.Margin = new System.Windows.Forms.Padding(2);
            this.endDay.Name = "endDay";
            this.endDay.Size = new System.Drawing.Size(198, 20);
            this.endDay.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "From";
            // 
            // CheckBt
            // 
            this.CheckBt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBt.Location = new System.Drawing.Point(707, 26);
            this.CheckBt.Margin = new System.Windows.Forms.Padding(2);
            this.CheckBt.Name = "CheckBt";
            this.CheckBt.Size = new System.Drawing.Size(102, 28);
            this.CheckBt.TabIndex = 4;
            this.CheckBt.Text = "Check";
            this.CheckBt.UseVisualStyleBackColor = true;
            this.CheckBt.Click += new System.EventHandler(this.CheckBt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "To";
            // 
            // fDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(820, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckBt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endDay);
            this.Controls.Add(this.startDay);
            this.Controls.Add(this.DriverGridView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "fDriver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DriverForm";
            this.Load += new System.EventHandler(this.fDriver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DriverGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DriverGridView;
        private System.Windows.Forms.DateTimePicker startDay;
        private System.Windows.Forms.DateTimePicker endDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CheckBt;
        private System.Windows.Forms.Label label2;
    }
}