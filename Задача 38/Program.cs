//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
double[] FillArrayWithRandom(double[] array)
{
    Random x = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(x.Next(0, 100) / 10.0); 
    }
    return array;
}

double[] array = new double[5];
array=FillArrayWithRandom(array);
Console.WriteLine("["+string.Join(" ; ", array) + "]");
double max = 0 ;
double min = 0 ;
for (int i = 0; i < array.Length; i++)
{
    if (max<=array[i])
    {
       max = array[i] ;
    }
}
for (int i = 0; i < array.Length; i++)
{
    if (max<=array[i])
    {
       max = array[i] ;
    }
}
min = max;
for (int i = 0; i < array.Length; i++)
{
    if (min>array[i])
    {
       min = array[i] ;
    }
}
Console.WriteLine("Максимальная число ="+max);
Console.WriteLine("Минимальная число = " + min);
double sum = max - min;
Console.WriteLine("Разница между максимальным и минимальным элементов массива = "+sum);
