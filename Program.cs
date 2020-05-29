using System;

namespace ComputationalThinkingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("COMPUTATIONAL THINKING EXERCISES\n");
                Console.WriteLine("Which exercise would you like to run?");
                Console.WriteLine("1. Are These Integers Equal?");
                Console.WriteLine("2. Even or Odd?");
                Console.WriteLine("3. Vowel or Consonant?");
                Console.WriteLine("4. Find the Largest Number");
                Console.WriteLine("5. Divisible by 3");
                Console.WriteLine("6. Restaurant Bill");
                Console.WriteLine("7. Age Category");
                Console.WriteLine("8. Words to Digits");
                Console.WriteLine("9. Which Name is Longer?");
                Console.WriteLine("10. Are these Numbers the Same?");
                Console.WriteLine("11. Name and Place of Birth");
                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch(userChoice)
                {
                    case "1":
                        AreTheseIntegersEqual();
                        break;
                    case "2":
                        EvenOrOdd();
                        break;
                    case "3":
                        VowelOrConsonant();
                        break;
                    case "4":
                        FindLargestNumber();
                        break;
                    case "5":
                        DivisibleBy3();
                        break;
                    case "6":
                        RestaurantBill();
                        break;
                    case "7":
                        AgeCategory();
                        break;
                    case "8":
                        WordsToDigits();
                        break;
                    case "9":
                        WhichNameIsLonger();
                        break;
                    case "10":
                        AreNamesSame();
                        break;
                    case "11":
                        NameAndBirthplace();
                        break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
            }
        }

        static void AreTheseIntegersEqual()
        {
            // Write a console application to ask the user for two integers. 
            // Check and see if the two integers are equal to each other.
            // If they are, inform the the user that the numbers are equal,
            // else inform the user that the numbers are not equal

            Console.Clear();
            Console.WriteLine("ARE THESE INTEGERS EQUAL?\n");

            // Enter your solution here
            // Ask user for 1st integer
            Console.WriteLine("Enter an integer: ");

            // Save integer in variable
            string firstInteger = Console.ReadLine();
            //Console.WriteLine(firstInteger);

            // Ask user for 2nd integer
            Console.WriteLine("Enter another integer: ");

            // Save integer in variable
            string secondInteger = Console.ReadLine();
           //Console.WriteLine(secondInteger);

            // Compare integers
            bool isEqual = firstInteger == secondInteger;
            //Console.WriteLine(isEqual)

            // If equal, print "Equal"
            if (firstInteger == secondInteger)
            {
                Console.WriteLine("Equal");
            }

            // If not equal, print "Not Equal"
            else
            {
                Console.WriteLine("Not Equal");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void EvenOrOdd()
        {
            // Write a console application that asks the user for a number.
            // Tell the user if that number is even or odd.

            Console.Clear();
            Console.WriteLine("EVEN OR ODD?\n");

            // Enter your solution here

            Console.WriteLine("Enter an integer: ");
            string integer = Console.ReadLine();
            int number = Convert.ToInt32(integer);
            bool isEven = (number % 2) == 0;
            if (isEven)
            {
                Console.WriteLine("\nEVEN");
            }
            else
            {
                Console.WriteLine("\nODD");
            }

            
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void VowelOrConsonant()
        {
            // Write a console application to check whether a letter is a vowel or consonant.
            // Hint: You can do this problem using a switch or an if condition.

            Console.Clear();
            Console.WriteLine("VOWEL OR CONSONANT?\n");

            // Enter your solution here
            Console.WriteLine("Enter a letter: ");
            string letter = Console.ReadLine();
            letter = letter.ToLower();
            switch (letter)
            {
                case "a":
                    Console.WriteLine("Vowel");
                    break;
                case "e":
                    Console.WriteLine("Vowel");
                    break;
                case "i":
                    Console.WriteLine("Vowel");
                    break;  
                case "o":
                    Console.WriteLine("Vowel");
                    break;
                case "u":
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonant");
                    break;
            }
            
            //bool isVowel = (letter == vowel)
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void FindLargestNumber()
        {
            // Write a console application that prompts the user to input two integer values.
            // Find and print the greatest value of the two integers.

            Console.Clear();
            Console.WriteLine("FIND THE LARGEST NUMBER\n");

            // Enter your solution here
            Console.WriteLine("Enter an integer: ");
            int integer1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another integer: ");
            int integer2 = Convert.ToInt32(Console.ReadLine());
            if (integer1 > integer2)
            {
                Console.WriteLine(integer1);
            }
            else if (integer1 == integer2)
            {
                Console.WriteLine("N/A");
            }
            else
            {
                Console.WriteLine(integer2);
            }

            Console.Write("\nPress enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void DivisibleBy3()
        {
            // Ask the user for a number and then tell them if it is divisible by 3

            Console.Clear();
            Console.WriteLine("DIVISIBLE BY 3\n");

            // Enter your solution here
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int numberModulus = number % 3;
            if (numberModulus == 0)
            {
                Console.WriteLine("Number is divisible by 3");
            }
            else
            {
                Console.WriteLine("Number is not divisible by 3");
            }

            Console.Write("\nPress enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void RestaurantBill()
        {      
            Console.Clear();
            Console.WriteLine("RESTAURANT BILL\n");

            // At a restaurant, Mike and his three friends decided to divide the bill evenly.
            // If each person paid $13 then what was the total bill?

            // Returning to the above problem, replace hard-coded values of 4(number of diners)
            // and 13(cost per diner) with values provided by the user.
            Console.WriteLine("How many diners?");
            double numberOfDiners = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How much was your bill?");
            double totalBill = Convert.ToDouble(Console.ReadLine());          

            // How nice!The restaurant is having Customer Appreciation Week.
            // If a table’s total bill is $50 or more, then they’ll receive a 10 % discount!
            // Otherwise, they’ll receive a 5 % discount.           
            if (totalBill > 50.00)
            {
                totalBill = totalBill - (totalBill * 0.1);
                Console.WriteLine("Happy Customer Appreciation Week! Enjoy 10% off!");
            }
            else
            {
                totalBill = totalBill - (totalBill * 0.05);
                Console.WriteLine("Happy Customer Appreciation Week! Enjoy 5% off!");
            }
            double individualBill = Math.Round(totalBill / numberOfDiners, 2);
            //not sure how to round to hundredths
           
            Console.Write("\nYou owe $" + individualBill);

            Console.Write("\nPress enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void AgeCategory()
        {
            // You're responsible for providing a demographic report for your local school district based on age.
            // To do this, you're going to determine which 'category' each person fits into based on their age.
            // The person's age will determine which category they should be in:

            // If they're from 0 to 2 the child should be with parents print : 'Still in Mama's Arms'
            // If they're 3 or 4 and should be in preschool print : 'Preschool Maniac'
            // If they're from 5 to 11 and should be in elementary school print : 'Elementary School'
            // From 12 to 14: 'Middle School'
            // From 15 to 18: 'High School'
            // From 19 to 22: 'College'
            // From 23 to 65: 'Working for the Man'
            // From 66 to 100: 'The Golden Years'
            // If the age of the person is less than 0 or more than 100 - it might be an alien
                    // print: "This program is for humans".

            Console.Clear();
            Console.WriteLine("AGE CATEGORY\n");
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 0 || age > 100)
            {
                Console.WriteLine("This program is for humans");
            }
            else if (0 <= age || age < 3)
            {
                Console.WriteLine("Still in Mama's Arms");
            }
            else if (3 <= age || age == 4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if (4 < age || age < 12)
            {
                Console.WriteLine("Elementary School");
            }
            else if (12 <= age || age < 15)
            {
                Console.WriteLine("Middle School");
            }
            else if (15 <= age || age < 19)
            {
                Console.WriteLine("High School");
            }
            else if (19 <= age || age < 23)
            {
                Console.WriteLine("College");
            }
            else if (23 <= age || age < 66)
            {
                Console.WriteLine("Working for the Man");
            }
            else
            {
                Console.WriteLine("The Golden Years");
            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void WordsToDigits()
        {
            // Having a string representation of a number, you need to print the digit form of the number.
            // Ask the user to enter a string representation of a number from zero to ten.
            // Using switch case, print the digit (0-10) representation of the number.

            Console.Clear();
            Console.WriteLine("WORDS TO DIGITS\n");
            
            Console.WriteLine("Pick a number from 0-10 and spell it out");
            string digit = (Console.ReadLine());
            digit = digit.ToLower();
            switch (digit)
            {
                case "zero":
                    Console.WriteLine("0");
                    break;
                case "one":
                    Console.WriteLine("1");
                    break;
                case "two":
                    Console.WriteLine("2");
                    break;
                case "three":
                    Console.WriteLine("3");
                    break;
                case "four":
                    Console.WriteLine("4");
                    break;
                case "five":
                    Console.WriteLine("5");
                    break;
                case "six":
                    Console.WriteLine("6");
                    break;
                case "seven":
                    Console.WriteLine("7");
                    break;
                case "eight":
                    Console.WriteLine("8");
                    break;
                case "nine":
                    Console.WriteLine("9");
                    break;
                case "ten":
                    Console.WriteLine("10");
                    break;
                default:
                    Console.WriteLine("Spell out a number from 0-10");
                    break;                

            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void WhichNameIsLonger()
        {
            // Ask the user for their first and last name.
            // Print the user's full name.
            // If the first name is longer than the last name, print "First is longer."
            // If the first name and last name are the same length, print "Same-sies!"
            // Otherwise, print "Last must be longer!"
            Console.Clear();
            Console.WriteLine("WHICH NAME IS LONGER?\n");

            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Full Name: {firstName} {lastName}");
            int lengthOfFirst = firstName.Length;
            int lengthOfLast = lastName.Length;
            if (lengthOfFirst > lengthOfLast)
            {
                Console.WriteLine("First is longer");
            }
            else if (lengthOfFirst == lengthOfLast)
            {
                Console.WriteLine("Same-sies");
            }
            else
            {
                Console.WriteLine("Last is longer");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void AreNamesSame()
        {
            // Ask the user for 2 names.

            // If the two names are the same, print "The names are the same."
            // If they're not the same, print "The names are different."

            Console.Clear();
            Console.WriteLine("ARE THESE NAMES THE SAME?\n");

            Console.WriteLine("Enter a name");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter another name");
            string name2 = Console.ReadLine();
            if (name1 == name2)
            {
                Console.WriteLine("The names are the same");
            }
            else
            {
                Console.WriteLine("The names are different");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void NameAndBirthplace()
        {
            // Ask the user for their first name and where they were born.
            // Print a sentence to the console that repeats this information.

            Console.Clear();
            Console.WriteLine("NAME AND PLACE OF BIRTH\n");

            Console.WriteLine("What is your first name?");
            string name = Console.ReadLine();
            Console.WriteLine("Where were you born?");
            string birthplace = Console.ReadLine();
            Console.WriteLine($"\nYour name is {name} and you were born in {birthplace}.");


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

    }
}
