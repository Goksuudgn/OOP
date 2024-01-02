namespace _06_InterfaceKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Calisan calisan = new Calisan();

            Personel personel = new Personel();
            personel.Adi = "Göksu";
            personel.Soyadi = "Doğan";
            personel.GorevTamamla();
            personel.GorevAta();

            Koordinator koordinator = new Koordinator();
            koordinator.Adi = "Kaan";
            koordinator.Soyadi = "Akkaya";
            koordinator.GorevTamamla();
            koordinator.GorevAta();
            koordinator.ToplantiPlanla();
            koordinator.ToplantiYap();

            Mudur mudur = new Mudur();
            mudur.Adi = "Züb";
            mudur.Soyadi = "Doğan";
            mudur.ToplantiYap();

            Asistan asistan = new Asistan();
            asistan.Adi = "Gök";
            asistan.Soyadi = "Su";
            asistan.ToplantiPlanla();

        }
    }
}
