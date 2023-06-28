namespace SOLID.LSP.Solution;

public abstract class Parallelogram
{
    protected Parallelogram(int height, int width)
    {
        Height = height;
        Width = width;
    }

    public double Height { get; private set; }

    public double Width { get; private set; }

    public double Area { get { return Height * Width; } }

    public void ReportArea()
    {
        Console.WriteLine($"Area: {Area}m².");
    }
}
