namespace QuanLiSachTruyen.UI
{
    partial class SachChoThue
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SachChoThue));
            this.cmbPhanLoai = new MetroFramework.Controls.MetroComboBox();
            this.txtTimKiem = new MetroFramework.Controls.MetroTextBox();
            this.gridSach = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnChoThue = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSach)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPhanLoai
            // 
            this.cmbPhanLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPhanLoai.FormattingEnabled = true;
            this.cmbPhanLoai.ItemHeight = 23;
            this.cmbPhanLoai.Items.AddRange(new object[] {
            "Tìm theo khách hàng",
            "Tìm theo tên sách"});
            this.cmbPhanLoai.Location = new System.Drawing.Point(292, 25);
            this.cmbPhanLoai.Name = "cmbPhanLoai";
            this.cmbPhanLoai.PromptText = "Tìm kiếm tất cả";
            this.cmbPhanLoai.Size = new System.Drawing.Size(165, 29);
            this.cmbPhanLoai.Sorted = true;
            this.cmbPhanLoai.TabIndex = 9;
            this.cmbPhanLoai.UseSelectable = true;
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.CustomButton.Image = null;
            this.txtTimKiem.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.txtTimKiem.CustomButton.Name = "";
            this.txtTimKiem.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtTimKiem.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTimKiem.CustomButton.TabIndex = 1;
            this.txtTimKiem.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTimKiem.CustomButton.UseSelectable = true;
            this.txtTimKiem.CustomButton.Visible = false;
            this.txtTimKiem.DisplayIcon = true;
            this.txtTimKiem.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTimKiem.Lines = new string[0];
            this.txtTimKiem.Location = new System.Drawing.Point(35, 25);
            this.txtTimKiem.MaxLength = 32767;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PromptText = "Tìm kiếm";
            this.txtTimKiem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.SelectionLength = 0;
            this.txtTimKiem.SelectionStart = 0;
            this.txtTimKiem.ShortcutsEnabled = true;
            this.txtTimKiem.Size = new System.Drawing.Size(252, 29);
            this.txtTimKiem.TabIndex = 8;
            this.txtTimKiem.UseSelectable = true;
            this.txtTimKiem.WaterMark = "Tìm kiếm";
            this.txtTimKiem.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTimKiem.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // gridSach
            // 
            this.gridSach.AllowUserToAddRows = false;
            this.gridSach.AllowUserToDeleteRows = false;
            this.gridSach.AllowUserToResizeRows = false;
            this.gridSach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSach.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridSach.EnableHeadersVisualStyles = false;
            this.gridSach.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridSach.Location = new System.Drawing.Point(35, 77);
            this.gridSach.Name = "gridSach";
            this.gridSach.ReadOnly = true;
            this.gridSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridSach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSach.Size = new System.Drawing.Size(623, 348);
            this.gridSach.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Orchid;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(244, 27);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(41, 27);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnChoThue
            // 
            this.btnChoThue.BackColor = System.Drawing.Color.Orchid;
            this.btnChoThue.FlatAppearance.BorderSize = 0;
            this.btnChoThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoThue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoThue.ForeColor = System.Drawing.Color.White;
            this.btnChoThue.Image = ((System.Drawing.Image)(resources.GetObject("btnChoThue.Image")));
            this.btnChoThue.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChoThue.Location = new System.Drawing.Point(664, 159);
            this.btnChoThue.Name = "btnChoThue";
            this.btnChoThue.Size = new System.Drawing.Size(94, 62);
            this.btnChoThue.TabIndex = 10;
            this.btnChoThue.Text = "Xem sách";
            this.btnChoThue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChoThue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChoThue.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(664, 227);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 62);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Orchid;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(664, 295);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 62);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(664, 363);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 62);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumOrchid;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(664, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 62);
            this.button1.TabIndex = 11;
            this.button1.Text = "Khách hàng";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Tìm theo khách hàng",
            "Tìm theo tên sách"});
            this.metroComboBox1.Location = new System.Drawing.Point(463, 25);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.PromptText = "Sắp xếp";
            this.metroComboBox1.Size = new System.Drawing.Size(165, 29);
            this.metroComboBox1.Sorted = true;
            this.metroComboBox1.TabIndex = 9;
            this.metroComboBox1.UseSelectable = true;
            // 
            // SachChoThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.cmbPhanLoai);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.gridSach);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnChoThue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Name = "SachChoThue";
            this.Size = new System.Drawing.Size(793, 453);
            ((System.ComponentModel.ISupportInitialize)(this.gridSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbPhanLoai;
        private MetroFramework.Controls.MetroTextBox txtTimKiem;
        private MetroFramework.Controls.MetroGrid gridSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnChoThue;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
    }
}
