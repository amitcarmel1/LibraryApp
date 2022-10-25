using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLib
{
    public class ItemCollection
    {
        public List<AbstractItem> itemsList;


        Book LifeOfFi = new Book("Life of fi", "Yann Martel", 16.69, 0, 1, new DateTime(2003, 5, 3), 9780156027328, Categories.Adventure, new DateTime(2022, 5, 4), 1, "first");
        Book GameofThrones = new Book("Game of Thrones", "George R. R. Martin ", 28.62, 0, 1, new DateTime(1996, 8, 1), 0345535529, Categories.Fantasy, new DateTime(2022, 5, 1), 1, "first");
        Book TheExorcist = new Book("The Exorcist", "William Peter Blatty", 31.47, 0, 1, new DateTime(2011, 10, 4), 006209436, Categories.Horror, new DateTime(2022, 5, 3), 1, "first");
        Book SevenDaysinJune = new Book("Seven Days in June", "Tia Williams", 16.78, 0, 1, new DateTime(2021, 7, 1), 9781538719107, Categories.Romance, new DateTime(2022, 5, 8), 1, "first");
        Book Ice = new Book("Ice", "Anna Kavan", 10, 0, 1, new DateTime(2006, 8, 7), 0720612683, Categories.Science_Fiction, new DateTime(2022, 4, 29), 1, "first");
        Book TheSunandHerFlowers = new Book("The Sun and Her Flowers", "Rupi Kaur", 20.44, 0, 1, new DateTime(2017, 10, 3), 1449486797, Categories.Poetry, new DateTime(2022, 5, 8), 1, "first");
        Journal FoodSensitivityJournal = new Journal("Food Sensitivity Journal", " Molly Brennand", 30, 0, 1, new DateTime(2018, 8, 14), "first", 144132772, Categories.Food, new DateTime(2022, 5, 9), 1);
        public ItemCollection()
        {
            itemsList = new List<AbstractItem>();
            itemsList.Add(LifeOfFi);
            itemsList.Add(GameofThrones);
            itemsList.Add(TheExorcist);
            itemsList.Add(SevenDaysinJune);
            itemsList.Add(Ice);
            itemsList.Add(TheSunandHerFlowers);
            itemsList.Add(FoodSensitivityJournal);
            //Insert(itemsList);
        }
       
        
        public AbstractItem this[long isbn]
        {
            get
            {
                return itemsList.Find(item => item.ISBN == isbn);
            }
        }
        public AbstractItem this[string name]
        {
            get
            {
                return itemsList.FirstOrDefault(item => item.Name == name);
            }
        }


        public AbstractItem this[int price, float discount]
        {
            get
            {
                return itemsList.Find(item => item.Price == price && item.Discount == discount);
            }
        }
        public void InsertItem(AbstractItem item)
        {
            itemsList.Add(item);
        }
       




    }
}
