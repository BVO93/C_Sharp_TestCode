using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace INotifyExample.ViewModels
{
   public class PersonViewModel : ObservableObject
    {
        private string _name;

        public string Name
        {
        get
        {
            if(string.IsNullOrWhiteSpace(_name))
            return "Unknown";

            return _name;
        }
        set{
            _name = value;
            OnPropertyChanged("Name");
        }
        
        
        }


    }
}
