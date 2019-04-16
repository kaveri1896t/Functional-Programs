//--------------------------------------------------------------------------------------------------------------------
// <copyright file="ReplaceString.cs" company="BridgeLabz">
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
    /// Replace string with username
    /// </summary>
    public class ReplaceString
    {
        /// <summary>
        /// Replaces the string1.
        /// </summary>
        public void ReplaceString1()
       {
            try
            {
                Console.WriteLine("enter the name which you want to replace : ");
                string name = Console.ReadLine();
                string msg = "Hello <<UserName>>, how are you ?";
                string rmsg = msg.Replace("<<UserName>>", name);
                Console.WriteLine(rmsg);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
       }
    }
}
