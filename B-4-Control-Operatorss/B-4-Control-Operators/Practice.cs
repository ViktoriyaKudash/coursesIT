using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    partial class Practice
    {
        //B4-P1/25. If_TimeOfDayGreeting
        //public static void B4_P1_25_If_TimeOfDayGreeting()
        //{
        //    var td = DateTime.Today.TimeOfDay;
        //    Console.WriteLine(td);
        //    if (td <='12:00:00')
        //    {
        //        Console.WriteLine("Доброе утро,Ольга");
        //    }
        //    else if (td >= '12:00:00' && td <= '17:00:00')
        //    {
        //        Console.WriteLine("Доброго дня ,Ольга");
        //    }
        //    else if (td >= '17:00:00')
        //    {
        //        Console.WriteLine("Добрый вечер ,Ольга");
        //    }
        //}

        //B4-P2/25. If_NumbersComparing
        public static void B4_P2_25_If_NumbersComparing()
        {
            Console.WriteLine("Введите х");
            int x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите х");
            int y = Convert.ToInt16(Console.ReadLine());
            if (x == y)
            {
                int res = x - y;
                Console.WriteLine("Значения равны ");
            }
            else if (x > y)
            {
                int res = x - y;
                Console.WriteLine("х больше у на " + res);
            }
            else if (x < y)
            {
                int res = y - x;
                Console.WriteLine("х меньше у на " + res);
            }
        }

        //B4-P3/25. If_PositiveNumbersComparing
        public static void B4_P3_25_If_PositiveNumbersComparing()
        {
            Console.WriteLine("Введите х");
            int x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите х");
            int y = Convert.ToInt16(Console.ReadLine());
            if (x == y)
            {
                if (y != 0)
                {
                    int res = x - y;
                    Console.WriteLine("Значения равны ");
                }

            }
            else if (x > y)
            {
                if (x != 0)
                {
                    int res = x - y;
                    Console.WriteLine("х больше у на " + res);
                }
            }
            else if (x < y)
            {
                int res = y - x;
                Console.WriteLine("х меньше у на " + res);
            }
        }

        //B4-P4/25. If_Akinator5Numbers
        public static void B4_P4_25_If_Akinator5Numbers()
        {
            Console.WriteLine("Загадайте число от 1 до 5 ");
            Console.WriteLine("Ваше число больше 3 ?");
            string num1 = Convert.ToString(Console.ReadLine());
            if (num1 == "да")
            {
                Console.WriteLine("Ваше число 4?");
            }
            string num2 = Convert.ToString(Console.ReadLine());
            if (num2 == "нет")
            {
                Console.WriteLine("Ваше число 5?");
            }
            string num3 = Convert.ToString(Console.ReadLine());
            if (num2 == "да")
            {
                Console.WriteLine("Ура, я угадал");
            }
            else if (num3 == "нет")
            {
                Console.WriteLine("Хм,вы загадали число с неправильного диапазона ");
            }
            if (num3 == "да")
            {
                Console.WriteLine("Ура, я угадал");
            }
            if (num1 == "нет")
            {
                Console.WriteLine("Ваше число 2?");

            } string num4 = Convert.ToString(Console.ReadLine());
            if (num4 == "да")
            {
                Console.WriteLine("Ура, я угадал");
            } else if (num4 == "нет")
            {
                Console.WriteLine("Ваше число 1?");
            }
            string num5 = Convert.ToString(Console.ReadLine());
            if (num5 == "да")
            {
                Console.WriteLine("Ура, я угадал");
            } else if (num5 == "нет")
            {
                Console.WriteLine("Ваше число 3?");
            }
            string num6 = Convert.ToString(Console.ReadLine());
            {
                if (num6 == "да")
                {
                    Console.WriteLine("Ура, я угадал");
                }
                else if (num6 == "нет")
                {
                    Console.WriteLine("Хм,вы загадали число с неправильного диапазона ");
                }

            }

        }

        //B4-P5/25. Switch_DayOfWeek
        public static void B4_P5_25_Switch_DayOfWeek()
        {
            var today = DateTime.Today;
            var dayOfWeek = (int)today.DayOfWeek;
            switch (dayOfWeek - 1) {
                case 0:
                    Console.WriteLine("Доброго понедельника, Ольга");
                    break;
                case 1:
                    Console.WriteLine("Доброго вторника, Ольга");
                    break;
                case 2:
                    Console.WriteLine("Доброй среды, Ольга");
                    break;
                case 3:
                    Console.WriteLine("Доброго четверга, Ольга");
                    break;
                case 4:
                    Console.WriteLine("Доброй пятницы, Ольга");
                    break;
                case 5:
                    Console.WriteLine("Доброй субботы, Ольга");
                    break;
                case 6:
                    Console.WriteLine("Доброго воскресенья, Ольга");
                    break;
            }
        }

        //B4-P6/25. Switch_GameNavigation
        public static void B4_P6_25_Switch_GameNavigation()
        {
            LabelStart:

            var buttom = Console.ReadKey();
            switch (buttom.KeyChar)
            {
                case 'W':
                case 'w':
                    Console.WriteLine("Верх");
                    break;
                case 'S':
                case 's':
                    Console.WriteLine("Низ");
                    break;
                case 'A':
                case 'a':
                    Console.WriteLine("Лево");
                    break;
                case 'D':
                case 'd':
                    Console.WriteLine("Право");
                    break;
                default:
                    Console.WriteLine("Куда прешь?");
                    break;
            }

            goto LabelStart;
        }

        //B4-P7/25. For_10OddEven
        public static void B4_P7_25_For_10OddEven()
        {
            for (int i = 0; i < 10; i++)
                if (i % 2 == 0)
                {
                    Console.WriteLine("Чётное\n" + i);
                } else
                {
                    Console.WriteLine("Нечётное\n" + i);
                }
        }

        //B4-P8/25. For_3DevideNumbers
        public static void B4_P8_25_For_3DevideNumbers()
        {
            for (int i = 30; i > 0; i--)
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
        }


        //B4-P9/25. For_Matrix10x10
        public static void B4_P9_25_For_Matrix10x10()
        {
            int x = 10;
            int y = 10;
            int[,] m = new int[x, y];

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                    Console.Write("{0} ", m[i, j]);
                Console.WriteLine();
            }
        }


        //B4-P10/25. For_HelloWorld
        public static void B4_P10_25_For_HelloWorld()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Hello world");
            }
        }


        //B4_P11/25. For_Afrochildren
        public static void B4_P11_25_For_Afrochildren()
        {

        }


        //B4-P12/25. For_Minus10OddEven
        public static void B4_P12_25_For_Minus10OddEven()
        {
            for (int i = -10; i < 0; i++)
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + "Чётное\n");
                }
                else Console.WriteLine(i + "Нечётное\n");
        }


        //B4-P13/25 For_LettersCount
        public static void B4_P13_25_For_LettersCount()
        {
            int count = 0;
            Console.WriteLine("Введите слово");
            string str = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < str.Length; ++i)
                if (str[i] == 'а')
                {
                    count++;
                    Console.WriteLine("Количество букв а: " + count);
                }

        }
        

        //B4-P14/25 *For_AlphabetBack
        public static void B4_P14_25_For_AlphabetBack()
        {
            
        }


        //B4-P15/25 While_OddEventNumber
        public static void B4_P15_25_While_OddEventNumber()
        {
            int n = 1;
            Console.WriteLine("Введите число");
            int num1 = Convert.ToInt32(Console.ReadLine());
            while (n < num1)
                if (num1 % 2 == 0)
                {
                    n++;
                    Console.WriteLine(n);
                }
        }


        //B4-P16/25 DoWhile_OddEventNumber
        public static void B4_P16_25_DoWhile_OddEventNumber()
        {
           
        }


        //B4-P17/25 While_HelloWorld
        public static void B4_P17_25_While_HelloWorld()
        {
            int n = 1;
            while (n < 6)
            {
                n++;
                Console.WriteLine("Hello world");
            }
        }


        //B4-P18/25 While_Multiplier
        public static void B4_P18_25_While_Multiplier()
        {
            
        }


        //B4-P19/25 While_SolveNumberAdding
        public static void B4_P19_25_While_SolveNumberAdding()
        {
            
        }


        //B4-P20/25 While_DiceGame
        public static void B4_P20_25_While_DiceGame()
        {
            
        }


        //B4-P21/25 *While_DiceGameMultiplePlayers
        public static void dB4_P21_25_While_DiceGameMultiplePlayers()
        {
        }


        //B4-P22_25 *While_Akinator100Numbers
        public static void B4_P22_25_While_Akinator100Numbers()
        {
            
        }


        //B4-P23/25 IfElse_Calcultor
        public static void B4_P23_25_IfElse_Calcultor()
        {
            Console.WriteLine("Введите число 1 ");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите число 2 ");
            int num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите оператор ");
            char oper = Convert.ToChar(Console.ReadLine());
            if (oper == '+')
            {
               int res = num1 + num2;
                Console.WriteLine("Результат сложения "+res);
            }
            if (oper == '-')
            {
                int res = num1 - num2;
                Console.WriteLine("Результат вычитания " + res);
            }
            if (oper == '*')
            {
                int res = num1 * num2;
                Console.WriteLine("Результат умножения " + res);
            }
            if (oper == '%')
            {
                int res = num1 - num2;
                Console.WriteLine("Результат деления " + res);
            }
        }


        //B4-P24_25 Switch_Calculator
        public static void B4_P24_25_Switch_Calculator()
        {
            Console.WriteLine("Введите число 1 ");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите число 2 ");
            int num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите оператор ");
            char oper = Convert.ToChar(Console.ReadLine());
          
                switch (oper)
            {
                case '+':
                   int res1 = num1 + num2;
                    Console.WriteLine("Результат"+ res1);
                    break;
                case '-':
                    int res2 = num1 - num2;
                    Console.WriteLine("Результат" + res2);
                    break;
                case '*':
                    int res3 = num1 * num2;
                    Console.WriteLine("Результат" + res3);
                    break;
                case '/':
                   int  res4 = num1 % num2;
                    Console.WriteLine("Результат" + res4);
                    break;

            }
        }


        //B4-P25/25 Cycle_WordRevercse
        public static void B4_P25_25_Cycle_WordRevercse()
        {
            Console.WriteLine("Введите слово");
            string str =Convert.ToString(Console.ReadLine());
            Console.WriteLine(string.Concat(str.Reverse()));

        }
    }
}
