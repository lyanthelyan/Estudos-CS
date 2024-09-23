using AbstractInterface.Models.Enum;

namespace AbstractInterface.Models.Entities
{
    abstract class AbstractShape : IShape
    {

        public Color Color { get; set; }

        public abstract double Area();
    }
}
