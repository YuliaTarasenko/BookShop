using System.Collections.Generic;
using System.ComponentModel;

namespace BookShop.Models
{
    public class PublishingCompany
    {
        public PublishingCompany()
        {
            Autors = new List<Autor>();
        }
        public int Id { get; set; }
        [DisplayName("Назва видавництва")]
        public string Name { get; set; }
        [DisplayName("Автори")]
        public virtual ICollection<Autor> Autors { get; set; }
    }
}
