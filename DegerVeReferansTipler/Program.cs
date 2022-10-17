namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int, float, double, decimal, bool = deger tip
            //array, class, interface = referans tip


            int[] numbers1 = new int[] { 1, 2, 3 };
            int[] numbers2 = new int[] { 10, 20, 30 };
            numbers1 = numbers2;
            numbers2 = new int[] { 100, 200, 300 };
            foreach (var number in numbers1)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            

        }
    }
}