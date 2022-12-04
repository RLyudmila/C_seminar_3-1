// See https://aka.ms/new-console-template for more information

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
// Задание должно быть выполнено в методе и метод должен вернуть массив чисел.


int num = InputInt();
int[] cub = res(num);
PrintArray(cub);

int InputInt();
{
    Console.WriteLine("Введитее целое число");
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Некорректное значение");
        return -1;
    }
}


int[] res(int num)
{
int[]arr = new int[num];
for (int i=0; i<arr.Length; i++) {
    arr[i]= i*i*i;
    }
    return arr;

}

void PrintArray (int[] arr){
    for (int i=0; i< arr.Length; i++)
    {
        Console.WriteLine($"{arr[i]}, ");
    }
}
