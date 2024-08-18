namespace ABC;
class Person {

    public Person() {     //default constructor
    }
    public Person(string n,DateTime d,long id){  //parameterized constructor
         name =n;
         dob = d;
         nid = id;
    }

    public string name;   
    public long nid;
    public DateTime dob;

public void PrintDetails()
 {
     Console.WriteLine ($"Name: {this.name}\nNational Identifier: {this.nid}\nDate of Birth: {this.dob}"); // \n le naya line ma liyera janxa
 }
    public static string PrintDetails(Person person) =>
        $"Name: {person.name}\nNational Id: {person.nid}\ndob: {person.dob.ToLongDateString()}";
    


}



