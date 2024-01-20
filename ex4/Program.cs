

int a=Convert.ToInt32(Console.ReadLine());
int[] A=new int [a];
for(int i=0;i<a;i++)
{
    A[i]=Convert.ToInt32(Console.ReadLine());
}
for(int i=0;i<a;i++)
{
    if(A[i]>0)
    {
        A[i]=0;
    }
}
for(int i=0;i<a;i++)
{
    System.Console.Write(A[i]+ " ");
}