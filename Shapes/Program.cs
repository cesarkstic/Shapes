// See h// Program.cs
using System.Diagnostics.CodeAnalysis;

namespace Shapes
{
    [ExcludeFromCodeCoverage]
    class Program
    {
        private static readonly List<IShapes> ShapeList = new List<IShapes>();
        private static readonly List<IShapes> WrongShapeList = new List<IShapes>();

        static void Main(string[] args)
        {

            ShapeList.AddRange(new IShapes[]
            {
                new Circle ("Circle 1", "Red", 3),
                new Rectangle ("Rectangle 1", "Blue", 4, 3),
                new Square ("Square 1", "White", 5),
                new Circle ("Circle 2", "Green", 30),
                new Rectangle ("Rectangle 2", "Yellow", 40, 30),
                new Square ("Square 2", "Black", 50)
            });

            foreach (var shape in ShapeList)
            {
                Console.WriteLine(shape.Draw());
            }

            var areaLargerThan50 = ShapeList.Where(s => s.Area() > 50)
                                            .OrderByDescending(s => s.Area());

            foreach (var shape in areaLargerThan50)
            {
                Console.WriteLine($"Area larger than 50: {shape.Draw()}");
            }

            try
            {
                ShapeList.AddRange(new IShapes[]
                {
                    new Circle ("Circle 3", "Brown", -3),
                    /*
                    new Rectangle ("Rectangle 1", "Cyan", -4, 3),
                    new Square ("Square 1", "Grey", -5),
                    new Rectangle ("Rectangle 3", "Orange", 4, -3),
                    */
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine("End of program");
        }
    }
}
