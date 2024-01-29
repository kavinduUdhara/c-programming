int theVal = 30;

if (theVal == 50){
    Console.WriteLine("theVal is 50");
}else if(theVal >= 51){
    Console.WriteLine("theVal is greater than or equal to 51");
}else{
    Console.WriteLine("theVal is not 50 and greater than 51");
}

if (theVal > 50){
    Console.WriteLine("theVal is large");
} else{
    Console.WriteLine("theVal is small");
}

Console.WriteLine(theVal < 50 ? "theVal is small" : "theVal is large");
//console.writeline(condition ? whatToPrintIfTrue : whatToPrintIfFlase)