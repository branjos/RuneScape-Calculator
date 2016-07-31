using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skill_Calculator.util;

namespace Skill_Calculator
{
    class HerblorePotions 
    {

        GetHighscores highscores = new GetHighscores();
        XpCalculations calc = new XpCalculations();
        GetPrice price = new GetPrice();
        

        //Constructor. This prints and gets the first messages/information. It will ask for which results are desired and print via the corresponding class
        public HerblorePotions(string username, double xpneeded, double bonusXp, double xpMultiplier)
        {
            Console.WriteLine("Herblore Potion Calculator! /n");

            printTable(username, xpneeded, bonusXp, xpMultiplier);

        }

        //Print xp table
        public void printTable(string username, double xpNeeded, double bonusXp, double xpMultiplier)
        {
            //Gets skill experience to desired level and sets it to a local variable
            
            Console.Clear();
            PrintTable table = new PrintTable();
            Console.WriteLine("Herblore Potions   User = " + username + " Experience needed = " + xpNeeded);
            table.printHeader();
            //            level     name                      boosts      base xp                                 bonus xp          base xp                                    item 1     2      3     4   product                   item 1    2      3     4   product                           
            table.printLine(1, "Attack Potion", calc.getBase(xpMultiplier, 25.0), calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 25.0)), calc.calculateCost("249", "221", "227", "", "121"), (calc.calculateCost("249", "221", "227", "", "121")) * calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 25.0)));
            table.printLine(3, "Ranging Potion", calc.getBase(xpMultiplier, 30.0), calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 30.0)), calc.calculateCost("249", "1951", "227", "", "27506"), (calc.calculateCost("249", "1951", "227", "", "27506")) * calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 30.0)));
            table.printLine(5, "Magic Potion", calc.getBase(xpMultiplier, 35.0), calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 35.0)), calc.calculateCost("253", "1470", "227", "", "27514"), (calc.calculateCost("253", "1470", "227", "", "27514")) * calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 35.0)));
            table.printLine(7, "Strength Potion", calc.getBase(xpMultiplier, 40.0), calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 40.0)), calc.calculateCost("253", "225", "227", "", "115"), (calc.calculateCost("253", "225", "227", "", "115")) * calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 40.0)));
            table.printLine(9, "Defence Potion", calc.getBase(xpMultiplier, 45.0), calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 45.0)), calc.calculateCost("251", "948", "227", "", "133"), (calc.calculateCost("251", "948", "227", "", "133")) * calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 45.0)));
            table.printLine(13, "Antipoison ", calc.getBase(xpMultiplier, 50.0), calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 50.0)), calc.calculateCost("251", "235", "227", "", "175"), (calc.calculateCost("251", "235", "227", "", "175")) * calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 50.0)));
            table.printLine(22, "Restore Potion", calc.getBase(xpMultiplier, 62.5), calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 62.5)), calc.calculateCost("255", "223", "227", "", "127"), (calc.calculateCost("255", "223", "227", "", "127")) * calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 62.5)));
            table.printLine(26, "Energy Potion", calc.getBase(xpMultiplier, 67.5), calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 67.5)), calc.calculateCost("255", "1975", "227", "", "3010"), (calc.calculateCost("255", "1975", "227", "", "3010")) * calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 67.5)));
            table.printLine(34, "Agility Potion", calc.getBase(xpMultiplier, 80.0), calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 80.0)), calc.calculateCost("2998", "2152", "227", "", "3034"), (calc.calculateCost("2998", "2152", "227", "", "3034")) * calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 80.0)));
            table.printLine(36, "Combat Potion", calc.getBase(xpMultiplier, 84.0), calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 84.0)), calc.calculateCost("255", "9736", "227", "", "9741"), (calc.calculateCost("255", "9736", "227", "", "9741")) * calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 84.0)));
            table.printLine(38, "Prayer Potion", calc.getBase(xpMultiplier, 87.5), calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 87.5)), calc.calculateCost("257", "231", "227", "", "139"), (calc.calculateCost("257", "231", "227", "", "139")) * calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 87.5)));
            table.printLine(40, "Summoning Potion", calc.getBase(xpMultiplier, 92), calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 92)), calc.calculateCost("12172", "12109", "227", "", "12142"), (calc.calculateCost("12172", "12109", "227", "", "12142")) * calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 92)));
            table.printLine(45, "Super attack", calc.getBase(xpMultiplier, 100), calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 100)), calc.calculateCost("259", "221", "227", "", "145"), (calc.calculateCost("259", "221", "227", "", "145")) * calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 100)));
            table.printLine(48, "Super Antipoison", calc.getBase(xpMultiplier, 106.3), calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 106.3)), calc.calculateCost("259", "235", "227", "", "181"), (calc.calculateCost("259", "235", "227", "", "181")) * calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 106.3)));
            table.printLine(50, "Fishing Potion", calc.getBase(xpMultiplier, 112.5), calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 112.5)), calc.calculateCost("261", "231", "227", "", "151"), (calc.calculateCost("261", "231", "227", "", "151")) * calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 112.5)));
            table.printLine(52, "Super Energy", calc.getBase(xpMultiplier, 117.5), calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 117.5)), calc.calculateCost("261", "2970", "227", "", "3018"), (calc.calculateCost("261", "2970", "227", "", "3018")) * calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 117.5)));
            table.printLine(52, "Hunter Potion", calc.getBase(xpMultiplier, 120.0), calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 120.0)), calc.calculateCost("261", "10109", "227", "", "10000"), (calc.calculateCost("261", "10109", "227", "", "10000")) * calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 120.0)));
            table.printFooter();
            Console.ReadKey();
        }

    }
}
