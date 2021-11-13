using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Book
    {
        public Book()
        {
            Genres = new List<Genre>();
            Subjects = new List<Subject>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Pages { get; set; } //количество страниц
        public int PublishedYear { get; set; }
        public virtual Autor Autor { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }

        //public int AutorId { get; set; }
        //public int GenreId { get; set; }
        //public int PublisherId { get; set; }
        //public int SubjectId { get; set; }
        //public int BookGenreId { get; set; }
        //public int BookSubjectId { get; set; }
    }
}
