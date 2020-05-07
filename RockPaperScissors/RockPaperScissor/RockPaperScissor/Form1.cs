using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissor
{
    public partial class Form1 : Form
    {
  
        public Form1()
        {
            InitializeComponent();
        }
        //Variablat qe kam mi perdor
        string[] gameItem = { "rock", "paper", "scissor"};
        int playerResult = 0;
        int cpResult = 0;
        string player;
        string computer;

        public void computerChoice()
        {
            Random rnd = new Random();
            int randomNr = rnd.Next(0, 3);

            computer = gameItem[randomNr];
            if (computer == "rock") picComputer.Image = picRock.Image;
            else if (computer == "paper") picComputer.Image = picPaper.Image;
            else picComputer.Image = picScissor.Image;
        }

        private void player_click(object sender, EventArgs e)
        {
            if (sender == picPaper)
            {
                player = "paper";
                picPlayer.Image = picPaper.Image;
            }
            else if (sender == picRock)
            {
                player = "rock";
                picPlayer.Image = picRock.Image;
            }
            else
            {
                player = "scissor";
                picPlayer.Image = picScissor.Image;
            }

            computerChoice();
            checkResult();
        }

        public void checkResult()
        {
            if(player == "paper")
            {
                if(computer == "rock")
                {
                    playerResult++;
                    lblResult.Text = ": " + playerResult.ToString();
                    MessageBox.Show("You won this round.");
                }
                else if(computer == "scissor")
                {
                    cpResult++;
                    lblComputerResult.Text = ": " + cpResult.ToString();
                    MessageBox.Show("The computer won this round.");
                }
            }
            else if(player == "rock")
            {
                if (computer == "scissor")
                {
                    playerResult++;
                    lblResult.Text = ": " + playerResult.ToString();
                    MessageBox.Show("You won this round.");
                }
                else if (computer == "paper")
                {
                    cpResult++;
                    lblComputerResult.Text = ": " + cpResult.ToString();
                    MessageBox.Show("The computer won this round.");
                }
            }
            else if(player == "scissor")
            {
                if (computer == "paper")
                {
                    playerResult++;
                    lblResult.Text = ": " + playerResult.ToString();
                    MessageBox.Show("You won this round.");
                }
                else if (computer == "rock")
                {
                    cpResult++;
                    lblComputerResult.Text = ": " + cpResult.ToString();
                    MessageBox.Show("The computer won this round.");
                }
            }
            if (player == computer) MessageBox.Show("This is a tie.");
        }
    }
}
