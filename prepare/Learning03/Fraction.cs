using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction() //initialize to 1/1
    {
        _top = 1;
        _bottom = 1;
    } 

    public Fraction(int wholeNumber) //initialize to wholeNumber/1
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom) //initialize to top/bottom
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetFractionTop()
    {
        int top = _top;
        return top;
    }

    public int GetFractionBottom()
    {
        int bottom = _bottom;
        return bottom;
    }

    public string GetFractionString()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }

    public double GetDecimalValue()
    {
        double decimalValue = (double)_top / (double)_bottom;
        return decimalValue;
    }


}