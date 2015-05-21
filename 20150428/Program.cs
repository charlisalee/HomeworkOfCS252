using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20150428
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exercise01 begins.


            Random random = new Random();
            int b = random.Next(0, 3);

            Console.Write("請選擇0.剪刀,1.石頭,2.布");
            int a = int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("平手");
            }
            else if (a == 0 && b == 1)
            {
                Console.WriteLine("電腦出石頭，你輸了");
            }
            else if (a == 0 && b == 2)
            {
                Console.WriteLine("電腦出布，你贏了");
            }
            else if (a == 1 && b == 0)
            {
                Console.WriteLine("電腦出剪刀，你贏了");
            }
            else if (a == 1 && b == 2)
            {
                Console.WriteLine("電腦出布，你輸了");
            }
            else if (a == 2 && b == 0)
            {
                Console.WriteLine("電腦出剪刀，你輸了");
            }
            else if (a == 2 && b == 1)
            {
                Console.WriteLine("電腦出石頭，你贏了");
            }


           //Exercise01 ends.




            //Exercise02 begins.
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            if (input % 2 == 0)
            {
                for (int i = 0; i < input; i = i + 1)
                {
                    sum += i;

                }
            }
            else
            {
                for (int i = 0; i <= input; i = i + 1)
                {
                    sum += i;

                }
            }
            Console.WriteLine("The answer is " + sum);


            //Exercise02 ends.

        }
    }
}
