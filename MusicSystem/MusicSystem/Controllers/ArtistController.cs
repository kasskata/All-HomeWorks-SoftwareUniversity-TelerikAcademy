namespace MusicSystem.Controllers
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web.Http;
    using Models;

    public class ArtistController : BaseApiController
    {
        [HttpGet]
        public IHttpActionResult GetArtists(ArtistBindingModel artist)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest("The Artist have invalid state");
            }

            var allArtists = this.Data.Artists.All().ToList();

            return this.Ok(allArtists.Select(a=>new ArtistBindingModel
            {
                Name = a.Name,
                Country = a.Country,
                DateOfBirth = a.DateOfBirth
            }));
        }

        [HttpPost]
        public IHttpActionResult PostArtist([FromBody]ArtistBindingModel artist)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest("The Artist have invalid state");
            }

            var newArtist = new Artist
            {
                Name = artist.Name,
                Country = artist.Country,
                DateOfBirth = artist.DateOfBirth
            };

            this.Data.Artists.Add(newArtist);
            this.Data.SaveChanges();

            return this.Ok(newArtist);
        }

        [HttpPut]
        public IHttpActionResult PutArtist(int id, [FromBody] ArtistBindingModel artist)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest("The Artist have invalid state");
            }
     
            var artistFound = this.Data.Artists.All().FirstOrDefault(a => a.Id == id);

            if (artistFound == null)
            {
                return this.BadRequest("Dont have such artist");
            }

            artistFound.Name = artist.Name;
            artistFound.Country = artist.Country;
            artistFound.DateOfBirth = artistFound.DateOfBirth;

            this.Data.SaveChanges();
            return this.Ok(artistFound);
        }

        public IHttpActionResult DeleteArtist(int id)
        {
            var artistForDelete = this.Data.Artists.All().FirstOrDefault(a => a.Id == id);

            if (artistForDelete == null)
            {
                return this.BadRequest("Dont have such artist");
            }

            this.Data.Artists.Delete(id);
            this.Data.SaveChanges();
            return this.Ok(artistForDelete);
        }

    }

    public class ArtistBindingModel
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Country { get; set; }

        public DateTime? DateOfBirth { get; set; }
    }
}