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
        public List<string> GetNames()
        {
            var names = new List<string>
            {
                "Mohammes", "Hassan", "ali", "Denis"
            };
            return names;
        }

        
    }
}
