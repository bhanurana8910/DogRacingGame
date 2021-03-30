using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRacingGame
{
    public partial class Form1 : Form
    {
        Guy[] guys = new Guy[3];  //player names 
        Greyhound[] dogs = new Greyhound[4]; // dogs aerry 
        Boolean win = false;
        int winner = -1;
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            guys[0] = new Guy("Thor", 50, thorlbl, thorradio);   
            guys[1] = new Guy("Rock", 50, rocklbl, rockradio); // load form and give each player to 50 $ for start the game
            guys[2] = new Guy("Lina", 50, linalbl, linaradio);

            guys[0].UpdateLabels();
            guys[1].UpdateLabels();  // update the labels   
            guys[2].UpdateLabels();
            Random ran = new Random();  // random numbers
            dogs[0] = new Greyhound(Dog1, ran);
            dogs[1] = new Greyhound(Dog2, ran);
            dogs[2] = new Greyhound(Dog3, ran);
            dogs[3] = new Greyhound(Dog4, ran);
        }
        private void radioClicked(object sender, EventArgs e)  // click pne radio buttons and update label accordingly
        {

            for (int i = 0; i < 3; i++)
            {
                if (guys[i].MyRadioButton.Checked)
                {
                    betNumeric.Value = 5;
                    betNumeric.Maximum = guys[i].Cash;
                    dogNumberNumeric.Value = 1;
                    NameOfBettorLabel.Text = guys[i].Name;
                }
            }

            MinimumBetLabel.Text = "Minimum Bet: " + betNumeric.Value + " bucks.";

        }
        private void betsButton_Click(object sender, EventArgs e)  // place the bet 
        {
            for (int i = 0; i < 3; i++)
            {
                if (guys[i].MyRadioButton.Checked)
                {
                    guys[i].MyLabel.Text = guys[i].Name + " has bet " + betNumeric.Value;
                    int val1, val2;
                    val1 = Convert.ToInt16(betNumeric.Value);
                    val2 = Convert.ToInt16(dogNumberNumeric.Value);
                    guys[i].PlaceBet(val1, val2);
                }
            }

        }
        private bool haveTheyBet()
        {
            for (int i = 0; i < 3; i++)
            {
                if (guys[i].MyBet == null)
                {
                    return false;
                }
            }
            return true;
        }






        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Race_Click(object sender, EventArgs e)   // race bitton 
        {

            if (haveTheyBet())
            {
                timer1.Enabled = true;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("All users must place a bet before the race begins!");
            }

        }

        private void reset_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 4; i++)
            {
                dogs[i].TakeStartingPosition();
            }
            win = false;
        }





        private void betNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)  // run all the dogs 
        {

            for (int i = 0; i < 4 && win == false; i++)
            {
                win = dogs[i].Run();
                if (win)
                {
                    timer1.Stop();
                    timer1.Enabled = false;
                    winner = i;
                    int dnumber = winner + 1;
                    for (int j = 0; j < 3; j++)
                    {
                        guys[j].Collect(winner);
                        guys[j].ClearBet();
                        guys[j].UpdateLabels();

                    }
                    MessageBox.Show("Dog " + dnumber + " has won the race!!");
                    break;
                }
            }
        }

    }
}
    
