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
    public partial class PlayerSetup : Form
    {
        //global player variables and parent form variable
        Player p1;
        Player p2;
        Form1 parent;
        public PlayerSetup()
        {
            InitializeComponent();
        }
        //constructor with parent class
        public PlayerSetup(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            parent.Hide();
            parent.Visible = false;
        }
        //when button is clicked, pick a color for player tile (Player 1)
        private void btnTileColorP1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnTileColorP1.BackColor = colorDialog1.Color;
            }
        }
        //Check if both Ready checkboxes have been checked
        public void checkReady()//check if both ready 
        {
            if (chkP1Ready.Checked == true && chkP2Ready.Checked == true)
            {

                GameBoard obj = new GameBoard(this, p1, p2);
                obj.Show();

            }
        }
        //if player is ready, initialize player with attributes from controls on form
        private void chkP1Ready_CheckedChanged(object sender, EventArgs e)
        {
            chkP1Ready.BackColor = Color.Green;
           foreach (Control c in tableLayoutPanel1.Controls)//if tile is picked, use it as player's character
            {
                if (c.BackColor == btnTileColorP1.BackColor)//construct player 1
                    p1 = new Player(txtPlayer1Name.Text, c.Text, c.BackColor, c.ForeColor);
            }
            checkReady();
        }

        private void chkP2Ready_CheckedChanged(object sender, EventArgs e)
        {
            chkP2Ready.BackColor = Color.Green;
            foreach (Control c in tableLayoutPanel2.Controls)
            {
                if (c.BackColor == btnTileColorP2.BackColor)//construct player 2
                    p2 = new Player(txtPlayer2Name.Text, c.Text, c.BackColor, c.ForeColor);
            }
            checkReady();
        }

       
        //for each button, check in the table layout for various conditions
        private void button1_Click(object sender, EventArgs e)
        {
            Button icon = sender as Button;
            if (icon.BackColor == Color.Red)
                return;
            else
            {
                foreach (Control c in tableLayoutPanel1.Controls)//check if other player picked this character
                {
                    if (c.BackColor == Color.Red)
                    {
                        c.BackColor = Color.Red;
                        c.ForeColor = Color.Black;
                    }
                 else if (icon.Text != c.Text)//make sure no other character is highlighted
                    {
                        c.BackColor = splitContainer1.Panel1.BackColor;
                        c.ForeColor = Color.Black;
                    }
                }
                icon.ForeColor = btnCharColorP1.BackColor;//highlight picked character
                icon.BackColor = btnTileColorP1.BackColor;
                foreach (Control c1 in tableLayoutPanel2.Controls)
                {
                    if (icon.Text == c1.Text)//make equivalent char in other player's options red
                    {
                        c1.BackColor = Color.Red;
                        c1.ForeColor = Color.Black;
                    }
                    else if (c1.BackColor == btnTileColorP2.BackColor) //make sure not to make red the other player's picked character
                    {
                        c1.BackColor = btnTileColorP2.BackColor;
                        c1.ForeColor = btnCharColorP2.BackColor;
                    }
                    else//default colors for all other nonpicked characters
                    {
                        c1.BackColor = splitContainer1.Panel2.BackColor;
                        c1.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button icon = sender as Button;
            if (icon.BackColor == Color.Red)
                return;
            else
            {
                foreach (Control c in tableLayoutPanel1.Controls)
                {
                    if (c.BackColor == Color.Red)
                    {
                        c.BackColor = Color.Red;
                        c.ForeColor = Color.Black;
                    }
                    else if (icon.Text != c.Text)
                    {
                        c.BackColor = splitContainer1.Panel1.BackColor;
                        c.ForeColor = Color.Black;
                    }
                }
                icon.ForeColor = btnCharColorP1.BackColor;
                icon.BackColor = btnTileColorP1.BackColor;
                foreach (Control c1 in tableLayoutPanel2.Controls)
                {
                    if (icon.Text == c1.Text)
                    {
                        c1.BackColor = Color.Red;
                        c1.ForeColor = Color.Black;
                    }
                    else if (c1.BackColor == btnTileColorP2.BackColor)
                    {
                        c1.BackColor = btnTileColorP2.BackColor;
                        c1.ForeColor = btnCharColorP2.BackColor;
                    }
                    else
                    {
                        c1.BackColor = splitContainer1.Panel2.BackColor;
                        c1.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button icon = sender as Button;
            if (icon.BackColor == Color.Red)
                return;
            else
            {
                foreach (Control c in tableLayoutPanel1.Controls)
                {
                    if (c.BackColor == Color.Red)
                    {
                        c.BackColor = Color.Red;
                        c.ForeColor = Color.Black;
                    }
                    else if (icon.Text != c.Text)
                    {
                        c.BackColor = splitContainer1.Panel1.BackColor;
                        c.ForeColor = Color.Black;
                    }
                }
                icon.ForeColor = btnCharColorP1.BackColor;
                icon.BackColor = btnTileColorP1.BackColor;
                foreach (Control c1 in tableLayoutPanel2.Controls)
                {
                    if (icon.Text == c1.Text)
                    {
                        c1.BackColor = Color.Red;
                        c1.ForeColor = Color.Black;
                    }
                    else if (c1.BackColor == btnTileColorP2.BackColor)
                    {
                        c1.BackColor = btnTileColorP2.BackColor;
                        c1.ForeColor = btnCharColorP2.BackColor;
                    }
                    else
                    {
                        c1.BackColor = splitContainer1.Panel2.BackColor;
                        c1.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button icon = sender as Button;
            if (icon.BackColor == Color.Red)
                return;
            else
            {
                foreach (Control c in tableLayoutPanel1.Controls)
                {
                    if (c.BackColor == Color.Red)
                    {
                        c.BackColor = Color.Red;
                        c.ForeColor = Color.Black;
                    }
                    else if (icon.Text != c.Text)
                    {
                        c.BackColor = splitContainer1.Panel1.BackColor;
                        c.ForeColor = Color.Black;
                    }
                }
                icon.ForeColor = btnCharColorP1.BackColor;
                icon.BackColor = btnTileColorP1.BackColor;
                foreach (Control c1 in tableLayoutPanel2.Controls)
                {
                    if (icon.Text == c1.Text)
                    {
                        c1.BackColor = Color.Red;
                        c1.ForeColor = Color.Black;
                    }
                    else if (c1.BackColor == btnTileColorP2.BackColor)
                    {
                        c1.BackColor = btnTileColorP2.BackColor;
                        c1.ForeColor = btnCharColorP2.BackColor;
                    }
                    else
                    {
                        c1.BackColor = splitContainer1.Panel2.BackColor;
                        c1.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button icon = sender as Button;
            if (icon.BackColor == Color.Red)
                return;
            else
            {
                foreach (Control c in tableLayoutPanel1.Controls)
                {
                    if (c.BackColor == Color.Red)
                    {
                        c.BackColor = Color.Red;
                        c.ForeColor = Color.Black;
                    }
                    else if (icon.Text != c.Text)
                    {
                        c.BackColor = splitContainer1.Panel1.BackColor;
                        c.ForeColor = Color.Black;
                    }
                }
                icon.ForeColor = btnCharColorP1.BackColor;
                icon.BackColor = btnTileColorP1.BackColor;
                foreach (Control c1 in tableLayoutPanel2.Controls)
                {
                    if (icon.Text == c1.Text)
                    {
                        c1.BackColor = Color.Red;
                        c1.ForeColor = Color.Black;
                    }
                    else if (c1.BackColor == btnTileColorP2.BackColor)
                    {
                        c1.BackColor = btnTileColorP2.BackColor;
                        c1.ForeColor = btnCharColorP2.BackColor;
                    }
                    else
                    {
                        c1.BackColor = splitContainer1.Panel2.BackColor;
                        c1.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button icon = sender as Button;
            if (icon.BackColor == Color.Red)
                return;
            else
            {
                foreach (Control c in tableLayoutPanel1.Controls)
                {
                    if (c.BackColor == Color.Red)
                    {
                        c.BackColor = Color.Red;
                        c.ForeColor = Color.Black;
                    }
                    else if (icon.Text != c.Text)
                    {
                        c.BackColor = splitContainer1.Panel1.BackColor;
                        c.ForeColor = Color.Black;
                    }
                }
                icon.ForeColor = btnCharColorP1.BackColor;
                icon.BackColor = btnTileColorP1.BackColor;
                foreach (Control c1 in tableLayoutPanel2.Controls)
                {
                    if (icon.Text == c1.Text)
                    {
                        c1.BackColor = Color.Red;
                        c1.ForeColor = Color.Black;
                    }
                    else if (c1.BackColor == btnTileColorP2.BackColor)
                    {
                        c1.BackColor = btnTileColorP2.BackColor;
                        c1.ForeColor = btnCharColorP2.BackColor;
                    }
                    else
                    {
                        c1.BackColor = splitContainer1.Panel2.BackColor;
                        c1.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button icon = sender as Button;
            if (icon.BackColor == Color.Red)
                return;
            else
            {
                foreach (Control c in tableLayoutPanel1.Controls)
                {
                    if (c.BackColor == Color.Red)
                    {
                        c.BackColor = Color.Red;
                        c.ForeColor = Color.Black;
                    }
                    else if (icon.Text != c.Text)
                    {
                        c.BackColor = splitContainer1.Panel1.BackColor;
                        c.ForeColor = Color.Black;
                    }
                }
                icon.ForeColor = btnCharColorP1.BackColor;
                icon.BackColor = btnTileColorP1.BackColor;
                foreach (Control c1 in tableLayoutPanel2.Controls)
                {
                    if (icon.Text == c1.Text)
                    {
                        c1.BackColor = Color.Red;
                        c1.ForeColor = Color.Black;
                    }
                    else if (c1.BackColor == btnTileColorP2.BackColor)
                    {
                        c1.BackColor = btnTileColorP2.BackColor;
                        c1.ForeColor = btnCharColorP2.BackColor;
                    }
                    else
                    {
                        c1.BackColor = splitContainer1.Panel2.BackColor;
                        c1.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button icon = sender as Button;
            if (icon.BackColor == Color.Red)
                return;
            else
            {
                foreach (Control c in tableLayoutPanel1.Controls)
                {
                    if (c.BackColor == Color.Red)
                    {
                        c.BackColor = Color.Red;
                        c.ForeColor = Color.Black;
                    }
                    else if (icon.Text != c.Text)
                    {
                        c.BackColor = splitContainer1.Panel1.BackColor;
                        c.ForeColor = Color.Black;
                    }
                }
                icon.ForeColor = btnCharColorP1.BackColor;
                icon.BackColor = btnTileColorP1.BackColor;
                foreach (Control c1 in tableLayoutPanel2.Controls)
                {
                    if (icon.Text == c1.Text)
                    {
                        c1.BackColor = Color.Red;
                        c1.ForeColor = Color.Black;
                    }
                    else if (c1.BackColor == btnTileColorP2.BackColor)
                    {
                        c1.BackColor = btnTileColorP2.BackColor;
                        c1.ForeColor = btnCharColorP2.BackColor;
                    }
                    else
                    {
                        c1.BackColor = splitContainer1.Panel2.BackColor;
                        c1.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button icon = sender as Button;
            if (icon.BackColor == Color.Red)
                return;
            else
            {
                foreach (Control c in tableLayoutPanel2.Controls)
                {
                    if (c.BackColor == Color.Red)
                    {
                        c.BackColor = Color.Red;
                        c.ForeColor = Color.Black;
                    }
                    else if (icon.Text != c.Text)
                    {
                        c.BackColor = splitContainer1.Panel2.BackColor;
                        c.ForeColor = Color.Black;
                    }
                }
                icon.ForeColor = btnCharColorP2.BackColor;
                icon.BackColor = btnTileColorP2.BackColor;
                foreach (Control c1 in tableLayoutPanel1.Controls)
                {
                    if (icon.Text == c1.Text)
                    {
                        c1.BackColor = Color.Red;
                        c1.ForeColor = Color.Black;
                    }
                    else if (c1.BackColor == btnTileColorP1.BackColor)
                    {
                        c1.BackColor = btnTileColorP1.BackColor;
                        c1.ForeColor = btnCharColorP1.BackColor;
                    }
                    else
                    {
                        c1.BackColor = splitContainer1.Panel1.BackColor;
                        c1.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button icon = sender as Button;
            if (icon.BackColor == Color.Red)
                return;
            else
            {
                foreach (Control c in tableLayoutPanel2.Controls)
                {
                    if (c.BackColor == Color.Red)
                    {
                        c.BackColor = Color.Red;
                        c.ForeColor = Color.Black;
                    }
                    else if (icon.Text != c.Text)
                    {
                        c.BackColor = splitContainer1.Panel2.BackColor;
                        c.ForeColor = Color.Black;
                    }
                }
                icon.ForeColor = btnCharColorP2.BackColor;
                icon.BackColor = btnTileColorP2.BackColor;
                foreach (Control c1 in tableLayoutPanel1.Controls)
                {
                    if (icon.Text == c1.Text)
                    {
                        c1.BackColor = Color.Red;
                        c1.ForeColor = Color.Black;
                    }
                    else if (c1.BackColor == btnTileColorP1.BackColor)
                    {
                        c1.BackColor = btnTileColorP1.BackColor;
                        c1.ForeColor = btnCharColorP1.BackColor;
                    }
                    else
                    {
                        c1.BackColor = splitContainer1.Panel1.BackColor;
                        c1.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button icon = sender as Button;
            if (icon.BackColor == Color.Red)
                return;
            else
            {
                foreach (Control c in tableLayoutPanel2.Controls)
                {
                    if (c.BackColor == Color.Red)
                    {
                        c.BackColor = Color.Red;
                        c.ForeColor = Color.Black;
                    }
                    else if (icon.Text != c.Text)
                    {
                        c.BackColor = splitContainer1.Panel2.BackColor;
                        c.ForeColor = Color.Black;
                    }
                }
                icon.ForeColor = btnCharColorP2.BackColor;
                icon.BackColor = btnTileColorP2.BackColor;
                foreach (Control c1 in tableLayoutPanel1.Controls)
                {
                    if (icon.Text == c1.Text)
                    {
                        c1.BackColor = Color.Red;
                        c1.ForeColor = Color.Black;
                    }
                    else if (c1.BackColor == btnTileColorP1.BackColor)
                    {
                        c1.BackColor = btnTileColorP1.BackColor;
                        c1.ForeColor = btnCharColorP1.BackColor;
                    }
                    else
                    {
                        c1.BackColor = splitContainer1.Panel1.BackColor;
                        c1.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button icon = sender as Button;
            if (icon.BackColor == Color.Red)
                return;
            else
            {
                foreach (Control c in tableLayoutPanel2.Controls)
                {
                    if (c.BackColor == Color.Red)
                    {
                        c.BackColor = Color.Red;
                        c.ForeColor = Color.Black;
                    }
                    else if (icon.Text != c.Text)
                    {
                        c.BackColor = splitContainer1.Panel2.BackColor;
                        c.ForeColor = Color.Black;
                    }
                }
                icon.ForeColor = btnCharColorP2.BackColor;
                icon.BackColor = btnTileColorP2.BackColor;
                foreach (Control c1 in tableLayoutPanel1.Controls)
                {
                    if (icon.Text == c1.Text)
                    {
                        c1.BackColor = Color.Red;
                        c1.ForeColor = Color.Black;
                    }
                    else if (c1.BackColor == btnTileColorP1.BackColor)
                    {
                        c1.BackColor = btnTileColorP1.BackColor;
                        c1.ForeColor = btnCharColorP1.BackColor;
                    }
                    else
                    {
                        c1.BackColor = splitContainer1.Panel1.BackColor;
                        c1.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button icon = sender as Button;
            if (icon.BackColor == Color.Red)
                return;
            else
            {
                foreach (Control c in tableLayoutPanel2.Controls)
                {
                    if (c.BackColor == Color.Red)
                    {
                        c.BackColor = Color.Red;
                        c.ForeColor = Color.Black;
                    }
                    else if (icon.Text != c.Text)
                    {
                        c.BackColor = splitContainer1.Panel2.BackColor;
                        c.ForeColor = Color.Black;
                    }
                }
                icon.ForeColor = btnCharColorP2.BackColor;
                icon.BackColor = btnTileColorP2.BackColor;
                foreach (Control c1 in tableLayoutPanel1.Controls)
                {
                    if (icon.Text == c1.Text)
                    {
                        c1.BackColor = Color.Red;
                        c1.ForeColor = Color.Black;
                    }
                    else if (c1.BackColor == btnTileColorP1.BackColor)
                    {
                        c1.BackColor = btnTileColorP1.BackColor;
                        c1.ForeColor = btnCharColorP1.BackColor;
                    }
                    else
                    {
                        c1.BackColor = splitContainer1.Panel1.BackColor;
                        c1.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button icon = sender as Button;
            if (icon.BackColor == Color.Red)
                return;
            else
            {
                foreach (Control c in tableLayoutPanel2.Controls)
                {
                    if (c.BackColor == Color.Red)
                    {
                        c.BackColor = Color.Red;
                        c.ForeColor = Color.Black;
                    }
                    else if (icon.Text != c.Text)
                    {
                        c.BackColor = splitContainer1.Panel2.BackColor;
                        c.ForeColor = Color.Black;
                    }
                }
                icon.ForeColor = btnCharColorP2.BackColor;
                icon.BackColor = btnTileColorP2.BackColor;
                foreach (Control c1 in tableLayoutPanel1.Controls)
                {
                    if (icon.Text == c1.Text)
                    {
                        c1.BackColor = Color.Red;
                        c1.ForeColor = Color.Black;
                    }
                    else if (c1.BackColor == btnTileColorP1.BackColor)
                    {
                        c1.BackColor = btnTileColorP1.BackColor;
                        c1.ForeColor = btnCharColorP1.BackColor;
                    }
                    else
                    {
                        c1.BackColor = splitContainer1.Panel1.BackColor;
                        c1.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button icon = sender as Button;
            if (icon.BackColor == Color.Red)
                return;
            else
            {
                foreach (Control c in tableLayoutPanel2.Controls)
                {
                    if (c.BackColor == Color.Red)
                    {
                        c.BackColor = Color.Red;
                        c.ForeColor = Color.Black;
                    }
                    else if (icon.Text != c.Text)
                    {
                        c.BackColor = splitContainer1.Panel2.BackColor;
                        c.ForeColor = Color.Black;
                    }
                }
                icon.ForeColor = btnCharColorP2.BackColor;
                icon.BackColor = btnTileColorP2.BackColor;
                foreach (Control c1 in tableLayoutPanel1.Controls)
                {
                    if (icon.Text == c1.Text)
                    { 
                        c1.BackColor = Color.Red;
                        c1.ForeColor = Color.Black;
                    }
                    else if (c1.BackColor == btnTileColorP1.BackColor)
                    {
                        c1.BackColor = btnTileColorP1.BackColor;
                        c1.ForeColor = btnCharColorP1.BackColor;
                    }
                    else
                    {
                        c1.BackColor = splitContainer1.Panel1.BackColor;
                        c1.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button icon = sender as Button;
            if (icon.BackColor == Color.Red)
                return;
            else
            {
                foreach (Control c in tableLayoutPanel2.Controls)
                {
                    if (c.BackColor == Color.Red)
                    {
                        c.BackColor = Color.Red;
                        c.ForeColor = Color.Black;
                    }
                    else if (icon.Text != c.Text)
                    {
                        c.BackColor = splitContainer1.Panel2.BackColor;
                        c.ForeColor = Color.Black;
                    }
                }
                icon.ForeColor = btnCharColorP1.BackColor;
                icon.BackColor = btnTileColorP1.BackColor;
                foreach (Control c1 in tableLayoutPanel1.Controls)
                {
                    if (icon.Text == c1.Text)
                    {
                        c1.BackColor = Color.Red;
                        c1.ForeColor = Color.Black;
                    }
                    else if (c1.BackColor == btnTileColorP1.BackColor)
                    {
                        c1.BackColor = btnTileColorP1.BackColor;
                        c1.ForeColor = btnCharColorP1.BackColor;
                    }
                    else
                    {
                        c1.BackColor = splitContainer1.Panel1.BackColor;
                        c1.ForeColor = Color.Black;
                    }
                }
            }
        }
        //pick colors for tile color and character color for each player
        private void btnCharColorP1_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                btnCharColorP1.BackColor = colorDialog2.Color;
            }
        }

        private void btnTileColorP2_Click(object sender, EventArgs e)
        {
            if (colorDialog3.ShowDialog() == DialogResult.OK)
            {
                btnTileColorP2.BackColor = colorDialog3.Color;
            }
        }

        private void btnCharColorP2_Click(object sender, EventArgs e)
        {
            if (colorDialog4.ShowDialog() == DialogResult.OK)
            {
                btnCharColorP2.BackColor = colorDialog4.Color;
            }
        }
    }
}
