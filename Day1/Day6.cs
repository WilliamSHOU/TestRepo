using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ThirtyDays
{
    class Day6
    {
        public string[] _strs;
        public Day6()
        {
            _strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
        }

        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var openWith = new Dictionary<string, List<string>>();

            foreach(string item in strs)
            {
                var i = item.ToCharArray();
                Array.Sort(i);
                string key = new string(i);
                
                if (openWith.ContainsKey(key))
                {
                    List<string> l = openWith[key];
                    WriteLine("Add new item: " + item + " in the list");
                    l.Add(item);
                    WriteLine("Removing " + key.ToUpper() + " from Dictionary");
                    openWith.Remove(key);
                    WriteLine("Adding " + key.ToUpper() + " from Dictionary");
                    openWith.Add(key, l);
                }
                else
                {
                    WriteLine("creating new List with key \"" + key + "\"");
                    List<string> l = new List<string>();
                    WriteLine("Add new item: " + item + " in the list");
                    l.Add(item);
                    openWith.Add(key, l);
                }
                //Write(key + " ");
            }

            var retList = new List<IList<string>>();
            
            foreach(string key in openWith.Keys)
            {
                retList.Add(openWith[key]);
            }

            return (IList<IList<string>>)retList;
        }
    }
}
