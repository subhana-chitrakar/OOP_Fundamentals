class Person {

    public Person() {     //default constructor
    }
    public Person(string n,DateTime d,long id){  //parameterized constructor
         this.name =n;
         this.dob = d;
         this.nid = id;
    }

    public string name;   
    public long nid;
    public DateTime dob;


    public void PrintDetails(){
        Console.WriteLine($"Name: {this.name}\nNational Id: {this.nid}\ndob: {this.dob.ToLongDateString()}");
    }  


}



