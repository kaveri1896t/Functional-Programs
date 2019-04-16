using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programs
{
   public class WindChill
    {

        double t = 0.0, v = 0.0;
      public void getdata()
	{
		Console.WriteLine("Enter the value of t : ");
		t=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the value of v: ");
        v = Convert.ToDouble(Console.ReadLine());
	}

        public void CalculateWindChill() {
		
		
		getdata();
		if(t<50 || v<120 || v>3)
		{
			double w=34.74+0.6215*t+(0.4275*t-35.75)*Math.Pow(v, 0.16);
			Console.WriteLine("WindChill = "+w);
		}
		
	}

    }
}
