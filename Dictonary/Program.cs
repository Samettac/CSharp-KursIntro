using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> plakaIl = new Dictionary<int, string>();
            plakaIl.Add(06, "Ankara");
            plakaIl.Add(19, "Çorum");
            plakaIl.Add(34, "İstanbul");

            foreach (var sehir in plakaIl)
            {
                //Console.WriteLine(sehir);
                Console.WriteLine("İl: " + sehir.Value + " - Plaka kodu: " + sehir.Key);
            }


        }
    }
}