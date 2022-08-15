//Напишите программу, которая найдёт точку пересечения 
//двух прямых, заданных уравнениями y = k1 * x + b1, 
//y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите числа");
double GetUserInput(string letter)
{
    Console.WriteLine($"{letter}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double k1 = GetUserInput("k1");
double b1 = GetUserInput("b1");
double k2 = GetUserInput("k2");
double b2 = GetUserInput("b2");

void PointIntersectionLines( double k1, double b1, double k2, double b2)
{
    double x = Math.Round(((b2-b1)/(k1-k2)),1);
    double y = Math.Round((k1*x + b1),1);
    Console.WriteLine($"k1={k1},b1={b1},k2={k2},b2={b2} ->({x};{y})");
}
PointIntersectionLines(k1,b1,k2,b2);