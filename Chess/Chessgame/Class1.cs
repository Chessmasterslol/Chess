using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessgame
{
    public class Class1
{
            public Class1()
            {
 
 
                var Player1 = new Player();
                var Player2 = new Player();
 
                    DrawoBoard(Player1, Player2);
 
                while (true)
                {
 
                    var mymove = Player1.MakeMove(Player2.GetPieces());
 
            string[] board=  DrawoBoard(Player1, Player2);
                    PrintBoard(board);
                       
 
                    var mymove2 = Player2.MakeMove(Player1);
            DrawoBoard(Player1, Player2);
 
 
 
                }
 
            }
}
