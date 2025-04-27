using System;
using System.Collections.Generic;
using System.Text.Json.Serialization.Metadata;

namespace C_Sharp_CollectionsClass
{
    public class Prpgram
    {
        public static void ArrayToList()
        {
            int[] arr = { 1, 2, 3, 4 };

            List<int> list = arr.ToList();

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }

        public static void ListToArray() {
            List<int> list = new List<int>() { 1, 2, 3 };

            int[] arr = list.ToArray();

            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        public static void DicttoArray()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                {1, "Raj" },
                { 2,"Ravi" },
                {3, "Gislen" }
            };

            int[] keyarr = dic.Keys.ToArray();

            string[] valuearr = dic.Values.ToArray();

            foreach (int i in keyarr)
            {
                Console.WriteLine(i);
            }
        }

        public static void ArrayTODict()
        {
            int[][] arr = new int[][]
            {
                new int []{1,2,3},
                new int [] {100, 200, 300}
            };

            Dictionary<int, int> dic = arr.ToDictionary(x => x[0], x => x[1]);

            foreach(KeyValuePair<int, int> k in dic)
            {
                Console.WriteLine(k.Key +" - "+k.Value);
            }
        }

        public static void DictToList()
        {
            Dictionary<int, string> dic = new Dictionary<int, String>()
            {
                {1,"Car"},
                {2,"Elephant" },
                {3,"Lion"}
            };

            List<int> list = dic.Keys.ToList();

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            List<string> str = dic.Values.ToList();
            foreach(string s in str)
            {
                Console.WriteLine(s);
            }
        }

        public static void ListtoDict()
        {
            //Dictionary<int, string> dir = new Dictionary<int, string>()
            //{
            //    {1,"Raj" },
            //    {2, "Lakshmi" },
            //    {3,"Arasan" },
            //    {4, "Mila" }
            //};

            List<List<int>> list = new List<List<int>>()
            {
                new List<int>{1,2,3},
                new List<int>{5,6,7},
            };

            Dictionary<int, int> dic = list.ToDictionary(x => x[0], x => x[1]);

            foreach(KeyValuePair <int, int> k in dic)
            {
                Console.WriteLine($"{k.Key} : {k.Value}");
            }
        }
        static void Main(String[] args)
        {
            ArrayToList();
            ListToArray();

            DicttoArray();

            ArrayTODict();

            DictToList();
            ListtoDict();

        }
    }
}