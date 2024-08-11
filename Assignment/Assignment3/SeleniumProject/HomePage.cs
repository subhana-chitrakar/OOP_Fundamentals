public class HomePage : IDriver
{



  public string[] MenuItems { get; set; }
  public int Height { get; set; }
  public int Width { get; set; }
  public byte[] ProfileAvatar { get; set; }


  public void HandleMenuClick(string menuItem){
    if(!string.IsNullOrWhiteSpace(menuItem) && MenuItems.Contains(menuItem))
    {
      Console.WriteLine($"{menuItem} has been clicked.");
    }
    else {
      Console.WriteLine($"{menuItem} not found.");
    }
  }


  public void Login(string userName, string password)
  {
    if((!string.IsNullOrWhiteSpace(userName) && userName.Length > 0) && (!string.IsNullOrWhiteSpace(password) && password.Length > 8 ))
    {
      Console. WriteLine($"Login Successful. Welcome {userName}");

    }
    else{
      Console.WriteLine("Login Failed!");
    }
  }

  public void Navigate(string url)
  {
    Console.WriteLine($"Navigate to {url}");
  }
  public void GetCurrentUrl()
  {
    Console.WriteLine("Current URL is https://www.test.com");
  }
}