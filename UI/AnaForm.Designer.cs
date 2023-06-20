namespace NufusMudurluguUygulamasi
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnVatandasEkle = new System.Windows.Forms.ToolStripButton();
            this.btnVatandasDuzenle = new System.Windows.Forms.ToolStripButton();
            this.btnVatandasSil = new System.Windows.Forms.ToolStripButton();
            this.BtnVatandasBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnEhliyetEkle = new System.Windows.Forms.ToolStripButton();
            this.btnEhliyetDüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnEhliyetSil = new System.Windows.Forms.ToolStripButton();
            this.btnEhliyetBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(849, 469);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(841, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vatandaşlar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 34);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(835, 406);
            this.dataGridView1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVatandasEkle,
            this.btnVatandasDuzenle,
            this.btnVatandasSil,
            this.BtnVatandasBul,
            this.toolStripTextBox1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(835, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Click += new System.EventHandler(this.toolStrip1_Click);
            // 
            // btnVatandasEkle
            // 
            this.btnVatandasEkle.Image = global::NufusMudurluguUygulamasi.Properties.Resources.database_user_add;
            this.btnVatandasEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVatandasEkle.Name = "btnVatandasEkle";
            this.btnVatandasEkle.Size = new System.Drawing.Size(56, 28);
            this.btnVatandasEkle.Text = "Ekle";
            this.btnVatandasEkle.Click += new System.EventHandler(this.btnVatandasEkle_Click);
            // 
            // btnVatandasDuzenle
            // 
            this.btnVatandasDuzenle.Image = global::NufusMudurluguUygulamasi.Properties.Resources.database_user_edit;
            this.btnVatandasDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVatandasDuzenle.Name = "btnVatandasDuzenle";
            this.btnVatandasDuzenle.Size = new System.Drawing.Size(77, 28);
            this.btnVatandasDuzenle.Text = "Düzenle";
            this.btnVatandasDuzenle.Click += new System.EventHandler(this.btnVatandasDuzenle_Click);
            // 
            // btnVatandasSil
            // 
            this.btnVatandasSil.Image = global::NufusMudurluguUygulamasi.Properties.Resources.database_user_cancel;
            this.btnVatandasSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVatandasSil.Name = "btnVatandasSil";
            this.btnVatandasSil.Size = new System.Drawing.Size(47, 28);
            this.btnVatandasSil.Text = "Sil";
            this.btnVatandasSil.Click += new System.EventHandler(this.btnVatandasSil_Click);
            // 
            // BtnVatandasBul
            // 
            this.BtnVatandasBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnVatandasBul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnVatandasBul.Image = global::NufusMudurluguUygulamasi.Properties.Resources.database_user_find;
            this.BtnVatandasBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnVatandasBul.Name = "BtnVatandasBul";
            this.BtnVatandasBul.Size = new System.Drawing.Size(28, 28);
            this.BtnVatandasBul.Text = "Bul";
            this.BtnVatandasBul.Click += new System.EventHandler(this.btnVatandasBul);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 23);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(28, 28);
            this.toolStripLabel1.Text = "Ara:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(841, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ehliyetler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridView2.Location = new System.Drawing.Point(3, 34);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(835, 406);
            this.dataGridView2.TabIndex = 3;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEhliyetEkle,
            this.btnEhliyetDüzenle,
            this.btnEhliyetSil,
            this.btnEhliyetBul,
            this.toolStripTextBox2,
            this.toolStripLabel2});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(835, 31);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnEhliyetEkle
            // 
            this.btnEhliyetEkle.Image = global::NufusMudurluguUygulamasi.Properties.Resources.access_card_man_add;
            this.btnEhliyetEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEhliyetEkle.Name = "btnEhliyetEkle";
            this.btnEhliyetEkle.Size = new System.Drawing.Size(56, 28);
            this.btnEhliyetEkle.Text = "Ekle";
            this.btnEhliyetEkle.Click += new System.EventHandler(this.btnEhliyetEkle_Click);
            // 
            // btnEhliyetDüzenle
            // 
            this.btnEhliyetDüzenle.Image = global::NufusMudurluguUygulamasi.Properties.Resources.access_card_man_edit;
            this.btnEhliyetDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEhliyetDüzenle.Name = "btnEhliyetDüzenle";
            this.btnEhliyetDüzenle.Size = new System.Drawing.Size(77, 28);
            this.btnEhliyetDüzenle.Text = "Düzenle";
            this.btnEhliyetDüzenle.Click += new System.EventHandler(this.btnEhliyetDüzenle_Click);
            // 
            // btnEhliyetSil
            // 
            this.btnEhliyetSil.Image = global::NufusMudurluguUygulamasi.Properties.Resources.access_card_man_cancel;
            this.btnEhliyetSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEhliyetSil.Name = "btnEhliyetSil";
            this.btnEhliyetSil.Size = new System.Drawing.Size(47, 28);
            this.btnEhliyetSil.Text = "Sil";
            this.btnEhliyetSil.Click += new System.EventHandler(this.btnEhliyetSil_Click);
            // 
            // btnEhliyetBul
            // 
            this.btnEhliyetBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnEhliyetBul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEhliyetBul.Image = global::NufusMudurluguUygulamasi.Properties.Resources.access_card_man_find;
            this.btnEhliyetBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEhliyetBul.Name = "btnEhliyetBul";
            this.btnEhliyetBul.Size = new System.Drawing.Size(28, 28);
            this.btnEhliyetBul.Text = "Bul";
            this.btnEhliyetBul.Click += new System.EventHandler(this.btnEhliyetBul_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(200, 23);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(28, 28);
            this.toolStripLabel2.Text = "Ara:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 447);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(849, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 469);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "AnaForm";
            this.Text = "Nüfus Müdürlüğü Yönetim";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnVatandasEkle;
        private System.Windows.Forms.ToolStripButton btnVatandasSil;
        private System.Windows.Forms.ToolStripButton btnVatandasDuzenle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton BtnVatandasBul;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnEhliyetEkle;
        private System.Windows.Forms.ToolStripButton btnEhliyetDüzenle;
        private System.Windows.Forms.ToolStripButton btnEhliyetSil;
        private System.Windows.Forms.ToolStripButton btnEhliyetBul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}

