using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter point X0:");
            float x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point Y0:");
            float y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point X1: ");
            float x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point Y1:");
            float y2 = Convert.ToInt32(Console.ReadLine());

            float dx = x2 - x1;
            float dy = y2 - y1;
            float _2dx = dx * 2;
            float _2dy = dy * 2;
            float pk = _2dy - dx;
            float q = (_2dy) - (_2dx);



            for (int i = 0; i < 100; i++)
            {
                if (pk < 0)
                {
                    x1 += 1;
                    Console.WriteLine("\t" + pk + "\t" + "(" + x1 + "," + y1 + ")");
                    pk = pk + _2dy;
                    if (x1 == x2 || y1 == y2)
                        break;
                }

                else if (pk >= 0)
                {

                    y1 += 1;
                    x1 += 1;
                    Console.WriteLine("\t" + pk + "\t" + "(" + x1 + "," + y1 + ")");
                    pk = pk + q;
                    if (x1 == x2 || y1 == y2)
                        break;
                }

            }

            Console.ReadLine();
        }
    }
}
