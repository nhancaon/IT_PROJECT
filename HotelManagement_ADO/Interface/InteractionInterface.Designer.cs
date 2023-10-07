namespace HotelManagement_ADO.Interface
{
    partial class InteractionInterface
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkOutBtn = new FontAwesome.Sharp.IconButton();
            this.servicesBookingBtn = new FontAwesome.Sharp.IconButton();
            this.roomBookingBtn = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.customersBtn = new FontAwesome.Sharp.IconButton();
            this.productBtn = new FontAwesome.Sharp.IconButton();
            this.serviceBtn = new FontAwesome.Sharp.IconButton();
            this.roomBtn = new FontAwesome.Sharp.IconButton();
            this.bookingBtn = new FontAwesome.Sharp.IconButton();
            this.bookingDetailBtn = new FontAwesome.Sharp.IconButton();
            this.userDetailBtn = new FontAwesome.Sharp.IconButton();
            this.userBtn = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(225, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(815, 640);
            this.mainPanel.TabIndex = 7;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.topPanel.Controls.Add(this.panel2);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(815, 87);
            this.topPanel.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.checkOutBtn);
            this.panel2.Controls.Add(this.servicesBookingBtn);
            this.panel2.Controls.Add(this.roomBookingBtn);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 85);
            this.panel2.TabIndex = 8;
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkOutBtn.FlatAppearance.BorderSize = 0;
            this.checkOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkOutBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkOutBtn.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.checkOutBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.checkOutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.checkOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkOutBtn.Location = new System.Drawing.Point(774, 0);
            this.checkOutBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkOutBtn.Size = new System.Drawing.Size(202, 85);
            this.checkOutBtn.TabIndex = 14;
            this.checkOutBtn.Text = "Check Out";
            this.checkOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkOutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkOutBtn.UseVisualStyleBackColor = true;
            this.checkOutBtn.Click += new System.EventHandler(this.checkOutBtn_Click);
            // 
            // servicesBookingBtn
            // 
            this.servicesBookingBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.servicesBookingBtn.FlatAppearance.BorderSize = 0;
            this.servicesBookingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicesBookingBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesBookingBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.servicesBookingBtn.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.servicesBookingBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.servicesBookingBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.servicesBookingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.servicesBookingBtn.Location = new System.Drawing.Point(578, 0);
            this.servicesBookingBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.servicesBookingBtn.Name = "servicesBookingBtn";
            this.servicesBookingBtn.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.servicesBookingBtn.Size = new System.Drawing.Size(196, 85);
            this.servicesBookingBtn.TabIndex = 13;
            this.servicesBookingBtn.Text = "Booking Service";
            this.servicesBookingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.servicesBookingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.servicesBookingBtn.UseVisualStyleBackColor = true;
            this.servicesBookingBtn.Click += new System.EventHandler(this.servicesBookingBtn_Click);
            // 
            // roomBookingBtn
            // 
            this.roomBookingBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.roomBookingBtn.FlatAppearance.BorderSize = 0;
            this.roomBookingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomBookingBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomBookingBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.roomBookingBtn.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.roomBookingBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.roomBookingBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roomBookingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomBookingBtn.Location = new System.Drawing.Point(376, 0);
            this.roomBookingBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roomBookingBtn.Name = "roomBookingBtn";
            this.roomBookingBtn.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.roomBookingBtn.Size = new System.Drawing.Size(202, 85);
            this.roomBookingBtn.TabIndex = 12;
            this.roomBookingBtn.Text = "Booking Room";
            this.roomBookingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomBookingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roomBookingBtn.UseVisualStyleBackColor = true;
            this.roomBookingBtn.Click += new System.EventHandler(this.roomBookingBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 85);
            this.panel1.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.leftPanel.Controls.Add(this.customersBtn);
            this.leftPanel.Controls.Add(this.productBtn);
            this.leftPanel.Controls.Add(this.serviceBtn);
            this.leftPanel.Controls.Add(this.roomBtn);
            this.leftPanel.Controls.Add(this.bookingBtn);
            this.leftPanel.Controls.Add(this.bookingDetailBtn);
            this.leftPanel.Controls.Add(this.userDetailBtn);
            this.leftPanel.Controls.Add(this.userBtn);
            this.leftPanel.Controls.Add(this.panel3);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(225, 640);
            this.leftPanel.TabIndex = 5;
            // 
            // customersBtn
            // 
            this.customersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.customersBtn.FlatAppearance.BorderSize = 0;
            this.customersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.customersBtn.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.customersBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.customersBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.customersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customersBtn.Location = new System.Drawing.Point(0, 460);
            this.customersBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customersBtn.Name = "customersBtn";
            this.customersBtn.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.customersBtn.Size = new System.Drawing.Size(225, 49);
            this.customersBtn.TabIndex = 16;
            this.customersBtn.Text = "Customers";
            this.customersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customersBtn.UseVisualStyleBackColor = true;
            this.customersBtn.Click += new System.EventHandler(this.customersBtn_Click);
            // 
            // productBtn
            // 
            this.productBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.productBtn.FlatAppearance.BorderSize = 0;
            this.productBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.productBtn.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.productBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.productBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.productBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productBtn.Location = new System.Drawing.Point(0, 411);
            this.productBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productBtn.Name = "productBtn";
            this.productBtn.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.productBtn.Size = new System.Drawing.Size(225, 49);
            this.productBtn.TabIndex = 13;
            this.productBtn.Text = "Products";
            this.productBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productBtn.UseVisualStyleBackColor = true;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // serviceBtn
            // 
            this.serviceBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.serviceBtn.FlatAppearance.BorderSize = 0;
            this.serviceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serviceBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.serviceBtn.IconChar = FontAwesome.Sharp.IconChar.BellConcierge;
            this.serviceBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.serviceBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.serviceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serviceBtn.Location = new System.Drawing.Point(0, 362);
            this.serviceBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.serviceBtn.Name = "serviceBtn";
            this.serviceBtn.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.serviceBtn.Size = new System.Drawing.Size(225, 49);
            this.serviceBtn.TabIndex = 12;
            this.serviceBtn.Text = "Services";
            this.serviceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serviceBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.serviceBtn.UseVisualStyleBackColor = true;
            this.serviceBtn.Click += new System.EventHandler(this.serviceBtn_Click);
            // 
            // roomBtn
            // 
            this.roomBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomBtn.FlatAppearance.BorderSize = 0;
            this.roomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.roomBtn.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.roomBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.roomBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roomBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomBtn.Location = new System.Drawing.Point(0, 313);
            this.roomBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roomBtn.Name = "roomBtn";
            this.roomBtn.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.roomBtn.Size = new System.Drawing.Size(225, 49);
            this.roomBtn.TabIndex = 10;
            this.roomBtn.Text = "Rooms";
            this.roomBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roomBtn.UseVisualStyleBackColor = true;
            this.roomBtn.Click += new System.EventHandler(this.roomBtn_Click);
            // 
            // bookingBtn
            // 
            this.bookingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookingBtn.FlatAppearance.BorderSize = 0;
            this.bookingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.bookingBtn.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            this.bookingBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.bookingBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bookingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingBtn.Location = new System.Drawing.Point(0, 264);
            this.bookingBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookingBtn.Name = "bookingBtn";
            this.bookingBtn.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.bookingBtn.Size = new System.Drawing.Size(225, 49);
            this.bookingBtn.TabIndex = 15;
            this.bookingBtn.Text = "Booking";
            this.bookingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bookingBtn.UseVisualStyleBackColor = true;
            this.bookingBtn.Click += new System.EventHandler(this.bookingBtn_Click);
            // 
            // bookingDetailBtn
            // 
            this.bookingDetailBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookingDetailBtn.FlatAppearance.BorderSize = 0;
            this.bookingDetailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingDetailBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingDetailBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.bookingDetailBtn.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.bookingDetailBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.bookingDetailBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bookingDetailBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingDetailBtn.Location = new System.Drawing.Point(0, 215);
            this.bookingDetailBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookingDetailBtn.Name = "bookingDetailBtn";
            this.bookingDetailBtn.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.bookingDetailBtn.Size = new System.Drawing.Size(225, 49);
            this.bookingDetailBtn.TabIndex = 11;
            this.bookingDetailBtn.Text = "Booking Detail";
            this.bookingDetailBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingDetailBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bookingDetailBtn.UseVisualStyleBackColor = true;
            this.bookingDetailBtn.Click += new System.EventHandler(this.bookingDetailBtn_Click);
            // 
            // userDetailBtn
            // 
            this.userDetailBtn.FlatAppearance.BorderSize = 0;
            this.userDetailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userDetailBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDetailBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.userDetailBtn.IconChar = FontAwesome.Sharp.IconChar.Dashcube;
            this.userDetailBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.userDetailBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userDetailBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userDetailBtn.Location = new System.Drawing.Point(-2, 720);
            this.userDetailBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userDetailBtn.Name = "userDetailBtn";
            this.userDetailBtn.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.userDetailBtn.Size = new System.Drawing.Size(223, 76);
            this.userDetailBtn.TabIndex = 14;
            this.userDetailBtn.Text = "Customer Detail";
            this.userDetailBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userDetailBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userDetailBtn.UseVisualStyleBackColor = true;
            this.userDetailBtn.Click += new System.EventHandler(this.userDetailBtn_Click);
            // 
            // userBtn
            // 
            this.userBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.userBtn.FlatAppearance.BorderSize = 0;
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.userBtn.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.userBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.userBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userBtn.Location = new System.Drawing.Point(0, 166);
            this.userBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userBtn.Name = "userBtn";
            this.userBtn.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.userBtn.Size = new System.Drawing.Size(225, 49);
            this.userBtn.TabIndex = 9;
            this.userBtn.Text = "Users List";
            this.userBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbName);
            this.panel3.Controls.Add(this.lbRole);
            this.panel3.Controls.Add(this.lbUserID);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 166);
            this.panel3.TabIndex = 8;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(14, 32);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 21);
            this.lbName.TabIndex = 4;
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.ForeColor = System.Drawing.Color.White;
            this.lbRole.Location = new System.Drawing.Point(77, 106);
            this.lbRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(0, 19);
            this.lbRole.TabIndex = 3;
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.ForeColor = System.Drawing.Color.White;
            this.lbUserID.Location = new System.Drawing.Point(122, 69);
            this.lbUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(0, 19);
            this.lbUserID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Role:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // InteractionInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InteractionInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel leftPanel;
        private FontAwesome.Sharp.IconButton productBtn;
        private FontAwesome.Sharp.IconButton serviceBtn;
        private FontAwesome.Sharp.IconButton roomBtn;
        private FontAwesome.Sharp.IconButton bookingBtn;
        private FontAwesome.Sharp.IconButton bookingDetailBtn;
        private FontAwesome.Sharp.IconButton userDetailBtn;
        private FontAwesome.Sharp.IconButton userBtn;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton customersBtn;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton checkOutBtn;
        private FontAwesome.Sharp.IconButton servicesBookingBtn;
        private FontAwesome.Sharp.IconButton roomBookingBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbName;
    }
}