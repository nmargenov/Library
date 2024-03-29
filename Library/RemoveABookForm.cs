using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class RemoveABookForm : Form
    {

        BindingSource bs = new BindingSource();

        public RemoveABookForm()
        {
            InitializeComponent();
            bs.DataSource = BookManager.bookmanager.books;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {          
            if (dataView.CurrentRow == null)
            {
                return;
            }
            BookManager.bookmanager.DeleteABook(dataView.CurrentCell.RowIndex);     
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            bs.ResetBindings(true);
            dataView.DataSource = bs;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
