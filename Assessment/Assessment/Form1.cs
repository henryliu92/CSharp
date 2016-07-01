using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment
{
    public partial class Form1 : Form
    {
        class Books
        {
            public string bookTitle;
            public string bookAuthor;
            public int bookISBN;
            public int bookPrice;

            public Books (string bookTitle, string bookAuthor, int bookISBN, int bookPrice)
            {
                this.bookTitle = bookTitle;
                this.bookAuthor = bookAuthor;
                this.bookISBN = bookISBN;
                this.bookPrice = bookPrice;
            }
        }

        List<Books> listOfBooks = new List<Books>() { };
        Books Book1 = new Books("The Big Four", "Agatha Christie", 978000712, 8);
        Books Book2 = new Books("On Her Majesty's Secret Service", "Ian Fleming", 12345654, 11);

        listOfBooks.Add(book1);
        

        public Form1()
        {
            InitializeComponent();

            buttonAdd.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonView_Click(object sender, EventArgs e)
        {

            buttonAdd.Enabled = true;
            buttonDelete.Enabled = true;
        }
        
        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Books newBook = new Books();


        }
    }
}
