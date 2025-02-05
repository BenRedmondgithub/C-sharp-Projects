using System;
using System.Collections.Generic;

namespace authorApp 
{

    public class Author 
    {
        public string name;
        public string Qualification;

        public string WorkingPlace;

        public string Country;

        List<string> Books = new List<string>();

        List<string> ReseachArea = new List<string>();

        List<string> seminarSchedule = new List<string>();
    

    public Author ( string name, string Qualification, string WorkingPlace, string Country,
                    List<string> Books, List<string> ReseachArea, List<string> seminarSchedule)
    {
        this.name = name;
        this.Qualification = Qualification;
        this.WorkingPlace = WorkingPlace;
        this.Country = Country;
        this.Books = Books;
        this.ReseachArea = ReseachArea;
        this.seminarSchedule = seminarSchedule;

    }

    public void showResArea()
    {
        foreach (var resArea in ReseachArea)
        {
            Console.WriteLine("- " + resArea);
        }
    }

    public void showBooks()
    {
        foreach (var book in Books)
        {
            Console.WriteLine("- " +book);
        }
    }

    public void showSeminarSchedule()
    {
        foreach (var seminar in seminarSchedule)
        {
            Console.WriteLine("- " +seminar);
        }
    }

    public void showAuthorInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Qualification: " + Qualification);
        Console.WriteLine("Working Place: " + WorkingPlace);
        Console.WriteLine("Country: " + Country);
        Console.WriteLine("Books: ");
        showBooks();
        Console.WriteLine("Research Area: ");
        showResArea();
        Console.WriteLine("Seminar Schedule: ");
        showSeminarSchedule();
    }

    class Program 
    {
        public static void Main(string[] args)
        {

            List<string> Books = new List<string>();
            Books.Add("Book1");
            Books.Add("Book2");
            Books.Add("Book3");

            List<string> ReseachArea = new List<string>();
            ReseachArea.Add("Area1");
            ReseachArea.Add("Area2");
            ReseachArea.Add("Area3");

            List<string> seminarSchedule = new List<string>();
            seminarSchedule.Add("Seminar1");
            seminarSchedule.Add("Seminar2");
            seminarSchedule.Add("Seminar3");

            Author author = new Author("Author1", "PhD", "University1", "Country1", Books, ReseachArea, seminarSchedule);
            author.showAuthorInfo();

        }
    }
}
}
