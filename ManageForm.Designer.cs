namespace TicketSelling
{
    partial class ManagerForm
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
            this.RightPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ManagerLb = new System.Windows.Forms.Label();
            this.btnManaTrip = new System.Windows.Forms.Button();
            this.btnSearchTicket = new System.Windows.Forms.Button();
            this.btnManaBill = new System.Windows.Forms.Button();
            this.btnManaUser = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightPanel
            // 
            this.RightPanel.Location = new System.Drawing.Point(191, 0);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(893, 588);
            this.RightPanel.TabIndex = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.button2);
            this.LeftPanel.Controls.Add(this.btnExit);
            this.LeftPanel.Controls.Add(this.button1);
            this.LeftPanel.Controls.Add(this.ManagerLb);
            this.LeftPanel.Controls.Add(this.btnManaTrip);
            this.LeftPanel.Controls.Add(this.btnSearchTicket);
            this.LeftPanel.Controls.Add(this.btnManaBill);
            this.LeftPanel.Controls.Add(this.btnManaUser);
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(187, 588);
            this.LeftPanel.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(0, 462);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(183, 41);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Manage Driver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ManagerLb
            // 
            this.ManagerLb.AutoSize = true;
            this.ManagerLb.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerLb.Location = new System.Drawing.Point(2, 28);
            this.ManagerLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ManagerLb.Name = "ManagerLb";
            this.ManagerLb.Size = new System.Drawing.Size(140, 36);
            this.ManagerLb.TabIndex = 8;
            this.ManagerLb.Text = "Manager";
            // 
            // btnManaTrip
            // 
            this.btnManaTrip.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManaTrip.Location = new System.Drawing.Point(2, 124);
            this.btnManaTrip.Margin = new System.Windows.Forms.Padding(2);
            this.btnManaTrip.Name = "btnManaTrip";
            this.btnManaTrip.Size = new System.Drawing.Size(181, 41);
            this.btnManaTrip.TabIndex = 1;
            this.btnManaTrip.Text = "Manage Trip";
            this.btnManaTrip.UseVisualStyleBackColor = true;
            this.btnManaTrip.Click += new System.EventHandler(this.ControlBt_Click);
            // 
            // btnSearchTicket
            // 
            this.btnSearchTicket.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTicket.Location = new System.Drawing.Point(2, 353);
            this.btnSearchTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchTicket.Name = "btnSearchTicket";
            this.btnSearchTicket.Size = new System.Drawing.Size(181, 41);
            this.btnSearchTicket.TabIndex = 6;
            this.btnSearchTicket.Text = "Search Ticket";
            this.btnSearchTicket.UseVisualStyleBackColor = true;
            this.btnSearchTicket.Click += new System.EventHandler(this.btnSearchTicket_Click);
            // 
            // btnManaBill
            // 
            this.btnManaBill.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManaBill.Location = new System.Drawing.Point(2, 294);
            this.btnManaBill.Margin = new System.Windows.Forms.Padding(2);
            this.btnManaBill.Name = "btnManaBill";
            this.btnManaBill.Size = new System.Drawing.Size(183, 41);
            this.btnManaBill.TabIndex = 6;
            this.btnManaBill.Text = "Manage Bill";
            this.btnManaBill.UseVisualStyleBackColor = true;
            this.btnManaBill.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnManaUser
            // 
            this.btnManaUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManaUser.Location = new System.Drawing.Point(2, 180);
            this.btnManaUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnManaUser.Name = "btnManaUser";
            this.btnManaUser.Size = new System.Drawing.Size(181, 41);
            this.btnManaUser.TabIndex = 6;
            this.btnManaUser.Text = "Manage User";
            this.btnManaUser.UseVisualStyleBackColor = true;
            this.btnManaUser.Click += new System.EventHandler(this.btnManaUser_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "Querry";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 594);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.RightPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel RightPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label ManagerLb;
        private System.Windows.Forms.Button btnManaTrip;
        private System.Windows.Forms.Button btnManaUser;
        private System.Windows.Forms.Button btnSearchTicket;
        private System.Windows.Forms.Button btnManaBill;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button2;
    }
}