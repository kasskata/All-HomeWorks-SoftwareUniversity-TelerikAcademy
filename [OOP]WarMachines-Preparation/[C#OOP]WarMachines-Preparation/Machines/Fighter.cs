namespace WarMachines.Machines
{
    using System.Collections.Generic;
    using System.Text;
    using WarMachines.Interfaces;

    public class Fighter : Machine, IFighter, IMachine
    {
        private const byte initialHealthPoints = 200;
        private const byte attackPointsMod = 40;
        private const byte deffPointsMod = 30;

        public Fighter(string initialName, double initialAttack,bool initialStealthMode, double initialDeff)
            : base(initialName, initialAttack, initialDeff, initialHealthPoints)
        {
            this.StealthMode = initialStealthMode;
        }
        public bool StealthMode { get; private set; }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(base.ToString());
            string deffenceModeAsString = this.StealthMode ? On : Off;
            result.Append(string.Format(" *Stealth: {0}", deffenceModeAsString));
            return result.ToString();
        }
    }
}
