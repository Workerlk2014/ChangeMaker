using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call the ChangeMaker function parameters, the Console.WriteLines just give a nice space
            ChangeMaker(3.18);
            Console.WriteLine();
            ChangeMaker(0.99);
            Console.WriteLine();
            ChangeMaker(12.93);
            Console.WriteLine();
            Console.ReadKey();
        }
        //Creates a function called ChangeMaker with a parameter called amount as a double
        static void ChangeMaker(double amount)
        {
            //Here Variables are declared for each while loop
            var FirstValue = 0;
            var SecondValue = 0;
            var ThirdValue = 0;
            var FourthValue = 0; 
            //The console prints out the input "amount"
            Console.WriteLine("Amount: " + amount);
            //While amount is greater than a quarter the loop removes a quarters worth from amount
            while(amount > 0.25)
            {
                FirstValue++;
                amount -= 0.25;
            }
            //While amount is greater than a dime the loop removes a dimes worth from amount
            while(amount > 0.10)
            {
                 SecondValue++;
                 amount -= 0.10;
            }
            //While amount is greater than a nickel the loop removes a nickels worth from amount
            while(amount > 0.05)
            {
                ThirdValue++;
                amount -= 0.05;
            }
            //While amount is greater than a penny the loop removes a pennies worth from amount
            while(amount >= 0.00)
            {
                FourthValue++;
                amount -= 0.01;
            }
            
            //Prints the amount of of each variable value
            Console.WriteLine("Quarters: " + FirstValue);
            Console.WriteLine("Dimes: " + SecondValue);
            Console.WriteLine("Nickles: " + ThirdValue);
            Console.WriteLine("Pennies: " + FourthValue);
 
        }
    }
}
