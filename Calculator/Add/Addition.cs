using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Add
{
    public class Addition
    {
        private readonly int _firstnumber;
        private readonly int _secondnumber;

        public Addition()
        {

        }

        public Addition(int firstnumber, int secondnumber)
        {
            _firstnumber = firstnumber;
            _secondnumber = secondnumber;
        }

        public int Calculate()
        {
            if (_firstnumber <= 0 || _secondnumber <= 0) return 0;
            return _firstnumber + _secondnumber; 
        }

    }
}
