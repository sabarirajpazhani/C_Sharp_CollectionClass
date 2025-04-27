using System;

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
        static void Main(string[] args)
        {
            //DictionaryDeclaeration();  
            acessingElement();

        }
    }
}