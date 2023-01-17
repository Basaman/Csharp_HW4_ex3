
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Clear();

int lenght = GetArrayLenghtFromUser("Введите длину массива: ");
int[] array = GetArrayFromUser(lenght);

Console.Write($"{String.Join(", ", array)} -> [{String.Join(", ", array)}]");

int GetArrayLenghtFromUser(string lenghtMessage)
{
    Console.Write(lenghtMessage);
    int userInput = int.Parse(Console.ReadLine() ?? "");
    return userInput;
}

int[] GetArrayFromUser(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = GetNumberFromUser("Введите целое число: ", "Ошибка ввода! ");
    }
    return result;
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
