using System;

[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface
    | AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = false)]

public class VersionAttribute : System.Attribute
{
    public int Major { get; private set; }
    public int Minor { get; private set; }

    public VersionAttribute(int major, int minor)
    {
        this.Major = major;
        this.Minor = minor;
    }
}
[VersionAttribute(4, 11)]
class VersionDemo
{
    static void Main()
    {
        Type type = typeof(VersionDemo);
        object[] versionAttributes = type.GetCustomAttributes(false);
        foreach (VersionAttribute versionAttribute in versionAttributes)
        {
            Console.WriteLine("The version of the class VersionDemo is {0}.{1}",
                versionAttribute.Major, versionAttribute.Minor);
        }
        Console.WriteLine();
    }
}