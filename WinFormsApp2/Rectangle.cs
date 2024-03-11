namespace WinFormsApp2;
public class Rectangle
{
    private double SideA = 0;
    private double SideB = 0;

    public void SetSideA(string a)
    {
        SetSideA(Convert.ToDouble(a));
    }
    public void SetSideA(double a)
    {
        SideA = a;
    }
    public void SetSideB(string b)
    {
        SetSideB(Convert.ToDouble(b));
    }
    public void SetSideB(double b)
    {
        SideB = b;
    }
    public double GetSideA() { return SideA; }
    public double GetSideB() { return SideB; }

    public double GetArea()
    {
        return SideA * SideB;
    }
}
