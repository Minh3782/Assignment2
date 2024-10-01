using System;

namespace Assignment2
{
    public class Program
    {
        #region Hidden

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
        
        #endregion

        /// <summary>
        /// Write code to prompt the user to enter their first name, middle initial
        /// and last name. Then read their input and display the user's name three 
        /// times using the following three formats:
        ///     first last
        ///     first middle last
        ///     last, first middle
        /// </summary>
        public static void Question1()
        { //change to string ??
            Console.Write("First name");
            string first = Console.ReadLine();
            Console.Write("Middle name");
            string middle = Console.ReadLine();
            Console.Write("Last name");
            string last = Console.ReadLine();
            Console.WriteLine(first + last);
            Console.WriteLine(first + middle + last);
            Console.WriteLine(last + "," + first + middle);
        }

        /// <summary>
        /// Write code to prompt the user for two integers. Then read their input and
        /// display the sum and the difference of the two integers.
        /// </summary>
        public static void Question2()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b, a - b);

        }

        /// <summary>
        /// Write code to calculate the area of a circle. The user will enter the radius
        /// of the circle and the program will calculate and display the area. 
        /// You must accept decimal places as input.
        /// Formula: area = 3.14 * radius * radius
        /// </summary>
        public static void Question3()
        { 
            Console.WriteLine ("Radius of the circle");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("area = " + 3.14 * a * a); 

        }

        /// <summary>
        /// Write code to prompt the user to enter a single character. Then read their 
        /// input and display the following message: You entered <char>
        /// For this question, you must use a variable of type char.
        /// </summary>
        public static void Question4()
        {
            char a = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("You enterred " + a);
        }

        /// <summary>
        /// Write code to ask the user a simple true or false question and then read
        /// their answer. The code should then display the message: Your answer was <bool>
        /// For this question, you must use a variable of type boolean.
        /// </summary>
        public static void Question5()
        {
            Console.WriteLine("Is today in October ?");
            bool a = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Your answer was " + a);
            
        }

        /// <summary>
        /// Write code to prompt the user to enter how many siblings they have.
        /// Then read their input and display a message saying: I also have <int> siblings
        /// </summary>
        public static void Question6()
        {
            Console.WriteLine("How many siblings do you have ?");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("I also have " + s + "siblings");
        }

        /// <summary>
        /// Adult tickets cost $3.75 and child tickets cost $2.25. Write code to prompt 
        /// the user for the number of adult tickets and the number of child tickets 
        /// that they want. Then display the total cost.
        /// </summary>
        public static void Question7()
        {
            Console.Write("How many adults are there?");
            int adl = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many children are there?");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(
                "The total cost: " +
                (adl + c)
            )
        }
    }
}
