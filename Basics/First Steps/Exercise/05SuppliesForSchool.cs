int NumberOfPenPacks = int.Parse(Console.ReadLine());
int NumberOfMarkersPacks = int.Parse(Console.ReadLine());
int CleaningPreparateLiters = int.Parse(Console.ReadLine());
double DiscountPercent = int.Parse(Console.ReadLine());


double TotalSumForPens = NumberOfPenPacks * 5.80;
double TotalSumsForMarkers = NumberOfMarkersPacks * 7.20;
double TotalSumsForCleaningPreparate = CleaningPreparateLiters * 1.20;
double DscPerc = DiscountPercent / 100;

double sum = TotalSumForPens + TotalSumsForMarkers + TotalSumsForCleaningPreparate;
double discount = (sum * DscPerc);
double TotalSum = sum - discount;

Console.WriteLine(TotalSum);
