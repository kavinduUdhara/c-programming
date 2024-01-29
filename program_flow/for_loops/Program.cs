// See https://aka.ms/new-console-template for more information
Console.WriteLine("The basic for loop");
for (int i = 0; i<15; i++){
    Console.WriteLine("The value of i: {0}",i);
}

int[] myNums = new int[] {7,5,25,84,995};
foreach(int i in myNums){
    Console.WriteLine("foreach i: {0}",i);
}

string str = "This is a straing";
foreach(char i in str){
    Console.WriteLine("char i: {0}",i);
}