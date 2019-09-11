namespace Media_Player_V2
{
    partial class FRM_INFO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_INFO));
            this.linkLabel_Contact = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Exit = new System.Windows.Forms.LinkLabel();
            this.linkLabel_TacGia = new System.Windows.Forms.LinkLabel();
            this.label_Info2 = new System.Windows.Forms.Label();
            this.label_Info1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel_Contact
            // 
            this.linkLabel_Contact.AutoSize = true;
            this.linkLabel_Contact.Location = new System.Drawing.Point(320, 279);
            this.linkLabel_Contact.Name = "linkLabel_Contact";
            this.linkLabel_Contact.Size = new System.Drawing.Size(106, 13);
            this.linkLabel_Contact.TabIndex = 10;
            this.linkLabel_Contact.TabStop = true;
            this.linkLabel_Contact.Text = "Liên hệ với chúng tôi";
            this.linkLabel_Contact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel_Exit
            // 
            this.linkLabel_Exit.AutoSize = true;
            this.linkLabel_Exit.Location = new System.Drawing.Point(655, 318);
            this.linkLabel_Exit.Name = "linkLabel_Exit";
            this.linkLabel_Exit.Size = new System.Drawing.Size(35, 13);
            this.linkLabel_Exit.TabIndex = 11;
            this.linkLabel_Exit.TabStop = true;
            this.linkLabel_Exit.Text = "Thoát";
            this.linkLabel_Exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel_TacGia
            // 
            this.linkLabel_TacGia.AutoSize = true;
            this.linkLabel_TacGia.Location = new System.Drawing.Point(320, 254);
            this.linkLabel_TacGia.Name = "linkLabel_TacGia";
            this.linkLabel_TacGia.Size = new System.Drawing.Size(43, 13);
            this.linkLabel_TacGia.TabIndex = 12;
            this.linkLabel_TacGia.TabStop = true;
            this.linkLabel_TacGia.Text = "Tác giả";
            this.linkLabel_TacGia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label_Info2
            // 
            this.label_Info2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Info2.Location = new System.Drawing.Point(320, 176);
            this.label_Info2.Name = "label_Info2";
            this.label_Info2.Size = new System.Drawing.Size(392, 64);
            this.label_Info2.TabIndex = 8;
            this.label_Info2.Text = resources.GetString("label_Info2.Text");
            // 
            // label_Info1
            // 
            this.label_Info1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Info1.Location = new System.Drawing.Point(320, 122);
            this.label_Info1.Name = "label_Info1";
            this.label_Info1.Size = new System.Drawing.Size(389, 54);
            this.label_Info1.TabIndex = 9;
            this.label_Info1.Text = "VTV Media Player là phần mềm hoàn toàn miễn phí,được xây dựng dựa trên nền tảng V" +
    "LC LIB và cùng nhiều open source khác";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(316, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Version: 1.0 Beta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(311, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "VTV Media Player ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FRM_INFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(743, 344);
            this.Controls.Add(this.linkLabel_Contact);
            this.Controls.Add(this.linkLabel_Exit);
            this.Controls.Add(this.linkLabel_TacGia);
            this.Controls.Add(this.label_Info2);
            this.Controls.Add(this.label_Info1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_INFO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About us";
            this.Load += new System.EventHandler(this.FRM_INFO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel_Contact;
        private System.Windows.Forms.LinkLabel linkLabel_Exit;
        private System.Windows.Forms.LinkLabel linkLabel_TacGia;
        private System.Windows.Forms.Label label_Info2;
        private System.Windows.Forms.Label label_Info1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}