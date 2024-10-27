string firstname = Console.ReadLine();
string lastname = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
string town = Console.ReadLine();

//"You are <firstName> <lastName>, a <age>-years old person from <town>."

string text = $"You are {firstname} {lastname}, a {age}-years old person from {town}.";
Console.WriteLine(text);
