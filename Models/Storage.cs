using System;
using System.ComponentModel;

namespace BookShop.Models
{
    public class Storage
    {
        public int Id { get; set; }
        [DisplayName("Дата створення запису")]
        public DateTime CreateDate { get; set; } //дата создания записи на складе
        [DisplayName("Собівартість книжки")]
        public decimal CostPrice { get; set; } //себестоимость книги
        [DisplayName("Кількість книжок на складі")]
        public int Quantity { get; set; } //количество книг
        [DisplayName("Назва книжки")]
        public virtual Book Book { get; set; }
        [DisplayName("Назва видавництва")]
        public virtual PublishingCompany Publisher { get; set; }
    }
}
