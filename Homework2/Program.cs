//double x1 = PrintAndGetValue("Введите координату первой точки по оси Х");
//double y1 = PrintAndGetValue("Введите координату первой точки по оси Y");
//double z1 = PrintAndGetValue("Введите координату первой точки по оси Z");
//double x2 = PrintAndGetValue("Введите координату второй точки по оси Х");
//double y2 = PrintAndGetValue("Введите координату второй точки по оси Y");
//double z2 = PrintAndGetValue("Введите координату второй точки по оси Z");
//Console.WriteLine("Длина отрезка = " + PrintAndGetResult(x1, x2, y1, y2, z1, z2));
        
//double PrintAndGetValue(string message)
//{
    //Console.WriteLine(message);
    //double input = double.Parse(Console.ReadLine());
    //return input;
//}

//double PrintAndGetResult(double x1, double x2, double y1, double y2, double z1, double z2)
//{
    //double result = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));
    //return result;
//}





string[] point1 = PrintAndGetValue1("Введите координаты первой точки");
string[] point2 = PrintAndGetValue2("Введите координаты второй точки");
Console.WriteLine(String.Join(", ", point1));
Console.WriteLine(String.Join(", ", point2));
double x1 = Double.Parse(point1[0]);
double x2 = Double.Parse(point2[0]);
double y1 = Double.Parse(point1[1]);
double y2 = Double.Parse(point2[1]);
double z1 = Double.Parse(point1[2]);
double z2 = Double.Parse(point2[2]);
Console.WriteLine("Длина отрезка = " + PrintAndGetResult(x1, x2, y1, y2, z1, z2));


static string[] PrintAndGetValue1(string message)
{
    Console.WriteLine(message);
    Console.WriteLine("Введите координату первой точки по оси Х");
    int x1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату первой точки по оси Y");
    int y1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату первой точки по оси Z");
    int z1 = int.Parse(Console.ReadLine());
    int[] array1 = new int[3];
    array1[0] = x1;
    array1[1] = y1;
    array1[2] = z1;
    string[] result1 = array1.Select(i => i.ToString()).ToArray();
    return result1;
}


static string[] PrintAndGetValue2(string message)
{
    Console.WriteLine(message);
    Console.WriteLine("Введите координату второй точки по оси Х");
    int x2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату второй точки по оси Y");
    int y2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату второй точки по оси Z");
    int z2 = int.Parse(Console.ReadLine());
    int[] array2 = new int[3];
    array2[0] = x2;
    array2[1] = y2;
    array2[2] = z2;
    string[] result2 = array2.Select(i => i.ToString()).ToArray();
    return result2;
}


double PrintAndGetResult(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double result = Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2) + Math.Pow(z1 - z2,2));
    return result;
}