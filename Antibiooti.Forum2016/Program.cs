using System;

namespace Antibiooti.Forum2016
{
    public class Program
    {
        public static void Main(string[] args)
        {

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

            Console.WriteLine("Enter command (T/M), characters, color and Press Enter:");
            line = Console.ReadLine();

            char[] whitespace = new char[] { ' ', '\t' };
            string[] ssizes = line.Split(whitespace);
            Console.WriteLine("Command Type: " + ssizes[0]);
            Console.WriteLine("String:" + ssizes[1]);
           // Console.WriteLine("Color:" + ssizes[2]);
            // Text section
            if(ssizes[0].Equals("T"))
            {

            }
            else if(ssizes[0].Equals("M")) // Movie Section
            {
               string filePath = ssizes[1];
              MovieMaker mvmaker = new MovieMaker(ssizes);

            }

          //  commandName=line.Substring(0, 1).Trim();
          //  characters=line.Substring(0, 1).Trim();
           //  Command cmd=new Command(commandName, );   


            
        }
    }
}
