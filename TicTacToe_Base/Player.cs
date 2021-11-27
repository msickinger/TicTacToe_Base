using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TicTacToe_Base
{
    public class Player
    {
       public string Name { get; set; }
       public string Character { get; set; }
       public Color TileColor    { get; set; }
       public Color CharColor { get; set; }

        public Player(string n, string c, Color t, Color ch)
        {
            Name = n;
            Character = c;
            TileColor = t;
            CharColor = ch;
        }
        public Player(Player p)
        {
            Name = p.Name;
            Character = p.Character;
            TileColor = p.TileColor;
            CharColor = p.CharColor;
        }
    }
}
