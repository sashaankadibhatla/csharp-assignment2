using System;


   
namespace csharp_assignment2
{
    public class MyArray
    {
        public int  Call(int s){
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
            return array.Length;
            }
            
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int s=int.Parse(Console.ReadLine());
            MyArray sec=new MyArray();
            int l=sec.Call(s);
           // Console.WriteLine(l);

            Program p= new Program();
            Console.WriteLine("Enter the number of terms in fibonacci series");
            string input=Console.ReadLine();
            int n=int.Parse(input);
            int value=p.Fibonacci(n);
           // Console.WriteLine(value);
        }
        public int Fibonacci(int n){
            int i,a,b,c,sum;
            Console.WriteLine("Fibonacci Series is :");
            a=0;
            b=1;
            c=0;
            sum=1;
            Console.Write(" {0} {1} ",a,b);
            for(i=2;i<=n-1;i++)
            {
                c=a+b;
                sum=sum+c;
                Console.Write(" {0} ",c);
                a=b;
                b=c;
            }
            return sum;
        }    
    
    }
}

