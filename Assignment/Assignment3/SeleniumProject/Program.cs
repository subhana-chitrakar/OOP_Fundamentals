HomePage homePage = new HomePage
{
  MenuItems = new [] {"Home" , "About Us"},
  Height = 200,
  Width= 500,
  ProfileAvatar = new byte[] { 111,222,223,224}
};


AboutUsPage aboutUsPage = new AboutUsPage
{
  MenuItems = new[] { "Home", "About Us" },
  Height = 200,
  Width = 500,
  ProfileAvatar = new byte[] { 111, 222, 223, 224 },
  Contacts = new[] { 1234567, 8910111, 1213141 }
};

homePage.Login("Subhana","Password123");
homePage.Navigate("https://www.test.com/HomePage");
homePage.GetCurrentUrl();
homePage.HandleMenuClick("Home Page");
aboutUsPage.Navigate("https://www.test.com/AboutUs");
homePage.HandleMenuClick("About Us");
aboutUsPage.GetCurrentUrl();
aboutUsPage.InitiatePhone("1234567");
aboutUsPage.InitiateEmail("subhana.chitrakar@gmail.com");