using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheSlum
{
    public class Mage : Character, TheSlum.Interfaces.IAttack
    {
        public Mage(string id, int x, int y, Team team)
            :base(id,x,y,150,50,team,5)
        {
            this.AttackPoints = 300;
            this.Inventory = new List<Item>();

        }

        public List<Item> Inventory { get; set; }

        public int AttackPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            // Return last? Thats not a good tactic: attack different player but is on requarements
            var targets = targetsList as List<Character>;
            for (int i =  targets.Count-1 ; i >= 0 ; i--)
            {
                if (targets[i].Team != this.Team && targets[i].IsAlive == true)
                {
                    return targets[i];
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
        protected override void RemoveItemEffects(Item item)
        {
            this.HealthPoints -= item.HealthEffect;
            this.DefensePoints -= item.DefenseEffect;
            this.AttackPoints -= item.AttackEffect;
        }
    }
}
