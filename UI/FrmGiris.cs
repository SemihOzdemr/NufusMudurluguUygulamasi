using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NufusMudurluguUygulamasi.UI
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void GirisBtn_Click(object sender, EventArgs e)
        {
            if (txtKullaniciad.Text == "root" && txtSifre.Text == "root")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış. Lütfen tekrar deneyin.", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }
    }
}
