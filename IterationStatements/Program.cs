using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void FirstCounter()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void SecondCounter()
        {
            for (int i = 3; i <= 999; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool IsEqual(int x, int y)
        {
            return (x == y) ? true : false;
        }

        //Write a method to check whether a given number is even or odd
        public static string IsEvenOrOdd(int x)
        {
            return (x % 2 == 1) ? "odd" : "even";
        }

        //Write a method to check whether a given number is positive or negative

        public static string IsPositiveOrNegative (int x)
        {
            if (x > 0)
            {
                return "positive";
            } else if (x < 0)
            {
                return "negative";
            } else
            {
                return "value is 0";
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static string CanTheyDrive ()
        {
            Console.WriteLine("Please enter your age");

            string x = Console.ReadLine();

            int XtoInt;

            if (int.TryParse(x, out XtoInt))
            {
                if (XtoInt >= 18)
                {
                    return "You can vote";
                }
                else if (XtoInt < 18)
                {
                    return "You cannot vote";
                }
                else
                {
                    return "Invalid input, please try again";
                }
            } else
            {
                return "Parse failed";
            }

           
            
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static bool IsWithinRange (int x)
        {
            if ( x <= 10 || x >= -10)
            {
                return true;
            } else
            {
                return false;
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static String MultiplicationTable (int x)
        {
            int timesOne = x * 1;
            int timesTwo = x * 2;
            int timesThree = x * 3;
            int timesFour = x * 4;
            int timesFive = x * 5;
            int timesSix = x * 6;
            int timesSeven = x * 7;
            int timesEight =  x * 8;
            int timesNine = x * 9;
            int timesTen = x * 10;
            int timesEleven = x * 11;
            int timesTwelve = x * 12;
            return $"x times 1: {timesOne}\nx times 2: {timesTwo}\nx times 3: {timesThree}\nx times 4: {timesFour}\nx times 5: {timesFive}\n" +
                $"x times 6: {timesSix}\nx times 7: {timesSeven}\nx times 8: {timesEight}\nx times 9: {timesNine}\nx times 10: {timesTen}\n" +
                $"x times 11: {timesEleven}\nx times 12: {timesTwelve}";
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            FirstCounter();
            SecondCounter();
            Console.WriteLine(IsEqual(2, 2));
            Console.WriteLine(IsEvenOrOdd(5));
            Console.WriteLine(IsPositiveOrNegative(-2));
            Console.WriteLine(CanTheyDrive());
            Console.WriteLine(IsWithinRange(7));
            Console.WriteLine(IsWithinRange(-11));
            Console.WriteLine(MultiplicationTable(5));
        }
    }
}
