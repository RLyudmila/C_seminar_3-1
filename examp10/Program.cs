// See https://aka.ms/new-console-template for more information

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!
// 14212 -> нет
// 12821 -> да
// 23432 -> да


 int number = int.Parse(Console.ReadLine());

int number1 = number/1000;
int number2 = number%100;
int first = number1/10;
int last = number2%10;
int second = number1%10;
int penultimate = number2/10;
if ((first == last) & (second == penultimate))
{
    Console.WriteLine("Число является полиндромом");
}
else
{
    Console.WriteLine("Число НЕ является полиндромом");
}



