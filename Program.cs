namespace AppSharp_5;
class MyClass
{
    static void Calculator_GotResult(object sendler, EventArgs eventArgs)
    {
        Console.WriteLine($"{((Calculator)sendler).Result}");
    }
    static void Calculator_GotResultTwo(object sendler, EventArgs eventArgs)
    {
        Console.WriteLine($"result = {((Calculator)sendler).Result}");
    }
    static void Main(string[] args)
    {
        ICalc calc = new Calculator();

        calc.GotResult += Calculator_GotResult;
        calc.GotResult += Calculator_GotResultTwo;
        calc.Sum(12);
        calc.Substruct(7);
        calc.Multiplay(13);
    }

}
