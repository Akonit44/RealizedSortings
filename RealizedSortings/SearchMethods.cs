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
        public static string wideSearch(Hashtable _to_search_in, string start_key)
        {
            Queue queue = new Queue();


            Add_to_Queue(_to_search_in, start_key);

            while (queue.Count != 0)
            {


            }

            string Is_search_target(string neighbour)
            {
                if (neighbour.Length > 5) return neighbour;
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
            return null;
        }
        
    }
}
