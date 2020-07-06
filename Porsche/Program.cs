using System;

namespace P
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Porsche.");
            System.Console.WriteLine(new Porsche().Farbe.ToString());
        }
    }
    public class Porsche
    {
        public int Farbe = 0;
        public Porsche()
        {
            Farbe = 1;
        }
    }
}
