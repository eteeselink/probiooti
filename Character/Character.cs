using System;

namespace Character
{
    class Character
    {
        //TODO sort the package structure
        private Pixel[,] buffer;

        public FakeScreen() {
            Clear();
        }

        public void Clear()
        {
            // TODO turn all lights off
        }

        public void Write(int x, int y)
        {
            // TODO FIX To display the character

                screen.Write(y, x, "*   *   *");
                screen.Write(y, x+1, "  * * *  ");
                screen.Write(y, x+2, "* * * * *");
                screen.Write(y, x+3, "  * * *  ");
                screen.Write(y, x+4, "*   *   *")<
        }

        public void SetCharacter(char c)
        {
            // To set the character
            //
        }

        public void SetLightColor(int n, ConsoleColor color)
        {
            // To set the color of a specific light
        }

        public void SetLightOn(int n, int onoff)
        {
            // To set a specific light on/off
        }
    }
}