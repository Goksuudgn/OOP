namespace _08_Enc_Inh_Poly
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Kare kare = new Kare(20);
            Console.WriteLine("Kenar uzunluğu : " + kare.KenarA);

            Kare kare2 = new Kare();
            Console.WriteLine("Kenar uzunluğu : " + kare2.KenarA);
        }
    }
    public class Kare
    {
        //Encapsulation (Kapsülleme) : Classların içerisindeki fieldlere değer atama ve okuma işlemi sırasında araya girebilme işlemine denir (Properties

        private int _KenarA;

        public int KenarA
        {
            get { return _KenarA; }
            set { _KenarA = value; }
        }

        //public int GetKenara()
        //{
        //   return _KenarA;
        //}
        public Kare()
        {

        }
        public Kare(int kenarUzunlugu)
        {
            this.KenarA = kenarUzunlugu;
            
        }



        //Inheritance (Miras Alma ) : Interfaceler ya da normal classlar ile miras alınarak classların öğelerinin genişletilebilmesine denir 

        //Polymorphism (Çok biçimlilik) : Bir metodun miras alınan sınıfta ezilerek (override) şeklinin ya da görevinin değiştirilmesi işlemine denir. (virtual method, abstract method)
    }
}
