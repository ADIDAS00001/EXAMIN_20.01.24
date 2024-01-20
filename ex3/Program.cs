

int a=Convert.ToInt32(Console.ReadLine());
int[] A=new int [a];
int mn=999999,b=0;
int mx=-999999,c=0;
for(int i=0;i<a;i++)
{
    A[i]=Convert.ToInt32(Console.ReadLine());
}
for(int i=0;i<a;i++)
{
   if(A[i]>mx)
   {
         mx=A[i];
         c=i;
   }
   if(A[i]<mn)
   {
        mn=A[i];
        b=i;
   }
}
for(int i=b;i<=c;i++)
{
    Console.Write($"{A[i]} ");
}
