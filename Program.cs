using System.Numerics;

namespace Random_numbers_lesson
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Random generator = new Random();
            int randNum; // We will store our random number in this variable
            randNum = generator.Next();



            Console.WriteLine("My random number is " + randNum);
            Console.WriteLine("Here are some numbers from 2 to 4!");
            Console.Write(generator.Next(2, 5) + " ");
            Console.Write(generator.Next(2, 5) + " ");
            Console.Write(generator.Next(2, 5) + " ");
            Console.Write(generator.Next(2, 5) + " ");
            Console.Write(generator.Next(2, 5) + " ");
            Console.WriteLine(generator.Next(2, 5) + " ");
            Console.WriteLine();
            Console.WriteLine("Here are some numbers from 0 to 99!");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.WriteLine(generator.Next(100) + " ");
            Console.WriteLine();
            int num1 = generator.Next(10);
            int num2 = generator.Next(10);
            if (num1 == num2)
            {
                Console.WriteLine("The random numbers were the same! Weird.");
            }
            if (num1 != num2)
            {
                Console.WriteLine("The random numbers were different! Not weird. ");
            }
            Console.ReadLine(); // Keeps the program from quitting



            //TAsk one

            Console.Clear();
            int minValue;
            int maxValue;
            Random Generator = new Random();
            int random;
            



            Console.Write("give me a minimum value: ");
            Console.Write("");
            int.TryParse(Console.ReadLine(), out minValue);
            Console.Write("give me max value ");
            Console.Write("");
            int.TryParse(Console.ReadLine(), out maxValue);
            randNum = generator.Next(minValue, maxValue);
            Console.WriteLine("Thank you! My random number is " + randNum);




        }




        
    }
}
