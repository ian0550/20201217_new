using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            //java : system.out.println("Hello World");
            //C# : Console.WriteLine("Hello World");

            int a = 100;
            if (a > 50)
            {
                Console.WriteLine("a는 50을 넘어요");
            }
            else
            {
                Console.WriteLine("a는 50을 넘지않아요");
            }

            //java
            /*
             * Scanner s = new Scanner(System.in);
             * string ss = s.nextLine();
             * int aa = s.nextInt();
             */

            String ss = Console.ReadLine();
            String sa = Console.ReadLine();
            int aa = int.Parse(Console.ReadLine());

        }
    }
}
