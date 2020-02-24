using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTask1
{
    public class Class1
    {
        public int n { get; set; }

        public string ReverseNumber()
        {
            int rem, reverse=0;
            while (n != 0)
            {

                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            return string.Format("The reverse of number is : {0}",reverse);
        }


    }
}
