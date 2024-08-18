using ABC;

internal class FileHandler
{
public List<Person> ReadFile(){
    {
    string filePath = @"C:\Users\subhana_teksewa\Desktop\oop\OOP_Fundamentals\Classwork\FundamentalConsoleApp\FileIO\File\Employee.txt";
    var fileContent = File.ReadAllText(filePath);
    Console.WriteLine(fileContent);


//Display name and dob of all people in employee.csv
     var lines = fileContent.Split(["\n","\r"],StringSplitOptions.RemoveEmptyEntries);
   

    var employees = new List<Person>();

     foreach(var line in lines.Skip(1).Take(10))
     {
        var data = line.Split(",",StringSplitOptions.RemoveEmptyEntries);
        var name = data[0];
        DateTime.TryParse(data[1],out DateTime d);
        var dob = d;
        var nid = long.Parse(data[2]);

        var employee = new Person(name,dob,nid);
        employees.Add(employee);

     }
     foreach( var emp in employees){
        emp.PrintDetails();
     }
    return employees;
    }
}


        public void WriteFile()
        {
            string filePath = @"C:\Users\subhana_teksewa\Desktop\oop\OOP_Fundamentals\Classwork\FundamentalConsoleApp\FileIO\File\People.txt";
            File.WriteAllText(filePath,"This file contains people info\n This file contains people info");
        }


         public void WriteEmployeesToFile(List<Person> employees)
        {
            string filePath = @"C:\Users\subhana_teksewa\Desktop\oop\OOP_Fundamentals\Classwork\FundamentalConsoleApp\FileIO\File\Employees.txt";
            var employeesText = employees.Select(Person.PrintDetails);
            File.WriteAllLines(filePath,employeesText);
        }

}


