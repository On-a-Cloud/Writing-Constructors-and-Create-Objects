#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

class Point
{
    private int x, y;

    public Point()
    {
        Console.WriteLine("Default constructor called");
    }

    public Point(int x, int y)
    {
        this.x = -1;
        this.y = -1; 
    }
    public double DistanceTo(Point other)
    {
        int xDiff = this.x - other.x;
        int yDiff = this.y - other.y;
        double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
        return distance;
    }
}
