using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordTown.Properties;

namespace WordTown
{
    public partial class WordTown_MainMenu : Form
    {
        int totalTime = 90;
        string timeStringFormatted;
        string timeFirstDigit;
        string timeSecondDigit;

        public WordTown_MainMenu()
        {
            InitializeComponent();
        }

        private void Exit_Button_MouseEnter(object sender, EventArgs e)
        {
            Exit_Button.Image = Resources.WordTown_HoveredExitIcon;
        }

        private void Exit_Button_MouseLeave(object sender, EventArgs e)
        {
            Exit_Button.Image = Resources.WordTown_NonHoveredExitIcon;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartGame_Button_Click(object sender, EventArgs e)
        {
            StartGame_Button.Visible = false;
            GameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // If TotalTime Not Equals 0, Then Decrease It By 1
            if (totalTime != 0)
            {
                totalTime--;
                timeStringFormatted = totalTime.ToString();
            }
            else
            {
                GameTimer.Stop();
            }

            // Gets The Two Digits Of Time
            timeSecondDigit = timeStringFormatted[0].ToString();
            timeFirstDigit = timeStringFormatted[1].ToString();

            // First Digit
            if (timeFirstDigit == "0")
            {
                FirstDigit_PictureBox.Image = Resources._0;
            }
            else if (timeFirstDigit == "1")
            {
                FirstDigit_PictureBox.Image = Resources._1;
            }
            else if (timeFirstDigit == "2")
            {
                FirstDigit_PictureBox.Image = Resources._2;
            }
            else if (timeFirstDigit == "3")
            {
                FirstDigit_PictureBox.Image = Resources._3;
            }
            else if (timeFirstDigit == "4")
            {
                FirstDigit_PictureBox.Image = Resources._4;
            }
            else if (timeFirstDigit == "5")
            {
                FirstDigit_PictureBox.Image = Resources._5;
            }
            else if (timeFirstDigit == "6")
            {
                FirstDigit_PictureBox.Image = Resources._6;
            }
            else if (timeFirstDigit == "7")
            {
                FirstDigit_PictureBox.Image = Resources._7;
            }
            else if (timeFirstDigit == "8")
            {
                FirstDigit_PictureBox.Image = Resources._8;
            }
            else if (timeFirstDigit == "9")
            {
                FirstDigit_PictureBox.Image = Resources._9;
            }

            // Second Digit
            if (timeSecondDigit == "0")
            {
                SecondDigit_PictureBox.Image = Resources._0;
            }
            else if (timeSecondDigit == "1")
            {
                SecondDigit_PictureBox.Image = Resources._1;
            }
            else if (timeSecondDigit == "2")
            {
                SecondDigit_PictureBox.Image = Resources._2;
            }
            else if (timeSecondDigit == "3")
            {
                SecondDigit_PictureBox.Image = Resources._3;
            }
            else if (timeSecondDigit == "4")
            {
                SecondDigit_PictureBox.Image = Resources._4;
            }
            else if (timeSecondDigit == "5")
            {
                SecondDigit_PictureBox.Image = Resources._5;
            }
            else if (timeSecondDigit == "6")
            {
                SecondDigit_PictureBox.Image = Resources._6;
            }
            else if (timeSecondDigit == "7")
            {
                SecondDigit_PictureBox.Image = Resources._7;
            }
            else if (timeSecondDigit == "8")
            {
                SecondDigit_PictureBox.Image = Resources._8;
            }
            else if (timeSecondDigit == "9")
            {
                SecondDigit_PictureBox.Image = Resources._9;
            }
        }
    }
}

