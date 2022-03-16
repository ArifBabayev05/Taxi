using System;

namespace dotnet5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 10;
            double distance = 1;
            double pay;

            if (distance>5)
            {
                pay = distance * 0.7;
            }
            else
            {
                pay = distance * 1;
            }
            if (balance>pay)

            {
                Console.WriteLine("Sifariş Uğurludur.");
            }
            else
            {
                Console.WriteLine("Sifariş Uğursuzdur.");
            }
        }
    }
}
