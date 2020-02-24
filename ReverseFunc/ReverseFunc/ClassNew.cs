using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseFunc
{
    public class ClassNew
    {
        public int n { get; set; }

        public string RevNumber()
        {
            int rem, reverse = 0;
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            return string.Format("The Reverse of number is {0}", reverse);
        }
    }
}
