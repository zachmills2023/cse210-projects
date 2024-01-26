using System;
using System.IO;

public class Fraction{

    private int _top;
    private int _bottom;

    // Below is the constructor:
    public Fraction(){
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber){
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top,int bottom){
        if (bottom == 0)
            throw new ArgumentException("The denominator cannot be zero.");

            _top = top;
            _bottom = bottom;
        
    }

    public int GetTop(){
        return _bottom;
    }

    public void SetBottom(int bottom){
        if (bottom == 0)
            throw new ArgumentException("The denominator cannot be zero.");
        _bottom = bottom;
    }

    public string GetFractionString(){
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue(){
        return (double)_top / _bottom;
    }



}