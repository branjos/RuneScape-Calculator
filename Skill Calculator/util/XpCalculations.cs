using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// The purpose of this class is to centralize the calculations into one class to aviod repetitive coding. It will be called
/// to get base xp rates with multipliers, determine actions to level, and use bonus xp. 
/// </summary>
namespace Skill_Calculator
{
    class XpCalculations
    {

        GetPrice price = new GetPrice();

        //The purpose of this method is to get base xp with the multiplier
        public double getBase(double multiplier, double baseXp)
        {
            double xp = 0;

            if (multiplier != 0)
            {
                xp = (baseXp * multiplier) + baseXp;
            }
            else
            {
                xp = baseXp;
            }

            return xp;
        }

        //This method determines how many actions are needed to reach goal level
        public double getActionsNeeded(double xpNeeded, double bonusXp, double baseXp)
        {
            double actions = 0;

            actions = xpNeeded / baseXp;

            if (xpNeeded <= bonusXp)
            {
                actions /= 2;
            }
            else
            {
                actions = actions - (bonusXp/baseXp);
            }

            return actions;
        }

        //This method takes item numbers and calculates loss/profit per one action
        public int calculateCost(string matOne, string matTwo, string matThree, string matFour, string item)
        {
            int total = 0;

            int material1 = 0;
            int material2 = 0;
            int material3 = 0;
            int material4 = 0;
            int product = 0;

            if(matOne == "" || matTwo == "" || matThree == "" || matFour == "")
            {
                if(matFour == "")
                {
                    if(matThree == "")
                    {
                        material1 = price.cost(matOne);
                        material2 = price.cost(matTwo);

                    }
                    else
                    {
                        material1 = price.cost(matOne);
                        material2 = price.cost(matTwo);
                        material3 = price.cost(matThree);
                    }
                }
                else
                {
                    material1 = price.cost(matOne);
                    material2 = price.cost(matTwo);
                    material3 = price.cost(matThree);
                    material4 = price.cost(matFour);
                }

            }

            product = price.cost(item);

            total = product - (material1 + material2 + material3 + material4);

            return total;
        }

        
    }
}
