namespace TheSlum
{
    using System;
    using System.Collections.Generic;

    public class Warior : Character, TheSlum.Interfaces.IAttack
    {
        public Warior(string id, int x, int y, Team team)
            : base(id, x, y, 200, 100, team, 2)
        {
            this.AttackPoints = 150;
            this.Inventory = new List<Item>();
        }

        public List<Item> Inventory { get; set; }

        public int AttackPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            foreach (var player in targetsList)
            {
                if (player.Team != this.Team && player.IsAlive != false)
                {
                    return player;
                }
            }

            return null;
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.RemoveItemEffects(item);
            this.Inventory.Remove(item);
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" Attack: {0}", this.AttackPoints);
        }

        protected override void ApplyItemEffects(Item item)
        {
            this.HealthPoints += item.HealthEffect;
            this.DefensePoints += item.DefenseEffect;
            this.AttackPoints += item.AttackEffect;
        }
    }
}
