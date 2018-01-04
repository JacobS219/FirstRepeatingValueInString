using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRecurringCharacter
{

    class Program
    {
        
        static void Main(string[] args)
        {
            GetHashtable();
            Console.ReadKey();
        }
        
        static Hashtable GetHashtable()
        {
            // Create and return new Hashtable.
            Hashtable ht = new Hashtable();

            //The String of characters to check
            string characters = "abcdefghicmnb";
            //string characters = "abcdefghijklmnopqrstuvwxyz";

            //create an array from the string
            var a = characters.ToCharArray();

            //for (int i = 0; i < a.Length; i++)
            //    Console.Write("  {0}: {1}", i, a[i]);

            //create a int value for the hashtable
            int value = 0;

            foreach (var key in a)
            {
                if (ht.ContainsKey(key))
                {
                    Console.WriteLine("\n");
                    Console.WriteLine(key + " is in the table already");
                    return ht;
                }

                else
                {

                    ht.Add(key, value);
                    value = value + 1;
                    Console.Write(key + "  ");
                    //Console.Write(value);
                }

                //Searches for a specific key.

                //string myKey = "c";
                //Console.WriteLine("The key \"{0}\" is {1}.", myKey, ht.ContainsKey(myKey) ? "in the Hashtable" : "NOT in the Hashtable");

                // Searches for a specific value.

                //string myValue = "c";
                //Console.WriteLine("The value \"{0}\" is {1}.", myValue, ht.ContainsValue(myValue) ? "in the Hashtable" : "NOT in the Hashtable");
            }

            //Hash contains key or value booleans
            //Console.WriteLine(ht.ContainsValue("c"));
            //Console.WriteLine(ht.ContainsKey("c"));

            Console.WriteLine("\n");
            Console.WriteLine("There were no repeat characters in the string");
            return ht;
        }
    }
}

