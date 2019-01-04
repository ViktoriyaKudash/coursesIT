using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // MassiveMaxInRow();   


            //int[] someArray = new int[] { 1, 2, 4, 3, 8, 5, 7, 6, 9, 0 };
            //Bubble_Sort(someArray);


            //ReadConsoleMassive();

            // ReplaceInPoem();

            Pyatnashki();
            CutString();
            Console.ReadLine();
        }

        public static void ReadConsoleMassive()
        {
            int[] arr = new int[6];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Введите число: ");
                int num = int.Parse(Console.ReadLine());
                arr[i] = num;
            }

            foreach (var intArr in arr)
            {
                Console.Write(intArr + " ");
            }

        }


        public static void Pyatnashki()
        {
            int[] numbers = new int[15];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = i + 1;
            }


            switch ()
            {
                case "W":
                    {
                    }
                    break;
                case 'A':
                    {

                    }
                    break;

                case 'S':
                    {
                    }
                    break;

                case 'D':
                    {
                    }
                    break;

                case 'Q':
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
            } 

}
    
            public static void Bubble_Sort(int[] anArray)
            {
                
                PrintArray(anArray);

             
                for (int i = 0; i < anArray.Length; i++)
                {    for (int j = 0; j < anArray.Length - 1 - i; j++)
                    {
                       
                        if (anArray[j] > anArray[j + 1])
                        {
                            Swap(ref anArray[j], ref anArray[j + 1]);
                        }
                    }
                 PrintArray(anArray);
                }
            }

          
            public static void Swap(ref int aFirstArg, ref int aSecondArg)
            {            
                int tmpParam = aFirstArg;              
                aFirstArg = aSecondArg;
                aSecondArg = tmpParam;
            }
            
            public static void PrintArray(int[] anArray)
            {              
                for (int i = 0; i < anArray.Length; i++)
                {                    
                    Console.Write(anArray[i] + " ");
                }
               
                Console.WriteLine("\n");
            }

            
        public static void MassiveMaxInRow()
        {
            int[,] array = { { 1, 2, 3 }, { 5, 5, 6 }, { 7, 8, 9 } };
            int max = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (max < array[i, j])
                        max = array[i, j];
                }
                Console.WriteLine(max);
                max = 0;
            }
        }
        public static void ReplaceInPoem() {
            Console.WriteLine("Введите стихотворение в одну строку,разделяя строки точкой с запятой;: ");
            string str = Console.ReadLine();
            string[] wrs = str.Split(new char[] { ';' });
            for (int i = 0; i < wrs.Length; i++)
            {
                wrs[i] = wrs[i].Replace("о", "а").Replace("л", "ль").Replace("ть", "т");
            }
            foreach (var Array in wrs)
            {
                Console.WriteLine(Array);
            }
        }

        public static void CutString()
        {
            Console.WriteLine("Введите предложение ");
            string str = Console.ReadLine();
            string replace="";


            for (int i =0; i < str.Length; i++)
            {
                if (str.Length > 13)
                {
                    replace = str.Substring(13)+".....";
                }

            }
            Console.WriteLine(replace); 
        }
        public static void PoemExample()
        {
            
        }
    }
}
