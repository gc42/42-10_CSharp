using System;
using System.Collections;
using System.Globalization;

using fs = first_space;
using ss = second_space;

namespace first_space
{
    class abc
    {
        public void func()
        {
            Console.WriteLine("Inside first_space");
        }
    }
}

namespace second_space
{
    class abc
    {
        public void func()
        {
            Console.WriteLine("Inside second_space");
        }
    }
}

namespace test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // FACTORIEL
            /*// Saisir une valeur
            bool OK = false;
            int num = 0;
            while (!OK)
            {
                Console.Write("Saisissez un petit nombre (0 to exit):");
                try
                {
                    num = int.Parse(Console.ReadLine());
                    OK = (num > 0 && num <= 12);
                }
                catch {}
                if (!OK)
                    Console.WriteLine("Erreur. Saisissez un nombre entre 1 et 12");
            }
            MyFactorial f = new MyFactorial();
            Console.WriteLine("Le factorial de {0} est : {1}", num, f.Factorial(num));
            */

            // STRUCT Books
            /*// Exemple structure
            Books Book1 = new Books();
            Books Book2 = new Books();

            Book1.getValues("C Programming", "Nuha Ali", "C Programming Tutorial", 6495407);
            Book2.getValues("Telecom Billing", "Zara Ali", "Telecom Billing Tutorial", 6495700);

            Book1.display();
            Book2.display();
            */

            // ENUM
            /*// enum exemple
            int WeekDayStart = (int)MyEnum.Lundi;
            int WeekDayEnd = (int)MyEnum.Vendredi;

            string WeekS = MyEnum.Lundi.ToString();
            string WeekE = MyEnum.Vendredi.ToString();

            Console.WriteLine("Lundi    : {0}", WeekDayStart);
            Console.WriteLine("Vendredi : {0}", WeekDayEnd);

            Console.WriteLine("Lundi    : {0}", WeekS);
            Console.WriteLine("Vendredi : {0}", WeekE);
            */

            // STATIC
            /*// static field exemple
            StaticVar v1 = new StaticVar();
            StaticVar v2 = new StaticVar();

            v1.Count();
            v1.Count();
            v1.Count();

            v2.Count();
            v2.Count();
            v2.Count();
            v2.Count();

            Console.WriteLine("Variable num for v1 : {0}", v1.getNum()); // ERROR cannot acces by instanced object, but...
            Console.WriteLine("Variable num : {0}", StaticVar.getNum()); // must acces by class name
            */


            // INITIALISE BASE CLASS
            /*// Test initialisation base fields
            TableTop t = new TableTop(4.5, 7.5);
            t.Display();
            Console.WriteLine("Total area : {0} m2", t.GetArea());
            Console.WriteLine("Total paint cost : {0}", t.GetCost(t.GetArea()).ToString("C2", CultureInfo.CreateSpecificCulture("fr-FR")));
            */


            // OVERRIDE & VIRTUAL
            /*// virtual methods and override methods
            Caller c = new Caller();
            Rectangle rec = new Rectangle(10, 7);
            Triangle  tri = new Triangle(3, 4);
            TableTop  top = new TableTop(4.5, 7.5);

            c.CallArea(rec);
            c.CallArea(tri);
            c.CallArea(top);
            */

            // NAMESPACES
            /*// namespaces avec alias
            fs.abc fc = new fs.abc();
            ss.abc sc = new ss.abc();

            fc.func();
            sc.func();
            */

            // INDEXERS
            /*// indexers exemple
            IndexedNames names = new IndexedNames();
            names[0] = "Ambre";
            names[1] = "Max";
            names[2] = "Floremce";
            names[3] = "Claude";
            names[4] = "Mamik";
            names[5] = "Papik";
            names[6] = "Jerome";

            // Using first Indexer with int parameter
            for (int i = 0; i < IndexedNames.size; i++ )
                Console.WriteLine(names[i]);
            Console.WriteLine("");

            // Using second Indexer with string parameter
            Console.WriteLine(names["Ambres"]);
            Console.WriteLine(names["Mamiks"]);
            */

            // COLLECTIONS
            /*// collections ArrayList
            ArrayList al = new ArrayList();

            Console.WriteLine("Adding some numbers:");
            al.Add(45);
            al.Add(75);
            al.Add(25);
            al.Add(12);
            al.Add(32);
            al.Add(99);
            al.Add(9);
            al.Add(88);
            al.Add(88);

            Console.WriteLine("Capacity: {0}", al.Capacity);
            Console.WriteLine("Count: {0}", al.Count);

            Console.Write("Content: ");
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.Write("Sorted content: ");
            al.Sort();
            al.Reverse();
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Trimmed capacity: ");
            al.TrimToSize();
            Console.WriteLine("Capacity: {0}", al.Capacity);

            al.Add(77);
			Console.WriteLine("Capacity: {0}", al.Capacity);

            al.Remove(99);
            al.RemoveRange(4, 5);
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Capacity: {0}", al.Capacity);
            Console.WriteLine("Is 75 in the ArrayList? : {0}", al.Contains(75));
            Console.WriteLine("Index of 75: {0}", al.IndexOf(75));
            */

            /*// Collection Hashtable
            Hashtable ht = new Hashtable();

            ht.Add("001", "Ambre Caron--Lasne");
            ht.Add("002", "Florence Lasne");
            ht.Add("003", "Guillaume Caron");
            ht.Add("004", "Maxence Caron--Lasne");
            ht.Add("005", "Mamik Caron");
            ht.Add("006", "Claude Lasne");
            ht.Add("007", "Fredo Caron--Bras");

            if (ht.ContainsValue("Fredo Caron--Bras"))
                Console.WriteLine("This person is already in the list");
            else
                ht.Add("008", "Fredo Caron--Bras");

            // Get a collection of keys
            ICollection key = ht.Keys;
            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }
            Console.WriteLine();
            ht["006"] = "TOTO";
            ht.Remove("003");
            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }
            */

            // Collection SortedList
            SortedList sl = new SortedList();

            sl.Add("001", "Ambre Caron--Lasne");
            sl.Add("002", "Florence Lasne");
            sl.Add("003", "Guillaume Caron");
            sl.Add("004", "Maxence Caron--Lasne");
            sl.Add("005", "Mamik Caron");
            sl.Add("006", "Claude Lasne");
            sl.Add("007", "Fredo Caron--Bras");

            if (sl.ContainsValue("Fredo Caron--Bras"))
                Console.WriteLine("This person is already in the list");
            else
                sl.Add("008", "Fredo Caron--Bras");

            // Get a collection of keys
            ICollection key = sl.Keys;
            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + sl[k]);
            }
            Console.WriteLine();
            sl["006"] = "TOTO";
            sl.Remove("003");
            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + sl[k]);
            }


        }
    }
}