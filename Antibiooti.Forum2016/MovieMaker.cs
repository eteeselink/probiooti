using System;
using System.IO;
using System.Collections.Generic;
namespace Antibiooti.Forum2016
{
    public class MovieMaker
    {
        private String[] allLines;
        public MovieMaker(string[] args){
                    string fileName = args[1];
                    Console.WriteLine("File Name: " + fileName);
                    try{
                      allLines = File.ReadAllLines(fileName); 
                    } catch (Exception e) {
                        Console.WriteLine("Unable to read file",e);
                    }
        }
        public List<ScreenTemplate> buildScreenTemplates(){
            List<ScreenTemplate> result = new List<ScreenTemplate>();
            for(int i=0;i<allLines.Length;i++){
                ScreenTemplate st = new ScreenTemplate();
                char[] whitespace = new char[] { ' ', '\t' };
                string[] symbolsAndColor = allLines[i].Split(whitespace);
                char[] allSymbols = symbolsAndColor[0].ToCharArray();
                if (allSymbols.Length==5&&symbolsAndColor[1].Length>0){
                    char[] onlySymbols = new char[5];
                    Array.Copy(allSymbols, 0, onlySymbols, 0, 5);
                    st.setSymbols(onlySymbols);
                    foreach(ConsoleColor currentColor in Enum.GetValues(typeof(ConsoleColor))){
                        if (currentColor.ToString().Equals(symbolsAndColor[1], StringComparison.CurrentCultureIgnoreCase))
                        {
                            st.setColor(currentColor);
                            break;
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