using ShapeObject.Entities;
using ShapeObject.Entities.Enums;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the number of shapes: ");
        int numberOfShapes = int.Parse(Console.ReadLine());
        List<Shape> shapes = new List<Shape>();

        for (int i = 1; i < numberOfShapes+1; i++)
        {
            Console.WriteLine($"Shape #{i} data: ");

            Console.Write("Rectangle or Circle (r/c)? ");
            char rc = char.Parse(Console.ReadLine());
            Console.Write("Color (Black/Blue/Red): ");
            Color color = Enum.Parse<Color>(Console.ReadLine());
            
            if (rc == 'r')
            {
                Console.Write("Width: ");
                double width = double.Parse(Console.ReadLine());
                Console.Write("Height: ");
                double height = double.Parse(Console.ReadLine());
                shapes.Add(new Rectangle(width, height, color));
            }
            else if (rc == 'c')
            {
                Console.WriteLine("Radius: ");
                double radius = double.Parse(Console.ReadLine());
                Shape circle = new Circle(radius, color);
                shapes.Add(new Circle(radius, color));
            }

        }
        Console.WriteLine("SHAPE AREAS: ");
        foreach (Shape item in shapes)
        {
            Console.WriteLine($"{item.Area().ToString("F2")}");
        }

    }
}