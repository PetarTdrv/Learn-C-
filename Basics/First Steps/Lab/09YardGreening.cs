double squareMeters = double.Parse(Console.ReadLine());
double priceWithoutDiscount = squareMeters * 7.61;
double discountPrice = priceWithoutDiscount * 0.18;
double discountDifference = priceWithoutDiscount - discountPrice;

string text = $"The final price is: {discountDifference} lv.\nThe discount is: {discountPrice} lv.";
Console.WriteLine(text);
