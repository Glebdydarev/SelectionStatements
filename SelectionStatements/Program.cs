using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Wellcome to the number guessing game!");
            Console.WriteLine("We going to guess if the number!");
            Console.WriteLine("What is the upper Limit for the range of the number?");



            var userResponse = Console.ReadLine();


            var upperLimit = int.Parse(userResponse);

            var random = new Random();

            var number = random.Next(1, upperLimit);





            Console.WriteLine("Input your guess:");

            var guess = int.Parse(Console.ReadLine());



            if (guess > number)
            {
                Console.WriteLine("Your guess is too hight! Sorry");
            }



            else if (guess < number)

            {
                Console.WriteLine("Your guess is too Low! Sorry");

            }


            else

            {
                Console.WriteLine("Corect!");
            }



            //Switch Statements


            Console.WriteLine("What is your favorite shool subject");

            string subject = Console.ReadLine();

            switch (subject)
            {

                case "Math":
                    Console.WriteLine("Math is important to know in your life");
                    break;

                case "Russian language":
                    Console.WriteLine("Russian is good to know as the second language");
                    break;


                case "Sport":
                    Console.WriteLine("Sport is keep you healthy");
                  break;



                case "English":
                    Console.WriteLine("English is the World language");
                    break;

                default:
                    Console.WriteLine("If you don't like any subject that is okay");
                    break;
            }
            
        }
     }
}
