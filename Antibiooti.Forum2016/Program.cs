using System;
using System.Collections.Generic;

namespace Antibiooti.Forum2016
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IScreen screen = new Screen();
           // MovieMaker mm = new MovieMaker(args);
            //mm.buildScreenTemplates();

          /*  using(var screen = new Screen()) {
            using(var screen = new Screen()) {
                screen.Clear();
                screen.Write(10, 10, "*   *   *     *   *   *    *   *   *     *   *   *     *   *   *");
                screen.Write(10, 11, "  * * *         * * *        * * *         * * *         * * *  ");
                screen.Write(10, 12, "* * * * *     * * * * *    * * * * *     * * * * *     * * * * *");
                screen.Write(10, 13, "  * * *         * * *        * * *         * * *         * * *  ");
                screen.Write(10, 14, "*   *   *     *   *   *    *   *   *     *   *   *     *   *   *");
                Console.ReadKey(true);
            }
            */
            string line;
           // string commandName;  

            Console.WriteLine("Syntax for commandline can be one of the two");
            Console.WriteLine("1. <T>,<5-character string>,<5-color strings(one per light)");
            Console.WriteLine("2. <M>,<FilePath>");
            Console.WriteLine("For example::");
            Console.WriteLine("T,0o.0o,blue,red,green,blue,red");
            Console.WriteLine("M,D:\\Continuous Integration\\movie.txt");
            line = Console.ReadLine();

            char[] whitespace = new char[] {','};
            string[] userInputArgs = line.Split(whitespace);
            
            Console.WriteLine("Command Type: " + userInputArgs[0]);
            if(userInputArgs.Length <= 1)
            {
                Console.WriteLine("Incorrect argument format. Please look at the examples and try again.");
                
            }
            else if (userInputArgs[0].Equals("T"))
            {
               int characterTextLength = userInputArgs[1].Length;
               if(characterTextLength != 5)
               {
                   Console.WriteLine("Character String should be 5 characters long");
               }            
               //Parse the colors and add it to a list, userInputArgs[2:6] 
               List<string> colorList = new List<string>(); 
               for(int index = 2;index < userInputArgs.Length;index++)
               {
                 colorList.Add(userInputArgs[index]);
               }    
/*               foreach(string color in colorList)
               {
                 Console.WriteLine("Color: " + color);
               }       */    
               IText text = new Text();
               text.WriteText(userInputArgs[1],null,screen); 

            }
            else if (userInputArgs[0].Equals("M")) 
            {
                string filePath = userInputArgs[1];
                MovieMaker mvmaker = new MovieMaker(userInputArgs);
                List<ScreenTemplate> screenList = mvmaker.buildScreenTemplates();
                foreach(ScreenTemplate cur in screenList){
                    IText text = new Text();
                    text.WriteText(new string(cur.getSymbols()), new List<string>(new string[] { cur.getColor().ToString() }),screen);
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
    }
}
