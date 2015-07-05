namespace MusicSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Song
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTime? Year { get; set; }

        public string Genre { get; set; }
        
        [Required]
        public virtual Artist Artist { get; set; }
    }
}