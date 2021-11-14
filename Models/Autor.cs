using System;
using System.ComponentModel;

namespace BookShop.Models
{
    public class Autor
    {
        public int Id { get; set; }
        [DisplayName("Ім'я автора")]
        public string Name { get; set; }
        [DisplayName("Дата народження")]
        public DateTime BirthYear { get; set; }
        [DisplayName("Видавництво")]
        public virtual PublishingCompany Publisher { get; set; }
    }
}
