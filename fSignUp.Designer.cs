namespace TicketSelling
{
    partial class fSignUp
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
            this.lbMissing = new System.Windows.Forms.Label();
            this.checkPwLb = new System.Windows.Forms.Label();
            this.ConfirmBt = new System.Windows.Forms.Button();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.tbCfPass = new System.Windows.Forms.TextBox();
            this.tbPassSignUp = new System.Windows.Forms.TextBox();
            this.tbUserSignUp = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lbCfPass = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbDOB = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbMissing);
            this.panel1.Controls.Add(this.checkPwLb);
            this.panel1.Controls.Add(this.ConfirmBt);
            this.panel1.Controls.Add(this.dtDOB);
            this.panel1.Controls.Add(this.cbGender);
            this.panel1.Controls.Add(this.tbCfPass);
            this.panel1.Controls.Add(this.tbPassSignUp);
            this.panel1.Controls.Add(this.tbUserSignUp);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.tbAddress);
            this.panel1.Controls.Add(this.tbPhone);
            this.panel1.Controls.Add(this.tbLastName);
            this.panel1.Controls.Add(this.tbFirstName);
            this.panel1.Controls.Add(this.lbCfPass);
            this.panel1.Controls.Add(this.lbPass);
            this.panel1.Controls.Add(this.lbUserName);
            this.panel1.Controls.Add(this.lbDOB);
            this.panel1.Controls.Add(this.lbGender);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Controls.Add(this.lbAddress);
            this.panel1.Controls.Add(this.lbLastName);
            this.panel1.Controls.Add(this.lbPhone);
            this.panel1.Controls.Add(this.lbFirstName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 459);
            this.panel1.TabIndex = 1;
            // 
            // lbMissing
            // 
            this.lbMissing.AutoSize = true;
            this.lbMissing.ForeColor = System.Drawing.Color.Red;
            this.lbMissing.Location = new System.Drawing.Point(120, 14);
            this.lbMissing.Name = "lbMissing";
            this.lbMissing.Size = new System.Drawing.Size(213, 19);
            this.lbMissing.TabIndex = 23;
            this.lbMissing.Text = "*Please fill the missing information";
            this.lbMissing.Visible = false;
            // 
            // checkPwLb
            // 
            this.checkPwLb.AutoSize = true;
            this.checkPwLb.ForeColor = System.Drawing.Color.Red;
            this.checkPwLb.Location = new System.Drawing.Point(420, 199);
            this.checkPwLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.checkPwLb.Name = "checkPwLb";
            this.checkPwLb.Size = new System.Drawing.Size(196, 19);
            this.checkPwLb.TabIndex = 22;
            this.checkPwLb.Text = "Wrong cormfirmed password!!";
            this.checkPwLb.Visible = false;
            this.checkPwLb.Click += new System.EventHandler(this.checkPwLb_Click);
            // 
            // ConfirmBt
            // 
            this.ConfirmBt.Location = new System.Drawing.Point(242, 404);
            this.ConfirmBt.Margin = new System.Windows.Forms.Padding(2);
            this.ConfirmBt.Name = "ConfirmBt";
            this.ConfirmBt.Size = new System.Drawing.Size(134, 29);
            this.ConfirmBt.TabIndex = 11;
            this.ConfirmBt.Text = "Confirm";
            this.ConfirmBt.UseVisualStyleBackColor = true;
            this.ConfirmBt.Click += new System.EventHandler(this.ConfirmBt_Click);
            // 
            // dtDOB
            // 
            this.dtDOB.Location = new System.Drawing.Point(107, 346);
            this.dtDOB.Margin = new System.Windows.Forms.Padding(2);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(255, 26);
            this.dtDOB.TabIndex = 7;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbGender.Location = new System.Drawing.Point(106, 301);
            this.cbGender.Margin = new System.Windows.Forms.Padding(2);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(86, 27);
            this.cbGender.TabIndex = 6;
            this.cbGender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbGender_KeyDown);
            // 
            // tbCfPass
            // 
            this.tbCfPass.Location = new System.Drawing.Point(456, 143);
            this.tbCfPass.Margin = new System.Windows.Forms.Padding(2);
            this.tbCfPass.MaxLength = 25;
            this.tbCfPass.Name = "tbCfPass";
            this.tbCfPass.Size = new System.Drawing.Size(160, 26);
            this.tbCfPass.TabIndex = 10;
            this.tbCfPass.UseSystemPasswordChar = true;
            this.tbCfPass.TextChanged += new System.EventHandler(this.PwCfTb_TextChanged);
            // 
            // tbPassSignUp
            // 
            this.tbPassSignUp.Location = new System.Drawing.Point(456, 102);
            this.tbPassSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassSignUp.MaxLength = 25;
            this.tbPassSignUp.Name = "tbPassSignUp";
            this.tbPassSignUp.Size = new System.Drawing.Size(160, 26);
            this.tbPassSignUp.TabIndex = 9;
            this.tbPassSignUp.UseSystemPasswordChar = true;
            this.tbPassSignUp.TextChanged += new System.EventHandler(this.PwTb_TextChanged);
            // 
            // tbUserSignUp
            // 
            this.tbUserSignUp.Location = new System.Drawing.Point(456, 63);
            this.tbUserSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserSignUp.MaxLength = 20;
            this.tbUserSignUp.Name = "tbUserSignUp";
            this.tbUserSignUp.Size = new System.Drawing.Size(160, 26);
            this.tbUserSignUp.TabIndex = 8;
            this.tbUserSignUp.TextChanged += new System.EventHandler(this.UsTb_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(106, 258);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(171, 26);
            this.tbEmail.TabIndex = 5;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(106, 210);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbAddress.MaxLength = 50;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(171, 26);
            this.tbAddress.TabIndex = 4;
            this.tbAddress.TextChanged += new System.EventHandler(this.AddressTb_TextChanged);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(106, 165);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(2);
            this.tbPhone.MaxLength = 20;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(171, 26);
            this.tbPhone.TabIndex = 3;
            this.tbPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPhone_KeyDown);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(106, 118);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2);
            this.tbLastName.MaxLength = 20;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(171, 26);
            this.tbLastName.TabIndex = 2;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(107, 67);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.tbFirstName.MaxLength = 20;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(171, 26);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // lbCfPass
            // 
            this.lbCfPass.AutoSize = true;
            this.lbCfPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCfPass.Location = new System.Drawing.Point(306, 150);
            this.lbCfPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCfPass.Name = "lbCfPass";
            this.lbCfPass.Size = new System.Drawing.Size(125, 19);
            this.lbCfPass.TabIndex = 9;
            this.lbCfPass.Text = "Comfirm password";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(307, 116);
            this.lbPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(69, 19);
            this.lbPass.TabIndex = 8;
            this.lbPass.Text = "Password";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(307, 77);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(70, 19);
            this.lbUserName.TabIndex = 7;
            this.lbUserName.Text = "Username";
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDOB.Location = new System.Drawing.Point(15, 346);
            this.lbDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(85, 19);
            this.lbDOB.TabIndex = 6;
            this.lbDOB.Text = "Date of birth";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(21, 304);
            this.lbGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(54, 19);
            this.lbGender.TabIndex = 5;
            this.lbGender.Text = "Gender";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(21, 261);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(42, 19);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(21, 217);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(60, 19);
            this.lbAddress.TabIndex = 3;
            this.lbAddress.Text = "Address";
            this.lbAddress.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.Location = new System.Drawing.Point(21, 121);
            this.lbLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(76, 19);
            this.lbLastName.TabIndex = 1;
            this.lbLastName.Text = "Last Name";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(21, 172);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(47, 19);
            this.lbPhone.TabIndex = 2;
            this.lbPhone.Text = "Phone";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.Location = new System.Drawing.Point(22, 70);
            this.lbFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(77, 19);
            this.lbFirstName.TabIndex = 1;
            this.lbFirstName.Text = "First Name";
            this.lbFirstName.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN UP";
            // 
            // fSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 481);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGN UP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label checkPwLb;
        private System.Windows.Forms.Button ConfirmBt;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox tbCfPass;
        private System.Windows.Forms.TextBox tbPassSignUp;
        private System.Windows.Forms.TextBox tbUserSignUp;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lbCfPass;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbMissing;
    }
}