﻿using System;

public class Answer {
    
  static int FindMax(int a, int b, int c)
    {
      // Введите свое решение ниже
        
int max = a; // Предполагаем, что максимальное значение изначально равно 'a'

        if (b > max)
        {
            max = b; // Если 'b' больше текущего максимума, обновляем максимум
        }

        if (c > max)
        {
            max = c; // Если 'c' больше текущего максимума, обновляем максимум
        }

        return max; // Возвращаем найденное максимальное значение

    }

  // Не удаляйте и не меняйте метод Main! 
  static public void Main(string[] args) {
        int a, b, c;

        if (args.Length >= 3) {
           a = int.Parse(args[0]);
           b = int.Parse(args[1]);
           c = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           a = 55;
           b = 0;
           c = 7;
        }

        // Не удаляйте строки ниже
        int result = FindMax(a, b, c);
        System.Console.WriteLine($"{result}");
    }
}