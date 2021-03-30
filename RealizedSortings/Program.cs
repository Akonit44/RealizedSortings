using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MySortings.Sortings;

namespace RealizedSortings
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();
            Queue queue_lst = new Queue();

            hash.Add("you", new string[] { "alice", "bob", "claire" });
            hash.Add("alice", new string[] { "bob", "claire" });

            Add_to_Queue(hash, ref queue_lst, "you");
            Add_to_Queue(hash, ref queue_lst, Get_Key(ref queue_lst));

            for (;  queue_lst.Count !=0; )
                Console.WriteLine($"{queue_lst.Dequeue()}");
            
        }
        public static void Add_to_Queue(Hashtable hash, ref Queue queue, string key)
        {
            foreach (string neighbour in (string[])hash[key])
            {
                if (!queue.Contains(neighbour)) queue.Enqueue(neighbour);
            }
        }
        public static string Get_Key(ref Queue queue)
        {
            return (string)queue.Dequeue();
        }
    }
}
