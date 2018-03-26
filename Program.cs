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
                }
            }
            
            Console.WriteLine("\n");
            Console.WriteLine("There were no repeat characters in the string");
            return ht;
        }
    }
}

