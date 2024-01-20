

int b=0;
void Fibonacci(int n) 
{
    if(n==1 && n==2)
    {
        return ;
    }
    else 
    {
        return Fibonacci(n-1)+Fibonacci(n-2);
    }
}