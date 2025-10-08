using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zainProject
{
    enum FontTheme
    {
        Normal,
        Danger,
        success,

    }
     static class CommonOutputFormat
    {
        static void ChangeConsoleTheme(FontTheme Theme) {

            if (Theme == FontTheme.Normal)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (Theme == FontTheme.Danger)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;


            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;

            }


        }
            
    }
}
