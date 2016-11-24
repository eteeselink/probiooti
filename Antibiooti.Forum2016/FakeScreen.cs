using System;

namespace Antibiooti.Forum2016
{
    struct Pixel {
        public char Char;
        public ConsoleColor Color;
        public Pixel(char chara, ConsoleColor color) {
            this.Char = chara;
            this.Color = color;
        }
    };

    class FakeScreen : IScreen
    {
        const int W = 80;
        const int H = 25;
     
        private Pixel[,] buffer;

        public FakeScreen() {
            Clear();
        }

        public void Clear()
        {
            buffer = new Pixel[H, W];
            for(int y = 0; y != H; y++) {
                for(int x = 0; x != W; x++) {
                    buffer[y, x] = new Pixel(' ', ConsoleColor.White);
                }
            }
        }

        public void Write(int x, int y, string text, ConsoleColor color = ConsoleColor.White)
        {
            if(y < 0 || H <= y || x < 0 || W <= (x + text.Length)) {
                throw new ArgumentException("out of bounds");
            }
            foreach(char c in text) {
                buffer[y, x] = new Pixel(c, color);
                x++;
            }
        }

        public Pixel this[int x, int y] 
        {
            get {
                return buffer[y, x];
            }
        }
    }
}