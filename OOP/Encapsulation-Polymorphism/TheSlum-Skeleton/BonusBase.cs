namespace TheSlum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TheSlum.Interfaces;

    public class BonusBase : Item, ITimeoutable
    {
        public BonusBase(string id, int healthEffect, int defenseEffect, int attackEffect, int timeout)
            : base(id, healthEffect, defenseEffect, attackEffect)
        {
            this.Timeout = timeout;
        }

        public int Timeout { get; set; }
        public int Countdown { get; set; }
        public bool HasTimedOut { get; set; }
    }
}

