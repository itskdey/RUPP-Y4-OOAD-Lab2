
internal class Program
{
    private static void Main(string[] args)
    {
        ExpList test = new();
        test.Load("expenses.txt");
        var total=test.AmountTotal;
        var max = test.Max;
        Console.WriteLine($"Amount Total> {total:n2}");
        Console.WriteLine($"Max-amount expense > No:{max?.No}, Descr:{max?.Descr}");
    }
}