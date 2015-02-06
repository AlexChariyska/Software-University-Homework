namespace GenericList
{
    using System;
    class GenericListCompilator
    {
        public static void Main()
        {
            GenericList<int> list = new GenericList<int>(2);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(10);
            list.Add(20);
            Console.WriteLine(list);
            Console.WriteLine("Max: " + list.Max());
            Console.WriteLine("Min: " + list.Min());
            list.RemoveAt(3);
            Console.WriteLine(list);
            Console.WriteLine(list[3]);
            Console.WriteLine(list.IndexOf(121));
            list.InsertAt(4, 8);
            Console.WriteLine("Inserting 66:");
            Console.WriteLine(list);
            Console.WriteLine(list.Count);
            Console.WriteLine("Attribute:");
            var attributes = typeof(GenericList<>).GetCustomAttributes(typeof(VersionAttribute), false);
            Console.WriteLine("Version: " + attributes[0]);
            list.Clear();
            Console.WriteLine("Cleared list");
            Console.WriteLine(list);
        }
    }
}
