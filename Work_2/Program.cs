// Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Введите пятизначное число: ");

int number = int.Parse(Console.ReadLine());

int firstNumber = number/10000;
int secondNumber = (number - firstNumber*10000)/1000;
int thirdNumber = (number - firstNumber*10000 - secondNumber*1000)/100;
int fourthNumber = (number - firstNumber*10000 - secondNumber*1000 - thirdNumber*100)/10;
int fifthNumber = (number - firstNumber*10000 - secondNumber*1000 - thirdNumber*100-fourthNumber*10);

if (firstNumber == fifthNumber && secondNumber == fourthNumber)
    Console.WriteLine("Вы ввели палиндром!");
else 
    Console.WriteLine("Число не палиндром"!);
    
// Console.WriteLine(firstNumber);
// Console.WriteLine(secondNumber);
// Console.WriteLine(thirdNumber);
// Console.WriteLine(fourthNumber);
// Console.WriteLine(fifthNumber);