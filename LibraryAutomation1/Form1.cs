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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database2Entities content = new Database2Entities();

            if(Txtusername.Text !=string.Empty && Txtuserpass.Text !=string.Empty && Txtusertype.Text !=string.Empty)
            {
                var user = content.Admins.Where(x => x.username.Equals(Txtusername.Text)).FirstOrDefault();
                if (user.userpass.Equals(Txtuserpass.Text))
                {
                    new Form2().Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("The password you entered is incorrect.");

                }

            }
            else
            {
                MessageBox.Show("The password you entered is incorrect.");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
