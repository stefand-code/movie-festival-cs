namespace MovieFestival
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Length { get; set; } 

        public Movie(string title, string genre, int length)
        {
            Title = title;
            Genre = genre;
            Length = length;
        }

        public string GetData()
        {
            return $"Title: {Title}, Length: {Length}, Genre: {Genre}";
        }
    }
}
