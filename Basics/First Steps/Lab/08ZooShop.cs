int numberOfdogFood = int.Parse(Console.ReadLine());
int numberOfcatFood = int.Parse(Console.ReadLine());

double totalSum = ((numberOfdogFood * 2.50) + (numberOfcatFood * 4));
string bon = $"{totalSum} lv.";
Console.WriteLine(bon);
