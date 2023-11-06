public class Square
{
    public double A;

    public Square(double a)
    {
        this.A = a;
    }

    public double GetArea()
    {
        return A*A;
    }

    public double GetPerimeter()
    {
        return A*4;
    }
}
