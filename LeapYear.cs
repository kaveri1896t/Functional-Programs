//--------------------------------------------------------------------------------------------------------------------
// <copyright file="LeapYear.cs" company="BridgeLabz">
// copyright @2019 
// </copyright>
// <creater name="Kaveri Tekawade"/>
//------------------------------------------------------------------------------------------------------------------
namespace Functional_Programs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    /// <summary>
    /// Leap year
    /// </summary>
    public class LeapYear
    {
        public void LeapYear1()
        {
            try
            {
                Console.WriteLine("enter 4 digit year which u want");
                string year = Console.ReadLine();
                if(year.Length==4)
                {
                    int Year = Convert.ToInt32(year);
                    ////The Year divisible by 4 && not a centurial || Centurial but divisible by 400
                    if(Year%4==0 && Year%100!=0 || Year%400==0)
		            {
			            Console.WriteLine(year+" entered year is leap year");
		            }
		            else
		            {
                        Console.WriteLine(year + " entered year is not leap year");
		            }
		        }
                else
                {
                    Console.WriteLine(year + "is not valid year plz enter correct year");
                }
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
