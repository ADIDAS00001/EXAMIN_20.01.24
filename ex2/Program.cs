

int a=Convert.ToInt32(Console.ReadLine());
int[] A=new int [a];
int k=0;
for(int i=0;i<a;i++)
{
        A[i]=Convert.ToInt32(Console.ReadLine());
}
k=Convert.ToInt32(Console.ReadLine());
for(int i=0;i<k;i++)
{
    System.Console.Write($"{A[i]} ");
}
for(int i=k+1;i<a;i++)
{
    System.Console.Write($"{A[i]} ");
}

