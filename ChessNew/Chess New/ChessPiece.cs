using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_New
{
    public class ChessMoves
    {
        public int positionX { get; set; }
        public int positionY { get; set; }
        public int x;
        public int y;
        public virtual void GetPostition()
        {
        }

        public void Move()
        {
            
        }
        public virtual void GetSymbol()
        {
            
        }
    }

    public class ChessPiece : ChessMoves
    {
        public void GetPosition()
        {
            
        }

        public override string GetSymbol()
        {
            
        }
    }
}
