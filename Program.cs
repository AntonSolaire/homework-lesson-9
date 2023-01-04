// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// void PrintNumber(int n, int count)
// {
//     if (count > n) Console.WriteLine("Error");
//     else
//     {
//         PrintNumber(n, count + 1);
//         Console.Write(count + ", ");
//     }
// }

// Console.WriteLine("Введите N");
// int N = Convert.ToInt32(Console.ReadLine());
// int count = 2;
// PrintNumber(N, count);
// Console.Write(1);



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// void PrintSumm(int m, int n, int summ)
// {
//   summ = summ + n;
//   if (n <= m)
//   {
//     Console.Write($"Сумма элементов = {summ}");
//     return;
//   }
//   PrintSumm(m, n - 1, summ);
// }


// Console.WriteLine("Введите M");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите N");
// int n = Convert.ToInt32(Console.ReadLine());
// int temp = m;

// if (m > n) 
// {
//   m = n; 
//   n = temp;
// }

// PrintSumm(m, n, temp=0);



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akk(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Akk(m - 1, 1);
  else return Akk(m - 1, Akk(m, n - 1));
}


Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman = Akk(m, n);

Console.Write($"Функция Аккермана равна {Akkerman} ");