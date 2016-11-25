using System;

namespace Antibiooti.Forum2016
{
    class Character
    {
        //TODO sort the package structure
        private Light[] lights;

        public Character() {
            lights = new Light[]{
                new Light(ConsoleColor.White,true),
                new Light(ConsoleColor.White,true),
                new Light(ConsoleColor.White,true),

                new Light(ConsoleColor.White,true),
                new Light(ConsoleColor.White,true),
                new Light(ConsoleColor.White,true),

                new Light(ConsoleColor.White,true),
                new Light(ConsoleColor.White,true),
                new Light(ConsoleColor.White,true),

                new Light(ConsoleColor.White,true),
                new Light(ConsoleColor.White,true),
                new Light(ConsoleColor.White,true),

                new Light(ConsoleColor.White,true),
                new Light(ConsoleColor.White,true),
                new Light(ConsoleColor.White,true)
            };
            Clear();
        }

        public void Clear()
        {
            // TODO turn all lights off
        }

        public void Write(int x, int y)
        {
            // TODO FIX To display the character

            using(var screen = new Screen()) {
                screen.Clear();
                screen.Write(y, x, lights[0].getChar()+"   "+lights[1].getChar()+"   " + lights[2].getChar());
                screen.Write(y, x+1, "  "+lights[3].getChar()+" "+lights[4].getChar()+" "+lights[5].getChar()+"  ");
                screen.Write(y, x+2, lights[6].getChar()+" "+lights[7].getChar()+" "+lights[8].getChar()+" "+lights[9].getChar()+" "+lights[10].getChar());
                screen.Write(y, x+3, "  "+lights[11].getChar()+" "+lights[12].getChar()+" "+lights[13].getChar()+"  ");
                screen.Write(y, x+4, lights[14].getChar()+"   "+lights[15].getChar()+"   "+lights[16].getChar());
                Console.ReadKey(true);
            }
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