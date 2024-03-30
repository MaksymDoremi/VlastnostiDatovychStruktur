using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using static VlasnostiDatovychStruktur.Program;

namespace VlasnostiDatovychStruktur
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Serazenost
            // Sorted
            // SortedSet, SortedList, SortedDictionary

            // sorted by value
            SortedSet<int> sortedSet = new SortedSet<int>() { 2, 3, 2, 5, 6, 4, };
            foreach (int i in sortedSet)
            {
                Console.WriteLine(i);
            }

            //sorted by key ascending
            SortedList<string, int> sortedList = new SortedList<string, int>();
            sortedList.Add("a", 10);
            sortedList.Add("d", 20);
            sortedList.Add("c", 30);
            sortedList.Add("b", 40);

            foreach (int i in sortedList.Values)
            {
                Console.WriteLine(i);
            }

            // we can input comparer
            SortedList<int, string> sortedList2 = new SortedList<int, string>(new AscendingComparer());
            sortedList2.Add(5, "last");
            sortedList2.Add(4, "second");
            sortedList2.Add(3, "first");
            foreach (KeyValuePair<int, string> kvp in sortedList2)
            {
                Console.WriteLine(kvp.Key + " : " + kvp.Value);
            }
            Console.WriteLine();

            SortedList<int, string> sortedList3 = new SortedList<int, string>(new DescendingComparer());
            sortedList3.Add(5, "last");
            sortedList3.Add(4, "second");
            sortedList3.Add(3, "first");
            foreach (KeyValuePair<int, string> kvp in sortedList3)
            {
                Console.WriteLine(kvp.Key + " : " + kvp.Value);
            }


            // SortedList vs SortedDictionary 
            //SortedDictionary has faster insertion and removal operations for unsorted data => O(log n)
            //SortedList has O(n)
            SortedDictionary<int, int> sortedDictionary = new SortedDictionary<int, int>();
            sortedDictionary.Add(7, 2);
            sortedDictionary.Add(5, 4);
            sortedDictionary.Add(6, 3);
            foreach (int i in sortedDictionary.Values)
            {
                Console.WriteLine(i);
            }

            // Unsorted
            // List<int>, Queue<int>, Stack<int>, HashSet<int>, Dictionary<int, int>, LinkedList<int>
            // tady doufam napsat kod napotitku to zvladnem


            // Opakovani

            // Unique value
            // HashSet SortedSet
            HashSet<string> strings = new HashSet<string>();
            strings.Add("a");
            strings.Add("b");
            strings.Add("c");
            strings.Add("c"); // neprida se

            Console.WriteLine("Hash set");
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }

            // Unique key
            // Dictionary SortedDictionary SortedList HashTable
            Hashtable hashtable = new Hashtable();

            hashtable.Add(3, "three");
            hashtable.Add("a", 1);
            hashtable.Add(4, "ababaa");
           
            try
            {
                hashtable.Add(4, "aaaaa"); // throws error
            }
            catch 
            {
                Console.WriteLine("An element with Key = 4 already exists.");
            }

            foreach (DictionaryEntry de in hashtable)
            {
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }


            //not unique
            // Array, List<int>, Queue<int>, Stack<int>, LinkedList<int>


            // Indexace
            // Indexed 
            // List, ArrayList, String[](Array), string
            string stringString = "a";
            Console.WriteLine(stringString[0]);
            string[] stringField = new string[2];
            stringField[0] = "y";
            stringField[1] = "b";
            Console.WriteLine(stringField[0]);

            // Hashovani
            // Hashed
            // HashSet, Hashtable, 
            hashtable = new Hashtable();
            hashtable.Add("key1", "value1");
            hashtable["asd"] = "asd";
            hashtable["key1"] = "asd";
            //hashtable.Add("asd", "value1");throw error
            HashSet<string> keys = new HashSet<string>();
            keys.Add("key1");
            keys.Add("ke2");
            keys.Add("key1");//nevlozi se znovu


            // Klice prvku
            // Dictionary<TKey, TValue>, SortedDictionary<TKey, TValue>
        }


        public class AscendingComparer : IComparer<int>
        {
            public int Compare(int first, int second)
            {
                return first < second ? -1 : first > second ? 1 : 0;     //ascending

            }
        }

        public class DescendingComparer : IComparer<int>
        {
            public int Compare(int first, int second)
            {
                return first < second ? 1 : first > second ? -1 : 0; // descending
            }
        }
    }
}