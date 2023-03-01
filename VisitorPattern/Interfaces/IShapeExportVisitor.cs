using VisitorPattern.Models;

namespace VisitorPattern.Interfaces
{
    public interface IShapeExportVisitor
    {
        void Export(Circle circle);
        void Export(Line line);
        void Export(Rectangle rectangle);
    }
}