using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneOtomasyon.Model
{
    public class Kişi
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime olusturmaTarihi { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }


        public Kişi()
        {

        }
        public Kişi(int id,string isim,string soyisim,DateTime oluşturmaTarihi,string kullaniciAdi,string sifre,string yetki )
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.olusturmaTarihi = oluşturmaTarihi;
            this.kullaniciAdi = kullaniciAdi;
            this.sifre = sifre;
            this.yetki = yetki;
        }
        public void setId(int id)
        {
            this.id = id;

        }
        public int getId()
        {
            return this.id;
        }
        public void setisim(string isim)
        {
            this.isim = isim;

        }
        public string getisim()
        {
            return this.isim;
        }
        public void setsoyisim(string soyisim)
        {
            this.soyisim = soyisim;

        }
        public string getsoyisim()
        {
            return this.soyisim;
        }
        public void setoluşturmaTarihi(DateTime olusturmatarihi)
        {
            this.olusturmaTarihi=olusturmaTarihi;

        }
        public DateTime getolustumaTarihi()
        {
            return this.olusturmaTarihi;
        }
        public void setkullaniciAdi(string kullaniciAdi)
        {
            this.kullaniciAdi = kullaniciAdi;

        }
        public string getkullaniciAdi()
        {
            return this.kullaniciAdi;
        }
        public void setsifre(string sifre)
        {
            this.sifre = sifre;

        }
        public string getsifre()
        {
            return this.sifre;
        }
        public void setyetki(string yetki)
        {
            this.yetki = yetki;

        }
        public string getyetki()
        {
            return this.yetki;
        }

        public override string ToString()
        {
            return "İsim - Soyisim"+ this.isim+""+this.soyisim;
        }


    }
}
