using System.Data;

namespace AppSharp_5;

internal interface ICalc
{
    event EventHandler<EventArgs> GotResult;

    int Sum(int value);
    int Substruct(int value);
    int Multiplay(int value);
    int Divide(int value);
}