using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessgame
{
     class ChessPiece : Moves
    {
        king kung = new king();
        queen drottning = new queen();
        rooks torn = new rooks();
        bishops Löpare = new bishops();
        knights häst = new knights();
        pawns bönder = new pawns();

     
            private List<Moves> possibleMoves { get; set; }

           
        }
    }

