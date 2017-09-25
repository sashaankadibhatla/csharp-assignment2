using System;
using Xunit;
using csharp_assignment2;
namespace assg2.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            Program fib =new Program();
            //Act
            int summation =fib.Fibonacci(5);
            //Assert
            Assert.IsType<int>(summation);
            Assert.Equal(7,summation);
            Assert.NotEqual(9,summation);
        }
        [Fact]

        public void Test2()
        {
            //Arrange
            MyArray arr=new MyArray();
            //Act
            int len=arr.Call(20);
            //Assert
            Assert.IsType<int>(len);
            Assert.Equal(20,len);
            Assert.NotEqual(11,len);
        }
}
}
