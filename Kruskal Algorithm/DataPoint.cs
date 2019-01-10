using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruskal_Algorithm
{
    class DataPoint
    {
        public int Number { get; set; }
        public int XPoint { get; set; }
        public int YPoint { get; set; }

        public Cluster Cluster { get; set; }

        public double Distace { get; set; }

        public DataPoint(int number, int xPoint, int yPoint, Cluster cluster)
        {
            Number = number;
            XPoint = xPoint;
            YPoint = yPoint;
            Cluster = cluster;
        }
    }
}
