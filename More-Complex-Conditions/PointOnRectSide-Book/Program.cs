﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnRectSide_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            var onSideLeftOrRight = (x == x1 || x == x2) && (y >= y1) && (y <= y2);
            var onSideUpperOrLower = (y == y1 || y == y2) && (x >= x1) && (x <= x2);

            if (onSideLeftOrRight || onSideUpperOrLower)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }


            //  if ((x == x1 || x == x2) && (y >= y1 && y <= y2) || (y == y1 || y == y2) && (x >= x1 && x <= x2))
            //  {
            //      Console.WriteLine("Border");
            //  }
            //  else
            //  {
            //      Console.WriteLine("Inside / Outside");
            //  }

        }
    }
}
