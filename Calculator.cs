namespace AppSharp_5;

internal class Calculator : ICalc
{
    public event EventHandler<EventArgs> GotResult;

    public int Result = 0;
    public int Sum(int value)
    {
        Result += value;
        RaiseEvent();
        return Result;
    }

    public int Substruct(int value)
    {
        Result -= value;
        RaiseEvent();
        return Result;
    }

    public int Multiplay(int value)
    {
        Result *= value;
        RaiseEvent();
        return Result;
    }

    public int Divide(int value)
    {
        Result /= value;
        RaiseEvent();
        return Result;
    }

    public void RaiseEvent()
    {
        GotResult?.Invoke(this, EventArgs.Empty);
    }

}