using Microsoft.AspNetCore.Mvc;
using Project7ASP.NETCoreMVC.Models;
using Project7ASP.NETCoreMVC.Services;

namespace Project7ASP.NETCoreMVC.Controllers
{
    public class MovieController : Controller
    {
        private readonly ILogger<MovieController> _logger;
        private readonly IMovieService _movieService;

        [BindProperty]
        public MovieView MovieInput { get; set; } = new();//For the form

        public List<Movie> MovieList { get; set; } = new();// = new() IS setting a default value!!

        public Movie ExistingMovie { get; set; }
        public MovieController(ILogger<MovieController> logger, IMovieService movieservice)
        {
            _logger = logger;
            _movieService = movieservice;
        }
        public IActionResult Index()
        {
            return View();
        }

        //Movie/overview
        [HttpPost]
        public IActionResult Overview(FormModel )
        {
            if (!ModelState.IsValid)
            {
                // Return the same page to show validation messages
                return View();
            }
            Movie newMovie = MovieInput.ToMovie();
            _movieService.AddMovie(newMovie);
            return RedirectToAction();
        }

        [HttpGet]
        public IActionResult Overview()
        {

            MovieList = _movieService.GetAllMovies();
            return View(MovieList);            
            
        }

        //Movie/MovieDetails
        [HttpGet]
        public IActionResult MovieDetails(Guid Id)
        {
            ExistingMovie = _movieService.GetById(Id);
            return View();
        }
    }
}
