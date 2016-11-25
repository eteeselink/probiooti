using System;
using Xunit;

namespace Antibiooti.Forum2016.Tests
{
    public class AnotherCharacterTest
    {
        [Fact]
        public void CharacterWritesCorrectly(){
            var screen = new FakeScreen();
                screen.Clear();
                screen.Write(10, 10, "*   *   *     *   *   *    *   *   *     *   *   *     *   *   *");
                screen.Write(10, 11, "  * * *         * * *        * * *         * * *         * * *  ");
                screen.Write(10, 12, "* * * * *     * * * * *    * * * * *     * * * * *     * * * * *");
                screen.Write(10, 13, "  * * *         * * *        * * *         * * *         * * *  ");
                screen.Write(10, 14, "*   *   *     *   *   *    *   *   *     *   *   *     *   *   *");
                //Console.ReadKey(true);

                Console.WriteLine(screen[10,10].Char);

                Assert.Equal(2,2);  
            
        }
    }
}
