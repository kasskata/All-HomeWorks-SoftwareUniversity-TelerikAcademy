namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Town
    {
        public Town()
        {
            Ads = new HashSet<Ad>();
            AspNetUsers = new HashSet<AspNetUser>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Ad> Ads { get; set; }

        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
    }
}
