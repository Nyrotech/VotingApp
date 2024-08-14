using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingApplication
{
    public partial class Vote : Form
    {
        int Candidate1 = 0;
        int Candidate2 = 0;

        public Vote()
        {
            InitializeComponent();
            Votes1.Text = Convert.ToString(Candidate1);
            Votes2.Text = Convert.ToString(Candidate2);

        }
        private void Vote_Load(object sender, EventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu GoBack = new Menu();
            GoBack.Show();
        }

        private void Vote1_Click(object sender, EventArgs e)
        {
            Votes1.Text = Convert.ToString(Candidate1++);
            Vote_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Votes2.Text = Convert.ToString(Candidate2++);
            Vote_Load(sender, e);
        }
    }
}
