double DepositedSum = double.Parse(Console.ReadLine());
int TimeOfDeposit = int.Parse(Console.ReadLine());
double AnnualInterestRate = double.Parse(Console.ReadLine());

double natrupanaLihva = DepositedSum * (AnnualInterestRate / 100);
double lihvaZaMesec = natrupanaLihva / 12;

double totalSum = DepositedSum + TimeOfDeposit * lihvaZaMesec;
Console.WriteLine(totalSum);
