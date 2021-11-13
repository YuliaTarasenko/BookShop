using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthYear { get; set; }
        public virtual PublishingCompany Publisher { get; set; }
    }
}
