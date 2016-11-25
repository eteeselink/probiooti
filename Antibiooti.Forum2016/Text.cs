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

        const string CharsOk = "|x\\/Oo.";

        public void WriteText(string text, List<string> color , IScreen screen){

            ConsoleColor color1 = ConsoleColor.Red;
            ConsoleColor color2 = ConsoleColor.Green;
            ConsoleColor color3 = ConsoleColor.Red;
            ConsoleColor color4 = ConsoleColor.Yellow;
            ConsoleColor color5 = ConsoleColor.Red;

            if(color==null) {
                Console.Write(color);
            }
            if(color!=null && color.Count > 0) {
                for(int b=0; b<color.Count; b++) {
                    if(b==0) {
                        color1 = assignColor(color[b]);
                    } else if (b==1) {
                        color2 = assignColor(color[b]);
                    } else if (b==2) {
                        color3 = assignColor(color[b]);
                    } else if (b==3) {
                        color4 = assignColor(color[b]);
                    } else if (b==4) {
                        color5 = assignColor(color[b]);
                    }
                }
            }
            
                foreach(char a in text){
                    if(!CharsOk.Contains(a.ToString())) {
                        Console.Write("The characters must be one of these: |,x,\\, /, O, o. . ");
                    } 
                }
                        Character c = new Character();
                        c.WriteCharacter(5, 10, text[0], color1, screen);
                        Character c1 = new Character();
                        c1.WriteCharacter(5, 24, text[1], color2, screen);
                        Character c2 = new Character();
                        c2.WriteCharacter(5, 38,text[2], color3, screen);
                        Character c3 = new Character();
                        c3.WriteCharacter(5, 52, text[3], color4, screen);
                        Character c4 = new Character();
                        c4.WriteCharacter(5, 66, text[4], color5, screen);
                        Console.ResetColor();
            }

        ConsoleColor assignColor(String s) {
            if (s.Equals("Red", StringComparison.CurrentCultureIgnoreCase)) {
                return ConsoleColor.Red;
            } else if (s.Equals("Green", StringComparison.CurrentCultureIgnoreCase)) {
               return ConsoleColor.Green; 
            } else if (s.ToLower() == "blue") {
               return ConsoleColor.Blue; 
            }
            return ConsoleColor.Red;
        }

    }

}