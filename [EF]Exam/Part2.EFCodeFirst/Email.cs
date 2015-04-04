using System.ComponentModel.DataAnnotations;

namespace Part2.EFCodeFirst
{
    public class Email
    {
        [Key]
        public int Id { get; set; }
        
        public string EmailContact { get; set; }
    }
}
