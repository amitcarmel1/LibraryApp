using BookLib;
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
using WpfLibrary.ViewModel;

namespace WpfLibrary.UIelements
{
    /// <summary>
    /// Interaction logic for AddJournalUc.xaml
    /// </summary>
    public partial class AddJournalUc : UserControl
    {
        public AddJournalUc()
        {
            InitializeComponent();
            cmbCategory.ItemsSource = Enum.GetValues(typeof(Categories)).Cast<Categories>();
        }

        //private void JorCategories(object sender, MouseEventArgs e)
        //{
        //    MessageBox.Show(" Food = 1 \n Art = 2 \n News = 4 \n Fitness = 8 \n (sum for more than one) ");

        //}
        
        
}
}
