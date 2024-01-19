using static System.Console;
namespace ShapeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Name: Jaiden Leonard
             * Class: CPSC 23000-001
             * Assignment: Shape Calculator
             * Date: 1/19/2023
            */

            //print header
            WriteLine("*********************************************");
            WriteLine("           Shape Calculator V1.0");
            WriteLine("*********************************************");

            //ask user for the width of the cube
            WriteLine("\nFirst, let's deal with a cube.");
            Write("What is the width? ");
            double cubeWidth;
            string userEntry;
            userEntry = ReadLine();
            try
            {
                cubeWidth = double.Parse(userEntry);
            } 
            catch (FormatException)
            {
                WriteLine("\nThe width entered is not valid.\nSetting the width to 1.\n");
                cubeWidth = 1;
            }

            //ask user for the length of the cube
            Write("What is the length? ");
            double cubeLength;
            userEntry = ReadLine();
            try
            {
                cubeLength = double.Parse(userEntry);
            }
            catch (FormatException)
            {
                WriteLine("\nThe length entered is not valid.\nSetting the length to 1.\n");
                cubeLength = 1;
            }

            //ask user for the height of the cube
            Write("What is the height? ");
            double cubeHeight;
            userEntry = ReadLine();
            try
            {
                cubeHeight = double.Parse(userEntry);
            }
            catch (FormatException)
            {
                WriteLine("\nThe height entered is not valid.\nSetting the height to 1.\n");
                cubeHeight = 1;
            }

            //calculate and print the cube's volume
            double cubeVolume = cubeWidth * cubeLength * cubeHeight;
            WriteLine("The cube's volume is {0:F3}", cubeVolume);

            //ask user for the radius of the sphere
            WriteLine("\nNow let's deal with a sphere.");
            Write("What is the radius? ");
            double sphereRadius;
            userEntry = ReadLine();
            try
            {
                sphereRadius = double.Parse(userEntry);
            }
            catch (FormatException)
            {
                WriteLine("\nThe radius entered is not valid.\nSetting the radius to 1.\n");
                sphereRadius = 1;
            }
            
            //calculate and print the sphere's volume
            double sphereVolume = 4.0 / 3 * Math.PI * Math.Pow(sphereRadius,3);
            WriteLine("The sphere's volume is {0:F3}", sphereVolume);

            //calculate and print the cube and sphere's total volume combined
            double totalVolume = cubeVolume + sphereVolume;
            WriteLine("\nThe total volume of the cube and sphere is {0:F3}", totalVolume);

            //print goodbye footer
            WriteLine("\nThank you for using this program.");
        }
    }
}
