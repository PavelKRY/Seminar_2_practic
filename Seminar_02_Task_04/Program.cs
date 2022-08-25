int randomA = new Random().Next(1,1000001);

if(randomA/7 == 0 && randomA/23 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}