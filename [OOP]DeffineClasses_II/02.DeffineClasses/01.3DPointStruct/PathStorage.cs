namespace _01._3DPointStruct
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using ThreeDPoint;
    using System.IO;

    public class PathStorage
    {
        List<float> path;
        StreamWriter output = new StreamWriter(@"output.txt");
        StreamReader input = new StreamReader(@"input.txt");

        public PathStorage()
        {
            path = new List<float>();
        }

        public List<float> Path
        {
            get
            {
                return this.path;
            }
        }
        public void AddPoint(float point)
        {
            path.Add(point);
        }
        public void PrintPath()
        {
            for (int i = 0; i < path.Count; i++)
            {
                Console.WriteLine(i+1+" point: "+path[i]);
            }
        }
        public void Output(PathStorage objekt)
        {
            for (int i = 0; i < path.Count; i++)
            {
                output.WriteLine(objekt);                
            }
            output.Close();
        }
        public PathStorage Input(PathStorage objekt)
        {
            PathStorage path = new PathStorage();
            while (input.ReadLine() != null)
            {
                float batman = float.Parse(input.ReadLine());
                path.AddPoint(batman);
            }
            input.Close();
            return path;
        }
    }
}
