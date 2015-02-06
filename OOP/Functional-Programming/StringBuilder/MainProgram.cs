namespace StringBuilder
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class MainProgram
    {
       static void Main()
        {
            StringBuilder example = new StringBuilder("Hello");
            Console.WriteLine(example.Substring(0, 1));
            example.AppendAll(new List<string>() { ":)", " ", "^_^" });
            Console.WriteLine(example);
            Console.WriteLine(example.RemoveText(":)"));

        }
    }
}
