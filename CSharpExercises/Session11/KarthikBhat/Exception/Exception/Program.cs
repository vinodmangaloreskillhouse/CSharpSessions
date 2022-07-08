// See https://aka.ms/new-console-template for more information


int[] sarray = { 1, 0, 3, 6 };
int temp, Num = 786; 
object Ob;

try
{
    sarray[10] = 2;
    
    
}
catch (Exception e)
{
    Console.WriteLine(e);
}
try
{
    temp = sarray[0] / sarray[1];

}
catch (Exception e)
{
    Console.WriteLine(e);
}
try
{
    Ob = Num;
    int num = (short)Ob;

}
catch (Exception e)
{
    Console.WriteLine(e);
}




 
