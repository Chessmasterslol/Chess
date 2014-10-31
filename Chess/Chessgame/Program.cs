using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessgame
{
    class Program
    {
        public static String m_PlayerColor;
        static void Main(string[] args)
        {

            Chessbord chess = new Chessbord();

            m_PlayerColor = "Black";
            Console.WriteLine("Player color is...");
            Console.WriteLine(m_PlayerColor);
            if (m_PlayerColor == "Black")

                Console.WriteLine("My first move is: e2 -> e4");
            else
                Console.WriteLine("Please enter your first move!");
        }
        //choose the colour

        public enum ChessColor
        {
            White,
            Black,
        }
    }
}

