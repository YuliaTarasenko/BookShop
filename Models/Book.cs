using System.Collections.Generic;
using System.ComponentModel;

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
        [DisplayName("Назва книжки")]
        public string Name { get; set; }
        [DisplayName("Кількість сторінок")]
        public int Pages { get; set; } //количество страниц
        [DisplayName("Рік видання")]
        public int PublishedYear { get; set; }
        [DisplayName("Ім'я автора")]
        public virtual Autor Autor { get; set; }
        [DisplayName("Жанр")]
        public virtual ICollection<Genre> Genres { get; set; }
        [DisplayName("Тематика книжки")]
        public virtual ICollection<Subject> Subjects { get; set; }

        //public int AutorId { get; set; }
        //public int GenreId { get; set; }
        //public int PublisherId { get; set; }
        //public int SubjectId { get; set; }
        //public int BookGenreId { get; set; }
        //public int BookSubjectId { get; set; }
    }
}
