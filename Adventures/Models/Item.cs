namespace Adventures.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public int TypeId { get; set; }
        public ItemType Type { get; set; }
    }
}
