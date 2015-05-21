using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS252_20150421
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable declaration begins.

            int num;
            int numPeople;
            string name;
            Int16 number, i, j, k;

            //Variable declaration ends.


            //Type of Variable and their property.
            sbyte typeA;        //8 bytes.      -128~127.
            byte typeB;         //8 bytes.      0~255.
            short typeC;        //16 bytes.     -32768~32768.
            ushort typeD;       //16 bytes.     0~65535.
            int typeE;          //32 bytes.     -2147483648~2147483647.
            uint typeF;         //32 bytes.     0~4294967295.
            long typeG;         //64 bytes.     -9223372036854775808~9223372036854775807.
            ulong typeH;        //64 bytes.     0~18446744073709551615.
            decimal typeI;      //64 bytes.     Handle to 28 decimal.
            float typeJ;        //32 bytes.     1.5*10^(-45)~3.4*10^(38).       指定float變數值時，必須在數值最後加上fex:float a = 0.3f;
            double typeK;       //64 bytes.     5.0*10^(-324)~1.7*10^(308)
            char typeL = 'A';
            string myName = "Charlisa";
            bool IsHappy = true;




            //Exercise begins.

            Console.WriteLine("Enter your name, please.");
            string userName = Console.ReadLine();
            Console.WriteLine("Could you please tell us you gender?");
            string userGender = Console.ReadLine();
            Console.WriteLine("Hello," + userName);
            Console.WriteLine("I guest that you must a " + userName);

            //Exercise ends.


        }
    }
}
