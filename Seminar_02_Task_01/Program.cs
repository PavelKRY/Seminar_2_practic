int firstDiggit = new Random().Next(100,1000);

int secondDiggit = (firstDiggit/10)%10;
Console.WriteLine(secondDiggit + " - Второе число случайно сгенерированного трёхзначного числа");