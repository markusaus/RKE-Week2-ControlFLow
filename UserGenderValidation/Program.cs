// See https://aka.ms/new-console-template for more information






Console.WriteLine("Please, select your gender (M/F):");

char userGender = Char.Parse(Console.ReadLine());
Console.WriteLine("Please enter your last name:");
string userLastName= Console.ReadLine();


if (userGender == 'M')

{
    Console.WriteLine($"Welcome, Mr {userLastName}!");
}
else if (userGender =='F')
{
    Console.WriteLine($"Welcome, Ms {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome {userLastName}!");
}
