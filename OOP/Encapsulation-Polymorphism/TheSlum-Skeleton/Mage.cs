namespace TheSlum
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using TheSlum.Interfaces;
    class Mage : Character, IAttack
    {
        public Mage(string id, int x, int y, int healthPoints, int defensePoints, Team team, int range, int attackPoints)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.AttackPoints = attackPoints;
        }

        public int AttackPoints { get; set; }

        public override Character GetTarget(System.Collections.Generic.IEnumerable<Character> targetsList)
        {
            return targetsList.LastOrDefault(ch => (ch.IsAlive && this.Team != ch.Team));
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
