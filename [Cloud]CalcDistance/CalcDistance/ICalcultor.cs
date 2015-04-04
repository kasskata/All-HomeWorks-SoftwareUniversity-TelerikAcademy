using System.Runtime.Serialization;
using System.ServiceModel;

namespace CalcDistance
{
    [ServiceContract]
    public interface ICalcultor
    {
        [OperationContract]
        float CalcDistance(Point first, Point second);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Point
    {
        [DataMember]
        public int X { get; set; }

        [DataMember]
        public int Y { get; set; }
    }
}
