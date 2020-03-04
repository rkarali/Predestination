using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predestination
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            Console.WriteLine("Matris'in genişliği?");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Matris'in yüksekliği?");
            y = Convert.ToInt32(Console.ReadLine());
            Point[,] pointArray = new Point[x, y];
            Random rand = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Point point = new Point
                    {
                        x = i,
                        y = j,
                        value = rand.Next(0, 2),
                        anotherWay = true,
                        isVisited = false
                    };
                    pointArray[i, j] = point;
                }
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    pointArray[i, j].up = j-1 > 0;
                    pointArray[i, j].down = j+1 < y;
                    pointArray[i, j].left = i-1 > 0;
                    pointArray[i, j].right = i+1 < x;
                }
            }
            
            foreach (var point in pointArray)
            {
                Console.WriteLine("x : {0} , y: {1}, value: {2}, left: {3}, right: {4}, up: {5}, down: {6} ", point.x, point.y, point.value, point.left, point.right, point.up, point.down);
            }
            Console.ReadKey();
            var result = pointArray[x - 1, y - 1].value == 0 ? false : IsThereAnExit(pointArray);
            string str = result ? " var.." : " yok..";
            Console.WriteLine("Çıkış" + str);
            Console.ReadKey();
        }

        public static bool IsThereAnExit(Point[,] pointArray)
        {
            
            return true;
        }
    }
}
