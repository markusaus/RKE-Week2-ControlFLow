﻿// See https://aka.ms/new-console-template for more information


Console.WriteLine("Enter your age!");

string userAge = Console.ReadLine();

int userAgeNum = 0;

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);
Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} old.");

if (isAgeNumber == true)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram!");
    }
    else
    {
        Console.WriteLine("You are too young too use Instagram!");
    }
}

else
{
     Console.WriteLine("Could not read your age!");
}