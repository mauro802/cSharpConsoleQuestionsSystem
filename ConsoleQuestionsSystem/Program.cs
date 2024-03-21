using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuestionsSystem
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            string number;
            do
            {
                Console.Write("Enter the number (1-7) for the question to run or 0 to exit: ");
                number = Console.ReadLine();
                ShowTitle(number);

                switch (number)
                {
                    case "1":
                        Question1();
                        break;
                    case "2":
                        Question2();
                        break;
                    case "3":
                        Question3();
                        break;
                    case "4":
                        Question4();
                        break;
                    case "5":
                        Question5();
                        break;
                    case "6":
                        Question6();
                        break;
                    case "7":
                        Question7();
                        break;
                }
            } while (number != "0");
        }

        public static void ShowTitle(string number)
        {
            Console.Clear();
            Console.WriteLine("Question {0}", number);
            Console.WriteLine("------------");
            Console.WriteLine();
        }



        /// <summary>
        /// Write code to prompt the user to enter their first name, middle initial
        /// and last name. Then read their input and display the user's name three 
        /// times using the following three formats:
        ///     first last
        ///     first middle last
        ///     last, first middle
        /// </summary>
        public static void Question1()
        {
            string firstName, middleInitial, lastName;

            Console.Write("Welcome. Please enter your first name: ");
            firstName = Console.ReadLine();

            Console.Write($"Thank you {firstName} for enter you first name. Now please enter your middle initial: ");
            middleInitial = Console.ReadLine();

            Console.Write($"You are almost done {firstName}, please enter your last name: ");
            lastName = Console.ReadLine();

            Console.WriteLine($"Congratulations {firstName}, you are done. See your data entered below with the requested format: ");
            Console.WriteLine($"{firstName} {lastName}");
            Console.WriteLine($"{firstName} {middleInitial} {lastName}");
            Console.WriteLine($"{lastName} {firstName} {middleInitial}");
        }

        /// <summary>
        /// Write code to prompt the user for two integers. Then read their input and
        /// display the sum and the difference of the two integers.
        /// </summary>
        public static void Question2()
        {
            int firstInteger, secondInteger, addition, subtraction;

            Console.Write("Welcome, please enter your first integer number: ");
            firstInteger = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Your first integer entered is {firstInteger}. Now enter your second integer number: ");
            secondInteger = Convert.ToInt32(Console.ReadLine());

            addition = firstInteger + secondInteger;
            subtraction = firstInteger - secondInteger;

            Console.WriteLine($"The integeres entered were: {firstInteger} and {secondInteger}");
            Console.WriteLine($"The addition of both is: {addition}");
            Console.WriteLine($"The subtraction of both is: {subtraction}");
        }

        /// <summary>
        /// Write code to calculate the area of a circle. The user will enter the radius
        /// of the circle and the program will calculate and display the area. 
        /// You must accept decimal places as input.
        /// Formula: area = 3.14 * radius * radius
        /// </summary>
        public static void Question3()
        {
            decimal radius, area;


            Console.WriteLine("Hello welcome to Circle Area Calculator");

            Console.Write($"To begin the calculation please enter the radius: ");
            radius = Convert.ToDecimal(Console.ReadLine());


            area = 3.14M * radius * radius;

            Console.WriteLine($"The area of the circle {radius} is: {area}");
        }

        /// <summary>
        /// Write code to prompt the user to enter a single character. Then read their 
        /// input and display the following message: You entered <char>
        /// For this question, you must use a variable of type char.
        /// </summary>
        public static void Question4()
        {
            char singleCharacter;

            Console.Write("Hello, please enter your favorite letter: ");
            singleCharacter = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"You entered the letter: {singleCharacter}");
        }

        /// <summary>
        /// Write code to ask the user a simple true or false question and then read
        /// their answer. The code should then display the message: Your answer was <bool>
        /// For this question, you must use a variable of type boolean.
        /// </summary>
        public static void Question5()
        {
            bool answer;

            Console.WriteLine("Hello this is a true or false question");
            Console.Write("Is Canada located in North America?: ");
            answer = Convert.ToBoolean(Console.ReadLine());

            if (answer == true)
            {
                Console.WriteLine($"Your answer was {answer} and it is the correct answer");
            }
            else
            {
                Console.WriteLine($"Your answer was {answer} and it is the wrong answer. The correct one is True");
            }
        }

        /// <summary>
        /// Write code to prompt the user to enter how many siblings they have.
        /// Then read their input and display a message saying: I also have <int> siblings
        /// </summary>
        public static void Question6()
        {
            int numberSiblings;

            Console.Write("How many siblings do you have?: ");
            numberSiblings = Convert.ToInt32(Console.ReadLine());

            if (numberSiblings == 1)
            {
                Console.WriteLine($"I also have {numberSiblings} sibling");
            }
            else
            {
                Console.WriteLine($"I also have {numberSiblings} siblings");
            }
        }

        /// <summary>
        /// Adult tickets cost $3.75 and child tickets cost $2.25. Write code to prompt 
        /// the user for the number of adult tickets and the number of child tickets 
        /// that they want. Then display the total cost.
        /// </summary>
        public static void Question7()
        {
            int numberAdultTickets, numberChildTickets;
            decimal totalCostTickets;

            Console.WriteLine("Welcome to the ticket purchase, below you can see the cost of the tickets.");
            Console.WriteLine("Adult ticket cost = $3.75, Child ticket cost = $2.25");

            Console.Write("How many adult tickets do you want?: ");
            numberAdultTickets = Convert.ToInt32(Console.ReadLine());

            Console.Write("And how many child tickets do you want?: ");
            numberChildTickets = Convert.ToInt32(Console.ReadLine());

            totalCostTickets = (3.75M * numberAdultTickets) + (2.25M  * numberChildTickets);

            Console.WriteLine($"The total cost of your tickets is: {totalCostTickets:c} ");
            Console.WriteLine("Thank you for buying here.");

        }
    }
}
