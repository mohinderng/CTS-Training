﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            DataLayer dl = new DataLayer();
            dl.GetData();
            Console.ReadKey();
            
        }

        
    }
}
