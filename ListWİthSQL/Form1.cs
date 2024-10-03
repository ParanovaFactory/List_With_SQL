using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListWİthSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Book_Db db = new Book_Db();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.books();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Name = txtName.Text;
            book.Author = txtAuthor.Text;
            book.Page = txtPage.Text;
            book.Type = txtType.Text;
            book.Publisher = txtPublisher.Text;

            db.bookAdd(book);
        }
    }
}
