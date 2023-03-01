using VisitorPattern.Interfaces;

namespace VisitorPattern.Models
{
    public class Circle : IShape
    {
        public void Export(IShapeExportVisitor shapeExportVisitor)
        {
            shapeExportVisitor.Export(this);
        }
    }
}