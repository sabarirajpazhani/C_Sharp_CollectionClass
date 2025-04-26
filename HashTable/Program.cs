using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Security.Cryptography;

namespace HashTable
{
    public class Program
    {
        public static void HashTableBasic()
        {
            Hashtable ht = new Hashtable();
            ht.Add("Id", 1001);
            ht.Add("Name", "Sabari");
            ht.Add("Salary", 20000);
            ht.Add("Locatiion", "Chennai");

            //DictionaryEntry d = new DictionaryEntry();
            foreach(DictionaryEntry i in ht)
            {
                Console.WriteLine(i.Key+" - "+i.Value);
            }

            Console.WriteLine();
        }

        public static void UserInput()
        {
            Hashtable students = new Hashtable();

            Console.WriteLine("Enter the no. of Students: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int id = Convert.ToInt32(Console.ReadLine());

                string name = Console.ReadLine();

                students.Add(id, name);

            }

            foreach(DictionaryEntry d in students)
            {
                Console.WriteLine(d.Key+" - "+d.Value);
            }

            Console.WriteLine(students["name"]);
        }

        public static void containsMethods()
        {
            Hashtable countries = new Hashtable()
            {
                {"IND", "Chennai,Mumbai,Bengaluru" },
                {"USA", "New York, Washington" },
                {"UK","London, Birmingham" }
            };

            Console.WriteLine(countries.Contains("IND"));  //contains
            Console.WriteLine(countries.ContainsKey("USA")); //containsKey
            Console.WriteLine(countries.ContainsValue("Chennai,Mumbai,Bengaluru")); //containsvalue
        }

        public static void RemoveElement()
        {
            Hashtable students = new Hashtable()
            {
                {"Id", 1 },
                {"Name", "Raj"},
                {"Salary", 2000}
            };

            students.Remove("Id");

            Console.WriteLine(students.Count);
            Console.WriteLine(students["Name"]);
        }

        public static void updateElement()
        {
            Hashtable students = new Hashtable()
            {
                {"Id", 1 },
                {"Name", "Raj"},
                {"Salary", 2000}
            };

            //string StudentsName = (string)students["Name"];
            //int studentsalary = (int)students["Salary"];

            students["Name"] = "Gislen";
            students["Salary"] = 30000;



            foreach(DictionaryEntry d in students)
            {
                Console.WriteLine(d.Key +" - "+d.Value);
            }
        }

        public static void accessingElement()
        {
            Hashtable students = new Hashtable()
            {
                 {"Id", 1 },
                {"Name", "Raj"},
                {"Salary", 2000}
            };

            foreach(object obj in students.Keys)
            {
                Console.WriteLine(obj + " - " + students[obj]);
            }
        }

        public static void clone()
        {
            Hashtable students = new Hashtable()
            {
                 {"Id", 1 },
                {"Name", "Raj"},
                {"Salary", 2000}
            };

            Hashtable copyStudents = (Hashtable)students.Clone();

            Console.WriteLine(copyStudents.Count);
        }

        public static void copyto()
        {
            Hashtable students = new Hashtable()
            {
                 {"Id", 1 },
                 {"Name", "Raj"},
                 {"Salary", 2000}
            };

            DictionaryEntry [] darr = new DictionaryEntry[students.Count];
            students.CopyTo(darr, 0);

            foreach(DictionaryEntry i in darr)
            {
                Console.WriteLine(i);
            }

            object[] objKey = new object[students.Count];
            object[] objValue = new object[students.Count];

            students.Keys.CopyTo(objKey, 0);
            students.Values.CopyTo(objValue, 0);

            Console.WriteLine("Keys array");
            foreach(object obj in objKey)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Values array");
            foreach(object obj in objValue){
                Console.WriteLine(obj);
            }
        }
        static void Main(string[] args)
        {
            HashTableBasic();
            UserInput();
            containsMethods();
            RemoveElement();
            accessingElement();
            updateElement();
            clone();

            copyto();
        }
    }
}