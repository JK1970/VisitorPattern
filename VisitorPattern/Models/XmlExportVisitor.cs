using VisitorPattern.Interfaces;

namespace VisitorPattern.Models
{
    public class XmlExportVisitor : IShapeExportVisitor
    {
        public void Export(Circle circle)
        {
            Console.WriteLine("Circle is exported to XML");
        }
        public void Export(Line line)
        {
            Console.WriteLine("Line is exported to XML");
        }
        public void Export(Rectangle rectangle)
        {
            Console.WriteLine("Rectangle is exported to XML");
        }
    }
}