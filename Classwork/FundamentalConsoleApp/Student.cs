class Student(string name, DateTime dob, string college, string program){


//Initialization (instant members)
    public string name = name;
    public DateTime dob = dob; 
    public string college = college; 
    public string program = program; 


//Calculate age of a student in years and months eg. 22 years and 2 months

public string CalculateAge(){
    var ageSpan = DateTime.Now - dob ;
    var year = ageSpan.Days / 365 ;
    var month = ageSpan.Days % 365 / 30 ;  
    return $"{year} years and {month} months";
}


//Get name initials of a student eg. Subhana Chitrakar -> SC

public string GetInitials(){
   var nameParts = name.Split(" ");
   var firstInitial = nameParts[0][0];
   var lastInitial = nameParts[nameParts.Length - 1][0]; // [1^][0] last bata 1
   return $"{firstInitial}{lastInitial}";
}

public string CapitalizeName() => name.ToUpper(); // arrow function 
/*{
    return name.ToUpper();
}*/


//Print details of a student. output format : SC is 24 years and 2 months old

public static string StudentDetails(string initial, string age) => $"{initial} is {age} old";



}