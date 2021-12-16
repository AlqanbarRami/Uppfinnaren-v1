using System.Collections.Generic;
using System.Linq;

namespace Art.Models
{
    public class MockPaintingRepository : IPaintingRepository
    {
        private readonly IArtistRepository IArtistRepository = new MockArtistRepository();

        public IEnumerable<Painting> AllPainting =>new List<Painting> { new Painting { PainingId=1 ,PaintingName= "Silence of nature",PaintingType="Oil Painting" , Length = 140 , Width = 100 , DrawingYear= "2020", Image = "https://d3rf6j5nx5r04a.cloudfront.net/ygDxGa-_V-LBxFPO1SkGf0BS4zc=/1120x0/product/5/0/75fffbcf840b4b0ca7844ce74a92d220_opt.jpg", Price = 280 },
        new Painting{PainingId=2, PaintingName="Lucky", PaintingType="Oil Painting" , Length=52, Width=42 , DrawingYear = "2021", Image= "https://d3rf6j5nx5r04a.cloudfront.net/C775hrN-B1Rl1djwrujZr7N2ESs=/1120x0/product/9/8/324997ae1ef14461ba1ee7ba552b6938_opt.jpg" , Price = 93 },
        new Painting { PainingId = 3 , PaintingName="Behind the scene", PaintingType = "Oil painting" , Length=52, Width = 42, DrawingYear="2021" , Image="https://d3rf6j5nx5r04a.cloudfront.net/XilzqOuifRkv1zKLP09iWR0eCO4=/1120x0/product/9/8/bfd0972cc5c74aab8b09a4087cdb944b_opt.jpg", Price = 180 }  };

        public Painting GetPainting(int PaintId)
        {
            return AllPainting.FirstOrDefault(s => s.PainingId == PaintId);
        }
    }
}
