/*********************************************************************
 * Program:     GolfScores
 * Student:     Jesse Quijano (#001456787)
 * Purpose:     Lab3 - Create Input form for two golfers' scores and calculate winner
 * Description: The purpose of this lab is to utilize arrays for a list of values then
 *              operate on the data later.
 *************************************************************************************/

using System;
using System.Windows.Forms;
using GolfScores.BusinessLogic;

namespace GolfScores
{
    public partial class Form1 : Form
    {
        private ScoringLogic Player1;
        private ScoringLogic Player2;

        public Form1()
        {
            InitializeComponent();

            // initialize our players with blank names for now
            Player1 = new ScoringLogic("");
            Player2 = new ScoringLogic("");

            // set the hole counters
            lblHoleNumberP1.Text = "1";
            lblHoleNumberP2.Text = "1";
        }

        private void btnAddScoreP1_Click(object sender, EventArgs e)
        {
            // make sure they input values
            if (txtNameP1.Text == "")
            {
                MessageBox.Show("You must specify a name for Player 1 before you can add a score", "Error", MessageBoxButtons.OK);
                return;
            }

            if (txtHoleScoreP1.Text == "")
            {
                MessageBox.Show("Score value cannot be blank.");
                return;
            }

            // make sure the value can be evaluated as a number
            int holeScore;
            if (!int.TryParse(txtHoleScoreP1.Text, out holeScore))
            {
                MessageBox.Show("The value entered is not a number.");
                return;
            }

            // Capture the players name in the object
            Player1.PlayerName = txtNameP1.Text;

            // Add the score for this hole
            Player1.AddNextScore(holeScore);

            // Update the Hole being displayed (and awaiting input)
            var hole = Player1.GetHoleCount();
            lblHoleNumberP1.Text = (hole < ScoringLogic.NUM_HOLES ? hole + 1 : ScoringLogic.NUM_HOLES).ToString();
            
            if (hole == ScoringLogic.NUM_HOLES) // we've reached the end of the round!
            {
                ShowScoresP1();

                // disable the input box and add score button
                txtHoleScoreP1.Enabled = false;
                btnAddScoreP1.Enabled = false;
            }

            // And finally, for this score, we clear the input
            txtHoleScoreP1.Text = "";
        }

        private void btnAddScoreP2_Click(object sender, EventArgs e)
        {
            // make sure they input values
            if (txtNameP2.Text == "")
            {
                MessageBox.Show("You must specify a name for Player 2 before you can add a score", "Error", MessageBoxButtons.OK);
                return;
            }

            if (txtHoleScoreP2.Text == "")
            {
                MessageBox.Show("Score value cannot be blank.");
                return;
            }

            // make sure the value can be evaluated as a number
            int holeScore;
            if (!int.TryParse(txtHoleScoreP2.Text, out holeScore))
            {
                MessageBox.Show("The value entered is not a number.");
                return;
            }

            // Capture the players name in the object
            Player2.PlayerName = txtNameP2.Text;

            // Add the score for this hole
            Player2.AddNextScore(holeScore);

            // Update the Hole being displayed (and awaiting input)
            var hole = Player2.GetHoleCount();
            lblHoleNumberP2.Text = (hole < ScoringLogic.NUM_HOLES ? hole + 1 : ScoringLogic.NUM_HOLES).ToString();

            if (hole == ScoringLogic.NUM_HOLES) // we've reached the end of the round!
            {
                ShowScoresP2();

                // disable the input box and add score button
                txtHoleScoreP2.Enabled = false;
                btnAddScoreP2.Enabled = false;
            }

            // And finally, for this score, we clear the input
            txtHoleScoreP2.Text = "";
        }

        public void ShowScoresP1()
        {
            // show each score in the P1 window
            for (int i=0; i < Player1.GetHoleCount(); i++)
            {
                lstP1.Items.Add("Hole " + (i+1) + " Score: " + Player1.GetHoleScore(i));
            }
        }

        public void ShowScoresP2()
        {
            for (int i = 0; i < Player2.GetHoleCount(); i++)
            {
                lstP2.Items.Add("Hole " + (i + 1) + " Score: " + Player2.GetHoleScore(i));
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Program End", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            Application.Exit();
        }

        private void btnDetermineWinner_Click(object sender, EventArgs e)
        {
            // make sure at least one of the players have been scored
            if (Player1.GetHoleCount() == 0 && Player2.GetHoleCount() == 0)
            {
                MessageBox.Show("The players have not had any holes scored yet.", "Error", MessageBoxButtons.OK);
                return;
            }

            // not fair if the players haven't played the same number of holes.  make sure we want to proceed.
            if (Player1.GetHoleCount() != Player2.GetHoleCount())
            {
                var result = MessageBox.Show("The players do not have the same number of holes scored. Determine winner anyway?", "Information", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            // lowest score wins!
            if (Player1.GetTotalScore() < Player2.GetTotalScore())
            {
                MessageBox.Show(Player1.PlayerName + " is the winner: " + Player1.GetTotalScore() + " strokes to " + Player2.GetTotalScore(), "Results");
            }
            else if (Player1.GetTotalScore() == Player2.GetTotalScore())
            {
                MessageBox.Show("We have a tie!", "Results");
            }
            else
            {
                MessageBox.Show(Player2.PlayerName + " is the winner: " + Player2.GetTotalScore() + " strokes to " + Player1.GetTotalScore(), "Results");
            }
        }
    }
}
