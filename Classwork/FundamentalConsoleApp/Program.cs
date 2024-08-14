// using ABC;
// using FundamentalConsoleApp.FileIO;
// using FundamentalConsoleApp.Generic;

//Console.WriteLine("Enter a text: ");
//string userInput = Console.ReadLine(); 
//Console.WriteLine($"You entered {userInput.Length} characters"); //string interpolation

////get username and convert into upper case
//Console.WriteLine("Enter your name");
//string username = Console.ReadLine();
//Console.WriteLine($"Your name in uppercase is {username.ToUpper()}");
//*/

//Person subhana = new(); //instance of class Person
//subhana.name = "Subhana Chitrakar";
//subhana.nid = 232232333134141;
//subhana.dob = new DateTime(2024,8,5);
////subhana.PrintDetails();



//Person subhana1 = new(); //instance of class Person
//subhana1.name = "Subhana Chitrakar1";
//subhana1.nid = 3645654646;
//subhana1.dob = new DateTime(2025,4,1);
////subhana1.PrintDetails();

//Person subhana2 = new Person("Subhana2",new DateTime(2000,5,30),4235453522); 
////subhana2.PrintDetails();


//Page page= new Page(100,150,"Hello");
////page.PrintPageInfo();



//Student s = new Student("Subhana Chitrakar" , new DateTime(2000,5,30), "Test","Engineering");
//(string AgeString, int AgeDays) = s.CalculateAge();

//var y = s.GetInitials();
//Console.WriteLine(s.CapitalizeName());

//var output = Student.StudentDetails(initial:y , age :AgeString );
//var output1 = Student.StudentDetails(initial:y , age : AgeString, ageDays: AgeDays );
//Console.WriteLine(output);
//Console.WriteLine(output1);



Generic g = new();
g.PrintDetails<string,int>("Hello",123);

//PlayingWithCollections.LearnArrays();


var FileHandler = new FileHandler();

var emps = FileHandler.ReadFile();

FileHandler.WriteFile();

FileHandler.WriteEmployeesToFile(emps);
