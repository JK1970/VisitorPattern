namespace VisitorPattern.Interfaces
{
    public interface IShape
    {
        void Export(IShapeExportVisitor shapeExportVisitor);
    }
}