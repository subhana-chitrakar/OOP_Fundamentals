public class Generic{

    public void PrintDetails<T , U>(T x, U y){
        Console.WriteLine($"Value of X: {x} and value of Y: {y}");
    }
    //<T> generic method type. It accepts type as a parameter. can be used in method overloading

   
}