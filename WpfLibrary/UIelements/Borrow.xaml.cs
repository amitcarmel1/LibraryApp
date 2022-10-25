using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BookLib;
using WpfLibrary.ViewModel;

namespace WpfLibrary.UIelements
{
    /// <summary>
    /// Interaction logic for Borrow.xaml
    /// </summary>
    public partial class Borrow : UserControl
    {
        //FilterViewModel filterViewModel = new FilterViewModel();
        public Borrow()
        {
            InitializeComponent();
            cmbGenres.ItemsSource = Enum.GetValues(typeof(Categories)).Cast<Categories>();
            //cmbAuthor.ItemsSource = filterViewModel.ListAutors();
        }

        //private void cmbGenres_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    object o = e.AddedItems[0];
        //    Categories c = (Categories)o;
        //    filterViewModel.FilterByJaner(c);
        //    lv.ItemsSource = filterViewModel.filteredList;
        //}

        //private void cmbAuthor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    object o = e.AddedItems[0];
        //    string s = o.ToString();
        //    filterViewModel.FilterByAutor(s);
        //    lv.ItemsSource = filterViewModel.filteredList;
        //}

        //private void cmbPrice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lv.ItemsSource);
        //    view.SortDescriptions.Add(new SortDescription("Price", ListSortDirection.Ascending));
        //}

        //private void ShowAll_Click(object sender, RoutedEventArgs e)
        //{
        //    lv.ItemsSource = filterViewModel.itemcollection;
        //}

        //private void lvSelectedItm(object sender, SelectionChangedEventArgs e)
        //{
        //    object o= e.AddedItems[0];
        //    AbstractItem ai = (AbstractItem)o;
        //    filterViewModel.SelectHandaling(ai);

        //}

        //public void CreateLv()
        //{
        //    sc.ItemsSource = filterViewModel.ShoppingChart;
        //    sc.SetValue(Grid.RowProperty, 1);
        //    sc.SetValue(Grid.ColumnProperty, 2);
        //    sc.DisplayMemberPath = "Name";
        //    sc.Background = Brushes.Transparent;
        //    sc.Foreground = Brushes.White;
        //    sc.Height = 500;
        //    sc.Width = 200;
        //    sc.FontSize = 20;
        //    sc.FontWeight = FontWeights.Bold;
        //    sc.SelectedItem = selectedItem;
        //    grid.Children.Add(sc);
        //}
        //private void scRemoveItem(object sender, SelectionChangedEventArgs e)
        //{
            
        //    object o = e.AddedItems[0];
        //   = (AbstractItem)o;
        //    filterViewModel.RemoveWhenTabbed(ai);
        //    return;
            
        //}

    }
}
