using Microsoft.CodeAnalysis;

namespace Adventures.Data
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SportActivityId { get; set; }
        public SportActivity SportsActivities { get; set; }

        public int LocationId { get; set; }
        public Location Locations { get; set; }
        public ICollection<EventReservation> EventReservations { get; set; }
    }
}
