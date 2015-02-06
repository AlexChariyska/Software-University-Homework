namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Frog : Animals
    {
        public Frog(string name, int age, string gender)
            : base(name, age, gender)
        {
        }
        public override void ProduceSound()
        {
            Console.WriteLine("The frog says kwak-kwak");
        }
    }
}
