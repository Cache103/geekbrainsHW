// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");

//Объявление массива
int[] arr = new int [5];
int bigNumber;
int del = 10000;
int index = 0;


System.Console.WriteLine("Введите пятизначное число: ");
bigNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = bigNumber / del % 10;
        del /= 10;
    }

if ((arr[index] == arr[arr.Length-1]) & (arr[index+1] == arr[arr.Length-2]))
    { System.Console.WriteLine("Число является палиндромом"); }
else
    { System.Console.WriteLine("Число не является палиндромом"); }



// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("");
Console.WriteLine("Программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

//Объявление переменных
char[] axis = { 'x','y','z' };
int[] arrA = new int[3];
int[] arrB = new int[3];
double[] powSum = new double[3];
double sum;
int idx = 0;

for (int i = 0; i < arrA.Length; i++)
    {
        System.Console.WriteLine($"Введите число {axis[i]}1: ");
        arrA[i] = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine($"Введите число {axis[i]}2: ");
        arrB[i] = Convert.ToInt32(Console.ReadLine());
        powSum[i] = Math.Pow(arrB[i] - arrA[i],2);
    }

sum = Math.Sqrt(powSum[idx] + powSum[idx+1] + powSum[idx+2]);

System.Console.WriteLine($"Результат: {Decimal.Round(Convert.ToDecimal(sum),2)}");


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("");
Console.WriteLine("Программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

System.Console.WriteLine("Введите число: ");
int num = Int32.Parse(Console.ReadLine());

for (int i=1; i<num+1; i++)
    {
        System.Console.WriteLine($"{Math.Pow(i,3)}");
    }