using System.Collections.Generic;
using System.ComponentModel;

namespace BookShop.Models
{
    public class Genre
    {
        public Genre()
        {
            Books = new List<Book>();
        }
        public int Id { get; set; }
        [DisplayName("Жанр")]
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
