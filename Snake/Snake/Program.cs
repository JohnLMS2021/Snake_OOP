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
            Point p = new Point(5, 6, '*');
            p.Draw();
            Snake snake = new Snake(p, 5, Direction.RIGHT);
            snake.Draw();

            HorizontalLine hLine1 = new HorizontalLine(2, 117, 28, '+');
            hLine1.Draw();
            HorizontalLine hLine2 = new HorizontalLine(2, 117, 1, '+');
            hLine2.Draw();
            VerticalLine vLine1 = new VerticalLine(1, 28, 117, '+');
            vLine1.Draw();
            VerticalLine vLine2 = new VerticalLine(1, 28, 1, '+');
            vLine2.Draw();

            Console.ReadLine();
        }
    }
}
