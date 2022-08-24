int firstDiggit = new Random().Next(1,65537);

Console.WriteLine(firstDiggit);

if(firstDiggit > 9999)
{
    Console.WriteLine((firstDiggit/100)%10);
}

else if(10000 > firstDiggit && firstDiggit > 999)
{
  Console.WriteLine((firstDiggit/10)%10);
}
else if(1000 > firstDiggit && firstDiggit >99)
{
   Console.WriteLine(firstDiggit%10);
}
else
{
    Console.WriteLine("Diggit don't have 3 diggit");
}
