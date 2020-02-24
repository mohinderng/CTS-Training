using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleApp1CreateXmlFile
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static void CreateXmlDemo()
        {
            XmlDocument doc = new XmlDocument();

            XmlDeclaration xmlDec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);

            XmlElement root = doc.Documen;
            doc.InsertBefore(xmlDec, root);

            XmlElement element1 = doc.CreateElement(string.Empty, "Products", string.Empty);
            doc.AppendChild(element1);

            XmlElement element2 = doc.CreateElement(string.Empty, "Ptitle", string.Empty);

            XmlText text1 = doc.CreateTextNode("Laptop");

            element1.AppendChild(element2);
            element2.AppendChild(element3);
            element2.AppendChild(text1);


            XmlElement element4 = doc.CreateElement(string.Empty, "Price", string.Empty);
            XmlText text2 = doc.CreateTextNode("45000");
            element4.AppendChild(text2);
            element2.AppendChild(element4);

            doc.Save(Directory.GetCurrentDirectory() + "//product.xml");
        }
    }
}
