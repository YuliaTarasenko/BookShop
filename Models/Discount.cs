using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public DateTime Start { get; set; } //начало скидки
        public DateTime End { get; set; } //конец
        public decimal Reduction { get; set; } //размер скидки
        public bool IsPercent { get; set; } //процентная или нет

        //public DateTime Create { get; set; } //дата создания
        //public int PersonId { get; set; } //кто создал эту скидку
    }
}
