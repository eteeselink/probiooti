﻿using System;
using Xunit;

namespace Antibiooti.Forum2016.Tests
{
    public class Tests
    {
        [Fact]
        public void FakeScreenWritesWhereItsSupposedTo() 
        {
            var fakeScreen = new FakeScreen();
            fakeScreen.Write(10, 10, "Hello", ConsoleColor.Blue);
            Assert.Equal(fakeScreen[14, 10].Char, 'o');            
            Assert.Equal(fakeScreen[14, 10].Color, ConsoleColor.Blue);    

            fakeScreen.Clear();
            Assert.Equal(fakeScreen[14, 10].Char, ' ');            
            Assert.Equal(fakeScreen[14, 10].Color, ConsoleColor.White);            
        }

        [Fact]
        public void FakeLight()
        {
            var light = new Light();
            Assert.Equal(light.getChar(), ' ');
            Assert.Equal(light.Status, false);
            Assert.Equal(light.Color, ConsoleColor.White);
            
            light = new Light(ConsoleColor.Green,true);
            Assert.Equal(light.getChar(), '*');
            Assert.Equal(light.Status, true);
            Assert.Equal(light.Color, ConsoleColor.Green);

        }
    }
}
