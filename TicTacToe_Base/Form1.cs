﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           PlayerSetup obj = new PlayerSetup();
            obj.Show();
            timer1.Enabled = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hide();
            timer1.Enabled=false;
        }
    }
    
}
