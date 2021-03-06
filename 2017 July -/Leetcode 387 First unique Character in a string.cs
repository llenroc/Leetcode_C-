﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode387_FirstUniqueCharacterInAString
{
    /// <summary>
    /// Leetcode 387 - First unique character in a string
    /// https://leetcode.com/problems/first-unique-character-in-a-string/description/
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
        }
        
        public int FirstUniqChar(string s)
        {
            if (s == null || s.Length == 0)
                return -1;

            int SIZE = 26;
            var count = new int[SIZE];
            var length = s.Length;
            for (int i = 0; i < length; i++)
            {
                count[s[i] - 'a']++;
            }

            // find first one with count = 1
            var hashset = new HashSet<char>(s.ToCharArray());
            for (int i = 0; i < length; i++)
            {
                var current = s[i];
                if (hashset.Contains(current))
                {
                    if (count[current - 'a'] == 1)
                        return i;

                    hashset.Remove(current);
                }
            }

            return -1;
        }        
    }
}
