using System;
using System.IO;

namespace esolangs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.ReadAllText("./input.txt"));
        }
    }
}
