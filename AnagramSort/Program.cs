using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Given an array of strings, sort it such that the anagrams are next to each other
// Eg:
// input {god, dog, abc, cab, man, ant, tan}
// output {abc, cab, dog, god, man}

namespace AnagramSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = {"abc", "ant", "cab", "dog", "god", "man", "tan"};

            CustomSortString(input);
        }

        static void CustomSortString(string[] input)
        {
            Dictionary<string, List<string>> table = new Dictionary<string, List<string>>();

            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];

                char[] currentCharArray = current.ToArray();

                Array.Sort(currentCharArray);

                string sortedString = new String(currentCharArray);

                if (table.ContainsKey(sortedString))
                {
                    table[sortedString].Add(current);
                }
                else
                {
                    List<string> value = new List<string>();
                    value.Add(current);

                    table.Add(sortedString, value);
                }
            }

            foreach (var entry in table)
            {
                List<string> strings = entry.Value;

                foreach (string str in strings)
                {
                    Console.Write(str + " ");
                }
            }
        }
    }
}
