﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine().ToLower());

           if (gender.Equals('m'))
            {
                if (age < 16) Console.WriteLine("Master");
                else Console.WriteLine("Mr.");
            }
           else if (gender.Equals('f'))
            {
                if (age < 16) Console.WriteLine("Miss");
                else Console.WriteLine("Ms.");
            }

        }
    }
}
