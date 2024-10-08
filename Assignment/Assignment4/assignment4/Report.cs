using System;
using System.Collections.Generic;
using System.Linq;
using trainee;
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
          Console.WriteLine("Trainees Grouped by College:");
        var traineeByCollege = trainees
            .GroupBy(x => x.college);
        

        
        foreach (var group in traineeByCollege)
        {
            foreach (var trainee in group)
            {
                Console.WriteLine($"{trainee.name}\t{trainee.dob}\t{trainee.college}\t{trainee.program}");
            }
        }

        // Get name and age of trainees who are in their teens
         Console.WriteLine("Trainees in Teens:");
               var traineeInTeens = trainees.Where(x => x.CalculateAge().Item2 / 365 >= 13 && x.CalculateAge().Item2 / 365 <= 19);

        foreach (var teen in traineeInTeens)
        {
            Console.WriteLine($"{teen.name}\t{teen.CalculateAge().Item1}");
        }


       

        // Get name initials, age and academic program of trainees and order result by initials
          Console.WriteLine("Trainees Ordered by Initials:");
        var orderedByInitials = trainees
            .Select(t => new
            {
                Initials = t.GetInitials(),
                Age = t.CalculateAge().Item1,
                t.program
            })
            .OrderBy(t => t.Initials);
        foreach (var item in orderedByInitials)
        {
            Console.WriteLine($"Trainees ordered by initials {item.Initials} - {item.Age} - {item.program}");
        }
    }
}