String outstr;
String str1 = "The quick brown fox jumps over the lazy dog.";
String str2 = "this is a string";
String str3 = "this is a STRING";
String[] strs = {"one", "two", "three", "four"};

//length of str
Console.WriteLine(str2.Length);
Console.WriteLine(str1[2]);

foreach (char c in str3){
    Console.Write(c);
    if (c == 'a'){
        Console.WriteLine();
        break;
    }
}

//string concatnation
outstr = String.Concat(strs);
Console.WriteLine(outstr);

//joining strings
outstr = String.Join(" - ",strs);
Console.WriteLine(outstr);

//TODO: String Comparison
//Compare will perform an ordinal comparison and return:
//< 0:  first string comes before second in sort order
//0:  first and second strings are same position in sort order
//> 0: first string comes after the second in sort order
int result = String.Compare(str2, "this is a string");
Console.WriteLine(result);

//equal just return a bool value
bool isEqual = str2.Equals(str3);
Console.WriteLine(isEqual);

//string searching
Console.WriteLine(str1.IndexOf('e'));
Console.WriteLine(str1.IndexOf("fox"));

//replace
outstr = str1.Replace("fox", "cat");
Console.WriteLine("str1: {0} | outstr: {1}",str1,outstr);

Console.WriteLine(outstr.IndexOf("fox"));