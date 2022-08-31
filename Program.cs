void MaxValue(int x, int y)
{
    Math.Max(x, y);
}

void MinValue(int x, int y)
{
    Math.Min(x, y);
}

bool TrySumIfOdd(int x, int y, out int Out)
{
    Out = x + y;
    return ((x + y) % 2 == 0) ? false : true;
}

void Repeat(String x, int y)
{
    String t = ""; 
    for (int i = 0; i < y; i++)
    {
        t += x;
    }

    Console.WriteLine(t);
}

Repeat("str", 3);