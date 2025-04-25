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

        public static void objectInitializer()
        {
            var arrayList = new ArrayList()
            {
                102, "Gislem", 'c', true, 3.4
            };

            foreach(var i in arrayList)
            {
                Console.Write(i+" ");
            }
        }

        public static void accessArrayElement()
        {
            ArrayList list = new ArrayList();
            for(int i =0; i< 4; i++)
            {
                Console.Write("Enter the ArrayList Element: ");
                string str = Console.ReadLine();
                list.Add(str);
            }

            Console.WriteLine("Acessing the Array Elements: ");
            for(int i=0; i<4; i++)
            {
                Console.WriteLine((object)list[i]);
            }

            var list2 = new ArrayList()
            {
                1, true, "Gislen", 2.23
            };

            for(int i=0; i<4; i++)
            {
                Console.WriteLine(list2[i]);
            }

        }

        public static void InsertElement()
        {
            ArrayList list = new ArrayList()
            {
                10, "gislen", 'c', true, 9.43
            };

            list.Insert(0, "CSE"); //insert at first positiom
            list.Insert(3, 's'); //insert at 4th position

            list.InsertRange(2, new[] { 1, 2, 3, 4 });
            ArrayList arr = new ArrayList()
            {
                "gislen", 12, 100
            };
            list.InsertRange(1, arr);

            foreach(var i in list)
            {
                Console.WriteLine(i+" ");
            }
        }

        public static void removeElement()
        {
            ArrayList list = new ArrayList()
            {
                10, "gislen", 'c', true, 9.43, 100,4.0, false, "id", "error"
            };

            list.Remove(10);
            list.RemoveAt(2);
            list.RemoveRange(2, 4);

            foreach(var i in list)
            {
                Console.WriteLine(i+", ");
            }

            Console.WriteLine("Length of the ArrayList: "+ list.Count);
        }
        public static void containsMethod()
        {
            ArrayList list = new ArrayList()
            {
                10, "gislen", 'c', true, 9.43, 100,4.0, false, "id", "error"
            };

            Console.WriteLine(list.Contains("gislen"));
        }

        public static void cloneArray()
        {
            ArrayList list = new ArrayList()
            {
                10, "gislen", 'c', true, 9.43
            };

            ArrayList list2 = (ArrayList)list.Clone();

            foreach(var i in list2)
            {
                Console.WriteLine(i+" ");
            }
        }
        static void Main(string[] args)
        {
            //arrayBasic();
            //objectInitializer();
            //accessArrayElement();

            //--------------------------Methods ---------------------------------
            //InsertElement();
            //removeElement();
            //containsMethod();
            cloneArray();

        }

    }
}