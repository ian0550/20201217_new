using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201217
{
    class Program
    {
        static void Main(string[] args)
        {
            int tmp = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    tmp += i;
                }

            }
            Console.WriteLine("\n 합 : " + tmp);

            Console.WriteLine("숫자를 입력하세요.");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = 0;
            int num3 = 0;
            if (num1 > 60)
            {
                num2 = num1 / 60;
                num3 = num1 - (num2 * 60);
                if (num3 > 0)
                {
                    Console.WriteLine(num2 + "분 " + num3 + "초");
                }
                else
                {
                    Console.WriteLine(num2 + "분");
                }

            }
            else
            {
                Console.WriteLine(num2 + "초");
            }

            Console.WriteLine("숫자를 입력하세요.");
            int i, j, k, m;
            int star;
            star = int.Parse(Console.ReadLine());

            for (i = 0; i < star; i++)
            {
                for (j = 0; j < (star - i - 1); j++)
                {
                    Console.Write(" ");
                }
                for (k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                for (m = 0; m < i; m++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("구구단");
            
            for(int gugu=2; gugu<10; gugu++)
            {
                for(int gugu2=1; gugu2<10; gugu2++)
                {
                    Console.WriteLine(gugu + "*" + gugu2 + "=" + (gugu * gugu2));
                }
                Console.WriteLine();
            }

            Console.WriteLine("월을 입력하세요.");
            int month = int.Parse(Console.ReadLine());
            
            if(month==12 || month==1 || month==2)
            {
                Console.WriteLine("겨울");
            }
            else if (month == 3 || month == 4 || month == 5)
            {
                Console.WriteLine("봄");
            }
            else if (month == 6 || month == 7 || month == 8)
            {
                Console.WriteLine("여름");
            }
            else if (month == 9 || month == 10 || month == 11)
            {
                Console.WriteLine("가을");
            }

            Console.WriteLine("숫자1을 입력하세요.");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("숫자2를 입력하세요.");
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("1사분면");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("2사분면");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("3사분면");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("4사분면");
            }
            else
            {
                Console.WriteLine("어느 사분면에도 포함되지 않습니다.");
                Console.WriteLine("0입니다.");
            }


        }
    }
}
