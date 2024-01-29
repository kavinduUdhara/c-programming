//basic value type varibles
using System.Numerics;
using System.Security.Principal;

int i = 10;
float f = 2.5f;
decimal d = 10.0m;
bool b = true;
char c = 'c'; //this wanna be within signle quotes

//string type
string str = "this is a string";

//implicit variable (that system decide what the data type is)
//according to the assigned value
var x = 10;
var z = "Hello!";

//array
int[] vals = new int[5];
string[] strs = {"one", "two", "three", "four"};

//print above var. using a formatting string
Console.WriteLine("Printing values assigned: ");
Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}",i,f,d,b,c,str,x,z);

//null means "no value"
Console.WriteLine("\nFollowing will print a null value(will show up as empty string): ");
object o = null;
Console.WriteLine(o);

//implicit conversion between types
long bignum;
bignum = i;

//explict conversions
float i_to_f = (float)i;
Console.WriteLine("{0}",i_to_f);
int f_to_i = (int)f;
Console.WriteLine("{0}",f_to_i);