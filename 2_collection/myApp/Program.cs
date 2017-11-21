using System;
using System.Collections.Generic;

namespace list_quickstart {
    class Program {
        static void Main (string[] args) {
            WorkingWithStrings ();
        }
        static void WorkingWithStrings () {
            //declare & initialize
            var names = new List<string> { "Samuele", "Ana", "Felipe" };
            foreach (var name in names) {
                Console.WriteLine ($"Hello {name.ToUpper()}!");
            }

            //modify list content
            Console.WriteLine ();
            names.Add ("Maria");
            names.Add ("Bill");
            names.Remove ("Ana");
            foreach (var name in names) {
                //il car $ serve per poter inserire nella stringa del codice C# ed eseguirlo
                Console.WriteLine ($"Hello {name.ToUpper()}!");
            }

            //access by index
            Console.WriteLine ($"My name is {names[0]}");
            Console.WriteLine ($"I've added {names[2]} and {names[3]} to the list");
            //the last is (list.count - 1)
            Console.WriteLine ($"The list has {names.Count} people in it");
            Console.WriteLine ($"The last name of the list is {names[names.Count - 1]}.");
            Console.WriteLine ();
            Console.WriteLine ("reference:");
            foreach (var name in names) {
                Console.WriteLine ($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine ();
            Console.WriteLine ("Search & Sort");

            var index = names.IndexOf ("Felipe");
            if (index == -1) {
                Console.WriteLine ($"When an item is not found, IndexOf ruturns {index}");
            } else {
                Console.WriteLine ($"The name {names[index]} is at index {index}");
            }

            index = names.IndexOf ("Not Found");
            if (index == -1) {
                Console.WriteLine ($"When an item is not found, IndexOf return {index}");
            } else {
                Console.WriteLine ($"The name {names[index]} is at index {index}");
            }

            //Sorting alfabetico
            names.Sort ();
            foreach (var name in names) {
                Console.WriteLine ($"Hello {name.ToUpper()}!");
            }
        }
    }
}