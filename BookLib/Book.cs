using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLib
{
    public class Book : AbstractItem
    {

        public Book(string name, string author, double price, double discount, int quantityInStock, DateTime productionDate,  long isbn,Categories categories, DateTime addingDate, int copyNumber, string edition) : base(name, author, price, discount, quantityInStock, productionDate,  isbn, categories, addingDate)
        {
            CopyNumber = copyNumber;
            Edition = edition;
        }

        public int CopyNumber { get; set; }
        public string Edition { get; set; }







    }
}
