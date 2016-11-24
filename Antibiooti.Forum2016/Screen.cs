using System;

namespace Antibiooti.Forum2016
{
    class Screen : IScreen, IDisposable
    {
        public void Write(int x, int y, string text, ConsoleColor color = ConsoleColor.White)
        {
            Console.CursorLeft = x;
            Console.CursorTop = y;
            Console.ForegroundColor = color;
            Console.Write(text);

            // somehow, CursorVisible = false doesn't seem to do much
            // so we move the cursor to left top so it's a bit out of the way.
            Console.CursorVisible = false;
            Console.CursorLeft = 0;
            Console.CursorTop = 0;
        }

        public void Clear()
        {
            Console.Clear();
            Console.ResetColor();
        }

        public void Dispose()
        {
            Clear();
        }
    }

}