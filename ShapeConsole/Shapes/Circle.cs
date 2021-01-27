using ShapeConsole.Models;
using ShapeConsole.Shapes.Base;
using System;

namespace ShapeConsole.Shapes
{
    public class Circle : Shape
    {
        public Circle(Point point, double radious)
        {
            this.Centre = point;
            this.Radius = radious;
        }

        public Point Centre { get; set; }
        public double Radius { get; set; }

        public override void Calculate()
        {
            this.AreaTotal = Math.PI * Radius * Radius;
            this.TopY = Radius + Centre.Y;
        }

        public override string ToString()
        {
            return $"{nameof(Circle)} = Point: {Centre}, Radius: {Radius}\n\tTotal area: {AreaTotal:F4}";
        }
    }
}
