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
    /// Interaction logic for TopFiveUc.xaml
    /// </summary>
    public partial class TopFiveUc : UserControl
    {
         int num = 1;
       
        public TopFiveUc()
        {
            InitializeComponent();
            
        }
        

        private void prev_Click(object sender, RoutedEventArgs e)
        {
                num--;
            if (num < 1)
                num = 5;

            pic.Source = new BitmapImage(new Uri(@"Images/" + num + ".jpg", UriKind.Relative));
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            num++;
            if (num > 5)
                num = 1;

            pic.Source = new BitmapImage(new Uri(@"/Images/" + num + ".jpg", UriKind.Relative));
        }
    }
}
