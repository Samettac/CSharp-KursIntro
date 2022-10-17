using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        //buna encapsulation - kapsülleme - denir. 
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
        }

        // bu tarz çok kullanışlı değil: fazladan bir değişken eklendiğinde -örn. stok adedi-
        // tüm metotlara o değişken parametre olarak eklenmeli
        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }

    }
}
