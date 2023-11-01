// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] array1 = new string[11] {"Hello", "2", "world", ":-)", "1234", "1567", "-2",
"computer science", "Russia", "Denmark", "Kazan"}; // Инициализация массива длиной 11 элементов.
string[] array2 = new string[array1.Length]; // Создание нового массива строк array2, который имеет ту же длину, что и array1.
// Объявление функции SecondArrayWithIF, которая принимает два параметра: array1 и array2.
void SecondArrayWithIF(string[] array1, string[] array2) 
{
    int count = 0; // Объявление переменной count и присваивание ей значения 0.
    // Начало цикла for, который будет выполняться, пока переменная i меньше длины массива array1.
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3) // Проверка, является ли длина текущего элемента массива array1 меньше или равной 3.
        {
        array2[count] = array1[i]; // Присваивание элементу массива array2 с индексом count...
        // ...значения текущего элемента массива array1.
        count++; // Увеличение значения переменной count на 1.
        }
    }
}
// Объявление функции PrintArray, которая принимает один параметр - массив строк.
void PrintArray(string[] array)
{
    // Цикл, который выполняет итерацию по заданным элементам в массиве.
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} "); // Вывод на экран текущего элемента массива array с помощью функции Console.Write.
    }
    Console.WriteLine(); // Вывод на экран символа пробела.
}
SecondArrayWithIF(array1, array2); // Вызов функции SecondArrayWithIF, передача ей массивов array1 и array2 в качестве параметров.
PrintArray(array2); // Вывод на экран отсортированного массива, длина которых менее 3х символов с помощью функции PrintArray.