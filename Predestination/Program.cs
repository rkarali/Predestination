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
            Console.WriteLine("Matris'in genişliği?");
            y = Convert.ToInt32(Console.ReadLine());
            List<Point> pointList = new List<Point>(x * y);
            Random rand = new Random();
            for(int i = 0; i< x; i++)
            {
                for(int j =0; j<y; j++)
                {
                    Point point = new Point
                    {
                        x = i,
                        y = j,
                        value = rand.Next(0,2)
                    };
                    pointList.Add(point);
                }
            }
            foreach(var point in pointList)
            {
                Console.WriteLine("x : {0} , y: {1}, value: {2} ",point.x,point.y,point.value);
            }

            var result = IsThereAnExit(pointList);
            string str = result ? " var.." : " yok..";
            Console.WriteLine("Çıkış" + str);
            Console.ReadKey();
        }
        
        public static bool IsThereAnExit(List<Point> pointList)
        {
            return true;
        }
    }
}
