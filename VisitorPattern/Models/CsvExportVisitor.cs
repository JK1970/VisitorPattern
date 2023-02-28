namespace VisitorPattern
{
    public class CsvExportVisitor : IShapeExportVisitor
    {
        public void Export(Circle circle)
        {
            Console.WriteLine("Circle is exported to CSV");
        }
        public void Export(Line line)
        {
            Console.WriteLine("Line is exported to CSV");
        }
        public void Export(Rectangle rectangle)
        {
            Console.WriteLine("Rectangle is exported to CSV");
        }
    }
}