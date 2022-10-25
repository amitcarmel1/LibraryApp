using BookLib;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using WpfLibrary.Interfaces;

namespace WpfLibrary.ViewModel
{
    public class TextBoxViewModel : ViewModelBase
    {
        ItemCollection itemCollection = new ItemCollection();
        public ObservableCollection<AbstractItem> AddedItemList { get; set; } = new ObservableCollection<AbstractItem>();
        public ObservableCollection<AbstractItem> RemovedItemList { get; set; } = new ObservableCollection<AbstractItem>();
        public ObservableCollection<AbstractItem> RemovedItemToShow { get; set; } = new ObservableCollection<AbstractItem>();
        public ObservableCollection<AbstractItem> BorrowedItemsList { get; set; } = new ObservableCollection<AbstractItem>();
        public ObservableCollection<AbstractItem> itemcollection { get; set; } = new ObservableCollection<AbstractItem>();
        public List<AbstractItem> ItemsToDiscount = new List<AbstractItem>();

        public bool Checked { get; set; }
        private string name;
        private string author;
        private double price;
        private double discount;
        private int quantityInStock;
        private DateTime productionDate;
        private long iSBN;
        private int copyNumber;
        private string edition;
        private Categories categories;
        private int num;
        private IChangeView changeView;
        private DateTime addingDate;
        private DateTime fromDate;
        private DateTime toDate;
        private Categories _selectedCategory;
        private int selectedItemToDiscount;
        private int discountInsert;
        private int quantityInsert;
        private RegisterViewModel rvm;
        private FilterViewModel fvm;
        private Visibility isVisibleForCustomer;
        private Visibility isVisibleForWorker;

        public RelayCommand AddBookCommand { get; set; }
        public RelayCommand AddJournalCommand { get; set; }
        public RelayCommand AddItemChoose { get; set; }
        public RelayCommand DeleteItemChoose { get; set; }
        public RelayCommand ReportChoose { get; set; }
        public RelayCommand DeleteJournalCommand { get; set; }
        public RelayCommand DeleteBookCommand { get; set; }
        public RelayCommand ViewActionsCommand { get; set; }
        public RelayCommand ReturnCommand { get; set; }
        public RelayCommand ApplyCommand { get; set; }

        public string Name { get => name; set => Set(ref name, value); }
        public string Author { get => author; set => Set(ref author, value); }
        public double Price { get => price; set => Set(ref price, value); }
        public double Discount { get => discount; set => Set(ref discount, value); }
        public int QuantityInStock { get => quantityInStock; set => Set(ref quantityInStock, value); }
        public DateTime ProductionDate { get => productionDate; set => Set(ref productionDate, value); }
        public long ISBN { get => iSBN; set => Set(ref iSBN, value); }
        public int CopyNumber { get => copyNumber; set => Set(ref copyNumber, value); }
        public string Edition { get => edition; set => Set(ref edition, value); }
        public Categories Categories { get => categories; set => Set(ref categories, value); }
        public int Num { get => num; set => Set(ref num, value); }
        public DateTime FromDate { get => fromDate; set => Set(ref fromDate, value); }
        public DateTime ToDate { get => toDate; set => Set(ref toDate, value); }
        public int DiscountInsert { get => discountInsert; set => Set(ref discountInsert, value); }
        public int QuantityInsert { get => quantityInsert; set => Set(ref quantityInsert, value); }
        public int SelectedItemsToDiscount
        {
            get { return selectedItemToDiscount; }
            set
            {
                selectedItemToDiscount = value;
                ItemsToDiscount.Add(itemcollection[selectedItemToDiscount]);
            }
        }


        public Categories SelectedCategory
        {
            get { return _selectedCategory; }
            set
            {
                _selectedCategory = value;
                Categories = _selectedCategory;
            }
        }

        public DateTime AddingDate
        {
            get { return addingDate; }
            set
            {
                addingDate = DateTime.Now;
            }
        }

        public void example(int exnum)
        {
            Num = exnum;
        }
        public TextBoxViewModel(IChangeView changeView, RegisterViewModel RVm, FilterViewModel fvm)
        {
            this.rvm = RVm;
            this.fvm = fvm;
            Insert(itemCollection.itemsList);
            this.changeView = changeView;
            this.changeView.action += example;
            AddBookCommand = new RelayCommand(AddBook);
            AddJournalCommand = new RelayCommand(AddJournal);
            AddItemChoose = new RelayCommand(AddItem);
            DeleteItemChoose = new RelayCommand(DeleteItem);
            ReportChoose = new RelayCommand(ReportProduction);
            DeleteJournalCommand = new RelayCommand(Delete);
            DeleteBookCommand = new RelayCommand(Delete);
            ViewActionsCommand = new RelayCommand(ViewActions);
            ReturnCommand = new RelayCommand(Return);
            ApplyCommand = new RelayCommand(Apply);
        }
        
        public void LoginCustomerToLib()
        { 
            if (rvm.workerPermisions== false && rvm.CustomerPermisions == false)
            {
                IsVisibleForWorker = Visibility.Collapsed;
                IsVisibleForCustomer = Visibility.Collapsed;

            }
            if (rvm.workerPermisions==true)
            {
                IsVisibleForWorker = Visibility.Visible;
                IsVisibleForCustomer = Visibility.Collapsed;
               
            }
            if (rvm.CustomerPermisions == true)
            {
                IsVisibleForWorker = Visibility.Collapsed;
                IsVisibleForCustomer = Visibility.Visible;
            }
        }
        public Visibility IsVisibleForCustomer
        {
            get { return isVisibleForCustomer; }  set => Set(ref isVisibleForCustomer, value);
        }
        public Visibility IsVisibleForWorker
        {
            get { return isVisibleForWorker;  }
            set => Set(ref isVisibleForWorker, value);
        }
        private void Apply()
        {
            if(rvm.workerPermisions==false)
            {
                MessageBox.Show("you have no permisions here");
                foreach (var item in ItemsToDiscount)
                {
                    ItemsToDiscount.Remove(item);
                }
                changeView.action.Invoke(0);
            }
            else
            {
                double tryDis = DiscountInsert / 100.0;
                foreach (var item in ItemsToDiscount)
                {
                    item.Discount = item.Price * tryDis;
                    if (itemCollection[item.Name] != default)
                    {
                        itemCollection[item.Name].Discount = item.Discount;
                    }
                }
            }
           
        }

        public void Insert(List<AbstractItem> itemsList)
        {
            foreach (var item in itemcollection)
            {
                itemcollection.Remove(item);
            }
            itemsList.ForEach(itemcollection.Add);
        }
        public bool IfExist()
        {
            foreach (var item in rvm.custList.Find(cust => cust.Name == rvm.Name).BorrowedItemslist)
            {
                if (item.Name == name)
                {
                    rvm.custList.Find(cust => cust.Name == rvm.Name).BorrowedItemslist.Remove(item);
                    return true;
                }
            }
            return false;
        }
        private void Return()
        {
            if (IfExist())
            {
                MessageBox.Show("Thank You!");
            }

            else
                MessageBox.Show("This Item does Not exist in you borrowing history, sorry");
        }

        private void ViewActions()
        {
           
                AddedItemList.Clear();
                RemovedItemToShow.Clear();
                foreach (var item in itemCollection.itemsList)
                {
                    if (item.AddingDate > FromDate && item.AddingDate < ToDate)
                        AddedItemList.Add(item);
                }
                //foreach (var item in RemovedItemList)
                //{
                //    if (item.AddingDate > FromDate && item.AddingDate < ToDate)
                //        RemovedItemToShow.Add(item);
                //}
                        
        }

        public void RegexValidationForUrenDits(string nameToCheck, string priceToCheck, string quantityToCheck, string productionDateToCheck,string addingDateToCheck, string copyNumberToCheck)
        {
            if (!Regex.IsMatch(nameToCheck, "[a-zA-Z]+"))
            {
                throw new Exception ();
            }
            if (!Regex.IsMatch(priceToCheck, @"^\d+(,\d{1,2})?$"))
            {
                throw new Exception();
            }
            if ((!Regex.IsMatch(quantityToCheck, @"^\d+$")) || QuantityInStock < 0)
            {
                throw new Exception();
            }
            if ((!Regex.IsMatch(copyNumberToCheck, @"^[0-9]+$")) || copyNumber < 0)
            {
                throw new Exception();
            }



        }
        private void Delete()
        {
            if (rvm.workerPermisions == false)
            {
                MessageBox.Show("you have no permisions here");
                changeView.action.Invoke(0);
                return;

            }
            try
            {
                RegexValidationForUrenDits(name, price.ToString(), quantityInStock.ToString(), productionDate.ToString(), addingDate.ToString(), copyNumber.ToString());

            }
            catch (Exception)
            {

                MessageBox.Show("Not a valid input");
                return;
            }

            if (itemCollection[Name] != default)
            {
                AbstractItem tmp = itemCollection.itemsList.Find(item => item.Name == this.Name);

                if (itemCollection.itemsList.Find(item => item.Name == this.Name).QuantityInStock==quantityInsert)
                itemCollection.itemsList.Remove(itemCollection.itemsList.Find(item => item.Name == this.Name));

                if (itemCollection.itemsList.Find(item => item.Name == this.Name).QuantityInStock < quantityInsert)
                {
                    MessageBox.Show($"we only have {itemCollection.itemsList.Find(item => item.Name == this.Name).QuantityInStock} copies from this item");
                    return;
                }
                if (itemCollection.itemsList.Find(item => item.Name == this.Name).QuantityInStock > quantityInsert)
                    itemCollection.itemsList.Find(item => item.Name == this.Name).QuantityInStock = itemCollection.itemsList.Find(item => item.Name == this.Name).QuantityInStock - quantityInsert;


                    tmp.AddingDate = DateTime.Now;
                    RemovedItemList.Add(tmp);
            }
            else
            {
                MessageBox.Show("This item does not exist");
            }
        }

        private void ReportProduction()
        {
            if (rvm.workerPermisions == false)
            {
                MessageBox.Show("you have no permisions here");
                changeView.action.Invoke(0);

            }
            else
            {
                changeView.action.Invoke(5);
            }
        }

        private void DeleteItem()
        {
            if (rvm.workerPermisions == false)
            {
                MessageBox.Show("you have no permisions here");
                changeView.action.Invoke(0);

            }
            else
            {
                changeView.action.Invoke(2);
            }
        }

        private void AddItem()
        {
            if (rvm.workerPermisions == false)
            {
                MessageBox.Show("you have no permisions here");
                changeView.action.Invoke(0);

            }
            else
            {
                changeView.action.Invoke(2);

            }
        }

      
        private void AddJournal()
        {
            if (rvm.workerPermisions == false)
            {
                MessageBox.Show("you have no permisions here");
                changeView.action.Invoke(0);
                return;
            }
            try
            {
                RegexValidationForUrenDits(name, price.ToString(), quantityInStock.ToString(), productionDate.ToString(), addingDate.ToString(), copyNumber.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Not a valid input");
                return;
            }

            if (itemCollection[Name] != default)
            {
                itemCollection[Name].QuantityInStock = itemCollection[Name].QuantityInStock+quantityInsert;
                MessageBox.Show($"{name} succesfully added!");
            }
            else
            {
                Journal journal = new Journal(Name, Author, Price, Discount, QuantityInStock=1, ProductionDate, Edition, ISBN, Categories, AddingDate, CopyNumber);
                itemCollection.itemsList.Add(journal);
            }

        }
        public void AddBook()
        {
            if (rvm.workerPermisions == false)
            {
                MessageBox.Show("you have no permisions here");
                changeView.action.Invoke(0);
                return;
            }
            try
            {
                RegexValidationForUrenDits(name, price.ToString(), quantityInStock.ToString(), productionDate.ToString(), addingDate.ToString(), copyNumber.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Not a valid input");
                return;
            }

            if (itemCollection[Name] != default)
            {
                itemCollection[Name].QuantityInStock = itemCollection[Name].QuantityInStock + quantityInsert;
                MessageBox.Show($"{name} succesfully added!");
            }

            else
            {

                Book book = new Book(Name, Author, Price, Discount, QuantityInStock=1, ProductionDate, ISBN, Categories, AddingDate, CopyNumber, Edition);
                
                itemCollection.itemsList.Add(book);
                MessageBox.Show($"{name} succesfully added!");

            }
        }
    }
}
