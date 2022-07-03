// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

void PrintArray (string [] array) //Метод для выводы массивов в консоль
{
    foreach (string Simvol in array)
        Console.Write($"{Simvol}, ");
    Console.WriteLine();
}

Console.Clear();
Console.Write("Введите массив строк, разделяя элементы запятой: ");
string DefaultData = Console.ReadLine() ?? "0"; //Вводим исходный массив одной строкой
string [] DefaultArray = DefaultData.Split(","); //Разделяем строки на исходный массив через запятую

int count = 0;
int i = 0;

foreach (string Simvol in DefaultArray) //создаем цикл для подсчета значения переменной count
    if (Simvol.Length <= 3)
        count++;

string [] NewArray = new string [count]; //Создание нового массива заданного размера

foreach (string Simvol in DefaultArray) //Заполнение нового массива элементами из трех и меньше символов из исходного массива
    if (Simvol.Length <= 3)
    {
        NewArray[i] = Simvol;
        i++;
    }

PrintArray(DefaultArray); //Вывод в консоль исходного массива для наглядного сравнения работы программы
PrintArray(NewArray); //Вывод в косноль нового массива как результат работы программы 