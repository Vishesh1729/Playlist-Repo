﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        // Datatype Conversion
        {
            int i = 100;
            float f = i;
            Console.WriteLine(f);
            float g = 100282821234222.43F;
            int h = (int)g;
            
            Console.WriteLine(h);

            // Parse and Try Parse
            string s = "100";
            int V = int.Parse(s);
            Console.WriteLine(V);

            string TRYPARSE = "100AV";
            int result = 0;
            int.TryParse(TRYPARSE, out result );
            Console.WriteLine(TRYPARSE);


        }
       
    }
}
