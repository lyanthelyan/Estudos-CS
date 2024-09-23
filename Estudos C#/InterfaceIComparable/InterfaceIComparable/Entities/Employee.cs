
using System.Globalization;

namespace InterfaceIComparable.Entities
{
    internal class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee) 
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " +Salary.ToString("F2", CultureInfo.InvariantCulture) ;
        }

        public int CompareTo(object obj)//Vou querer comparar dois funcionarios por nome, quando um funcionario for alfabeticamente maior que o outro
        {
            if (!(obj is Employee)) // Se o obj não for da classe Employee vai dar erro
            {
                throw new ArgumentException("COMPARING ERROR: ARGUMENT IS NOT AN EMPLOYEE");
            }
            Employee other = obj as Employee; //Criei apenas um objeto
            return Salary.CompareTo(other.Salary) ; //Comparando por salario
        }
    }
}
