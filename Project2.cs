// See https://aka.ms/new-console-template for more information
using System.Xml;

public class Cartesian
{
    private int x;
    private int y;

    public Cartesian(int _x, int _y)
    {
        this.x = _x;
        this.y = _y;
    }

    private int xCoordinate
    {
        get { return this.x; }
        set { this.x = value; }
    }

    private int yCoordinate
    {
        get { return this.y; }
        set { this.y = value; }
    }

    public static Cartesian operator *(Cartesian a, int scalar)
        => new Cartesian(a.x * scalar, a.y * scalar);
    public static Cartesian operator +(Cartesian a, Cartesian b)
        => new Cartesian(a.x + b.x, a.y + b.y);
    public static bool operator ==(Cartesian a, Cartesian b)
    {
        if (a.x==b.x && a.y==b.y)
        {
            return true;
        }
        else
        {
            return false;
        }
    } 
    public static bool operator !=(Cartesian a, Cartesian b)
    {
        if (a.y!=b.y && a.x!=b.x)
        {
            return true;

        }
        else
        {
            return false;
        }
    }
    public void PrintCartesian()
    {
        Console.WriteLine($"({this.x},{this.y})");
    }

    public override string ToString()
    {
        return $"({this.x},{this.y})";
    }
}
public class Project2
{
    static void Main(string[] args)
    {
        Cartesian a = new Cartesian(3, 5);
        Cartesian b = new Cartesian(4, 7);
        a.PrintCartesian();
        b.PrintCartesian();
        int k=15;
        Cartesian c = a* k;
        c.PrintCartesian();
        Cartesian d = a + b;
        d.PrintCartesian();
        Console.WriteLine(a == b);
        Console.WriteLine(a != b);
    }
}