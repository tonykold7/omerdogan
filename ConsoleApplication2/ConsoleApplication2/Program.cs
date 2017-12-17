using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim; int x, y;
             Console.WriteLine("====Ad girin====");
             isim = Console.ReadLine();
             x = isim.Length;
             for (int i = 0; i < x; i++)
             {
                 y = (int)isim[i] + 10;
                 Console.Write((char)y);
             }
             Console.ReadKey();
            }
        }
    }
