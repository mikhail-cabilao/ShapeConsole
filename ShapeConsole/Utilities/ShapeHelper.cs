using ShapeConsole.Models;
using ShapeConsole.Shapes;
using ShapeConsole.Shapes.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShapeConsole.Utilities
{
   
    public static class ShapeHelper
    {
        public static List<Shape> GetShapes()
        {
            using (var reader = new StreamReader($"{Directory.GetCurrentDirectory()}/shapes.csv"))
            {
                return reader.ReadToEnd()
                    .Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s =>
                    {
                        var type = s.Split(',').FirstOrDefault();
                        var values = s.Split(',').Skip(1).Select(p => double.Parse(p)).ToArray();
                        var shape = new Shape();
                        if (type == "C")
                            shape = new Circle(new Point(values[0], values[1]), values[2]);
                        else
                            shape = new Triangle(new Point(values[0], values[1]), new Point(values[2], values[3]), new Point(values[4], values[5]));

                        shape.Calculate();
                        return shape;
                    })
                    .ToList();
            }
        }
    }
}
