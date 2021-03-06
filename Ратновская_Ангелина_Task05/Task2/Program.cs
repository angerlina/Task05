﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите текст:");
            Console.WriteLine();
            var text = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Сколько раз встречается каждое слово в тексте:");
            string[] arrayStrings =  text.Split(new char[] {' ', '.'});

            for (int i = 0; i < arrayStrings.Length; i++)
            {
                arrayStrings[i] = arrayStrings[i].Trim(',', ' ').ToLower();
            }
            
            var dictionary = new Dictionary<string, int>();
           
            foreach (var element in arrayStrings)
            {
                if (!dictionary.ContainsKey(element))
 
                dictionary.Add(element, arrayStrings.Count(word => word == element));
            }

            foreach (var word in dictionary)
            {
                Console.WriteLine("{0}, {1}", word.Key, word.Value);
            }
            Console.ReadLine();
        }
    }
}
