using System;
using SimpleAPI.Controllers;
using Xunit;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {

        ValuesController controller = new ValuesController();

        [Fact]
        public void Test1()
        {
            
        }

        [Fact]
        public void GetReturnsCorrectNumber()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Tim P", returnValue.Value);
        }
    }
}
