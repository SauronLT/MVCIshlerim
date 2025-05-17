using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class Library
{
    public string Name { get; set; }
    private Book[] books = new Book[0];

    public void AddBook(Book book)
    {
        Array.Resize(ref books, books.Length + 1);
        books[books.Length-1] = book;
    }

    public Book GetBookById(int id)
    {
        return books.FirstOrDefault(b => b.Id == id);
    }

    

    public Book[] GetBook(string name)
    {
        return books.Where(b => b.Name.ToLower().Contains(name.ToLower())).ToArray();
    }

    public void GetAllBooks()
    {
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }

    public void Update(int id, Book newBook)
    {
        var existing = GetBookById(id);
        if (existing != null)
        {
            existing.Name = newBook.Name;
            existing.AuthorName = newBook.AuthorName;
            existing.Price = newBook.Price;
        }
    }
}