using ExtensionMethods.Extensions;
using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen isminizi yazın: ");
            string name = Console.ReadLine();

            Console.WriteLine("İşte isminizin tersten yazılışı : ");
            Console.WriteLine(name.GetReverse());
            
            
            
        }
    }
}
