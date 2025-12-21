using Microsoft.AspNetCore.Mvc;
using Project7ASP.NETCoreMVC.Models;
using Project7ASP.NETCoreMVC.Services;
using System.Diagnostics;

namespace Project7ASP.NETCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMovieService _movieService;

        [BindProperty]
        public MovieView MovieInput { get; set; } = new();//For the form

        public List<Movie> MovieList { get; set; } = new();// = new() IS setting a default value!!

        public HomeController(ILogger<HomeController> logger, IMovieService movieservice)
        {
            _logger = logger;
            _movieService = movieservice;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //home/overview
        [HttpPost]
        public IActionResult Overview()
        {
            if (!ModelState.IsValid)
            {
                // Return the same page to show validation messages
                return View();
            }
            Movie newMovie = MovieInput.ToMovie();
            _movieService.AddMovie(newMovie);
            return RedirectToAction();//rerun the OnGet

            MovieList = _movieService.GetAllMovies();

        }
        
        //home/MovieDetails
        public IActionResult MovieDetails()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
