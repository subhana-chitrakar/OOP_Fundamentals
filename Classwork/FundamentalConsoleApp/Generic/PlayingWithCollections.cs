using ABC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FundamentalConsoleApp.Generic;

internal class PlayingWithCollections
{
    //arrays,lists, dictionary

    public void LearnArrays()
    {
        string[] empNames = new string[10]; //array defination
        empNames[0] = "Subhana";
        empNames[1] = "Subhana1";
        empNames[2] = "Subhana2";


        string[] empNames = ["Subhana1", "Subhana1", "Subhana1"]; //if the value is known
        byre[] evenNumbers = [2, 4, 6, 8, 10, 12, 14, 16, 18]; //defining primitive arrays


        int[,] mat1 = { { 1, 2, 3 }, { 4, 5, 6 } };
        int[][] mat1 = [[2, 3, 4], [3, 4]]; //Jagged arrays


        //Create array of numbers from 1 to 100
        //print from that collection,print the number to console if it is multiple of 3 or 5


        int[] numbers = [100];
        int[] numbers = Enumerable.Range(1, 100).ToArray();


        foreach (int number in range)
        {

        }









        //int[] multipleOfThree = new int[100];
        //int[] multipleOfFive = new int[100];

        //for ( int i = 1; i <= 100; i++ )
        //{
        //    if(i % 3 == 0)
        //    {
        //        multipleOfThree = i;
        //        Console.Writeline(multipleOfThree);
        //    }
        //    else if (i % 5 == 0) {

        //        multipleOfFive = i;
        //        Console.Writeline(multipleOfFive);
        //    }
        //    else
        //    {

        //    }
        //}
    }




    public void LearnLists()
    {
        List<string> names = ["Subhana1", "Subhana1", "Subhana1"];
        names.Add("Ram");
        List<(string Country, string Capital)> countries = new(); //tuple
        countries.Add(("Nepal", "Ktm"));
        countries.Add(("India", "Delhi"));
        countries.Add(("China", "Beijing"));


        List<Person> people = new();
        Person person = new  Person();
        Person person1 = new Person();
        Person person2 = new Person();
        Person person3 = new Person();
        Person person4 = new Person();
        Person person5 = new Person();

        //people.Add(person1);
        //people.Add(person2);
        //people.Add(person3);
        //people.Add(person4);
        //people.Add(person5);

        //or
        people.AddRange([person1, person2, person3, person4, person5]);


    }

    //Dictionary -> collection of key value pair.KEY MUST BE UNIQUE.
    public void LearnDictionary()
    {
        Dictionary<string,int> countryPopulation = new(); 
        countryPopulation.Add("Nepal",23423424);
        countryPopulation.Add("India", 564564646);

    }





}
