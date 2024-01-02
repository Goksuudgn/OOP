namespace _04_AbstractClassveMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cihaz cihaz = new Cihaz(); abstract class olduğundan newlenemiyor
            Elektronik elektronik = new Elektronik();
            elektronik.Barkod = "15454";
            elektronik.CPU = "cpu";
            elektronik.RAM = "memory";

            elektronik.BarkodYaz();
            string sonuc = elektronik.Birlestir("göksu", "doğan");

            Console.WriteLine( sonuc);
        }
    }
}
