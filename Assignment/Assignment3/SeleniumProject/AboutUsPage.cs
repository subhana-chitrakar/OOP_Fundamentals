public class AboutUsPage : HomePage
{


  public string Title { get; set; }
  public int[] Contacts { get; set; }


  public void InitiatePhone(string number)
  {
    if (!string.IsNullOrWhiteSpace(number) && Contacts.Contains(Convert.ToInt32(number)))
    {
      Console.WriteLine($"Your Phone number is {number}");
    }
    else
    {
      Console.WriteLine("Initiating Phone Failed.");
    }
  }


  public void InitiateEmail(string email)
  {
    if (!string.IsNullOrWhiteSpace(email) && email.Contains("@"))
    {
        Console.WriteLine($"Your email is {email}");
    }
      else
      {
        Console.WriteLine("Enter a valid email address.");
      }
    
  }

}