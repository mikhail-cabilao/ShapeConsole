using ShapeConsole.Models;
using ShapeConsole.Shapes.Base;
using System;
using System.Linq;

namespace ShapeConsole.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(Point pa, Point pb, Point pc)
        {
            this.PointA = pa;
            this.PointB = pb;
            this.PointC = pc;
        }

        public Point PointA { get; set; }
        public Point PointB { get; set; }
        public Point PointC { get; set; }

        public override void Calculate()
        {
            var area = ((PointA.X * (PointB.Y - PointC.Y)) + (PointB.X * (PointC.Y - PointA.Y)) + (PointC.X * (PointA.Y - PointB.Y))) / 2;
            this.AreaTotal = Math.Abs(area);
            this.TopY = new double[] { PointA.Y, PointB.Y, PointC.Y }.OrderByDescending(o => o).FirstOrDefault();
        }

        public override string ToString()
        {
            return $"{nameof(Triangle)} = {PointA},{PointB},{PointC}\n\tTotal area: {AreaTotal:F4}";
        }
    }
}
