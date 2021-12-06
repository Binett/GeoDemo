using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Add
{
    public class Addition
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        

        public Addition()
        {

        }

        public Addition(int firstnumber, int secondnumber)
        {
            FirstNumber = firstnumber;
            SecondNumber = secondnumber;
        }

        public int Calculate()
        {
            if (FirstNumber <= 0 || SecondNumber <= 0) return 0;
            return FirstNumber + SecondNumber; 
        }

    }
}
