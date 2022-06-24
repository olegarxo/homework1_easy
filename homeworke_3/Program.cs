Console.Clear();
Console.WriteLine("Введите рост первого спортсмена");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите рост второго спортсмена");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите рост третьего спортсмена");
int numberTree = Convert.ToInt32(Console.ReadLine());
int[] growth = { numberOne, numberTwo, numberTree };
int temp;
for (int i = 0; i < growth.Length - 1; i++)
{
    for (int j = i + 1; j < growth.Length; j++)
    {
        if (growth[i] < growth[j])
        {
            temp = growth[i];
            growth[i] = growth[j];
            growth[j] = temp;
        }
    }
} 

Console.WriteLine("Вывод отсортированного массива");
for (int i = 0; i < growth.Length; i++)
{
    Console.WriteLine(growth[i]);};