using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InterfaceKavrami
{
    public abstract class Calisan
    {
        public string Adi {  get; set; }
        public string Soyadi { get; set;}
    }

    public class Personel : Calisan, IGorev
    {
        //GorevAtama()
        //GorevTamamla()
        public void GorevAta()
        {
            Console.WriteLine($"Personel Görev Ata = {Adi} {Soyadi}");
        }

        public void GorevTamamla()
        {
            Console.WriteLine($"Personel Görev Tamamla = {Adi} {Soyadi}");
        }
    }
    public class Koordinator : Calisan, IGorev , IToplanti, IToplantii
    {
       
        public void GorevAta()
        {
            Console.WriteLine($"Koordinatör Görev Ata = {Adi} {Soyadi}");
        }

        public void GorevTamamla()
        {
            Console.WriteLine($"Koordinatör Görev Tamamla = {Adi} {Soyadi}");
        }

        public void ToplantiPlanla()
        {

            Console.WriteLine($"Koordinatör Toplanti Planla = {Adi} {Soyadi}");
        }

        public void ToplantiYap()
        {
            Console.WriteLine($"Koordinatör Toplanti Yap = {Adi} {Soyadi}");
        }
    }
    public class Mudur : Calisan , IToplanti
    {
        //ToplantiYap()
        public void ToplantiYap()
        {
            Console.WriteLine($"Müdür Toplanti Yap = {Adi} {Soyadi}");
        }
    }

    public interface IGorev //Metodun kod bloğu bulunmaz
    {
        void GorevAta();
        void GorevTamamla();
    }
    public interface IToplanti
    {
        void ToplantiYap();
    }


    // Toplantı planlama yapabilen bir asistan sınıfı üretelim
    public interface IToplantii
    {
        void ToplantiPlanla();
    }
    public class Asistan : Calisan, IToplantii
    {
        public void ToplantiPlanla()
        {
            Console.WriteLine($"Asistan Toplantı Planla:{Adi} {Soyadi}");
        }
       
    }

}
