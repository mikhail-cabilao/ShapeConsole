using ShapeConsole.Extensions;
using ShapeConsole.Models;
using ShapeConsole.Shapes;
using ShapeConsole.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanusConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = ShapeHelper.GetShapes();

            Console.WriteLine("Top 5 biggest shapes.");
            foreach (var shape in shapes.GetBiggerShapes(5))
            {
                Console.WriteLine(shape.ToString());
            }

            //The top 5 bigger shapes are in Triangle shape so I decided to add for circle shape.
            Console.WriteLine("Top 5 biggest circle.");
            foreach (var shape in shapes.GetBiggerShapesByType<Circle>(5))
            {
                Console.WriteLine(shape.ToString());
            }

            Console.WriteLine("-----------------------");
            var topShape = shapes.GetTopShape();
            Console.WriteLine($"Shape closest to top is {topShape.GetType().Name} with a Y axes of {topShape.TopY:F4}");
        }
    }
}