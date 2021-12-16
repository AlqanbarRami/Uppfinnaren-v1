using Art.Models;
using Microsoft.AspNetCore.Mvc;

namespace Art.Controllers
{
    public class ArtistController : Controller
    {
        private readonly IArtistRepository artistRepository;


        public ArtistController( IArtistRepository artistRepository)
        {
            this.artistRepository = artistRepository;
        }

        public IActionResult Artists()
        {
            return View(artistRepository.AllArtist);
        }
       
    }
}
