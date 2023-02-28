namespace VisitorPattern
{
    public class Circle : IShape
    {
        public void Export(IShapeExportVisitor shapeExportVisitor)
        {
            shapeExportVisitor.Export(this);
        }
    }
}