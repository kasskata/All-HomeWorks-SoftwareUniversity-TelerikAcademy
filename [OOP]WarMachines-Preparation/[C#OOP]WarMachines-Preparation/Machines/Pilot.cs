namespace WarMachines.Machines
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private string name;
        private IList<IMachine> machines;

        public Pilot(string initialname)
        {
            this.Name = initialname;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Pilot name cannot be null");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                throw new ArgumentException("Machine cannot be null");
            }

            this.machines.Add(machine);
        }

        public string Report()
        {
            var result = new StringBuilder();

            string pilotName = this.Name;
            string numberOfmachines = this.machines.Count == 0 ? "no" : this.machines.Count.ToString();
            string machineWord = this.machines.Count == 1 ? " machine" : " machines";

            result.Append(string.Format("{0} - {1},{2}", pilotName, numberOfmachines, machineWord));

            var sortedmachines = this.machines
                                     .OrderBy(m => m.HealthPoints)
                                     .ThenBy(m => m.Name);

            foreach (var machine in sortedmachines)
            {
                result.Append(machine.ToString());
            }
            
            return result.ToString();
        }
    }
}
