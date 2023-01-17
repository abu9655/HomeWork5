// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] FillArrayWithRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

int[] array = new int [10];
array=FillArrayWithRandom(array);
Console.Write("["+string.Join(",", array));
int sum = array[1];
for (int i = 3 ; i<array.Length;i=i+2)
{
    sum=sum+array[i];
    
}
Console.Write("] ->" +sum);
