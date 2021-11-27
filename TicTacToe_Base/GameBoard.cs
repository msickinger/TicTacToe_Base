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

        //global variables for functions
        PlayerSetup parent;
        
        Player P1, P2;
        bool turnP1 = true;
        bool turnP2 = false;
        string winner;
        DialogResult result;
        
        public GameBoard()
        {
            InitializeComponent();
        }
        //initialize gameboard and pass player data through constructor
        public GameBoard(PlayerSetup parent, Player p1, Player p2)
        {
            InitializeComponent();
            this.parent = parent;
            parent.Hide();
           
            
            P1 = new Player (p1);
            P2 = new Player (p2);

        }
        //Load the gameboard with players' attributes
        private void GameBoard_Load(object sender, EventArgs e)
        {
            lblGBP1Name.Text = P1.Name;
            tableLayoutPanel2.BackColor = P1.TileColor;
            tableLayoutPanel3.BackColor = P2.TileColor;
            lblGBP1Name.BackColor = P1.TileColor;
            lblGBP1Name.ForeColor = P1.CharColor;
            lblGBP1Char.Text = P1.Character;
            lblGBP1Char.ForeColor = P1.CharColor;
            lblGBP1Char.BackColor = P1.TileColor;
            lblGBP2Name.Text = P2.Name;
            lblGBP2Name.BackColor = P2.TileColor;
            lblGBP2Name.ForeColor = P2.CharColor;
            lblGBP2Char.Text = P2.Character;
            lblGBP2Char.ForeColor = P2.CharColor;
            lblGBP2Char.BackColor = P2.TileColor;

            lblGBTurn.Text = P1.Name + "'s Turn";
            lblGBTurn.BackColor = P1.TileColor;
            lblGBTurn.ForeColor = P1.CharColor;


        }
        public void clickTurn(object sender) //Changes bottom label when player plays (changes turns)
        {
            Label icon = sender as Label;
            
            if (turnP1 == true)
            {
               
                icon.Text = P1.Character;
                icon.BackColor = P1.TileColor;
                icon.ForeColor = P1.CharColor;
                lblGBTurn.Text = P2.Name + "'s Turn";
                lblGBTurn.BackColor = P2.TileColor;
                lblGBTurn.ForeColor = P2.CharColor;
                turnP1 = false;
                turnP2 = true;
               
            }
            else if (turnP2 == true)
            {
               
                icon.Text = P2.Character;
                icon.BackColor = P2.TileColor;
                icon.ForeColor = P2.CharColor;
                lblGBTurn.Text = P1.Name + "'s Turn";
                lblGBTurn.BackColor = P1.TileColor;
                lblGBTurn.ForeColor = P1.CharColor;
                turnP2 = false;
                turnP1 = true;
            }
        }
      //for all labels on game board, if clicked display player's attributes and check for win
        private void label1_Click(object sender, EventArgs e)
        {
            clickTurn(sender);
            checkWin();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            clickTurn(sender);
            checkWin();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            clickTurn(sender);
            checkWin();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            clickTurn(sender);
            checkWin();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            clickTurn(sender);
            checkWin();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            clickTurn(sender);
            checkWin();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            clickTurn(sender);
            checkWin();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            clickTurn(sender);
            checkWin();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            clickTurn(sender);
            checkWin();
        }
        //checks all possibilities of a win and displays dialog box with options
        //to play again or close the application
        public void checkWin()
        {


            //1st row win
            if (label1.Text == P1.Character && label2.Text == P1.Character && label3.Text == P1.Character)
            {
                winner = "The winner is " + P1.Name +". Do you want to play again?";
                result = MessageBox.Show(winner, "Game Over", MessageBoxButtons.YesNo);
            }

            else if (label1.Text == P2.Character && label2.Text == P2.Character && label3.Text == P2.Character)
            {
                winner = "The winner is " + P2.Name + ". Do you want to play again?"; 
                result = MessageBox.Show(winner, "Game Over", MessageBoxButtons.YesNo);

            }


            //2nd row win
            else if (label6.Text == P1.Character && label4.Text == P1.Character && label5.Text == P1.Character)
            {
                winner = "The winner is " + P1.Name + ". Do you want to play again?" ;
                result = MessageBox.Show(winner, "Game Over", MessageBoxButtons.YesNo);
            }

            else if (label6.Text == P2.Character && label4.Text == P2.Character && label5.Text == P2.Character)
            {
                winner = "The winner is " + P2.Name + ". Do you want to play again?";
                result = MessageBox.Show(winner, "Game Over", MessageBoxButtons.YesNo);
            }


            //3rd row win
            else if (label9.Text == P1.Character && label8.Text == P1.Character && label7.Text == P1.Character)
            {
                winner = "The winner is " + P1.Name + ". Do you want to play again?";
                result = MessageBox.Show(winner, "Game Over", MessageBoxButtons.YesNo);
            }

            else if (label9.Text == P2.Character && label8.Text == P2.Character && label7.Text == P2.Character)
            {
                winner = "The winner is " + P2.Name + ". Do you want to play again?";
                result = MessageBox.Show(winner, "Game Over", MessageBoxButtons.YesNo);
            }


            //1st column win
            else if (label1.Text == P1.Character && label6.Text == P1.Character && label9.Text == P1.Character)
            {
                winner = "The winner is " + P1.Name + ". Do you want to play again?";
                result = MessageBox.Show(winner, "Game Over", MessageBoxButtons.YesNo);
            }

            else if (label1.Text == P2.Character && label6.Text == P2.Character && label9.Text == P2.Character)
            {
                winner = "The winner is " + P2.Name + ". Do you want to play again?";
                result = MessageBox.Show(winner, "Game Over", MessageBoxButtons.YesNo);
            }


            //2nd col win
            else if (label2.Text == P1.Character && label4.Text == P1.Character && label8.Text == P1.Character)
            {
                winner = "The winner is " + P1.Name + ". Do you want to play again?";
                result = MessageBox.Show(winner, "Game Over", MessageBoxButtons.YesNo);
            }

            else if (label2.Text == P2.Character && label4.Text == P2.Character && label8.Text == P2.Character)
            {
                winner = "The winner is " + P2.Name + ". Do you want to play again?";
                result = MessageBox.Show(winner, "Game Over", MessageBoxButtons.YesNo);
            }


            //3rd col win
            else if (label3.Text == P1.Character && label5.Text == P1.Character && label7.Text == P1.Character)
            {
                winner = "The winner is " + P1.Name + ". Do you want to play again?";
                result = MessageBox.Show(winner, "Game Over", MessageBoxButtons.YesNo);
            }

            else if (label3.Text == P2.Character && label5.Text == P2.Character && label7.Text == P2.Character)
            {
                winner = "The winner is " + P2.Name + ". Do you want to play again?";
                result = MessageBox.Show(winner, "Game Over", MessageBoxButtons.YesNo);
            }


            //left diagonal win
            else if (label1.Text == P1.Character && label4.Text == P1.Character && label7.Text == P1.Character)
            {
                winner = "The winner is " + P1.Name + ". Do you want to play again?";
                result = MessageBox.Show(winner, "Game Over", MessageBoxButtons.YesNo);
            }

            else if (label1.Text == P2.Character && label4.Text == P2.Character && label7.Text == P2.Character)
            {
                winner = "The winner is " + P2.Name + ". Do you want to play again?";
                result = MessageBox.Show(winner, "Game Over", MessageBoxButtons.YesNo);
            }


            //right diagonal win
            else if (label3.Text == P1.Character && label4.Text == P1.Character && label9.Text == P1.Character)
            {

                winner = "The winner is " + P1.Name + ". Do you want to play again?";
                result = MessageBox.Show(winner, "Game Over", MessageBoxButtons.YesNo);
            }

            else if (label3.Text == P2.Character && label4.Text == P2.Character && label9.Text == P2.Character)
            {
                winner = "The winner is " + P2.Name + ". Do you want to play again?";
                result = MessageBox.Show(winner, "Game Over", MessageBoxButtons.YesNo);
            }

           
            if (result ==DialogResult.Yes)
            {
                PlayerSetup obj = new PlayerSetup();
                obj.Show();
                this.Close();

            }
            else if(result== DialogResult.No)
            {
                Application.Exit();
            }


        }
       
    }
}
