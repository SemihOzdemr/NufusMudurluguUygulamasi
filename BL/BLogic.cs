using NufusMudurluguUygulamasi.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NufusMudurluguUygulamasi.BL
{
    public static class BLogic
    {
        public static bool VatandasEkle(Vatandas m)
        {
            try
            {
                int res = DataLayer.VatandasEkle(m);
                return (res > 0);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return false;
            }
        
        }

        internal static bool EhliyetEkle(Ehliyet e)
        {
            try
            {
                int res = DataLayer.EhliyetEkle(e);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet EhliyetGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.EhliyetGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool EhliyetGüncelle(Ehliyet e)
        {
            try
            {
                int res = DataLayer.EhliyetGüncelle(e);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool EhliyetSil(string ıd)
        {
            try
            {
                int res = DataLayer.EhliyetSil(ıd);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return false;
            }
        }

        internal static string EhliyetVKontrol(string tc)
        {
            try
            {
                string res = DataLayer.EhliyetVKontrol(tc);
                return res;
            }
            catch (Exception)
            {
                MessageBox.Show("Girdiğiniz Kimlik Numarasına Kayıtlı Vatandaş Yok!");
                return "";
            }
        }

        internal static DataSet VatandasGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.VatandasGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool VatandasGüncelle(Vatandas m)
        {
            try
            {
                int res = DataLayer.VatandasGüncelle(m);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool VatandasSil(string tc)
        {
            try
            {
                int res = DataLayer.VatandasSil(tc);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return false;
            }
        }
    }
}
