using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsoleApp
{
    internal class MobileBookApp: IBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public MobileBookApp(string title, string author, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
        public bool AddBook(string title, string author, decimal price, int quantity)
        {
            // Implementation for adding a book
            return true;
        }
        public bool RemoveBook(string title)
        {
            // Implementation for removing a book
            return true;
        }
        public bool UpdateBook(string title, string author, decimal price, int quantity)
        {
            // Implementation for updating a book
            return true;
        }
        public bool Login(string username, string password)
        {
            // Implementation for login
            return true;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Price: ${Price}");
        }
    }
}
