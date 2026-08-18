// See https://aka.ms/new-console-template for more information
using BookStoreConsoleApp;
using Microsoft.Data.SqlClient;
using System.Data;

//Console.WriteLine("Hello, Welcome To Book Stroe");


//Console.WriteLine("Please enter the book name:");
//string bookNmae = Console.ReadLine();

//Console.WriteLine("Please enter the book price:");

//string bookPrice = Console.ReadLine();
//DBLayer dBLayer = new DBLayer();
//dBLayer.SaveBookDataToDB(bookNmae, bookPrice);
//Console.WriteLine("Thank You, Information stored in system.");

Console.WriteLine("Please enter the book Id to read data from database:");
string bookId = Console.ReadLine();
DBLayer dBLayer = new DBLayer();
string result = dBLayer.ReadBookDataFromDB(Convert.ToInt32(bookId));


DataTable resultTable = dBLayer.ReadBookDataFromDBViaAdapter(Convert.ToInt32(bookId));


Console.WriteLine(result);
Console.ReadLine();