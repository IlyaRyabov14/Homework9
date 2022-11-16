Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ??"");

string PrintNatur(int start, int end)
{
    if(start==end)
    {
        return start.ToString();
    }
    return (start + ", " + PrintNatur(start + 1, end));
}
Console.WriteLine(PrintNatur(1, N));

