using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 6, '*');

            p1.Draw();

            Point p2 = new Point(6, 7, '#');

            p2.Draw();

            HorizontalLine hLine1 = new HorizontalLine(3, 10, 9, '+');
            hLine1.Draw();
            HorizontalLine hLine2 = new HorizontalLine(3, 10, 3, '+');
            hLine2.Draw();
            VerticalLine vLine1 = new VerticalLine(3, 8, 10, '+');
            vLine1.Draw();
            VerticalLine vLine2 = new VerticalLine(3, 8, 3, '+');
            vLine2.Draw();


            Console.ReadLine();
        }
    }
}
