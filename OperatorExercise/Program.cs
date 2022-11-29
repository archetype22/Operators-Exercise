using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
           #region
           Console.WriteLine("For X = '45' and Y = 15'.");
           Console.WriteLine("Addition");
           int x = 45;
           int y = 15;

           x += y;
           Console.WriteLine(x);
           Console.WriteLine();
           Console.WriteLine("Subtraction");

           x -= y;
           Console.WriteLine(x);
           Console.WriteLine();
           Console.WriteLine("Multiplication");

           x *= y;
           Console.WriteLine(x);
           Console.WriteLine();
           Console.WriteLine("Division");
           int a = 17; int b = 4; int quotient = (a / b); int remainder = (a % b);
           if (a == 17 && b == 4)
           {
               Console.WriteLine($"17/4 is {quotient} with a remainder of {remainder}.");
           }

           #endregion
           //Exercise 2

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            double AreaOfCircle = Math.PI * Math.Pow(radius, 2);
            double area = AreaOfCircle * radius;
            Console.WriteLine($"The area of a circle with radius {radius} is {area}.");

        }   





    }
}
