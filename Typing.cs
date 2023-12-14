using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Скоропечатание
{
    internal class Typing
    {
        public int Test(string Text)
        {
            int rightsym = 0;
            while (true)
            {
                for (int i = 0; i < Text.Length; i++)
                {

                    ConsoleKeyInfo key1 = Console.ReadKey(true);
                    char symbol = Text[i];
                    if (key1.KeyChar == symbol)
                    {
                        Console.SetCursorPosition(i, 0);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(Text[i]);
                        rightsym++;

                    }
                    else if (key1.KeyChar != symbol)
                    {
                        Console.SetCursorPosition(i, 0);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(Text[i]);
                    }

                }
                break;
            }
            int symmin = rightsym / 1;
            int symsec = rightsym / 60;
            return rightsym;

        }

    }
}
         

