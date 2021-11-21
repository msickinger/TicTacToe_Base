using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Base
{
    public class Player
    {
        string Name { get; set; }
        string Character { get; set; }
        string TileColor    { get; set; }
        string CharColor { get; set; }

        Player(string n, string c, string t, string ch)
        {
            Name = n;
            Character = c;
            TileColor = t;
            CharColor = ch;
        }
    }
}
