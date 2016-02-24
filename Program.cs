using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TristanFreitasAssignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            InitalMenu();
        }
        public static void InitalMenu()
        {
            int firstTriValue = 0;
            int secondTriValue = 0;
            int thirdTriValue = 0;

            string triangleTypeFinal = "";

            TriangleFinder trianglerFinder = new TriangleFinder();
            trianglerFinder.triangleType = "";

            Console.Clear();
            Console.WriteLine("1. Enter Triangle Dimensions" + "\n2. Exit");

            try
            {
                int intMenuOption = int.Parse(Console.ReadLine());

                if (intMenuOption == 1)
                {
                    trianglerFinder.testBool = true;
                    Console.Clear();
                    Console.WriteLine("Please chose 3 numbers to form a triangle.");
                    Console.WriteLine("First Value:");
                    firstTriValue = int.Parse(Console.ReadLine());
                    Console.WriteLine("Second Value:");
                    secondTriValue = int.Parse(Console.ReadLine());
                    Console.WriteLine("Third Value:");
                    thirdTriValue = int.Parse(Console.ReadLine());

                    if (firstTriValue == 0 || secondTriValue == 0 || thirdTriValue == 0)
                    {
                        Console.WriteLine("0's Dont make a triangle.");
                        Console.ReadLine();
                        InitalMenu();
                    }

                    else if (firstTriValue + secondTriValue >= thirdTriValue && firstTriValue + 
                        thirdTriValue >= secondTriValue && secondTriValue + 
                        thirdTriValue >= firstTriValue || firstTriValue < 0 
                        && secondTriValue < 0 && thirdTriValue < 0
                        || firstTriValue < 0 || secondTriValue < 0 || thirdTriValue < 0)
                    {
                        trianglerFinder.Analyze(firstTriValue, secondTriValue, thirdTriValue);
                        triangleTypeFinal = trianglerFinder.triangleType;
                        if (triangleTypeFinal == "")
                        {
                            Console.WriteLine("These numbers dont make a triangle. Try Again");
                            Console.ReadLine();
                            InitalMenu();

                        }
                        else
                        {
                            Console.WriteLine("The triangle is a " + triangleTypeFinal + " Triangle");
                            Console.ReadLine();
                            InitalMenu();
                        }
                    }

                    else
                    {
                        Console.WriteLine("These numbers dont make a triangle. Try Again");
                        Console.ReadLine();
                        trianglerFinder.triangleType = "";
                        InitalMenu();
                    }

                }
                else if (intMenuOption == 2)
                {
                    Environment.Exit(0);
                }
                else
                {
                    InitalMenu();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You have entered an invalid option.");
                Console.ReadLine();
                InitalMenu();

            }
        }
    }
}
