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
    public partial class SearchIssueForm : Form
    {
        Database2Entities context = new Database2Entities();
        public SearchIssueForm()
        {
            InitializeComponent();
            catcombo.DataSource = context.Categories.ToList();
            catcombo.DisplayMember = "Title";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultgrid.AutoGenerateColumns = false;
            var books = context.Books.Where(x =>x.Title == btitletxt.Text || x.Category == catcombo.Text).ToList();
            resultgrid.DataSource = books;


        }

        private void resultgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var title = resultgrid.Rows[e.RowIndex].Cells[2].Value;
            var Quantity = resultgrid.Rows[e.RowIndex].Cells[4].Value;
            var category= resultgrid.Rows[e.RowIndex].Cells[3].Value;
            var isbn = resultgrid.Rows[e.RowIndex].Cells[1].Value;
            titletxt.Text = title.ToString();
            qtytxt.Text = Quantity.ToString();
            catetxt.Text = Category.ToString();
            ISBNTxt.Text = isbn.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IssueBook book = new IssueBook();
            book.Enrollment = studentetxt.Text;
            book.ISBN = ISBNTxt.Text;
             //book.IssueReturn = true;
            var singlebook = context.Books.Where(x => x.ISBN == ISBNTxt.Text);
            context.IssueBooks.Add(book);
            context.SaveChanges();
        }

        private void SearchIssueForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }
    }
}
