using System;
using System.Windows.Forms;

namespace Library
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addABookButton_Click(object sender, EventArgs e)
        {
            AddABookForm addBook = new AddABookForm();
            addBook.Show();
        }

        private void removeABookButton_Click(object sender, EventArgs e)
        {
            RemoveABookForm removeBook = new RemoveABookForm();
            removeBook.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBookButton_Click(object sender, EventArgs e)
        {
            CheckABookForm checkBook = new CheckABookForm();
            checkBook.Show();
        }

        private void returnBookButton_Click(object sender, EventArgs e)
        {
            ReturnABookForm returnBook = new ReturnABookForm();
            returnBook.Show();
        }
    }
}
