/**       
 *--------------------------------------------------------------------
 * 	   File name: Lab6.cs
 * 	Project name: Lab 6
 *--------------------------------------------------------------------
 * Author’s name and email:	Ethan Light lightec@etsu.edu				
 *          Course-Section: CSCI 1250-002
 *           Creation Date:	3/29/22		
 * -------------------------------------------------------------------
 */

using System;

class Lab6 
{
    //main method
    static void Main(String[] args)
    {
        ShowCharacter();

        CalculateRetail();

        for (double temp = 80; temp <= 100; temp++)
        {
        Console.Write(temp + "°F ");
        Celsius(temp);
        }

        IsPrime(3);
        IsPrime(6);

        //show character method - takes the user input of a string and an integer and displays a letter of the string based on the position of the letter in regards to the integer
        static void ShowCharacter()
        {
            //variables
            String userInput;
            int letterPosition;
            char letter;

            //get a word from the user
            Console.WriteLine("Provide a word. ");
            userInput = Console.ReadLine();

            //get a number from the user
            Console.WriteLine("Provide an integer. ");
            letterPosition = int.Parse(Console.ReadLine());

            //find the letter position and display back to the user
            letter = userInput[letterPosition - 1];
            Console.WriteLine("Your letter is " + letter);
        }

        //retail price method - calculates the retail price of an item based on the user input 
        static void CalculateRetail()
        {
            //variables
            double wholesaleCost;
            double markupPercent;
            double total;

            //get the wholesale cost
            Console.WriteLine("Provide the wholesale cost. ");
            wholesaleCost = double.Parse(Console.ReadLine());

            //get the markup percentage
            Console.WriteLine("Provide the markup percentage. ");
            markupPercent = double.Parse(Console.ReadLine());

            //calculate retail
            total = wholesaleCost * markupPercent / 100 + wholesaleCost;
            Console.WriteLine("Your total is " + total);
        }

        //temp table method - accepts a fahrenheit temperature and converts to celcius
        static void Celsius(double fahrenheit)
        {
            //convert fahrenheit to celcius
            double celsius = Math.Round((fahrenheit - 32) * 5 / 9, 2);
            Console.WriteLine(celsius + "°C");
        }

        //prime numbers method - takes an integer as an argument and returns true or false based on if the number is prime or not
        static void IsPrime(int num)
        {   
            bool primeCheck = true;

            //if num is 0 or 1 then they are not prime numbers
            if (num == 0 || num == 1)
            {
                primeCheck = false;
            }
            else
            {
                for (int i = 2; i < num/2; i++)
                {
                    if (num % i == 0)
                    {
                        primeCheck = false;
                    }
                }
            }
            Console.WriteLine(primeCheck);
        }
    }
}