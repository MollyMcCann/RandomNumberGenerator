using System;

namespace RandomNumberGenerator
{
    class Program
    {
        //ultimate goal is to write a caller for bingo we are starting with a random number generation and 
        //will build from this point onward.
        static void Main(string[] args)
        {
            //declaring number
            int randomNumber;

            Random randm = new Random();
            //setting range of numbers we can choose from
            randomNumber = randm.Next(1,91);
            //printing our number
            Console.WriteLine(" Your random number is " + randomNumber);
            Console.ReadLine();

        }
    }
}
