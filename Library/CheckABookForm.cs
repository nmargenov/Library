using System;
using System.Windows.Forms;

namespace Library
{
    public partial class CheckABookForm : Form
    {

        BindingSource bs = new BindingSource();

        public CheckABookForm()
        {
            InitializeComponent();
            bs.DataSource = BookManager.bookmanager.books;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {         
            if(dataView.CurrentRow == null)
            {
                return;
            }
            if (!BookManager.bookmanager.books[dataView.CurrentCell.RowIndex].Available)
            {
                MessageBox.Show("Sorry! This book is not available right now!", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (datePicker.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Please select a returning date in the future!", "Invalid Return Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BookManager.bookmanager.books[dataView.CurrentCell.RowIndex].ReturnDate = datePicker.Value.Date;
            ;
            BookManager.bookmanager.CheckABook(dataView.CurrentCell.RowIndex);


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

