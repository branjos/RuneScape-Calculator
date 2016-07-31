using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

//This class is specifically designed to use the RuneScape Grand Exchange API to get and return the price of a specific item. 
//It's only method takes one parameter, the item number, and adds it to the end of the URL. This will take 

namespace Skill_Calculator
{
    class GetPrice
    {
        public int cost(String itemID)
        {
            int price = 0;
            try {
                //Calls the URL and places it into the string
                string url = new WebClient().DownloadString("http://services.runescape.com/m=itemdb_rs/api/catalogue/detail.json?item=" + itemID);
                
                //Gets the starting index of the number we are looking for
                int index1 = url.IndexOf("current");
                
                //Gets the index of the start of the next area which the string needs to stop
                int index2 = url.IndexOf("today");
                
                //Turns index2 into a length opposed to an index for use in the substring method
                index2 = index2 - index1;
                
                //Cuts down the clutter of the string to a more managable size
                string current = url.Substring(index1, index2);

                //Using index1 again to get the index of price
                index1 = current.IndexOf("price");

                //Turns index2 into a length again, by taking the length of the string minus 34
                index2 = (current.Length - 3) - (index1 + 7);

                //Further cuts down the string to the actual price of the item
                current = current.Substring(index1 + 7, index2);

                //Remove unnecessary commas or quotations
                current = current.Replace(",", "");
                current = current.Trim('"');

                price = Int32.Parse(current);
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }

            return price;
        }
    }
}
