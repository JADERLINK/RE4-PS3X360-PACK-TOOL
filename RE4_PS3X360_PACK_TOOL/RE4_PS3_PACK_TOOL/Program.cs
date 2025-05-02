using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE4_PS3_PACK_TOOL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("# RE4 PS3 PACK TOOL");
            Console.WriteLine("# By: JADERLINK");
            Console.WriteLine("# youtube.com/@JADERLINK");
            Console.WriteLine("# github.com/JADERLINK");
            Console.WriteLine("# VERSION 1.1.0 (2025-05-02)");

            RE4_PS3X360_PACK_SHARED_PROJECT.MainProgram.Continue(args, true);
        }
    }
}
