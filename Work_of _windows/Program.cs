// //  Это простая программа, которая выводит сообщение "Hello World!". 
// // Для вывода используется метод Console.WriteLine. Console — это тип, 
// // который представляет окно консоли.Console.WriteLine("Hello, World!");

// Console.WriteLine("Hello World!");

// //В первой строке объявляется переменная aFriend, и ей назначается значение Bill. Вторая строка выводит имя.

// string aFriend = "Bill";
// Console.WriteLine(aFriend);

// aFriend = "Maira";
// Console.WriteLine(aFriend);

// Console.WriteLine("Hello " + aFriend);
// // Вы уже использовали + для создания строк из переменных и констант. Но есть способ лучше. 
// // Вы можете поместить переменную между символами { и }, чтобы код C# заменял этот текст значением переменной.

// Console.WriteLine($"Hello {aFriend}");

// //Между фигурными скобками можно указать более одной переменной. Попробуйте выполнить следующий код:

// string firstFriend = "Maria";
// string secondFriend = "Sage";
// Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

//  //Длину строки можно узнать с помощью Length

// Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
// Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

// // Предположим, что строки содержат начальные или конечные пробелы, которые не нужно отображать. 
// // Вам нужно обрезать эти лишние пробелы. 
// // Эту задачу выполняют метод Trim и связанные с ним методы TrimStart и TrimEnd.
// // Они просто удаляют из строки начальные и (или) конечные пробелы.

// string greeting = "      Hello World!       ";
// Console.WriteLine($"[{greeting}]");

// string trimmedGreeting = greeting.TrimStart();
// Console.WriteLine($"[{trimmedGreeting}]");

// trimmedGreeting = greeting.TrimEnd();
// Console.WriteLine($"[{trimmedGreeting}]");

// trimmedGreeting = greeting.Trim();
// Console.WriteLine($"[{trimmedGreeting}]");

// Метод Replace выполняет аналогичную задачу для строк. 
// Он находит некоторую подстроку и заменяет ее другим текстом. 
// Метод Replace принимает два параметра. 
// Это строки в скобках. Первая строка — это текст для поиска. 
// Вторая строка — это текст для замены. 

// string sayHello = "Hello World!";
// Console.WriteLine(sayHello);
// sayHello = sayHello.Replace("Hello", "Greetings");
// Console.WriteLine(sayHello);

// // Два других полезных метода преобразуют все буквы строки в прописные или строчные. 
// // Попробуйте следующий код: Введите его и наблюдайте, как IntelliSense предоставит подсказки при вводе To

// Console.WriteLine(sayHello.ToUpper());
// Console.WriteLine(sayHello.ToLower());

// Другая функция операции поиска и замены — поиск текста в строке. 
// Для поиска можно использовать Contains метод. 
// Он покажет, содержит ли строка подстроку. 
// Попробуйте выполнить код ниже, чтобы изучить Contains:

// string songLyrics = "You say goodbye, and I say hello";
// Console.WriteLine(songLyrics.Contains("goodbye"));
// Console.WriteLine(songLyrics.Contains("greetings"));

// // Существует два схожих метода (StartsWith и EndsWith) для поиска подстрок в строках.
// // С их помощью выполняется поиск подстроки в начале или конце строки. 
// // Попробуйте изменить пример выше таким образом, чтобы вместо
// // Containsиспользовались StartsWith и EndsWith.

// Console.WriteLine(songLyrics.StartsWith("You"));
// Console.WriteLine(songLyrics.EndsWith("You"));

// Console.WriteLine(songLyrics.EndsWith("hello"));
// Console.WriteLine(songLyrics.StartsWith("hello"));

string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.StartsWith("goodbye"));

Console.WriteLine(songLyrics.EndsWith("hello"));
Console.WriteLine(songLyrics.EndsWith("goodbye"));