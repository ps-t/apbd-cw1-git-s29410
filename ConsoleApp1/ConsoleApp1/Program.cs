Console.WriteLine("Hello, This is \"The Project\"");
Console.WriteLine("Input the name:\n");
string name = Console.ReadLine();
Console.WriteLine($"Hello, and Welcome {name} to \"THE PROJECT\"");

int[] values = new int[2];
Console.WriteLine("input first number:");
values[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input second number:");
values[1] = Convert.ToInt32(Console.ReadLine());

double CalculateAverage(int[] values)
{
    return values.Average();
}
