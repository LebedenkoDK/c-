int N = 22;
int T = 0;

while(T < N)
{
    T=T+2;   
    if (T <= N) Console.Write(T);
    if (T < (N - 1)) Console.Write(", ");
}
Console.Write(".");