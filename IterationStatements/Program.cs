namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Printthousands()
        {
            for(int i = 1000; i >= -1000; i --)
            {
                Console.WriteLine(i);
                           
            }

        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Triplenine()
        {
            for (int i = 3; i >= 999; i += 3)
            {
                Console.WriteLine(i);
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
            
            if (number % 2 != 0)
            {
                Console.WriteLine($"{number} is odd.");
            }
            else
            {
                Console.WriteLine($"{number} is even.");
            }
        }

        //Write a method to check whether a given number is positive or negative
        static int PositiveNegative(int number) //methods PascalCasing variables camelCasing
        {
            

            if (number > 0)
            {
                
                Console.WriteLine($"positive");
                return number;

            }
            else
            {
                Console.WriteLine($"negative");
                return number;
            }
        }


        //Write a method to read the age of a candidate and determine whether they can vote.
        public static bool VoteAge()
        {
            Console.WriteLine($"How old are you");
            var age = int.Parse(Console.ReadLine());
         
            if (age >= 18)
            {
                Console.WriteLine($"you are {age} so you can vote");
                return true;
            }
            else
            {
                Console.WriteLine($"you are {age} so you cant vote");
                return false;
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool Range()
        {
            Console.WriteLine($"give me a number");
            var number = int.Parse(Console.ReadLine());
            if (number >= -10 && number <= 10) 
            {
               
                Console.WriteLine($"That is in the range");
                return true;
            }
            else 
            {
                Console.WriteLine($"That is not in range");
                return false;
            }
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
            Printthousands();
            Triplenine();
            Equal(2, 2);
            PositiveNegative(6);
            EvenorOdd(19);
            VoteAge();
            Range();
            MultiplicationTable(34);



        }
    }
}
