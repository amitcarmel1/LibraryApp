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

namespace WpfLibrary.UIelements
{
    /// <summary>
    /// Interaction logic for AddBookUc.xaml
    /// </summary>
    public partial class AddBook : UserControl
    {
        public AddBook()
        {
            InitializeComponent();
            cmbCategory.ItemsSource = Enum.GetValues(typeof(Categories)).Cast<Categories>();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }



        //private void TextBlock_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    MessageBox.Show(" Adventure = 1 \n Fantasy = 2 \n  Horror = 4 \n Romance = 8 \n Science Fiction = 16 \n Poetry = 32 \n (sum for more than one) ");
        //}
    }
}
