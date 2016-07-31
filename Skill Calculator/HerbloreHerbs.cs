using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skill_Calculator.util;

namespace Skill_Calculator
{
    class HerbloreHerbs
    {

        string username = "";
        int desiredLevel = 0;
        double bonusXp = 0.0;
        double xpMultiplier = 0.0;

        GetHighscores highscores = new GetHighscores();
        XpCalculations calc = new XpCalculations();

        public HerbloreHerbs()
        {
            

            highscores.getXP(username);

            printTable();
        }

        public void printTable()
        {
            //Gets skill experience to desired level and sets it to a local variable
            double xpNeeded = highscores.getExpNeeded(desiredLevel, "herblore", username);

            PrintTable table = new PrintTable();
            table.printHeader();
            //            level     name                      boosts      base xp                                 bonus xp          base xp                                    item 1     2      3     4   product                   item 1    2      3     4   product                           
            table.printLine(1, "Attack Potion", calc.getBase(xpMultiplier, 25.0), calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 25.0)), calc.calculateCost("249", "221", "227", "", "121"), (calc.calculateCost("249", "221", "227", "", "121")) * calc.getActionsNeeded(xpNeeded, bonusXp, calc.getBase(xpMultiplier, 25.0)));
        }
    }
}
