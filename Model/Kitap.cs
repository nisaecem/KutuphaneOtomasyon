using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneOtomasyon.Model
{
    public class Kitap
    {
        public int kitapid { get; set; }
        public string kitapİsim { get; set; }
        public string kitapYazar { get; set; }
        public string kitapDili { get; set; }
        public string yayınEvi { get; set; }
        public string tür { get; set; }
        public int adet { get; set; }
        public int sayfaSayisi { get; set; }
        public int basimYili { get; set; }
        public Kitap()
        { }
        public Kitap(int kitapid,string kitapİsim,string kitapYazar,string kitapDili,string yayinEvi,string tür,int adet,int sayfaSayisi,int basimYili)
        {
            this.kitapid = kitapid;
            this.kitapİsim = kitapİsim;
            this.kitapYazar= kitapYazar;
            this.kitapDili = kitapDili;
            this.yayınEvi =yayinEvi ;
            this.tür= tür;
            this.adet = adet;
            this.sayfaSayisi = sayfaSayisi;
            this.basimYili = basimYili;
        }
        public int getkitapid()
        {
            return this.kitapid;
        }
        public string getkitapİsim()
        {
            return this.kitapİsim;
        }
        public string getkitapYazar()
        {
            return this.kitapYazar;
        }
        public string getkitapDili()
        {
            return this.kitapDili;
        }
        public string getyayinEvi()
        {
            return this.yayınEvi;
        }
        public string gettür()
        {
            return this.tür;
        }
        public int getadet()
        {
            return this.adet;
        }
        public int getsayfaSayisi()
        {
            return this.sayfaSayisi;
        }
        public int getbasimYili()
        {
            return this.basimYili;
        }
    }
}
