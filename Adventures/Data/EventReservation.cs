namespace Adventures.Data
{
    public class EventReservation
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public Event Events { get; set; }
        public int UserId { get; set; }
        public User Users { get; set; }
    }
}
