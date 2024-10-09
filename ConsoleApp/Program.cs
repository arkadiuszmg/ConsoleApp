// See https://aka.ms/new-console-template for more information


//Console.WriteLine("Hello, World!");

string name = "Ewa";

char sex = 'M';

var age = 17;

if (sex == 'F' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine($"{name}, lat {age}");
}
else if (sex != 'F' &&  age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{

}