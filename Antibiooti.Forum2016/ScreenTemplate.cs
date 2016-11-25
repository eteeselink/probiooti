using System;
namespace Antibiooti.Forum2016
{
    public class ScreenTemplate
    {
        private char[] symbols;
        private ConsoleColor color;
        public ConsoleColor getColor(){
            return this.color;
        }
        public void setColor(ConsoleColor color){
            this.color = color;
        }
        public void setSymbols(char[] symbols){
            this.symbols = symbols;
        }
        public char[] getSymbols(){
            return this.symbols;
        }
    }
}