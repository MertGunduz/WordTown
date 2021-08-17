using System;
using System.Data.OleDb;
using System.Windows.Forms;
using WordTown.Properties;

namespace WordTown
{
    public partial class WordTown_MainMenu : Form
    {
        // Time Variables
        int totalTime = 90;
        string timeStringFormatted;
        string timeFirstDigit;
        string timeSecondDigit;

        // Question Data
        Random randomQuestion = new Random();
        string englishWord;
        string turkishWord;

        // True & False Data
        int trueAnswers;
        int falseAnswers;
        int iDontKnowAnswers;

        public WordTown_MainMenu()
        {
            InitializeComponent();
        }
        private void WordTown_MainMenu_Load(object sender, EventArgs e)
        {
            DatabaseClass.DatabaseInstantiate();
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

        private void TurkishWord_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (TurkishWord_TextBox.Text == "  Turkish Word:")
            {
                TurkishWord_TextBox.Clear();
            }
        }

        private void StartGame_Button_Click(object sender, EventArgs e)
        {
            // Sets To Zero When Starting Program
            trueAnswers = 0;
            falseAnswers = 0;
            iDontKnowAnswers = 0;
            totalTime = 90;

            StartGame_Button.Visible = false;
            FirstDigit_PictureBox.Visible = true;
            GameTimer.Start();

            DatabaseClass.oleDbConnection.Open();
            OleDbCommand takeQuestionCommand = new OleDbCommand("Select English_Word, Turkish_Word From Words_Table Where Word_ID = @p1", DatabaseClass.oleDbConnection);
            takeQuestionCommand.Parameters.AddWithValue("p1", randomQuestion.Next(1, 2489));
            OleDbDataReader oleDbDataReader = takeQuestionCommand.ExecuteReader();

            while (oleDbDataReader.Read())
            {
                englishWord = oleDbDataReader[0].ToString();
                turkishWord = oleDbDataReader[1].ToString();
            }
            oleDbDataReader.Close();
            DatabaseClass.oleDbConnection.Close();

            EnglishWord_TextBox.Text = englishWord;
        }
        private void SubmitAnswer_Button_Click(object sender, EventArgs e)
        {
            if (TurkishWord_TextBox.Text == turkishWord)
            {
                trueAnswers++;
            }
            else
            {
                falseAnswers++;
            }

            DatabaseClass.oleDbConnection.Open();
            OleDbCommand takeQuestionCommand = new OleDbCommand("Select English_Word, Turkish_Word From Words_Table Where Word_ID = @p1", DatabaseClass.oleDbConnection);
            takeQuestionCommand.Parameters.AddWithValue("p1", randomQuestion.Next(1, 2489));
            OleDbDataReader oleDbDataReader = takeQuestionCommand.ExecuteReader();

            while (oleDbDataReader.Read())
            {
                englishWord = oleDbDataReader[0].ToString();
                turkishWord = oleDbDataReader[1].ToString();
            }
            oleDbDataReader.Close();
            DatabaseClass.oleDbConnection.Close();

            EnglishWord_TextBox.Text = englishWord;

            TurkishWord_TextBox.Clear();
        }

        private void IDontKnowAnswer_Button_Click(object sender, EventArgs e)
        {
            iDontKnowAnswers++;
            TurkishWord_TextBox.Clear();

            DatabaseClass.oleDbConnection.Open();
            OleDbCommand takeQuestionCommand = new OleDbCommand("Select English_Word, Turkish_Word From Words_Table Where Word_ID = @p1", DatabaseClass.oleDbConnection);
            takeQuestionCommand.Parameters.AddWithValue("p1", randomQuestion.Next(1, 2489));
            OleDbDataReader oleDbDataReader = takeQuestionCommand.ExecuteReader();

            while (oleDbDataReader.Read())
            {
                englishWord = oleDbDataReader[0].ToString();
                turkishWord = oleDbDataReader[1].ToString();
            }
            oleDbDataReader.Close();
            DatabaseClass.oleDbConnection.Close();

            EnglishWord_TextBox.Text = englishWord;

            TurkishWord_TextBox.Clear();
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
                MessageBox.Show($"|-| WordTown |-|\n\nTrue Answers: {trueAnswers}\nFalse Answers: {falseAnswers}\nI Don't Knows: {iDontKnowAnswers}", "Statistics", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Gets The Two Digits Of Time
            if (totalTime >= 10)
            {
                timeSecondDigit = timeStringFormatted[0].ToString();
                timeFirstDigit = timeStringFormatted[1].ToString();
            }
            else
            {
                FirstDigit_PictureBox.Visible = false;
                timeSecondDigit = timeStringFormatted[0].ToString();
            }


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

