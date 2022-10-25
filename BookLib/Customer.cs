using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLib
{
    public class Customer : Person
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public List<AbstractItem> BorrowedItemslist;
        public Customer()
        {
            BorrowedItemslist = new List<AbstractItem>();
        }

    }
}
