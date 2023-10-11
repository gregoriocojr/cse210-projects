using System;

public abstract class Shape
{
    protected string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // public vistual double GetArea()
    // {
    //     return 0;
    // }

    public abstract double GetArea();
}