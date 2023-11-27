// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100.
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90]

// int[] FillArray(int size)
// {
// int[] array = new int[size];
// for(int i = 0; i < array.Length; i++)
// {
// array[i] = new Random().Next(1, 101);
// }
// return array;
// }

// void PrintArray(int[] InMass)
// {
// Console.Write("Массив с элементами: ");
// for(int i = 0; i < InMass.Length; i++)
// {
// Console.Write(InMass[i] + " ");
// }
// }

// void Filter(int[] num)
// {
// int[] n = new int[num.Length];
// Console.WriteLine();
// Console.Write("Элементы массива, значения которых лежат в отрезке [20, 90]: ");

// for (int i = 0; i < num.Length; i++)
// {
// if (num[i] >= 20 && num[i] <= 90)
// {
// Console.Write(num[i] + " ");
// n[i] = num[i];
// }
// }
// int countWithoutZeros = n.Count(x => x != 0);
// Console.WriteLine();
// Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [20,90]: {countWithoutZeros}");
// }

// int sizeMass = 10;
// int[] mass = FillArray(sizeMass);
// PrintArray(mass);
// Filter(mass);


// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, 
// которая определяет количество чётных чисел в массиве.

int[] FillArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 1001);
    }
    return array;
}

void PrintArray(int[] InMass)
{
    Console.Write("Массив с элементами: ");
    for(int i = 0; i < InMass.Length; i++)
    {
        Console.Write(InMass[i] + " ");
    }
}

void fevenNumbers(int[] num) 
{
    int[] n = new int[num.Length];
    Console.WriteLine(); 
    Console.Write("Элементы массива, значения которых четное: "); 
    int countWithoutZeros = 0;

    for (int i = 0; i < num.Length; i++) {
        if (num[i] % 2 == 0) {
            Console.Write(num[i] + " ");
            n[countWithoutZeros] = num[i];
            countWithoutZeros++;
        }
    }

    Console.WriteLine();
    Console.WriteLine($"Количество чётных чисел в массиве: {countWithoutZeros}");
}

int sizeMass = 10;
int[] mass = FillArray(sizeMass);
PrintArray(mass);
fevenNumbers(mass);