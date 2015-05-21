using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20150424
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise01 begins.

                     //Conversion begins.


                        float a = 0.3f;
                        double floatA = a;           //小到大

                        double b = 0.3;
                        float floatB = (float)b;     //大到小       不可 float floatB = b;


                        string convertionA = b.ToString();              //數轉字串
                        float A = float.Parse(convertionA);             //字串轉數

                    //Conversion edns.


                        Console.WriteLine("Please enter four integers.");
                        string integerA = Console.ReadLine();
                        string integerB = Console.ReadLine();
                        string integerC = Console.ReadLine();
                        string integerD = Console.ReadLine();
                        int addtionA=int.Parse(integerA)+int.Parse(integerB);
                        int addtionB=int.Parse(integerC)+int.Parse(integerD);
                        Console.WriteLine(addtionA + addtionB);

            //Exercise01 ends.



            //Exercise02 begins.

            Random random=new Random();
            int randomNumber = random.Next(0, 2);
            Console.Write("Please enter your name:");
            //產生一個亂數產生器
            string name=Console.ReadLine();
            string gender=(randomNumber==0)?"女":"男";
            
            
            Console.WriteLine("{0} I guess you're a {1}! Am I right?",name,gender);

            //Exercise02 ends.
        }
    }
}
