using System.Collections;
using System;
using System.Collections.Generic;



class LineComparison
{
    public int X1;
    public int X2;
    public int Y1;
    public int Y2;

    public LineComparison(int X1, int X2, int Y1, int Y2)
    {
        this.X1 = X1;
        this.X2 = X2;
        this.Y1 = Y1;
        this.Y2 = Y2;
    }

    public void Calculation()
    {
        double LengthOfALine = (double)(Math.Sqrt((Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2))));
        Console.WriteLine("Length Of Line :" + LengthOfALine);
        Console.WriteLine("A Length as 2 Point (x1,y1) & (x2,y2) : " + (X1, Y1) + (X2, Y2));
    }

    public void Comparision()
    {

        if (X1 == X2)
        {
            Console.WriteLine("x1 is Equal to x2 :" + X1);
        }
        else if (X1 > X2)
        {

            Console.WriteLine("x1 is Greater than x2 :" + (X1, X2));
        }
        else
        {
            Console.WriteLine("x1 is Less than x2 :" + (X1, X2));
        }


        if (Y1 == Y2)
        {
            Console.WriteLine("y1 is Equal to y2 :" + Y1);
        }
        else if (Y1 > Y2)
        {
            Console.WriteLine("y1 is Greater than y2 :" + (Y1, Y2));
        }
        else
        {
            Console.WriteLine("y1 is Less than y2 :" + (Y1, Y2));
        }


    }

    static void Main(string[] args)
    {

        Console.WriteLine("Enter a value of X1:");
        int X1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a value of X2:");
        int X2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a value of Y1:");
        int Y1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a value of Y2:");
        int Y2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Welcome to Line Comparison Computation Program.");
        LineComparison list = new LineComparison(X1, X2, Y1, Y2);

        list.Comparision();
        list.Calculation();
    }



}