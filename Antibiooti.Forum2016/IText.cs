using System;
using System.Collections.Generic;


namespace Antibiooti.Forum2016
{
    interface IText
    {
        void WriteText(string text,  string color, ConsoleColor colors , IScreen screen); 
    }
}