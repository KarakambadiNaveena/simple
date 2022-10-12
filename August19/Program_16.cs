using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAM_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int point = 100;

          
                Console.WriteLine("HIT or MISS");
                string s = Console.ReadLine();
           
                if (s == " HIT" )
                {
                    point = point + 10;
                }
                else
                {
                    point = point - 20;

                }

                Console.WriteLine("Point = {0}", point);
                Console.ReadLine();
            }
        }
    }

