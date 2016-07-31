using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skill_Calculator.util;

namespace Skill_Calculator
{
    class Herblore
    {
        string username = "";
        int desiredLevel = 0;
        double bonusXp = 0.0;
        double xpMultiplier = 0.0;
        int skillxp = 0;
        double xpNeeded = 0.0;

        //This is called by MainMenu and starts the herblore portion of the calculator. It asks the user for information
        //and then asks what information they would like displayed. 
        public Herblore()
        {
            Console.WriteLine("Welcome to the Herblore Calculator! /n");

            setInfo();

            bool keepGoing = true;

            while (keepGoing)
            {
                Console.Clear();
                Console.WriteLine("Herblore Calculator! /n");
                Console.WriteLine("Please select an option by number:");
                Console.WriteLine("1. Making Potions");
                Console.WriteLine("2. Cleaning Herbs");
                Console.WriteLine("3. Misc");
                Console.WriteLine("0. Quit");

                string answer = Console.ReadLine();

                if(answer == "1")
                {
                    HerblorePotions potions = new HerblorePotions(username, xpNeeded, bonusXp, xpMultiplier);
                }
                else if(answer == "2")
                {
                    HerbloreHerbs herbs = new HerbloreHerbs();
                }
                else if(answer == "3")
                {
                    HerbloreMisc misc = new HerbloreMisc();
                }
                else if(answer == "0")
                {
                    keepGoing = false; 
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again with JUST a NUMBER!");
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                }

            }

            
        }

        //This method requests necessary information from the user and places it into variables in this class.
        private void setInfo()
        {
            bool correct = false; //bool for loops to get user information
            GetHighscores highscores = new GetHighscores();
            //get username
            Console.Clear();
            Console.WriteLine("Please enter your username: ");
            Console.WriteLine("If your herblore level is below 35 or you want to enter your experinece, hit enter");
            username = Console.ReadLine();
            if(username == "")
            {
                Console.Clear();
                Console.WriteLine("Please enter your herblore experience:");
                skillxp = Int32.Parse(Console.ReadLine());
            }

            if (xpNeeded == 0)
            {
                highscores.getXP(username);
                xpNeeded = highscores.getExpNeeded(desiredLevel, "herblore", username);
            }
            else
            {
                xpNeeded = highscores.getExpNeeded(desiredLevel, skillxp);
            }

            //get desired level
            while (correct != true)
            {
                Console.Clear();
                Console.WriteLine("Please enter herblore level desired: ");
                desiredLevel = Int32.Parse(Console.ReadLine());
                if (desiredLevel >= 2 && desiredLevel <= 120)
                {
                    correct = true;
                }
                else
                {
                    Console.WriteLine("Invalid answer. Enter a number between 2 and 120");
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                }
            }

            //get bonus xp
            correct = false;
            while(correct != true)
            {
                Console.Clear();
                Console.WriteLine("Please enter your bonus xp: ");
                string temp = Console.ReadLine();
                if (temp.All(Char.IsDigit))
                {
                    bonusXp = Double.Parse(temp);
                    correct = true;
                }
                else
                {
                    Console.WriteLine("Invalid entry, please enter all digits.");
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                }
            }

            //get multiplier
            correct = false;

            while(correct != true)
            {
                Console.Clear();
                Console.WriteLine("Please enter your boost as a DECIMAL");
                Console.WriteLine("");
                Console.WriteLine("Botansit outfit - .01 each piece or .06 for all 5");
                Console.WriteLine("Avatar - .06 for close, .03 for same world");
                Console.WriteLine("Portable wells - .1");

                xpMultiplier = Double.Parse(Console.ReadLine());

                if(xpMultiplier >= 0.0 && xpMultiplier <= 0.22)
                {
                    correct = true;
                }
                else
                {
                    Console.WriteLine("Invlaid input, please put a number between 0 and .22");
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                }
            }
        }
    }
}
