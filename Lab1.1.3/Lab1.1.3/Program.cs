﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine(@"Please,  type the number:
            1. Farmer, wolf, goat and cabbage puzzle
            2. Console calculator
            3. Factirial calculation
            ");

            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Farmer_puzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    Factorial_calculation();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        #region farmer
        static void Farmer_puzzle()
        {
            bool wolf = true;
            bool cabbage = true;
            bool goat = true;

            int selection;

            while (true)
            {


                Console.WriteLine("What does farmer ride on the next bank");
                if (wolf)
                {
                    Console.WriteLine("There: farmer and wolf - 1");
                }
                if (cabbage)
                {
                    Console.WriteLine("There: farmer and cabbage - 2");
                }
                if (goat)
                {
                    Console.WriteLine("There: farmer and goat - 3");
                }
                Console.WriteLine("There: farmer - 4");

                selection = int.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        wolf = false;
                        break;
                    case 2:
                        cabbage = false;
                        break;
                    case 3:
                        goat = false;
                        break;
                }
                if (wolf == false && goat == false && cabbage == false)
                {
                    Console.WriteLine("Congratulation. You win");
                    break;
                }
                if (wolf == true && goat == true && cabbage == false)
                {
                    Console.WriteLine("Wolf eat's goat. You loose");
                    break;
                }
                if (goat == true && cabbage == true && wolf == false)
                {
                    Console.WriteLine("Goat eats cabbage. You loose");
                    break;
                }

                Console.WriteLine("What does farmer ride on the next bank");
                if (wolf == false)
                {
                    Console.WriteLine("Back: farmer and wolf - 5");
                }
                if (cabbage == false)
                {
                    Console.WriteLine("Back: farmer and cabbage - 6");
                }
                if (goat == false)
                {
                    Console.WriteLine("Back: farmer and goat - 7");
                }
                Console.WriteLine("Back: farmer - 8");

                selection = int.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 5:
                        wolf = true;
                        break;
                    case 6:
                        cabbage = true;
                        break;
                    case 7:
                        goat = true;
                        break;
                }

                if (wolf == false && goat == false)
                {
                    Console.WriteLine("Wolf eat's goat. You loose");
                    break;
                }
                if (goat == false && cabbage == false)
                {
                    Console.WriteLine("Goat eats cabbage. You loose");
                    break;
                }

            }
        }
        #endregion

        #region calculator
        static void Calculator()
        {
            Console.WriteLine(@"Select the arithmetic operation:
            1. Multiplikation
            2. Divide
            3. Addition
            4. Substraction
            5. Exponentiation
            ");

            int a, firstOperand, secondOperand;

            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter first operand: ");
            firstOperand = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter first operand: ");
            secondOperand = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("{0} * {1} = {2}", firstOperand, secondOperand, firstOperand * secondOperand);
                    break;
                case 2:
                    if (secondOperand == 0)
                    {
                        Console.WriteLine("Division by zero forbidden");
                        break;
                    }
                    Console.WriteLine("{0} / {1} = {2}", firstOperand, secondOperand, firstOperand / secondOperand);
                    break;
                case 3:
                    Console.WriteLine("{0} + {1} = {2}", firstOperand, secondOperand, firstOperand + secondOperand);
                    break;
                case 4:
                    Console.WriteLine("{0} - {1} = {2}", firstOperand, secondOperand, firstOperand - secondOperand);
                    break;
                case 5:
                    Console.WriteLine("{0} exponents {1} is {2}", firstOperand, secondOperand, Math.Pow(firstOperand, secondOperand));
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;

            }

        }
        #endregion

        #region Factorial
        static void Factorial_calculation()
        {
            Console.WriteLine("Write number ");
            int numberInt = int.Parse(Console.ReadLine());
            if (numberInt >= 0)
            {
                int result = Fact(numberInt);
                Console.WriteLine("{0}! = {1}", numberInt, result);
            }
            else
                Console.WriteLine("You type wrong number");



        }

        static int Fact(int n)
        {
            if (n <= 1)
                return 1;
            return n * Fact(n - 1);
        }
        #endregion
    }
}
