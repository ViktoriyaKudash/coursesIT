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
            bool photo = true;
            int srok = 9;
            bool usePhoto = false;

            if (photo == true)
            {
                if (srok <= 3)
                {
                    if (photo != usePhoto)
                    {
                        Console.WriteLine("Оплачивайте");
                    }
                
                }
                else
                {
                    Console.WriteLine("идите в фотокомнату");
                }
                Console.ReadKey();
            }
        }
    }
}
