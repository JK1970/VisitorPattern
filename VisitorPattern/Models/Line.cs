namespace VisitorPattern
{
    public class Line : IShape
    {
        public void Export(IShapeExportVisitor shapeExportVisitor)
        {
            shapeExportVisitor.Export(this);
        }
    }
}