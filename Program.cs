using System;


   
namespace csharp_assignment2
{
     class MyArray
    {
        public  static void  Call(){
            Console.WriteLine("Enter the size of array");
            int s=int.Parse(Console.ReadLine());
            int []array=new int[s];
            int i;
            for(i=0;i<s;i++)
            {
                 array[i]=i+1;
                 Console.WriteLine(" {0} ",array[i]);
                 if(i==10)
                 {
                  Console.WriteLine("array crosses 10");
                 }
            }
            }
            
    }
    class Program
    {
        public static void Main(string[] args)
        {
            MyArray.Call();
            Program p= new Program();
            p.Fibonacci();
        }
        public void Fibonacci(){
            Console.WriteLine("Enter the number of terms in fibonacci series");
            string input=Console.ReadLine();
            int n=int.Parse(input);
            int i,a,b,c;
            Console.WriteLine("Fibonacci Series is :");
            a=0;
            b=1;
            c=0;
            Console.Write(" {0} {1} ",a,b);
            for(i=2;i<=n;i++)
            {
                c=a+b;
                Console.Write(" {0} ",c);
                a=b;
                b=c;
            }
        }    
    
    }
}

