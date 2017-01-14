using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1

            //introduction
            bool trueFalse = true;

            while (trueFalse == true)
            {
                Console.WriteLine("\nHello there!!! Thank you for using the new and improved Mister Cleatus,/nthe \"slightly less\" inaccurate fortune teller.\n\nTo quit at any time, type \"Quit\"\nTo restart at any time, type \"Restart\"\n\n");
                Console.WriteLine("\nTo begin, please enter your first name. Nicknames are okay.\n");  //asking for first name

                string firstName = Console.ReadLine();
                string firstNameCaps = firstName.ToUpper();

                if (firstNameCaps == "QUIT")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    break;
                }
                else if (firstNameCaps == "RESTART")
                {
                    continue;
                }

                Console.WriteLine("\nNow please enter your last name.\n"); //asking for last name

                string lastName = Console.ReadLine();
                string lastNameCaps = lastName.ToUpper();

                if (lastNameCaps == "QUIT")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    break;
                }
                else if (lastNameCaps == "RESTART")
                {
                    continue;
                }

                string fullName = firstName + " " + lastName;
                GreetUser(firstName, lastName);

                Console.WriteLine("\nPlease enter your age. If you're insecure about your age, I suppose lying\nis okay.\n"); //asking for age

                string ageQuit = Console.ReadLine();
                string ageQuitCaps = ageQuit.ToUpper();

                if (ageQuitCaps == "QUIT")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    break;
                }
                else if (ageQuitCaps == "RESTART")
                {
                    continue;
                }

                int age = int.Parse(ageQuit);

                int retireYears = NumberOfYearsBeforeRetired(age);

                Console.WriteLine("\nWell, if you're lying, I am sure " + age + " is close enough.");
                Console.WriteLine("\nPlease enter the month you were born as a two digit number. \ne.g. 10 for October.\n"); //asking for birth month

                string birthMonthQuit = Console.ReadLine();
                string birthMonthQuitCaps = birthMonthQuit.ToUpper();

                if (birthMonthQuitCaps == "QUIT")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    break;
                }
                else if (birthMonthQuitCaps == "RESTART")
                {
                    continue;
                }

                int birthMonth = int.Parse(birthMonthQuit);

                double moneyInBank = MoneyInBank(birthMonth);

                Console.WriteLine("\nWhat is your favorite color from the choices that are in ROYGBIV.\nIf you don't know the colors included in ROYGBIV, please type \"Help\"\n"); //asking for favorite color

                string favoriteColor = Console.ReadLine();
                string favoriteColorCaps = favoriteColor.ToUpper();

                if (favoriteColorCaps == "QUIT")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    break;
                }
                else if (favoriteColorCaps == "RESTART")
                {
                    continue;
                }

                do
                {
                    if (favoriteColorCaps == "HELP") //In case help is required
                    {
                        Console.WriteLine("\a\nRed\nOrange\nYellow\nGreen\nBlue\nIndigo\nViolet\n\nOut of those choices, which is your favorite?\nType \"Help\" to display the color choices again\n");
                        favoriteColor = Console.ReadLine();
                    }

                    favoriteColorCaps = favoriteColor.ToUpper();
                } while (favoriteColorCaps == "HELP");

                favoriteColorCaps = favoriteColor.ToUpper();

                if (favoriteColorCaps == "QUIT")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    break;
                }
                else if (favoriteColorCaps == "RESTART")
                {
                    continue;
                }

                string transport = ModeOfTransportation(favoriteColorCaps);

                Console.WriteLine("\nI guess " + favoriteColor + " is an decent choice.\n\nLastly, how many siblings do you have?\n"); //asking for number of siblings

                string numberOfSiblingsQuit = Console.ReadLine();
                string numberOfSiblingsQuitCaps = numberOfSiblingsQuit.ToUpper();

                if (numberOfSiblingsQuitCaps == "QUIT")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    break;
                }
                else if (numberOfSiblingsQuitCaps == "RESTART")
                {
                    continue;
                }

                int numberOfSiblings = int.Parse(numberOfSiblingsQuit);

                string vacationHome = vacationHomeLocation(numberOfSiblings);

                Console.WriteLine("\n\nAll right. All right. Settle down. That is all I need to make my prediction.\nPlease press any key to find out your future.");
                Console.ReadKey();
                Console.WriteLine("\nYou could at least get a drum roll going... *sigh* Just press any key again.\n");
                Console.ReadKey();

                //All user input is complete.

                Console.WriteLine("\n\n" + fullName + " will retire in " + retireYears + " years with $" + moneyInBank + " in the bank,\na vacation home in " + vacationHome + ", and " + transport + ".");

                trueFalse = false;
            }

            Console.ReadKey();
        }

        //Greeting the user method
        static string GreetUser(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Greetings, " + fullName + ". I will tell you your fortune!");
            return fullName;
        }

        //retirement years method
        static int NumberOfYearsBeforeRetired(int userAge)
        {
            int retireYears;
            if ((userAge % 2) == 1)
            {
                retireYears = 16;
            }
            else
            {
                retireYears = 45;
            }

            return retireYears;
        }

        //vacation Home Location method
        static string vacationHomeLocation(int numberOfSiblings)
        {
            string vacationHome;
            if (numberOfSiblings >= 4)
            {
                vacationHome = "your backyard";
            }
            else
            {
                switch (numberOfSiblings)
                {
                    case 0:
                        vacationHome = "a beach house in Dubai";
                        break;

                    case 1:
                        vacationHome = "Rio de Janeiro";
                        break;

                    case 2:
                        vacationHome = "Napa Valley";
                        break;

                    case 3:
                        vacationHome = "a modest cabin in the woods";
                        break;

                    default:
                        vacationHome = "a dumpster in Siberia (you filthy liar)";
                        break;
                }
            }
            return vacationHome;
        }

        //mode of transportation method
        static string ModeOfTransportation(string favoriteColor)
        {
            string transport;
            switch (favoriteColor)
            {
                case "RED":
                    transport = "\na crimson Maserati";
                    break;

                case "BLUE":
                    transport = "\na yacht on the cerulean sea";
                    break;

                case "GREEN":
                    transport = "\nan emerald colored private jet";
                    break;

                case "ORANGE":
                    transport = "\na mango colored Lamborghini";
                    break;

                case "YELLOW":
                    transport = "\na neon sphinx on which to ride";
                    break;

                case "VIOLET":
                    transport = "\nyou will ride on the back of a one eyed, one horned,\nflying purple people eater";
                    break;

                case "INDIGO":
                    transport = "\na magical monkey that carries you to your destinations";
                    break;

                case "INIGO":
                    transport = "\nmy name is Inigo Montoya.\n\nYou killed my father, prepare to die (nice typo)\a\a\a";
                    break;

                default:
                    transport = "\na squeaky shopping cart";
                    break;
            }
            return transport;
        }

        //money in bank method
        static double MoneyInBank(int birthMonth)
        {
            double moneyInBank;

            if (birthMonth >= 1 && birthMonth <= 4)
            {
                moneyInBank = 131313.13;
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                moneyInBank = 121314.11;
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                moneyInBank = 5318008.01;
            }
            else
            {
                moneyInBank = 0.00;
            }
            return moneyInBank;
        }

        //fortune comment method
        static void FortuneQuality()
        {
            Console.WriteLine("That might be my best fortune yet. Good for you.");
        }
    }
}
