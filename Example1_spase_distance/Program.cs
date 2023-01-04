//Даны координаты двух точек в пространстве, требуется найти расстояние между ними.

double ReadValueFromConsole(string message)
    {
        System.Console.WriteLine(message);
        double value = Convert.ToInt32(Console.ReadLine());
        return value;
    }
    double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
    {
    return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    }
     double x1 = ReadValueFromConsole("x1 = ");
     double y1 = ReadValueFromConsole("y1 = ");
     double z1 = ReadValueFromConsole("z1 = ");
     double x2 = ReadValueFromConsole("x2 = ");
     double y2 = ReadValueFromConsole("y2 = ");
     double z2 = ReadValueFromConsole("z2 = ");

System.Console.WriteLine(Math.Round(FindDistance(x1, y1, z1, x2, y2, z2), 3));