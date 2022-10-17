using System.Collections.Generic;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin", "Samet", "Murat", "Ahmet"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];  //bu işlemle isimlere bellekten yeni bir adres atanır ve 5 elemanlı
            //isimler[4] = "İlker";     //5. elamanı ilker, diğer elemanları boş olan bir dizi olur. eski değerler işe yaramaz.
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);
            //diziler sabittir genişletilemez. bu yüzden genelde koleksiyonlar kullanılıyor.

            List<string> isimler2 = new List<string> { "Engin", "Samet", "Murat", "Ahmet" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}