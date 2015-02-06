namespace Timer
{
    using System;
    class TimerTest
    {
        public static void Action(string str)
        {
            Console.Write(":) ");
        }
        static void Main()
        {
            AsynTimer example = new AsynTimer(Action, 5, 1000);
            example.Start();
        
        }
    }
}

