using System;
using System.Collections.Generic;
using System.Linq;
namespace report;


internal class Reports
{
    static List<Trainee> trainees = new List<Trainee>
    {
        new Trainee("Ram Bista", new DateTime(1990, 12, 12), "Vedas", "BIT"),
        new Trainee("Laxman Shrestha", new DateTime(1988, 1, 10), "Ascol", "BSC"),
        new Trainee("Bishnu Rawal", new DateTime(1990, 4, 22), "PK", "BIM"),
        new Trainee("Suneer Bista", new DateTime(2000, 6, 10), "Cenral TU", "BIT"),
        new Trainee("Sita Acharya", new DateTime(2010, 8, 29), "CCRC", "BIT"),
        new Trainee("Ram Basnet", new DateTime(2004, 9, 23), "People's College", "BSC"),
        new Trainee("Rama Chitrakar", new DateTime(2003, 8, 17), "People's College", "BSC"),
        new Trainee("Mahesh Manandhar", new DateTime(2004, 9, 23), "CCRC", "BIM"),
        new Trainee("Renu Shahi", new DateTime(2004, 9, 23), "Vedas", "BIM"),
        new Trainee("Sanjana Luitel", new DateTime(2007, 4, 26), "PK", "BSC")
    };

    public static void LetsQuery()
    {
        // Get all trainees grouped by their college
        var traineeByCollege = trainees
            .GroupBy(x => x.College)
            .Select(college => new
            {
                College = college.Key,
                Trainees = college.ToList()
            });

        
        foreach (var group in traineeByCollege)
        {
            Console.WriteLine($"College: {group.College}");
            foreach (var trainee in group.Trainees)
            {
                Console.WriteLine(Trainee.PrintDetails(trainee));
            }
        }

        // Get name and age of trainees who are in their teens
        var teens = trainees
            .Select(t => new { t.Name, Age = t.CalculateAge() })
            .Where(t => t.Age.Item2 >= 13 * 365 && t.Age.Item2 < 20 * 365);

        foreach (var teen in teens)
        {
            Console.WriteLine($"Trainees in their teens: {teen.Name} - {teen.Age.Item1}");
        }


       

        // Get name initials, age and academic program of trainees and order result by initials
        var orderedByInitials = trainees
            .Select(t => new
            {
                Initials = t.GetInitials(),
                Age = t.CalculateAge().Item1,
                t.Program
            })
            .OrderBy(t => t.Initials);
        foreach (var item in orderedByInitials)
        {
            Console.WriteLine($"Trainees ordered by initials {item.Initials} - {item.Age} - {item.Program}");
        }
    }