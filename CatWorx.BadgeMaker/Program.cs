using System;
using System.Collections.Generic;
namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main()
        {
            // double side = 3.14;
            // double area = side * side;
            // Console.WriteLine("area: {0}", area);
            // Console.WriteLine("area is a {0}", area.GetType());


            // Console.WriteLine(2 * 3);         // Basic Arithmetic: +, -, /, *
            // Console.WriteLine(10 % 3);        // Modulus Op => remainder of 10/3
            // Console.WriteLine(1 + 2 * 3);     // order of operations
            // Console.WriteLine(10 / 3.0);      // int's and doubles
            // Console.WriteLine(10 / 3);        // int's 
            // Console.WriteLine("12" + "3");    // What happens here?

            // int num = 10;
            // num += 100;
            // Console.WriteLine(num);
            // num++;
            // Console.WriteLine(num);

            // bool isCold = true;
            // Console.WriteLine(isCold ? "drink" : "add ice");
            // Console.WriteLine(!isCold ? "drink" : "add ice");

            string stringNum = "2";
            int intNum = Convert.ToInt16(stringNum);
            Console.WriteLine(intNum);
            Console.WriteLine(intNum.GetType());



        }
    }
}