using System;
using System.Data;
using System.Windows.Forms;

namespace ZueKelime
{
    public partial class IstatistikSayfasi : Form
    {
        VeritabaniYardimci db = new VeritabaniYardimci();
        int aktifKullaniciID ;

        public IstatistikSayfasi()
        {
            InitializeComponent();
        }

        private void IstatistikSayfasi_Load(object sender, EventArgs e)
        {
            try
            {
                aktifKullaniciID = OturumBilgisi.AktifKullaniciID;

                string toplam = "SELECT COUNT(*) FROM kelimeler";
                string ogrenilen = $"SELECT COUNT(*) FROM KullaniciKelimeleri WHERE kullaniciID={aktifKullaniciID} AND Adim >= 6";

                DataTable toplamDt = db.VeriGetir(toplam) as DataTable;
                DataTable ogrenilenDt = db.VeriGetir(ogrenilen) as DataTable;

                if (toplamDt != null && toplamDt.Rows.Count > 0)
                    lblToplam.Text = "Toplam Kelime: " + toplamDt.Rows[0][0].ToString();

                if (ogrenilenDt != null && ogrenilenDt.Rows.Count > 0)
                    lblOgrenilen.Text = "Öğrenilen Kelime: " + ogrenilenDt.Rows[0][0].ToString();

                for (int i = 0; i <= 6; i++)
                {
                    string adimQuery = $"SELECT COUNT(*) FROM KullaniciKelimeleri WHERE kullaniciID={aktifKullaniciID} AND Adim = {i}";
                    DataTable adimDt = db.VeriGetir(adimQuery) as DataTable;

                    if (adimDt != null && adimDt.Rows.Count > 0)
                    {
                        int sayi = Convert.ToInt32(adimDt.Rows[0][0]);
                        Control[] controls = Controls.Find("lblAdim" + i, true);
                        if (controls.Length > 0)
                            controls[0].Text = $"Adım {i}: {sayi} kelime";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("İstatistikler alınırken hata oluştu:\n\n" + ex.Message);
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            SinavSayfasi sinav = new SinavSayfasi();
            sinav.Show();
            this.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
