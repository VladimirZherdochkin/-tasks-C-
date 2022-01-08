//Найти расстояние между точками в пространстве 2D/3D
class Point //класс, описывающий точку в пространстве
    {
        double x, y, z; //переменные для хранения ее координат
        
        public double X//свойства для получения данных из полей
        {
            get {return x;}
        }
        public double Y
        {
            get {return y;}
        }
        public double Z
        {
            get {return z;}
        }
 
        public Point(double x, double y, double z) //конструктор точки, в нем мы задаем значения
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
 
    }
    class Program
    {
 
        static double LengthSide(Point A, Point B)//метод, считающий длину отрезка в трехмерном пространстве
        {
            return Math.Sqrt(((B.X - A.X) * (B.X - A.X)) + ((B.Y - A.Y) * (B.Y - A.Y))+((B.Z - A.Z) * (B.Z - A.Z)));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x,y,z coordinates of first point");
            double x0 = double.Parse(Console.ReadLine());
            double y0 = double.Parse(Console.ReadLine());
            double z0 = double.Parse(Console.ReadLine());
            Point A = new Point(x0,y0,z0);
            Console.WriteLine("Enter x,y,z coordinates of second point");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double z1 = double.Parse(Console.ReadLine());
            Point B = new Point(x1, y1, z1);
            Console.WriteLine("Длина отрезка в декартовых координатах равна {0} чего-то там",LengthSide(A, B));
         
        }
        
    }