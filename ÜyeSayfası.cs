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
    public partial class ÜyeSayfası : Form
    {
        List<Kitap> kitaplarım;
        public ÜyeSayfası(List<Kitap> kitaplarım)
        {
            InitializeComponent();
            this.kitaplarım = kitaplarım;
        }
        private void btn_çikiş_Click(object sender, EventArgs e)
        {
            Form1 loginsayfası = new Form1();
            loginsayfası.Show();
            this.Hide();
            MessageBox.Show("Çıkış Yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ÜyeSayfası_Load(object sender, EventArgs e)
        {
            foreach(Kitap kitap in kitaplarım)
            {
                dataGridView3.Rows.Add(kitap.getkitapid(),kitap.getkitapİsim(),kitap.getkitapYazar(),kitap.getkitapDili(),kitap.getyayinEvi(),kitap.gettür(),kitap.getadet(),kitap.getsayfaSayisi(),kitap.getbasimYili());
            }
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            int kitapİd = Convert.ToInt32(textBox3.Text);
            Kitap hedefKitap=null;
            foreach(Kitap kitap in kitaplarım)
            {
                if(kitap.getkitapid()==kitapİd)
                {
                    hedefKitap = kitap;
                }
            }
            dataGridView3.Rows.Clear();
            dataGridView3.Rows.Add(hedefKitap.getkitapid(), hedefKitap.getkitapİsim(), hedefKitap.getkitapYazar(), hedefKitap.getkitapDili(), hedefKitap.getyayinEvi(), hedefKitap.gettür(), hedefKitap.getadet(), hedefKitap.getsayfaSayisi(), hedefKitap.getbasimYili());
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Remove(dataGridView3.CurrentRow);
            foreach (Kitap kitap in kitaplarım)
            {
                dataGridView3.Rows.Add(kitap.getkitapid(), kitap.getkitapİsim(), kitap.getkitapYazar(), kitap.getkitapDili(), kitap.getyayinEvi(), kitap.gettür(), kitap.getadet(), kitap.getsayfaSayisi(), kitap.getbasimYili());
            }
        }
    }
}
