using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    class ParticleSystemMain
    {
        const int Rows = 30;
        const int Col = 30;
        static readonly Random RandomGenerator = RandomGenerator;
        static void Main()
        {
            var renderer = new ConsoleRenderer(Rows,Col);

            var particleOperator = new ParticleUpdater();

            var engine = new Engine(renderer,particleOperator,null,300);

            GenerateParticle(engine);

            engine.Run();
        }

        private static void GenerateParticle(Engine engine)
        {
            engine.AddParticle(new Particle(
                new MatrixCoords(15, 0),
                new MatrixCoords(0, 1)
                ));

            engine.AddParticle(new DyingParticle(
                new MatrixCoords(0, 15),
                new MatrixCoords(1, 0),
                8
                ));
            var emitterPosition = new MatrixCoords(15, 15);

            var emitterSpeed = new MatrixCoords(0, 0);

            var emitter = new ParticleEmiter(emitterPosition, emitterSpeed, RandomGenerator, 5, 2, (emitterParameter) =>
            {
                MatrixCoords particlePos = emitterParameter.Position;


                int particleRowSpeed = emitterParameter.Generator.Next(emitterParameter.MinSpeedCoord, emitterParameter.MaxSpeedCoord + 1);
                int particleColSpeed = emitterParameter.Generator.Next(emitterParameter.MinSpeedCoord, emitterParameter.MaxSpeedCoord + 1);
                                
                MatrixCoords particleSpeed = new MatrixCoords(particleRowSpeed,particleColSpeed);

                Particle generated = null;

                int particleTypeIndex = emitterParameter.Generator.Next(0, 2);
                switch (particleTypeIndex)
                {
                    case 0: generated = new Particle(particlePos, particleSpeed); break;
                    case 1:
                        uint lifespan = (uint)emitterParameter.Generator.Next(8);
                        generated = new DyingParticle(particlePos,particleSpeed,lifespan);
                        break;
                    default:
                        throw new ArgumentException("Invalid Type");
                }
                return generated;
            }
            );
            engine.AddParticle(emitter);
        }
    }
}
