using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class RepellerParticle : Particle
    {
        class ParticleRepeller : Particle
        {
            public int PushPower { get; private set; }

            public int Radius { get; private set; }

            public ParticleRepeller(MatrixCoords position, MatrixCoords speed, int pushPower, int radius) :
                base(position, speed)
            {
                this.PushPower = pushPower;
                this.Radius = radius;
            }

            public override char[,] GetImage()
            {
                return new char[,] { { 'R' } };
            }
        }
    }
}
