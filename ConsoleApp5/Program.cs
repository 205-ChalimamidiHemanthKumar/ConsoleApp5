using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Anil", "Sharma", "Abdullah",
                       "Imran", "Siva", "Naresh",
                       "Suresh", "Suman" };
            //UsingLINQReadXML()
            UsingLINQReadXml(names);
        }
        private static void UsingLINQReadXml(string[] names)
        {
            string myXML = @"<Departments>
                         <Department>Account</Department>
                         <Department>Sales</Department>
                         <Department>Pre-Sales</Department>
                         <Department>Marketing</Department>
                         </Departments>";
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);

            var result = xdoc.Element("Departments").Descendants();

            foreach (XElement item in result)
            {
                Console.WriteLine("Departments Name - " + item.Value);
            }

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}
