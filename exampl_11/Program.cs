// See https://aka.ms/new-console-template for more information


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int InputInt()
{
    Console.WriteLine("Ведите целое число");
    bool isNum  = double.TryParse(Console.ReadLine(), out double num);
    if (isNum)
    {
        return (int)num;
    }
    else 
    {
        Console.WriteLine("Значение не корректное");
        return -1;
    }
}

double ax = InputInt();
double ay = InputInt();
double az = InputInt();
double bx = InputInt();
double by = InputInt();
double bz = InputInt();

double GetDistanceBetweenPoints (double ax, double ay,double az, double bx,double by,double bz) {
    double ab= Math.Sqrt((bx-ax)*(bx-ax)+(by-ay)*(by-ay)+(bz-az)*(bz-az));
    return ab;
}
double res = GetDistanceBetweenPoints(ax,ay,az,bx,by,bz);
Console.WriteLine(res);


