using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string con1 = "Hello, my name is Heather. ";
            string con2 = "I live in Nova Scotia, Canada.";

            Console.WriteLine(con1 + con2 + "  I have a kitten named, Phoebe.");

            string province = "On";
            Console.WriteLine("I lived in Toronto, " + province.ToUpper() + " for many years.");

            StringBuilder sb = new StringBuilder();

            sb.AppendLine();
            sb.Append("The terror, which would not end for another twenty-eight years --");
            sb.Append("if it ever did end - began, so far as I now or can tell,");
            sb.Append("with a boat made from a sheet of newspaper floating down a gutter swollen with rain.");
            sb.AppendLine();
            sb.AppendLine();
            sb.Append("\"It\" - Stephen King");

            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
