using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiktaktoe
{
    public partial class TikTakToe : Form
    {
        bool turn = true;
        int TurnCount = 0;


        public TikTakToe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            TurnCount++;
            checkForWinner();

        }
        private void checkForWinner()
        {
            bool there_is_a_winner = false;


            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && !a1.Enabled)
                there_is_a_winner = true;
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && !b1.Enabled)
                there_is_a_winner = true;
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && !c1.Enabled)
                there_is_a_winner = true;

            else if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && !a1.Enabled)
                there_is_a_winner = true;
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && !a2.Enabled)
                there_is_a_winner = true;
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && !c3.Enabled)
                there_is_a_winner = true;

            else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && !a1.Enabled)
                there_is_a_winner = true;
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && !c1.Enabled)
                there_is_a_winner = true;


            if (there_is_a_winner)
            {
                disabledButton();

                string winner = "";
                if (turn)
                    winner = "O";

                else
                    winner = "X";
                MessageBox.Show(winner + " Wins!");

            }
            else
            {
                if (TurnCount == 9)
                    MessageBox.Show("Draw :( ");
            }


        }
        private void disabledButton()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;

                }
            }

            catch { }
        
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            TurnCount = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true ;
                    b.Text = "";

                }
            }

            catch { }

        }


    }
}
