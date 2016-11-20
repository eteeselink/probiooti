using System;

namespace Antibiooti.Forum2016
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using(var screen = new Screen()) {
                screen.Clear();
                screen.Write(20, 10, "    *   *   *     *   *   *    *   *   *     *   *   *");
                screen.Write(20, 11, "      * * *         * * *        * * *         * * *  ");
                screen.Write(20, 12, "    * * * * *     * * * * *    * * * * *     * * * * *");
                screen.Write(20, 13, "      * * *         * * *        * * *         * * *  ");
                screen.Write(20, 14, "    *   *   *     *   *   *    *   *   *     *   *   *");
                Console.ReadKey(true);
            }
        }
    }
}
