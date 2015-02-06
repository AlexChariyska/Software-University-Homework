namespace Animals
{
    using System;
    using System.Collections.Generic;

    class Cat : Animals
    {
        public Cat(string name, int age, string gender)
            : base(name, age, gender)
        {

        }
        public override void ProduceSound()
        {
            Console.WriteLine("The cat says mqou-maou");
        }
    }
}
