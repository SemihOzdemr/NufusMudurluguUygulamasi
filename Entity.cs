using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NufusMudurluguUygulamasi
{
    public class Personel
    {
        public string Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullanıcıAdi { get; set; }
        public string Sifre { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
    }

    public class Vatandas
    {
        public string Tc { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Cinsiyet { get; set; }
        public string DogumTarihi { get; set; }
        public string DogumYeri { get; set; }
        public string AnaAdı { get; set; }
        public string BabaAdı { get; set; }
        public string AnaTc { get; set; }
        public string BabaTc { get; set; }
        public string MedeniHali { get; set; }
        public string Adres { get; set; }

        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }
    }

    public class Ehliyet
    {
        public string Id { get; set; }
        public string VatandasTc { get; set; }
        public string Sınıflar { get; set; }
    }
}
