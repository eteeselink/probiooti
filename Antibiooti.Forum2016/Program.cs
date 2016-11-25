using System;

namespace Antibiooti.Forum2016
{
    public class Program
    {
        public static void Main(string[] args)
        {
          /*  using(var screen = new Screen()) {
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
            string commandName;

            Console.WriteLine("Enter command (T/M), characters, color and Press Enter:");
            line = Console.ReadLine();
            commandName=line.Substring(0, 1).Trim();
           if(commandName=="T")
            {
               // var TextCommand= new Command();
                Console.WriteLine("Text");
            };

     
    
                   
        }
    }
}
