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
    /// Interaction logic for RegisterUC.xaml
    /// </summary>
    public partial class RegisterUC : UserControl
    {
        public RegisterUC()
        {
            InitializeComponent();
        }

       

        //private void RegisterClick(object sender, RoutedEventArgs e)
        //{
        //    int newIndex = mainRegister.sample.SelectedIndex + 1;
        //    if (newIndex >= mainRegister.sample.Items.Count)
        //        newIndex = 0;
        //    mainRegister.sample.SelectedIndex = newIndex;
        //}

        //private void LogIn_click(object sender, RoutedEventArgs e)
        //{
        //        while (registerViewModel.CustomerPermisions == true)
        //        {
        //            AddJournalButton.IsEnabled = false;
        //        }

        //}
    }
}
