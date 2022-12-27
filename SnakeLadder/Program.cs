using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SnakeLadder
{
    internal class SnakeLadder
    {
        public static void WelcomeMsg()
        {
            Console.WriteLine("Welcome to Snake and Ladder Game");
        }
        static void Main(string[] args)
        {
            WelcomeMsg();
            int position = 0;
            Console.WriteLine($"Initial starting position of Player :{position}");
            Console.ReadLine();
        }
    }
}
