namespace Animals
{
    using System;
    using System.Collections.Generic;
    class Dogs : Animals
    {
        public Dogs(string name, int age, string gender)
            : base(name, age, gender)
        {

        }
        public override void ProduceSound()
        {
            Console.WriteLine("The dog says bauuu");
        }
    }
}
