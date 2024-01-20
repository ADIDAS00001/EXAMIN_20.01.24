int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int x=0;
void Swap(ref int a, ref int b)
{
    x=a;
    a=b;
    b=x;
}

Swap(ref a, ref b);
Console.WriteLine(a);
System.Console.WriteLine(b);