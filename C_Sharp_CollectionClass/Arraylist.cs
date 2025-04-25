using System;
using System.Collections;

namespace C_Sharp_CollectionClass
{
    public class Arraylist
    {
        public static void arrayBasic()
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Gislen");
            list.Add('c');
            list.Add(20.3);


            foreach(var i in list)
            {
                Console.WriteLine(i+" ");
            }

        }
        static void Main(string[] args)
        {
            arrayBasic();
        }

    }
}