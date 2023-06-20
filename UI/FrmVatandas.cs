using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NufusMudurluguUygulamasi.UI
{
    public partial class FrmVatandas : Form
    {

        
        public FrmVatandas()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Vatandas Vatandas { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtTc)) return;
            if (!ErrorControl(txtAd)) return;
            if (!ErrorControl(txtSoyad)) return;
            if (!ErrorControl(txtTel)) return;
            if (!ErrorControl(txtCinsiyet)) return;
            if (!ErrorControl(txtDogumTarihi)) return;
            if (!ErrorControl(txtDogumYeri)) return;
            if (!ErrorControl(txtAnneAd)) return;
            if (!ErrorControl(txtBabaAd)) return;
            if (!ErrorControl(txtAnneTc)) return;
            if (!ErrorControl(txtBabaTc)) return;
            if (!ErrorControl(txtMedeniHal)) return;
            if (!ErrorControl(txtAdres)) return;

            Vatandas.Tc = txtTc.Text;
            Vatandas.Ad = txtAd.Text;
            Vatandas.Soyad = txtSoyad.Text;
            Vatandas.Telefon = txtTel.Text;
            Vatandas.Cinsiyet = txtCinsiyet.Text;
            Vatandas.DogumTarihi = txtDogumTarihi.Value.ToString("dd.MM.yyyy");
            Vatandas.DogumYeri = txtDogumYeri.Text;
            Vatandas.AnaAdı = txtAnneAd.Text;
            Vatandas.BabaAdı = txtBabaAd.Text;
            Vatandas.AnaTc = txtAnneTc.Text;
            Vatandas.BabaTc = txtBabaTc.Text;
            Vatandas.MedeniHali = txtMedeniHal.Text;
            Vatandas.Adres = txtAdres.Text;

            DialogResult = DialogResult.OK;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya Hatalı Bilgi!");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }

            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
                {
                    errorProvider1.SetError(c, "Eksik veya Hatalı Bilgi!");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }

            if (c is ComboBox)
            {
                ComboBox comboBox = c as ComboBox;
                if (comboBox.SelectedItem == null)
                {
                    errorProvider1.SetError(c, "Eksik veya Hatalı Bilgi!");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }

            if (c is DateTimePicker)
            {
                DateTimePicker dateTimePicker = c as DateTimePicker;
                if (dateTimePicker.Value > DateTime.Now)
                {
                    errorProvider1.SetError(c, "Gelecek bir tarih seçilemez!");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }

            if (c is CheckedListBox)
            {
                CheckedListBox checkedListBox = c as CheckedListBox;
                if (checkedListBox.CheckedItems.Count == 0)
                {
                    errorProvider1.SetError(c, "En az bir öğe seçmelisiniz!");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }

            return true;
        }



        private void txtDogumTarihi_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void txtDogumTarihi_DropDown(object sender, EventArgs e)
        {
            
        }

        private void FrmVatandas_Load(object sender, EventArgs e)
        {
            if(Güncelleme)
            {
                txtTc.Text = Vatandas.Tc.ToString();
                txtAd.Text = Vatandas.Ad;
                txtSoyad.Text = Vatandas.Soyad;
                txtTel.Text = Vatandas.Telefon;
                txtCinsiyet.Text = Vatandas.Cinsiyet;
                try
{
    DateTime temp;
    if (DateTime.TryParse(Vatandas.DogumTarihi.ToString(), out temp))
    {
        txtDogumTarihi.Value = temp;
    }
    else
    {
        MessageBox.Show("Geçerli bir tarih değeri elde edilemedi.");
    }
}
catch (Exception exo)
{
    MessageBox.Show("hata: " + exo);
}




                txtDogumYeri.Text = Vatandas.DogumYeri;
                txtAnneAd.Text = Vatandas.AnaAdı;
                txtBabaAd.Text = Vatandas.BabaAdı;
                txtAnneTc.Text = Vatandas.AnaTc;
                txtBabaTc.Text = Vatandas.BabaTc;
                txtMedeniHal.Text = Vatandas.MedeniHali;
                txtAdres.Text = Vatandas.Adres;

            }
            else
            { 
            }
        }
    }
}
