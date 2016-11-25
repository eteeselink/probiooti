using System;
using Xunit;

namespace Antibiooti.Forum2016.Tests
{
    public class CharacterTest
    {
        [Fact]
        public void test1() 
        {
            var fakeScreen = new FakeScreen();
            var text = new Text();
            text.WriteText("O", "red", ConsoleColor.Red, fakeScreen);
            // Assert.Equal(fakeScreen[10, 10].Char, ''); 
            // Console.Write(text.WriteText("O", "red", null));
            // fakeScreen.Write(10, 10, "Hello", ConsoleColor.Blue);
            // Assert.Equal(fakeScreen[14, 10].Char, 'o');            
            // Assert.Equal(fakeScreen[14, 10].Color, ConsoleColor.Blue);    

            // fakeScreen.Clear();
            // Assert.Equal(fakeScreen[14, 10].Char, ' ');            
            // Assert.Equal(fakeScreen[14, 10].Color, ConsoleColor.White);            
        }
    }
}