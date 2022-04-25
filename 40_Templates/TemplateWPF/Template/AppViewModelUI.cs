using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public partial class AppViewModel : Observable
    {
        // Commands

        public DelegateCommand ComCalcSum
            => new DelegateCommand(CalcSum, CanCalcSum);


        // All variables that are set on the GUI

        private int _result;
        public int result
        {
            get { return _result; }
            set { Set(ref _result, value); }
        }


        private int _value1;
        public int value1
        {
            get { return _value1; }
            set { Set(ref _value1, value); }
        }

        private int _value2;
        public int value2
        {
            get { return _value2; }
            set { Set(ref _value2, value); }
        }


    }
}
