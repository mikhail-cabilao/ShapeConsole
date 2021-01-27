using ShapeConsole.Shapes.Base;
using System.Collections.Generic;
using System.Linq;

namespace ShapeConsole.Extensions
{
    public static class ShapeExtensions
    {
        public static List<Shape> GetBiggerShapes(this List<Shape> shapes, int take) => shapes.OrderByDescending(o => o.AreaTotal).Take(take).ToList();
        public static List<Shape> GetBiggerShapesByType<T>(this List<Shape> shapes, int take) where T: Shape => shapes.Where(t => t is T).OrderByDescending(o => o.AreaTotal).Take(take).ToList();
        public static Shape GetTopShape(this List<Shape> shapes) => shapes.OrderByDescending(o => o.TopY).FirstOrDefault();
    }
}
