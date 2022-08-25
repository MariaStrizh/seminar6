// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)//
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

// int[] arr=RandomArray (12,-10,10);
// можно так
const int SIZE=12;
const int LEFT_RANGE=-10;
const int RICHT_RANGE=10;
int[] arr=RandomArray (SIZE,LEFT_RANGE,RICHT_RANGE);

Console.WriteLine ($"Исходный массив {string.Join(",", arr)}");
ReverseArray(arr);
Console.WriteLine ($"Развернутый массив {string.Join(",", arr)}");

int [] RandomArray (int size, int leftRange, int rigthRange) // метод для создания массива
{
    int[] array=new int[size];
    Random rand=new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=rand.Next(leftRange, rigthRange+1);
    }
    return array;
}

void ReverseArray(int[] array) //метод переворачивания массива
{
    for (int i = 0; i < array.Length/2; i++)
    {
        int temp=array[i];
        array[i]=array[array.Length-1-i];
        array[array.Length-1-i]=temp;
    }
}