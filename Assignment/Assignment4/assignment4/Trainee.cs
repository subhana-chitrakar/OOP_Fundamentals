using System;
using System.Collections.Generic;
using System.Linq;
namespace trainee;

internal class Trainee
{
    public string Name { get; }
    public DateTime Dob { get; }
    public string College { get; }
    public string Program { get; }

    public Trainee(string name, DateTime dob, string college, string program)
    {
        Name = name;
        Dob = dob;
        College = college;
        Program = program;
    }
    // Calculate age of a trainee in years and months
    public (string, int) CalculateAge()
    {
        var ageSpan = DateTime.Now - Dob;
        var years = ageSpan.Days / 365;
        var months = (ageSpan.Days % 365) / 30;
        return ($"{years} Years and {months} Months", ageSpan.Days);
    }

    // Get name initials of a trainee
    public string GetInitials()
    {
        var nameParts = Name.Split(" ");
        char firstInitial = nameParts[0][0];
        var lastInitial = nameParts[^1][0];
        return $"{firstInitial}{lastInitial}";
    }
    public static string PrintDetails(Trainee trainee) =>
        $"{trainee.Name}\t{trainee.Dob.ToShortDateString()}\t{trainee.College}\t{trainee.Program}";
}



}