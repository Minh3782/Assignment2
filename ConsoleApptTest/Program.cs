// See https://aka.ms/new-console-template for more information

//QUESTION 1
//Console.Write("Type a number to enter your choice: ");
//int numberChoice = Convert.ToInt32(Console.ReadLine());
//switch (numberChoice)
//{
//    case 1:
//        Console.WriteLine("Calculate area");
//        break;
//    case 2:
//        Console.WriteLine("Calculate volume");
//        break;
//    case 3:
//        Console.WriteLine("Calculate surface area");
//        break;
//    case 4:
//        Console.WriteLine("Exit the program");
//        break;
//    default:
//        Console.WriteLine("ERROR: Invalid choice");
//        break;
//}
//QUESTION 2
//Console.Write("Enter two integers, the first one: ");
//int stInt = Convert.ToInt32(Console.ReadLine());
//Console.Write("the second one: ");
//int ndInt = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter a character: ");
//char myCharacter = Convert.ToChar(Console.ReadLine());
//if (myCharacter == 'A')
//{
//    Console.WriteLine($"The sum of two integers: {stInt + ndInt}");
//}
//else if (myCharacter == 'S')
//{
//    Console.WriteLine($"The difference of the second integer from the first: {ndInt - stInt}");
//}
//else
//{
//    Console.WriteLine($"The product of two integers: {stInt * ndInt}");
//}

//QUESTION 4
Console.WriteLine("Enter a weekday: ");
string myDay = Console.ReadLine();
switch (myDay)
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
}
