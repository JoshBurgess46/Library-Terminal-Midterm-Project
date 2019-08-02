using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Library_Terminal
{
    public class Books : LibraryItems
    {
        public string Author { get; set; }
        public string Medium { get; set; }

        public Books()
        {

        }

        public Books(string barcode, string title, string checkedOut, string genre, string year, string dueDate, string author, string medium)
            : base(barcode, title, checkedOut, genre, year, dueDate)
        {

        }
        public static void FilterBookListByAuthor(List<Books> bookList)
        {
            Console.WriteLine("What author would you like to search for?");
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^[a-zA-Z. ]+$"))
            {
                int counter = 0;
                foreach (Books book in bookList)
                {
                    if (book.Author == input)
                    {
                        counter++;
                        Console.WriteLine($"{counter}. {book.Title}");
                    }
                }
            }
            else
            {
                Console.WriteLine("That is not a valid author.");
                FilterBookListByAuthor(bookList);
            }
        }
        public void FilterBookListByTitle(List<Books> bookList)
        {
            Console.WriteLine("What title would you like to search for?");
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^[a-zA-Z. ]+$"))
            {
                int counter = 0;
                foreach (Books book in bookList)
                {
                    if (book.Title.Contains(input))
                    {
                        counter++;
                        Console.WriteLine($"{counter}. {book.Title}");
                    }
                }
            }
            else
            {
                Console.WriteLine("That is not a valid title.");
                FilterBookListByTitle(bookList);
            }
        }

    }
}
