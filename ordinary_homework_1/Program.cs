﻿Console.WriteLine("Введите первое число!");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число!");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (numberOne > numberTwo){
    max = numberOne;   
}
else if (numberOne > numberTwo){
    max = numberTwo;   
}
Console.WriteLine($"Первое число {numberOne}, второе число {numberTwo} -> max={max} ");
