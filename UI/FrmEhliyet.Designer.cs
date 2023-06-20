namespace NufusMudurluguUygulamasi.UI
{
    partial class FrmEhliyet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listEhliyetSınıfları = new System.Windows.Forms.CheckedListBox();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.txtTc = new System.Windows.Forms.MaskedTextBox();
            this.kontrolAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vatandaş Tc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ehliyet Sınıfı:";
            // 
            // listEhliyetSınıfları
            // 
            this.listEhliyetSınıfları.FormattingEnabled = true;
            this.listEhliyetSınıfları.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A",
            "B1",
            "B",
            "BE",
            "C1",
            "C1E",
            "C",
            "CE",
            "D1",
            "D1E",
            "D",
            "DE",
            "F",
            "G"});
            this.listEhliyetSınıfları.Location = new System.Drawing.Point(131, 102);
            this.listEhliyetSınıfları.Name = "listEhliyetSınıfları";
            this.listEhliyetSınıfları.Size = new System.Drawing.Size(142, 244);
            this.listEhliyetSınıfları.TabIndex = 1;
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(279, 26);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(75, 23);
            this.btnKontrol.TabIndex = 3;
            this.btnKontrol.Text = "Kontrol";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(131, 26);
            this.txtTc.Mask = "00000000000";
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(142, 20);
            this.txtTc.TabIndex = 4;
            // 
            // kontrolAd
            // 
            this.kontrolAd.Location = new System.Drawing.Point(131, 64);
            this.kontrolAd.Name = "kontrolAd";
            this.kontrolAd.ReadOnly = true;
            this.kontrolAd.Size = new System.Drawing.Size(142, 20);
            this.kontrolAd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vatandaş Ad Soyad:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(240, 381);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(114, 41);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "İptal";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(120, 381);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(114, 41);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Tamam";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmEhliyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 440);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.kontrolAd);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.listEhliyetSınıfları);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmEhliyet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmEhliyet";
            this.Load += new System.EventHandler(this.FrmEhliyet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox listEhliyetSınıfları;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.MaskedTextBox txtTc;
        private System.Windows.Forms.TextBox kontrolAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}