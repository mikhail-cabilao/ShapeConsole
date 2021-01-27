
namespace ShapeConsole.Shapes.Base
{
    public class Shape : IShape
    {
        public double AreaTotal { get; set; }
        public double TopY { get; set; }
        public virtual void Calculate() { }
    }
}
