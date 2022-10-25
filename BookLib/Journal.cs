using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLib
{
    public class Journal : AbstractItem
    {
        public Journal(string name, string author, double price, double discount, int quantityInStock, DateTime productionDate,  string edition, long isbn,Categories categories, DateTime addingDate, int copyNumber) : base(name, author, price, discount, quantityInStock, productionDate, isbn, categories, addingDate)
        {
            CopyNumber = copyNumber;
            Edition = edition;
            //Journal_Categories = journalCategories;
        }

        //public List<JournalCategories> Category { get; set; }

        public int CopyNumber { get; set; }
        public string Edition { get; set; }
       // public Categories Journal_Categories { get; set; }

    }
}
