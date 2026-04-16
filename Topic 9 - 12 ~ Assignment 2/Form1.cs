using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_9___12___Assignment_2
{
    public partial class MainForm : Form
    {

        double firstnum, secondnum, result;
        bool enteredFirstNum = false;
        bool enteredSecondNum = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnquit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reconfirm if you want to quit", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void btnequal_Click(object sender, EventArgs e)
        {

        }







    }
}
