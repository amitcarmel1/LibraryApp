using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLibrary.Interfaces
{
    public interface IChangeView
    {
        Action<int> action { get; set; }
    }
}
