using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Price { get; set; } //цена
        public DateTime Date { get; set; } //дата покупки
        public virtual Storage Storage { get; set; } //склад
        public virtual Discount Discount { get; set; } //скидка

        //public virtual User User { get; set; }
    }
}
