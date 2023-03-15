using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Book
{
    public string Title;
    public int Pages;
    public int PublicationYear;

    public Book(string title, int pages, int publicationYear)
    {
        Title = title;
        Pages = pages;
        PublicationYear = publicationYear;
    }

    public override string ToString()
    {
        return $"{Title}, {Pages} pages, {PublicationYear}";
    }
}