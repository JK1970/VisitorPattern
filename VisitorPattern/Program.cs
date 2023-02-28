using VisitorPattern.Models;
using VisitorPattern.Interfaces;

namespace VisitorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            List<IShape> shapes = new()
            {
                new Circle(),
                new Line(),
                new Rectangle(),
            };

            XmlExportVisitor xmlExportVisitor = new();

            foreach (IShape shape in shapes)
            {
                shape.Export(xmlExportVisitor);
            }

            CsvExportVisitor csvExportVisitor = new();

            foreach (IShape shape in shapes)
            {
                shape.Export(csvExportVisitor);
            }
        }
    }
}