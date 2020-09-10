using System;
using Xunit;
using FirstLib;

namespace NewCoreProject
{
    public class test1
    {
        [Fact]
        public void testadd()
        {
        //Given
        var obj=new Calculator(2,1);
        Assert.Equal(3,obj.add());
            //When

            //Then
        }

        
        [Fact]
        public void testmul()
        {
        //Given
        var obj=new Calculator(2,1);
        Assert.Equal(2,obj.mul());
            //When

            //Then
        }
    }
}