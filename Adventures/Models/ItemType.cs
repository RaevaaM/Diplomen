namespace Adventures.Models
{
    public class ItemType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        ICollection<Item> Items { get; set; }
    }
}
