using System;

namespace StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pi = Math.PI;

         Console.WriteLine("1. " + $"{DateTime.Now, 40:MMMM dd, yyyy}" );
            Console.WriteLine("2. " + $"{DateTime.Now:yyyy.dd.MM}");
            Console.WriteLine("3. Day" + $"{DateTime.Now: d}" + " of" + $"{DateTime.Now: MMMM, yyyy}");
            Console.WriteLine("4. Year:" + $"{DateTime.Now: yyyy,}" + " Month:" + $"{DateTime.Now: MM,}" + " Day:" + $"{DateTime.Now: dd}");
            Console.WriteLine("5. " + $"{DateTime.Now, 10: dddd}");
            Console.WriteLine("6. " + $"{DateTime.Now, 10: hh:mm tt}" + $"{DateTime.Now, 10: dddd}");
            Console.WriteLine("7. h:" + $"{DateTime.Now :hh,}" + " m:" + $"{DateTime.Now :mm,}" + " s:" + $"{DateTime.Now :ss}");
            Console.WriteLine("8. " + $"{DateTime.Now:yyyy.MM.dd.hh.mm.ss}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. " + $"{pi :C}");
            Console.WriteLine("2. " + $"{pi,10:n3}");

            
        }
    }
}
