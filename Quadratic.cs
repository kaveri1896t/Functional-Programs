using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programs
{
    public class Quadratic
    {
        double a, b, c;
        void input()
	{
            try
            {
		Console.WriteLine("Enter the value of a :");
		a=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the value of b :");
		b=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the value of c :");
		c=Convert.ToDouble(Console.ReadLine());
        }catch(Exception ex)
           {
               Console.WriteLine(ex.Message);
           }
	}

       public void RootsOfQuadraticEquation() 
       {
           try
           {
               input();
               double rootx1 = 0.0;
               double rootx2 = 0.0;
               Console.WriteLine("The entered expression is : " + a + "x*x+" + b + "x+" + c);
               double delta = b * b - 4 * a * c;

               if (delta > 0)
               {
                   rootx1 = (-b + Math.Sqrt(delta)) / (2 * a);
                   rootx2 = (-b - Math.Sqrt(delta)) / (2 * a);
               }
               Console.WriteLine("Two roots of x are : " + rootx1 + " & " + rootx2);

           }catch(Exception ex)
           {
               Console.WriteLine(ex.Message);
           }

	}

    }
}
