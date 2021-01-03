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
    public partial class ManageBook : Form
    {
        Database2Entities context = new Database2Entities();
        public ManageBook()

        {

            InitializeComponent();
            cateCombo.DataSource = context.Categories.ToList();
            cateCombo.DisplayMember = "Title";


        }

        public bool ReadOnly { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Database2Entities context = new Database2Entities();
            Book book = new Book();
            book.ISBN = isbntxt.Text;
            book.Title = titletxt.Text;
            book.Category = cateCombo.SelectedText;
            book.Quantity = Convert.ToInt32(Qtytxt.Text);
            context.Books.Add(book);
            context.SaveChanges();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Database2Entities context = new Database2Entities();
            var book = context.Books.Where(x => x.ISBN == risbntxt.Text).FirstOrDefault();
            rtitletxt.Text = book.Title;
            rcattxt.Text = book.Category;
            aqtytxt.Text = Convert.ToString(book.Quantity);

            rtitletxt.Text = Convert.ToString(book.Title);
           // rtitletxt.Text = ReadOnly = true;
           // rcattxt.ReadOnly = true;
            aqtytxt.ReadOnly = true;



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Database2Entities content = new Database2Entities();
            var book = content.Books.Where(x => x.ISBN == risbntxt.Text).FirstOrDefault();
            var bookqty = book.Quantity - Convert.ToInt32(rqtytxt.Text);
            book.Quantity = bookqty;

            content.SaveChanges();
            MessageBox.Show($"Book{rqtytxt.Text} removed");




        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }
    }
}
