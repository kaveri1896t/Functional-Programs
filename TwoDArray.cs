//--------------------------------------------------------------------------------------------------------------------
// <copyright file="TwoDArray.cs" company="BridgeLabz">
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
    /// 2D Array
    /// </summary>
    public class TwoDArray
    {
        /// <summary>
        /// Arrays this instance.
        /// </summary>
        public void TwoDArrays()
        {
            try
            {
                int m = 0, n = 0;
                Console.WriteLine("Enter the no of rows: ");
                m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the no of cols : ");
                n = Convert.ToInt32(Console.ReadLine());
                int[,] intArray = new int[m, n];
                double[,] doubleArray = new double[m, n];
                bool[,] booleanArray = new bool[m, n];
                int ch = 0;
                do
                {
                    Console.WriteLine("\n1.Integer Array\n2.Double Array\n3.Boolean Array\n\nEnter your choice : ");
                    ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            Console.WriteLine("Enter the Integer values : ");
                            for (int i = 0; i < m; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    intArray[i, j] = Convert.ToInt32(Console.ReadLine());
                                }
                            }

                            for (int i = 0; i < m; i++)
                            {
                                Console.WriteLine();
                                for (int j = 0; j < n; j++)
                                {
                                    Console.Write(intArray[i, j] + " ");
                                }
                            }

                            break;

                        case 2:
                            Console.WriteLine("Enter the Double values : ");
                            for (int i = 0; i < m; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    doubleArray[i, j] = Convert.ToDouble(Console.ReadLine());
                                }
                            }

                            for (int i = 0; i < m; i++)
                            {
                                Console.WriteLine();
                                for (int j = 0; j < n; j++)
                                {
                                    Console.Write(doubleArray[i, j] + " ");
                                }
                            }

                            break;

                        case 3:
                            Console.WriteLine("Enter the Boolean values : ");
                            for (int i = 0; i < m; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    booleanArray[i, j] = Convert.ToBoolean(Console.ReadLine());
                                }
                            }

                            for (int i = 0; i < m; i++)
                            {
                                Console.WriteLine();
                                for (int j = 0; j < n; j++)
                                {
                                    Console.Write(booleanArray[i, j] + " ");
                                }
                            }

                            break;

                        default:
                            break;
                    }
                }
                while (ch <= 3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
