
int sum=0;
void SumOfDigits(int n)
{
    for(int i=n;i>0;i/=10)
    {
        sum+=n%10;
    }
}
 SumOfDigits(1234);
 System.Console.WriteLine(sum);