int firstDiggit = new Random().Next(1,65586796);
int threeDiggit = firstDiggit;
Console.WriteLine(threeDiggit);
while(threeDiggit>1000)
{
    threeDiggit = threeDiggit/10;
}
if(threeDiggit>99)
{
    threeDiggit=threeDiggit%10;
    Console.WriteLine("Третья цифра случайно выбранного числа из заданного диапозона это:");
    Console.WriteLine(threeDiggit);
}
else
{
    Console.WriteLine("У значения нет третьего символа");
}


