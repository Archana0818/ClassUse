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
    class Dog
    {
        string name;
        string breed;
        string colour;
        string gender;

        // default constructor
        public Dog() 
        {
            name = "";
            breed = "";
            colour = "";
            gender = "";
        }

        //Constructor with parameters
        public Dog
     (string dogName, string dogBreed, string dogColour, string dogGender)
        {
            name = "dogName";
            breed = "dogBreed";
            colour = "dogColour";
            gender = "dogGender";
        }
        
        // method to disply dog information
        public void DisplayDogInformation(List<Dog> dogList)
        {

            if (dogList.Count == 0)
                Console.WriteLine("Sorry, we don't have any"+
                    " dog information yet.");
            for (int i = 0; i < dogList.Count; i++)
            {
                Console.WriteLine("************************");
                Console.WriteLine("Name : " + dogList[i].name);
                Console.WriteLine("Breed : " + dogList[i].breed);
                Console.WriteLine("Colour : " + dogList[i].colour);
                Console.WriteLine("Gender : " + dogList[i].gender);
                Console.WriteLine("************************");
            }
        }
        // method to add dog
        public Dog AddDogInformation(List<Dog> dogList)
        {
            Dog dog;
            dog= new Dog();

            bool genderValidation;
            bool nameCheck;
            bool containsInt;

            nameCheck = true;
            genderValidation = true;
            containsInt = true;
           
             NAME:
             Console.WriteLine("Please enter the name : ");
             dog.name = Console.ReadLine().ToUpper();
             containsInt = dog.name.Any(char.IsDigit);
                
             if (containsInt)
                {
                    Console.WriteLine("Name can not have"+
                         " any numbers in that");
                    Console.WriteLine();
                    goto NAME;
                }
               
            
            for (int i = 0; i < dogList.Count; i++)
            {
                while (nameCheck)
                {
                    if (dogList[i].name.Contains(dog.name))
                    {
                        Console.WriteLine("We already have a dog"+
                            " with that name");
                        Console.WriteLine("Please enter the name : ");
                        dog.name = Console.ReadLine().ToUpper();
                    }
                    else
                    {
                        nameCheck = false;
                    }
                }
            }
           BREED:
                Console.WriteLine("Please enter the breed : ");
                dog.breed = Console.ReadLine().ToUpper();
                containsInt = dog.breed.Any(char.IsDigit);
           
                if (containsInt)
                {

                    Console.WriteLine("Breed can not have any"+
                        " numbers in that.");
                    Console.WriteLine();
                    goto BREED;
                }
            
            COLOUR:
                Console.WriteLine("Please enter the colour : ");
                dog.colour = Console.ReadLine().ToUpper();
                containsInt = dog.colour.Any(char.IsDigit);
                if (containsInt)
                {
                    Console.WriteLine("Colour can not have any"+
                        " numbers in that.");
                    Console.WriteLine();
                    goto COLOUR;
                }
            
            Console.WriteLine("Please enter the gender : ");
            dog.gender = Console.ReadLine().ToUpper();
            while(genderValidation)
           { 
                if (dog.gender != "MALE" && dog.gender != "FEMALE")
                {
                    Console.WriteLine("Invalid entry!"+
                        " enter male or female");
                    Console.WriteLine("Please enter the gender : ");
                    dog.gender = Console.ReadLine().ToUpper();
                }
                else
                {
                    dogList.Add(dog);
                    genderValidation = false;
                }
            }
            
            return dog;

        }

        //method to edit dog information 

        public Dog EditDogInformation(List<Dog> dogList)
        {
            Dog dog;
            dog = new Dog();
            bool genderValidation;
            bool containsInt;

            genderValidation = true;
            containsInt = true;
           
            Console.WriteLine("Enter the name of the dog who's" +
                " information you want to edit");
            dog.name = Console.ReadLine().ToUpper();
            for (int i = 0; i < dogList.Count; i++)
            {
                if (dogList[i].name.Contains(dog.name))
                {
                    int userInput = 0;
                    Console.WriteLine("We found the dog with that name");
                    Console.WriteLine("Name: " + dogList[i].name);
                    Console.WriteLine("Breed: " + dogList[i].breed);
                    Console.WriteLine("Colour: " + dogList[i].colour);
                    Console.WriteLine("Gender: " + dogList[i].gender);
                    while (userInput != 5)
                    {
                        Console.WriteLine("Select from the" +
                            " following option: ");
                        Console.WriteLine("1 to edit name");
                        Console.WriteLine("2 to edit breed");
                        Console.WriteLine("3 to edit colour");
                        Console.WriteLine("4 to edit gender");
                        Console.WriteLine("5 to save and exit this menu");
                        userInput = int.Parse(Console.ReadLine());
                        if (userInput == 1)
                        {
                         NAME:
                            Console.WriteLine("Please enter the name : ");
                            dog.name = Console.ReadLine().ToUpper();
                            
                            containsInt = dog.name.Any(char.IsDigit);

                            if (containsInt)
                            {
                                Console.WriteLine("Name can not have" +
                                     " any numbers in that");
                                Console.WriteLine();
                                goto NAME;
                            }
                            dogList[i].name = dog.name;
                        }
                        if (userInput == 2)
                        {
                           BREED:
                            Console.WriteLine("Please enter the breed: ");
                            dog.breed = Console.ReadLine().ToUpper();
                            containsInt = dog.breed.Any(char.IsDigit);

                            if (containsInt)
                            {
                                Console.WriteLine("Name can not have" +
                                     " any numbers in that");
                                Console.WriteLine();
                                goto BREED;
                            }
                            dogList[i].breed = dog.breed;
                        }
                        if (userInput == 3)
                        {
                            COLOUR:
                            Console.WriteLine("Please enter" +
                                " the colour: ");
                            dog.colour = Console.ReadLine().ToUpper();
                            containsInt = dog.colour.Any(char.IsDigit);

                            if (containsInt)
                            {
                                Console.WriteLine("Name can not have" +
                                     " any numbers in that");
                                Console.WriteLine();
                                goto COLOUR
                                    ;
                            }
                            dogList[i].colour = dog.colour;
                        }
                        if (userInput == 4)
                        {
                            Console.WriteLine("Please enter" +
                                " the gender : ");
                            Console.WriteLine("male or female");
                            dog.gender = Console.ReadLine().ToUpper();
                            while (genderValidation)
                            {
                             
                        if(dog.gender != "MALE" && dog.gender != "FEMALE")
                                {
                                    Console.WriteLine("Invalid entry!" +
                                        " enter male or female");
                                    Console.WriteLine("Please enter" +
                                        " the gender : ");
                               dog.gender = Console.ReadLine().ToUpper();
                                }
                                else
                                {
                                    dogList[i].gender = dog.gender;
                                    genderValidation = false;
                                }

                            }
                        }

                    }

                }
            
             else
             {
                Console.WriteLine("We do not have any" +
                " information of the dog with" +
                " the name you entered");
            }
        }


            return dog;
        }

       
        }
        


    }

