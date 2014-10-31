using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Chessgame
{
    public class ChessMoves
    {
        public int positionX { get; set; }
        public int positionY { get; set; }
        public int x;
        public int y;
       
    }

    public abstract class Fat
    {
        public virtual int Move(int x, int y)
        {
            
        }
    }
}

