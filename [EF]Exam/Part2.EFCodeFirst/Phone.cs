using System.ComponentModel.DataAnnotations;

namespace Part2.EFCodeFirst
{
    public class Phone
    {
        [Key]
        public int Id { get; set; }
        
        public string PhoneNumber { get; set; }
    }
}
