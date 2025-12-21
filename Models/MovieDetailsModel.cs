using Microsoft.AspNetCore.Mvc;
using Project7ASP.NETCoreMVC.Services;

namespace Project7ASP.NETCoreMVC.Models
{
    public class MovieDetailsModel
    {
        public IMovieService _movieService;
        public MovieDetailsModel(IMovieService movieService)
        {
            _movieService = movieService;
        }
        

        public Movie ExistingMovie { get; set; }

        /*
        public IActionResult OnGet(Guid Id)
        {
            ExistingMovie = _movieService.GetById(Id);
            return View();
        }
        */
        [HttpPost]
        public IActionResult Index(Guid Id)
        {
            ExistingMovie = _movieService.GetById(Id);
            return View();
        }
    }
}
