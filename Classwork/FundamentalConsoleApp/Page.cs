//CLASSWORK 2
//Create class called page with fields height (inch),width(inch) and title
//Page should have parameterized constructor which assigns each fields
//Create a method that prints height and width of that page in the pixels
//Create instance of this class and display details in console



class Page{


public Page(int h, int w, string t ) {
    this.height = h;
    this.width = w;
    this.title = t;
}


public int height;
public int width;
public string title;


public void PrintPageInfo(){
    Console.WriteLine($"height: {this.height * 96} pixel \nwidth: {this.width *96} pixel\ntitle: {this.title}");
}

}