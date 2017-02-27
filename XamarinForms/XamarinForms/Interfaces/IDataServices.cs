using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinForms.Interfaces
{
    interface IDataServices
    {
        List<string> GetNames();
        void AddNames(string s);
    }
}
