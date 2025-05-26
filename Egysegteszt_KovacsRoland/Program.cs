using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egysegteszt_KovacsRoland
{
    public class Rectangle
    {
        public double CalculateArea(double width, double height)
        {
            if (width < 0 || height< 0)
            {
                throw new Exception();
            }


            return width * height;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var peldany = new Rectangle();

            Console.WriteLine("Adj meg a téglalap oldalait: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"A téglalap területe: {peldany.CalculateArea(a, b)}");
            Console.ReadKey();
        }
    }
}
