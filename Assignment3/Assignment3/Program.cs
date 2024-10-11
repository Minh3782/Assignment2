using System;
using System.IO;

namespace Assignment3
{
    class Program
    {
        #region Hidden

        public static void Main(string[] args)
        {
            string number;
            do
            {
                Console.Write("Enter the number (1-10) for the question to run or 0 to exit: ");
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
                    case "8":
                        Question8();
                        break;
                    case "9":
                        Question9();
                        break;
                    case "10":
                        Question10();
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

        #endregion

        /// <summary>
        /// Write code that prompts the user for a menu choice.
        /// The program will display a message based on the following:
        ///   Choice            Message
        ///   1                 "Calculate area"
        ///   2                 "Calculate volume"
        ///   3                 "Calculate surface area"
        ///   4                 "Exit the program"
        ///   any other input   "ERROR: Invalid choice"
        /// </summary>
        public static void Question1()
        {
            Console.Write("Type a number to enter your choice: ");
            int numberChoice = Convert.ToInt32(Console.ReadLine());
            switch(numberChoice)
            {
                case 1:
                    Console.WriteLine("Calculate area");
                    break;
                case 2:
                    Console.WriteLine("Calculate volume");
                    break;
                case 3:
                    Console.WriteLine("Calculate surface are");
                    break;
                case 4:
                    Console.WriteLine("Exit the program");
                    break;
                default:
                    Console.WriteLine("ERROR: Invalid choice");
                    break ;
            }

        }

        /// <summary>
        /// Write code that allows the user to enter two integers and a character.
        /// If the character is 'A', then add the two integers.
        /// If the character is 'S', then subtract the second integer from the first.
        /// Otherwise, multiply the integers.
        /// Display the results of the arithmetic.
        /// </summary>
        public static void Question2()
        {
            Console.Write("Enter two integers, the first one: ");
            int stInt = Convert.ToInt32(Console.ReadLine());
            Console.Write("the second one: ");
            int ndInt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a character: ");
            char myCharacter = Convert.ToChar(Console.ReadLine());
            if (myCharacter == 'A')
            {
                Console.WriteLine($"The sum of two integers: {stInt + ndInt}");
            }
            else if (myCharacter == 'S')
            {
                Console.WriteLine($"The difference of the second integer from the first: {ndInt - stInt}");
            }
            else
            {
                Console.WriteLine($"The product of two integers: {stInt * ndInt}");
            }
        }

        /// <summary>
        /// Write code that prompts the user for the number of cources and residency status
        /// (domestic or international) and calculates tuition cost. Cost is calculated based on the
        /// folowing:
        ///     Domestic        $325 per course
        ///     International   $1375 per course
        /// You decide how you want the user to enter their residency status and prompt accordingly.
        /// You must use named constants for the cost per course.
        /// Display the total cost.
        /// </summary>
        public static void Question3()
        {

        }

        /// <summary>
        /// Write code that prompts the user for a day of the week. The program will display a 
        /// message based on the following:
        ///     Choice      Message
        ///     Sun         Home
        ///     Mon         Work
        ///     Tue         Work
        ///     Wed         Home
        ///     Thu         Work
        ///     Fri         Work
        ///     Sat         Work
        /// </summary>
        public static void Question4()
        {
            Console.WriteLine("Enter a weekday: ");
            string myDay = Console.ReadLine();
            switch(myDay)
            {
                case "Mon":
                    Console.WriteLine("Work");
                    break;
                case "Tue":
                    Console.WriteLine("Work");
                    break;
                case "Wed":
                    Console.WriteLine("Work");
                    break;
                case "Thu":
                    Console.WriteLine("Work");
                    break;
                case "Fri":
                    Console.WriteLine("Work");
                    break;
                case "Sat":
                    Console.WriteLine("Work");
                    break;
                case "Sun":
                    Console.WriteLine("Home");
                    break;
                    default:
                    break;
            }

        /// <summary>
        /// Write code for a furniture company. Ask the user to choose Pine, Oak or Mahogany.
        /// Show the price of a table manufactured with the choosen wood. Pine tables cost $100, 
        /// Oak tables cost $125, and Mahogany tables cost $310. You must use named constants and
        /// a switch statement. You must accept any variation on the case (Eg. Pine, pine, PINE, piNe, etc
        /// </summary>
        public static void Question5()
        {

        }

        /// <summary>
        /// Write code that prompts the user for an hourly pay rate. If the value entered is less than
        /// $5.65, display an error message
        /// </summary>
        public static void Question6()
        {

        }

        /// <summary>
        /// Write code that prompt a user for an hourly pay rate. If the user enters a vale less than
        /// $5.65 or greater than $49.99, prompt the user again. If the user enters an invalid value again,
        /// display an appropriate error message. If the user enters a valid value on either the first or
        /// second attempt, display the pay rate as well as the weekly rate which is calculated as 40 times 
        /// the hourly rate.
        /// </summary>
        public static void Question7()
        {

        }

        /// <summary>
        /// Write a program for a college's admissions office. The user enters a numeric high school grade
        /// point average (ex. 3.2) and an admission test score. Print the message "Accept" if the student
        /// meets either of the following requirements:
        ///     A grade point average of 3.0 or higher and an admission test score of at least 60
        ///     A grade point average of less than 3.0 and an admission test score of at least 80
        /// If the student does not meet either of the qualification criteria, print "Reject"
        /// </summary>
        public static void Question8()
        {

        }

        /// <summary>
        /// Write code that prompts the uesr for an hourly pay rate and hours worked. Compute gross pay
        /// (hours times pay rate), withholding tax, and net pay (gross pay minus withholding tax).
        /// Withholding tax is computed as a percentage of gross pay based on the following:
        ///     Gross pay                       Withholding Percentage
        ///     Up to an including 300.00       10%
        ///     300.01 and up                   12%
        /// </summary>
        public static void Question9()
        {

        }

        /// <summary>
        /// Write code for a lawn-mowing service. The lawn-mowing season lasts 20 weeks. The weekly fee
        /// for mowing a lot under 400 square feet is $25. The fee for a lot that is 400 square feet or more,
        /// but under 600 square feet, is $35 per week. The fee for a lot that is 600 square feet or over is 
        /// $50 per week. Prompt the user for the length and width of a lawn, and then print the weekly
        /// mowing fee, as well as the total fee for the 20-week season.
        /// </summary>
        public static void Question10()
        {

        }
    }
}
