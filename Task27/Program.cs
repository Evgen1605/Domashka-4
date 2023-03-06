// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр {num} равна {SumNumber(num)}");

int SumNumber(int number){// создали функцию которая считает сумму цифр числа, например задали 123
  int sum = 0;// создали переменную которая изначально равна 0, после первой итерации sum = 3, после второй итерации 3+2=5 (sum = 5), третья 5+1=6 (sum = 6)
  while (number > 0)// циклом проверяем пока наше число больше 0 (123 > 0), после первой итерации число становиться (12 > 0), после второй (1 > 0), третья (0 > 0)- нет, заканчиваем цикл
  {
    sum +=  number % 10;// при каждом проходе (итерации) цикла в sum записывается последняя цифра числа (sum += 3), после второй итерации (sum += 2), после третей (sum += 1)
    number /= 10;// после последняя цифра удаляется из заданного числа (123 / 10 = 12), вторая итерация (12 / 10 = 1), третья (1 / 10 = 0)
  }
  return sum;// возвращаем результат цикла (sum = 6) 
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