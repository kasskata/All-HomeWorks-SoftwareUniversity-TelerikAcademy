namespace MusicSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Album
    {
        public Album()
        {
            this.Artists = new HashSet<Artist>();
            this.Songs = new HashSet<Song>();
        }

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTime? Year { get; set; }

        public string Producer { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}