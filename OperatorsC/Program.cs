using System;

namespace OperatorsC
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}",num3); //result -5

            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}", !isSunny);//result false

            // increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num); // result 1
            Console.WriteLine("num is {0}", num++);//result 1
            // pre increment
            Console.WriteLine("num is {0}", ++num);//= result 3

            // decrement operator
            num--;
            Console.WriteLine("num is {0}", num);//result 2
            Console.WriteLine("num is {0}", num--);//result 2
            // pre decrement
            Console.WriteLine("num is {0}", --num);//result 0

            int result;

            result = num1 + num2;
            Console.WriteLine(" result of num1 + num2 is {0}", result);
            result = num1 - num2;
            Console.WriteLine(" result of num1 - num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine(" result of num1 / num2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine(" result of num1 * num2 is {0}", result);
            result = num1 % num2;
            Console.WriteLine(" result of num1 % num2 is {0}", result);

            //relational and type operators
            bool isLower;
            isLower = num1 > num2;
            Console.WriteLine("result of num1 > num2 is {0}", isLower);

            // equality operator
            bool isEqual;
            isEqual = num1 == num2;//false
            Console.WriteLine("result of num1 == num2 is {0}", isEqual);

            isEqual = num1 != num2;//true
            Console.WriteLine("result of num1 != num2 is {0}", isEqual);

            // conditional operators
            bool isLowerAndSunny;
            //condition1 AND condition2
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("result of isLower && isSunny is {0}", isLowerAndSunny);

            //condition1 OR condition2
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("result of isLower || isSunny is {0}", isLowerAndSunny);

            Console.ReadKey();
        }
    }
}