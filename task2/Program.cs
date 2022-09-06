Console.Write("m=");
int m = int.Parse(Console.ReadLine());
Console.Write("n=");
int n = int.Parse(Console.ReadLine());

funct(m,n);
int sumof(int m, int n)
{
    if (m == 0)
     return n + 1;
    else if (n == 0 && m > 0)
    return sumof(m - 1, 1);
    else
    return (sumof(m - 1, sumof(m, n - 1)));
}

void funct(int m, int n)
{
    Console.Write(sumof(m, n)); 

}

