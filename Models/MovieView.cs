using System.ComponentModel.DataAnnotations;

namespace Project7ASP.NETCoreMVC.Models
{
    public class MovieView
    {
        [Required]
        public string Title { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Director { get; set; } = string.Empty;




    }

    public static class MovieViewMapper
    {
        public static Movie ToMovie(this MovieView newMovie)
        {

            return new Movie(newMovie.Title, newMovie.Year, newMovie.Director);
        }
    }
}
}
