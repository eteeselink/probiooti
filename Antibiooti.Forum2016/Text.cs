using System;
using System.Collections.Generic;

namespace Antibiooti.Forum2016
{
    class Text: IText
    {
        public enum EColors
        {
            Red = ConsoleColor.Red,
            Green = ConsoleColor.Green,
            Blue = ConsoleColor.Blue
        }

        enum CharsExpected
        {
            SlashLeft = '\\',
            SlashRight = '/',
            BigO = 'O',
            SmallO = 'o',
            Dot = '.'
        }
        const string CharsOk = "\\/Oo.";

        public void WriteText(string text, string color , ConsoleColor colors, IScreen screen){
        //    var screen = new Screen();
        //var screen = new FakeScreen();
                // screen.Clear();
                // screen.Write(10, 10, "*   *   *     *   *   *    *   *   *     *   *   *     *   *   *");
                // screen.Write(10, 11, "  * * *         * * *        * * *         * * *         * * *  ");
                // screen.Write(10, 12, "* * * * *     * * * * *    * * * * *     * * * * *     * * * * *");
                // screen.Write(10, 13, "  * * *         * * *        * * *         * * *         * * *  ");
                // screen.Write(10, 14, "*   *   *     *   *   *    *   *   *     *   *   *     *   *   *");
          
                foreach(char a in text){
               
                    if(!CharsOk.Contains(a.ToString())) {
                        Console.Write("The characters must be one of these: \\, /, O, o. . ");
                    } else {
                        Character c = new Character();
                        if (text[0] == a) {
                        c.WriteCharacter(10, 10, a, ConsoleColor.Red, screen);
                        }
                    }

                }       
              
            //   Console.ReadKey(true);
            }

    }
}