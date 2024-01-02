using _02_ClassLibrary;
using static _02_ClassLibrary.Araba;
using static _02_ClassLibrary.Kisi;

namespace _01_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba nesne = new Araba();
            nesne.Marka = "Opel";
            nesne.Model = "Corsa";
            nesne.MaksimumHız = 180;

            Console.WriteLine("Arabanın markası : " + nesne.Marka);
            Console.WriteLine(nesne.Marka + " aracındaki yolcu sayısı : " + nesne._suankiYolcuSayisi);

            Araba nesne2 = new Araba(4); // iki tane constractor var yukarıda boş halini kullandım. burada da diğerinde yolcu sayisi parametreli bir construcyor vardı o yüzden burda 4 yazıyoruz .
            nesne2.Marka = "Fiat";
            nesne2.Model = "Linea";
            nesne2.MaksimumHız = 180;
            nesne2.Ilerle();
            nesne2.KapilariKilitle();

            Console.WriteLine(nesne2.Marka + " aracındaki yolcu sayısı : " + nesne2._suankiYolcuSayisi);


            //Kişi isimli class olsun 
            //Kimlik no adı soyadı doğum tarihi Property
            //kişi sınıfını tc kimlik no girmeden nesnesini oluşturmama izin vermesin


            Kisi kisi = new Kisi(123);
            kisi.Adi = "Göksu";
            kisi.Soyadi = "Doğan";
            kisi.Dogumtarihi = DateTime.Today.AddYears(-27);

            Console.WriteLine("Kişi Bilgileri");
            Console.WriteLine("Kimlik no : " + kisi.TcKimlikNo);
            Console.WriteLine("Adi Soyadı " + kisi.AdiSoyadiGetir);
            Console.WriteLine("Doğum tarihi = " + kisi.Dogumtarihi.ToShortDateString);


            Console.Clear();
            Personel.Adi = "Göksu";
            Personel.Soyadi = "Doğan";

            Console.WriteLine("Personel Bilgileri : " + Personel.Adi + " " + Personel.Soyadi);



            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Adi = "Göksu";
            Ogretmen.Soyadi = "Doğan";
            //Soyadı static olduğu için nesneden değilde class isminden erişilebilir.

            //Kare isimli bir class olsun
            //Kenar uzunluğu isimli property olsun 
            //Kenar uzunluğunu dolu olacak şekilde nesne oluşturabiliyim ,boşta oluşturulabilir
            //Karenin Alanını hesaplayıp dönen bir metot olsun 
            //KArenin kenar uzunluğunu kullanıcı kendi girsin, girdikten sonra kareenin alanını hesaplayan metot ile ekrana yazdırsın 

            //Console.Clear();

            //Console.WriteLine("Karenin kenar uzunluğunu girin...");
            //double kenarUzunlugu = Convert.ToDouble(Console.ReadLine());

            //Kare kare = new Kare(kenarUzunlugu);
            //double alan = kare.AlanHesapla();

            //Console.WriteLine("Karenin Alanı : " + alan);

            Console.Clear();
            Sirket sirket = new Sirket();
            sirket.PostaKodu = 34560;
            sirket.Adi = "Acunmedya Akademi";
            Console.WriteLine("Şirketin Adı : " + sirket.Adi);

            Kare kare = new Kare();
            kare.KenarUzunluğu = 120;
            Console.WriteLine("Kenar uzunluğu = " + kare.KenarUzunluğu);

            Console.Clear();
            Elektronik elektronik = new Elektronik("1232" , "sfdsfsd");
            //elektronik.
            Telefon telefon = new Telefon("1232", "sfdsfsd");
            telefon.RAM = "12 GB";
            telefon.CPU = "Snapdrogan";
            telefon.Renk = "Siyah";

        }


    }

}
