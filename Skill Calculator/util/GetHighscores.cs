using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
/// <summary>
/// This class is designed to pull highscores information using the RuneScape API and put the numbers into a readable and
/// useable format. You should be able to input a username, a skill, and level desired and experience needed will be given.
/// 
/// Notes: skills in the stats array are listed in the following order - Total, Attack, Defence, Strength, Constitution, Ranged, 
/// Prayer, Magic, Cooking, Woodcutting, Fletching, Fishing, Firemaking, Crafting, Smithing, Mining, Herblore, Agility, 
/// Thieving, Slayer, Farming, Runecrafting, Hunter, Construction, Summoning, Dungeoneering, Divination
/// They each also have three for each category - rank, level, xp
/// </summary>
namespace Skill_Calculator
{
    class GetHighscores
    {
        
        List<int> stats = new List<int>(); //will hold the xp values in an easily obtainable format
        List<string> listStats = new List<string>();

        //levels is an array of the experience needed for all of the levels 1-120 in RuneScape.
        int[] levels = { 0, 0, 83, 174, 276, 388, 512, 650, 801, 969, 1154, 1358, 1584, 1833, 2107, 2411, 2746, 3115,
            3523, 3973, 4470, 5018, 5624, 6291, 7028, 7842, 8740, 9730, 10824, 12031, 13363, 14833, 16456, 18247, 20224,
            22406, 24815, 27473, 30408, 33648, 37224, 41171, 45529, 50339, 55649, 61512, 67983, 75127, 83014, 91721,
            101333, 111945, 123660, 136594, 150872, 166636, 184040, 203254, 224466, 247886, 273742, 302288, 333804, 368599,
            407015, 449428, 496254, 547953, 605032, 668051, 737627, 814445, 899257, 992895, 1096278, 1210421, 1336443,
            1475581, 1629200, 1798808, 1986068, 2192818, 2421087, 2673114, 2951373, 3258594, 3597792, 3972294, 4385776,
            4842295, 5346332, 5902831, 6517253, 7195629, 7944614, 8771558, 9684577, 10692629, 11805606, 13034431, 14391160,
            15889109, 17542976, 19368992, 21385073, 23611006, 26068632, 28782069, 31777943, 35085654, 38737661, 42769801,
            47221641, 52136869, 57563718, 63555443, 70170840, 77474828, 85539082, 94442737, 104273167 };
        
        //This method gets the username, skill desired, and level desired and outputs experience needed.
        public void getXP(string username) {
            try
            {
                var url = "http://services.runescape.com/m=hiscore/index_lite.ws?player=" + username;

                WebClient client = new WebClient();
                using (var stream = client.OpenRead(url))
                using (var reader = new StreamReader(stream))
                {
                    int i = 0;
                    while (reader.Peek() >= 0 && i <= 27)
                    {
                        string str;
                        string[] array;
                        str = reader.ReadLine();

                        array = str.Split(',');

                        listStats.Add(array[0]);
                        listStats.Add(array[1]);
                        listStats.Add(array[2]);

                        i++;
                    }
          
                }
                stats = listStats.Select(s => int.Parse(s)).ToList();
                
                //used for testing what the list contains
                
                //foreach (int list in stats)
                //{                       
                //    Console.WriteLine(list);
                //}

            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex);
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
            catch (System.IndexOutOfRangeException) { }
        }

        //This method determines what skill is needed and what xp the user has in that skill.
        private int getSkillExperience(string skill)
        {

            int experience = 0;
            int ex = 0;

            if (skill == "herblore")
            {
                experience = stats[50];
            }
            if (skill == "prayer")
            {
               // if (Int32.TryParse(stats[20], out experience)) ;
            }
            if(skill == "cooking")
            {
               // if (Int32.TryParse(stats[26], out experience)) ;
            }
            if(skill == "fletching")
            {
               // if (Int32.TryParse(stats[32], out experience)) ;
            }
            if(skill == "firemaking")
            {
               // if (Int32.TryParse(stats[38], out experience)) ;
            }
            if(skill == "crafting")
            {
               // if (Int32.TryParse(stats[41], out experience)) ;
            }
            if (skill == "smithing")
            {
               // if (Int32.TryParse(stats[44], out experience)) ;
            }
            Console.WriteLine(experience);
            return experience;
        }
        
        //This method takes the user's experience and desired level and returns experience needed. This should be called
        //and assigned to a local variable in the skill's own class
        public double getExpNeeded(int desiredLevel, string skill, string username)
        {
            double xpNeeded = 0;

            getXP(username);

            xpNeeded = levels[desiredLevel] - getSkillExperience(skill);

            return xpNeeded;
        }

        public double getExpNeeded(int desiredLevel, int skillxp)
        {
            double xpNeeded = 0;

            xpNeeded = levels[desiredLevel] - skillxp;

            return xpNeeded;
        }

        //Returns total xp needed
        public int getLevelXp(int level)
        {
            int temp = levels[level];
            return temp;
        }
    }
}
