using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RealizedSortings.SearchMethods;

namespace RealizedSortings
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();
           

            hash.Add("you", new string[] { "alice", "bob", "claire" });
            hash.Add("alice", new string[] { "bob", "claire" });
            Console.WriteLine(wideSearch(hash, "you"));
        }
    }
}
