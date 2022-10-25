using System;
using System.Collections.Generic;
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

namespace WpfLibrary.UIelements
{
    /// <summary>
    /// Interaction logic for usrFilter.xaml
    /// </summary>
    public partial class usrFilter : UserControl
    {
        //public  static event EventHandler<Object> CategorieChanged;
        
        public usrFilter()
        {
            InitializeComponent();
            cmbGenres.ItemsSource = Enum.GetValues(typeof(Categories)).Cast<Categories>();
            
        }

        public void cmbGenres_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

        }
    }
}
