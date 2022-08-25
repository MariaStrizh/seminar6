// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine ("Введите колличество чисел");
int M = Convert.ToInt32(Console.ReadLine());
int sum=0;
int[] arr=new int[M];
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine ($"Введите число {i+1} =" );
    int n = Convert.ToInt32(Console.ReadLine());
    arr[i]=n;
}
 for (int i = 0; i < arr.Length; i++)
{
 if (arr[i]>0)
    {
        sum = sum + 1 ;
    }
}
Console.WriteLine ($"Колличество положительных чисел = {sum}");