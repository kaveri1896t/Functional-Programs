//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Coupon.cs" company="BridgeLabz">
// copyright @2019 
// </copyright>
//<creater name="Kaveri Tekawade"/>
//--------------------------------------------------------------------------------------------------------------------
namespace Functional_Programs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    /// <summary>
    /// Coupon
    /// </summary>
    public class Coupon
    {
        /// <summary>
        /// Distincts the coupon.
        /// </summary>
        public void DistinctCoupon() {
           try{


               Random random = new Random();
            Console.WriteLine("enter numbers");
            
		    int n = Convert.ToInt32(Console.ReadLine());       // number of card types
          
	        bool[] isCollected = new bool[n];  // isCollected[i] = true if card i has been collected
           
	        int count = 0;                           // total number of cards collected
	        int distinct = 0;                        // number of distinct cards
	  
	        // repeatedly choose a random card and check whether it's a new one
	        while (distinct < n) {
               
	            int value =Convert.ToInt32( random.Next(n) );   // random card between 0 and n-1
               
	            count++;                                 // we collected one more card
	            if (!isCollected[value]) {
                    
	                distinct++;
	                Console.WriteLine("distinct values are:"+distinct);
	                isCollected[value] = true;
	            }
	            
	        }

	        // print the total number of cards collected
	        Console.WriteLine("Total Random nos needed to make all Distinct");
	        Console.WriteLine(count);


	}catch(Exception ex)
           {
            Console.WriteLine(ex.Message);

    }
           }      
    }
    }
