// David Barlow Fibonacci Sequence 10/30/24 
// 0,1,1,2,3,5,8,13,21,34,55
Console.Clear();

Console.Write(Fibonacci(26));
Console.WriteLine();

int Fibonacci(int n)
{
    // 3rd number = first(0) + second(1);
    // 4th number = sedond(1) + 3rd(1);
    if(n == 0)
    {
        return 0;
    }else if(n == 1)
    {
        return 1;
    }
    return n = Fibonacci(n-2) + Fibonacci(n-1);
}