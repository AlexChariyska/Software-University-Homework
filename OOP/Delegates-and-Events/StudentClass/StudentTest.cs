namespace StudentClass
{
    using System;
    class StudentTest
    {
        static void Main()
        {
            Student student1 = new Student("Pesho", 19);
            student1.PropertyChanged += (sender, eventArgs) =>
            {
                Console.WriteLine(
                    "Property changed: {0} (from {1} to {2})",
                    eventArgs.PropName,
                    eventArgs.OldValue,
                    eventArgs.NewValue);
            };

            student1.Name = "Kiro";
            student1.Age = 48;
        }
    }
}
