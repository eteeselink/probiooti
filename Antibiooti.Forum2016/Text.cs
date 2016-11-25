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

        public void WriteText(string text, List<string> color , IScreen screen){
        //    var screen = new Screen();
        //var screen = new FakeScreen();
                // screen.Clear();
                // screen.Write(10, 10, "*   *   *     *   *   *    *   *   *     *   *   *     *   *   *");
                // screen.Write(10, 11, "  * * *         * * *        * * *         * * *         * * *  ");
                // screen.Write(10, 12, "* * * * *     * * * * *    * * * * *     * * * * *     * * * * *");
                // screen.Write(10, 13, "  * * *         * * *        * * *         * * *         * * *  ");
                // screen.Write(10, 14, "*   *   *     *   *   *    *   *   *     *   *   *     *   *   *");
          
                // if(colo)
                // foreach(string s incolor)
                foreach(char a in text){
               
                    if(!CharsOk.Contains(a.ToString())) {
                        Console.Write("The characters must be one of these: \\, /, O, o. . ");
                    } else {
                        Character c = new Character();
                        // if (text[0] == a) {
                        c.WriteCharacter(20, 10, text[0], ConsoleColor.Red, screen);
                        Character c1 = new Character();
                        c1.WriteCharacter(20, 20, text[1], ConsoleColor.Red, screen);

                        Character c2 = new Character();
                        c2.WriteCharacter(20, 33,text[2], ConsoleColor.Red, screen);
                        Character c3 = new Character();
                        c3.WriteCharacter(20, 44, text[3], ConsoleColor.Red, screen);
                        Character c4 = new Character();
                        c4.WriteCharacter(20, 55, text[4], ConsoleColor.Red, screen);
                    }

                }       
              
            //   Console.ReadKey(true);
            }

    }
}