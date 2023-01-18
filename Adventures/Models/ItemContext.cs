using Microsoft.EntityFrameworkCore;

namespace Adventures.Models
{
    public class ItemContext:DbContext
    {
        public ItemContext(): base("name=Items")
        {

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
    }
}
