namespace Media_Player_V2
{
    partial class FRM_TAOLISTNHAC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_TAOLISTNHAC));
            this.button_Tao = new System.Windows.Forms.Button();
            this.textBox_TenList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Tao
            // 
            this.button_Tao.Location = new System.Drawing.Point(129, 63);
            this.button_Tao.Name = "button_Tao";
            this.button_Tao.Size = new System.Drawing.Size(75, 23);
            this.button_Tao.TabIndex = 1;
            this.button_Tao.Text = "Tạo";
            this.button_Tao.UseVisualStyleBackColor = true;
            this.button_Tao.Click += new System.EventHandler(this.button_Tao_Click);
            // 
            // textBox_TenList
            // 
            this.textBox_TenList.Location = new System.Drawing.Point(129, 18);
            this.textBox_TenList.Name = "textBox_TenList";
            this.textBox_TenList.Size = new System.Drawing.Size(167, 20);
            this.textBox_TenList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập tên list";
            // 
            // button_Thoat
            // 
            this.button_Thoat.Location = new System.Drawing.Point(221, 63);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(75, 23);
            this.button_Thoat.TabIndex = 2;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FRM_TaoListNhac
            // 
            this.AcceptButton = this.button_Tao;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 98);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_TenList);
            this.Controls.Add(this.button_Tao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_TaoListNhac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo list nhạc";
            this.Load += new System.EventHandler(this.FRM_TaoListNhac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Tao;
        private System.Windows.Forms.TextBox textBox_TenList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}