using System.Data;

namespace AppSharp_5;

internal interface ICalc
{
    event EventHandler<EventArgs> GotResult;

    void Sum(int value);
    void Substruct(int value);
    void Multiplay(int value);
    void Divide(int value);
    void CancelList();
}