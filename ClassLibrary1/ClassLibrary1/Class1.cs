    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public int No1 { get; set; }
        public int No2 { get; set;}

        public string Add()
        {
            return string.Format("Sum ={0}", No1 + No2);
        }

        public string Difference()
        {
            return string.Format("Difference = {0}", No1 - No2);
        }

        public string Multiply()
        {
            return string.Format("Product = {0}", No1 * No2);
        }

        public string Division()
        {
            return string.Format("Quotient = {0}", No1 / No2);
        }
    }
}
