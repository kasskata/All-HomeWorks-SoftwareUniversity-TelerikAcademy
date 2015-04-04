using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheSlum
{
    public class Healer : Character, TheSlum.Interfaces.IHeal
    {
        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, 75, 50, team, 6)
        {
            this.HealingPoints = 60;
            this.Inventory = new List<Item>();

        }

        public List<Item> Inventory { get; set; }

        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var minHealth = int.MaxValue;
            foreach (var player in targetsList)
            {
                if (player.HealthPoints < minHealth && player.Id != this.Id)
                {
                    minHealth = player.HealthPoints;
                }
            }
            foreach (var player in targetsList)
            {
                if (player.Team == this.Team && player.HealthPoints == minHealth)
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
            return base.ToString() + string.Format(" Healing: {0}", this.HealingPoints);
        }
        
    }
}
