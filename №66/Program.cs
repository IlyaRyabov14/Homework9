Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine() ??"");
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ??"");
int result = 0;
int SumNatur(int start, int end)
{
    for (int i = start; i<=end; i++)
    {
        result += i;
    } 
    return result;
}
Console.WriteLine(SumNatur(M,N));