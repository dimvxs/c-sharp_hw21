// See https://aka.ms/new-console-template for more information

// Создайте анонимный метод для получения RGB значения для цвета радуги. 
// Цвет радуги передаётся в качестве параметра. Напишите код для тестирования 
// работы метода.


using hw;

delegate void Color(string color);
delegate int ArrDel(int[] array);

delegate bool CheckWord(string text, string word);


class Program
{
    static void Main()
    {
       
// Color changeColor = delegate(string color){ //анонимная функция

// switch(color){
//                 case "red":
//                      Console.ForegroundColor = ConsoleColor.Red;
//                      Console.WriteLine("red \n");
//                         break;
//                 case "magenta":
//                         Console.ForegroundColor = ConsoleColor.Magenta;
//                         Console.WriteLine("magenta \n");
//                         break;
//                 case "yellow":
//                         Console.ForegroundColor = ConsoleColor.Yellow;
//                         Console.WriteLine("yellow \n");
//                      break;
//                 case "green":
//                         Console.ForegroundColor = ConsoleColor.Green;
//                         Console.WriteLine("green \n");
//                       break;
//                 case "blue":
//                         Console.ForegroundColor = ConsoleColor.Blue;
//                         Console.WriteLine("blue \n");
//                         break;
//                 case "dark magenta":
//                         Console.ForegroundColor = ConsoleColor.DarkMagenta;
//                         Console.WriteLine("dark magenta \n");
//                          break;
//                 case "dark cyan":
//                         Console.ForegroundColor = ConsoleColor.DarkCyan;
//                         Console.WriteLine("dark cyan \n");
//                        break;
//                 default:
//                     Console.WriteLine("неизвестный цвет \n");
//                       break;
//             }
// };

// changeColor("red");
// changeColor("magenta");
// changeColor("yellow");
// changeColor("green");
// changeColor("blue");
// changeColor("dark magenta");
// changeColor("dark cyan");


// // Задание 3
// // Создайте лямбда-выражение для подсчёта количества чисел в массиве, кратных семи. Напишите код для тестирования работы лямбды.

// ArrDel GetSum = (int[] array) => {
//     int count = 0;
// foreach(int el in array){
// if(el % 7 == 0){
// count++;
// }
// }

// return count;

// };

// int[] array = {7, 14, 21, 28, 35, 42, 49, 56, 63, 70, 77, 84, 91, 98};
// int result = GetSum(array);
// Console.Write("aliquot 7 count: " + result + "\n");


// // Задание 4
// // Создайте лямбда-выражение для подсчёта количества положительных чисел в массиве. Напишите код для тестирования работы лямбды.

// ArrDel Positive = (int[] array) => {
// int count = 0;
// foreach(int el in array){
//     if(el > 0){
//         count++;
//     }
// }
// return count;
// };

// int[] array1 = {7, 14, 21, 28, 35, 42, 49, 56, 63, 70, 77, 84, 91, 98};
// int result1 = Positive(array1);
// Console.Write("positive count: " + result1 + "\n");

// // Задание 5
// // Создайте лямбда-выражение для отображения уникальных отрицательных чисел в массиве. Напишите код для тестирования работы лямбды.


// ArrDel Unique = (int[] array) => {
//     int count = 0;
//  bool[] isVisited = new bool[array.Length];  // Массив для отслеживания посещенных чисел

//             for (int i = 0; i < array.Length; i++)
//             {
//                 if (array[i] < 0 && !isVisited[i])  // Проверяем, что число отрицательное и еще не было учтено
//                 {
//                     // Проверяем, уникально ли это число среди предыдущих
//                     bool isUnique = true;
//                     for (int j = 0; j < i; j++)
//                     {
//                         if (array[i] == array[j])  // Если число повторяется, оно не уникально
//                         {
//                             isUnique = false;
//                             break;
//                         }
//                     }

//                     if (isUnique)
//                     {
//                         count++;  // Если уникальное, увеличиваем счетчик
//                     }
                    
//                     // Отмечаем число как посещенное
//                     isVisited[i] = true;
//                 }
//             }
//             return count;

// };

// int[] array2 = {7, 14, 21, 28, 35, 42, 49, 56, 63, 70, 77, 84, 91, 98};
// int result2 = Unique(array2);
// Console.Write("unique count: " + result2 + "\n");

// // Задание 6
// // Создайте лямбда-выражение для проверки есть ли в тексте заданное слово. Напишите код для тестирования работы лямбды.


// string text = "this is cool text";
// string word = "is";

// CheckWord check = (text, word) => text.Contains(word);

// bool result7 = check(text, word);
// Console.Write("result: " + result7 + "\n");



Bag myBackpack = new Bag("Черный", "Nike", "Нейлон", 1.2, 30.0, 5);

            // Создаем предметы
            Item item1 = new Item("Книга", 5.0);  // Книга, 5 литров
            Item item2 = new Item("Ноутбук", 7.0);  // Ноутбук, 7 литров
            Item item3 = new Item("Флешка", 1.0);  // Флешка, 1 литр
            Item item4 = new Item("Наушники", 2.0);  // Наушники, 2 литра

            // Пробуем добавить предметы в рюкзак
            try
            {
                myBackpack.AddItemToBag(item1);  // Добавляем книгу
                myBackpack.AddItemToBag(item2);  // Добавляем ноутбук
                myBackpack.AddItemToBag(item3);  // Добавляем флешку
                myBackpack.AddItemToBag(item4);  // Добавляем наушники
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);  // Выводим ошибку, если рюкзак переполнен
            }
        
}
}
