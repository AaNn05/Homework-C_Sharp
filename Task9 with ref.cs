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

static void quadratic_ref(double a, double b, double d, ref double x1, ref double x2)
{
    x1 = (-b - Math.Sqrt(d)) / (2 * a);
    x2 = (-b + Math.Sqrt(d)) / (2 * a);
}

double x1 = 0;
double x2 = 0;

quadratic_ref(a, b, d, ref x1, ref x2);
Console.WriteLine("The first root of the quadratic equation is: " + x1);
Console.WriteLine("The second root of the quadratic equation is: " + x2);*/