using System;
using Xunit;

namespace Antibiooti.Forum2016.Tests
{
    public class Tests
    {
        [Fact]
        public void Test1() 
        {
            using(new Antibiooti.Forum2016.Screen()) {
                Assert.True(true);
            }
            
        }
    }
}
