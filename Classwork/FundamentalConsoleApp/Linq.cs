//LINQ -> Language Integrated Query


using Microsoft.VisualBasic;

internal class Linq
{
   double[] marks = [34.5,67.2,80.5,65.9,70.6,45.0,68,30.5];

    static List<Student> students = [
        new ("Ram Kumar", new DateTime(1900,12,12), "IMS","BIT"),
        new ("Alice Johnson", new DateTime(1985, 3, 15), "IMS1","BIT1"),
        new ("Bob Smith", new DateTime(1990, 7, 22), "IMS2","BIT2"),
        new ("Carol Williams", new DateTime(1978, 11, 30), "IMS3","BIT3"),
        new ("David Brown", new DateTime(1965, 2, 8), "IMS4","BIT4"),
    ];

  //Get all marks which surpass passmarks 40
  //imperative -> loop (we know how it works)
  //declarative -> sql (we dont know kasari work garcha, we just declare things)

  //Imperative
 List<double>passMarks = [];
  public  void Query()
  {
    foreach (var mark in marks)
    {
      if(mark > 40)
      {
        passMarks.Add(mark);
      }
    }

    //Declarative
    var passMarks1 = marks.Where(mark => mark >40); //filter

    var result = marks.Select(x => x.ToString(
  "f2"));  //Projection
  
  //Get all passmarks converted to nearest integer
  var marksToPrint = marks.Where(mark => mark > 40).Select(x =>Math.Round(x));

  foreach(var mark in result){
    Console.WriteLine(result);
  }

  //Expression
  marksToPrint = from mark in marks 
                where mark > 40
                select Math.Round(mark);



    //Get all employees who are born after 2000

    var studsAfter2000 = students.Where(x => x.dob.Year > 2000);

    //Get employee name with their ages and oder by age
    var studs = students.Select(x => new {Name =x.name, Age = x.CalculateAge()})
    .OrderBy(x => x.Age.Item2);


    foreach (var items in studs)
    {
      Console.WriteLine($"{items.Name}\t{items.Age.Item1}");
    }
  }


 


}
