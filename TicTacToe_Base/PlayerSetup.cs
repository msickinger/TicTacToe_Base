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
        Player p1;
        Player p2;
        Form1 parent;
       
        public PlayerSetup()
        {
            InitializeComponent();
        }
        public PlayerSetup(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            parent.Hide();
            parent.Visible = false;
        }
        private void btnTileColorP1_Click(object sender, EventArgs e)
        {

        }
        private void pickCharacter()
        {
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                CheckBox icon = c as CheckBox;
                if(icon.Checked ==true)
                {
                    icon.BackColor = btnTileColorP1.BackColor;
                    icon.ForeColor = btnCharColorP1.BackColor;
                    foreach (Control c2 in tableLayoutPanel2.Controls)
                    {
                        CheckBox icon2 = c2 as CheckBox;
                        if(icon2.Text ==icon.Text)
                        {
                            icon2.BackColor = Color.Red;
                            icon2.ForeColor = Color.Black;
                            
                        }
                    }
                    foreach (Control c3 in tableLayoutPanel1.Controls)
                    {
                        CheckBox icon3 = c3 as CheckBox;
                        if (icon3.Text != icon.Text)
                        {
                            icon.Checked = false;
                            icon.BackColor = splitContainer1.Panel1.BackColor;
                            icon.ForeColor = Color.Black;
                        }
                    }
                }
                else if(icon.Checked ==false)
                {
                    icon.BackColor = splitContainer1.Panel1.BackColor;
                    icon.ForeColor = Color.Black;
                }

            }
        }
        
        public void checkReady()//check if both ready 
        {
            if (chkP1Ready.Checked == true && chkP2Ready.Checked == true)
            {
                GameBoard obj = new GameBoard(this);
                obj.Show();
            }
        }

        private void chkP1Ready_CheckedChanged(object sender, EventArgs e)
        {
            chkP2Ready.BackColor = Color.Green;
            //p1 = new Player(...)
            checkReady();
        }

        private void chkP2Ready_CheckedChanged(object sender, EventArgs e)
        {
            chkP2Ready.BackColor = Color.Green;
            //p2 = new Player(...)
            checkReady();
        }

        private void chkP1Char1_CheckedChanged(object sender, EventArgs e)
        {
            pickCharacter();
        }
    }
}
