/* Program ID: Assignment 5
 Purpose: understand the use of class
 Revision History: Written Archana Lohani April 2017
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5ArchanaLohaniP1
{
    class Program
    {
       
        static List<Dog> dogList = new List<Dog>();
        static void Menu()
        {          
            Console.WriteLine("Welcome to the Menu");
            Console.WriteLine("Choose from the following option: ");
            Console.WriteLine("1: to display dog information");
            Console.WriteLine("2: to add new dog information");
            Console.WriteLine("3: to edit dog information");
            Console.WriteLine("4: exit");
        }
        static void Main(string[] args)
        { 
                int userInput;
                userInput = 0;
                Dog dog;
                bool validationCheck;
                validationCheck = true;

            while (validationCheck)
                {
                try {
                    dog = new Dog();

                    Menu();
                    userInput = int.Parse(Console.ReadLine());
                    if (userInput<=1 || userInput>=5)
                    {
                        Console.WriteLine("Invalid entry!,"+
                            " Choose from 1 to 4 only");
                        
                    }
                    if (userInput == 1)
                    {
                        Console.Clear();
                        dog.DisplayDogInformation(dogList);
                        Console.WriteLine();

                    }
                    if (userInput == 2)
                    {
                        Console.Clear();
                        
                       dog = dog.AddDogInformation(dogList);

                        dog.DisplayDogInformation(dogList);
                    }

                    if (userInput == 3)
                    {

                        dog = dog.EditDogInformation(dogList);

                        dog.DisplayDogInformation(dogList);
                    }

                 if (userInput == 4)
                        {
                        Console.Clear();
                            validationCheck = false;
                        }
                    }
                
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Entry!"+
                        " Enter only integer");
                }
            }  
        }
    }        
}



