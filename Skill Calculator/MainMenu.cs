using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This is the main menu for the program. It will ask the user for their username, and display the menu of available skills.
/// After displaying the skills it will wait for the user to input their choice and send the user to the skill of their
/// choice. The method to call in this class from the main class will have a loop that will end upon quitting.
/// </summary>
namespace Skill_Calculator
{
    class MainMenu
    {
        //Prints the main menu for the 
        public void printMenu()
        {

            Console.Clear();
            Console.WriteLine("Welcome to the RuneScape Calculator main menu!");
            Console.WriteLine("Please enter the corresponding number of the function you want to use:");
            Console.WriteLine("1. Herblore");
            Console.WriteLine("0. Quit");
            Console.WriteLine("More to come...");
            
        }

        //Holds the logic for starting the menu and holding the loop 
        public void start()
        {
            bool keepGoing = true; //boolean for the loop
            string menuChoice = ""; //menu option number

            while (keepGoing)
            {
                Console.Clear();
                printMenu();         
                menuChoice = Console.ReadLine();
                if(menuChoice == "1")
                {
                    startHerblore();
                }
                else if(menuChoice == "0")
                {
                    keepGoing = false;
                }
                else
                {
                    Console.WriteLine("Learn to read... Try again");
                }
            }
        }

        //Creates an instance of the herblore class and calls its constructor.
        public void startHerblore()
        {
            Herblore herblore = new Herblore();
        }

    }
}
