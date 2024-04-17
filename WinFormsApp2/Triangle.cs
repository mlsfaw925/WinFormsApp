namespace WinFormsApp2;
public class Triangle
{
    private double SideA = 0;
    private double SideB = 0;
    private double SideC = 0;

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
    public void SetSideC(string c)
    {
        SetSideC(Convert.ToDouble(c));
    }
    public void SetSideC(double c)
    {
        SideC = c;
    }
    public double GetSideA() { return SideA; }
    public double GetSideB() { return SideB; }
    public double GetSideC() { return SideC; }


    public double Pythagoras()
    {
        SideC = Math.Sqrt(SideA * SideA + SideB * SideB);
        return Math.Round(SideC, 2);
    }

    public double GetArea()
    {
        var tribase = Convert.ToDouble(SideA);
        var triheight = Convert.ToDouble(SideB);
        return (SideA * SideB / 2);
    }
}
