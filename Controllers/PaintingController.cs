using Microsoft.AspNetCore.Mvc;
using Art.Models;
using Art.ViewModels;

namespace Paintings.Controllers
{
    public class PaintingController : Controller
    {
        private readonly IPaintingRepository paintingRepository;
        private readonly IArtistRepository artistRepository;
      

        public PaintingController(IPaintingRepository paintingRepository, IArtistRepository artistRepository) 
        {
            this.paintingRepository = paintingRepository;
            this.artistRepository = artistRepository;   
        }

        public IActionResult AllPainting()
        {
            PaintingViewModel paintingViewModel = new PaintingViewModel();
            paintingViewModel.Paintings = paintingRepository.AllPainting;
            paintingViewModel.ArtistName = "Sonja Brussen";
            return View(paintingViewModel);
        }

    }
}
