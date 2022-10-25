using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfLibrary.Interfaces;
using WpfLibrary.ViewModel;

namespace WpfLibrary.Service
{
    internal class DataService : IChangeView
    {
        public Action<int> action { get; set; }
    }
}
