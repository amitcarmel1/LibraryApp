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
    /// Interaction logic for AddItemUC.xaml
    /// </summary>
    public partial class AddItemUC : UserControl
    {
        public AddItemUC()
        {
            InitializeComponent();
            cmbCategory.ItemsSource = Enum.GetValues(typeof(Categories)).Cast<Categories>();
        }
    }
}
