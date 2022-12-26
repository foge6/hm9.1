// Задача 64: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.
// 245
// int Shifting (int number){
// if (number/2==0 && number > 0) return 1;
// if (number/2==0 && number < 0) return -1;
// if (number % 2 == 1 || number %2 == -1)
// {
// System.Console.Write(Shifting (number/2));
// return 1;
// }
// else{
// System.Console.Write(Shifting(number/2));
// return 0;
// }
// }
// System.Console.WriteLine("Write number");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number != 0)
// System.Console.WriteLine(Shifting(number));
// else
// System.Console.WriteLine("Write number");


// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int Summ (int M, int N)
// {
// if (Math.Min(M,N) < Math.Max(M,N)){
// return Summ(Math.Min(M,N)+1,Math.Max(M,N)) + Math.Min(M,N);
// }
// else
// return Math.Max(M,N);
// }
// System.Console.WriteLine("Write number");
// int M = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Write number");
// int N = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Summ(M,N));