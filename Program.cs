using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Running ValueTypes...");
        var valueTypes = new ValueTypes();
        valueTypes.Run();

        Console.WriteLine("\nRunning TaggedInteger...");
        var taggedInteger = new TaggedInteger();
        taggedInteger.Run();

        Console.WriteLine("\nRunning DataTypes...");
        var dataTypes = new DataTypes();
        dataTypes.Run();
    }
}