using System;

namespace Antibiooti.Forum2016
{
    interface IScreen
    {
        void Write(int x, int y, string text, ConsoleColor color = ConsoleColor.White);
        void Clear();   
    }
}