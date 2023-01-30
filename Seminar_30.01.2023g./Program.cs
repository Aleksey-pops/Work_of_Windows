// Даны числа 7 и 23

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int num1 = number %7;
int num2 = number % 23;

if (num1 == 0 && num2 == 0) Console.WriteLine("Число кратно 7 и 23");
else Console.WriteLine("Число не кратное 7 и 23");