using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinForms.Interfaces;

namespace XamarinForms.Services
{
    public class DataService : IDataServices
    {
        public List<string> _names;

        public DataService()
        {
            _names = new List<string>
            {
                "Mohammes", "Hassan", "ali", "Denis"
            };
        }

        public void AddNames(string s)
        {
            _names.Add(s);
        }

        public List<string> GetNames()
        {
            return _names;
        }

        
    }
}
