namespace basicapi
{
    public class EndPointOne
    {
        public int Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Type { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string Filename { get; set; } = String.Empty;
        public double Price { get; set; } = 0;
        public int Rating { get; set; } = 0;
    }
}