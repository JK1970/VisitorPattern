using VisitorPattern.Interfaces;

namespace VisitorPattern.Models
{
    public class Rectangle : IShape
    {
        public void Export(IShapeExportVisitor shapeExportVisitor)
        {
            shapeExportVisitor.Export(this);
        }
    }
}