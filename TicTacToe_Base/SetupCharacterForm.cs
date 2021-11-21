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
    public partial class SetupCharacterForm : Form
    {
        Label firstClicked=null;
        Label secondClicked=null;

        bool allowClicking = true;

        public SetupCharacterForm()
        {
            InitializeComponent();
        }

        private void SetupCharacterForm_Load(object sender, EventArgs e)
        {

        }

        public void PlayerPick()
        {
            
            if(allowClicking ==true)
            {

            }
        }
       
            
            
               
          
 
    }

    public class PlayerClass
    {
        string PlayerName;
        string PlayerChar;
    }
}
