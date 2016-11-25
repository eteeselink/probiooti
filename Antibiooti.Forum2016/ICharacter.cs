using System;


namespace Antibiooti.Forum2016
{
    interface ICharacter
    {
        void WriteCharacter(int x, int y, char c, ConsoleColor col, IScreen screen);
    }
}