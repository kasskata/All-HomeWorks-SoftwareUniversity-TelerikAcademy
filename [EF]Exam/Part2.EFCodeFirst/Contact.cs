using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Part2.EFCodeFirst
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        
        [Required] 
        public string Name { get; set; }

        public string Position { get; set; }

        public string Company { get; set; }
        
        public string Url { get; set; }

        public string Notes { get; set; }

        public virtual List<Email> Emails { get; set; }
        public virtual List<Phone> Phones { get; set; }
    }
}