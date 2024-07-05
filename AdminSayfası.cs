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
    public partial class AdminSayfası : Form
    {
        List<Kişi> kişilerim;
        List<Kitap> kitaplarım;
        public AdminSayfası(List<Kişi> kişilerim,List<Kitap> kitaplarım)
        {
            InitializeComponent();
            this.kişilerim = kişilerim;
            this.kitaplarım = kitaplarım;
        }
        private void AdminSayfası_Load(object sender, EventArgs e)
        {
            foreach (Kişi kişi in kişilerim)
            {
                dataGridView1.Rows.Add(kişi.getId(),kişi.getisim(),kişi.getsoyisim(),kişi.getolustumaTarihi(),kişi.getkullaniciAdi(),kişi.getsifre(),kişi.getyetki());
            }
            foreach(Kitap kitap in kitaplarım)
            {
                dataGridView2.Rows.Add(kitap.getkitapid(),kitap.getkitapİsim(),kitap.getkitapYazar(),kitap.getkitapDili(),kitap.getyayinEvi(),kitap.gettür(),kitap.getadet(),kitap.getsayfaSayisi(),kitap.getbasimYili());
            }
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToInt32(txt_id.Text),txt_isim.Text,txt_soyisim.Text, Convert.ToDateTime(txt_oluşturma.Text), txt_kullaniciAdi.Text,txt_şifre.Text,txt_yetki.Text);
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }
        public void TxtDoldur()
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_oluşturma.Text = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value).ToString("dd.MM.yyyy HH.mm.ss");
            txt_kullaniciAdi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_şifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_yetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtDoldur();
        }
        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            int id =Convert.ToInt32(txt_id.Text);
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            DateTime tarih = Convert.ToDateTime(txt_oluşturma.Text);
            string kullanıcıadi = txt_kullaniciAdi.Text;
            string sifre = txt_şifre.Text;
            string yetki = txt_yetki.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id,isim,soyisim,tarih,kullanıcıadi,sifre,yetki);
        }
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            for(int i=0; i<Gbox_üye.Controls.Count ;i++)
            {
                if(Gbox_üye.Controls[i] is TextBox || Gbox_üye.Controls[i] is MaskedTextBox)
                {
                    Gbox_üye.Controls[i].Text = string.Empty;
                }
            }
        }
        private void btn_kEkle_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(Convert.ToInt32(txt_kİd.Text),txt_kİsim.Text, txt_kYazar.Text, txt_dil.Text, txt_yEvi.Text, txt_tür.Text,Convert.ToInt32(txt_adet.Text),Convert.ToInt32(txt_sayfasayısı.Text),Convert.ToInt32(txt_basım.Text));
        }

        private void btn_ksil_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void btn_kgüncel_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(txt_kİd.Text,txt_kİsim.Text,txt_kYazar.Text,txt_dil.Text,txt_yEvi.Text,txt_tür.Text,txt_adet.Text,txt_sayfasayısı.Text,txt_basım.Text);
        }

        private void btn_kitaptemiz_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gb_kitap.Controls.Count; i++)
            {
                if (gb_kitap.Controls[i] is TextBox)
                {
                    gb_kitap.Controls[i].Text = string.Empty;
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kİd.Text= dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_kİsim.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_kYazar.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_dil.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_yEvi.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_tür.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_adet.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txt_sayfasayısı.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            txt_basım.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
        }
        private void btn_kişiara_Click(object sender, EventArgs e)
        {
            Kişi hedefkişi = null;
            int seçilenid = Convert.ToInt32(textBox1.Text);
            foreach(Kişi kişi in kişilerim)
            {
                if(kişi.getId()==seçilenid)
                {
                    hedefkişi = kişi;
                    break;
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefkişi.getId(), hedefkişi.getisim(), hedefkişi.getsoyisim(),hedefkişi.getolustumaTarihi(),hedefkişi.getkullaniciAdi(),hedefkişi.getsifre(),hedefkişi.getyetki());
        }
        private void btn_yenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            foreach(Kişi hedefkişi in kişilerim)
            {
                dataGridView1.Rows.Add(hedefkişi.getId(), hedefkişi.getisim(), hedefkişi.getsoyisim(), hedefkişi.getolustumaTarihi(), hedefkişi.getkullaniciAdi(), hedefkişi.getsifre(), hedefkişi.getyetki());
            }
        }
        private void btn_kitapara_Click(object sender, EventArgs e)
        {
            Kitap hedefkitap = null;
            int kitapid = Convert.ToInt32(textBox2.Text);
            foreach (Kitap kitap in kitaplarım)
            {
                if (kitap.getkitapid() == kitapid)
                {
                    hedefkitap = kitap;
                    break;
                }
            }
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(hedefkitap.getkitapid(),hedefkitap.getkitapİsim(),hedefkitap.getkitapYazar(),hedefkitap.getkitapDili(),hedefkitap.getyayinEvi(),hedefkitap.gettür(),hedefkitap.getadet(),hedefkitap.getsayfaSayisi(),hedefkitap.getbasimYili());
        }

        private void btn_kyenile_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            foreach (Kitap hedefkitap in kitaplarım)
            {
                dataGridView2.Rows.Add(hedefkitap.getkitapid(), hedefkitap.getkitapİsim(), hedefkitap.getkitapYazar(), hedefkitap.getkitapDili(), hedefkitap.getyayinEvi(), hedefkitap.gettür(), hedefkitap.getadet(), hedefkitap.getsayfaSayisi(), hedefkitap.getbasimYili());
            }
        }

        private void btn_çikiş_Click(object sender, EventArgs e)
        {
            Form1 loginsayfası = new Form1();
            loginsayfası.Show();
            this.Hide();
            MessageBox.Show("Çıkış Yapıldı","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
