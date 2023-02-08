using System;

public class Fraction

{
    private int _top;
    private int _bottom;

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public Fraction()
    {
        _top = 1;
        _bottom = 1;

    }
    public int Gettop()
    {
        return _top;
    }
    public void Settop(int top)
    {
        _top = top;
    }
    public int Getbottom()
    {
        return _bottom;
    }
    public void Setbottom(int bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        return ($"{_top}/{_bottom}");
    }
    public double GetDecimalValue()
    {
        double top = Convert.ToDouble(_top);
        double bottom = Convert.ToDouble(_bottom);

        return top/bottom;
    }

}




