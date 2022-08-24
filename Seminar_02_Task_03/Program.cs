Console.WriteLine("Введите цифру, соответствующую дню недели (например-Понедельник=1) :");
int inputA = Int32.Parse(Console.ReadLine());


if(inputA < 8)
switch(inputA)
{
    case 1:
    Console.WriteLine("не является выходным днём");
    break;
    case 2:
    Console.WriteLine("не является выходным днём");
    break;
    case 3:
    break;
    Console.WriteLine("не является выходным днём");
    break;
    case 4:
    Console.WriteLine("не является выходным днём");
    break;
    case 5:
    Console.WriteLine("не является выходным днём");
    break;
    //
    //Закомментировал это решение,
    //думаю что то, что вошло в код корректнее, хоть и длинее
    //(не включает в себя if, default и else)
    //
    //case 6:
    //Console.WriteLine("является выходным днём");
    //break;
    //case 7:
    //Console.WriteLine("является выходным днём");
    //break;
//}

    default:
    Console.WriteLine("Является выходным днём");
    break;
}
else
{
    Console.WriteLine("Вы ввели неподходящее число, введите число от 1 до 7");
}

