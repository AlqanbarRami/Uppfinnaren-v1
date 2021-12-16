using System.Collections.Generic;

namespace Art.Models
{
    public class MockArtistRepository : IArtistRepository
    {
        public IEnumerable<Artist> AllArtist => new List<Artist> { new Artist { ArtistId = 1, FirstName = "Sonja", LastName = "Brussen", Country = "Netherlands", Email = "Sonja@gmail.com", PhoneNumber = "0739888159" , ImageArtist = "https://dutch-accent.nl/wp-content/uploads/sonjabrussen.jpg" } };
    }
}
