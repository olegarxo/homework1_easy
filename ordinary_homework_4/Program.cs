/*Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int [] tamp = { };
for (int i = 0; i <= number; i++){
    tamp[i] = 0 + i;
}
for (int j = 0; j <= number; j++){
    if (tamp[j] %2 ==1 )
    Console.WriteLine(tamp[j]);
}
*/
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 ==0){
    for (int i = 2; i <= number;i+=2)
    Console.Write($"{i },");
}
else{
    for (int j = 1; j <= number;j+=2)
    Console.Write($"{j },");
}