namespace KursGun2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DO NOT REPEAT YOURSELF!
            //type safety
            //değer tutucu, alias

            string katagoriEtiketi = "Katagori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool girisYaptiMi = false;
            double dolarDun = 17.35;
            double dolarBugun = 17.35;

            if (dolarBugun<dolarDun)
            {
                Console.WriteLine("Azalış oku");
            }
            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış oku");
            }
            else
            {
                Console.WriteLine("Değişmedi oku");
            }



            if (girisYaptiMi == true) 
            {
                Console.WriteLine("Giris yap butonu");
            }
            else
            {
                Console.WriteLine("Kullanici ayarlari butonu");
            }
        }
    }
}