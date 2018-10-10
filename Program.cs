using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            double Snuglength, Snugwidth, Penthousewidth, Penthouselength, Snugarea, Snugperimeter, Penthousearea, Penthouseperimeter;

            do
            {
                Console.WriteLine("Enter length of the Snug room ");
                Snuglength = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter width of the Snug room ");
                Snugwidth = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter length of the Penhouse room ");
                Penthouselength = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter width of the Penthouse room ");
                Penthousewidth = Convert.ToDouble(Console.ReadLine());

                Snugperimeter = 2 * Snuglength + 2 * Snugwidth;

                Console.WriteLine("The perimeter of the snug room is {0}", Snugperimeter);

                Snugarea = Snuglength * Snugwidth;

                Console.WriteLine("The area of the snug room is {0}", Snugarea);

                Penthouseperimeter = 2 * Penthouselength + 2 * Penthousewidth;

                Console.WriteLine("The perimeter of the Penthouse room is {0}", Penthouseperimeter);

                Penthousearea = Penthouselength * Penthousewidth;

                Console.WriteLine("The area of the Penthouse room is {0}", Penthousearea);

                Console.WriteLine("\n Would you like to continue y/n?");
            }


            while (Console.ReadLine() == "y");

                {
                


                }





        }
    }
}
