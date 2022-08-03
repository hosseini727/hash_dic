using System;
using System.Collections;
using System.Collections.Generic;

namespace HashTable_Dictionery
{
    internal class Program
    {
        /// <summary>
        /// https://www.tutorialsteacher.com/csharp/csharp-hashtable
        /// https://codecell.ir/a/2d9f
        /// در دیکشنری، می‌توانید جفت‌های Key/Value را فقط از یک نوع ذخیره کنید.
        /// در Hashtable، می‌توانید جفت‌های Key/Value از یک نوع یا از نوع های متفاوت را ذخیره کنید.
        /// 
        /// </summary>

        /// <param name="args"></param>
        static void Main(string[] args)
        {

            //hash table 
            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three"); 

            foreach (DictionaryEntry de in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            //creating a Hashtable using collection-initializer syntax
            var cities = new Hashtable(){
    {"UK", "London, Manchester, Birmingham"},
    {"USA", "Chicago, New York, Washington"},
    {"India", "Mumbai, New Delhi, Pune"}
};

            foreach (DictionaryEntry de in cities)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
            //end hash table



            //dci 
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");
            Hashtable ht = new Hashtable(dict);
            //end dic


        }
    }
}
