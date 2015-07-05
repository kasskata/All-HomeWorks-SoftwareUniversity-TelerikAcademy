namespace MusicSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Artist
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Country { get; set; }

        public DateTime? DateOfBirth { get; set; }
    }
}
