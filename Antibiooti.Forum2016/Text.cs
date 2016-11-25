using System;
using System.Collections.Generic;

namespace probiooti.Antibiooti.Forum2016
{
    public class Text: IText
    {
        enum CharsExpected
        {
            SlashLeft = '\\',
            SlashRight = '/',
            BigO = 'O',
            SmallO = 'o',
            Dot = '.'
        }

        public void WriteText(string text, int color , List<int> colors){
            foreach(char a in text){
                
            }

        }
    }
}