using NufusMudurluguUygulamasi.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NufusMudurluguUygulamasi.UI
{
    public partial class FrmEhliyet : Form
    {
        public FrmEhliyet()
        {
            InitializeComponent();
        }

      

      
        public Ehliyet Ehliyet { get; set; }
        public Vatandas Vatandas { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            string b = BLogic.EhliyetVKontrol(txtTc.Text);

            if(b.Length > 0)
            {
              kontrolAd.Text = b;
            }
            else
            {
                MessageBox.Show("Girdiğiniz Kimlik Numarasına Kayıtlı Bir vatandaş Bulunamadı!");
            }
            
        }


        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtTc)) return;
            if (!ErrorControl(listEhliyetSınıfları)) return;
            if (!ErrorControl(kontrolAd)) return;

            List<string> checkedItems = new List<string>();

            foreach (var item in listEhliyetSınıfları.CheckedItems)
            {
                checkedItems.Add(item.ToString());
            }

            string result = string.Join(",", checkedItems);

            Ehliyet.Sınıflar = result;
            Ehliyet.VatandasTc = txtTc.Text;

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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


        private void FrmEhliyet_Load(object sender, EventArgs e)
        {
            if (Güncelleme)
            {
                txtTc.Text = Ehliyet.VatandasTc.ToString();

                string items = Ehliyet.Sınıflar;
                if (items != null)
                {
                    string[] itemArray = items.Split(',');
                    for (int i = 0; i < listEhliyetSınıfları.Items.Count; i++)
                    {
                        if (itemArray.Contains(listEhliyetSınıfları.Items[i].ToString()))
                        {
                            listEhliyetSınıfları.SetItemChecked(i, true);
                        }
                    }
                }

            }
            else
            {
            }
        

        


        }
    }
}
