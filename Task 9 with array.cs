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

static double[] quadratic_arr(double a, double b, double d, double x1, double x2)
{
    double[] root = new double[2];
    x1 = (-b - Math.Sqrt(d)) / (2 * a);
    x2 = (-b + Math.Sqrt(d)) / (2 * a);
    root[0] = x1;
    root[1] = x2;
    return root;
}

double x1 = 0;
double x2 = 0;

var e = quadratic_arr(a, b, d, x1, x2);
Console.WriteLine("The first root of the quadratic equation is: " + e[0]);
Console.WriteLine("The first root of the quadratic equation is: " + e[1]);*/