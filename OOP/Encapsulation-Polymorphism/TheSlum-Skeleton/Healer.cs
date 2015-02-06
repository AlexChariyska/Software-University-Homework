namespace TheSlum
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using TheSlum.Interfaces;
    class Healer : Character, IHeal
    {
        public Healer(string id, int x, int y, int healthPoints, int defensePoints, Team team, int range, int healingPoints)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.HealingPoints = healingPoints;
        }

        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.OrderBy(ch => ch.HealthPoints).First(ch => !ch.Equals(this) && ch.Team == this.Team);
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
        }
    }
}
