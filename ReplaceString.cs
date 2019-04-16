using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programs
{
   public class ReplaceString
    {
        public void ReplaceString1()
       {
            try
            {
                Console.WriteLine("enter the name which u want to be replaced");
                string name = Console.ReadLine();
                string msg = "Hello <<UserName>>, how are you ?";
                string Rmsg = msg.Replace("<<UserName>>",name);
                Console.WriteLine(Rmsg);
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
       }
    }
}
