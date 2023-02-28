namespace VisitorPattern
{
    public interface IShape
    {
        void Export(IShapeExportVisitor shapeExportVisitor);
    }
}