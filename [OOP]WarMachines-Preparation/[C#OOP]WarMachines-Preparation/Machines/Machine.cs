namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        protected const string On = "ON";
        protected const string Off = "OFF";

        private string name;
        private IPilot pilot;
        private IList<string> targets;

        public Machine(string initialName, double initialAttPoints, double initialDeffPoints, double initialHelthPoints)
        {
            this.Name = initialName;
            this.AttackPoints = initialAttPoints;
            this.DefensePoints = initialDeffPoints;
            this.targets = new List<string>();
            this.HealthPoints = initialHelthPoints;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Machine name cannot be null");
                }

                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Engaged Pilot cannot be null");
                }

                this.pilot = value;
            }
        }

        public double HealthPoints { get; set; }

        public double AttackPoints { get; protected set; }

        public double DefensePoints { get; protected set; }

        public IList<string> Targets
        {
            get
            {
                return new List<string>(this.targets);
            }
        }

        public void Attack(string target)
        {
            if (string.IsNullOrEmpty(target))
            {
                throw new ArgumentNullException("Target cannot be null or empty");
            }

            this.targets.Add(target);
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            string targetAsString = this.targets.Count == 0 ? "None" :
                string.Join(", ", this.targets);

            result.AppendLine(string.Format("- {0}", this.Name));
            result.AppendLine(string.Format(" *Type: {0}", this.GetType().Name));
            result.AppendLine(string.Format(" *Healt: {0}", this.HealthPoints));
            result.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));
            result.AppendLine(string.Format(" *Defense: {0}", this.DefensePoints));
            result.AppendLine(string.Format(" *Targets: {0}", targetAsString));

            return result.ToString();
        }
    }
}
