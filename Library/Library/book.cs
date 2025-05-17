using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class Book
{
    private static int _idCounter = 0;

    public int Id { get; private set; }
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public double Price { get; set; }

    public Book(string name, string authorName, double price)
    {
        Id = ++_idCounter;
        Name = name;
        AuthorName = authorName;
        Price = price;
    }

    public string ShowInfo()
    {
        return "Id: " + Id + ", Name: " + Name + ", Author: " + AuthorName + ", Price: " + Price;
    }

    public override string ToString()
    {
        return ShowInfo();
    }
}
