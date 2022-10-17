namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array - dizi

            string[] kurslar = new string[] { "C#", "Java", "Python", "C++" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}