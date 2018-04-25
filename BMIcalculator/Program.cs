using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIcalculator
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("**** BMI CALCULATOR ****");

            //Takes the user input for weight
            Console.Write("Enter your weight(kg): ");
            double kg;
            kg = Convert.ToDouble(Console.ReadLine());


            //Takes the user input for height
            Console.Write("Enter your height(m): ");
            double height;
            height = Convert.ToDouble(Console.ReadLine());
            
           //Showing BMI 
            double BMI = kg / (height * height);
            Console.WriteLine("Your BMI is: " + Math.Round(BMI,2));

            //loop in order to find BMI
            if (BMI <= 18.5)
            {
                Console.WriteLine("Health Status: Underweight");
            }
            else if (BMI > 18.5 && BMI < 24.5)
            {
                Console.WriteLine("Health Status: Normal");
            }
            else if (BMI >= 24.5 && BMI <= 29.9)
            {
                Console.WriteLine("Health Status: Overweight");
            }
            else 
            {
                Console.WriteLine("Health Status: Obese");
            }

            Console.ReadKey();

        }
           

    }

       
}
