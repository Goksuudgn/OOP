using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ConsoleApp
{
    //Inheritance (Kalıtım) : Miras alma işlemi
    public class Cihaz
    {
        public string Barkod { get; set; }
        public string BarkodYaz()
        {
            return "Barkod = " + Barkod;
        }
        //Bu metoda sadece miras alınan sınıf üzerinden erişilebilir
        protected void Yaz (string mesaj)
        {
            Console.WriteLine(mesaj);
        }
        public Cihaz(string barkod, string SeriNo)
        {
            this.Barkod = barkod;
        }
    }
    public class Elektronik : Cihaz //elektronik classına erişmeye çalışırsan cihazın içindeki özelliklerin hepsine erişebilirsin
    {
        public Elektronik(string barkod, string SeriNo) : base(barkod,SeriNo)
        {

        }
        public string CPU { get; set; }
        public string RAM { get; set; }
        public void SatinAl()
        {
            Yaz("sasf");
        }
    }

    public class Telefon : Elektronik
    {
        public Telefon(string barkod, string SeriNo) : base(barkod, SeriNo)
        {
        }

        public string Renk { get; set; }
        public void AramaYap()
        {
            Console.WriteLine(base.BarkodYaz());
            Console.WriteLine("Arama Yapıldı");
        }
    }
    public class Bilgisayar : Elektronik
    {
        public Bilgisayar(string barkod, string SeriNo) : base(barkod, SeriNo)
        {
        }
    }
    public class Monitor : Cihaz
    {
        public Monitor(string barkod, string SeriNo) : base(barkod, SeriNo)
        {
        }
    }
}
