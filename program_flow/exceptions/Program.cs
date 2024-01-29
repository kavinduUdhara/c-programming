int x = 10000;
int y = 10;
int z;

try{
    if (x > 1000){
        throw new ArgumentOutOfRangeException("x","x has to be 1000 or less");
    }
    z = x/y;
    Console.WriteLine(z);
} catch (DivideByZeroException e){
    Console.WriteLine("opps! something went wrong");
    Console.WriteLine(e.Message);
} catch (ArgumentOutOfRangeException e){
    Console.WriteLine(e.Message);
} finally{
    Console.WriteLine("This line always runs");
}