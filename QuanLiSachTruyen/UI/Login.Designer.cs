namespace QuanLiSachTruyen.UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangNhap = new MetroFramework.Controls.MetroButton();
            this.txtMatKhau = new MetroFramework.Controls.MetroTextBox();
            this.txtDangNhap = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(377, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý thuê sách";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.txtDangNhap);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(331, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 352);
            this.panel1.TabIndex = 1;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnDangNhap.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDangNhap.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDangNhap.Location = new System.Drawing.Point(51, 261);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(229, 38);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDangNhap.UseCustomBackColor = true;
            this.btnDangNhap.UseSelectable = true;
            this.btnDangNhap.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMatKhau.CustomButton.Image = null;
            this.txtMatKhau.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtMatKhau.CustomButton.Name = "";
            this.txtMatKhau.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtMatKhau.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMatKhau.CustomButton.TabIndex = 1;
            this.txtMatKhau.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMatKhau.CustomButton.UseSelectable = true;
            this.txtMatKhau.CustomButton.Visible = false;
            this.txtMatKhau.DisplayIcon = true;
            this.txtMatKhau.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtMatKhau.Lines = new string[0];
            this.txtMatKhau.Location = new System.Drawing.Point(51, 206);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(7);
            this.txtMatKhau.MaxLength = 32767;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '●';
            this.txtMatKhau.PromptText = "Mật khẩu";
            this.txtMatKhau.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.SelectionLength = 0;
            this.txtMatKhau.SelectionStart = 0;
            this.txtMatKhau.ShortcutsEnabled = true;
            this.txtMatKhau.ShowClearButton = true;
            this.txtMatKhau.Size = new System.Drawing.Size(229, 38);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.UseCustomBackColor = true;
            this.txtMatKhau.UseCustomForeColor = true;
            this.txtMatKhau.UseSelectable = true;
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.WaterMark = "Mật khẩu";
            this.txtMatKhau.WaterMarkColor = System.Drawing.Color.Silver;
            this.txtMatKhau.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtDangNhap
            // 
            this.txtDangNhap.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDangNhap.CustomButton.Image = null;
            this.txtDangNhap.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtDangNhap.CustomButton.Name = "";
            this.txtDangNhap.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtDangNhap.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDangNhap.CustomButton.TabIndex = 1;
            this.txtDangNhap.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDangNhap.CustomButton.UseSelectable = true;
            this.txtDangNhap.CustomButton.Visible = false;
            this.txtDangNhap.DisplayIcon = true;
            this.txtDangNhap.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDangNhap.Lines = new string[0];
            this.txtDangNhap.Location = new System.Drawing.Point(51, 151);
            this.txtDangNhap.Margin = new System.Windows.Forms.Padding(7);
            this.txtDangNhap.MaxLength = 32767;
            this.txtDangNhap.Name = "txtDangNhap";
            this.txtDangNhap.PasswordChar = '\0';
            this.txtDangNhap.PromptText = "Tên đăng nhập";
            this.txtDangNhap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDangNhap.SelectedText = "";
            this.txtDangNhap.SelectionLength = 0;
            this.txtDangNhap.SelectionStart = 0;
            this.txtDangNhap.ShortcutsEnabled = true;
            this.txtDangNhap.ShowClearButton = true;
            this.txtDangNhap.Size = new System.Drawing.Size(229, 38);
            this.txtDangNhap.TabIndex = 1;
            this.txtDangNhap.UseCustomBackColor = true;
            this.txtDangNhap.UseSelectable = true;
            this.txtDangNhap.WaterMark = "Tên đăng nhập";
            this.txtDangNhap.WaterMarkColor = System.Drawing.Color.Silver;
            this.txtDangNhap.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(115, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(136, 305);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(54, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtDangNhap;
        private MetroFramework.Controls.MetroTextBox txtMatKhau;
        private MetroFramework.Controls.MetroButton btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
    }
}