namespace HotelManagement_ADO.AdminForms
{
    partial class DamagedItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.txtitemName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtdiPrice = new System.Windows.Forms.TextBox();
            this.txtdiAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbookID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.dgvDAMAGEDITEM = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtitemID = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDAMAGEDITEM)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1249, 616);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 49);
            this.btnCancel.TabIndex = 162;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel.Controls.Add(this.txtitemID);
            this.panel.Controls.Add(this.txtitemName);
            this.panel.Controls.Add(this.txtdiPrice);
            this.panel.Controls.Add(this.txtdiAmount);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txtbookID);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.lb1);
            this.panel.Location = new System.Drawing.Point(18, 86);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(455, 442);
            this.panel.TabIndex = 165;
            // 
            // txtitemName
            // 
            this.txtitemName.BackColor = System.Drawing.Color.Transparent;
            this.txtitemName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtitemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtitemName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtitemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtitemName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtitemName.ItemHeight = 30;
            this.txtitemName.Items.AddRange(new object[] {
            "Bathrobe",
            "Bedsheet",
            "Duvet",
            "Hanger",
            "Pillow",
            "Slippers",
            "Towel"});
            this.txtitemName.Location = new System.Drawing.Point(231, 194);
            this.txtitemName.Name = "txtitemName";
            this.txtitemName.Size = new System.Drawing.Size(180, 36);
            this.txtitemName.TabIndex = 23;
            // 
            // txtdiPrice
            // 
            this.txtdiPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiPrice.Location = new System.Drawing.Point(231, 361);
            this.txtdiPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiPrice.Name = "txtdiPrice";
            this.txtdiPrice.Size = new System.Drawing.Size(180, 30);
            this.txtdiPrice.TabIndex = 22;
            // 
            // txtdiAmount
            // 
            this.txtdiAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiAmount.Location = new System.Drawing.Point(231, 275);
            this.txtdiAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiAmount.Name = "txtdiAmount";
            this.txtdiAmount.Size = new System.Drawing.Size(180, 30);
            this.txtdiAmount.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(53, 366);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 280);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Amount";
            // 
            // txtbookID
            // 
            this.txtbookID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookID.Location = new System.Drawing.Point(231, 34);
            this.txtbookID.Margin = new System.Windows.Forms.Padding(4);
            this.txtbookID.Name = "txtbookID";
            this.txtbookID.Size = new System.Drawing.Size(180, 30);
            this.txtbookID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Booking ID";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.Color.Transparent;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.White;
            this.lb1.Location = new System.Drawing.Point(53, 118);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(80, 25);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Item ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(371, 616);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(147, 49);
            this.btnDelete.TabIndex = 163;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(795, 616);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 49);
            this.btnBack.TabIndex = 164;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(18, 616);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(147, 49);
            this.btnAdd.TabIndex = 159;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(595, 616);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(147, 49);
            this.btnReload.TabIndex = 158;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1413, 616);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 49);
            this.btnSave.TabIndex = 161;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFix
            // 
            this.btnFix.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFix.Location = new System.Drawing.Point(193, 616);
            this.btnFix.Margin = new System.Windows.Forms.Padding(4);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(147, 49);
            this.btnFix.TabIndex = 160;
            this.btnFix.Text = "Update";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // dgvDAMAGEDITEM
            // 
            this.dgvDAMAGEDITEM.AllowUserToResizeColumns = false;
            this.dgvDAMAGEDITEM.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDAMAGEDITEM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDAMAGEDITEM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDAMAGEDITEM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDAMAGEDITEM.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDAMAGEDITEM.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDAMAGEDITEM.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDAMAGEDITEM.Location = new System.Drawing.Point(499, 86);
            this.dgvDAMAGEDITEM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDAMAGEDITEM.Name = "dgvDAMAGEDITEM";
            this.dgvDAMAGEDITEM.ReadOnly = true;
            this.dgvDAMAGEDITEM.RowHeadersVisible = false;
            this.dgvDAMAGEDITEM.RowHeadersWidth = 51;
            this.dgvDAMAGEDITEM.RowTemplate.Height = 24;
            this.dgvDAMAGEDITEM.Size = new System.Drawing.Size(1036, 442);
            this.dgvDAMAGEDITEM.TabIndex = 166;
            this.dgvDAMAGEDITEM.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDAMAGEDITEM.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDAMAGEDITEM.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDAMAGEDITEM.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDAMAGEDITEM.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDAMAGEDITEM.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDAMAGEDITEM.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDAMAGEDITEM.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDAMAGEDITEM.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDAMAGEDITEM.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDAMAGEDITEM.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDAMAGEDITEM.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDAMAGEDITEM.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvDAMAGEDITEM.ThemeStyle.ReadOnly = true;
            this.dgvDAMAGEDITEM.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDAMAGEDITEM.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDAMAGEDITEM.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDAMAGEDITEM.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDAMAGEDITEM.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDAMAGEDITEM.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDAMAGEDITEM.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDAMAGEDITEM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDAMAGEDITEM_CellClick);
            // 
            // txtitemID
            // 
            this.txtitemID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemID.Location = new System.Drawing.Point(231, 113);
            this.txtitemID.Margin = new System.Windows.Forms.Padding(4);
            this.txtitemID.Name = "txtitemID";
            this.txtitemID.Size = new System.Drawing.Size(180, 30);
            this.txtitemID.TabIndex = 24;
            // 
            // DamagedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1579, 750);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.dgvDAMAGEDITEM);
            this.Name = "DamagedItem";
            this.Text = "DamagedItem";
            this.Load += new System.EventHandler(this.DamagedItem_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDAMAGEDITEM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel;
        private Guna.UI2.WinForms.Guna2ComboBox txtitemName;
        private System.Windows.Forms.TextBox txtdiPrice;
        private System.Windows.Forms.TextBox txtdiAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbookID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFix;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDAMAGEDITEM;
        private System.Windows.Forms.TextBox txtitemID;
    }
}