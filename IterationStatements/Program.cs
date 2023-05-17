namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Printthousands(int highest,int lowest)
        {
            for(int i = 1000; i>= lowest; i --)
            {
                Console.WriteLine(i);
                           
            }

        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Triplenine()
        {
            for (int j = 3; j >= 999; j += 3)
            {
                Console.WriteLine(j);
            }
        }


        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool Equal(int a, int b)
        {
            
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        //Write a method to check whether a given number is even or odd
        public static void EvenorOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
        }

        //Write a method to check whether a given number is positive or negative
        static void Positivenegative()
        {
            var number = 6;

            if (number > 0)
            {
                Console.WriteLine($"positive");

            }
            else
            {
                Console.WriteLine($"negative");
            }
        }


        //Write a method to read the age of a candidate and determine whether they can vote.
        public static bool VoteAge(int age)
        {
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool Range(int number)
        {
            return number >= -10 && number <= 10;
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} x {i} = {result}");
            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Printthousands(1000, -1000);
            Triplenine();
            Equal(2,2);
            Positivenegative();
            EvenorOdd(19);
            VoteAge(34);
            Range(14);
            MultiplicationTable(34);
          


        }
    }
}
