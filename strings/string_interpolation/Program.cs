String make = "zuzuki";
String model = "Wagon-R";
int year = 2020;
float miles = 8_450.27f;
decimal price = 60_275.0m;

Console.WriteLine("This car is {0} {1} {2}, with {4} miles and costs ${4:C2}", make, model, year, miles, price);

//above with interpolation
Console.WriteLine($"This car is {make} {model} {year}, with {miles} miles and costs ${price:C}");

//inline expression
Console.WriteLine($"This car is {make} {model} {year}, with {{{miles * 1.6:F2}}} miles and costs ${price:C}");