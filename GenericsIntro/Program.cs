﻿namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");

            string[] x = new string[] {};
            Console.WriteLine(x.Length); 
        }
    }
}