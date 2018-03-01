using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLTestings
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../Doc/shiporders.xml");
            var rootNode = doc.DocumentElement;

            foreach (XmlNode node in rootNode.ChildNodes)
            {
               if(node.Name== "item")
                {
                    foreach (XmlNode childNode in node.ChildNodes)
                    {
                        Console.WriteLine($"{childNode.Name}:{childNode.InnerText}");
                    }
                }
            }

        }
    }
}
