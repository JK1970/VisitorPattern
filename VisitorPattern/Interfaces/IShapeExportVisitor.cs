namespace VisitorPattern
{
    public interface IShapeExportVisitor
    {
        void Export(Circle circle);
        void Export(Line line);
        void Export(Rectangle rectangle);
    }
}