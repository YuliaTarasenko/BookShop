using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Storage
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } //дата создания записи на складе
        public decimal CostPrice { get; set; } //себестоимость книги
        public decimal Quantity { get; set; } //количество книг
        public virtual Book Book { get; set; }
        public virtual PublishingCompany Publisher { get; set; }
    }
}
