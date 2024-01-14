using System;
namespace factorialapp
{
    class program
    {
        static void Main(string[] args)
        {
            int i, fact = 1;
            for(i=1;i<=5;i++)
            {
                fact=fact*i;
            }
            Console.WriteLine(fact);
        }
        
    }
}