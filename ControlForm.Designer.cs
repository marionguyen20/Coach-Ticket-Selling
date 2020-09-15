namespace TicketSelling.Manager
{
    partial class ControlForm
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
            this.cbIDDriver = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTripTb = new System.Windows.Forms.DateTimePicker();
            this.DriverID = new System.Windows.Forms.Label();
            this.DiscountTb = new System.Windows.Forms.TextBox();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.AvailableTb = new System.Windows.Forms.TextBox();
            this.TotalSeatTb = new System.Windows.Forms.TextBox();
            this.TotalSLabel = new System.Windows.Forms.Label();
            this.ArrivalTimeTb = new System.Windows.Forms.TextBox();
            this.ArrivalLabel = new System.Windows.Forms.Label();
            this.StartTimeTb = new System.Windows.Forms.TextBox();
            this.StartLabel = new System.Windows.Forms.Label();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.DestinationTb = new System.Windows.Forms.TextBox();
            this.SourceTb = new System.Windows.Forms.TextBox();
            this.SearchLb = new System.Windows.Forms.Label();
            this.SearchCB = new System.Windows.Forms.ComboBox();
            this.SearchBt = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SourceLb = new System.Windows.Forms.Label();
            this.DestLb = new System.Windows.Forms.Label();
            this.pnSourceDes = new System.Windows.Forms.Panel();
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.cbSource = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnDate = new System.Windows.Forms.Panel();
            this.dtPickTo = new System.Windows.Forms.DateTimePicker();
            this.dtPickFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnIDDriver = new System.Windows.Forms.Panel();
            this.cbDriver = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataShow)).BeginInit();
            this.DetailGB.SuspendLayout();
            this.pnSourceDes.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnDate.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnIDDriver.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataShow
            // 
            this.DataShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataShow.Location = new System.Drawing.Point(9, 62);
            this.DataShow.Margin = new System.Windows.Forms.Padding(2);
            this.DataShow.MultiSelect = false;
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
            this.DetailGB.Controls.Add(this.cbIDDriver);
            this.DetailGB.Controls.Add(this.label1);
            this.DetailGB.Controls.Add(this.DateTripTb);
            this.DetailGB.Controls.Add(this.DriverID);
            this.DetailGB.Controls.Add(this.DiscountTb);
            this.DetailGB.Controls.Add(this.DiscountLabel);
            this.DetailGB.Controls.Add(this.PriceTb);
            this.DetailGB.Controls.Add(this.PriceLabel);
            this.DetailGB.Controls.Add(this.AvailableTb);
            this.DetailGB.Controls.Add(this.TotalSeatTb);
            this.DetailGB.Controls.Add(this.TotalSLabel);
            this.DetailGB.Controls.Add(this.ArrivalTimeTb);
            this.DetailGB.Controls.Add(this.ArrivalLabel);
            this.DetailGB.Controls.Add(this.StartTimeTb);
            this.DetailGB.Controls.Add(this.StartLabel);
            this.DetailGB.Controls.Add(this.SourceLabel);
            this.DetailGB.Controls.Add(this.DestinationLabel);
            this.DetailGB.Controls.Add(this.DateLabel);
            this.DetailGB.Controls.Add(this.btnSave);
            this.DetailGB.Controls.Add(this.btnCancel);
            this.DetailGB.Controls.Add(this.DestinationTb);
            this.DetailGB.Controls.Add(this.SourceTb);
            this.DetailGB.Enabled = false;
            this.DetailGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.DetailGB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DetailGB.Location = new System.Drawing.Point(654, 11);
            this.DetailGB.Margin = new System.Windows.Forms.Padding(2);
            this.DetailGB.Name = "DetailGB";
            this.DetailGB.Padding = new System.Windows.Forms.Padding(2);
            this.DetailGB.Size = new System.Drawing.Size(155, 567);
            this.DetailGB.TabIndex = 2;
            this.DetailGB.TabStop = false;
            this.DetailGB.Text = "Detail";
            // 
            // cbIDDriver
            // 
            this.cbIDDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbIDDriver.FormattingEnabled = true;
            this.cbIDDriver.Location = new System.Drawing.Point(10, 484);
            this.cbIDDriver.Name = "cbIDDriver";
            this.cbIDDriver.Size = new System.Drawing.Size(139, 28);
            this.cbIDDriver.TabIndex = 30;
            this.cbIDDriver.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbIDDriver_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 306);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Available Seat";
            // 
            // DateTripTb
            // 
            this.DateTripTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DateTripTb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTripTb.Location = new System.Drawing.Point(11, 143);
            this.DateTripTb.Margin = new System.Windows.Forms.Padding(2);
            this.DateTripTb.Name = "DateTripTb";
            this.DateTripTb.Size = new System.Drawing.Size(140, 23);
            this.DateTripTb.TabIndex = 1;
            this.DateTripTb.Value = new System.DateTime(2020, 4, 10, 0, 0, 0, 0);
            // 
            // DriverID
            // 
            this.DriverID.AutoSize = true;
            this.DriverID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.DriverID.Location = new System.Drawing.Point(12, 464);
            this.DriverID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DriverID.Name = "DriverID";
            this.DriverID.Size = new System.Drawing.Size(72, 17);
            this.DriverID.TabIndex = 27;
            this.DriverID.Text = "Driver ID";
            // 
            // DiscountTb
            // 
            this.DiscountTb.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountTb.Location = new System.Drawing.Point(9, 437);
            this.DiscountTb.Margin = new System.Windows.Forms.Padding(2);
            this.DiscountTb.Name = "DiscountTb";
            this.DiscountTb.Size = new System.Drawing.Size(140, 25);
            this.DiscountTb.TabIndex = 26;
            this.DiscountTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DiscountTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DiscountTb_KeyPress);
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.DiscountLabel.Location = new System.Drawing.Point(8, 407);
            this.DiscountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(71, 17);
            this.DiscountLabel.TabIndex = 25;
            this.DiscountLabel.Text = "Discount";
            // 
            // PriceTb
            // 
            this.PriceTb.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTb.Location = new System.Drawing.Point(9, 380);
            this.PriceTb.Margin = new System.Windows.Forms.Padding(2);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(140, 25);
            this.PriceTb.TabIndex = 24;
            this.PriceTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PriceTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceTb_KeyPress);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.PriceLabel.Location = new System.Drawing.Point(8, 361);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(45, 17);
            this.PriceLabel.TabIndex = 23;
            this.PriceLabel.Text = "Price";
            // 
            // AvailableTb
            // 
            this.AvailableTb.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableTb.Location = new System.Drawing.Point(9, 334);
            this.AvailableTb.Margin = new System.Windows.Forms.Padding(2);
            this.AvailableTb.Name = "AvailableTb";
            this.AvailableTb.ReadOnly = true;
            this.AvailableTb.Size = new System.Drawing.Size(140, 25);
            this.AvailableTb.TabIndex = 22;
            this.AvailableTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalSeatTb
            // 
            this.TotalSeatTb.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSeatTb.Location = new System.Drawing.Point(9, 279);
            this.TotalSeatTb.Margin = new System.Windows.Forms.Padding(2);
            this.TotalSeatTb.Name = "TotalSeatTb";
            this.TotalSeatTb.Size = new System.Drawing.Size(140, 25);
            this.TotalSeatTb.TabIndex = 22;
            this.TotalSeatTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalSLabel
            // 
            this.TotalSLabel.AutoSize = true;
            this.TotalSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.TotalSLabel.Location = new System.Drawing.Point(8, 260);
            this.TotalSLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalSLabel.Name = "TotalSLabel";
            this.TotalSLabel.Size = new System.Drawing.Size(83, 17);
            this.TotalSLabel.TabIndex = 21;
            this.TotalSLabel.Text = "Total Seat";
            // 
            // ArrivalTimeTb
            // 
            this.ArrivalTimeTb.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrivalTimeTb.Location = new System.Drawing.Point(11, 233);
            this.ArrivalTimeTb.Margin = new System.Windows.Forms.Padding(2);
            this.ArrivalTimeTb.Name = "ArrivalTimeTb";
            this.ArrivalTimeTb.Size = new System.Drawing.Size(140, 25);
            this.ArrivalTimeTb.TabIndex = 20;
            // 
            // ArrivalLabel
            // 
            this.ArrivalLabel.AutoSize = true;
            this.ArrivalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ArrivalLabel.Location = new System.Drawing.Point(12, 214);
            this.ArrivalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ArrivalLabel.Name = "ArrivalLabel";
            this.ArrivalLabel.Size = new System.Drawing.Size(95, 17);
            this.ArrivalLabel.TabIndex = 19;
            this.ArrivalLabel.Text = "Arrival Time";
            // 
            // StartTimeTb
            // 
            this.StartTimeTb.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeTb.Location = new System.Drawing.Point(11, 187);
            this.StartTimeTb.Margin = new System.Windows.Forms.Padding(2);
            this.StartTimeTb.Name = "StartTimeTb";
            this.StartTimeTb.Size = new System.Drawing.Size(140, 25);
            this.StartTimeTb.TabIndex = 18;
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.StartLabel.Location = new System.Drawing.Point(12, 168);
            this.StartLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(83, 17);
            this.StartLabel.TabIndex = 17;
            this.StartLabel.Text = "Start Time";
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.SourceLabel.Location = new System.Drawing.Point(12, 29);
            this.SourceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(59, 17);
            this.SourceLabel.TabIndex = 10;
            this.SourceLabel.Text = "Source";
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.DestinationLabel.Location = new System.Drawing.Point(12, 78);
            this.DestinationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(90, 17);
            this.DestinationLabel.TabIndex = 12;
            this.DestinationLabel.Text = "Destination";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.DateLabel.Location = new System.Drawing.Point(12, 124);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(76, 17);
            this.DateLabel.TabIndex = 14;
            this.DateLabel.Text = "Date Trip";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(9, 521);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(58, 40);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(86, 521);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 40);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // DestinationTb
            // 
            this.DestinationTb.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationTb.Location = new System.Drawing.Point(11, 97);
            this.DestinationTb.Margin = new System.Windows.Forms.Padding(2);
            this.DestinationTb.Name = "DestinationTb";
            this.DestinationTb.Size = new System.Drawing.Size(140, 25);
            this.DestinationTb.TabIndex = 13;
            // 
            // SourceTb
            // 
            this.SourceTb.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceTb.Location = new System.Drawing.Point(11, 51);
            this.SourceTb.Margin = new System.Windows.Forms.Padding(2);
            this.SourceTb.Name = "SourceTb";
            this.SourceTb.Size = new System.Drawing.Size(140, 25);
            this.SourceTb.TabIndex = 11;
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
            "All Trips",
            "Source - Destination",
            "Date Trip",
            "Start_Time",
            "Arrival_Time",
            "Duration",
            "Total_Seat",
            "Available_Seat",
            "Price",
            "Discount",
            "ID_Trip",
            "ID_Manager",
            "ID_Driver"});
            this.SearchCB.Location = new System.Drawing.Point(76, 21);
            this.SearchCB.Margin = new System.Windows.Forms.Padding(2);
            this.SearchCB.Name = "SearchCB";
            this.SearchCB.Size = new System.Drawing.Size(175, 26);
            this.SearchCB.TabIndex = 31;
            this.SearchCB.SelectedValueChanged += new System.EventHandler(this.SearchCB_SelectedValueChanged);
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
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(217, 542);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 32);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.DeleteBt_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(14, 540);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 32);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.AddBt_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.Location = new System.Drawing.Point(116, 540);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(72, 34);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.EditBt_Click);
            // 
            // SourceLb
            // 
            this.SourceLb.AutoSize = true;
            this.SourceLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceLb.Location = new System.Drawing.Point(13, 5);
            this.SourceLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SourceLb.Name = "SourceLb";
            this.SourceLb.Size = new System.Drawing.Size(44, 17);
            this.SourceLb.TabIndex = 32;
            this.SourceLb.Text = "From";
            // 
            // DestLb
            // 
            this.DestLb.AutoSize = true;
            this.DestLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestLb.Location = new System.Drawing.Point(12, 30);
            this.DestLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DestLb.Name = "DestLb";
            this.DestLb.Size = new System.Drawing.Size(90, 17);
            this.DestLb.TabIndex = 32;
            this.DestLb.Text = "Destination";
            // 
            // pnSourceDes
            // 
            this.pnSourceDes.Controls.Add(this.cbDestination);
            this.pnSourceDes.Controls.Add(this.cbSource);
            this.pnSourceDes.Controls.Add(this.label6);
            this.pnSourceDes.Controls.Add(this.DestLb);
            this.pnSourceDes.Location = new System.Drawing.Point(266, 2);
            this.pnSourceDes.Name = "pnSourceDes";
            this.pnSourceDes.Size = new System.Drawing.Size(298, 55);
            this.pnSourceDes.TabIndex = 33;
            this.pnSourceDes.Visible = false;
            // 
            // cbDestination
            // 
            this.cbDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Location = new System.Drawing.Point(107, 29);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(174, 24);
            this.cbDestination.TabIndex = 33;
            // 
            // cbSource
            // 
            this.cbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSource.FormattingEnabled = true;
            this.cbSource.Location = new System.Drawing.Point(107, 3);
            this.cbSource.Name = "cbSource";
            this.cbSource.Size = new System.Drawing.Size(174, 24);
            this.cbSource.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Source";
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.tbValue);
            this.pnSearch.Controls.Add(this.label2);
            this.pnSearch.Location = new System.Drawing.Point(293, 12);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(268, 36);
            this.pnSearch.TabIndex = 34;
            this.pnSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.pnSearch_Paint);
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
            // pnDate
            // 
            this.pnDate.Controls.Add(this.dtPickTo);
            this.pnDate.Controls.Add(this.dtPickFrom);
            this.pnDate.Controls.Add(this.label3);
            this.pnDate.Controls.Add(this.SourceLb);
            this.pnDate.Location = new System.Drawing.Point(256, 2);
            this.pnDate.Name = "pnDate";
            this.pnDate.Size = new System.Drawing.Size(308, 56);
            this.pnDate.TabIndex = 35;
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
            this.label4.Location = new System.Drawing.Point(11, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Total Trip";
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
            this.pnIDDriver.Paint += new System.Windows.Forms.PaintEventHandler(this.pnSearch_Paint);
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
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 581);
            this.Controls.Add(this.pnDate);
            this.Controls.Add(this.pnIDDriver);
            this.Controls.Add(this.pnSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnSourceDes);
            this.Controls.Add(this.SearchCB);
            this.Controls.Add(this.DetailGB);
            this.Controls.Add(this.SearchLb);
            this.Controls.Add(this.DataShow);
            this.Controls.Add(this.SearchBt);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ControlForm";
            this.Text = "MANAGE TRIP";
            ((System.ComponentModel.ISupportInitialize)(this.DataShow)).EndInit();
            this.DetailGB.ResumeLayout(false);
            this.DetailGB.PerformLayout();
            this.pnSourceDes.ResumeLayout(false);
            this.pnSourceDes.PerformLayout();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnDate.ResumeLayout(false);
            this.pnDate.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnIDDriver.ResumeLayout(false);
            this.pnIDDriver.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataShow;
        private System.Windows.Forms.GroupBox DetailGB;
        private System.Windows.Forms.DateTimePicker DateTripTb;
        private System.Windows.Forms.Label DriverID;
        private System.Windows.Forms.TextBox DiscountTb;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.TextBox PriceTb;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox TotalSeatTb;
        private System.Windows.Forms.Label TotalSLabel;
        private System.Windows.Forms.TextBox ArrivalTimeTb;
        private System.Windows.Forms.Label ArrivalLabel;
        private System.Windows.Forms.TextBox StartTimeTb;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox DestinationTb;
        private System.Windows.Forms.TextBox SourceTb;
        private System.Windows.Forms.Label SearchLb;
        private System.Windows.Forms.ComboBox SearchCB;
        private System.Windows.Forms.Button SearchBt;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label SourceLb;
        private System.Windows.Forms.Label DestLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AvailableTb;
        private System.Windows.Forms.Panel pnSourceDes;
        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.ComboBox cbSource;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnDate;
        private System.Windows.Forms.DateTimePicker dtPickTo;
        private System.Windows.Forms.DateTimePicker dtPickFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbIDDriver;
        private System.Windows.Forms.Panel pnIDDriver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDriver;
        private System.Windows.Forms.Label label6;
    }
}