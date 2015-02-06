namespace TheSlum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Pill : BonusBase
    {
        public Pill(string id)
            : base(id, 0, 0, 100, 1) { }
    }
}
