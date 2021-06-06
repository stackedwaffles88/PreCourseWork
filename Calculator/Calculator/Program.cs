using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    public class Calc
    {
        public int userResponseNumber1;
        public int userResponseNumber2;
        public string userInputOperation;
        

        public int Add(int a, int b)
        {
            int addition = a + b;
            return addition;
        }

        public int Subtract(int c, int d)
        {
            int subtract = c - d;
            return subtract;
        }

        public int Multiply(int e, int f)
        {
            int multiply = e * f;
            return multiply;
        }

        public int Divide(int g, int h)
        {
            int divide = g / h;
            return divide;
        }

        public void Greeting()
        {
            Console.WriteLine($"Hello! What operation would you like to perform? ( +, -, *, or /)");
        }
        public void GetUserNum()
        {
            Console.WriteLine("Ok, Add. What's your first number?");
            userResponseNumber1 = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("What's your second number?");
            userResponseNumber2 = Convert.ToInt32(Console.ReadLine().Trim());
        }

        public void Error2()
        {
            Console.WriteLine("Sorry, that's not a valid response! Try again.");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            calc.Greeting();

            START:
            calc.userInputOperation = Console.ReadLine().Trim();
            string inputAdd = "+";
            string inputSubtract = "-";
            string inputDivide = "/";
            string inputMultiply = "*";
            string userAnswer = Console.ReadLine().Trim().ToLower();

            if (calc.userInputOperation == inputAdd)
            {
                //Console.WriteLine("Ok, Add. What's your first number?");
                //calc.userResponseNumber1 = Convert.ToInt32(Console.ReadLine().Trim());
                //Console.WriteLine("What's your second number?");
                //calc.userResponseNumber2 = Convert.ToInt32(Console.ReadLine().Trim());
                Calc calc1 = new Calc();
                calc1.GetUserNum();
                Console.WriteLine("The answer is " + calc.Add(calc.userResponseNumber1, calc.userResponseNumber2));
                
            }

            else if (calc.userInputOperation == inputSubtract)
            {
                Console.WriteLine("Ok, Subtract. What's your first number?");
                calc.userResponseNumber1 = Convert.ToInt32(Console.ReadLine().Trim());
                Console.WriteLine("What's your second number?");
                calc.userResponseNumber2 = Convert.ToInt32(Console.ReadLine().Trim());
                calc.Subtract(calc.userResponseNumber1, calc.userResponseNumber2);
                Console.WriteLine("The answer is " + calc.Subtract(calc.userResponseNumber1, calc.userResponseNumber2));
            }

            else if (calc.userInputOperation == inputMultiply)
            {
                Console.WriteLine("Ok, Multiply. What's your first number?");
                calc.userResponseNumber1 = Convert.ToInt32(Console.ReadLine().Trim());
                Console.WriteLine("What's your second number?");
                calc.userResponseNumber2 = Convert.ToInt32(Console.ReadLine().Trim());
                calc.Multiply(calc.userResponseNumber1, calc.userResponseNumber2);
                Console.WriteLine("The answer is " + calc.Multiply(calc.userResponseNumber1, calc.userResponseNumber2));
            }

            else if (calc.userInputOperation == inputDivide)
            {
                Console.WriteLine("Ok, Divide. What's your first number?");
                calc.userResponseNumber1 = Convert.ToInt32(Console.ReadLine().Trim());
                Console.WriteLine("What's your second number?");
                calc.userResponseNumber2 = Convert.ToInt32(Console.ReadLine().Trim());
                calc.Divide(calc.userResponseNumber1, calc.userResponseNumber2);
                Console.WriteLine("The answer is " + calc.Divide(calc.userResponseNumber1, calc.userResponseNumber2));
                
            }

            else
            {
                calc.Error2();
                goto START;
            }

            
            
            
            if (userAnswer == "yes")
            {
                goto START;
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }

            
        }
    }
}
