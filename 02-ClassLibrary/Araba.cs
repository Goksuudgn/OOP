using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClassLibrary
{
    //Sadece bu projenin içerisinden erişilebilir
    //private class ArabaOzel
    //{

    //}
    public class Araba
    {
        //Fields (değişkenler)
        public int _suankiHizi;
        public int _suankiYolcuSayisi;

        //Properties (ÖZellikler)
        public string Marka { get; set; }
        public string Model { get; set; }
        public int MaksimumHız { get; set; }

        //Events (olaylar)
        public event EventHandler Calistirildi;

        //Constructors (Temel Yapı Oluşturucu)
        public Araba()
        {

        }
        public Araba(int yolcuSayisi)
        {
            _suankiYolcuSayisi = yolcuSayisi;
        }

        //Metotlar
        public void KapilariKilitle()
        {

        }
        public void KapilariKilitle(bool anahtarKontaktaMi)
        {

        }

        public void Ilerle()
        {

        }
    }
}
