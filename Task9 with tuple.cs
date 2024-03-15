/*double a;
double b;
double c;
double d = 0;

do
{
    if (d < 0)
    {
        Console.WriteLine("Discriminant is less then 0.");
        Console.WriteLine();
    }

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

if (a == 0)
{
    Console.WriteLine("Coefficient 'a' cannot be zero.");
    return;
}

static (double, double) quadratic_tuple(double a, double b, double d, double x1, double x2)
{
    x1 = (-b - Math.Sqrt(d)) / (2 * a);
    x2 = (-b + Math.Sqrt(d)) / (2 * a);
    return (x1, x2);
}

double x1 = 0;
double x2 = 0;

var q = quadratic_tuple(a, b, d, x1, x2);
Console.WriteLine("The first root of the quadratic equation is: " + q.Item1);
Console.WriteLine("The first root of the quadratic equation is: " + q.Item2);*/