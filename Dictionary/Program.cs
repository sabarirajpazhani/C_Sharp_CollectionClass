using System;
using System.Reflection.Metadata;
using System.Threading.Channels;

namespace C_Sharp_CollectionsClass
{
    public class Program
    {
        public static void DictionaryDeclaeration()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();

            for(int i = 0; i < 3; i++)
            {
                int key = Convert.ToInt32(Console.ReadLine());

                string value = Console.ReadLine();

                dic.Add(key, value);
            }

            foreach(object obj in dic)
            {
                Console.WriteLine(obj);
            }
        }

        public static void acessingElement()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                {1, "Raj" },
                { 2,"Ravi" },
                {3, "Gislen" }
            };

            foreach(KeyValuePair <int, string> kvp in dic)
            {
                Console.WriteLine(kvp.Key +" - "+kvp.Value);
            }

            for(int i = 0; i < dic.Count; i++)
            {
                int key = dic.Keys.ElementAt(i);
                string value = dic[key];

                Console.WriteLine(key + " - "+ value);
            }
        }

        public static void containsMethods()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                {1, "Raj" },
                { 2,"Ravi" },
                {3, "Gislen" }
            };

            Console.WriteLine(dic.ContainsKey(1));
            Console.WriteLine(dic.ContainsValue("Raj"));
        }

        public static void forAll()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                {1, "Raj" },
                { 2,"Ravi" },
                {3, "Gislen" }
            };

            dic.AsParallel().ForAll(x => Console.WriteLine(x.Key+" : "+x.Value));
            
        }

        public static void updateing()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                {1, "Raj" },
                { 2,"Ravi" },
                {3, "Gislen" }
            };

            dic[1] = "Sabari";
            foreach(object i in dic)
            {
                Console.WriteLine(i);
            }
        }

        public static void trygetvalue()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                {1, "Raj" },
                { 2,"Ravi" },
                {3, "Gislen" }
            };

            Console.WriteLine(dic.TryGetValue(2, out string name));
            Console.WriteLine();        }
        static void Main(string[] args)
        {
            //DictionaryDeclaeration();  
            //acessingElement();
            //containsMethods();
            //forAll();
            //updateing();

            trygetvalue();
        }
    }
}