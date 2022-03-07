Console.WriteLine("Welcome to Line Comparison Computation Program.");

Console.WriteLine("Enter x1 : ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter x2 : ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter y1 : ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter y2 : ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("A Length as 2 Point (x1,y1) & (x2,y2) : " + (x1,y1) + (x2,y2));

float LengthOfALine =(float)(Math.Sqrt((Math.Pow((x2 - x1), 2)  + Math.Pow((y2 - y1), 2) ))) ;
Console.WriteLine("Length Of Line :" + LengthOfALine);

if (x1 == x2)
{
    Console.WriteLine("x1 is Equal to x2:" + x1);
}
else if (x1 > x2)
{

    Console.WriteLine("x1 is Greater than x2:"  + (x1 , x2));
}
else
{
    Console.WriteLine("x1 is Less than x2:"  +(x1 , x2));
}


if (y1 == y2)
{
    Console.WriteLine("y1 is Equal to y2:" + y1);
}
else if (y1 > y2)
{
    Console.WriteLine("y1 is Greater than y2:" +(y1 , y2));
}
else
{
    Console.WriteLine("y1 is Less than y2:" +(y1 , y2));
}
    
