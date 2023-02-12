// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр {num} равна {SumNumber(num)}");

int SumNumber(int number){
  int sum = 0;
  while (number > 0)
  {
    sum = sum + number % 10;
    number = number / 10; 
  }
  return sum;
}


// Эталлонное решение

// int Promt(string message){
//   System.Console.Write(message);
//   string readInput = System.Console.ReadLine();
//   int result = int.Parse(readInput);
//   return result;
// }

// int SumALLDigit(int number){
//   int result = 0;
//   while (number > 0)
//   {
//     result += number % 10;
//     number = number / 10;
//   }
//   return result;
// }
// int number = Promt("Введите число: ");
// Console.WriteLine($"Сумма цифр {number} равна {SumALLDigit(number)}");