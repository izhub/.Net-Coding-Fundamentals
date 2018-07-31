using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _15_AssembliesAndNamespaces
{
    class Program
    {
        //The .Net Framework class library is a collection of classes, each containing methods filled with functionalty
        // that we can utilitize. it's massive so was split into multiple files called .net assemblies 
        //even apps we make are compiling into .net assemblies, bin/debug folder contains additional files to 
        //connect to the compiled executable allowing us to pause and debug line by line
        static void Main(string[] args)
        {
            // Write one string to a text file.
            //string text = "A class is the most powerful data type in C#. Like a structure, " +
            //               "a class defines the data and behavior of the data type. ";
            
            //File.WriteAllText(@"C:\Users\Zahid\Documents\Visual Studio 2015\Projects\BTaborCodingFundamentals\15-AssembliesAndNamespaces\WriteText.txt", text);

            //https://msdn.microsoft.com/en-us/library/fhd1f0sw(v=vs.110).aspx
            WebClient client = new WebClient();
            string reply = client.DownloadString("Http://msdn.microsoft.com");

            Console.WriteLine(reply);

            //gets full page html to file
            File.WriteAllText(@"C:\Users\Zahid\Documents\Visual Studio 2015\Projects\BTaborCodingFundamentals\15-AssembliesAndNamespaces\WriteText.txt", reply);

            Console.ReadLine();
        }
    }
}
