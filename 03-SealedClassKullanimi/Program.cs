using _03_SealedClassKullanimi.Models;

namespace _03_SealedClassKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cihaz cihaz = new Cihaz();
            Console.WriteLine("Hello, World!");


            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Adi = "Göksu";
            ogrenci.DersCalis();
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Maas = 46546;
            ogretmen.Adi = "dfgd";
            ogretmen.DerseHazirlan();

            Yonetici yonetici = new Yonetici();
            yonetici.Meslek = "Müdür";
            yonetici.MaasOde();
        }
    }
    //miras alınamaz class'lardır diyebillirz
    public sealed class Cihaz
    {
        public string Barkod { get; set; }
    }
    public class Elektronik 
    {

    }

    //öğrenci, öğretmen, yönetici
    //tümünde adı, soyadı, doğum tarihi
    //öğretmen ve yönetici Maasş, Mesleği özelliklerine sahip 
    //Öğretmen derse hazırlan(), DersAnlat() metotlarına sahip işlerini yapabilir
    //Yönetici MaaşÖdeme işini yapabilir
    //Öğrenci de DersÇalış(), TekrarEt() , ÖdevYap() işlerini yerine getirebilir ve not ortalaması özelliğine sahip olabilir
   
}
