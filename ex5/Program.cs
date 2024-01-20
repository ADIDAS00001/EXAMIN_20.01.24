

int a=Convert.ToInt32(Console.ReadLine());
int[] A=new int [a];
int b=0;
int cnt=0;
for(int i=0;i<a;i++)
{
        A[i]=Convert.ToInt32(Console.ReadLine());
}
b=Convert.ToInt32(Console.ReadLine());
for(int i=0;i<a;i++)
{
    if(A[i]==b)
    {
        cnt++;
    }
}
System.Console.WriteLine(cnt);