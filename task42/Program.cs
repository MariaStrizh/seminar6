// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10
Console.WriteLine ("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

void GetBinaruView(int N)
{
    if (N==0) return;
    GetBinaruView(N/2);
    Console.Write(N%2);
}
GetBinaruView(number);