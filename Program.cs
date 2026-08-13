// See https://aka.ms/new-console-template for more information
using BookStoreConsoleApp;

Console.WriteLine("Hello, Welcome To Book Stroe");


Console.WriteLine("Please enter the book name:");
string bookNmae = Console.ReadLine();

Console.WriteLine("Please enter the book price:");

string bookPrice = Console.ReadLine();
DBLayer dBLayer = new DBLayer();
dBLayer.SaveBookDataToDB(bookNmae, bookPrice);
Console.WriteLine("Thank You, Information stored in system.");
Console.ReadLine();