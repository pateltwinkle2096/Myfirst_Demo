// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

string firstname = "twinkle";
string lastname = "patel";
string f1 = String.Concat(firstname, lastname); //add value using concat
Console.WriteLine(f1);


string firstname1 = "twinkle";
string lastname2 = "patel";
string f2 = $"full name is: {firstname1} {lastname2}";//interpolation
Console.WriteLine(f2);

string name1 = "twinkle";
Console.WriteLine(name1[3]);//print character

string name2 = "pa tel";
Console.WriteLine(name2.IndexOf("e"));//Indexof

string s1= "hello world";
string s2 = s1.PadLeft(12);
Console.WriteLine(s2);

string s3 = "Hello C Sharp";
string s4 = s3.Substring(2); //substring
Console.WriteLine(s4);

int day = 6;
switch (day)
{
    case 0:
        Console.WriteLine("Sunday");
        break;
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tueday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;

    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;

}


// checking vowel and consonant
char gender;

//Reading gender from user
Console.WriteLine("Enter gender (M/m or F/f): ");
gender = Convert.ToChar (Console.ReadLine());

switch (gender)
{
    case 'M':
    case 'm':
        Console.WriteLine("MALE");
        break;

    case 'F':
    case 'f':
        Console.WriteLine("FEMALE");
        break;

    default:
        Console.WriteLine("Unspecified Gender");
        break;
}

Console.ReadLine();
 
 
