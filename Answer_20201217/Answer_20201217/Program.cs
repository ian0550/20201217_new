using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer_20201217
{
    class Program
    {
        static void Main(string[] args)
        {
            //java : System.out.println("Hello"); //한 줄 출력하고 한 줄 띄는 거
            //C# : Console.WriteLine("Hello");

            Console.WriteLine("Hello 하고 한 줄 띈다. ");

            //java : System.out.print("Hello"); //한 줄 출력하고 한 줄 띄는 거
            //C# : Console.WriteLine("Hello");

            Console.Write("Hello 하고 한 줄 안 띄움. ");

            //java : System.out.println(); //아무것도 안 하고 그냥 한 줄 띄우기
            //C# : Console.WriteLine();

            Console.WriteLine(); //여기서 한 줄을 띄운다.

            //변수 
            //java와 동일
            int example= 100;
            string ex1 = "하이";
            string ex2 = "헬로";
            string 이런것도됨 = "신기하죠?";
            Console.WriteLine(이런것도됨); //근데 하지마세요. 옛날꺼에선 안 돌아갈 수 있음

            //문자열과 숫자 혼합하기
            string ex3 = example + " 더하기" + example + "은 " + (example + example) + "이다. ";
            string ex4 = $"{example} 더하기 {example}은 {example + example}이다. ";
            string ex5 = string.Format("{0} 더하기 {1}은 {2}이다. ", example, example, example + example);

            Console.WriteLine(ex3);
            Console.WriteLine(ex4);
            Console.WriteLine(ex5);

            //조건문
            //java와 동일함
            if (example > 30)
            {
                Console.WriteLine("30이상");
            }
            else
            {
                Console.WriteLine("30미만");
            }

            if (example == 10)
            {
                Console.WriteLine("10");
            }
            else if(example == 10)
            {
                Console.WriteLine("10");
            }

            if(example == 20)
            {
                Console.WriteLine("20");
            } //끝에 꼭 else 안 붙여도 됨

            if (example == 10)
            {
                Console.WriteLine("10");
            }
            else
            {
                Console.WriteLine("10이랑 20은 아님");
            }

            switch (example)
            {
                case 10:
                    Console.WriteLine("10");
                    break;
                case 20:
                    Console.WriteLine("20");
                    break;
                default:
                    Console.WriteLine("10이랑 20은 아님");
                    break;
            }

            //반복문도 java와 동일
            //단 foreach라는 특수 문법이 있는데 이건 나중에 알려줌
            //근데 몰라도 코드짜는 데는 지장없음

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("같은 말 10번 반복하기");
            }

            int temp = 10;
            while (temp>0)
            {
                temp--;
            }
            do
            {
                temp++;
            } while (temp < 10);

            //값을 입력받는 경우
            //java
            /*
            Scanner s = new Scanner(System.in);
            String test = s.nextLine();
            int tes2 = s.nextInt();

             */
            //C#
            //String test = Console.ReadLine();
            //int test2 = int.Parse(Console.ReadLine());
            //Console.ReadLine은 단축키 없음

            string test = Console.ReadLine();
            int test2 = int.Parse(Console.ReadLine());


        }
    }
}
