using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XMLLinq
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void CreateXmlWithLinq()
        {
            XDocument doc = new XDocument(new XElement("Items",
                                          new XElement("Item",
                                          new XElement("ItemName","Cake"),
                                          new XElement ("Price","250")),
                                          new XElement )
        }
    }
}
