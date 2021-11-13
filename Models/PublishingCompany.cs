using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class PublishingCompany
    {
        public PublishingCompany()
        {
            Autors = new List<Autor>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Autor> Autors { get; set; }
    }
}
