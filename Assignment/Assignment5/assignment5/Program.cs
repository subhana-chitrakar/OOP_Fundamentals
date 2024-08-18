string filePath = @"C:\Users\mahes\Desktop\oop\OOP_Fundamentals\Assignment\Assignment5\assignment5";
List<Person> people = await CSVParser.ParseCSV(filePath);
await PeopleReport.SaveMales(people, filePath);
await PeopleReport.SaveFemales(people, filePath);
await PeopleReport.SaveDotComUsers(people, filePath);