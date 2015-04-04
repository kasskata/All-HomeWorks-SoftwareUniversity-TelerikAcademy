using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class ParticleEmiter: Particle
    {
        private uint maxEmittedPerCount;
        private Func<ParticleEmiter, Particle> randomParticleGeneratorMethod;

        public ParticleEmiter(
            MatrixCoords position, MatrixCoords speed,Random generator,
            uint maxEmittedPerCount,int maxSpeedCoord,
            Func<ParticleEmiter,Particle> randomParticleGeneratorMethod)
        :base(position,speed)
        {
            this.Generator = generator;

            this.maxEmittedPerCount = maxEmittedPerCount;
            this.MinSpeedCoord = 0;
            this.MaxSpeedCoord = (int)maxSpeedCoord;
            this.randomParticleGeneratorMethod = randomParticleGeneratorMethod;
        }

        public Random Generator { get; private set; }
        public int MaxSpeedCoord { get; private set; }
        public int MinSpeedCoord { get; private set; }
        public override IEnumerable<Particle> Update()
        
        {
            var baseProduced = base.Update();

            List<Particle> produced = new List<Particle>();
            
            int emittedCount = this.Generator.Next((int)this.maxEmittedPerCount+1);

            for (int i = 0; i < emittedCount; i++)
            {
                Particle p = GetRandomParticle();
                produced.Add(p);
            }
            produced.AddRange(baseProduced);
            return produced;
        }
        public Particle GetRandomParticle()
        {
           

            Particle result = this.randomParticleGeneratorMethod(this);

            return result;
        }
    }
}
