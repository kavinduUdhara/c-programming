using System.Text;

int jumpCount = 10;
string[] animals = {"goats", "cats", "pigs"};

//create a string builder
StringBuilder sb = new StringBuilder();

Console.WriteLine($"Capacity: {sb.Capacity} | length: {sb.Length}");

sb.Append("The quick brown fox ");
sb.Append("jumped over the lazy dog.");
sb.AppendLine();
sb.AppendFormat($"He did this {jumpCount} times.");
sb.AppendLine();

sb.Append("He also jumped over ");
sb.AppendJoin(", ", animals);

sb.Replace("fox", "cat");
sb.Insert(0, "This is the ");

Console.WriteLine($"Capacity: {sb.Capacity} | length: {sb.Length}");
Console.WriteLine(sb.ToString());