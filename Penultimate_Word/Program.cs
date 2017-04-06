using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penultimate_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            
        using (StreamReader reader = File.OpenText(@"C:\Users\princ\Documents\Notes\CodeEval_PenultimateWord.txt"))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;

                    string[] words = line.Split(' ');

                            Console.WriteLine(words[(words.Length) - 2]);                    
        }
        
            Console.ReadKey();
            
        }
    }
}
