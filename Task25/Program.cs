// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4-> 16

Console.Clear();
Console.Write("Введите число A: ");
int numA = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int numB = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{Exponentiation(numA, numB)}");

int Exponentiation(int a, int b){
  int result = 1;
  for (int i = 1; i <= b; i++)
  {
    result *= a;
  }
  return result;
}
