namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 55;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
            }
            Console.WriteLine("-----------------Metotlar-------------------");

            // buna instance denir - örnek
            SepetManager sepetManager = new SepetManager();
            //encapsulation 
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            // bu tarz çok kullanışlı değil: fazladan bir değişken eklendiğinde -örn. stok adedi-
            // tüm metotlara o değişken parametre olarak eklenmeli
            sepetManager.Ekle2("Armut", "Yeşil armut", 12);
            sepetManager.Ekle2("Elma", "Kırmızı elma", 8);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 45);
        }
    }
}