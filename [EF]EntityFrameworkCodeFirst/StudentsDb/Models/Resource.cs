namespace StudentsDb
{
    //Resources: id, name, type of resource (video / presentation / document / other), link
    public class Resource
    {
        public int Id { get; set; }

        public TypeResourse TypeResourse { get; set; }

        public string Link { get; set; }
    }
}
