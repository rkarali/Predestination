using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predestination
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public int value { get; set; }
        public bool isVisited { get; set; }
        public bool anotherWay { get; set; }
        public bool? left { get; set; }
        public bool? right { get; set; }
        public bool? up { get; set; }
        public bool? down { get; set; }
    }
}
