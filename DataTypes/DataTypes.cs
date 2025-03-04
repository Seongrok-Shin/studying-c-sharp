public class DataTypes
{
    public void Run()
    {
        int i = 1;
        string s= "String";
        const int speedLimit = 55;
        const double pi = 3.14159265358979323846264338327950;
        Console.WriteLine($"{nameof(i)} = {i}");
        Console.WriteLine($"{nameof(s)} = {s}");
        Console.WriteLine($"{nameof(speedLimit)} = {speedLimit}");
        Console.WriteLine($"{nameof(pi)} = {pi}");
        Console.WriteLine($"long of a + b = {Calculate(1,2)}");
        Conversion(1, 3.5);
    }
        long Calculate(int a, int b)
        {
        long result = a + b;
        
        return result;
        }

    private static void Conversion(int i, double d)
    {
        Console.WriteLine($"{nameof(i)} = {i}, {nameof(d)} = {d}");
        Console.WriteLine($"Casting to integer {nameof(i)} + {nameof(d)} = {i + (int) d}");
        Console.WriteLine($"Casting to dobule {nameof(i)} + {nameof(d)} = {(double)i + d}");

    }
}