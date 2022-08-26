int firstDiggit = new Random().Next(1,10000000);
string firstDiggit_01 = firstDiggit.ToString();
char threeDiggit = firstDiggit_01[2];
Console.WriteLine(firstDiggit_01);
Console.WriteLine("Третья цифра случайно выбранного числа из заданного диапозона это: ");
Console.WriteLine(threeDiggit);