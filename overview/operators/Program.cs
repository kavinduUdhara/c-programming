int x = 10, y = 5;
string a = "abcd", b = "efgd";

//ToDo: basic math operations are + - / *
Console.WriteLine("-------Basic Math Operations-------");
Console.WriteLine(x * y / x);
Console.WriteLine(a + b);

//ToDo: Increment / Decrement operations
Console.WriteLine("-------Shorthand-------");
x ++;
y--;
Console.WriteLine("x: {0} | y: {1}",x ,y);
//x--

//short hand operators: a = a + b
a += b;
Console.WriteLine("value of a+=b: {0}",a);


//ToDo: logical operators &&, ||
Console.WriteLine("-------Logical Operators-------");
Console.WriteLine("if x > y && y >= 5: {0}", x > y && y >= 5);
Console.WriteLine("if x > y || y >= 5: {0}", x > y || y >= 5);

//null-coalescing operators
string str = null;
Console.WriteLine(str ?? "Unknown straing");

//insted writing:
//if (variable is null){
    //variable = something
//}
//we can write
str ??= "New staring";
Console.WriteLine(str);