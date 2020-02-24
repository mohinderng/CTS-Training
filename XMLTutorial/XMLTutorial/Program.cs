using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace XMLTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmld = new XmlDocument();
            XmlNodeList xmlnode;
            int i = 0;
            string str = null;

            FileStream fs = new FileStream(@"D:\HTML Mohinder\C#\XMLTutorial\XMLTutorial\XMLFile1.xml", FileMode.Open,FileAccess.Read);
            xmld.Load(fs);
            xmlnode = xmld.GetElementsByTagName("Book");

            for(i=0;i<=xmlnode.Count-1;i++)
            {
                xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                str = xmlnode[i].ChildNodes.Item(0).InnerText.Trim() + " " +
                      xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + " " +
                      xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
                Console.WriteLine(str);
            }

            void Xmldemo()
            {
                XmlNode currentnode = xmld.DocumentElement.FirstChild;
                Console.WriteLine(currentnode.OuterXml);

                XmlNode nextnode = currentnode.NextSibling;
                Console.WriteLine(nextnode.OuterXml);

                XmlNode node3 = nextnode.NextSibling;
                Console.WriteLine(node3.OuterXml);
            }
        }
    }
}
