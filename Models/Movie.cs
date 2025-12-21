namespace Project7ASP.NETCoreMVC.Models
{
    public class Movie
    {

        public Movie(string title, int year, string director)
        {
            Title = title;
            Year = year;
            Director = director;

        }

        public Guid ID { get; } = Guid.NewGuid();
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
    }
}
