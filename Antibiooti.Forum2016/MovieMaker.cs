using System;
using System.IO;
using System.Collections.Generic;
namespace Antibiooti.Forum2016
{
    public class MovieMaker
    {
        private String[] allLines;
        public MovieMaker(string[] args){
            if (args.Length>1) {
                switch (args[0]) {
                    case "movie":
                    string fileName = args[1];
                    try{
                      allLines = File.ReadAllLines("Antibiooti.Forum2016/"+fileName); 
                    } catch (Exception e) {
                        Console.WriteLine("Unable to read file",e);
                    }
                    break;
                }
            }
        }
        public List<ScreenTemplate> buildScreenTemplates(){
            List<ScreenTemplate> result = new List<ScreenTemplate>();
            for(int i=0;i<allLines.Length;i++){
                ScreenTemplate st = new ScreenTemplate();
                char[] allSymbols = allLines[i].ToCharArray();
                double colorDigit = Char.GetNumericValue(allSymbols[5]);
                if (allSymbols.Length==6&&colorDigit>=1&&colorDigit<=15){
                    char[] onlySymbols = new char[5];
                    Array.Copy(allSymbols, 0, onlySymbols, 0, 5);
                    st.setSymbols(onlySymbols);
                    foreach(ConsoleColor currentColor in Enum.GetValues(typeof(ConsoleColor))){
                        if (currentColor.GetHashCode()==Char.GetNumericValue(allSymbols[5])){
                            st.setColor(currentColor);
                        }
                    }
                } else {
                    throw new Exception("Wrong input string format");
                }       
            }
            return result;
        }
    }
}