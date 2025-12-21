using System.Collections.Generic;
using Project7ASP.NETCoreMVC.Services;


namespace Project7ASP.NETCoreMVC.Models
{
    public class OverviewModel
    {
        public IMovieService _movieService;

        
        public MovieView MovieInput { get; set; } = new();//For the form


        public OverviewModel(IMovieService movieService)
        {
            _movieService = movieService;
        }


        public List<Movie> MovieList { get; set; } = new();// = new() IS setting a default value!!



        /*
        public void OnGet()
        {
            MovieList = _movieService.GetAllMovies();



        }

        
        public IActionResult Index()
        {
            if (!ModelState.IsValid)
            {
                // Return the same page to show validation messages
                return Page();
            }
            Movie newMovie = MovieInput.ToMovie();
            _movieService.AddMovie(newMovie);
            return RedirectToPage();//rerun the OnGet
        }
        */
    }
}
