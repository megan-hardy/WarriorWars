using System;

namespace WarriorWars.Tools
{
    internal static class Decor  //simple tasks-actions that you don't want to write repeatedly
    {
        public static void ColorfulWriteLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
