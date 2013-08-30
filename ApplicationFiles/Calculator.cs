using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Calculator
{
    class Calculator
    {
        static bool gotOP = false;
        static int intReturn = 0;
        static string choice;
        static bool wasTrue = false;
        static bool isNum = false;
        static int intNum1 = 0;
        static string num1 = null;
        static int savedOperationNumber = 1;
        static int savedCommandNumber = 1;
        static string op;
        static int intNum2 = 0;
        static bool correctOP = true;
        static string whatChanged = null;
        static string wasSuccessful = null;

        static void Main(string[] args)
        {
            if (!File.Exists("Saved-Operations.txt"))
            {
                StreamWriter createOperations = new StreamWriter("Saved-Operations.txt");
                createOperations.Close();
            }
            if (!File.Exists("Saved-Commands.txt"))
            {
                StreamWriter createCommands = new StreamWriter("Saved-Commands.txt");
                createCommands.Close();
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Welcome to ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Calculator");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("!");
            Console.Write("\nPress");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" enter");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" to start, or type");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" quit");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" to exit.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string key = Console.ReadLine();
            if (key == "quit")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            while (1 == 1)
            {
                gotOP = false;
                intReturn = 0;
                choice = null;
                wasTrue = false;
                isNum = false;
                intNum1 = 0;
                num1 = null;
                op = null;
                intNum2 = 0;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Please type your");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" first");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(" number.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                while (isNum == false)
                {
                    num1 = Console.ReadLine();
                    if (num1 == "quit")
                    {
                        Environment.Exit(0);
                    }
                    try { intNum1 = int.Parse(num1); isNum = true; }
                    catch (System.FormatException)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Please enter a number.");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        isNum = false;
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Your first number is ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(intNum1);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(".\n\n");
                Console.Write("Please type your");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" operator");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(". Type");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" help");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(" to see a list of operators.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                op = Console.ReadLine();
                if (op == "quit")
                {
                    Environment.Exit(0);
                }
                switch (op)
                {
                    case "+":
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("You are");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(" adding");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine(".\n\n");
                        break;
                    case "-":
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("You are");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(" subtracting");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine(".\n\n");
                        break;
                    case "*":
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("You are");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(" multiplying");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine(".\n\n");
                        break;
                    case "/":
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("You are");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(" dividing");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine(".\n\n");
                        break;
                    case "<":
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("You are trying your");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(" first number");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(" against your");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(" second number");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine(".\n\n");
                        break;
                    case ">":
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("You are trying your");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(" second number");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(" against your");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(" first number");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine(".\n\n");
                        break;
                    case "%":
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("You are finding the");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(" remainder");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(" of your");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(" first number");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(" and your");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(" second number");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine(".\n\n");
                        break;
                    case "!":
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("\nOpening");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write(" command prompt");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("...\n");
                        Console.Write("\nRetype your");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write(" first number");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(".");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        num1 = Console.ReadLine();
                        if (num1 == "quit")
                        {
                            Environment.Exit(0);
                        }
                        try { intNum1 = int.Parse(num1); }
                        catch (System.FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.Write("Number not recieved. Closing");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(" command prompt");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("...\n");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            isNum = false;
                        }
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("Number changed");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(" successfully");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write(". Closing");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write(" command prompt");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("...\n");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("\nPlease type your");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(" operator");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine(".");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        op = Console.ReadLine();
                        if (op != "+" || op != "-" || op != "*" || op != "/" || op != "%" || op != ">" || op != "<" || op != "!")
                        {
                            correctOP = false;
                        }
                        if (op == "!")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.Write("\nOpening");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(" command prompt");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("...\n");
                            Console.Write("\nRetype your");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(" first number");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine(".");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            num1 = Console.ReadLine();
                            if (num1 == "quit")
                            {
                                Environment.Exit(0);
                            }
                            try { intNum1 = int.Parse(num1); }
                            catch (System.FormatException)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.Write("Number not recieved. Closing");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.Write(" command prompt");
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("...\n\n");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                isNum = false;
                            }
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.Write("Number changed");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(" successfully");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.Write(". Closing");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(" command prompt");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("...\n\n");
                            bool canContinue = false;
                            while (canContinue == false)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("Please enter your");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(" operator");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine(".");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                op = Console.ReadLine();
                                if (op == "!")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.Write("\nOpening");
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.Write(" command prompt");
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("...\n");
                                    Console.Write("\nRetype your");
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.Write(" first number");
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine(".");
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    num1 = Console.ReadLine();
                                    if (num1 == "quit")
                                    {
                                        Environment.Exit(0);
                                    }
                                    try { intNum1 = int.Parse(num1); }
                                    catch (System.FormatException)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.Write("Number not recieved. Closing");
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.Write(" command prompt");
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("...\n\n");
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        isNum = false;
                                    }
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.Write("Number changed");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write(" successfully. ");
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.Write("Closing");
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.Write(" command prompt");
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("...\n\n");
                                }
                                if (op == "+" || op == "-" || op == "*" || op == "/" || op == "%" || op == ">" || op == "<")
                                {
                                    canContinue = true;
                                    if (op == "!")
                                    {
                                        canContinue = false;
                                    }
                                }
                            }
                            if (op == "help")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("\n+ - + -");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(" Operators");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine(" - + - +");
                                Console.WriteLine("=========================");
                                Console.Write("Addition       :");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(" +");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("Subtraction    :");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(" -");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("Multiplication :");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(" *");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("Division       :");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(" /");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("Modulus        :");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(" %");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("Greater Than   :");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(" >");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("Less Than      :");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(" <");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("\nPlease type your");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(" operator");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine(".");
                                Console.WriteLine("\n");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                op = Console.ReadLine();
                                if (op != "+" || op != "-" || op != "*" || op != "/" || op != "%" || op != ">" || op != "<")
                                {
                                    correctOP = false;
                                }
                                while (correctOP == false)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.Write("\nPlease enter a valid");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.Write(" operator");
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine(".");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    op = Console.ReadLine();
                                    if (op == "+" || op == "-" || op == "*" || op == "/" || op == "%" || op == ">" || op == "<")
                                    {
                                        correctOP = true;
                                    }
                                    if (op == "!")
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.Write("\nOpening ");
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.Write("command prompt");
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("...");
                                        Console.Write("\nRetype your");
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.Write(" first number");
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine(".");
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        num1 = Console.ReadLine();
                                        if (num1 == "quit")
                                        {
                                            Environment.Exit(0);
                                        }
                                        try { intNum1 = int.Parse(num1); }
                                        catch (System.FormatException)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.Write("Number not recieved. Closing");
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.Write(" command prompt");
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("...\n\n");
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            isNum = false;
                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.Write("Number changed");
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.Write("successfully. ");
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.Write("Closing");
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.Write(" command prompt");
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("...\n\n");
                                    }
                                    else
                                    {
                                        correctOP = false;
                                    }
                                }
                            }
                        }
                        while (correctOP == false)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("\nPlease enter a valid");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(" operator");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(".");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            op = Console.ReadLine();
                            if (op == "+" || op == "-" || op == "*" || op == "/" || op == "%" || op == ">" || op == "<" || op == "!")
                            {
                                correctOP = true;
                                if (op == "!")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.Write("\nOpening ");
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.Write(" command prompt");
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("...");
                                    Console.Write("\nRetype your");
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.Write(" first number");
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine(".");
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    num1 = Console.ReadLine();
                                    if (num1 == "quit")
                                    {
                                        Environment.Exit(0);
                                    }
                                    try { intNum1 = int.Parse(num1); }
                                    catch (System.FormatException)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.Write("Number not recieved. Closing");
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.Write(" command prompt");
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("...\n\n");
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        isNum = false;
                                    }
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.Write("Number changed");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write("successfully. ");
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.Write("Closing");
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.Write(" command prompt");
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("...\n\n");
                                }
                                else
                                {
                                    correctOP = false;
                                }
                            }
                            else if (op == "help")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("\n+ - + -");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(" Operators");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine(" - + - +");
                                Console.WriteLine("=========================");
                                Console.Write("Addition       :");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(" +");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("Subtraction    :");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(" -");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("Multiplication :");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(" *");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("Division       :");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(" /");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("Modulus        :");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(" %");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("Greater Than   :");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(" >");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("Less Than      :");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(" <");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("\nPlease type your");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(" operator");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine(".");
                                Console.WriteLine("\n");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                op = Console.ReadLine();
                                if (op != "+" || op != "-" || op != "*" || op != "/" || op != "%" || op != ">" || op != "<")
                                {
                                    correctOP = false;
                                }
                                while (correctOP == false)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.Write("\nPlease enter a valid");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.Write(" operator");
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine(".");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    op = Console.ReadLine();
                                    if (op == "+" || op == "-" || op == "*" || op == "/" || op == "%" || op == ">" || op == "<")
                                    {
                                        correctOP = true;
                                    }
                                    if (op == "!")
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.Write("\nOpening ");
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.Write(" command prompt");
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("...\n");
                                        Console.Write("\nRetype your");
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.Write(" first number");
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine(".");
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        num1 = Console.ReadLine();
                                        if (num1 == "quit")
                                        {
                                            Environment.Exit(0);
                                        }
                                        try { intNum1 = int.Parse(num1); }
                                        catch (System.FormatException)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.Write("Number not recieved. Closing");
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.Write(" command prompt");
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("...\n\n");
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            isNum = false;
                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.Write("Number changed");
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.Write("successfully. ");
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.Write("Closing");
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.Write(" command prompt");
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("...\n\n");
                                    }
                                    else
                                    {
                                        correctOP = false;
                                    }
                                }
                            }
                            else
                            {
                                correctOP = false;
                            }
                        }
                        break;
                    case "help":
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("\n+ - + -");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(" Operators");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine(" - + - +");
                        Console.WriteLine("=========================");
                        Console.Write("Addition       :");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(" +");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("Subtraction    :");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(" -");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("Multiplication :");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(" *");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("Division       :");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(" /");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("Modulus        :");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(" %");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("Greater Than   :");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(" >");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("Less Than      :");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(" <");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("\nPlease type your");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(" operator");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine(".");
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        op = Console.ReadLine();
                        if (op != "+" || op != "-" || op != "*" || op != "/" || op != "%" || op != ">" || op != "<")
                        {
                            correctOP = false;
                        }
                        while (correctOP == false)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("\nPlease enter a valid");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(" operator");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(".");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            op = Console.ReadLine();
                            if (op == "+" || op == "-" || op == "*" || op == "/" || op == "%" || op == ">" || op == "<")
                            {
                                correctOP = true;
                            }
                            else if (op == "!")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.Write("\nOpening ");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.Write(" command prompt");
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("...");
                                Console.Write("\nRetype your");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.Write(" first number");
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine(".");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                num1 = Console.ReadLine();
                                if (num1 == "quit")
                                {
                                    Environment.Exit(0);
                                }
                                try { intNum1 = int.Parse(num1); }
                                catch (System.FormatException)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.Write("Number not recieved. Closing");
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.Write(" command prompt");
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("...\n\n");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    isNum = false;
                                }
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.Write("Number changed");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.Write(" successfully. ");
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.Write("Closing");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.Write(" command prompt");
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("...\n\n");
                            }
                            else
                            {
                                correctOP = false;
                            }
                        }
                        break;
                    default:
                        correctOP = false;
                        while (correctOP == false)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("\nPlease enter a valid");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(" operator");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(".");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            op = Console.ReadLine();
                            if (op == "+" || op == "-" || op == "*" || op == "/" || op == "%" || op == ">" || op == "<")
                            {
                                correctOP = true;
                            }
                            else
                            {
                                correctOP = false;
                            }
                        }
                        Console.WriteLine("\n");
                        break; 
                }
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Please type your");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" second");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(" number.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                isNum = false;
                string num2 = null;
                string op1 = null;
                while (isNum == false)
                {
                    num2 = Console.ReadLine();
                    if (num2 == "quit")
                    {
                        Environment.Exit(0);
                    }
                    else if (num2 == "!")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("\nOpening ");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write(" command prompt");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("...");
                        Console.Write("\nRetype your");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write(" operator");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(".");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        op1 = Console.ReadLine();
                        if (op1 == "quit")
                        {
                            Environment.Exit(0);
                        }
                        if (op1 != "+" || op1 != "-" || op1 != "*" || op1 != "/" || op1 != "%" || op1 != ">" || op1 != "<")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.Write("Operator not recieved. Closing");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(" command prompt");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("...\n\n");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            isNum = false;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.Write("Operator changed");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write("successfully. ");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.Write("Closing");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(" command prompt");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("...\n\n");
                            op = op1;
                        }
                    }
                    try { intNum2 = int.Parse(num2); isNum = true; }
                    catch (System.FormatException)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Please enter a number.");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        isNum = false;
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("\nYour second number is ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(intNum2);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(".\n\n");
                while (gotOP == false)
                {
                    switch (op)
                    {
                        case "+":
                            intReturn = intNum1 + intNum2;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(intNum1);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(" " + op);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(" " + intNum2);
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(" equals");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write(" " + intReturn);
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(".");
                            Console.Write("\nPress enter to");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" continue");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(", or type");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" quit");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(" to exit.");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            SaveOperations();
                            choice = Console.ReadLine();
                            if (choice == "quit")
                            {
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.Clear();
                            }
                            gotOP = true;
                            break;
                        case "-":
                            intReturn = intNum1 - intNum2;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(intNum1);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(" " + op);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(" " + intNum2);
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(" equals");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write(" " + intReturn);
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(".");
                            Console.Write("\nPress enter to");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" continue");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(", or type");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" quit");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(" to exit.");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            SaveOperations();
                            choice = Console.ReadLine();
                            if (choice == "quit")
                            {
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.Clear();
                            }
                            gotOP = true;
                            break;
                        case "*":
                            intReturn = intNum1 * intNum2;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(intNum1);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(" " + op);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(" " + intNum2);
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(" equals");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write(" " + intReturn);
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(".");
                            Console.Write("\nPress enter to");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" continue");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(", or type");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" quit");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(" to exit.");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            SaveOperations();
                            choice = Console.ReadLine();
                            if (choice == "quit")
                            {
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.Clear();
                            }
                            gotOP = true;
                            break;
                        case "/":
                            intReturn = intNum1 / intNum2;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(intNum1);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(" " + op);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(" " + intNum2);
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(" equals");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write(" " + intReturn);
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(".");
                            Console.Write("\nPress enter to");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" continue");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(", or type");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" quit");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(" to exit.");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            SaveOperations();
                            choice = Console.ReadLine();
                            if (choice == "quit")
                            {
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.Clear();
                            }
                            gotOP = true;
                            break;
                        case "%":
                            intReturn = intNum1 % intNum2;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(intNum1);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(" " + op);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(" " + intNum2);
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(" equals");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write(" " + intReturn);
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(".");
                            Console.Write("\nPress enter to");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" continue");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(", or type");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" quit");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(" to exit.");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            SaveOperations();
                            choice = Console.ReadLine();
                            if (choice == "quit")
                            {
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.Clear();
                            }
                            gotOP = true;

                            break;
                        case "<":
                            if (intNum1 < intNum2 == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(intNum1);
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write(" is");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.Write(" less than");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(" " + intNum2);
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine(".");
                                wasTrue = true;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(intNum1);
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(" is not");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write(" less than");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(" " + intNum2);
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine(".");
                                wasTrue = false;
                            }
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("\nPress enter to");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" continue");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(", or type");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" quit");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(" to exit.");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            SaveOperations();
                            choice = Console.ReadLine();
                            if (choice == "quit")
                            {
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.Clear();
                            }
                            gotOP = true;
                            break;
                        case ">":
                            if (intNum1 > intNum2 == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(intNum1);
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write(" is");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.Write(" greater than");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(" " + intNum2);
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine(".");
                                wasTrue = true;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(intNum1);
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(" is not");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write(" greater than");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(" " + intNum2);
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine(".");
                                wasTrue = false;
                            }
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("\nPress enter to");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" continue");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(", or type");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" quit");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(" to exit.");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            SaveOperations();
                            choice = Console.ReadLine();
                            if (choice == "quit")
                            {
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.Clear();
                            }
                            gotOP = true;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("That is not a valid");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(" operator");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(". Type");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(" help");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(" to see a list of operators.");
                            gotOP = false;
                            break;
                    }
                } 
            }
        }
        public static void SaveOperations()
        {
            StreamWriter savedOperations = File.AppendText("Saved-Operations.txt");
            savedOperationNumber = savedOperationNumber + 1;
            if (op == "+" || op == "-" || op == "*" || op == "/" || op == "%")
            {
                savedOperations.WriteLine(savedOperationNumber + "." + " " + intNum1 + " " + op + " " + intNum2 + " = " + intReturn);
                savedOperations.Close();
                savedOperationNumber = savedOperationNumber + 1;
            }
            else
            {
                savedOperations.WriteLine(savedOperationNumber + "." + " " + intNum1 + " " + op + " " + intNum2 + " = " + wasTrue);
                savedOperations.Close();
                savedOperationNumber = savedOperationNumber + 1;
            }
        }
        public static void SaveCommands()
        {
            StreamWriter savedCommands = File.AppendText("Saved-Commands.txt");
            savedCommands.WriteLine(savedCommandNumber + "." + " Command: !, to change " + whatChanged + ". " + wasSuccessful);
            savedCommands.Close();
            savedCommandNumber = savedCommandNumber + 1;
        }
    }
}
