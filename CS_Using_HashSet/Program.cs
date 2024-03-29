﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CS_Using_HashSet
{
    // Answers to the question: explanations why some operations on HashSets are faster than with Lists, and some are slower.

    // The answrs showcased in the documentation we were provide are as follows:
    // For adding list are faster, for contains hashset is faster and for remove hashset is faster.

    // My answers are as follows:
    // For adding hashset are faster, for contains list is faster and for remove hashset is faster.

    // Since the results are diffrent between the documentation provided and my results i am unsure if i should trust the documentation provided.
    // The only result that is the same is the remove operation where hashset is faster.
    // The reason why i think the results are diffrent is because the documentation provided is outdated (7 years ago)
    // and the results are diffrent in the current version of C#.
    
    // The reason according to google why hashset is faster at adding operations
    // is because it uses a hash table to store the elements and dosent have to iterate through the list to find a good location.

    // The reason why list is faster at contains operations is because it uses a array to store the elements can iterate through the list to find the element.
    // Where as hashset has to calculate the hash of the element and then find the element in the hash table.

    // The reason why hashset is faster at remove operations is because it uses a hash table to store the elements
    // and dosent have to iterate through the list to find a good location.

    /*
      ____________________________________
List Performance while Adding Item

9.244 ms

Ends Here

____________________________________
HashSet Performance while Adding Item

0.064 ms

Ends Here
____________________________________

____________________________________
List Performance while performing Remove item operation

0.297 ms

Ends Here

____________________________________
HashSet Performance while performing Remove item operation

0.008 ms

Ends Here
____________________________________

____________________________________
List Performance while checking Contains operation

0.005 ms

Ends Here

____________________________________
HashSet Performance while checking Contains operation

0.057 ms

Ends Here
____________________________________

    */
    class Program
    {
        static string[] names = new string[] {
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
                "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
                "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
                "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
                "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
                "Leena", "Neema", "Sita",
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
                "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
                "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
                "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
                "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
                "Leena", "Neema", "Sita",
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
                "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
                "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
                "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
                "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
                "Leena", "Neema", "Sita",
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
                "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
                "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
                "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
                "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
                "Leena", "Neema", "Sita",
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
                "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
                "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
                "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
                "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
                "Leena", "Neema", "Sita",
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
                "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
                "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
                "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
                "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
                "Leena", "Neema", "Sita",
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
                "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
                "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
                "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
                "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
                "Leena", "Neema", "Sita",
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
                "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
                "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
                "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
                "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
                "Leena", "Neema", "Sita",
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
                "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
                "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
                "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
                "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
                "Leena", "Neema", "Sita",
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
                "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
                "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
                "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
                "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
                "Leena", "Neema", "Sita",
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
                "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
                "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
                "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
                "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
                "Leena", "Neema", "Sita",
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
                "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
                "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
                "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
                "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
                "Leena", "Neema", "Sita",
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
                "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
                "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
                "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
                "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
                "Leena", "Neema", "Sita",
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
                "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
                "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
                "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
                "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
                "Leena", "Neema", "Sita",
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
                "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
                "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
                "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
                "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
                "Leena", "Neema", "Sita",
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
                "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
                "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
                "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
                "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
                "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
                "Leena", "Neema", "Sita"
            };
        static void Main(string[] args)
        {
            Console.WriteLine("Using HashSet");
            //1. Defining String Array (Note that the string "mahesh" is repeted) 
            string[] names = new string[] {
                "mahesh",
                "vikram",
                "mahesh",
                "mayur",
                "suprotim",
                "saket",
                "manish"
            };
            //2. Length of Array and Printing array
            Console.WriteLine("Length of Array " + names.Length);
            Console.WriteLine();
            Console.WriteLine("The Data in Array");
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();
            //3. Defining HashSet by passing an Array of string to it
            HashSet<string> hSet = new HashSet<string>(names);
            //4. Count of Elements in HashSet
            Console.WriteLine("Count of Data in HashSet " + hSet.Count);
            Console.WriteLine();
            //5. Printing Data in HashSet, this will eliminate duplication of "mahesh" 
            Console.WriteLine("Data in HashSet");
            foreach (var n in hSet)
            {
                Console.WriteLine(n);
            }

            //1.
            string[] names1 = new string[] {
                "mahesh","sabnis","manish","sharma","saket","karnik"
            };

            string[] names2 = new string[] {
                "suprotim","agarwal","vikram","pendse","mahesh","mitkari"
            };
            //2.
            HashSet<string> hSetN1 = new HashSet<string>(names1);
            Console.WriteLine("Data in First HashSet");
            foreach (var n in hSetN1)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("_______________________________________________________________");
            HashSet<string> hSetN2 = new HashSet<string>(names2);
            Console.WriteLine("Data in Second HashSet");
            foreach (var n in hSetN2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("________________________________________________________________");
            //3.
            Console.WriteLine("Data After Union");
            hSetN1.UnionWith(hSetN2);
            foreach (var n in hSetN1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Data in HashSet before using Except With");
            Console.WriteLine("_________________________________");
            //storing data of hSetN3 in temporary HashSet
            HashSet<string> hSetN3 = new HashSet<string>(names1);
            foreach (var n in hSetN3)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Using Except With");
            Console.WriteLine("_________________________________");
            hSetN3.ExceptWith(hSetN2);
            foreach (var n in hSetN3)
            {
                Console.WriteLine(n);
            }
            HashSet<string> hSetN4 = new HashSet<string>(names1);
            Console.WriteLine("_________________________________");
            Console.WriteLine("Elements in HashSet before using SymmetricExceptWith");
            Console.WriteLine("_________________________________");
            Console.WriteLine("HashSet 1");
            foreach (var n in hSetN4)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("HashSet 2");
            foreach (var n in hSetN2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("_________________________________");
            Console.WriteLine("Using SymmetricExceptWith");
            Console.WriteLine("_________________________________");
            hSetN4.SymmetricExceptWith(hSetN2);
            foreach (var n in hSetN4)
            {
                Console.WriteLine(n);
            }
            Get_Add_Performance_HashSet_vs_List();
            Get_Remove_Performance_HashSet_vs_List();
            Get_Contains_Performance_HashSet_vs_List();

        }
        static void Get_Add_Performance_HashSet_vs_List()
        {

            Console.WriteLine("____________________________________");
            Console.WriteLine("List Performance while Adding Item");
            Console.WriteLine();
            List<string> lstNames = new List<string>();
            var s2 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                lstNames.Add(s);
            }
            s2.Stop();

            Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine("HashSet Performance while Adding Item");
            Console.WriteLine();

            HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
            var s1 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                hStringNames.Add(s);
            }
            s1.Stop();

            Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine("____________________________________");
            Console.WriteLine();

        }
        static void Get_Contains_Performance_HashSet_vs_List()
        {

            Console.WriteLine("____________________________________");
            Console.WriteLine("List Performance while checking Contains operation");
            Console.WriteLine();
            List<string> lstNames = new List<string>();
            var s2 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                lstNames.Contains(s);
            }
            s2.Stop();

            Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine("HashSet Performance while checking Contains operation");
            Console.WriteLine();

            HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
            var s1 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                hStringNames.Contains(s);
            }
            s1.Stop();

            Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms"));
            Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine("____________________________________");
            Console.WriteLine();

        }
        static void Get_Remove_Performance_HashSet_vs_List()
        {

            Console.WriteLine("____________________________________");
            Console.WriteLine("List Performance while performing Remove item operation");
            Console.WriteLine();
            List<string> lstNames = new List<string>();
            var s2 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                lstNames.Remove(s);
            }
            s2.Stop();

            Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine("HashSet Performance while performing Remove item operation");
            Console.WriteLine();

            HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
            var s1 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                hStringNames.Remove(s);
            }
            s1.Stop();

            Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine("____________________________________");
            Console.WriteLine();

        }
    }
}