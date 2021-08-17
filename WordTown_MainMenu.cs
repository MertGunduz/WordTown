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
    }
}
