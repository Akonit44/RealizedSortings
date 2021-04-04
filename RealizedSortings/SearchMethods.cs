using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RealizedSortings
{
    public class SearchMethods
    {
        public static string wideSearch(Hashtable To_search_in, string start_key)
        {
            //TO MAIN()->>>>>>>
            //Hashtable hash = new Hashtable();
            //hash.Add("you", new string[] { "alice", "bob", "claire" });
            //hash.Add("alice", new string[] { "bob", "claire" });
            //Console.WriteLine(wideSearch(hash, "you"));
            Queue queue = new Queue();
            string rez = "";

            Add_to_Queue(To_search_in, start_key);

            while (queue.Count != 0)
            {
                rez = (string)queue.Dequeue();
                if (Is_search_target(rez)) return rez;
                else Add_to_Queue(To_search_in, rez);
            }

            bool Is_search_target(string neighbour)
            {
                if (neighbour.Length > 5) return true;
                return false;
            }
            void Add_to_Queue(Hashtable hash, string key)
            {
                foreach (string neighbour in (string[])hash[key])
                {
                    if (!queue.Contains(neighbour)) queue.Enqueue(neighbour);
                }
            }
            string Get_Key()
            {
                return (string)queue.Dequeue();
            }
            return "There is no Matches";
        }
        

    }
}
