using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {

        //To change the player
        int playerChange = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ClickLabel1_Click(object sender, EventArgs e)
        {
            // Check whose turn it is and update the box accordingly
            if (playerChange == 0)
            {
                tictactoeBox1.Text = "X";
                playerChange++;
            }
            else if (playerChange == 1)
            {
                tictactoeBox1.Text = "O";
                playerChange--;
            }
        }

        private void ClickLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
