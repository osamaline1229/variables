﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the value of  factorial : ");
        int a = Convert.ToInt32(Console.ReadLine());
        int i;
        int k;
        
        
        do
        {
            
            a = a - 1;
            i = a;
            
            i = a - 1;
            int k = a * i;
           
        } while (a > 0);
        Console.WriteLine(k);
    }
}