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
            Console.WriteLine(resArea);
        }
    }

    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Size of int: {0}", sizeof(int));

            Console.ReadLine();
        }
    }
}
}
