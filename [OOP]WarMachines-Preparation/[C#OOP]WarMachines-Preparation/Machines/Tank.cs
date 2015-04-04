namespace WarMachines.Machines
{
    using System.Collections.Generic;
    using System.Text;
    using WarMachines.Interfaces;

    public class Tank : Machine, ITank, IMachine
    {
        private const byte initialHealthPoints = 100;
        private const byte attackPointsMod = 40;
        private const byte deffPointsMod = 30;

        public Tank(string initialName, double initialAttack, double initialDeff)
            : base(initialName, initialAttack, initialDeff, initialHealthPoints)
        {
            this.ToggleDefenseMode();
        }
        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.AttackPoints += attackPointsMod;
                this.DefensePoints -= deffPointsMod;
            }
            else
            {
                this.AttackPoints -= attackPointsMod;
                this.DefensePoints += deffPointsMod;
            }
            this.DefenseMode = !this.DefenseMode;
        }
        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(base.ToString());
            string deffenceModeAsString = this.DefenseMode ? On : Off;
            result.Append(string.Format(" *Defence: {0}", deffenceModeAsString));
            return result.ToString();
        }
    }
}
