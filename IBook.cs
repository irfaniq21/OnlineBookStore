using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsoleApp
{
    public interface IBook
    {
        bool AddBook(string title, string author, decimal price, int quantity);

        bool RemoveBook(string title);


        bool UpdateBook(string title, string author, decimal price, int quantity);

    }
}
