using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> cList = new List<char>();
            cList.Add('*');
            cList.Add('#');
            cList.Add('@');
            cList.Add('%');

            Point p1 = new Point(1, 3, cList[0]);
            Point p2 = new Point(4, 5, cList[1]);
            Point p3 = new Point(7, 9, cList[2]);
            Point p4 = new Point(9, 14, cList[3]);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            foreach (Point i in pList)
            {
                i.Draw();
            }

            Console.ReadLine();
        }
    }
}
