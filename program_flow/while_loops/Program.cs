string str = "";
Console.WriteLine("this is while loop");
while (str != "exit"){
    Console.Write("enter value for str: ");
    str = Console.ReadLine();
    Console.WriteLine("you entered: {0}", str);
}

Console.WriteLine("this is do whole loop");
do{
    Console.Write("enter value for str: ");
    str = Console.ReadLine();
    Console.WriteLine("you entered: {0}",str);
} while(str != "exit");