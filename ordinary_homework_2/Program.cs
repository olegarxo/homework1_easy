//Первое решение
Console.WriteLine("Введите первое число!");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число!");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число!");
int numberTree = Convert.ToInt32(Console.ReadLine());
int max = numberOne;
if (max < numberTwo){
    max = numberTwo;
    if (max < numberTree){
        max = numberTree;
    }
}
    Console.WriteLine(max);
/*Второе решение
Console.Clear();
Console.WriteLine("Введите первое число!");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число!");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число!");
int numberTree = Convert.ToInt32(Console.ReadLine());
int[] max = {numberOne, numberTwo, numberTree};
int tamp;
for (int i=0; i<max.Length - 1; i++)
{
    for(int j=0; j<max.Length; j++)
    {

        if (max[i]>max[j])
        {
            tamp = max[i];
            max[i] = max[j];
            max[j] = tamp;
        }
    }
}
Console.WriteLine($"Первое число {numberOne}, второе число {numberTwo}, третье число {numberTree} -> max={max[0]} ");
*/