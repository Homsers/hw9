Console.Write("m=");
int m = int.Parse(Console.ReadLine());
Console.Write("n=");
int n = int.Parse(Console.ReadLine());


int sumof (int m, int n)
{
    int numbers = m;
    
    if (m == n)
     return 0;
    else
    m++;
     numbers = m + sumof(m, n);
     return numbers;
}

Console.Write(sumof(m - 1, n));


