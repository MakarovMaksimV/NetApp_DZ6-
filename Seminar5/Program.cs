namespace Seminar5;

class Program
{
    static void Main(string[] args)
    {
        ICalculatable calculatable = new Calculator();
        calculatable.GotResult += Calculatable_GotResult;
        calculatable.Add(5);
        calculatable.Sub(3);
        calculatable.CancelLast();
        calculatable.CancelLast();
        calculatable.Multy(5);
        calculatable.Div(2);
        Console.ReadKey();
    }

    private static void Calculatable_GotResult(object? sender, EventArgs e)
    {
        Console.WriteLine($"{((Calculator)sender).Result}");
    }
}

