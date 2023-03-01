using VisitorPattern.Interfaces;

namespace VisitorPattern.Models
{
    public class Line : IShape
    {
        public void Export(IShapeExportVisitor shapeExportVisitor)
        {
            shapeExportVisitor.Export(this);
        }
    }
}