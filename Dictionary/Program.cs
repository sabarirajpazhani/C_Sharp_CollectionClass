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
        static void Main(string[] args)
        {
            DictionaryDeclaeration();  
        }
    }
}