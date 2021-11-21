using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Base
{
    public partial class GameBoard : Form
    {
        PlayerSetup parent;
        public GameBoard()
        {
            InitializeComponent();
        }
        public GameBoard(PlayerSetup parent)
        {
            InitializeComponent();
            this.parent = parent;
            parent.Hide();

        }

        private void GameBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
