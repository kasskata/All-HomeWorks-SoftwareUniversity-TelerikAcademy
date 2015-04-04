namespace ThreeDPoint
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public struct Struct3DPoint
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public Struct3DPoint(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        
        public override string ToString()
        {
            return String.Format("( {0},{1},{2} )", this.X, this.Y, this.Z);
        }
        
        static readonly Struct3DPoint basse = new Struct3DPoint(0,0,0);
        
        public static Struct3DPoint Basse
        {
            get
            {
                return basse;
            }
        }
    }
}
