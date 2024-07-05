using KütüphaneOtomasyon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneOtomasyon
{
    public partial class Form1 : Form
    {
        List<Kişi> kişilerim = new List<Kişi>();
        List<Kitap> kitaplarım = new List<Kitap>();
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kullaniciAdi.Text = string.Empty;
            txt_sifre.Text = string.Empty;
        }
        private void btn_giriş_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre = "";
            kullaniciAdi = txt_kullaniciAdi.Text;
            sifre = txt_sifre.Text;
            bool kontrol = false;
            foreach (Kişi kişi in kişilerim)
            {
                if (kullaniciAdi.ToLower() == kişi.getkullaniciAdi() && sifre == kişi.getsifre() && kişi.getyetki()=="admin")
                {
                    //admin  sayfasına git
                    AdminSayfası adminsayfası = new AdminSayfası(kişilerim,kitaplarım);
                    adminsayfası.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
                else if(kullaniciAdi.ToLower() == kişi.getkullaniciAdi() && sifre == kişi.getsifre() && kişi.getyetki() == "üye")
                {
                    //üye sayfasına git
                    ÜyeSayfası üyesayfası = new ÜyeSayfası(kitaplarım);
                    üyesayfası.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
            }
            if(!kontrol)
            {
                MessageBox.Show("Hatalı Bİr İşlem Yaptınız Tekrar Deneyiniz.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            kişilerim.Add(new Kişi(1, "nisa", "güdür", DateTime.Now, "nisa","1" , "admin"));
            kişilerim.Add(new Kişi(2, "taha", "güdür", DateTime.Now, "taha", "2", "üye"));
            kişilerim.Add(new Kişi(3, "alisami", "güdür", DateTime.Now, "velet","3" , "üye"));
            kişilerim.Add(new Kişi(4, "yasir", "aydoğan", DateTime.Now, "yaço", "4", "üye"));

            kitaplarım.Add(new Kitap(1, "İçimizdeki Şeytan", "Sebahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "Roman",100,250,2015));
            kitaplarım.Add(new Kitap(2, "Tutunamayanlar", "Oğuz Atay", "Türkçe", "İletişim Yayınları", "Roman", 350, 760, 2015));
            kitaplarım.Add(new Kitap(3, "Uçurtma Avcısı", "Khaled Hosseini", "İngilizce", "Everest Yayıncılık", "Roman", 100, 350, 2010));
            kitaplarım.Add(new Kitap(4, "Küçük Prens", "Antoine de Saint-Exupéry", "İngilizce", "Can Çocuk Yayınları", "Roman", 50, 60, 2018));
        }
    }
}
