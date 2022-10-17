namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ali";
            musteri1.Soyad = "Bekir";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Ahmet";
            musteri2.Soyad = "Can";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}