using NufusMudurluguUygulamasi.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NufusMudurluguUygulamasi
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmGiris loginForm = new FrmGiris();
            DialogResult result = loginForm.ShowDialog(); // Kullanıcı Giriş Formu gösterilir

            if (result == DialogResult.OK) // Kullanıcının giriş yaptığı doğrulanırsa
            {
                Application.Run(new AnaForm()); // Ana Formu çalıştırır
            }
            else
            {
                // Kullanıcı girişi başarısız veya iptal edildi
                // Uygulama sonlandırılıyor.
                Application.Exit();
            }
        }
    }
}
