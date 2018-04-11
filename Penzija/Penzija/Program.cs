using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penzija
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Vnesi tvoja leta");
            int leta = int.Parse(Console.ReadLine());
            if (leta >= 65)
            {
                Console.WriteLine(leta + " - moraš se upokojiti");
            }
            else
            {
                if(leta == 64)
                {
                    Console.WriteLine(leta + " -še eno leto");
                }
                else
                {
                    if(leta == 63)
                    {
                        Console.WriteLine(leta + " -še dve leti");
                    }
                    else
                    {
                        if (leta == 62)
                        {
                            Console.WriteLine(leta + " -še tri leta");
                        }
                        else
                        {
                            Console.WriteLine(leta + " - Še dolgo boš delal");
                        }
                    }
                }
            }
            Console.WriteLine("Hvala in lep pozdrav");
            Console.ReadLine();
            */

            Console.WriteLine("Vnesi 1 2 ali 3");
            int število = int.Parse(Console.ReadLine());
            switch (število)
            {
                case 1:
                    Console.WriteLine("Vnesi si 1");
                    break;
                case 2:
                    Console.WriteLine("Vnesi si 2");
                    break;
                case 3:
                    Console.WriteLine("Vnesi si 3");
                    break;
                default:
                    Console.WriteLine("Število mora biti med 1 in 3");
                    break;
            }
            Console.ReadLine();
        }
    }
}
