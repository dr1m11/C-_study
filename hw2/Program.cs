int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if(a > b) 
{
    if (a > c) 
    {    
        Console.Write("max = " + a);
    }    
}

if(b > a) 
{
    if (b > c) 
    {    
        Console.Write("max = " + b);
    }    
}

if(c > a) 
{
    if (c > b) 
    {    
        Console.Write("max = " + c);
    }     
}