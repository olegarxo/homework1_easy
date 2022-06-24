Console.Clear();
Console.WriteLine("Введите число!");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (number >=0)
{
 Console.Write($"Вы ввели {number} получите ");
   while (count < number)
   {
    Console.Write($"1 ");
    count+=1;
    }

}
else {

Console.WriteLine("Вы ввели отрицательное число");

}
/*Console.Clear();
Console.WriteLine("Введите число!");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (count < number){

    Console.WriteLine("1 ");
    count+=1;
}*/
