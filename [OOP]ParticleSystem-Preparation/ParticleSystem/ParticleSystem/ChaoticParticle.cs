using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class ChaoticParticle : Particle
    {
        public ChaoticParticle(MatrixCoords position, MatrixCoords speed, Random random)
            : base(position, speed)
        {
            this.Random = random;
        }

        public Random Random { get; private set; }

        protected override void Move()
        {
            this.Speed = new MatrixCoords(this.Random.Next(-3, 3), this.Random.Next(-3, 3));
            base.Move();
        }
        public override char[,] GetImage()
        {
            return new char[,] { {'*'} };
        }
    }
}
