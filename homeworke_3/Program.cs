Console.Clear();
Console.WriteLine("Введите рост первого спортсмена");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите рост второго спортсмена");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите рост третьего спортсмена");
int numberTree = Convert.ToInt32(Console.ReadLine());
int[] growth = { numberOne, numberTwo, numberTree };
int temp;
if (numberOne > 0 && numberTwo > 0 && numberTree > 0)
{
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

Console.WriteLine("Рост спортсменов по убыванию ");
for (int i = 0; i < growth.Length; i++){ 
    Console.WriteLine(growth[i]);
    }
}
else{
       Console.WriteLine("Рост не может быть отрицательным");
}