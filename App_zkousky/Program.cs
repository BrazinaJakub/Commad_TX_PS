using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App_zkousky
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\PS_SDK\data.txt";
           

            string text = Environment.NewLine + "Here is more text for the file";

            System.IO.File.AppendAllText(path, text);
        }
    }
}
