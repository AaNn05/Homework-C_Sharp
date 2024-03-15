/*double a;
double b;
double c;
double d = 0;

do
{
    Console.Write("Give a value to a: ");
    a = double.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Give a value to b: ");
    b = double.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Give a value to c: ");
    c = double.Parse(Console.ReadLine());
    d = Math.Pow(b, 2) - 4 * a * c;
    Console.WriteLine();


} while (d < 0);

A dec = new A(a, b, c, d);
Console.WriteLine("The first root of the quadratic equation is: " + dec.x1);
Console.WriteLine("The second root of the quadratic equation is: " + dec.x2);
class A
{
    public double x1 = 0;
    public double x2 = 0;

    public A(double a, double b, double c, double d)
    {
        if (a == 0)
        {
            Console.WriteLine("Coefficient 'a' cannot be zero.");
            return;
        }
        

        x1 = (-b - Math.Sqrt(d)) / (2 * a);
        x2 = (-b + Math.Sqrt(d)) / (2 * a);
    }
 }*/