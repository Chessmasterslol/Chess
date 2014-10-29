using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessgame
{
    class Program
    {
        static void Main(string[] args)
        {
            string plats1 = "T";
            string plats2 = "H";
            string plats3 = "B";
            string plats4 = "Q";

            string plats5 = "K";
            string plats6 = "B";
            string plats7 = "H";
            string plats8 = "T";

            string plats9 = "P";
            string plats10 = "P";
            string plats11 = "P";
            string plats12 = "P";

            string plats13 = "P";
            string plats14 = "P";
            string plats15 = "P";
            string plats16 = "P";

            Console.WriteLine(plats1 + " " + plats2 + " " + plats3 + " " + plats4 + " " + plats5 + " " + plats6 + " " + plats7 + " " + plats8);
            Console.WriteLine(plats9 + " " + plats10 + " " + plats11 + " " + plats12 + " " + plats13 + " " + plats14 + " " + plats15 + " " + plats16);
            Console.ReadKey();
            Chessbord chess = new Chessbord();


        }
    }
}
