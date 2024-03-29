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
    public partial class AddABookForm : Form
    {
        public AddABookForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(bookNameTextBox.Text))
            {
                MessageBox.Show("Please enter a valid book name!", "Invalid Book Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(authorNameTextBox.Text))
            {
                MessageBox.Show("Please enter a valid author name!", "Invalid author Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string message = "Would you like to add a picture to the book?";
            string caption = "Add a picture";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons,icon);

            if (result == DialogResult.No)
            {
                BookManager.bookmanager.CreateABook(bookNameTextBox.Text, authorNameTextBox.Text);
            }
            if(result == DialogResult.Yes)
            {
                PictureBox pictureBox = new PictureBox();
                OpenFileDialog openFile = new OpenFileDialog();
                DialogResult fileResult;

                openFile.Filter = "Image Files(*.PNG; *.JPG; *.BMP)|*.PNG; *.JPG; *.BMP;";
                fileResult = openFile.ShowDialog();

                if (fileResult == DialogResult.OK)
                {
                    pictureBox.Image = new Bitmap(openFile.FileName);
                    BookManager.bookmanager.CreateABookWithPicture(bookNameTextBox.Text, authorNameTextBox.Text, pictureBox);
                }
                else
                {
                    BookManager.bookmanager.CreateABook(bookNameTextBox.Text, authorNameTextBox.Text);
                }
            }
        }    
    }
}
