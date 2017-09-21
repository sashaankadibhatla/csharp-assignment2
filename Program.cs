using System;


   
namespace csharp_assignment2
{
     class MyArray
    {
        public  static void  Call(){
            int []array=new int[12];
            int i;
            for(i=1;i<=10;i++)
            {
                 array[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("array crosses 10");
            }
            
        }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the class array");
            MyArray.Call();
            Console.WriteLine("Enter the number of terms in fibonacci series");
            string input=Console.ReadLine();
            int n=int.Parse(input);
            int i;
            int[] array=new int[n+1];
            array[0]=0;
            array[1]=1;
            for(i=2;i<=n;i++)
            {
                array[i]=array[i-1]+array[i-2];
            }
            Console.WriteLine("Fibonacci Series is :");
            for(i=0;i<=n;i++)
                Console.Write(" {0} ",array[i]);
            
        }
    }
    
}

