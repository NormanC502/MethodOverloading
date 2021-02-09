using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var returnString = Add(1, 10, true);

            Console.WriteLine(returnString);
        }

        private static int Add (int number1, int number2)
        {
            return number1 + number2;
        }

        private static decimal Add (decimal num1, decimal num2)
           
        {
            return num1 + num2;
        }

        private static string Add(int number5, int number6, bool canAdd)

            
        {
            if (canAdd == true && number5 + number6 == 1)
            {

                return $"{number5 + number6} dollar";
            }
            else if (canAdd == true && number5 + number6 > 1)
            {

                return $"{number5 + number6} dollars";
            }
            else
            {
                return "Cant add these numbers";
            }



        }

               
    }   
}
