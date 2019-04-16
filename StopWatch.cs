using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Functional_Programs
{
   public class StopWatch
    {
	    public void start1() {
            Stopwatch sw = new Stopwatch();
            sw.Start();
	    }

	    
	    public void stop1() {
            Stopwatch sw = new Stopwatch();
            sw.Stop();
	    }

	    
	    public void elapsedTime()  {
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("ElapsedTime is : " + sw.ElapsedMilliseconds);
	    }
	        
            public void CalculateElapsedTime()
	        {
	        	
	        	int ch;
	        	
	        	do
	        	{
	        	Console.WriteLine("1.Start\n2.Stop\nEnter your choice : ");
	        	ch=Convert.ToInt32(Console.ReadLine());

	            switch(ch)
	        	{
	        	case  1:
	        		start1();
	        		break;
	        	case 2:
	        		stop1();
	        		break;
	        	default:
                    elapsedTime();
	        		break;
	            }
	        	
	        	}while(ch>=1 || ch<=2);
	        	
	        	
	        }

    }
}
