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

            ConsoleColor color1 = ConsoleColor.Red;
            ConsoleColor color2 = ConsoleColor.Red;
            ConsoleColor color3 = ConsoleColor.Red;
            ConsoleColor color4 = ConsoleColor.Red;
            ConsoleColor color5 = ConsoleColor.Red;

            if(color!=null && color.Count > 0) {
                foreach(string s in color) {
                    // s.
                }
            }
            
                foreach(char a in text){
               
                    if(!CharsOk.Contains(a.ToString())) {
                        Console.Write("The characters must be one of these: x,\\, /, O, o. . ");
                    } 
                }
                        Character c = new Character();
                        c.WriteCharacter(20, 10, text[0], color1, screen);
                        Character c1 = new Character();
                        c1.WriteCharacter(20, 24, text[1], color2, screen);
                        Character c2 = new Character();
                        c2.WriteCharacter(20, 38,text[2], color3, screen);
                        Character c3 = new Character();
                        c3.WriteCharacter(20, 52, text[3], color4, screen);
                        Character c4 = new Character();
                        c4.WriteCharacter(20, 66, text[4], color5, screen);
              
            //   Console.ReadKey(true);
            }

    }
}