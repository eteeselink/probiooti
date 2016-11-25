using System;
using System.Collections.Generic;


namespace Antibiooti.Forum2016
{
    interface IText
    {
        void WriteText(string text,  List<string> color, IScreen screen); 
    }
}