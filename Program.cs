using System;

namespace ClassDomainAccountEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rcn = new Rectangle();
            Console.Write("Please enter most : ");
            rcn.Most = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter size ");
            rcn.Size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSize: "+rcn.Size + "\nMost: " + rcn.Most+ "\nDomain: " + rcn.Domain);
            
            Console.ReadKey();
        }
    }
}
