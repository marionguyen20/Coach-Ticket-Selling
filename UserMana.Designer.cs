namespace TicketSelling
{
    partial class UserMana
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
            this.DataShow = new System.Windows.Forms.DataGridView();
            this.DetailGB = new System.Windows.Forms.GroupBox();
            this.dtPickerDOB = new System.Windows.Forms.DateTimePicker();
            this.lbGender = new System.Windows.Forms.Label();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbDOB = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.SearchLb = new System.Windows.Forms.Label();
            this.SearchCB = new System.Windows.Forms.ComboBox();
            this.SearchBt = new System.Windows.Forms.Button();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnIDDriver = new System.Windows.Forms.Panel();
            this.cbDriver = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnDate = new System.Windows.Forms.Panel();
            this.dtPickTo = new System.Windows.Forms.DateTimePicker();
            this.dtPickFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataShow)).BeginInit();
            this.DetailGB.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnIDDriver.SuspendLayout();
            this.pnDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataShow
            // 
            this.DataShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataShow.Location = new System.Drawing.Point(9, 62);
            this.DataShow.Margin = new System.Windows.Forms.Padding(2);
            this.DataShow.Name = "DataShow";
            this.DataShow.ReadOnly = true;
            this.DataShow.RowHeadersWidth = 51;
            this.DataShow.RowTemplate.Height = 24;
            this.DataShow.Size = new System.Drawing.Size(641, 472);
            this.DataShow.TabIndex = 1;
            this.DataShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataShow_CellClick);
            // 
            // DetailGB
            // 
            this.DetailGB.BackColor = System.Drawing.SystemColors.Control;
            this.DetailGB.Controls.Add(this.dtPickerDOB);
            this.DetailGB.Controls.Add(this.lbGender);
            this.DetailGB.Controls.Add(this.tbGender);
            this.DetailGB.Controls.Add(this.tbEmail);
            this.DetailGB.Controls.Add(this.lbEmail);
            this.DetailGB.Controls.Add(this.tbAddress);
            this.DetailGB.Controls.Add(this.lbAddress);
            this.DetailGB.Controls.Add(this.tbPhone);
            this.DetailGB.Controls.Add(this.lbPhone);
            this.DetailGB.Controls.Add(this.tbLastName);
            this.DetailGB.Controls.Add(this.lbLastName);
            this.DetailGB.Controls.Add(this.lbUserID);
            this.DetailGB.Controls.Add(this.lbFirstName);
            this.DetailGB.Controls.Add(this.lbDOB);
            this.DetailGB.Controls.Add(this.tbFirstName);
            this.DetailGB.Controls.Add(this.tbUserID);
            this.DetailGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.DetailGB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DetailGB.Location = new System.Drawing.Point(654, 11);
            this.DetailGB.Margin = new System.Windows.Forms.Padding(2);
            this.DetailGB.Name = "DetailGB";
            this.DetailGB.Padding = new System.Windows.Forms.Padding(2);
            this.DetailGB.Size = new System.Drawing.Size(182, 567);
            this.DetailGB.TabIndex = 2;
            this.DetailGB.TabStop = false;
            this.DetailGB.Text = "Detail";
            // 
            // dtPickerDOB
            // 
            this.dtPickerDOB.CustomFormat = "dd-MM-yyyy";
            this.dtPickerDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtPickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerDOB.Location = new System.Drawing.Point(11, 472);
            this.dtPickerDOB.Margin = new System.Windows.Forms.Padding(2);
            this.dtPickerDOB.Name = "dtPickerDOB";
            this.dtPickerDOB.Size = new System.Drawing.Size(169, 23);
            this.dtPickerDOB.TabIndex = 1;
            this.dtPickerDOB.Value = new System.DateTime(2020, 4, 10, 0, 0, 0, 0);
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbGender.Location = new System.Drawing.Point(10, 392);
            this.lbGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(62, 17);
            this.lbGender.TabIndex = 25;
            this.lbGender.Text = "Gender";
            // 
            // tbGender
            // 
            this.tbGender.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGender.Location = new System.Drawing.Point(11, 411);
            this.tbGender.Margin = new System.Windows.Forms.Padding(2);
            this.tbGender.Name = "tbGender";
            this.tbGender.ReadOnly = true;
            this.tbGender.Size = new System.Drawing.Size(169, 25);
            this.tbGender.TabIndex = 24;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(13, 354);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(169, 25);
            this.tbEmail.TabIndex = 24;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbEmail.Location = new System.Drawing.Point(12, 335);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(47, 17);
            this.lbEmail.TabIndex = 23;
            this.lbEmail.Text = "Email";
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(11, 295);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ReadOnly = true;
            this.tbAddress.Size = new System.Drawing.Size(169, 25);
            this.tbAddress.TabIndex = 22;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbAddress.Location = new System.Drawing.Point(10, 276);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(67, 17);
            this.lbAddress.TabIndex = 21;
            this.lbAddress.Text = "Address";
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(11, 233);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(2);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.ReadOnly = true;
            this.tbPhone.Size = new System.Drawing.Size(169, 25);
            this.tbPhone.TabIndex = 20;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbPhone.Location = new System.Drawing.Point(12, 214);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(54, 17);
            this.lbPhone.TabIndex = 19;
            this.lbPhone.Text = "Phone";
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(11, 175);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.ReadOnly = true;
            this.tbLastName.Size = new System.Drawing.Size(169, 25);
            this.tbLastName.TabIndex = 18;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbLastName.Location = new System.Drawing.Point(12, 156);
            this.lbLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(85, 17);
            this.lbLastName.TabIndex = 17;
            this.lbLastName.Text = "Last Name";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbUserID.Location = new System.Drawing.Point(10, 29);
            this.lbUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(62, 17);
            this.lbUserID.TabIndex = 10;
            this.lbUserID.Text = "User ID";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbFirstName.Location = new System.Drawing.Point(12, 94);
            this.lbFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(86, 17);
            this.lbFirstName.TabIndex = 12;
            this.lbFirstName.Text = "First Name";
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbDOB.Location = new System.Drawing.Point(12, 453);
            this.lbDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(100, 17);
            this.lbDOB.TabIndex = 14;
            this.lbDOB.Text = "Date of Birth";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(11, 113);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.ReadOnly = true;
            this.tbFirstName.Size = new System.Drawing.Size(169, 25);
            this.tbFirstName.TabIndex = 13;
            // 
            // tbUserID
            // 
            this.tbUserID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserID.Location = new System.Drawing.Point(9, 51);
            this.tbUserID.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.ReadOnly = true;
            this.tbUserID.Size = new System.Drawing.Size(169, 25);
            this.tbUserID.TabIndex = 11;
            // 
            // SearchLb
            // 
            this.SearchLb.AutoSize = true;
            this.SearchLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLb.Location = new System.Drawing.Point(11, 24);
            this.SearchLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchLb.Name = "SearchLb";
            this.SearchLb.Size = new System.Drawing.Size(61, 18);
            this.SearchLb.TabIndex = 30;
            this.SearchLb.Text = "Search";
            // 
            // SearchCB
            // 
            this.SearchCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCB.FormattingEnabled = true;
            this.SearchCB.Items.AddRange(new object[] {
            "All Users",
            "ID User",
            "First_Name",
            "Last_Name",
            "Phone",
            "Address_User",
            "Email",
            "Gender",
            "Date Of Birth"});
            this.SearchCB.Location = new System.Drawing.Point(76, 21);
            this.SearchCB.Margin = new System.Windows.Forms.Padding(2);
            this.SearchCB.Name = "SearchCB";
            this.SearchCB.Size = new System.Drawing.Size(175, 26);
            this.SearchCB.TabIndex = 31;
            this.SearchCB.SelectedIndexChanged += new System.EventHandler(this.SearchCB_SelectedIndexChanged);
            this.SearchCB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchCB_KeyDown);
            // 
            // SearchBt
            // 
            this.SearchBt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchBt.Location = new System.Drawing.Point(569, 11);
            this.SearchBt.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBt.Name = "SearchBt";
            this.SearchBt.Size = new System.Drawing.Size(81, 46);
            this.SearchBt.TabIndex = 9;
            this.SearchBt.Text = "FIND";
            this.SearchBt.UseVisualStyleBackColor = false;
            this.SearchBt.Click += new System.EventHandler(this.SearchBt_Click);
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.tbValue);
            this.pnSearch.Controls.Add(this.label2);
            this.pnSearch.Location = new System.Drawing.Point(293, 12);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(268, 36);
            this.pnSearch.TabIndex = 34;
            // 
            // tbValue
            // 
            this.tbValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValue.Location = new System.Drawing.Point(89, 10);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(174, 24);
            this.tbValue.TabIndex = 36;
            this.tbValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Value";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbTotal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(446, 542);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 36);
            this.panel1.TabIndex = 36;
            // 
            // tbTotal
            // 
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(108, 5);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(89, 27);
            this.tbTotal.TabIndex = 38;
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Total User";
            // 
            // pnIDDriver
            // 
            this.pnIDDriver.Controls.Add(this.cbDriver);
            this.pnIDDriver.Controls.Add(this.label5);
            this.pnIDDriver.Location = new System.Drawing.Point(288, 15);
            this.pnIDDriver.Name = "pnIDDriver";
            this.pnIDDriver.Size = new System.Drawing.Size(268, 36);
            this.pnIDDriver.TabIndex = 34;
            this.pnIDDriver.Visible = false;
            // 
            // cbDriver
            // 
            this.cbDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDriver.FormattingEnabled = true;
            this.cbDriver.Location = new System.Drawing.Point(91, 5);
            this.cbDriver.Name = "cbDriver";
            this.cbDriver.Size = new System.Drawing.Size(161, 28);
            this.cbDriver.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Value";
            // 
            // pnDate
            // 
            this.pnDate.Controls.Add(this.dtPickTo);
            this.pnDate.Controls.Add(this.dtPickFrom);
            this.pnDate.Controls.Add(this.label3);
            this.pnDate.Controls.Add(this.label1);
            this.pnDate.Location = new System.Drawing.Point(256, 4);
            this.pnDate.Name = "pnDate";
            this.pnDate.Size = new System.Drawing.Size(308, 56);
            this.pnDate.TabIndex = 36;
            this.pnDate.Visible = false;
            // 
            // dtPickTo
            // 
            this.dtPickTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickTo.Location = new System.Drawing.Point(69, 30);
            this.dtPickTo.Name = "dtPickTo";
            this.dtPickTo.Size = new System.Drawing.Size(237, 23);
            this.dtPickTo.TabIndex = 1;
            // 
            // dtPickFrom
            // 
            this.dtPickFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickFrom.Location = new System.Drawing.Point(69, 0);
            this.dtPickFrom.Name = "dtPickFrom";
            this.dtPickFrom.Size = new System.Drawing.Size(237, 23);
            this.dtPickFrom.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "From";
            // 
            // UserMana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 581);
            this.Controls.Add(this.pnDate);
            this.Controls.Add(this.pnIDDriver);
            this.Controls.Add(this.pnSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SearchCB);
            this.Controls.Add(this.DetailGB);
            this.Controls.Add(this.SearchLb);
            this.Controls.Add(this.DataShow);
            this.Controls.Add(this.SearchBt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "UserMana";
            this.Text = "MANAGE USER";
            ((System.ComponentModel.ISupportInitialize)(this.DataShow)).EndInit();
            this.DetailGB.ResumeLayout(false);
            this.DetailGB.PerformLayout();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnIDDriver.ResumeLayout(false);
            this.pnIDDriver.PerformLayout();
            this.pnDate.ResumeLayout(false);
            this.pnDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataShow;
        private System.Windows.Forms.GroupBox DetailGB;
        private System.Windows.Forms.DateTimePicker dtPickerDOB;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.Label SearchLb;
        private System.Windows.Forms.ComboBox SearchCB;
        private System.Windows.Forms.Button SearchBt;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnIDDriver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDriver;
        private System.Windows.Forms.Panel pnDate;
        private System.Windows.Forms.DateTimePicker dtPickTo;
        private System.Windows.Forms.DateTimePicker dtPickFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGender;
    }
}