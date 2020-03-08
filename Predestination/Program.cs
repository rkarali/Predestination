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
            int x;
            int y;
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
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.WriteLine("[{0},{1}]",pointArray[i,j].x, pointArray[i, j].y);
            //        Console.ReadLine();
            //        pointArray[i, j].left = i - 1 > 0 ? pointArray[i-1,j] : new Point() { anotherWay = false};
            //        Console.WriteLine("left: {0}", pointArray[i, j].left.anotherWay.ToString());
            //        Console.ReadLine();
            //        pointArray[i, j].right = i+1 < x ? pointArray[i+1,j]: new Point() { anotherWay = false };
            //        Console.WriteLine("right: {0}", pointArray[i, j].right.anotherWay.ToString());
            //        Console.ReadLine();
            //        pointArray[i, j].up = j - 1 > 0? pointArray[i, j-1]: new Point() { anotherWay = false };
            //        Console.WriteLine("up: {0}", pointArray[i, j].up.anotherWay.ToString());
            //        Console.ReadLine();
            //        pointArray[i, j].down = j + 1 < y? pointArray[i, j + 1] : new Point() { anotherWay = false };
            //        Console.WriteLine("down: {0}", pointArray[i, j].down.anotherWay.ToString());
            //        Console.ReadLine();
            //    }
            //}

            foreach (var point in pointArray)
            {
                Console.WriteLine("x : {0} , y: {1}, value: {2}", point.x, point.y, point.value);
            }
            Console.ReadKey();
            var refPointArray = pointArray;
            var result = (pointArray[x - 1, y - 1].value == 0 || pointArray[0,0].value == 0) ? false : IsThereAnExit(pointArray,refPointArray);
            string str = result ? " var.." : " yok..";
            Console.WriteLine("Çıkış" + str);
            Console.ReadKey();
        }

        public static bool IsThereAnExit(Point[,] pointArray, Point[,] refpointArray)
        {
            for(int x = 0; x<refpointArray.GetUpperBound(0),x++)
            {
                for (int y = 0; y < refpointArray.GetUpperBound(1), y++) {
                    if (pointArray[x, y].anotherWay == false)
                    {
                        return false;
                    }
                    else if(pointArray[x, y].value == 0)
                    {

                    }
                    else
                    { 
                        if(y+1< refpointArray.GetUpperBound(1))
                        {
                            Point[,] moveBottom = new Point[x,y-1];

                            for (int i = x; i< refpointArray.GetUpperBound(0); i++)
                            {
                                for(int j=y+1; j < refpointArray.GetUpperBound(1), j++)
                                {
                                    Point pt = new Point() { anotherWay = pointArray[i, j].anotherWay, isVisited = pointArray[i, j].isVisited,value = pointArray[i, j].value,x = pointArray[i, j].x,y= pointArray[i, j].y};
                                    moveBottom[i, j - y - 1] = pt;
                                }
                            }
                            IsThereAnExit(moveBottom,refpointArray);
                        }
                        else if(x+1 < pointArray.GetUpperBound(0))
                        {
                            Point[,] moveRight = new Point[x-1, y];

                            for (int i = x+1; i < pointArray.GetUpperBound(0); i++)
                            {
                                for (int j = y; j < pointArray.GetUpperBound(1), j++)
                                {
                                    Point pt = new Point() { anotherWay = pointArray[i, j].anotherWay, isVisited = pointArray[i, j].isVisited, value = pointArray[i, j].value, x = pointArray[i, j].x, y = pointArray[i, j].y };
                                    moveRight[i-x-1, j] = pt;
                                }
                            }
                            IsThereAnExit(moveRight,refpointArray);
                        }
                        //else if(x-1 > 0)
                        //{
                        //    Point[,] moveLeft = new Point[x - 1, y];

                        //    for (int i = x - 1; i < pointArray.GetUpperBound(0); i++)
                        //    {
                        //        for (int j = y; j < pointArray.GetUpperBound(1), j++)
                        //        {
                        //            Point pt = new Point() { anotherWay = pointArray[i, j].anotherWay, isVisited = pointArray[i, j].isVisited, value = pointArray[i, j].value, x = pointArray[i, j].x, y = pointArray[i, j].y };
                        //            moveRight[i - x - 1, j] = pt;
                        //        }
                        //    }
                        //    IsThereAnExit(moveRight);
                        //}
                    }
                }
            }
            return true;
        }
    }
}
