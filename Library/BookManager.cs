using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Library
{
    class BookManager : Book
    {
        public static BookManager bookmanager = new BookManager();

        public List<Book> books = new List<Book>();

        int DeletedItemsCount;


        public void CreateABook(string Name, string author)
        {
            Book book = new Book();
            book.Name = Name;
            book.Author = author;
            book.Available = true;
            book.ID = books.Count + 1 + DeletedItemsCount;
            book.ReturnDate = DateTime.MinValue;
            books.Add(book);
            MessageBox.Show($"You successfully added {book.Name} by {book.Author}!","Added Book",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public void CreateABookWithPicture(string Name, string author,PictureBox picturebox)
        {
            Book book = new Book();
            book.Name = Name;
            book.Author = author;
            book.Available = true;
            book.ID = books.Count + 1 + DeletedItemsCount;
            book.ReturnDate = DateTime.MinValue;
            book.Image = picturebox.Image;
            books.Add(book);
            
            
            MessageBox.Show($"You successfully added {book.Name} by {book.Author}!", "Added Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ReturnABook(int id, bool lateOrNot)
        {
            foreach (Book book in this.books)
            {
                if (book.Equals(books[id]))
                {
                    book.ReturnDate = DateTime.MinValue;
                    book.Available = true;
                    if (lateOrNot)
                    {
                        MessageBox.Show($"You are returning the book late! You have to pay a 20$ fine!", "Returning a book late", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    MessageBox.Show($"You successfully returned {book.Name} by {book.Author}!", "Returned Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }   
        }

        public void DeleteABook(int id)
        {
            foreach (Book book in this.books)
            {
                if (book.Equals(books[id]))
                {
                    books.RemoveAt(id);
                    DeletedItemsCount++;
                    if (books.Count == 0)
                    {
                        DeletedItemsCount = 0;
                    }
                    MessageBox.Show($"You successfully deleted {book.Name} by {book.Author}!", "Deleted Book",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;
                }
            }
        }

        public void CheckABook(int id)
        {
            foreach (Book book in this.books)
            {
                if (book.Equals(books[id]) && book.Available)
                {
                    book.Available = false;
                    MessageBox.Show($"You checked {book.Name}!","Checked Book",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;
                }
                if (book.Equals(books[id]) && !book.Available)
                {
                    MessageBox.Show($"Book {book.Name} is currently unavailable!","Book Unavailable",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    break;
                }

            }
        }
    }
}
