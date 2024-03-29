using System;
using System.Windows.Forms;


namespace Library
{
    public partial class ReturnABookForm : Form
    {
        BindingSource bs = new BindingSource();

        bool late;

        public ReturnABookForm()
        {
            InitializeComponent();
            bs.DataSource = BookManager.bookmanager.books;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            if (dataView.CurrentRow == null)
            {
                return;
            }
            if (BookManager.bookmanager.books[dataView.CurrentCell.RowIndex].Available || BookManager.bookmanager.books[dataView.CurrentCell.RowIndex].ReturnDate == DateTime.MinValue)
            {
                MessageBox.Show("This book is not for return!", "Book not for return", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (datePicker.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Please select a returning date in the future!", "Invalid Return Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!BookManager.bookmanager.books[dataView.CurrentCell.RowIndex].Available && BookManager.bookmanager.books[dataView.CurrentCell.RowIndex].ReturnDate != DateTime.MinValue)
            {
                if (BookManager.bookmanager.books[dataView.CurrentCell.RowIndex].ReturnDate.Date < datePicker.Value.Date)
                {
                    late = true;
                }
                BookManager.bookmanager.ReturnABook(dataView.CurrentCell.RowIndex,late);
                late = false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            dataView.DataSource = bs;
            bs.ResetBindings(true);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
