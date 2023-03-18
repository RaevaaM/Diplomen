namespace Adventures.Data
{
    public class Location
    {
        public int Id { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longtitude { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
