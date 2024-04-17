using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter your grade: ");
            int grade;
            if (!int.TryParse(Console.ReadLine(), out grade))
            {
                Console.WriteLine("Invalid input. Please enter a valid grade.");
                return;
            }

            if (grade >= 91 && grade <= 100) {

                Console.WriteLine("Outstanding");
            }

            else if (grade >= 86 && grade <= 90) {
                Console.WriteLine("Very Satisfactory");
            }

            else if (grade >= 80 && grade <= 85) {
                Console.WriteLine("Satisfactory");
            }

            else if (grade >= 75 && grade <= 79) {
                Console.WriteLine("Fairly Satisfactory");
            }

            else {
                Console.WriteLine("Did not meet expectations");
            }
        }
    }
}
