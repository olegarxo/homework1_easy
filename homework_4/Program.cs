Console.WriteLine("Введите количество секунд");
int newSecond = Convert.ToInt32(Console.ReadLine());
int minuts = newSecond /60 ;
int newSecondNext = newSecond % 60;
int hourse = minuts /60;
int minutsNext = minuts % 60;
Console.WriteLine($"{newSecond} секунд это: {hourse} часов,{minutsNext} минут, {newSecondNext} секунд");