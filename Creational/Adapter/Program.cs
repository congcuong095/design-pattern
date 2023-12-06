internal class Program
{
    private static void Main(string[] args)
    {
        int x1 = 1, x2 = 10, y1 = 0, y2 = 5;
        IShape shape1 = new AdapterLine(new LegacyLine());
        IShape shape2 = new AdapterRectangle(new LegacyRectangle());

        Console.WriteLine(shape1.Draw(x1, y1, x2, y2));
        Console.WriteLine(shape2.Draw(x1, y1, x2, y2));
    }

    interface IShape
    {
        string Draw(int x1, int y1, int x2, int y2);
    }

    class LegacyRectangle
    {
        public string Draw(int x1, int y1, int width, int height)
        {
            return $"Rectangle - x1: {x1}, y1: {y1}, width: {width}, height: {height}";
        }
    }

    class LegacyLine
    {
        public string Draw(int x1, int y1, int x2, int y2)
        {
            return $"Line - x1: {x1}, y1: {y1}, x2: {x2}, y2: {y2}";
        }
    }

    class AdapterRectangle : IShape
    {
        private readonly LegacyRectangle legacyRectangle;

        public AdapterRectangle(LegacyRectangle _legacyRectangle)
        {
            legacyRectangle = _legacyRectangle;
        }
        public string Draw(int x1, int y1, int x2, int y2)
        {
            int width = Math.Abs(x1 - x2);
            int height = Math.Abs(y1 - y2);

           return legacyRectangle.Draw(x1, y1, width, height);
        }
    }

    class AdapterLine : IShape
    {
        private readonly LegacyLine legacyLine;
        public AdapterLine(LegacyLine _legacyLine)
        {
            legacyLine = _legacyLine;
        }
        public string Draw(int x1, int y1, int x2, int y2)
        {
            return legacyLine.Draw(x1, y1, x2, y2);
        }
    }
}