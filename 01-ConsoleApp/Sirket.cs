using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ConsoleApp
{
    internal class Sirket
    {
        public string Adi { get; set; } = "Codeove"; // eğer böyle bir eşitlik yapılırsa boş bırakıldığı takdirde isme bu gelir Yani bun değer default bir değerdir.
        public string Adres { get; set; }
        // null geçilsin istiyorsak public string? Adres { get; set; } yazabiliriz

        private int _PostaKodu;
        public int PostaKodu
        {
            get { return _PostaKodu; }
            set { _PostaKodu = value;}
        }

        //public int GetPostaKodu()
        //{
        //    return _PostaKodu;
        //}

        //public void SetPostaKodu(int value)
        //{
        //    _PostaKodu = value;
        //}
    }
    class Kare
    {
        private int _KenarUzunlugu; //bu bir field ve private olduğu için dışarıdan erişimi yok

        public int KenarUzunluğu  // bu bir property ve public olduğu için program cs den erişimi var
        {
            get //geriye değer döndüren metot
            { 
                return _KenarUzunlugu; 
            }
            set //geriye değer döndüremeyen metot
            { 
                if (value > 100)
                    value = 100;  //100ün üstünde değer geldiğinde direkt 100 olarak gönderir 

                _KenarUzunlugu = value;
            } 
            //erişim belirleyicisi privaye olan kenar uzunluğu için encapsulation işlemi yapmış olduk
        }

    }
}
