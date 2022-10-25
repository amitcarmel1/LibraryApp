using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLib
{
    public abstract class AbstractItem
    {
        public AbstractItem(string name, string author, double price, double discount, int quantityInStock, DateTime productionDate,  long isbn , Categories categories, DateTime addingDate)
        {
            Name = name;
            Author = author;
            Price = price;
            Discount = discount;
            QuantityInStock = quantityInStock;
            ProductionDate = productionDate;
            ISBN = isbn;
            Categories = categories;
            AddingDate = addingDate;

        }
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public int QuantityInStock { get; set; }
        public DateTime ProductionDate { get; set; }

        public long ISBN { get; set; }
        public Categories Categories { get; set; }
        public DateTime AddingDate { get; set; }
    }
}
