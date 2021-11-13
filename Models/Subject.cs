using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Subject
    {
        public Subject()
        {
            Books = new List<Book>();
        }
        public int Id { get; set; }
        public string Name { get; set; } //тематика
        public virtual ICollection<Book> Books { get; set; }
    }
}
