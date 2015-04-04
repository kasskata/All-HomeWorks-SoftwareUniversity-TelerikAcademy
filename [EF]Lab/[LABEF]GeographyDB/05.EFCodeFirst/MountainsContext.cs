using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _05.EFCodeFirst
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MountainsContext : DbContext
    {
        public MountainsContext()
            : base("name=MountainsContext")
        {
        }

        public IDbSet<Country> Countries { get; set; }

        public IDbSet<Mountain> Mountains { get; set; }

        public IDbSet<Peak> Peaks { get; set; }
    }
}
//Create an Entity Framework (EF) code first data model for keeping countries, mountains and peaks.
//•	Countries have country code (2 Latin letters) and country name.
//•	Mountains have a name and belong to multiple countries.
//•	Peaks have a name, elevation and mountain.

public class Country
{
    [Key]
    public int Id { get; set; }

    [MaxLength(2)]
    [MinLength(2)]
    public string CountryCode { get; set; }

    public string CountryName { get; set; }
}

public class Mountain
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Peak> Peaks { get; set; }
}

public class Peak
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }

    public int Elevetaion { get; set; }

    public virtual Mountain Mountain { get; set; }
}