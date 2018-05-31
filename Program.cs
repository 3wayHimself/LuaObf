using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "LuaObf";
            Console.WriteLine("Loading LuaObf . . .");
            Obfuscator obfuscator = new Obfuscator();
            Console.WriteLine("Selected Lua Version: 5.1");
            Console.Write("Enter the File Path for LuaObf to Obfuscate: ");
            string path = Console.ReadLine();
            Console.Title = "LuaObf : Obfuscating: " + path;
            string input = File.ReadAllText(@path);
            Console.WriteLine(obfuscator.Obfuscate(input));
            string halt = Console.ReadLine();
        }
    }
}
