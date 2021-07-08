using System;

namespace SoloLearnDay2_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch statement
            Console.WriteLine("Switch without using default");
            int numBer = 3;
            switch (numBer)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
            }

            //By using default
            Console.WriteLine("Switch by using default");
            int age = 88;
            switch (age)
            {
                case 16:
                    Console.WriteLine("Too young");
                    break;
                case 42:
                    Console.WriteLine("Adult");
                    break;
                case 70:
                    Console.WriteLine("Senior");
                    break;
                default:
                    Console.WriteLine("The default case");
                    break;
            }

            //While loop
            Console.WriteLine("Use of while loop");
            int num = 1;
            while (num < 6)
            {
                Console.WriteLine(num);
                num++;
            }

            int x = 1;
            while (x++ < 5)
            {
                if (x % 2 == 0)
                    x += 2;
            }

            //for loop
            Console.WriteLine("Use of for loop");
            for (int a = 10; a < 15; a++)
            {
                Console.WriteLine("Value of a: {0}", a);
            }


            int s = 10;
            for (; s > 0;)
            {
                Console.WriteLine(s);
                s -= 3;
            }

            //do while
            Console.WriteLine("Use of do while");
            int z = 0;
            do
            {
                Console.WriteLine(z);
                z++;
            } while (z < 5);


            //use of break in other loops
            Console.WriteLine(use of break in other loops);
            int number = 0;
            while (number < 20)
            {
                if (number == 5)
                    break;

                Console.WriteLine(number);
                number++;
            }

            //Continue
            Console.WriteLine("Use of continue");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue;

                Console.WriteLine(i);
            }
        }
    }
}
