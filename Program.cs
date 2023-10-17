// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Вывод сообщения и запись введённых данных
string[] PromptStringArray(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    string[] values = value.Split(",");

    return values;
}

// Ищет элементы с длиной <= 3
string[] SearchForShortElements(string[] strings)
{
    int count = 0;

    for (int i = 0; i < strings.Length; i++)
    {
        count = strings[i].Length <= 3 ? count += 1 : count;
    }

    string[] newStrings = new string[count];
    int j = 0;

    for (int i = 0; i < strings.Length; i++)
    {
        if (strings[i].Length <= 3)
        {
            newStrings[j] = strings[i];
            j++;
        }
    }

    return newStrings;
}

// Выводит элементы массива в консоль
void OutputArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine(array[array.Length - 1] + "]");
}

// Получение массива от пользователя
string[] strings = PromptStringArray("Введите массив (элементы через запятую): ");

// Создание нового массива и вывод на экран
OutputArray(SearchForShortElements(strings));