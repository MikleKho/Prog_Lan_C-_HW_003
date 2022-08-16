// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
int[] Point_coordinates()
{
    int[] Coord = new int[3];
    string Temp = "";
    System.Console.Write("Введите координату X -> ");
    Temp = Console.ReadLine();
    Coord[0] = int.Parse(Temp);
    System.Console.Write("Введите координату Y -> ");
    Temp = Console.ReadLine();
    Coord[1] = int.Parse(Temp);
    System.Console.Write("Введите координату Z -> ");
    Temp = Console.ReadLine();
    Coord[2] = int.Parse(Temp);

    return Coord;
}

double Lenght_line_segment(int[] point_01, int[] point_02)
{
    double lenght = Math.Sqrt(Math.Pow((point_01[0] - point_02[0]), 2) +
                            Math.Pow((point_01[1] - point_02[1]), 2) +
                            Math.Pow((point_01[2] - point_02[2]), 2));
    return lenght;
}

int[] Point_01 = new int[3];
int[] Point_02 = new int[3];

System.Console.WriteLine("Введите координаты первой точки:");
Point_01 = Point_coordinates();

System.Console.WriteLine("Введите координаты второй точки:");
Point_02 = Point_coordinates();

double lenght_segment = Lenght_line_segment(Point_01, Point_02);
System.Console.WriteLine($"Длина отрезка равна  {Math.Round(lenght_segment, 2)}");

