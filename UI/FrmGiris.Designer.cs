namespace NufusMudurluguUygulamasi.UI
{
    partial class FrmGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciad = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.GirisBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // txtKullaniciad
            // 
            this.txtKullaniciad.Location = new System.Drawing.Point(104, 12);
            this.txtKullaniciad.Name = "txtKullaniciad";
            this.txtKullaniciad.Size = new System.Drawing.Size(115, 20);
            this.txtKullaniciad.TabIndex = 2;
            this.txtKullaniciad.Text = "root";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(104, 38);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(115, 20);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.Text = "root";
            // 
            // GirisBtn
            // 
            this.GirisBtn.Location = new System.Drawing.Point(85, 75);
            this.GirisBtn.Name = "GirisBtn";
            this.GirisBtn.Size = new System.Drawing.Size(119, 46);
            this.GirisBtn.TabIndex = 3;
            this.GirisBtn.Text = "Giris";
            this.GirisBtn.UseVisualStyleBackColor = true;
            this.GirisBtn.Click += new System.EventHandler(this.GirisBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(225, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 144);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.GirisBtn);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciad;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button GirisBtn;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}