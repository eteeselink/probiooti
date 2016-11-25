using System;

namespace Antibiooti.Forum2016
{
    class Character : ICharacter
    {
        //TODO sort the package structure
        private Light[] lights;

        public Character() {
            lights = new Light[]{
                new Light(ConsoleColor.White,false),
                new Light(ConsoleColor.White,false),
                new Light(ConsoleColor.White,false),

                new Light(ConsoleColor.White,false),
                new Light(ConsoleColor.White,false),
                new Light(ConsoleColor.White,false),

                new Light(ConsoleColor.White,false),
                new Light(ConsoleColor.White,false),
                new Light(ConsoleColor.White,false),

                new Light(ConsoleColor.White,false),
                new Light(ConsoleColor.White,false),
                new Light(ConsoleColor.White,false),

                new Light(ConsoleColor.White,false),
                new Light(ConsoleColor.White,false),
                new Light(ConsoleColor.White,false),

                new Light(ConsoleColor.White,false),
                new Light(ConsoleColor.White,false)
            };
        }

        // Set all lights off
        public void Clear()
        {
            for (int i=0;i<17;i++){
                lights[i].Status = false;
            }
        }

        public void WriteCharacter(int x, int y, char c, ConsoleColor col, IScreen screen)
        {
            // TODO FIX To display the character
            SetCharacter(c);
            SetCharacterColor(col);
            screen.Write(y, x, lights[0].getChar()+"   "+lights[1].getChar()+"   " + lights[2].getChar());
            screen.Write(y, x+1, "  "+lights[3].getChar()+" "+lights[4].getChar()+" "+lights[5].getChar()+"  ");
            screen.Write(y, x+2, lights[6].getChar()+" "+lights[7].getChar()+" "+lights[8].getChar()+" "+lights[9].getChar()+" "+lights[10].getChar());
            screen.Write(y, x+3, "  "+lights[11].getChar()+" "+lights[12].getChar()+" "+lights[13].getChar()+"  ");
            screen.Write(y, x+4, lights[14].getChar()+"   "+lights[15].getChar()+"   "+lights[16].getChar());
        }

        public void SetCharacter(char c)
        {
            // To set the character
            Clear();
            switch (c)
            {
                case '.':
                    lights[8].Status = true;
                    break;
                case 'o':
                    lights[3].Status = true;
                    lights[4].Status = true;
                    lights[5].Status = true;
                    lights[7].Status = true;
                    lights[9].Status = true;
                    lights[11].Status = true;
                    lights[12].Status = true;
                    lights[13].Status = true;
                    break;
                case 'O':
                    lights[0].Status = true;
                    lights[1].Status = true;
                    lights[2].Status = true;
                    lights[6].Status = true;
                    lights[10].Status = true;
                    lights[14].Status = true;
                    lights[15].Status = true;
                    lights[16].Status = true;
                    break;
                case '\\':
                    lights[0].Status = true;
                    lights[3].Status = true;
                    lights[8].Status = true;
                    lights[13].Status = true;
                    lights[16].Status = true;
                    break;
                case '|':
                    lights[1].Status = true;
                    lights[4].Status = true;
                    lights[8].Status = true;
                    lights[12].Status = true;
                    lights[15].Status = true;
                    break;
                case '/':
                    lights[2].Status = true;
                    lights[5].Status = true;
                    lights[8].Status = true;
                    lights[11].Status = true;
                    lights[14].Status = true;
                    break;
                default:
                    break;
            }        
        }

        public void SetCharacterColor(ConsoleColor color)
        {
            // To set the color of a specific light
            for (int i=0;i<17;i++){
                lights[i].Color = color;
            }
        }

        public void SetLightOn(int n, int onoff)
        {
            // To set a specific light on/off
        }
    }
}