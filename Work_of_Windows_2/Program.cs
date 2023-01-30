﻿// // Для сложения используйте символ +. 
// //  — вычитание;
// // * — умножение;
// // / — деление.

// int a = 18;
// int b = 6;
// int c = a + b;
// int c1 = a - b;
// int c2 = a * b;
// int c3 = a / b;
// Console.WriteLine(c);
// Console.WriteLine(c1);
// Console.WriteLine(c2);
// Console.WriteLine(c3);

// // Умножение и деление имеют приоритет над сложением и вычитанием

// int a = 5;
// int b = 4;
// int c = 2;
// int d = a + b * c;
// Console.WriteLine(d);

// // Можно применить другую последовательность операций. 
// // Для этого операции, которые должны выполняться первыми, нужно заключить в скобки:

// int a = 5;
// int b = 4;
// int c = 2;
// // int d = (a + b) * c;
// int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
// Console.WriteLine(d);

// // Деление целых чисел всегда дает результат в виде целого числа, 
// // даже если ожидаемый результат содержит десятичную или дробную часть.

// int a = 7;
// int b = 4;
// int c = 3;
// int d = (a + b) / c;
// Console.WriteLine(d);


// // В последнем примере вы увидели, что при делении целых чисел результат усекается.
// // Вы можете получить остаток с помощью оператора remainder, который обозначается символом %.


// int a = 7;
// int b = 4;
// int c = 3;
// int d = (a + b) / c;
// int e = (a + b) % c;
// Console.WriteLine($"quotient: {d}");
// Console.WriteLine($"remainder: {e}");

// Тип целых чисел C# характеризуется еще одним отличием от математических целых: 
// тип int имеет минимальные и максимальные ограничения.


// int max = int.MaxValue;
// int min = int.MinValue;
// Console.WriteLine($"The range of integers is {min} to {max}");

// // Если при вычислении выводится значение вне этих пределов, 
// // возникает условие потери значимости или переполнения. 
// // Ответ должен находиться в диапазоне от минимального до максимального значения. 
// // Добавьте эти две строки в интерактивное окно, чтобы увидеть пример:

// int what = max +  2147483646;
// Console.WriteLine($"An example of overflow: {what}");

// // Числовой тип double представляет число с плавающей запятой двойной точности. 

// double a = 5;
// double b = 4;
// double c = 2;
// double d = (a + b) / c;
// Console.WriteLine(d);

// double a = 19;
// double b = 23;
// double c = 8;
// double d = (a + b) / c;
// Console.WriteLine(d);

// // Диапазон значений типа double гораздо больше, чем диапазон значений целых чисел. 

// double max = double.MaxValue;
// double min = double.MinValue;
// Console.WriteLine($"The range of double is {min} to {max}");

// // Значения выводятся в экспоненциальном представлении. Число слева от символа E является значащим. 
// // Число справа — это показатель степени, который равен 10.

// // Так же, как десятичные числа в математике, значения double в 
// // C# могут содержать ошибки округления. Выполните этот код:

// double third = 1.0 / 3.0;
// Console.WriteLine(third);

// // Вы знаете, что 0.3 имеет значение 3/10 и не равняется 1/3. 
// // Аналогично 0.33 имеет значение 33/100. 
// // Это ближе к 1/3, но по-прежнему неточно.

// Тип decimal имеет меньший диапазон, но большую точность, чем double.

// decimal min = decimal.MinValue;
// decimal max = decimal.MaxValue;
// Console.WriteLine($"The range of the decimal type is {min} to {max}");

// // Обратите внимание, что диапазон меньше, чем для типа double. 
// // Вы можете убедиться в повышении точности при использовании типа decimal, выполнив следующий код:

// double a = 1.0;
// double b = 3.0;
// Console.WriteLine(a / b);

// // Суффикс M возле чисел указывает, что для константы должен использоваться тип decimal.
// // В противном случае компилятор предполагает тип double.

// decimal c = 1.0M;
// decimal d = 3.0M;
// Console.WriteLine(c / d);

// Задача

// Теперь, когда вы ознакомились с разными числовыми типами, 
// напишите код, который позволяет вычислить площадь круга с радиусом 2,50 см.
// Помните, что площадь круга равна квадрату радиуса, умноженному на число пи. 
// Подсказка: в .NET есть константа пи Math.PI, которую можно использовать. Math.PI, как и все константы, объявленные в пространстве имен System.Math, — это значение double. 
// По этой причине вместо значений decimal д
// ля этой задачи следует использовать double.

double a = 2.50;
double b = Math.PI;
double c = (a * a) * b;
Console.WriteLine(c);