int theVal = 70;

switch(theVal){
    case 50:
        Console.WriteLine("theVal is 50");
        break;
    case 51:
        Console.WriteLine("theVal is 51");
        break;
    case 52:
    case 53:
    case 54:
        Console.WriteLine("theVal is in between 52 and 54");
        break;
    case <50:
        Console.WriteLine("theVal is lower than 50");
        break;
    default:
        Console.WriteLine("theval is greater than 54");
        break;
}