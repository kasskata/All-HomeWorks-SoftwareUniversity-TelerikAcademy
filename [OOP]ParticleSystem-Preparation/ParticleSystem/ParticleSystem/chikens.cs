using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class ChickenParticle : ChaoticParticle
    {
        private const int DefaultDelay = 3;

        private int updateCounter = 0;
        private int delayCounter = 0;
        private bool layEgg;

        public ChickenParticle(MatrixCoords position, MatrixCoords speed, Random randomGen)
            : base(position, speed, randomGen)
        {
            this.layEgg = false;
        }

        public override IEnumerable<Particle> Update()
        {
            if (this.layEgg == true)
            {
                this.delayCounter++;
                if (delayCounter == DefaultDelay)
                {
                    this.delayCounter = 0;
                    layEgg = false;
                    return this.LayEgg();
                }

                return new List<Particle>();
            }

            if (updateCounter == this.Random.Next(0, 7))
            {
                this.layEgg = true;
            }

            return base.Update();
        }

        public IEnumerable<Particle> LayEgg()
        {
            return new List<Particle>() { new ChickenParticle(this.Position, this.Speed, this.Random) };
        }
        public override char[,] GetImage()
        {
            return new char[,]{{'%'}};
        }
    }
}
