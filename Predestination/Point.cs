using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predestination
{
    public class Point
    {
        public int x { get; set; } = 0;
        public int y { get; set; } = 0;
        public int value { get; set; } = 0;
        public bool isVisited { get; set; } = false;
        public bool anotherWay { get; set; } = true;
    }
}
