Console.Clear();
Console.WriteLine("Введите первое число");
double numberOne = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Второе число");
double numberTwo = Convert.ToDouble(Console.ReadLine());
if (numberOne < numberTwo)
{
    double tempy = numberOne / numberTwo;
    Console.WriteLine($"Первое число поместиться {tempy} раз во втором числе");
}
else {

Console.WriteLine("Второе число всеже больше первого");

}