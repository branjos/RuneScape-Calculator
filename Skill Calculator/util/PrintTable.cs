using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_Calculator.util
{
    class PrintTable
    {
        //Prints the header for the table. It should be called once, at the start of the printer call.
        public void printHeader()
        {
            
            Console.WriteLine("+-------------------------------------------------------------------------------+");
            Console.WriteLine("|Level|         Name        | Xp Each | To Reach Goal |Cost Ea| Total Cost      |");
            Console.WriteLine("|-----|---------------------|---------|---------------|-------|-----------------|");
        }

        //This prints one line, all data is fed through parameters. Uses StringBuilder
        public void printLine(int level, string name, double xpEa, double itemToGoal, double gpXp, double totalCost)
        {
            //convert doubles to strings
            string lvl = level.ToString();
            //Console.WriteLine(lvl);
            xpEa = Math.Ceiling(xpEa);
            string ea = xpEa.ToString();
            //Console.WriteLine(ea);
            itemToGoal = Math.Ceiling(itemToGoal);
            string goal = itemToGoal.ToString();
            //Console.WriteLine(goal);
            gpXp = Math.Ceiling(gpXp);
            string gp = gpXp.ToString();
            //Console.WriteLine(gp);
            totalCost = Math.Ceiling(totalCost);
            string total = totalCost.ToString();
            //Console.WriteLine(total);

            string line = "|     |                     |         |               |       |                 |";

            var sb = new StringBuilder(line);

            //Replacing level            
            sb.Remove(2, lvl.Length);
            sb.Insert(2, lvl);           

            //Replacing name
            sb.Remove(8, name.Length);
            sb.Insert(8, name);

            //Replacing xpEa
            sb.Remove(30, ea.Length);
            sb.Insert(30, ea);

            //Replacing goal
            sb.Remove(40, goal.Length);
            sb.Insert(40, goal);

            //Replacing Gp/Xp
            sb.Remove(56, gp.Length);
            sb.Insert(56, gp);

            //Replacing total
            sb.Remove(64, total.Length);
            sb.Insert(64, total);

            line = sb.ToString();
            Console.WriteLine(line);
            System.Threading.Thread.Sleep(13000);
        }

        public void printFooter()
        {
            Console.WriteLine("+-----------------------------PRESS ANY KEY TO EXIT-----------------------------+");
        }
    }
}
