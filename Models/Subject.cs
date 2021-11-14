using System.Collections.Generic;
using System.ComponentModel;

namespace BookShop.Models
{
    public class Subject
    {
        public Subject()
        {
            Books = new List<Book>();
        }
        public int Id { get; set; }
        [DisplayName("Тематика книжки")]
        public string Name { get; set; } //тематика
        public virtual ICollection<Book> Books { get; set; }
    }
}
