namespace Media_Player_V2
{
    partial class FRM_CLOSEPROGRAM
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CLOSEPROGRAM));
            this.numericUpDown_Gio = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Phut = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Giay = new System.Windows.Forms.NumericUpDown();
            this.label_gio = new System.Windows.Forms.Label();
            this.label_Phut = new System.Windows.Forms.Label();
            this.label_Giay = new System.Windows.Forms.Label();
            this.button_DatGio = new System.Windows.Forms.Button();
            this.button_Huy = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel_TrangThai = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_ThoiGianConLai = new System.Windows.Forms.ToolStripLabel();
            this.label_ThoiGianHienTai = new System.Windows.Forms.Label();
            this.label_ThoiGianDaHen = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_Ngay = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.radioButton_CoTatMay = new System.Windows.Forms.RadioButton();
            this.radioButton_KhongTatMay = new System.Windows.Forms.RadioButton();
            this.label_tatmay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Gio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Phut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Giay)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_Gio
            // 
            this.numericUpDown_Gio.Location = new System.Drawing.Point(92, 137);
            this.numericUpDown_Gio.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown_Gio.Name = "numericUpDown_Gio";
            this.numericUpDown_Gio.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown_Gio.TabIndex = 1;
            // 
            // numericUpDown_Phut
            // 
            this.numericUpDown_Phut.Location = new System.Drawing.Point(227, 137);
            this.numericUpDown_Phut.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown_Phut.Name = "numericUpDown_Phut";
            this.numericUpDown_Phut.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown_Phut.TabIndex = 2;
            // 
            // numericUpDown_Giay
            // 
            this.numericUpDown_Giay.Location = new System.Drawing.Point(351, 137);
            this.numericUpDown_Giay.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown_Giay.Name = "numericUpDown_Giay";
            this.numericUpDown_Giay.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown_Giay.TabIndex = 3;
            // 
            // label_gio
            // 
            this.label_gio.AutoSize = true;
            this.label_gio.Location = new System.Drawing.Point(31, 139);
            this.label_gio.Name = "label_gio";
            this.label_gio.Size = new System.Drawing.Size(23, 13);
            this.label_gio.TabIndex = 1;
            this.label_gio.Text = "Giờ";
            // 
            // label_Phut
            // 
            this.label_Phut.AutoSize = true;
            this.label_Phut.Location = new System.Drawing.Point(163, 139);
            this.label_Phut.Name = "label_Phut";
            this.label_Phut.Size = new System.Drawing.Size(29, 13);
            this.label_Phut.TabIndex = 1;
            this.label_Phut.Text = "Phút";
            this.label_Phut.Click += new System.EventHandler(this.label_Phut_Click);
            // 
            // label_Giay
            // 
            this.label_Giay.AutoSize = true;
            this.label_Giay.Location = new System.Drawing.Point(298, 139);
            this.label_Giay.Name = "label_Giay";
            this.label_Giay.Size = new System.Drawing.Size(28, 13);
            this.label_Giay.TabIndex = 1;
            this.label_Giay.Text = "Giây";
            // 
            // button_DatGio
            // 
            this.button_DatGio.Location = new System.Drawing.Point(92, 208);
            this.button_DatGio.Name = "button_DatGio";
            this.button_DatGio.Size = new System.Drawing.Size(75, 23);
            this.button_DatGio.TabIndex = 4;
            this.button_DatGio.Text = "Đặt giờ";
            this.button_DatGio.UseVisualStyleBackColor = true;
            this.button_DatGio.Click += new System.EventHandler(this.button_DatGio_Click);
            // 
            // button_Huy
            // 
            this.button_Huy.Location = new System.Drawing.Point(217, 208);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(75, 23);
            this.button_Huy.TabIndex = 5;
            this.button_Huy.Text = "Hủy lệnh";
            this.button_Huy.UseVisualStyleBackColor = true;
            this.button_Huy.Click += new System.EventHandler(this.button_Huy_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.Location = new System.Drawing.Point(341, 208);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(75, 23);
            this.button_Thoat.TabIndex = 6;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_title.Location = new System.Drawing.Point(95, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(303, 31);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Hẹn giờ tắt chương trình";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_TrangThai,
            this.toolStripLabel_ThoiGianConLai});
            this.toolStrip1.Location = new System.Drawing.Point(0, 247);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(466, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel_TrangThai
            // 
            this.toolStripLabel_TrangThai.Name = "toolStripLabel_TrangThai";
            this.toolStripLabel_TrangThai.Size = new System.Drawing.Size(94, 22);
            this.toolStripLabel_TrangThai.Text = "Không kích hoạt";
            // 
            // toolStripLabel_ThoiGianConLai
            // 
            this.toolStripLabel_ThoiGianConLai.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel_ThoiGianConLai.Name = "toolStripLabel_ThoiGianConLai";
            this.toolStripLabel_ThoiGianConLai.Size = new System.Drawing.Size(60, 22);
            this.toolStripLabel_ThoiGianConLai.Text = "Waiting....";
            // 
            // label_ThoiGianHienTai
            // 
            this.label_ThoiGianHienTai.AutoSize = true;
            this.label_ThoiGianHienTai.Location = new System.Drawing.Point(138, 49);
            this.label_ThoiGianHienTai.Name = "label_ThoiGianHienTai";
            this.label_ThoiGianHienTai.Size = new System.Drawing.Size(49, 13);
            this.label_ThoiGianHienTai.TabIndex = 1;
            this.label_ThoiGianHienTai.Text = "00:00:00";
            // 
            // label_ThoiGianDaHen
            // 
            this.label_ThoiGianDaHen.AutoSize = true;
            this.label_ThoiGianDaHen.Location = new System.Drawing.Point(138, 72);
            this.label_ThoiGianDaHen.Name = "label_ThoiGianDaHen";
            this.label_ThoiGianDaHen.Size = new System.Drawing.Size(49, 13);
            this.label_ThoiGianDaHen.TabIndex = 1;
            this.label_ThoiGianDaHen.Text = "00:00:00";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label_Ngay
            // 
            this.label_Ngay.AutoSize = true;
            this.label_Ngay.Location = new System.Drawing.Point(31, 99);
            this.label_Ngay.Name = "label_Ngay";
            this.label_Ngay.Size = new System.Drawing.Size(32, 13);
            this.label_Ngay.TabIndex = 1;
            this.label_Ngay.Text = "Ngày";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // radioButton_CoTatMay
            // 
            this.radioButton_CoTatMay.AutoSize = true;
            this.radioButton_CoTatMay.Location = new System.Drawing.Point(92, 170);
            this.radioButton_CoTatMay.Name = "radioButton_CoTatMay";
            this.radioButton_CoTatMay.Size = new System.Drawing.Size(38, 17);
            this.radioButton_CoTatMay.TabIndex = 7;
            this.radioButton_CoTatMay.Text = "Có";
            this.radioButton_CoTatMay.UseVisualStyleBackColor = true;
            // 
            // radioButton_KhongTatMay
            // 
            this.radioButton_KhongTatMay.AutoSize = true;
            this.radioButton_KhongTatMay.Checked = true;
            this.radioButton_KhongTatMay.Location = new System.Drawing.Point(219, 170);
            this.radioButton_KhongTatMay.Name = "radioButton_KhongTatMay";
            this.radioButton_KhongTatMay.Size = new System.Drawing.Size(56, 17);
            this.radioButton_KhongTatMay.TabIndex = 7;
            this.radioButton_KhongTatMay.TabStop = true;
            this.radioButton_KhongTatMay.Text = "Không";
            this.radioButton_KhongTatMay.UseVisualStyleBackColor = true;
            // 
            // label_tatmay
            // 
            this.label_tatmay.AutoSize = true;
            this.label_tatmay.Location = new System.Drawing.Point(31, 172);
            this.label_tatmay.Name = "label_tatmay";
            this.label_tatmay.Size = new System.Drawing.Size(45, 13);
            this.label_tatmay.TabIndex = 1;
            this.label_tatmay.Text = "Tắt máy";
            // 
            // FRM_CloseProGram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(466, 272);
            this.Controls.Add(this.radioButton_KhongTatMay);
            this.Controls.Add(this.radioButton_CoTatMay);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_Huy);
            this.Controls.Add(this.button_DatGio);
            this.Controls.Add(this.label_Giay);
            this.Controls.Add(this.label_Phut);
            this.Controls.Add(this.label_ThoiGianDaHen);
            this.Controls.Add(this.label_ThoiGianHienTai);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_Ngay);
            this.Controls.Add(this.label_tatmay);
            this.Controls.Add(this.label_gio);
            this.Controls.Add(this.numericUpDown_Giay);
            this.Controls.Add(this.numericUpDown_Phut);
            this.Controls.Add(this.numericUpDown_Gio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_CloseProGram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hẹn giờ tắt chương trình";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Gio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Phut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Giay)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_Gio;
        private System.Windows.Forms.NumericUpDown numericUpDown_Phut;
        private System.Windows.Forms.NumericUpDown numericUpDown_Giay;
        private System.Windows.Forms.Label label_gio;
        private System.Windows.Forms.Label label_Phut;
        private System.Windows.Forms.Label label_Giay;
        private System.Windows.Forms.Button button_DatGio;
        private System.Windows.Forms.Button button_Huy;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.ToolStrip toolStrip1;
        internal System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_TrangThai;
        private System.Windows.Forms.Label label_ThoiGianHienTai;
        private System.Windows.Forms.Label label_ThoiGianDaHen;
        internal System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_ThoiGianConLai;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_Ngay;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton radioButton_KhongTatMay;
        private System.Windows.Forms.RadioButton radioButton_CoTatMay;
        private System.Windows.Forms.Label label_tatmay;
    }
}