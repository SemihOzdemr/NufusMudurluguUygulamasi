using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NufusMudurluguUygulamasi.BL;
using NufusMudurluguUygulamasi.UI;

namespace NufusMudurluguUygulamasi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void toolStrip1_Click(object sender, EventArgs e)
        {

        }

        private void btnVatandasEkle_Click(object sender, EventArgs e)
        {
            FrmVatandas frmVatandas = new FrmVatandas()
            {
                Text = "Vatandaş Ekle",
                Vatandas = new Vatandas() { }
            };

            var sonuc = frmVatandas.ShowDialog();

            if ( sonuc == DialogResult.OK )
            {
               bool b = BLogic.VatandasEkle(frmVatandas.Vatandas);
                if ( b )
                {
                    DataSet ds = BLogic.VatandasGetir("");
                    if( ds != null )
                        dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnVatandasBul(object sender, EventArgs e)
        {
            DataSet ds = BLogic.VatandasGetir(toolStripTextBox1.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.VatandasGetir("");
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];

            DataSet dse = BLogic.EhliyetGetir("");
            if (dse != null)
                dataGridView2.DataSource = dse.Tables[0];
        }

        private void btnVatandasDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            FrmVatandas frmVatandas = new FrmVatandas()
            {
                Text = "Vatandaş Güncelle",
                Güncelleme = true,
                Vatandas = new Vatandas()
                {
                    Tc = row.Cells[0].Value.ToString(),
                    Ad = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                    Telefon = row.Cells[3].Value.ToString(),
                    Cinsiyet = row.Cells[4].Value.ToString(),
                    DogumTarihi = row.Cells[5].Value.ToString(),
                    DogumYeri = row.Cells[6].Value.ToString(),
                    AnaAdı = row.Cells[7].Value.ToString(),
                    BabaAdı = row.Cells[8].Value.ToString(),
                    AnaTc = row.Cells[9].Value.ToString(),
                    BabaTc = row.Cells[10].Value.ToString(),
                    MedeniHali = row.Cells[11].Value.ToString(),
                    Adres = row.Cells[12].Value.ToString(),
                },

            };
                var sonuc = frmVatandas.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.VatandasGüncelle(frmVatandas.Vatandas);
                if (b)
                {
                    DataSet ds = BLogic.VatandasGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
            }






        
        }

        private void btnVatandasSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var Tc = row.Cells[0].Value.ToString();
           
            var sonuc = MessageBox.Show("Seçili Kayıt Silinsin mi ?", "Silmeyi Onayla", MessageBoxButtons.OKCancel,  MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.VatandasSil(Tc);
                if (b)
                {
                    DataSet ds = BLogic.VatandasGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnEhliyetEkle_Click(object sender, EventArgs e)
        {
            FrmEhliyet frmEhliyet = new FrmEhliyet()
            {
                Text = "Ehliyet Bilgileri",
                Ehliyet = new Ehliyet(),
                Vatandas = new Vatandas() 
            };

            var sonuc = frmEhliyet.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.EhliyetEkle(frmEhliyet.Ehliyet);
                if (b)
                {
                    DataSet ds = BLogic.EhliyetGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnEhliyetDüzenle_Click(object sender, EventArgs e)
        {


            DataGridViewRow row = dataGridView2.SelectedRows[0];
            FrmEhliyet frmEhliyet = new FrmEhliyet()
            {
                Text = "Ehliyet Güncelle",
                Güncelleme = true,
                Ehliyet = new Ehliyet()
                {
                    Id = row.Cells[0].Value.ToString(),
                    VatandasTc = row.Cells[1].Value.ToString(),
                    Sınıflar = row.Cells[2].Value.ToString()
                }   

            };
            var sonuc = frmEhliyet.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.EhliyetGüncelle(frmEhliyet.Ehliyet);
                if (b)
                {
                    DataSet ds = BLogic.EhliyetGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }
            }


        }

        private void btnEhliyetSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var Id = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili Kayıt Silinsin mi ?", "Silmeyi Onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.EhliyetSil(Id);
                if (b)
                {
                    DataSet ds = BLogic.EhliyetGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnEhliyetBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.EhliyetGetir(toolStripTextBox2.Text);
            if (ds != null)
                dataGridView2.DataSource = ds.Tables[0];
        }
    }
}
