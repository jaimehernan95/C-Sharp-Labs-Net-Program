using System;

namespace Lab4SectionA
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1, num2, num3;
                int methodUsed;
                int result;
                Console.WriteLine("Insert first number");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insert second number");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insert third number");
                num3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("calculate greatest number using 1) if statement only or 2) if else statement (Type 1 or 2):");
                methodUsed = Convert.ToInt32(Console.ReadLine());

                switch(methodUsed)
                {
                    case 1:
                        result = CalculateGreatestWithIfOnly(num1, num2, num3);
                        break;
                    default:
                        result = CalculateGreatestwithIfElse(num1, num2, num3);
                        break;
                }

                Console.WriteLine("greatest number is: {0}", result);
                Console.ReadKey();
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("Kindly Enter a number");
            }
            catch(FormatException)
            {
                Console.WriteLine("Kindly Enter a correct number");
            }
        }

        public static int CalculateGreatestWithIfOnly(int num1, int num2, int num3)
        {
            if(num1 >= num2 && num1 >= num3)
            {
                return num1;
            }

            if (num2 >= num1 && num2 >= num3)
            {
                return num2;
            }

            return num3;
        }

        public static int CalculateGreatestwithIfElse(int num1, int num2, int num3)
        {
            if (num1 >= num2 && num1 >= num3)
            {
                return num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }

        }
    }
}
