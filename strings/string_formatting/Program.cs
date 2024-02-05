//look at https://lnkd.in/gt3eF6r
int[] num = {1,2,3,4};
int[] sales = {100000, 150000, 200000, 225000};
double[] intMixPct = {.386, .413, .421, .457};
string str1 = "testStr";
int val1 = 1234;
decimal val2 = 1234.5678m;

//basic fomatting notation
Console.WriteLine("{0}",str1);

// TODO: Specifying Numerical formatting
// General format is index[, alignment]: [format]}
// Common types are N (Number), G (General), F (Fixed-point), // E (Exponential), D (Decimal), P (Percent), X (Hexadecimal),
// C (Currency in local format)
Console.WriteLine("decimal(D): {0:D} | Number(N): {0:N} | General(G): {0:G} | Fixed-point(F): {0:F} | Exponential(E): {0:E} | percent(P): {0:P}", val1);
Console.WriteLine("Hexadecimal(X): {0:X}, Currency(C): {0:C}",val1);

//specify the precision
Console.WriteLine("{0:D6} | {0:N3}", val1);

//formatting with alignment and spacing
for(int i = 0; i < 4; i++){
    Console.WriteLine("{0,3:D} | {1,9:C0} | {2,5:P1}",num[i], sales[i], intMixPct[i]);
}