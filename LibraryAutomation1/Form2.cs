using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomation1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SearchIssueForm().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form6().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ManageBook().Show();
            this.Hide();
        }
    }
}
