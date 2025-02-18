using System.Security.Cryptography.X509Certificates;

namespace AppSharp_5;

internal class Calculator : ICalc
{
    public event EventHandler<EventArgs> GotResult;

    public int Result = 0;

    public Stack<int> Results { get; private set; } = new Stack<int>();

    private void ShowAndSaveResult()
    {
        Results.Push(Result);
        RaiseEvent();
    }
    public void Sum(int value)
    {
        Result += value;
        ShowAndSaveResult();
    }

    public void Substruct(int value)
    {
        Result -= value;
        ShowAndSaveResult();
    }

    public void Multiplay(int value)
    {
        Result *= value;
        ShowAndSaveResult();
    }

    public void Divide(int value)
    {
        if (value != 0)
        {
            Result /= value;
            ShowAndSaveResult();
        }
        else Console.WriteLine("Делить на ноль нельзя!");
    }

    public void RaiseEvent()
    {
        GotResult?.Invoke(this, EventArgs.Empty);
    }

    public void CancelList()
    {
        if (Results.Count > 0)
        {
            Results.Pop();
            Result = Results.Pop();
            RaiseEvent();
        }
    }

}