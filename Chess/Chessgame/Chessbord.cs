using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessgame
{
    //Är shackbrädet.
    class Chessbord
    {
        public string Chessbord()
        {
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("█");
                    Console.WriteLine();
                }
            }

            for (int x = 0; x < 8; x = x + 2)
            {
                for (int y = 0; y < 8; y = y + 2)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ");
                    Console.WriteLine();
                }
            }
            for (int x = 1; x < 8; x = x + 2)
            {
                for (int y = 1; y < 8; y = y + 2)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ");
                    Console.WriteLine();
                }
            }
            return ;
        }
    }   
}
